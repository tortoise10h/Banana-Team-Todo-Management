using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team_Todo_Management.Common.Enum;
using Team_Todo_Management.Data;
using Team_Todo_Management.IServices;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Services
{
    public class CommentServices : ICommentServices
    {
        private readonly DataContext _context;
        private readonly IActivityServices _activityServices;

        public CommentServices(DataContext context, IActivityServices activityServices)
        {
            _context = context;
            _activityServices = activityServices;
        }

        public async Task<AjaxResultViewModel> DeleteComment(int commentId, ApplicationUser currentUser)
        {
            var comment = await _context.Comments
                .Include(x => x.Todo)
                .SingleOrDefaultAsync(x => x.Id == commentId);

            if (comment == null)
            {
                return new AjaxResultViewModel(false, "Comment not found");
            }

            /** Only allow delete comment by the owner */
            if (comment.UserId != currentUser.Id)
            {
                return new AjaxResultViewModel(false, "You don't have permission to delete this comment");
            }

            await _activityServices.TrackActivity(
                currentUser.FirstName,
                currentUser.LastName,
                currentUser.Email,
                ActivityTypeEnum.DeleteComment,
                $"\"{comment.Content}\" from the task \"{comment.Todo.Name}\"",
                currentUser.Id,
                _context
            );
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return new AjaxResultViewModel(true, "");
        }
    }
}