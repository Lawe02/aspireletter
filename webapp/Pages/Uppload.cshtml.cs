using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Supalib.Dto;
using Supalib.Interface;
using Supalib.Models;

namespace webapp.Pages
{
    [Authorize]
    public class UpploadModel : PageModel
    {
        private readonly IResumeService _resumeService;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public UpploadModel(IResumeService resumeService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _resumeService = resumeService;
        }
        [BindProperty]
        public ResumeUploadDto Resume { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var userId = _userManager.GetUserId(User);

            await _resumeService.UploadResumeAsync(Resume, userId);
            return RedirectToPage(Page());
        }
    }
}
