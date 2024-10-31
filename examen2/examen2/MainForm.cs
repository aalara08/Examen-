/*
 * Created by SharpDevelop.
 * User: CC2_PC46
 * Date: 29/10/2024
 * Time: 03:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace examen2
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
		
		
		void Button1Click(object sender, EventArgs e)
		{
			SpeechSynthesizer s = new SpeechSynthesizer();
			string texto = ingles.Text;
			s.Speak(texto);
		}
	}
}