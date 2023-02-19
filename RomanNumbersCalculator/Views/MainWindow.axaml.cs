using Avalonia.Controls;
using RomanNumbersCalculator.ViewModels;
using Avalonia.Interactivity;


namespace RomanNumbersCalculator.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
