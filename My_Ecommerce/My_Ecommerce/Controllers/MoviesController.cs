using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Ecommerce.DBContext;
using My_Ecommerce.Models.PracticeModel;

namespace My_Ecommerce.Controllers
{
    public class MoviesController : Controller
    {
        private readonly EcommerceDbContext _context;
        //private readonly MovieRepository _repository;

        public MoviesController(EcommerceDbContext context)
        {
            _context = context;
            //_repository = repository;
        }

        public async Task<IActionResult> Index(string? searchText)
        {
            var datalist = _context.Movie;
            var movies = from m in datalist select m;

            if (!String.IsNullOrEmpty(searchText))
            {
                movies = movies.Where(s => s.Title!.Contains(searchText));
            }

            return View(await movies.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            var datalist = await _context.Movie.ToListAsync();

            if (id == null || datalist == null)
            {
                return NotFound();
            }

            var movie = (id > 0) ? datalist.FirstOrDefault(c => c.Id == id) : null;
            
            //var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
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
            return View(movie);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return Problem("Entity set 'EcommerceDbContext.Movie'  is null.");
            }


            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
          return _context.Movie.Any(e => e.Id == id);
        }
    }
}
