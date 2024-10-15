using System;

namespace QuickDate
{

    using System;

    namespace HelloWorld
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Club { get; set; }
            public int Age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }

        public class SoccerPlayer : Person
        {
            public string Position { get; set; }
            public int GoalsScored { get; set; }
            public int GamesPlayed { get; set; }

            public SoccerPlayer(string firstName, string lastName, int age, string position)
                : base(firstName, lastName, age)
            {
                Position = position;
                GoalsScored = 0;
                GamesPlayed = 0;
            }

            public void ScoreGoal()
            {
                GoalsScored++;
            }

            public void PlayGame()
            {
                GamesPlayed++;
            }
        }

        public class Menedzer : Person
        {
            public Menedzer(string firstName, string lastName, int age, string position)
            : base(firstName, lastName, age)
            {

            }

            public void changeClub(string club)
            {
                this.Club = club;
            }
        }
    }

    internal class Cum
    {
        static void Main(string[] args)
        {
        
        }

    }
}