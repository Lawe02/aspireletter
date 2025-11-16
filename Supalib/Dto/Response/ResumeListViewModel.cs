using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supalib.Dto.Response
{
    public class ResumeListViewModel
    {
        public List<ResumeViewModel> Resumes { get; set; } = new List<ResumeViewModel>();
    }
}
