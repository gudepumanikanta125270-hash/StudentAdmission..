using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    class StudentAdmission
    {
        
        private int studentID;
        private string studentName;
        private double entranceScore;
        private string admissionStatus;
        
        private void EvaluateStatus()
        {
            if (entranceScore >= 60.0)
            {
                admissionStatus = "ACCEPTED";
            }
            else
            {
                admissionStatus = "REJECTED";
            }
        }
        
        public StudentAdmission()
        {
            studentID = 0;
            studentName = "Unassigned";
            entranceScore = 0.0;
            admissionStatus = "PENDING";
        }
      
        public StudentAdmission(int id, string name, double score)
        {
            studentID = id;
            studentName = name;
            entranceScore = score;
            EvaluateStatus();
        }
        public void DisplayStudentDetails()
        {

            Console.WriteLine($" {studentID,-12}{studentName,-20}{entranceScore,-15:F2}{admissionStatus,-15}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========================================================");
            Console.WriteLine(" STUDENT ADMISSION MANAGEMENT MODULE");


            Console.WriteLine("===========================================================");

            StudentAdmission s1 = new StudentAdmission(101, "JAYANTH", 88.50);
            StudentAdmission s2 = new StudentAdmission(102, "ASH", 54.00);
            StudentAdmission s3 = new StudentAdmission(103, "DHRUV", 72.30);
            StudentAdmission s4 = new StudentAdmission(104, "ROHAN", 55.30);

            Console.WriteLine($" {"Student ID",-12}{"Name",-20}{"Score (%)",-15}{"Status",-15} ");
            Console.WriteLine(" -----------------------------------------------------------");

            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            s3.DisplayStudentDetails();
            s4.DisplayStudentDetails();

            Console.WriteLine("===========================================================");
        }

    }
}
