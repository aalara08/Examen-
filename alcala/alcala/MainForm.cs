/*
 * Created by SharpDevelop.
 * User: CC2_PC41
 * Date: 29/10/2024
 * Time: 03:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace alcala
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			if(comboBoxMaterias.SelectedItem!=null)
			{
				if(comboBoxMaterias.SelectedItem.ToString()=="Ecologia")
				{
					ecologia ecologia = new ecologia();
					ecologia.Show();
				}
				else if(comboBoxMaterias.SelectedItem.ToString()=="Ingles")
				{
					Ingles ingles = new Ingles();
					ingles.Show();
				}
				else if(comboBoxMaterias.SelectedItem.ToString()=="Humanidades")
				{
					Humanidades humanidades = new Humanidades();
					humanidades.Show();
				}
				
			}
		}
	}
}
