using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Supalib.Dto.Response;
using Supalib.Interface;
using Supalib.Models;
using Supalib.Service;

namespace webapp.Pages
{
    public class ResumesModel : PageModel
    {
        private readonly IResumeService _resumeService;
        private readonly UserManager<ApplicationUser> _userManager;
        public ResumesModel(IResumeService resumeService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _resumeService = resumeService;
        }

        public ResumeListViewModel Resumes { get; set; }
        public async void OnGet()
        {
            Resumes = await _resumeService.GetResumesAsync(_userManager.GetUserId(User));
        }
    }
}
