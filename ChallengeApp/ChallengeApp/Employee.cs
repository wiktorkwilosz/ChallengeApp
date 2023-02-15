using System;
using System.Diagnostics;

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
          
            
           


        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if(grade< 0)
                {
                    continue;
                }
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / grades.Count;

            return statistics;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int index = 0; index < this.grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
            }
            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;

            } while (index < this.grades.Count);
            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index > this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;     
            }
            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;

        }
        

    }
}


  