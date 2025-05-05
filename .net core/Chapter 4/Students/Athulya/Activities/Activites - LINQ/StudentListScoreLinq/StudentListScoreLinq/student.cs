namespace StudentListScoreLinq
{
    internal class student
    {
        public int Score{ get; set; }
        public string Name { get; set; }

        public student()
        {

        }
        public student(int score, string name)
        {
            Score = score;
            Name = name;
        }
    }
}