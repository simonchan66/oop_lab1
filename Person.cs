namespace PersonLab
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        // Properties
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age
        {
            get { return age; }
            set
            {
                // Ensure age is valid
                if (value >= 0 && value <= 122)
                {
                    age = value;
                }
            }
        }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        public string DisplayGina()
        {

            string formatted = id + ": " + firstName + " " + lastName + "'s favourite colour is " + favoriteColor + "\n";


            return formatted;
        }
        public void ChangeFavoriteColor()
        {
            favoriteColor = "White";
        }
        public int GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;

            return ageInTenYears;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonId\t\t" + id + "\n";
            formatted += "FirstName\t" + firstName + "\n";
            formatted += "LastName\t" + lastName + "\n";
            formatted += "FavoriteColor\t" + favoriteColor + "\n";
            formatted += "Age\t" + age + "\n";
            formatted += "IsWorking\t" + isWorking + "\n";
            return formatted;
        }

    }
}