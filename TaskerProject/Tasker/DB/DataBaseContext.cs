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



}
