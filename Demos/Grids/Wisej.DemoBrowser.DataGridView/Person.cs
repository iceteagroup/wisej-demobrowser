using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataGridView
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string UserName { get; set; }
		public int Age { get; set; }
		public PersonGender Gender { get; set; }
		public Guid CartId { get; set; }
		public string SSN { get; set; }
		public string Address { get; set; }
		public string Designation { get; set; }
		public string Mail { get; set; }

		public string Avatar { get; set; }
		public string Rating
		{
			get => _rating;
			set => _rating = BuildRatingHtml(value);
		}

		public int Progress { get; set; }

		public Person(int id, string ssn)
		{
			Id = id;
			SSN = ssn;
		}

		private string BuildRatingHtml(string value)
		{
			try
			{
				var rate = int.Parse(value);

				var rating = 5;
				var sb = new StringBuilder();

				//Check the rating value, if < 5 then it's a five star rating, less than 10 then it becomes 10 and so on...
				while (rate > rating) rating *= 2;

				sb.Append("<div style=\"direction: rtl;display: flex;justify content:flex-end;\">");

				for (var i = 0; i < rate; i++)
				{
					sb.Append("<img src=\"resource.wx/Wisej.DemoBrowser.DataGridView/Images/star-filled.png\" width=\"16px\" height=\"16px\">");
					sb.Append("\n");
				}

				for (var i = 0; i < rating - rate; i++)
				{
					sb.Append("<img src=\"resource.wx/Wisej.DemoBrowser.DataGridView/Images/star.png\" width=\"16px\" height=\"16px\">");
					sb.Append("\n");
				}

				sb.Append("</div>");
				return sb.ToString();
			}
			catch (Exception e)
			{
				return _rating;
			}
		}

		private string _rating;
	}
}