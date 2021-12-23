using BasketballApp_2.BDConnection;
using BasketballApp_2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BasketballApp_2.User
{
    /// <summary>
    /// Interaction logic for competition_document_page.xaml
    /// </summary>
    public partial class competition_document_page : Page
    {

        public static ObservableCollection<Club> clubs { get; set; }
        public competition_document_page()
        {
            InitializeComponent();

            clubs = new ObservableCollection<Club>(basketballBdConnection.connection.Club.ToList());
            this.DataContext = this;
        }

        private void list_of_clubs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedClubID = (list_of_clubs.SelectedItem as Club).ClubID;
            NavigationService.Navigate(new about_club_page(selectedClubID));
        }
    }
}
