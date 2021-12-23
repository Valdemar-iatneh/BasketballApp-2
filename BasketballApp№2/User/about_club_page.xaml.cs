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
    /// Interaction logic for about_club_page.xaml
    /// </summary>
    public partial class about_club_page : Page
    {
        private static ObservableCollection<Participant> participants { get; set; }
        private static ObservableCollection<Team> teams { get; set; }
        private static ObservableCollection<Hall> halls { get; set; }
        private static int selClubID { get; set; }

        public about_club_page(int selectedClubID)
        {
            InitializeComponent();

            selClubID = selectedClubID;

            halls = new ObservableCollection<Hall>(basketballBdConnection.connection.Hall.ToList());
            participants = new ObservableCollection<Participant>(basketballBdConnection.connection.Participant.ToList());
            teams = new ObservableCollection<Team>(basketballBdConnection.connection.Team.ToList());

            teams.Where(f => f.ClubID == selectedClubID).ToList();
            var teamIDs = from team in teams
                          select team.TeamID;
            int teamID = 0;
            foreach (int i in teamIDs)
            {
                teamID = i;
            }
            participants.Where(f => f.TeamID == teamID).ToList();
            info1.ItemsSource = participants;
            Console.WriteLine(selectedClubID);
            halls.Where(f => f.ClubID == selectedClubID).ToList();
            info2.ItemsSource = halls;
            this.DataContext = this;
        }
    }
}
