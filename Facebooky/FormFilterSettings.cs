using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facebooky
{
    public partial class FormFilterSettings : Form
    {
        public List<PostFilterGroup> PostFilterGroups { get; set; }

	    public FormFilterSettings()
	    {
		    InitializeComponent();
        }

        private void filterSettingsForm_Load(object i_Sender, EventArgs i_Args)
        {
	        postFilterGroupBindingSource.DataSource = PostFilterGroups;
        }

        private void buttonAddGroup_Click(object i_Sender, EventArgs i_Args)
        {
            FormAddNewGroup formAddGroup = new FormAddNewGroup();
            formAddGroup.ShowDialog();
            if (formAddGroup.DialogResult == DialogResult.OK)
            {
	            postFilterGroupBindingSource.Add(formAddGroup.NewFilterGroup);
            }
        }
        
		private void buttonRemoveSelectedGroups_Click(object i_Sender, EventArgs i_Args)
        {
			postFilterGroupBindingSource.RemoveCurrent();
        }

		private void buttonClose_Click(object i_Sender, EventArgs i_Args)
        {         
            this.Close();
        }

	    private void buttonEditMarked_Click(object i_Sender, EventArgs i_Args)
	    {
		    PostFilterGroup postFilterGroup = (PostFilterGroup)postFilterGroupBindingSource.Current;
		    FormEditFilterGroup editFilterGroupForm = new FormEditFilterGroup();
		    editFilterGroupForm.FilterGroup = postFilterGroup;
		    editFilterGroupForm.ShowDialog();
	    }

	    private void checkedListBoxFilterGroups_ItemCheck(object i_Sender, ItemCheckEventArgs i_Args)
		{
			PostFilterGroup group = (PostFilterGroup)checkedListBoxFilterGroups.Items[i_Args.Index];
			switch (i_Args.NewValue)
			{
				case CheckState.Unchecked:
					group.Enabled = false;
					break;
				case CheckState.Checked:
					group.Enabled = true;
					break;
			}
		}

		private void postFilterGroupBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			checkedListBoxFilterGroups.UpdateValueBinding();
		}
    }
}
