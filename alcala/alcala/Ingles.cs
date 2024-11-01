/*
 * Created by SharpDevelop.
 * User: novar
 * Date: 01/11/2024
 * Time: 11:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace alcala
{
	/// <summary>
	/// Description of Ingles.
	/// </summary>
	public partial class Ingles : Form
	{
		public Ingles()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnLeerClick(object sender, EventArgs e)
		{
			SpeechSynthesizer s = new SpeechSynthesizer();
			string texto = lblIngles.Text;
			s.Speak(texto);
		}
		
		void BtnSalirIngClick(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
