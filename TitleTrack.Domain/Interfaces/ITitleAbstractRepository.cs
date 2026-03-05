using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitleTrack.Domain.Entities;

namespace TitleTrack.Domain.Interfaces
{
    public interface ITitleAbstractRepository
    {
        Task<List<TitleAbstract>> GetAllTitleAbstractsAsync();
        Task CreateTitleAbstractAsync(TitleAbstract titleAbstract);
        Task<TitleAbstract> GetTitleAbstractByIdAsync(int id);
    }
}
