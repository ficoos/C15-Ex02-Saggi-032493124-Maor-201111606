using System;
using System.Windows.Forms;

namespace Facebooky
{
	public partial class FormEditFilterGroup : Form
	{
		public PostFilterGroup FilterGroup { get; set; }

		public FormEditFilterGroup()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs i_Args)
		{
			loadFilterGroup();
			base.OnShown(i_Args);
		}

		private void loadFilterGroup()
		{
			postFilterGroupBindingSource.DataSource = FilterGroup;
			this.comboBoxPriority.Items.Add(ePostPriority.Demoted);
			this.comboBoxPriority.Items.Add(ePostPriority.Hidden);
			this.comboBoxPriority.Items.Add(ePostPriority.Promoted);
			comboBoxPriority.Text = ((PostFilterGroup)postFilterGroupBindingSource.Current).PostPriority.ToString();
		}

		private void buttonAddFilter_Click(object i_Sender, EventArgs i_Args)
		{
			if (textBoxAddFilter.Text.Length > 0)
			{
				RegexPostFilter newFilter = new RegexPostFilter(textBoxAddFilter.Text);
				postFiltersBindingSource.Add(newFilter);
				textBoxAddFilter.Text = string.Empty;
			}
		}

		private void buttonClose_Click(object i_Sender, EventArgs i_Args)
		{
			Close();
		}

		private void buttonRemoveSelectedFilter_Click(object i_Sender, EventArgs i_Args)
		{
			postFiltersBindingSource.RemoveCurrent();
		}

		private void comboBoxPriority_SelectionChangeCommitted(object i_Sender, EventArgs i_Args)
		{
			((PostFilterGroup)postFilterGroupBindingSource.Current).PostPriority = (ePostPriority)comboBoxPriority.SelectedItem;
		}

		private void checkedListBoxFilterFilters_ItemCheck(object i_Sender, ItemCheckEventArgs i_Args)
		{
			IPostFilter filter = (IPostFilter)postFiltersBindingSource.Current;
			switch (i_Args.NewValue)
			{
				case CheckState.Unchecked:
					filter.Enabled = false;
					break;
				case CheckState.Checked:
					filter.Enabled = true;
					break;
			}
		}

		private void postFiltersBindingSource_ListChanged(object i_Sender, System.ComponentModel.ListChangedEventArgs i_Args)
		{
			checkedListBoxFilterFilters.UpdateValueBinding();
		}
	}
}
