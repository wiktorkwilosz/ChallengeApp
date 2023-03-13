
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";


        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                    if(GradeAdded!= null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }


                else
                {
                    throw new Exception("Błędna wartość. Wartość musi sie mieścić w przedziale 0-100");
                }
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
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);

            return result;
        }

        private Statistics CountReadGradesFromFile(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.PointsCollected += grade;
            }
            return statistics;
        }


        public override Statistics RememberTheCollectedPoints()
        {

            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountReadGradesFromFile(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var namber = float.Parse(line);
                        grades.Add(namber);
                        line = reader.ReadLine();

                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            {


                foreach (var grade in grades)
                {

                    statistics.AddGrade(grade);
                }

            }
            return statistics;
        }
    }
}

          
