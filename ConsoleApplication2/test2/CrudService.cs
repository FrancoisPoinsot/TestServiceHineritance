using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.test2
{
	interface ICrudService
	{
		object Post(object data);
	}

	class CrudService: ICrudService
	{
		public CrudService Next;

		public virtual object Post(object data)
		{ return Next?.Post(data); }
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
		public override object Post(object dataobject)
		{
			Model2 data = getData(dataobject);
			//do stuff
			Console.WriteLine("Enter logger2: " + data.otherStuff);
			var returnvalue=base.Post(data);
			Console.WriteLine("Leaving logger2");

			return returnvalue;
			//log stuff
		}
	}

	class BL2 : ServiceModel2
	{
		public override object Post(object dataobject)
		{
			Model2 data = getData(dataobject);
			//do stuff
			Console.WriteLine("Enter BL2: " + data.otherStuff);
			return new Model2();
			Console.WriteLine("Leaving BL2");
			//return stuff
		}
	}
}
