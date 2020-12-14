using System.Threading.Tasks;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.IServices
{
    public interface ICommentServices
    {
        Task<AjaxResultViewModel> DeleteComment(int commentId, ApplicationUser currentUser);
    }
}