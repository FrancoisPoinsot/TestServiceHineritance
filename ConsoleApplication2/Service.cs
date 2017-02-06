using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	class Service
	{
		public Service Next;

		public virtual void Post(object data)
		{ Next?.Post(data); }
	}

	abstract class ServiceModel2:Service
	{
		protected Model2 getData(object dataObject)
		{
			Model2 data;
			if (!(dataObject is Model2))
			{ throw new Exception("oops"); }
			return (Model2)dataObject;
		}
	}

	class Logger2 : ServiceModel2
	{
		public override void Post(object dataobject)
		{
			Model2 data = getData(dataobject);
			//do stuff
			Console.WriteLine("Enter logger1: " + data.otherStuff);
			base.Post((object)data);
			Console.WriteLine("Leaving logger1");
			//log stuff
		}
	}

	class BL2 : ServiceModel2
	{
		public override void Post(object dataobject)
		{
			Model2 data = getData(dataobject);
			//do stuff
			Console.WriteLine("Enter BL1: " + data.otherStuff);
			base.Post((object)data);
			Console.WriteLine("Leaving BL1");
			//return stuff
		}
	}
}
