using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Interface_MsSql_Oracle
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cls_CRUD cls_CRUD = new Cls_CRUD(new Oracle());
			label1.Text = cls_CRUD.insert();
			label2.Text = cls_CRUD.delete();
			label3.Text = cls_CRUD.update();
			label4.Text = new string('-',100);
		}
	}
}
