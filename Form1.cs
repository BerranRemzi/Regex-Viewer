using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Viewer
{
	public partial class Form1 : Form
	{
		string filePath = "";
		string fileContent = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			// Create a pattern for a word that starts with letter "M"  
			string pattern = txtFilter.Text;
			// Create a Regex  
			Regex rg = new Regex(pattern);

			// Get all matches  
			MatchCollection matchedAuthors = rg.Matches(fileContent);
			// Print all matched authors  

			txtResult.Text = "";
			for (int count = 0; count < matchedAuthors.Count; count++)
			{
				//Console.WriteLine(matchedAuthors[count].Value);
				txtResult.Text += matchedAuthors[count].Value + "\n";
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				filePath = openFileDialog.FileName;

				//Read the contents of the file into a stream
				var fileStream = openFileDialog.OpenFile();

				using (StreamReader reader = new StreamReader(fileStream))
				{
					fileContent = reader.ReadToEnd();

					txtPath.Text = filePath;
					txtInput.Text = fileContent;
				}
			}
		}
	}
}
