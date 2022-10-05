using System;

class Swap
	{
		static void Main(String[] args)
		{
			int a=5,b=3,temp;

			//swapping
			temp=a;
			a=b;
			b=temp;
			
			Console.WriteLine("Values after swapping are:");
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
		}
	}