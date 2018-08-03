using System;
using System.Collections.Generic;
using System.Data.Entity;
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

		public void AddRange(TaskClass currentTaskClass)
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
				TaskClass currentTask;
				var taskToDeleteCollection = db.TaskSet.Where(x => x.Title == task).ToList();
				if (taskToDeleteCollection.Count > 1)
					throw new Exception("There are two records with the same name");
				currentTask = taskToDeleteCollection.FirstOrDefault() as TaskClass;
				db.TaskSet.Remove(currentTask);
				db.SaveChanges();
			}
		}
	}
}

