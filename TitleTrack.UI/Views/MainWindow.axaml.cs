using Avalonia.Controls;
using TitleTrack.UI.ViewModels;

namespace TitleTrack.UI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}