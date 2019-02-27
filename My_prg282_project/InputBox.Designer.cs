namespace My_prg282_project
{
	partial class InputBox
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtUserCoordsX = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserCoordsY = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(30, 94);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(154, 23);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.Text = "SUBMIT";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtUserCoordsX
			// 
			this.txtUserCoordsX.Location = new System.Drawing.Point(30, 52);
			this.txtUserCoordsX.Name = "txtUserCoordsX";
			this.txtUserCoordsX.Size = new System.Drawing.Size(46, 20);
			this.txtUserCoordsX.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter Coordinates";
			// 
			// txtUserCoordsY
			// 
			this.txtUserCoordsY.Location = new System.Drawing.Point(132, 52);
			this.txtUserCoordsY.Name = "txtUserCoordsY";
			this.txtUserCoordsY.Size = new System.Drawing.Size(52, 20);
			this.txtUserCoordsY.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "X :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(106, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Y :";
			// 
			// InputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(225, 129);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUserCoordsY);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUserCoordsX);
			this.Controls.Add(this.btnSubmit);
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtUserCoordsX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserCoordsY;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}