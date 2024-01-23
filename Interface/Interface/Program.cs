
using Interface;

//Interface_Tier hund1 = new Hund();
//Interface_Tier katze1 = new Katze();

//hund1.Laufen();
//Console.WriteLine($"{hund1.Lautgeben()}");
//Console.WriteLine("________________________\n");

//katze1.Laufen();
//Console.WriteLine($"{katze1.Lautgeben()}");
//Console.WriteLine("________________________\n");


//Console.ReadKey();

//___________________________________________________________________________________________________________________________________________________

//Interface_Tier[] tiere =new Interface_Tier[4];
//tiere[0] = new Hund();
//tiere[1] = new Katze();
//tiere[2] = new Hund();
//tiere[3] = new Hund();
//int k = 1;

//foreach(var t in tiere)
//{
//	Console.WriteLine($"{k++}tes Tier\n");
//	t.Laufen();
//	Console.WriteLine($"{t.Lautgeben()}");
//	Console.WriteLine("__________________\n");
//}


//Console.ReadKey();

//___________________________________________________________________________________________________________________________________________________


List<Interface_Tier> list = new List<Interface_Tier>();

try
{
    Console.WriteLine("3 EINGABEN BITTE ");

    for (int i = 0; i <3; i++)
	{
        Console.WriteLine("\nMit (1) Hund und mit (2) Katze");
		int wahl = Convert.ToInt32(Console.ReadLine());
		if(wahl == 1)
		{
			list.Add(new Hund());
		}
		else if(wahl == 2)
		{
			list.Add(new Katze());
		}
		else
		{
			Console.WriteLine("Falsche Eingabe");
		}
	}
}
catch(Exception e) 
{
	Console.WriteLine(e.Message);
}

int k = 1;
foreach (var t in list)
{
	Console.WriteLine($"{k++}tes Tier\n");
	t.Laufen();
	Console.WriteLine($"{t.Lautgeben()}");
	Console.WriteLine("__________________\n");
}

Console.ReadKey();
