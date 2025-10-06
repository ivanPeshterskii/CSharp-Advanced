namespace GenericArrayCreator
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			var numbers = ArrayCreator.Create(10, 100);
			var strings = ArrayCreator.Create(5, "Pesho");
		}
    }
}

