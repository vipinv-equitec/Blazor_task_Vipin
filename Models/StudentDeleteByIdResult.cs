﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Models
{
    public partial class StudentDeleteByIdResult
    {
        public int StudentId { get; set; }
        public string StudName { get; set; }
        public int? StudAge { get; set; }
        public string StudEmail { get; set; }
        public string StudDepartment { get; set; }
        public string Skills { get; set; }
        public bool? IsActive { get; set; }
    }
}