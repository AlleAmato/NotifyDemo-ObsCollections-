using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotifyDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowViewModel();
            DataContext = vm;
        }

        private void LoadList_Click(object sender, RoutedEventArgs e)
        {
            vm.LoadList();
        }
        private void AddList_Click(object sender, RoutedEventArgs e)
        {
            vm.AddList();
        }
        private void ModList_Click(object sender, RoutedEventArgs e)
        {
            vm.ModObs();
        }

        private void LoadObs_Click(object sender, RoutedEventArgs e)
        {
            vm.LoadObs();
        }
        private void AddObs_Click(object sender, RoutedEventArgs e)
        {
            vm.AddObs();
        }
        private void ModObs_Click(object sender, RoutedEventArgs e)
        {
            vm.ModList();
        }
    }
}
