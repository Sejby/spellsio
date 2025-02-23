using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using wetherio.ViewModels;

namespace wetherio.Views
{
    public partial class SpellView : UserControl
    {
        public SpellView()
        {
            InitializeComponent();
            var viewModel = new SpellViewModel();
            DataContext = viewModel;
            _ = viewModel.InitializeAsync();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
