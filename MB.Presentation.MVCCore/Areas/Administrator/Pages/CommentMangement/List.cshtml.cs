using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentMangement
{
    public class ListModel : PageModel
    {
        private readonly ICommentApplication _commentApplication;
        public List<CommentViewModel> Comments { get; set; }

        public ListModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet()
        {
          Comments = _commentApplication.GetList();
        }
    }
}
