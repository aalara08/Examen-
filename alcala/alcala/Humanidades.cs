/*
 * Created by SharpDevelop.
 * User: novar
 * Date: 01/11/2024
 * Time: 11:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace alcala
{
	/// <summary>
	/// Description of Humanidades.
	/// </summary>
	public partial class Humanidades : Form
	{
		public Humanidades()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSalirHumaClick(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
