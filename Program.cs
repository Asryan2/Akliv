using IronWebScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vilka
{
	class Program
	{

		public static void Main(string[] args)
		{
			Better888 bet = new Better888();
			bet.GetAllEvents();
		}
	}
}
