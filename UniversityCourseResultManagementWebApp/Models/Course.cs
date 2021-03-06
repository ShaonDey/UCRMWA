﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityCourseResultManagementWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Provide a Code")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Length must be in between 5 to 50 characters")]
        [DisplayName("Code :")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please Provide a Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Length must be in between 5 to 50 characters")]
        [DisplayName("Name :")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Provide a Cradit")]
        [DisplayName("Credit :")]
        [Range(typeof(double), "0.5", "5.0", ErrorMessage = "Cradit range must be 0.5 to 5.0")]
        public double Cradit { get; set; }

        [Required(ErrorMessage = "Please Provide a Description")]
        [DisplayName("Description :")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Select a Department")]
        [DisplayName("Department :")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Select a Semester")]
        [DisplayName("Semester :")]
        public int SemesterId { get; set; }
    }
}