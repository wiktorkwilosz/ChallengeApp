namespace ChallengeApp
{

    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, char age)
            : base(name, surname, age)
        {

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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            

            foreach (var grade in grades)
            {
                if (grade < 0)
                {
                    continue;
                }
             
            }

            return statistics;
        }
    }
}
