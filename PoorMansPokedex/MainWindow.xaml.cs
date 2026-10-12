using System.Windows;
using PoorMansPokedex.ViewModels;

namespace PoorMansPokedex;

public partial class MainWindow : Window
{
    public MainWindow(PokedexViewModel viewModel)
    {
        ArgumentNullException.ThrowIfNull(viewModel);

        InitializeComponent();
        this.DataContext = viewModel;
    }
}