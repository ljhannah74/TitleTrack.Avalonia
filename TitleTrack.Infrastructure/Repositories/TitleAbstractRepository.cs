using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitleTrack.Domain.Entities;
using TitleTrack.Domain.Interfaces;
using TitleTrack.Infrastructure.Data;

namespace TitleTrack.Infrastructure.Repositories
{
    public class TitleAbstractRepository : ITitleAbstractRepository
    {
        private readonly AppDbContext _context;

        public TitleAbstractRepository(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<List<TitleAbstract>> GetAllTitleAbstractsAsync()
        {
            return await _context.TitleAbstracts.ToListAsync();
        }

        public async Task<TitleAbstract> GetTitleAbstractByIdAsync(int id)
        {
            return await _context.TitleAbstracts.FindAsync(id);
        }

        public async Task CreateTitleAbstractAsync(TitleAbstract titleAbstract)
        {
            _context.TitleAbstracts.Add(titleAbstract);
            await _context.SaveChangesAsync();
        }
    }
}
