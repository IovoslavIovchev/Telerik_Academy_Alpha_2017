namespace School_Classes.Models
{
    public class Discipline
    {
        private string name;
        private int numOfLectures;
        private int numOfExercises;
        private string comment;

        public Discipline(string name, int numOfLectures, int numOfExercises)
        {
            this.name = name;
            this.numOfLectures = numOfLectures;
            this.numOfExercises = numOfExercises;
            this.comment = string.Empty;
        }

        public Discipline(string name, int numOfLectures, int numOfExercises, string comment)
            : this(name, numOfLectures, numOfExercises)
        {
            this.comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numOfLectures;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numOfExercises;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
        }
    }
}