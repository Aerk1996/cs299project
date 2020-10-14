using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace employeeABBeducation.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Lütfen ad giriniz")]
        [DisplayName("Ad")]
        public string EmployeeName { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage = "Lütfen soyad giriniz")]
        [DisplayName("Soyad")]
        public  string EmployeeSurname { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Daire Başkanlığı")]
        public   string  EmployeeDaireBaskanligi { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Meslek")]
        public string EmployeeJob { get; set; }
    }
}
