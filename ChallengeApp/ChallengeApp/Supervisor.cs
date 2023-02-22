

namespace ChallengeApp
{
    public class Supervisor : IEmployee
        
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }
    
        
        public string Name {get; private set; }
        public string Surname { get; private set; } 

        public int Age { get; private set; }
       
        public void AddGrade(float grade)
        {
            if (grade>=1 && grade>=6)
            {
                this.grades.Add(grade);
            }
            throw new Exception("Wybierz punkty z przedziału od 1 do 6");

        }

        
         public void AddGrade(string grade)
    {
        switch (grade)
        {
            case "6":
                this.grades.Add(100);
                break;
            case "5":
                this.grades.Add(85);
                break;
            case "5-" or "-5":
                this.grades.Add(80);
                break;
                case "4+" or "+4":
                    this.grades.Add(65);
                    break;
                case "4":
                this.grades.Add(60);
                break;
            case "4-" or "-4":
                this.grades.Add(55);
                break;
            case "3":
                this.grades.Add(50);
                break;
            case "3-" or "-3":
                this.grades.Add(45);
                break;
            case "2":
                this.grades.Add(40);
                break;
                case "2-" or "-2":
                    this.grades.Add(35);
                    break;
                case "1":
                this.grades.Add(20);
                break;
            default:
                {
                    throw new Exception("Wrong letter");
                }

        }
    }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
   
   
}

