using System;
using System.Data.Entity;

namespace Tasker
{
	class DataBaseContext: DbContext
	{
		public DataBaseContext()
			:base("TaskerDB")
		{ }

		static DataBaseContext()
		{
			Database.SetInitializer<DataBaseContext>(new DropCreateDatabaseAlways<DataBaseContext>());
		}

		public DbSet<TaskClass> TaskSet { get; set; }
	}

	public static class TaskAction
	{
		static readonly DataBaseContext db = new DataBaseContext();
		
		public static void Add(TaskClass currentTaskClass)
		{
			if (currentTaskClass == null)
				throw new Exception("You are tring to add Task that is null");
			db.TaskSet.Add(currentTaskClass);
			db.SaveChanges();
		}
	}

}
