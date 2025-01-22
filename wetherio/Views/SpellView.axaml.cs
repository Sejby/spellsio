using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using wetherio.ViewModels;
using System.Threading.Tasks;

namespace wetherio.Views
{
    public partial class SpellView : UserControl
    {
        public SpellView()
        {
            InitializeComponent();
            DataContext = new SpellViewModel();
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            if (DataContext is SpellViewModel viewModel)
            {
                await viewModel.InitializeAsync();
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
