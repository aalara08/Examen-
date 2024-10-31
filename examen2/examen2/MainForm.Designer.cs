/*
 * Created by SharpDevelop.
 * User: CC2_PC46
 * Date: 29/10/2024
 * Time: 03:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace examen2
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tobe = new System.Windows.Forms.Label();
			this.ingles = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tobe
			// 
			this.tobe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tobe.Location = new System.Drawing.Point(109, 23);
			this.tobe.Name = "tobe";
			this.tobe.Size = new System.Drawing.Size(139, 38);
			this.tobe.TabIndex = 0;
			this.tobe.Text = "Verbo to be";
			// 
			// ingles
			// 
			this.ingles.Location = new System.Drawing.Point(12, 72);
			this.ingles.Name = "ingles";
			this.ingles.Size = new System.Drawing.Size(362, 233);
			this.ingles.TabIndex = 1;
			this.ingles.Text = resources.GetString("ingles.Text");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(161, 308);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "LEER";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 379);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ingles);
			this.Controls.Add(this.tobe);
			this.Name = "MainForm";
			this.Text = "examen2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label ingles;
		private System.Windows.Forms.Label tobe;
	}
}
