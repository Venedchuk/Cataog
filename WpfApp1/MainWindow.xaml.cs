using Catalog.Core;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TeamsView.ItemsSource = db.Teams;
            TeamsView.DisplayMemberPath = "Name";

            Players.DisplayMemberPath = "Name";

            PlayersWithoutTeam.ItemsSource = db.People.Where(x => x.Team == null);

        }

        public DataService db = new DataService();

        private void TeamsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            Players.ItemsSource = db.People.Where(x => x.Team == TeamsView.SelectedValue);
            
        }
    }
}
