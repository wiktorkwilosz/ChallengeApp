namespace ChallengeApp
{



    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            float f = valueInInt;
            
            if (grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);
                }
            
            else
            {
                Console.WriteLine("invalid grade value");
            }
     
        }
        public void AddGrade(long grade)
        {
            float valueAsFloat = (long)grade;
            this.AddGrade(valueAsFloat);
        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat =(int)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(short grade)
        {
            float f = (short)grade;
            this.AddGrade(grade);
        }
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
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
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / grades.Count;

            return statistics;

        }


    }
}


  