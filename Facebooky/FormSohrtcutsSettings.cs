using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facebooky
{
	public partial class FormShortcutsSettings : Form
	{
		private readonly IDictionary<string, string> r_ShortcutsDictionary;

		public FormShortcutsSettings(IDictionary<string, string> i_ShortcutsDictionary)
		{
			this.r_ShortcutsDictionary = i_ShortcutsDictionary;
			InitializeComponent();
			foreach (KeyValuePair<string, string> item in this.r_ShortcutsDictionary)
			{
				listBoxShortcutsList.Items.Add(item);
			}
		}

		private void buttonAdd_Click(object i_Sender, EventArgs i_Args)
		{
			if (isInputLegal(textBoxFrom.Text, textBoxTo.Text))
			{
				KeyValuePair<string, string> item = new KeyValuePair<string, string>(textBoxFrom.Text, textBoxTo.Text);
				r_ShortcutsDictionary.Add(item);
				listBoxShortcutsList.Items.Add(item);
				textBoxFrom.Text = textBoxTo.Text = string.Empty;
			}
		}

		private bool isInputLegal(string i_From, string i_To)
		{
			return !string.IsNullOrEmpty(i_From)
				&& !string.IsNullOrEmpty(i_To)
				&& !this.r_ShortcutsDictionary.ContainsKey(i_From);
		}

		private void buttonRemoveSelected_Click(object i_Sender, EventArgs i_Args)
		{
			if (listBoxShortcutsList.SelectedItem != null)
			{
				KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)listBoxShortcutsList.SelectedItem;
				r_ShortcutsDictionary.Remove(selectedItem.Key);
				listBoxShortcutsList.Items.Remove(selectedItem);
			}
		}
	}
}