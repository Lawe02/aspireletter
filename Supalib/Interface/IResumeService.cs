using Microsoft.AspNetCore.Identity;
using Supalib.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supalib.Interface
{
    public interface IResumeService
    {
        public Task UpploadResumeASync(ResumeUploadDto dto);
    }
}
