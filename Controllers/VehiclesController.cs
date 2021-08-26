using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage2._0G6.Data;
using Garage2._0G6.Models;
using Garage2._0G6.Models.ViewModels;

namespace Garage2._0G6.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly Garage2_0G6Context _context;
        private readonly IVehicleRepository _vehicleRepository;
        private const int sizeLimit = 35;

        public VehiclesController(Garage2_0G6Context context, IVehicleRepository vehicleRepository)
        {
            _context = context;
            _vehicleRepository = vehicleRepository;
        }

        //GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var indexVM = new IndexViewModel
            {
                FreeSpaces = sizeLimit - _context.Vehicle.Count()
            };

            return View(indexVM);
        }

        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index2(string regnum = null) // HTML input name="regnum"
        {
            var model = _context.Vehicle.Select(v => new VehicleViewModel
            {
                Id = v.Id,
                Regnum = v.Regnum,
                Model = v.Model,
                Arrivaldate = v.Arrivaldate,
                ParkedTime = (DateTime.Now - v.Arrivaldate)
            }
            
            );
            model = regnum == null ?
                model :
                //model.Where(v => v.Regnum == regnum); EXACT MATCH
                model.Where(v => v.Regnum.Contains(regnum));
            //Todo Not FOUND add

            if (model.Count() == 0)
            {
                TempData["Empty"] = "Registration number could not be found";
                Console.WriteLine("funkar");
            }

            return View(model);
        }

        public async Task<IActionResult> Receipt(int? id) // HTML input name="regnum"
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            var model = new ReceiptViewModel
            {
                Id = vehicle.Id,
                Regnum = vehicle.Regnum,
                Model = vehicle.Model,
                Arrivaldate = vehicle.Arrivaldate,
                Leavingdate = DateTime.Now,
                ParkingTime = (DateTime.Now - vehicle.Arrivaldate),
                Price = ((short)(DateTime.Now - vehicle.Arrivaldate).TotalMinutes) * 1
            };

            //model = regnum == null ?
            //    model :
            //    //model.Where(v => v.Regnum == regnum); EXACT MATCH
            //    model.Where(v => v.Regnum.Contains(regnum));


            return View("Receipt", model);
        }



        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            if (_context.Vehicle.Count() >= sizeLimit)
            {
                TempData["Error"] = $"Garage is full";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Type,Regnum,Color,Brand,Model,Wheel,Arrivaldate")] Vehicle vehicle)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(vehicle);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(vehicle);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Regnum,Color,Brand,Model,Wheel")] Vehicle vehicle) 
        //public async Task<IActionResult> Create([Bind("Id,Type,Regnum,Color,Brand,Model,Wheel")] VehicleCreateModel createVehicle)
        {

            if (ModelState.IsValid)
            {
                bool unique = true;

                var duplicates = _context.Vehicle
                    .Where(v => v.Regnum.Contains(vehicle.Regnum))
                    .Select(v => v)
                    .ToList();

                if (duplicates.Count() > 0)
                {
                    unique = false;
                }

                if (unique)
                {
                    vehicle.Arrivaldate = DateTime.Now;

                    TempData["Success"] = $"Vehicle {vehicle.Regnum} successfully parked";

                    vehicle.Regnum = vehicle.Regnum.ToUpper();

                    _context.Add(vehicle);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("Regnum", "Registration number must be unique");
                    return View(vehicle);
                }
            }
            return View(vehicle);

            // TODO Fungerar Men Exponerar en Vehicle istället för VehicleCreateModel
            //    Vehicle vehicle = new();
            //    vehicle.Id = createVehicle.Id;
            //    vehicle.Type = createVehicle.Type;
            //    vehicle.Regnum = createVehicle.Regnum;
            //    vehicle.Color = createVehicle.Color;
            //    vehicle.Brand = createVehicle.Brand;
            //    vehicle.Model = createVehicle.Model;
            //    vehicle.Wheel = createVehicle.Wheel;
            //    vehicle.Arrivaldate = DateTime.Now;
            //    _context.Add(vehicle);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //    return View(createVehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Regnum,Color,Brand,Model,Wheel,Arrivaldate")] Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["Success"] = $"Vehicle {vehicle.Regnum} successfully edited";
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            TempData["Success"] = $"Vehicle {vehicle.Regnum} successfully collected";
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.Id == id);
        }

        [HttpGet]
        [Route("List")]
        public IActionResult List()
        {
            var list = new ListViewModel
            {
                VehicleList = _context.Vehicle.Select(v => new VehiclesListViewModel
                {
                    Id = v.Id,
                    Type = v.Type,
                    Regnum = v.Regnum,
                    Arrivaldate = v.Arrivaldate
                }),

                VehicleCount = _vehicleRepository.GetVehicleCount(),
                WheelCount = _vehicleRepository.GetWheelCount(),
                Revenue = _vehicleRepository.GetRevenue(),

                CarCount = _vehicleRepository.GetVehicleAmount(VehicleType.Car),
                BusCount = _vehicleRepository.GetVehicleAmount(VehicleType.Bus),
                BoatCount = _vehicleRepository.GetVehicleAmount(VehicleType.Boat),
                MotorcycleCount = _vehicleRepository.GetVehicleAmount(VehicleType.Motorcycle),
                AirplaneCount = _vehicleRepository.GetVehicleAmount(VehicleType.Airplane)
            };

            //var product = _context.Vehicle.Select(v => new VehiclesListViewModel
            //{
            //    Id = v.Id,
            //    Type = v.Type,
            //    Regnum = v.Regnum,
            //    Arrivaldate = v.Arrivaldate
            //});

            //ViewBag.vehicleCount = _vehicleRepository.GetVehicleCount();
            //ViewBag.wheelCount = _vehicleRepository.GetWheelCount();
            //ViewBag.revenue = _vehicleRepository.GetRevenue();

            return View(list);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            var vehicle = _vehicleRepository.GetVehicleById(id);

            return View(vehicle);
        }
    }
}
