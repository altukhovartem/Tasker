namespace Tasker
{
	class Program
	{
		static void Main(string[] args)
		{
			TaskClass task1 = new TaskClass("FirstTask");
			TaskClass task2 = new TaskClass("SecondTask");
			TaskAction action = new TaskAction();
			action.Add(task1);
			action.Add(task2);

			action.Delete("FirstTask");
		}
	}
}
