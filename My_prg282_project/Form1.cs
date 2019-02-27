using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Threading;
	

namespace My_prg282_project
{

	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}
		public int xAxis;
		public int yAxis;
		private void Form1_Load(object sender, EventArgs e)
		{
			//pbAirPlane.Location = (12, 152);

			xAxis = int.Parse(pbAirPlane.Location.X.ToString());
			yAxis = int.Parse(pbAirPlane.Location.Y.ToString());

			lblXaxis.Text = xAxis.ToString();
			lblYaxis.Text = yAxis.ToString();

			//timer1.Start();
			// Hides first group of Text
			lblCoordinates.Visible = false;
			txtUserCoordsX.Visible = false;
			lblX.Visible = false;
			lblY.Visible = false;
			txtUserCoordsY.Visible = false;
			btnMove.Visible = false;

			// Hides Second group Text
			lblCoordinateTwo.Visible = false;
			txtXCoordinateTwo.Visible = false;
			lblXTwo.Visible = false;
			lblYaxis.Visible = false;
			txtYCoordinateTwo.Visible = false;
			btnMoveTwo.Visible = false;
			lblYTwo.Visible = false;

			// Hides Second group Text
			lblCoordinateThree.Visible = false;
			txtXCoordinateThree.Visible = false;
			lblXThree.Visible = false;
			lblXThree.Visible = false;
			txtYCoordinateThree.Visible = false;
			btnMoveThree.Visible = false;
			lblYThree.Visible = false;

		}

		public void Calculation()
		{
			
		
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();

			

			//pbTankOne.Location.X = xObstacle1;

			xAxis = int.Parse(pbAirPlane.Location.X.ToString());
			yAxis = int.Parse(pbAirPlane.Location.Y.ToString());

			txtUserCoordsX.Text = xAxis.ToString();
			txtUserCoordsY.Text = yAxis.ToString();

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			/*xAxis = int.Parse(pbAirPlane.Location.X.ToString());
			yAxis = int.Parse(pbAirPlane.Location.Y.ToString());

			lblXaxis.Text = "X: " + xAxis.ToString();
			lblYaxis.Text = "Y: " + yAxis.ToString();
			

			int xObstacle2 = int.Parse(pbTankTwo.Location.X.ToString());
			int yObstacle2 = int.Parse(pbTankTwo.Location.Y.ToString());

			int xObstacle3 = int.Parse(pbTankThree.Location.X.ToString());
			int yObstacle3 = int.Parse(pbTankThree.Location.Y.ToString());

			while (true)
			{
				xAxis++;
				if (yObstacle1 == yAxis && xObstacle1 == xAxis - 1)
				{
					yAxis = yAxis + 1;

				}
			}  */

			// AVOIDING THE TANK
			int distAvoidance = pbAirPlane.Location.X - pbTankOne.Location.X;

			if (distAvoidance <= 100 )
			{
				/*while (!distAvoidance!<=-10)
				{ 
					xAxis += 10;
				}*/
					
				
			}


			double planeX, planeY, EnemybaseX, EnemybaseY;
			planeX = pbAirPlane.Location.X;
			planeY = pbAirPlane.Location.Y;
			EnemybaseX = btnEnemyCamp.Location.X;
			EnemybaseY = btnEnemyCamp.Location.Y;

			int xObstacle1 = int.Parse(pbTankOne.Location.X.ToString());
			int yObstacle1 = int.Parse(pbTankOne.Location.Y.ToString());

			lblXaxis.Text = String.Format(" Plane X : {0}", pbAirPlane.Location.X.ToString());
			lblYaxis.Text = String.Format(" Plane Y : {0}", pbAirPlane.Location.Y.ToString());
			int step = 1;

			int xDistance, yDistance;

			int XBaseDifference = btnEnemyCamp.Location.X - pbAirPlane.Location.X;
			int YBaseDifference = pbAirPlane.Location.Y - btnEnemyCamp.Location.Y;


			if (pbAirPlane.Location.X == pbTankOne.Location.X && pbAirPlane.Location.Y == pbTankOne.Location.Y)
			{
				timer1.Stop();
				MessageBox.Show("We just passed a Tank depo");
				//InitializeTimer2();
				//SuccessFullyBombed = true;

				//pbAirPlane.Image = Properties.Resources.Explotion;
			}


			if (pbAirPlane.Location.X == 670)
			{
				timer1.Stop();
				MessageBox.Show("We have reached the enemies camp!, mayday");
				//InitializeTimer2();
				//SuccessFullyBombed = true;

				//pbAirPlane.Image = Properties.Resources.Explotion;
			}
			else
			{
				

				if (pbAirPlane.Location.X < btnEnemyCamp.Location.X)
				{
					pbAirPlane.Location = new Point(pbAirPlane.Location.X + step, pbAirPlane.Location.Y);
					if (pbAirPlane.Location.Y >= pbTankOne.Location.Y && pbAirPlane.Location.Y <= pbTankOne.Location.Y && pbAirPlane.Location.X < pbTankOne.Location.X - 20)
					{
						pbAirPlane.Location = new Point(pbAirPlane.Location.X + step, pbTankOne.Location.Y - step);

						if (pbAirPlane.Location.Y == pbTankOne.Location.Y)
						{
							/*if (pbAirPlane.Location.X==pbTankOne.Location.X-1)
							{

							}*/
							if (pbAirPlane.Location.X >= pbTankOne.Location.X && pbTankOne.Location.Y >= pbTankOne.Location.Y)
							{
								//Regs Onder
								xDistance = pbAirPlane.Location.X - pbTankOne.Location.X;
								yDistance = pbAirPlane.Location.Y - pbTankOne.Location.Y;
								//Flag = "RO";
							}

						}

					}
					if (pbAirPlane.Location.Y >= pbTankTwo.Location.Y && pbAirPlane.Location.Y <= pbTankTwo.Location.Y && pbAirPlane.Location.X < pbTankTwo.Location.X - 20)
					{
						pbAirPlane.Location = new Point(pbAirPlane.Location.X + step, pbTankTwo.Location.Y + step);
					}
				}
				else
				{
					
					timer1.Enabled = false;
				}

			}
		}

		private void pbTankOne_Click(object sender, EventArgs e)
		{
			lblCoordinates.Visible = true;
			txtUserCoordsX.Visible = true;
			lblX.Visible = true;
			lblY.Visible = true;
			txtUserCoordsY.Visible = true;
			btnMove.Visible = true;
		}

		private void pbTankOne_DragEnter(object sender, DragEventArgs e)
		{
			
		}

		private void pbTankOne_DragDrop(object sender, DragEventArgs e)
		{
			
		}

		private void pbTankOne_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void btnMove_Click(object sender, EventArgs e)
		{
			int xObstacle1 = int.Parse(txtUserCoordsX.Text);
			int yObstacle1 = int.Parse(txtUserCoordsY.Text);

			pbTankOne.Location.X.Equals(xObstacle1);
			pbTankOne.Location.Y.Equals(yObstacle1);

			pbTankOne.Location = new Point(xObstacle1, yObstacle1);

			lblCoordinates.Visible = false;
			txtUserCoordsX.Visible = false;
			lblX.Visible = false;
			lblY.Visible = false;
			txtUserCoordsY.Visible = false;
			btnMove.Visible = false;
		}

		private void pbTankTwo_Click(object sender, EventArgs e)
		{
			lblCoordinateTwo.Visible = true;
			txtXCoordinateTwo.Visible = true;
			lblXTwo.Visible = true;
			lblYaxis.Visible = true;
			txtYCoordinateTwo.Visible = true;
			btnMoveTwo.Visible = true;
			lblYTwo.Visible = true;
		}

		private void btnMoveTwo_Click(object sender, EventArgs e)
		{
			int xObstacle2 = int.Parse(txtXCoordinateTwo.Text);
			int yObstacle2 = int.Parse(txtYCoordinateTwo.Text);

			pbTankTwo.Location.X.Equals(xObstacle2);
			pbTankTwo.Location.Y.Equals(yObstacle2);

			pbTankTwo.Location = new Point(xObstacle2, yObstacle2);

			lblCoordinateTwo.Visible = false;
			txtXCoordinateTwo.Visible = false;
			lblXTwo.Visible = false;
			lblYTwo.Visible = false;
			txtYCoordinateTwo.Visible = false;
			btnMoveTwo.Visible = false;

		}

		private void pbTankThree_Click(object sender, EventArgs e)
		{
			lblCoordinateThree.Visible = true;
			txtXCoordinateThree.Visible = true;
			lblXThree.Visible = true;
			lblXThree.Visible = true;
			txtYCoordinateThree.Visible = true;
			btnMoveThree.Visible = true;
			lblYThree.Visible = true;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			int xObstacle3 = int.Parse(txtXCoordinateThree.Text);
			int yObstacle3 = int.Parse(txtYCoordinateThree.Text);

			pbTankTwo.Location.X.Equals(xObstacle3);
			pbTankTwo.Location.Y.Equals(yObstacle3);

			pbTankTwo.Location = new Point(xObstacle3, yObstacle3);

			lblCoordinateThree.Visible = false;
			txtXCoordinateThree.Visible = false;
			lblXThree.Visible = false;
			lblYThree.Visible = false;
			txtYCoordinateThree.Visible = false;
			btnMoveThree.Visible = false;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
