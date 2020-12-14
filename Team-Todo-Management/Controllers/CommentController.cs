using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team_Todo_Management.Data;
using Team_Todo_Management.IServices;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Controllers
{
    public class CommentController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICommentServices _commentServices;

        public CommentController(DataContext context, UserManager<ApplicationUser> userManager, ICommentServices commentServices)
        {
            _context = context;
            _userManager = userManager;
            _commentServices = commentServices;
        }

        [HttpPost]
        public async Task<IActionResult> DeleteComment(
            [FromRoute] int id
        )
        {
            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);

                var result = await _commentServices.DeleteComment(id, currentUser);

                return Ok(result);
            }
            else
            {
                return Ok(new AjaxResultViewModel(false, "Something went wrong please try again"));
            }
        }
    }
}