﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sync.Data;
using Sync.Models;

namespace Sync.Areas.admin.Controllers
{
    [Area("admin")]
    public class SettingsController : Controller
    {
        private readonly SyncContext _context;

        public SettingsController(SyncContext context)
        {
            _context = context;
        }

        // GET: admin/Settings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Setting.ToListAsync());
        }

        // GET: admin/Settings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setting = await _context.Setting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (setting == null)
            {
                return NotFound();
            }

            return View(setting);
        }

        // GET: admin/Settings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/Settings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Logo,About,Address,Mail,Phone")] Setting setting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(setting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(setting);
        }

        // GET: admin/Settings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setting = await _context.Setting.FindAsync(id);
            if (setting == null)
            {
                return NotFound();
            }
            return View(setting);
        }

        // POST: admin/Settings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Logo,About,Address,Mail,Phone")] Setting setting)
        {
            if (id != setting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(setting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SettingExists(setting.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(setting);
        }

        // GET: admin/Settings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setting = await _context.Setting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (setting == null)
            {
                return NotFound();
            }

            return View(setting);
        }

        // POST: admin/Settings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var setting = await _context.Setting.FindAsync(id);
            _context.Setting.Remove(setting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SettingExists(int id)
        {
            return _context.Setting.Any(e => e.ID == id);
        }
    }
}
