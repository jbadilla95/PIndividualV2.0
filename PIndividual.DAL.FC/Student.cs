using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIndividual.DAL.FC
{
    public class Student
    {
        public int ID { get; set;  }
        public string LastName { get; set;  }

        //[Column("FirstName")]
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}