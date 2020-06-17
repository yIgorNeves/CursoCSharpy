﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be betwen {2} and {1}")]
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }
        
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} Required")]
        public DateTime BirthDate { get; set; }
        
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; }

        public Seller()
        {
        }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales (DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr=> sr.Amount);
        }

    }
}
