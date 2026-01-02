using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public class BlobFileRepository : GenericRepository<BlobFile>, IBlobFileRepository
    {
        private readonly SchoolDbContext _context;

        public BlobFileRepository(SchoolDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
