using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HelperMethods.Models
{
	[DisplayName("New Person")]
	public partial class PersonMetadata
	{
		[HiddenInput(DisplayValue = false)]
		public int PersonId { get; set; }

		[Display(Name ="First")]
		public string FirstName { get; set; }

		[Display(Name = "Last")]
		public string LastName { get; set; }

		[Display(Name = "Birth Date")]
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }

		[Display(Name = "Approved")]
		public bool IsApproved { get; set; }

		[UIHint("Enum")]
		public Role Role { get; set; }
	}
}