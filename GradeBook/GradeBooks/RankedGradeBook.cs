using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;
using GradeBook.Enums;
using GradeBook;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
            
        }
        public override char GetLetterGrade(double averageGrade)
        {
            
            if (Students.Count < 5)
            {
                throw new InvalidOperationException(" ");
            }
            int CountedStudents = Students.Count;
            double BetterThan = 0;
            
           foreach (var student in Students)
            {
                if(student.AverageGrade > averageGrade)
                {
                    BetterThan++;
                }                
                
            }
            

            if (BetterThan >= 0.8*CountedStudents)
                return 'A';
            else if (BetterThan >= 0.6* CountedStudents)
                return 'B';
            else if (BetterThan >= 0.4 * CountedStudents)
                return 'C';
            else if (BetterThan >= 0.2 * CountedStudents)
                return 'D';
            else
                return 'F';            
        }

        
    }
   
}

