﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gride.Models
{
	public class Employee
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public uint EmployeeID { get; set; }
		[Required, StringLength(50)]
		public string Name{ get; set; }
		[Required, StringLength(50), Display(Name="Last Name")]
		public string LastName { get; set; }
		[Display(Name = "Date of Birth"), DataType(DataType.Date)]
		public DateTime DoB { get; set; }
		public Gender Gender { get; set; } = Gender.Not_Specified;
		[Required, StringLength(100), EmailAddress, Display(Name = "E-mail address")]
		public string EMail { get; set; }
		[Required, StringLength(12), Phone, Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }
		public bool Admin { get; set; } = false;
		public ulong LoginID { get; set; }
		public float Experience { get; set; }
		[RegularExpression(@"(\\\\?([^\\/]*[\\/])*)([^\\/]+)$", ErrorMessage = "Path to ProfileImage is not a valid path")]
		public string ProfileImage { get; set; } = null;

		public virtual ICollection<Skill> Skills { get; set; }
		public virtual ICollection<Function> Functions { get; set; }
		public virtual ICollection<Location> Locations { get; set; }
	}
	public enum Gender
	{
		Male, Female, Not_Specified
	}
}
