using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.IdentityModel.Abstractions;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TitleTrack.Application.Services;
using TitleTrack.Domain.Entities;

namespace TitleTrack.UI.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly TitleAbstractService _service;
        public ObservableCollection<TitleAbstract> TitleAbstracts { get; } = new();
        public MainWindowViewModel(TitleAbstractService service)
        {
            _service = service;
            LoadTitleAbstracts();
        }

        private async Task LoadTitleAbstracts()
        {
            var titleAbstracts = await _service.GetAllTitleAbstractsAsync();
            TitleAbstracts.Clear();
            foreach (var titleAbstract in titleAbstracts)
            {
                TitleAbstracts.Add(titleAbstract);
            }
        }
    }
}
