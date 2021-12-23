using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace QuickRun
{
	public partial class Info : Form
	{
		public Info()
		{
			InitializeComponent();
		}

		private void Info_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
		}
	}
}
