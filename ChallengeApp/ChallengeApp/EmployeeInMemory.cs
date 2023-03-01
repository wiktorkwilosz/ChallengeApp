
namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        private IEnumerable<object> grades;
        private byte grade;

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.AddGrade(grade);
            }
            else
            {
                throw new Exception("Invalid number");
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
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            {

                {

                    {
                        foreach (var grade in this.grades) ;

                        statistics.Max = Math.Max(statistics.Max, grade);
                        statistics.Min = Math.Min(statistics.Min, grade);
                        statistics.Average += grade;

                    }
                    statistics.Average = (float)Math.Round(statistics.Average);
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
                }return statistics; 
            }
        }
    }
}


