using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker
{
	class CustomInitializatior: DropCreateDatabaseAlways<DataBaseContext>
	{
		protected override void Seed(DataBaseContext context)
		{
			List<TaskClass> listOfTasks = new List<TaskClass>
			{
				new TaskClass("Task1"),
				new TaskClass("Task2"),
				new TaskClass("Task3")
			};

			context.TaskSet.AddRange(listOfTasks);
			context.SaveChanges();
		}
	}
}
