using AppWithGui.ViewModel;
using System.Windows;

namespace AppWithGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            var userViewModel = new UserViewModel();
            userViewModel.LoadUsers();
            UserViewControl.DataContext = userViewModel;
        }
    }
}
