using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.test3
{
	//nope nope nope
	class Service
	{
		public Service Next;
		public Dictionary<string, Func<object,object>> AvailableEndPoints=new Dictionary<string, Func<object, object>>();

		protected object callNext(string funcName, object dataObject)
		{ return Next.call(funcName, dataObject); }

		protected object call(string funcName, object dataObject)
		{
			Func<object, object> localFunc;
			
			if (AvailableEndPoints.TryGetValue(funcName, out localFunc)){
				return localFunc(dataObject);
			} else{
				return Next?.call(funcName, dataObject);
			}
		}
	}

	abstract class CrudService : Service
	{
		public CrudService()
		{
			AvailableEndPoints.Add("Post", (object _dataObject) => {

					return callNext("Post",_dataObject);
				}
			);
		}
	}
}
