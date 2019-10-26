﻿namespace PIndividual.DAL.FC
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        
        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; } //que se puedan hacer nulos 

        public virtual Course Course { get; set; } //relacion a curso 

        public virtual Student Student { get; set; }
    }

    public enum Grade
    {
    
        A, B, C, D, F
    }
}