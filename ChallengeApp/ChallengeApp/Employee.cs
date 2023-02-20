

namespace ChallengeApp
{
 
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            name = name;
            surname = surname;
        }
       
        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            float f = valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }

 }
        public void AddGrade(long grade)
        {
            float valueAsFloat = (long)grade;
            this.AddGrade(valueAsFloat);
        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat = (int)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(short grade)
        {
            float f = (short)grade;
            this.AddGrade(grade);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Invalid number");
            }
   
        }
        public void AddGrade (char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                this.grades.Add(100);
                    break;
                case 'B' or 'b':
                    this.grades.Add(80);
                    break;
                case 'C' or 'c':
                    this.grades.Add(60);
                    break;
                case 'D' or 'd':
                    this.grades.Add(40);
                    break;
                case 'E' or 'e':
                    this.grades.Add(20);
                    break;
                case 'F' or 'f':
                    this.grades.Add(0);
                    break;
                default:
                    {
                        throw new Exception("Wrong letter");
                    }
                    
            }                          
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade < 0)
                {
                    continue;
                }
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    throw new Exception("Ponizej normy!");
                    break;
            }

            return statistics;
        }
    }
}
          

  