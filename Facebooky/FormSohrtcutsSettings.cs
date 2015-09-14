using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facebooky
{
	public partial class FormShortcutsSettings : Form
	{
		private readonly StringDictionary r_ShortcutsDickDictionary;
		public FormShortcutsSettings(StringDictionary i_ShortcutsDickDictionary)
		{
			r_ShortcutsDickDictionary = i_ShortcutsDickDictionary;
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (isInputLegal(textBoxFrom.Text,textBoxTo.Text))
			{
				r_ShortcutsDickDictionary.Add(textBoxFrom.Text, textBoxTo.Text);
			}		
		}

		private bool isInputLegal(string i_From, string i_To)
		{
			bool legalReplace = !r_ShortcutsDickDictionary.ContainsKey(i_From);

			if (i_From == null || i_To == null ||  0 <= i_To.IndexOf(i_From))
			{
				legalReplace = false;
			}
			else
			{
				foreach (string key in r_ShortcutsDickDictionary.Keys)
				{
					if (key.IndexOf(i_To) >= 0 || r_ShortcutsDickDictionary[key].IndexOf(i_From) >= 0)
					{
						legalReplace = false;
					}
				}
			}
			return legalReplace;
		}
	}
}
