using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker
{
	public class TaskAction
	{
		DataBaseContext db;
		
		public void Add(TaskClass currentTaskClass)
		{
			using (db = new DataBaseContext())
			{
					if (currentTaskClass == null)
						throw new Exception("You are tring to add Task that is null");
				db.TaskSet.Add(currentTaskClass);
				db.SaveChanges();
			}
		}

		public void Delete(string task)
		{
			using (db = new DataBaseContext())
			{
				TaskClass currentTask = new TaskClass(task);
				db.TaskSet.Remove(currentTask);
				db.SaveChanges();
			}


		}
	}
}
