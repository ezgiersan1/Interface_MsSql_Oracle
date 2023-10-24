using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_Interface_MsSql_Oracle
{
	public interface IRepository
	{
		string insert();
		string update();
		string delete();
	}
}
