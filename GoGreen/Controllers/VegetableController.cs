using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoGreen.Data;
using GoGreen.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoGreen.Controllers
{
    public class VegetableController : Controller
    {
        private readonly VegetableContext _context;

        public VegetableController(VegetableContext context)
        {
            _context = context;
        }

        // GET: Vegetable
        public async Task<IActionResult> Index(int? id, string? search, bool isapi=false)
        {
            var vegetables = from vegetable in _context.Vegetable
                         select vegetable;

            if (!(id == null))
            {
                vegetables = vegetables.Where(vegetable => vegetable.Id == id);
            }

            if (!String.IsNullOrEmpty(search))
            {
                vegetables = vegetables.Where(vegetable => vegetable.Name.Contains(search));
            }

            ViewData["id"] = id;
            ViewData["search"] = search;

            if (isapi) {
                return Json(await vegetables.ToListAsync());
            }

            return View(await vegetables.ToListAsync());
        }

        // GET: Vegetable/Details/5
        public async Task<IActionResult> Details(int? id, bool isapi = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vegetable == null)
            {
                return NotFound();
            }

            if (isapi)
            {
                return Json(vegetable);
            }

            return View(vegetable);
        }

        // GET: Vegetable/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vegetable/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken] //disabled to better centralize API
        public async Task<IActionResult> Create([Bind("Name,Price")] Vegetable vegetable, bool isapi = false)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vegetable);
                await _context.SaveChangesAsync();
                if (isapi)
                {
                    return Json(vegetable);
                }
                return RedirectToAction(nameof(Index));
            }

            if (isapi)
            {
                var errorList = ModelState.Values.SelectMany(v => v.Errors).ToList();
                return StatusCode((int)System.Net.HttpStatusCode.MethodNotAllowed, errorList);
            }
            return View(vegetable);
        }

        // GET: Vegetable/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetable.FindAsync(id);
            if (vegetable == null)
            {
                return NotFound();
            }
            return View(vegetable);
        }

        // POST: Vegetable/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken] //disabled to better centralize API
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] Vegetable vegetable, bool isapi = false)
        {
            if (id != vegetable.Id)
            {
                if (isapi)
                {
                    return StatusCode((int)System.Net.HttpStatusCode.NotFound);
                }
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vegetable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VegetableExists(vegetable.Id))
                    {
                        if (isapi)
                        {
                            return StatusCode((int)System.Net.HttpStatusCode.NotFound);
                        }
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                if (isapi)
                {
                    return Json(vegetable);
                }
                return RedirectToAction(nameof(Index));
            }

            if (isapi)
            {
                var errorList = ModelState.Values.SelectMany(v => v.Errors).ToList();
                return StatusCode((int)System.Net.HttpStatusCode.MethodNotAllowed, errorList);
            }
            return View(vegetable);
        }

        // GET: Vegetable/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vegetable == null)
            {
                return NotFound();
            }

            return View(vegetable);
        }

        // POST: Vegetable/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken] //disabled to better centralize API
        public async Task<IActionResult> DeleteConfirmed(int id, [Bind("Id")] Vegetable _vegetable, bool isapi = false)
        {
            try
            {
                if (isapi)
                {
                    id = _vegetable.Id;
                }
                var vegetable = await _context.Vegetable.FindAsync(id);
                _context.Vegetable.Remove(vegetable);
                await _context.SaveChangesAsync();

                if (isapi)
                {
                    return Json(vegetable);
                }
                return RedirectToAction(nameof(Index));
            } catch (Exception ex)
            {
                if (isapi)
                {
                    return StatusCode((int)System.Net.HttpStatusCode.NotFound);
                }
                return RedirectToAction(nameof(Index));
            }
        }

        private bool VegetableExists(int id)
        {
            return _context.Vegetable.Any(e => e.Id == id);
        }
    }
}
