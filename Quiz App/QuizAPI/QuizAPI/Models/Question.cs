﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
	public class Question
	{
		[Key]
		public int QnId { get; set; }

		[MaxLength(250)]
		public string QnInWords { get; set; }

		[MaxLength(50)]
		public string? ImageName { get; set; }

		[MaxLength(50)]
		public string Option1 { get; set; }

		[MaxLength(50)]
		public string Option2 { get; set; }

		[MaxLength(50)]
		public string Option3 { get; set; }

		[MaxLength(50)]
		public string Option4 { get; set; }

		public int Answer { get; set; }
	}
}