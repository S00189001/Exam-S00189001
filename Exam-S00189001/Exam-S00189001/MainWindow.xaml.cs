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

/*
 * Couldn't get the player generation working
 */

namespace Exam_S00189001
{
   

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Player> FullTeamList = new List<Player>();
        // creates a reference to the player class
        public Player player;
        public List<Player> tempTeamList = new List<Player>();
        public List<Player> selectedPlayersList = new List<Player>();


        public MainWindow()
        {
            InitializeComponent();
            //FullTeamList.Add(player.PlayerGeneration(player));

            //creates an instance of player and stores as player1
            Player player1 = new Player("Mattie", "Bowen", Position.Forward, new DateTime(2000, 5, 10), 24);

            tempTeamList.Add(player1);

        }
        
        ////public void TeamCreation()
        ////{
        ////    // Create a list of 18
            

        ////    for (int i = 0; i <= 18; i++)
        ////    {
        ////        //FullTeamList.Add(PlayerGeneration(player));
        ////        player.PlayerList.Add(player.PlayerGeneration(player));
        ////        FullTeamList = player.PlayerList;

        ////        //Player player = new Player(player.PlayerGeneration.FindName as string, );
        ////        //player.PlayerGeneration();
        ////    }
        ////}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //TeamCreation();
            //FullTeamList = player.PlayerList;
            lstb_AllPlayers.ItemsSource = tempTeamList;
            lstb_AllPlayers.Items.Refresh();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            // creates a variable we can use to store the selected item
            Player selectedItem;
            // store the selected item in selected item as player
            selectedItem = lstb_AllPlayers.SelectedItem as Player;
            // add the selected item to the selected player list
            lstb_SelectedPlayers.ItemsSource = selectedItem.PlayerList;
            // remove the selected item from the All players list

            //updates spaces
            txtb_Spaces.Text = selectedPlayersList.Count.ToString();
        }

        private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            // creates a variable we can use to store the selected item
            Player selectedItem;
            // stores the selected item in the selectedItem variable from selected players
            selectedItem = lstb_SelectedPlayers.SelectedItem as Player;
            lstb_AllPlayers.ItemsSource = selectedItem.PlayerList;

            //update spaces
            txtb_Spaces.Text = selectedPlayersList.Count.ToString();
        }
    }
}
