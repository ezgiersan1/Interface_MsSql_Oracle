using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_Interface_MsSql_Oracle
{
	public class MsSqlDB : IRepository
	{
		public string delete()
		{
			return "MsSql delete";
		}

		public string insert()
		{
			return "MsSql insert";
		}

		public string update()
		{
			return "MsSql update";
		}
	}
}
