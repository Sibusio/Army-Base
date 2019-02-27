namespace My_prg282_project
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblXaxis = new System.Windows.Forms.Label();
			this.lblYaxis = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtUserCoordsX = new System.Windows.Forms.TextBox();
			this.lblCoordinates = new System.Windows.Forms.Label();
			this.txtUserCoordsY = new System.Windows.Forms.TextBox();
			this.lblX = new System.Windows.Forms.Label();
			this.lblY = new System.Windows.Forms.Label();
			this.btnHospital = new System.Windows.Forms.Button();
			this.btnMove = new System.Windows.Forms.Button();
			this.btnMoveTwo = new System.Windows.Forms.Button();
			this.lblYTwo = new System.Windows.Forms.Label();
			this.lblXTwo = new System.Windows.Forms.Label();
			this.txtYCoordinateTwo = new System.Windows.Forms.TextBox();
			this.lblCoordinateTwo = new System.Windows.Forms.Label();
			this.txtXCoordinateTwo = new System.Windows.Forms.TextBox();
			this.btnMoveThree = new System.Windows.Forms.Button();
			this.lblYThree = new System.Windows.Forms.Label();
			this.txtYCoordinateThree = new System.Windows.Forms.TextBox();
			this.lblCoordinateThree = new System.Windows.Forms.Label();
			this.txtXCoordinateThree = new System.Windows.Forms.TextBox();
			this.lblXThree = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOffice = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pb_AirPlane_Parking = new System.Windows.Forms.PictureBox();
			this.pbTankTwo = new System.Windows.Forms.PictureBox();
			this.pbTankThree = new System.Windows.Forms.PictureBox();
			this.btnEnemyCamp = new System.Windows.Forms.Button();
			this.pbTankOne = new System.Windows.Forms.PictureBox();
			this.pbAirPlane = new System.Windows.Forms.PictureBox();
			this.btnTankDepot = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_AirPlane_Parking)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTankTwo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTankThree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTankOne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAirPlane)).BeginInit();
			this.SuspendLayout();
			// 
			// lblXaxis
			// 
			this.lblXaxis.AutoSize = true;
			this.lblXaxis.Location = new System.Drawing.Point(3, 7);
			this.lblXaxis.Name = "lblXaxis";
			this.lblXaxis.Size = new System.Drawing.Size(14, 13);
			this.lblXaxis.TabIndex = 1;
			this.lblXaxis.Text = "X";
			// 
			// lblYaxis
			// 
			this.lblYaxis.AutoSize = true;
			this.lblYaxis.Location = new System.Drawing.Point(48, 7);
			this.lblYaxis.Name = "lblYaxis";
			this.lblYaxis.Size = new System.Drawing.Size(14, 13);
			this.lblYaxis.TabIndex = 3;
			this.lblYaxis.Text = "Y";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.lblYaxis);
			this.panel1.Controls.Add(this.lblXaxis);
			this.panel1.Location = new System.Drawing.Point(700, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(95, 30);
			this.panel1.TabIndex = 4;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 404);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(149, 34);
			this.btnStart.TabIndex = 5;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtUserCoordsX
			// 
			this.txtUserCoordsX.Location = new System.Drawing.Point(33, 346);
			this.txtUserCoordsX.Name = "txtUserCoordsX";
			this.txtUserCoordsX.Size = new System.Drawing.Size(41, 20);
			this.txtUserCoordsX.TabIndex = 14;
			// 
			// lblCoordinates
			// 
			this.lblCoordinates.AutoSize = true;
			this.lblCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCoordinates.Location = new System.Drawing.Point(30, 316);
			this.lblCoordinates.Name = "lblCoordinates";
			this.lblCoordinates.Size = new System.Drawing.Size(122, 16);
			this.lblCoordinates.TabIndex = 15;
			this.lblCoordinates.Text = "Enter Coordninates";
			// 
			// txtUserCoordsY
			// 
			this.txtUserCoordsY.Location = new System.Drawing.Point(102, 346);
			this.txtUserCoordsY.Name = "txtUserCoordsY";
			this.txtUserCoordsY.Size = new System.Drawing.Size(47, 20);
			this.txtUserCoordsY.TabIndex = 16;
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(12, 349);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(17, 13);
			this.lblX.TabIndex = 17;
			this.lblX.Text = "X:";
			// 
			// lblY
			// 
			this.lblY.AutoSize = true;
			this.lblY.Location = new System.Drawing.Point(80, 349);
			this.lblY.Name = "lblY";
			this.lblY.Size = new System.Drawing.Size(17, 13);
			this.lblY.TabIndex = 18;
			this.lblY.Text = "Y:";
			// 
			// btnHospital
			// 
			this.btnHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHospital.Location = new System.Drawing.Point(408, 36);
			this.btnHospital.Name = "btnHospital";
			this.btnHospital.Size = new System.Drawing.Size(74, 130);
			this.btnHospital.TabIndex = 19;
			this.btnHospital.Text = "Hospital";
			this.btnHospital.UseVisualStyleBackColor = true;
			// 
			// btnMove
			// 
			this.btnMove.Location = new System.Drawing.Point(15, 373);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new System.Drawing.Size(146, 23);
			this.btnMove.TabIndex = 21;
			this.btnMove.Text = "MOVE";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnMoveTwo
			// 
			this.btnMoveTwo.Location = new System.Drawing.Point(178, 373);
			this.btnMoveTwo.Name = "btnMoveTwo";
			this.btnMoveTwo.Size = new System.Drawing.Size(146, 23);
			this.btnMoveTwo.TabIndex = 27;
			this.btnMoveTwo.Text = "MOVE";
			this.btnMoveTwo.UseVisualStyleBackColor = true;
			this.btnMoveTwo.Click += new System.EventHandler(this.btnMoveTwo_Click);
			// 
			// lblYTwo
			// 
			this.lblYTwo.AutoSize = true;
			this.lblYTwo.Location = new System.Drawing.Point(243, 349);
			this.lblYTwo.Name = "lblYTwo";
			this.lblYTwo.Size = new System.Drawing.Size(17, 13);
			this.lblYTwo.TabIndex = 26;
			this.lblYTwo.Text = "Y:";
			// 
			// lblXTwo
			// 
			this.lblXTwo.AutoSize = true;
			this.lblXTwo.Location = new System.Drawing.Point(175, 349);
			this.lblXTwo.Name = "lblXTwo";
			this.lblXTwo.Size = new System.Drawing.Size(17, 13);
			this.lblXTwo.TabIndex = 25;
			this.lblXTwo.Text = "X:";
			// 
			// txtYCoordinateTwo
			// 
			this.txtYCoordinateTwo.Location = new System.Drawing.Point(265, 346);
			this.txtYCoordinateTwo.Name = "txtYCoordinateTwo";
			this.txtYCoordinateTwo.Size = new System.Drawing.Size(47, 20);
			this.txtYCoordinateTwo.TabIndex = 24;
			// 
			// lblCoordinateTwo
			// 
			this.lblCoordinateTwo.AutoSize = true;
			this.lblCoordinateTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCoordinateTwo.Location = new System.Drawing.Point(193, 316);
			this.lblCoordinateTwo.Name = "lblCoordinateTwo";
			this.lblCoordinateTwo.Size = new System.Drawing.Size(122, 16);
			this.lblCoordinateTwo.TabIndex = 23;
			this.lblCoordinateTwo.Text = "Enter Coordninates";
			// 
			// txtXCoordinateTwo
			// 
			this.txtXCoordinateTwo.Location = new System.Drawing.Point(196, 346);
			this.txtXCoordinateTwo.Name = "txtXCoordinateTwo";
			this.txtXCoordinateTwo.Size = new System.Drawing.Size(41, 20);
			this.txtXCoordinateTwo.TabIndex = 22;
			// 
			// btnMoveThree
			// 
			this.btnMoveThree.Location = new System.Drawing.Point(345, 373);
			this.btnMoveThree.Name = "btnMoveThree";
			this.btnMoveThree.Size = new System.Drawing.Size(146, 23);
			this.btnMoveThree.TabIndex = 32;
			this.btnMoveThree.Text = "MOVE";
			this.btnMoveThree.UseVisualStyleBackColor = true;
			this.btnMoveThree.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// lblYThree
			// 
			this.lblYThree.AutoSize = true;
			this.lblYThree.Location = new System.Drawing.Point(410, 349);
			this.lblYThree.Name = "lblYThree";
			this.lblYThree.Size = new System.Drawing.Size(17, 13);
			this.lblYThree.TabIndex = 31;
			this.lblYThree.Text = "Y:";
			this.lblYThree.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtYCoordinateThree
			// 
			this.txtYCoordinateThree.Location = new System.Drawing.Point(432, 346);
			this.txtYCoordinateThree.Name = "txtYCoordinateThree";
			this.txtYCoordinateThree.Size = new System.Drawing.Size(47, 20);
			this.txtYCoordinateThree.TabIndex = 30;
			this.txtYCoordinateThree.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lblCoordinateThree
			// 
			this.lblCoordinateThree.AutoSize = true;
			this.lblCoordinateThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCoordinateThree.Location = new System.Drawing.Point(360, 316);
			this.lblCoordinateThree.Name = "lblCoordinateThree";
			this.lblCoordinateThree.Size = new System.Drawing.Size(122, 16);
			this.lblCoordinateThree.TabIndex = 29;
			this.lblCoordinateThree.Text = "Enter Coordninates";
			this.lblCoordinateThree.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtXCoordinateThree
			// 
			this.txtXCoordinateThree.Location = new System.Drawing.Point(363, 346);
			this.txtXCoordinateThree.Name = "txtXCoordinateThree";
			this.txtXCoordinateThree.Size = new System.Drawing.Size(41, 20);
			this.txtXCoordinateThree.TabIndex = 28;
			this.txtXCoordinateThree.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// lblXThree
			// 
			this.lblXThree.AutoSize = true;
			this.lblXThree.Location = new System.Drawing.Point(342, 346);
			this.lblXThree.Name = "lblXThree";
			this.lblXThree.Size = new System.Drawing.Size(20, 13);
			this.lblXThree.TabIndex = 33;
			this.lblXThree.Text = "X :";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(92, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(10, 318);
			this.panel2.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 35;
			this.label1.Text = "HOME BASE";
			// 
			// btnOffice
			// 
			this.btnOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOffice.Location = new System.Drawing.Point(557, 248);
			this.btnOffice.Name = "btnOffice";
			this.btnOffice.Size = new System.Drawing.Size(67, 84);
			this.btnOffice.TabIndex = 37;
			this.btnOffice.Text = "Office";
			this.btnOffice.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::My_prg282_project.Properties.Resources.Hospital_EnemyBase;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(429, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 35);
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			// 
			// pb_AirPlane_Parking
			// 
			this.pb_AirPlane_Parking.BackgroundImage = global::My_prg282_project.Properties.Resources.Plane_Parking;
			this.pb_AirPlane_Parking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pb_AirPlane_Parking.Location = new System.Drawing.Point(-3, 2);
			this.pb_AirPlane_Parking.Name = "pb_AirPlane_Parking";
			this.pb_AirPlane_Parking.Size = new System.Drawing.Size(100, 50);
			this.pb_AirPlane_Parking.TabIndex = 36;
			this.pb_AirPlane_Parking.TabStop = false;
			// 
			// pbTankTwo
			// 
			this.pbTankTwo.BackgroundImage = global::My_prg282_project.Properties.Resources.ArmyTank;
			this.pbTankTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbTankTwo.Location = new System.Drawing.Point(306, 63);
			this.pbTankTwo.Name = "pbTankTwo";
			this.pbTankTwo.Size = new System.Drawing.Size(49, 35);
			this.pbTankTwo.TabIndex = 13;
			this.pbTankTwo.TabStop = false;
			this.pbTankTwo.Click += new System.EventHandler(this.pbTankTwo_Click);
			// 
			// pbTankThree
			// 
			this.pbTankThree.BackgroundImage = global::My_prg282_project.Properties.Resources.ArmyTank;
			this.pbTankThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbTankThree.Location = new System.Drawing.Point(451, 237);
			this.pbTankThree.Name = "pbTankThree";
			this.pbTankThree.Size = new System.Drawing.Size(49, 35);
			this.pbTankThree.TabIndex = 12;
			this.pbTankThree.TabStop = false;
			this.pbTankThree.Click += new System.EventHandler(this.pbTankThree_Click);
			// 
			// btnEnemyCamp
			// 
			this.btnEnemyCamp.BackgroundImage = global::My_prg282_project.Properties.Resources.EnemyBaseCamp;
			this.btnEnemyCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnemyCamp.ForeColor = System.Drawing.Color.Yellow;
			this.btnEnemyCamp.Location = new System.Drawing.Point(723, 36);
			this.btnEnemyCamp.Name = "btnEnemyCamp";
			this.btnEnemyCamp.Size = new System.Drawing.Size(72, 411);
			this.btnEnemyCamp.TabIndex = 11;
			this.btnEnemyCamp.Text = "ENEMY CAMP";
			this.btnEnemyCamp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnEnemyCamp.UseVisualStyleBackColor = true;
			// 
			// pbTankOne
			// 
			this.pbTankOne.BackgroundImage = global::My_prg282_project.Properties.Resources.ArmyTank;
			this.pbTankOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbTankOne.Location = new System.Drawing.Point(239, 174);
			this.pbTankOne.Name = "pbTankOne";
			this.pbTankOne.Size = new System.Drawing.Size(49, 35);
			this.pbTankOne.TabIndex = 6;
			this.pbTankOne.TabStop = false;
			this.pbTankOne.Click += new System.EventHandler(this.pbTankOne_Click);
			this.pbTankOne.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbTankOne_DragDrop);
			this.pbTankOne.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbTankOne_DragEnter);
			this.pbTankOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbTankOne_MouseDown);
			// 
			// pbAirPlane
			// 
			this.pbAirPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbAirPlane.Image = ((System.Drawing.Image)(resources.GetObject("pbAirPlane.Image")));
			this.pbAirPlane.Location = new System.Drawing.Point(12, 174);
			this.pbAirPlane.Name = "pbAirPlane";
			this.pbAirPlane.Size = new System.Drawing.Size(66, 68);
			this.pbAirPlane.TabIndex = 0;
			this.pbAirPlane.TabStop = false;
			// 
			// btnTankDepot
			// 
			this.btnTankDepot.Location = new System.Drawing.Point(642, 137);
			this.btnTankDepot.Name = "btnTankDepot";
			this.btnTankDepot.Size = new System.Drawing.Size(75, 61);
			this.btnTankDepot.TabIndex = 39;
			this.btnTankDepot.Text = "Tank Depot";
			this.btnTankDepot.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTankDepot);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOffice);
			this.Controls.Add(this.pb_AirPlane_Parking);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.lblXThree);
			this.Controls.Add(this.btnMoveThree);
			this.Controls.Add(this.lblYThree);
			this.Controls.Add(this.txtYCoordinateThree);
			this.Controls.Add(this.lblCoordinateThree);
			this.Controls.Add(this.txtXCoordinateThree);
			this.Controls.Add(this.btnMoveTwo);
			this.Controls.Add(this.lblYTwo);
			this.Controls.Add(this.lblXTwo);
			this.Controls.Add(this.txtYCoordinateTwo);
			this.Controls.Add(this.lblCoordinateTwo);
			this.Controls.Add(this.txtXCoordinateTwo);
			this.Controls.Add(this.btnMove);
			this.Controls.Add(this.btnHospital);
			this.Controls.Add(this.lblY);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.txtUserCoordsY);
			this.Controls.Add(this.lblCoordinates);
			this.Controls.Add(this.txtUserCoordsX);
			this.Controls.Add(this.pbTankTwo);
			this.Controls.Add(this.pbTankThree);
			this.Controls.Add(this.btnEnemyCamp);
			this.Controls.Add(this.pbTankOne);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pbAirPlane);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_AirPlane_Parking)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTankTwo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTankThree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTankOne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAirPlane)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbAirPlane;
		private System.Windows.Forms.Label lblXaxis;
		private System.Windows.Forms.Label lblYaxis;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pbTankOne;
		private System.Windows.Forms.Button btnEnemyCamp;
		private System.Windows.Forms.PictureBox pbTankThree;
		private System.Windows.Forms.PictureBox pbTankTwo;
		private System.Windows.Forms.TextBox txtUserCoordsX;
		private System.Windows.Forms.Label lblCoordinates;
		private System.Windows.Forms.TextBox txtUserCoordsY;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Button btnHospital;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.Button btnMoveTwo;
		private System.Windows.Forms.Label lblYTwo;
		private System.Windows.Forms.Label lblXTwo;
		private System.Windows.Forms.TextBox txtYCoordinateTwo;
		private System.Windows.Forms.Label lblCoordinateTwo;
		private System.Windows.Forms.TextBox txtXCoordinateTwo;
		private System.Windows.Forms.Button btnMoveThree;
		private System.Windows.Forms.Label lblYThree;
		private System.Windows.Forms.TextBox txtYCoordinateThree;
		private System.Windows.Forms.Label lblCoordinateThree;
		private System.Windows.Forms.TextBox txtXCoordinateThree;
		private System.Windows.Forms.Label lblXThree;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pb_AirPlane_Parking;
		private System.Windows.Forms.Button btnOffice;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnTankDepot;
	}
}

