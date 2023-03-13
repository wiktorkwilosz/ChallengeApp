﻿

namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; } 

        public float Max { get; private set; } 

        public float Sum { get; private set; }

        public int Count { get; private set; }  



        public float Average
        {
            get
            {
                if(Count ==0)
                {
                    return 0;
                }
                else
                {
                    return this.Sum / this.Count;
                }
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return'A'; 
                    case var average when average >= 60:
                        return 'B';                       
                    case var average when average >= 40:
                        return 'C';                       
                    case var average when average >= 20:
                        return 'D';                     
                    default:
                        return 'E';
                        
                }
            }
        }
        public string PointsCollected { get; internal set; }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);

        }
    }
}
