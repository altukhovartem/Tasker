using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker
{
	public class TaskClass
	{
		[Key]
		public int TaskID { get; set; }
		public string Title { get; set; }

		public TaskClass(string Title)
		{
			this.Title = Title;
		}
	}
}
