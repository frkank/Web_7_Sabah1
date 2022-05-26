﻿using DersAtamaApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DersAtamaApp.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public int No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public sbyte Period { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Course> SelectedCourses { get; set; }
    }
}
