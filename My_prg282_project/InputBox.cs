using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_prg282_project
{
	public partial class InputBox : Form
	{
		public InputBox()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			int xObstacle1 = int.Parse(txtUserCoordsX.Text);
			int yObstacle1 = int.Parse(txtUserCoordsY.Text);

			
		}
	}
}
