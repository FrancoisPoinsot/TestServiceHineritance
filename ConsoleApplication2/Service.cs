using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	class ServiceModel1
	{
		public ServiceModel1 Next;

		public virtual void Post(Model1 data)
		{ Next?.Post(data); }
	}

	class Logger1 : ServiceModel1
	{
		public override void Post(Model1 data)
		{
			//do stuff
			Console.WriteLine("Enter logger1: "+ data.Stuff);
			base.Post(data);
			Console.WriteLine("Leaving logger1");
			//log stuff
		}
	}

	class BL1: ServiceModel1
	{
		public override void Post(Model1 data)
		{
			//do stuff
			Console.WriteLine("Enter BL1: " + data.Stuff);
			base.Post(data);
			Console.WriteLine("Leaving BL1");
			//return stuff
		}
	}
}
