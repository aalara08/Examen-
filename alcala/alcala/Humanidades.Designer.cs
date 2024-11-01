/*
 * Created by SharpDevelop.
 * User: novar
 * Date: 01/11/2024
 * Time: 11:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace alcala
{
	partial class Humanidades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Humanidades));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSalirHuma = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 59);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(623, 585);
			this.label1.TabIndex = 1;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(239, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(222, 41);
			this.label2.TabIndex = 2;
			this.label2.Text = "Humanidades";
			// 
			// btnSalirHuma
			// 
			this.btnSalirHuma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalirHuma.Location = new System.Drawing.Point(262, 662);
			this.btnSalirHuma.Name = "btnSalirHuma";
			this.btnSalirHuma.Size = new System.Drawing.Size(184, 47);
			this.btnSalirHuma.TabIndex = 3;
			this.btnSalirHuma.Text = "Salir";
			this.btnSalirHuma.UseVisualStyleBackColor = true;
			this.btnSalirHuma.Click += new System.EventHandler(this.BtnSalirHumaClick);
			// 
			// Humanidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(721, 721);
			this.Controls.Add(this.btnSalirHuma);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Humanidades";
			this.Text = "Humanidades";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalirHuma;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
