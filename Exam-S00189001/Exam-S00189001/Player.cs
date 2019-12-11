using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_S00189001
{
    // Creates an enum that will be used to define by type
    public enum Position
    {
        Goalkeeper, //0
        Defender,   //1
        Midfielder, //2
        Forward     //3
    }
    public class Player
    {
        // Declared variable
        public string firstName { get; set; }
        public string surname { get; set; }
        public Position preferredPosition { get; set; }
        public DateTime dob { get; set; }
        public int age { get; set; }
        public List<Player> PlayerList;

        // Random variable created to use random ranges
        public Random random = new Random();

        public Player (string firstName, string surname, Position preferedPosition, DateTime dob, int age)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.preferredPosition = preferredPosition;
            this.dob = dob;
            this.age = (int)DateTime.Now.Subtract(dob).Days / 365; //age;
        }

        public void PlayerGeneration(Player player)
        {           
            // array of firstName to be used in the creation of a player
            string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};

            // array of SecondName to be used in the creation of a player
            string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };

            firstName = firstNames[random.Next(0, 20)];
            surname = lastNames[random.Next(0, 20)];
            age = (int)DateTime.Now.Subtract(dob).Days / 365;

            Player player1 = new Player(firstName, surname, Position.Goalkeeper, dob, age);
            //player = player1;
            //return player;
            PlayerList.Add(player1);
        }

        //public void PlayerCreation()
        //{
        //    string[] firstNames = {
        //        "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
        //        "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
        //        "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};

        //    string[] lastNames = {
        //        "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
        //        "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
        //        "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
        //    };

        //    firstName = firstNames[random.Next(0, 20)];
        //    surname = lastNames[random.Next(0, 20)];
        //}
    }
}
