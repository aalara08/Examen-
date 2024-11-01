/*
 * Created by SharpDevelop.
 * User: CC2_PC41
 * Date: 29/10/2024
 * Time: 03:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace alcala
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
			this.comboBoxMaterias = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxMaterias
			// 
			this.comboBoxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxMaterias.FormattingEnabled = true;
			this.comboBoxMaterias.Items.AddRange(new object[] {
									"Matematicas",
									"Ingles",
									"Fisica",
									"Humanidades",
									"Ecologia"});
			this.comboBoxMaterias.Location = new System.Drawing.Point(92, 159);
			this.comboBoxMaterias.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxMaterias.Name = "comboBoxMaterias";
			this.comboBoxMaterias.Size = new System.Drawing.Size(221, 28);
			this.comboBoxMaterias.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(124, 9);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 73);
			this.label5.TabIndex = 6;
			this.label5.Text = "Menu";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnEntrar
			// 
			this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.Location = new System.Drawing.Point(232, 222);
			this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(148, 52);
			this.btnEntrar.TabIndex = 7;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(28, 222);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(148, 52);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(384, 64);
			this.label1.TabIndex = 9;
			this.label1.Text = "Selecciona una materia para mostar:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(413, 306);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxMaterias);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Menu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxMaterias;
		private System.Windows.Forms.Label label1;
	}
}
