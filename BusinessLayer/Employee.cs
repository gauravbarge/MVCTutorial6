﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string  Gender { get; set; }
        public string City { get; set; }
        public int DepartmentID { get; set; }
    }
}