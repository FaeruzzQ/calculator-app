class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, n, Penambahan(a, b));
		Console.WriteLine("Hasil Pengurangan : {0} + {1} = {2}", a, n, Pengurangan(a, b));
		Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", a, n, Perkalian(a, b));
		Console.WriteLine("Hasil Pembagian : {0} + {1} = {2}", a, n, Pembagian(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey
	}
	
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan (int a, int b)
	{
		return a - b;
	}
	
	static int Perkalian (int a, int b) 
	{
		return a * b;
	}
	
	static int Pembagian (int a, int b)
	{
		return a/b;
	}
}