/*
 * Created by SharpDevelop.
 * User: novar
 * Date: 01/11/2024
 * Time: 11:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace alcala
{
	partial class Ingles
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingles));
			this.tobe = new System.Windows.Forms.Label();
			this.lblIngles = new System.Windows.Forms.Label();
			this.btnLeer = new System.Windows.Forms.Button();
			this.btnSalirIng = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tobe
			// 
			this.tobe.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tobe.Location = new System.Drawing.Point(159, 26);
			this.tobe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.tobe.Name = "tobe";
			this.tobe.Size = new System.Drawing.Size(234, 47);
			this.tobe.TabIndex = 1;
			this.tobe.Text = "Verbo to be";
			this.tobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblIngles
			// 
			this.lblIngles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIngles.Location = new System.Drawing.Point(37, 102);
			this.lblIngles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIngles.Name = "lblIngles";
			this.lblIngles.Size = new System.Drawing.Size(483, 383);
			this.lblIngles.TabIndex = 2;
			this.lblIngles.Text = resources.GetString("lblIngles.Text");
			this.lblIngles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnLeer
			// 
			this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLeer.Location = new System.Drawing.Point(384, 511);
			this.btnLeer.Margin = new System.Windows.Forms.Padding(4);
			this.btnLeer.Name = "btnLeer";
			this.btnLeer.Size = new System.Drawing.Size(136, 41);
			this.btnLeer.TabIndex = 3;
			this.btnLeer.Text = "Leer";
			this.btnLeer.UseVisualStyleBackColor = true;
			this.btnLeer.Click += new System.EventHandler(this.BtnLeerClick);
			// 
			// btnSalirIng
			// 
			this.btnSalirIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalirIng.Location = new System.Drawing.Point(37, 511);
			this.btnSalirIng.Name = "btnSalirIng";
			this.btnSalirIng.Size = new System.Drawing.Size(136, 41);
			this.btnSalirIng.TabIndex = 4;
			this.btnSalirIng.Text = "Salir";
			this.btnSalirIng.UseVisualStyleBackColor = true;
			this.btnSalirIng.Click += new System.EventHandler(this.BtnSalirIngClick);
			// 
			// Ingles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(566, 594);
			this.Controls.Add(this.btnSalirIng);
			this.Controls.Add(this.btnLeer);
			this.Controls.Add(this.lblIngles);
			this.Controls.Add(this.tobe);
			this.Name = "Ingles";
			this.Text = "Ingles";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalirIng;
		private System.Windows.Forms.Button btnLeer;
		private System.Windows.Forms.Label lblIngles;
		private System.Windows.Forms.Label tobe;
	}
}
