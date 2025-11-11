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
    }
}



