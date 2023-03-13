
namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        

        private IEnumerable<object> grades;
        private byte grade;

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
        public  event GradeAddedDelegate GradeAdded;
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.AddGrade(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Błędna wartość. Wartość musi sie mieścić w przedziale 0-100");
            }
        }


        public override void AddGrade(long grade)
        {
            float valueAsFloat = (long)grade;
            this.AddGrade(valueAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (int)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string grade)
        {
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
        }

        public override void AddGrade(char grade)
        {
            {
                switch (grade)
                {
                    case 'A' or 'a':
                        this.AddGrade(100);
                        break;
                    case 'B' or 'b':
                        this.AddGrade(80);
                        break;
                    case 'C' or 'c':
                        this.AddGrade(60);
                        break;
                    case 'D' or 'd':
                        this.AddGrade(40);
                        break;
                    case 'E' or 'e':
                        this.AddGrade(20);
                        break;
                    case 'F' or 'f':
                        this.AddGrade(0);
                        break;
                    default:
                        {
                            throw new Exception("Wrong letter");
                        }
                }

            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
                {

                    {
                        foreach (var grade in this.grades) ;

                        statistics.AddGrade(grade);

                    }

                    
                    
                } return statistics;
            
        }
        public override Statistics RememberTheCollectedPoints()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.PointsCollected += grade + ",";
            }
            return statistics;
        }
    }
}
    

