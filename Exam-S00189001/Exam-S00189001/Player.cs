using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_S00189001
{
    public class Player
    {
        public string firstName { get; set; }
        public string surname { get; set; }
        public Position preferredPosition { get; set; }
        public DateTime dob { get; set; }
        public int age { get; set; }

        public Player (string firstName, string surname, Position preferedPosition, DateTime dob, int age)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.preferredPosition = preferredPosition;
            this.dob = dob;
            this.age = age;
        }
    }
}
