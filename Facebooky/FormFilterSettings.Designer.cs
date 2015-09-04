namespace Facebooky
{
    partial class FormFilterSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.checkedListBoxFilterGroups = new System.Windows.Forms.CheckedListBox();
			this.postFilterGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonAddGroup = new System.Windows.Forms.Button();
			this.buttonRemoveSelectedGroups = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonEditMarked = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.postFilterGroupBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// checkedListBoxFilterGroups
			// 
			this.checkedListBoxFilterGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkedListBoxFilterGroups.DataSource = this.postFilterGroupBindingSource;
			this.checkedListBoxFilterGroups.DisplayMember = "Name";
			this.checkedListBoxFilterGroups.FormattingEnabled = true;
			this.checkedListBoxFilterGroups.Location = new System.Drawing.Point(11, 6);
			this.checkedListBoxFilterGroups.Margin = new System.Windows.Forms.Padding(2);
			this.checkedListBoxFilterGroups.Name = "checkedListBoxFilterGroups";
			this.checkedListBoxFilterGroups.Size = new System.Drawing.Size(447, 379);
			this.checkedListBoxFilterGroups.TabIndex = 1;
			this.checkedListBoxFilterGroups.ValueMember = "Enabled";
			this.checkedListBoxFilterGroups.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFilterGroups_ItemCheck);
			// 
			// postFilterGroupBindingSource
			// 
			this.postFilterGroupBindingSource.DataSource = typeof(Facebooky.PostFilterGroup);
			this.postFilterGroupBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.postFilterGroupBindingSource_ListChanged);
			// 
			// buttonAddGroup
			// 
			this.buttonAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddGroup.Location = new System.Drawing.Point(462, 6);
			this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAddGroup.Name = "buttonAddGroup";
			this.buttonAddGroup.Size = new System.Drawing.Size(176, 38);
			this.buttonAddGroup.TabIndex = 0;
			this.buttonAddGroup.Text = "Add New Group";
			this.buttonAddGroup.UseVisualStyleBackColor = true;
			this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
			// 
			// buttonRemoveSelectedGroups
			// 
			this.buttonRemoveSelectedGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveSelectedGroups.Location = new System.Drawing.Point(462, 48);
			this.buttonRemoveSelectedGroups.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRemoveSelectedGroups.Name = "buttonRemoveSelectedGroups";
			this.buttonRemoveSelectedGroups.Size = new System.Drawing.Size(176, 38);
			this.buttonRemoveSelectedGroups.TabIndex = 2;
			this.buttonRemoveSelectedGroups.Text = "Remove Selected Groups";
			this.buttonRemoveSelectedGroups.UseVisualStyleBackColor = true;
			this.buttonRemoveSelectedGroups.Click += new System.EventHandler(this.buttonRemoveSelectedGroups_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(462, 366);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(176, 27);
			this.buttonClose.TabIndex = 4;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonEditMarked
			// 
			this.buttonEditMarked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEditMarked.Location = new System.Drawing.Point(462, 90);
			this.buttonEditMarked.Margin = new System.Windows.Forms.Padding(2);
			this.buttonEditMarked.Name = "buttonEditMarked";
			this.buttonEditMarked.Size = new System.Drawing.Size(176, 34);
			this.buttonEditMarked.TabIndex = 3;
			this.buttonEditMarked.Text = "Edit Marked";
			this.buttonEditMarked.UseVisualStyleBackColor = true;
			this.buttonEditMarked.Click += new System.EventHandler(this.buttonEditMarked_Click);
			// 
			// FormFilterSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 398);
			this.Controls.Add(this.buttonEditMarked);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonRemoveSelectedGroups);
			this.Controls.Add(this.buttonAddGroup);
			this.Controls.Add(this.checkedListBoxFilterGroups);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormFilterSettings";
			this.Text = "Filter Setttings";
			this.Load += new System.EventHandler(this.filterSettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.postFilterGroupBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxFilterGroups;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonRemoveSelectedGroups;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonEditMarked;
		private System.Windows.Forms.BindingSource postFilterGroupBindingSource;
    }
}