using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitleTrack.Domain.Entities;
using TitleTrack.Domain.Interfaces;

namespace TitleTrack.Application.Services
{
    public class TitleAbstractService
    {
        private readonly ITitleAbstractRepository _repo;

        public TitleAbstractService(ITitleAbstractRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<TitleAbstract>> GetAllTitleAbstractsAsync()
        {
            return await _repo.GetAllTitleAbstractsAsync();
        }

        public async Task CreateTitleAbstractAsync(TitleAbstract titleAbstract)
        {
            await _repo.CreateTitleAbstractAsync(titleAbstract);
        }

        public async Task<TitleAbstract> GetTitleAbstractByIdAsync(int id)
        {
            return await _repo.GetTitleAbstractByIdAsync(id);
        }
    }
}
