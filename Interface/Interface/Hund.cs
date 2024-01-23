using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal class Hund : Interface_Tier
	{
		 void Interface_Tier.Laufen()
		{
			Console.WriteLine("Ich bin einHund ich laufe und renne");
		}

		 string Interface_Tier.Lautgeben()
		{
			return "Ich bin ein Hund und mache Wuff";
		}

	}
}
