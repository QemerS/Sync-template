using System;
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
    public class SocialsController : Controller
    {
        private readonly SyncContext _context;

        public SocialsController(SyncContext context)
        {
            _context = context;
        }

        // GET: admin/Socials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Social.ToListAsync());
        }

        // GET: admin/Socials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var social = await _context.Social
                .FirstOrDefaultAsync(m => m.ID == id);
            if (social == null)
            {
                return NotFound();
            }

            return View(social);
        }

        // GET: admin/Socials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/Socials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Link")] Social social)
        {
            if (ModelState.IsValid)
            {
                _context.Add(social);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(social);
        }

        // GET: admin/Socials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var social = await _context.Social.FindAsync(id);
            if (social == null)
            {
                return NotFound();
            }
            return View(social);
        }

        // POST: admin/Socials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Link")] Social social)
        {
            if (id != social.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(social);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialExists(social.ID))
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
            return View(social);
        }

        // GET: admin/Socials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var social = await _context.Social
                .FirstOrDefaultAsync(m => m.ID == id);
            if (social == null)
            {
                return NotFound();
            }

            return View(social);
        }

        // POST: admin/Socials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var social = await _context.Social.FindAsync(id);
            _context.Social.Remove(social);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialExists(int id)
        {
            return _context.Social.Any(e => e.ID == id);
        }
    }
}
