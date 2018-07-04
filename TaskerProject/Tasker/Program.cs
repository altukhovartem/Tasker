namespace Tasker
{
	class Program
	{
		static void Main(string[] args)
		{
			TaskClass task1 = new TaskClass("FirstTask");
			TaskAction.Add(task1);			
		}
	}
}
