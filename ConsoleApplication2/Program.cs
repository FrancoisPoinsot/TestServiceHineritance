using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceModel1 srv = new Logger1() { Next = new BL1() };
			srv.Post(new Model1 { Stuff = "boo" });
		}
	}
}
