using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_Interface_MsSql_Oracle
{
	public class Oracle : IRepository
	{
		public string delete()
		{
			return "Oracle delete";
		}

		public string insert()
		{
			return "Oracle insert";
		}

		public string update()
		{
			return "Oracle update";
		}
	}
}
