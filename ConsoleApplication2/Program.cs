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
			test1.ServiceModel1 srv = new test1.Logger1() { Next = new test1.BL1() };
			srv.Post(new Model1 { Stuff = "boo" });

			test2.CrudService srv2 = new test2.Logger2() { Next = new test2.BL2() };
			srv2.Post(new Model2 { otherStuff = 42 });

		}
	}
}
