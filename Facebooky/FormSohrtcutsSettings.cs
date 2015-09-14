using System;
using System.Collections.Specialized;
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
			foreach (string key in r_ShortcutsDickDictionary.Keys)
			{
				listBoxShortcutsList.Items.Add(key);
			}
			listBoxShortcutsList.SelectedIndexChanged += listBoxShortcutsListOnSelectedIndexChanged;
		}

		private void listBoxShortcutsListOnSelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
		{
			if (listBoxShortcutsList.SelectedItem != null)
			{
				textBox1.Text = r_ShortcutsDickDictionary[listBoxShortcutsList.SelectedItem.ToString()];
			}
			else
			{
				{
					textBox1.Text = "";
				}
			}
		}

		private void buttonAdd_Click(object i_Sender, EventArgs i_Args)
		{
			if (isInputLegal(textBoxFrom.Text, textBoxTo.Text))
			{
				r_ShortcutsDickDictionary.Add(textBoxFrom.Text, textBoxTo.Text);
				listBoxShortcutsList.Items.Add(textBoxFrom.Text);
			}
		}

		private bool isInputLegal(string i_From, string i_To)
		{
			bool legalReplace = !r_ShortcutsDickDictionary.ContainsKey(i_From);

			if (i_From == null || i_To == null || 0 <= i_To.IndexOf(i_From))
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

		private void btnRemoveSelected_Click(object i_Sender, EventArgs i_Args)
		{
			string selectedKey = listBoxShortcutsList.SelectedItem.ToString();
			r_ShortcutsDickDictionary.Remove(selectedKey);
			listBoxShortcutsList.Items.Remove(selectedKey);
		}
	}
}
