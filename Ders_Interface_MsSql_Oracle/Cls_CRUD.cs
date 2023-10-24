using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_Interface_MsSql_Oracle
{
	public class Cls_CRUD
	{
        private IRepository db;
        public Cls_CRUD(IRepository db)
        {
            this.db = db;
        }

        public string delete ()
        {
            return db.delete();
        }

		public string insert()
		{
			return db.insert();
		}

		public string update()
		{
			return db.update();
		}
	}
}
