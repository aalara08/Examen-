﻿/*
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
			ecologia ecologia = new ecologia();
			ecologia.Show();
		}
	}
}