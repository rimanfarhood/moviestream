using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStream.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieStream.Models;

namespace MovieStream.Controllers
{
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }
        [HttpGet("movie")]

        [HttpGet("index")]
        public async Task<IActionResult> Index(string searchString)
        {
            Console.WriteLine($"Search String: {searchString}");
            var movies = _context.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m =>
                    m.Title.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(movie);
        }
        [HttpGet("details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        [HttpGet("edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        [HttpPost("edit")]
        public async Task<IActionResult> Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            _context.Update(movie);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet("delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            var movie = await _context.Movies.FindAsync(id);

            return View(movie);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            _context.Movies.Remove(movie);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}