﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Shop.Api.Models
{
    public partial class Employees
    {
        public Employees()
        {
            InverseMgr = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
        }

        public int Empid { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Title { get; set; }
        public string Titleofcourtesy { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Hiredate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postalcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int? Mgrid { get; set; }

        public virtual Employees Mgr { get; set; }
        public virtual ICollection<Employees> InverseMgr { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}