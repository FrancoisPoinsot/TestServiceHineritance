using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.test2
{
	interface ICrudService
	{
		void Post(object data);
	}

	class CrudService: ICrudService
	{
		public CrudService Next;

		public virtual void Post(object data)
		{ Next?.Post(data); }
	}

	abstract class ServiceModel2: CrudService
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
			Console.WriteLine("Enter logger2: " + data.otherStuff);
			base.Post(data);
			Console.WriteLine("Leaving logger2");
			//log stuff
		}
	}

	class BL2 : ServiceModel2
	{
		public override void Post(object dataobject)
		{
			Model2 data = getData(dataobject);
			//do stuff
			Console.WriteLine("Enter BL2: " + data.otherStuff);
			base.Post(data);
			Console.WriteLine("Leaving BL2");
			//return stuff
		}
	}
}
