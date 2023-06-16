using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUniversal.Utils
{
    public class Student
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string StudentRecord { get; set; }
        public int FirstExam { get; set; }
        public int SecondExam { get; set; }
        public static Random randomNumber { get; set; }
        
        static Student()
        {
            randomNumber = new Random();
        }
        public Student(string Name, string LastName, string StudentRecord)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.StudentRecord = StudentRecord;
        }

        private float CalculateAverage() => (FirstExam + SecondExam) / 2;
        private double CalculateFinalScore()
        {
            if(CalculateAverage() >= 4)
            {
                return CalculateAverage() + randomNumber.Next(6, 10);
            }
            else
            {
                return -1;
            }
        }

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ")
                .Append(Name).Append("\n")
                .Append("Apellido: ")
                .Append(LastName).Append("\n")
                .Append("Legajo: ")
                .Append(StudentRecord).Append("\n")
                .Append("Nota del primer parcial: ")
                .Append(FirstExam).Append("\n")
                .Append("Nota del segundo parcial: ")
                .Append(SecondExam).Append("\n")
                .Append("Nota final: ")
                .Append(CalculateFinalScore() != -1 ? CalculateFinalScore() : "Alumno desaprobado")
                .Append("\n");

            return sb.ToString();
        }
    }
}
