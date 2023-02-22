

namespace ChallengeApp
{
    public interface IEmployee
    {
      public  string Name { get; }
      public  string Surname { get; } 
      public int Age{ get; }
        public void AddGrade(char grade);
        public void AddGrade(float grade);
        public void AddGrade(long grade);
        public void AddGrade(int grade);
        public void AddGrade(string grade);

        Statistics GetStatistics();


    }
}
