using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Supalib.Interface;
using Supalib.Models;

namespace webapp.Pages
{
    public class ViewResumeModel : PageModel
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public ViewResumeModel(IResumeRepository resumeRepository, UserManager<ApplicationUser> userManager)
        {
            _resumeRepository = resumeRepository;
            _userManager = userManager;
        }
        public int ResumeId { get; set; }

        public async Task<ActionResult> OnGetAsync(int id)
        {
            ResumeId = id;
            return Page();
        }

        public async Task<ActionResult> OnGetResumeAsync(int id)
        {
            string userId = _userManager.GetUserId(User);
            Resume resume = await _resumeRepository.GetResumeAsync(userId, id);
            return File(resume.Data, resume.ContentType);
        }
    }
}
