using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team_Todo_Management.Data;

namespace Team_Todo_Management.Controllers
{
    [Authorize]
    public class FileController : Controller
    {
        private readonly DataContext _context;

        public FileController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> DeleteFile([FromRoute] int id)
        {
            var media = await _context.Medias.SingleOrDefaultAsync(x => x.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), media.Location);

            _context.Medias.Remove(media);
            await _context.SaveChangesAsync();

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            return RedirectToAction("Details", "Todo", new { id = media.TodoId });
        }
    }
}
