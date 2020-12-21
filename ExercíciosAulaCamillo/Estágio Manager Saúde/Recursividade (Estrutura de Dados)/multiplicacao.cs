using System;
class Program
{
	static void Main()
	{
		Console.Write(Multiplicar(10, 5));
	}
	static int Multiplicar (int m, int n)
	{
		int resultado;
		if (n == 0) resultado = m;
		else
		m += Multiplicar(m, n - 1);
		resultado = m;
		return resultado;
	}
}