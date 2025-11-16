using Microsoft.EntityFrameworkCore;
using Supalib.Data;
using Supalib.Interface;
using Supalib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supalib.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private ApplicationDbContext _db;
        public ResumeRepository(ApplicationDbContext db) 
        { 
            _db = db;
        }
        public async Task SaveResumeAsync(Resume resume)
        {
            _db.Resumes.Add(resume);
            await _db.SaveChangesAsync();
        }

        public async Task<Resume> GetResumeAsync(string userId, int resumeId)
        {
            Resume resume = await _db.Resumes
                .Where(r => r.UserId == userId && r.Id == resumeId)
                .FirstOrDefaultAsync();

            if (resume == null)
                throw new KeyNotFoundException("No resume found");
            return resume;
        }

        public async Task<List<Resume>> GetResumesAsync(string userId)
        {
            List<Resume> resumes = await _db.Resumes
                .Where(resume => resume.UserId == userId)
                .ToListAsync();

            return resumes;
        }
    }
}



