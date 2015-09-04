namespace Facebooky
{
    partial class FormEditFilterGroup
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
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonRemoveSelectedFilter = new System.Windows.Forms.Button();
			this.buttonAddFilter = new System.Windows.Forms.Button();
			this.checkedListBoxFilterFilters = new System.Windows.Forms.CheckedListBox();
			this.postFiltersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.postFilterGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBoxPriority = new System.Windows.Forms.ComboBox();
			this.textBoxAddFilter = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.postFiltersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postFilterGroupBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(11, 334);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(469, 27);
			this.buttonClose.TabIndex = 7;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonRemoveSelectedFilter
			// 
			this.buttonRemoveSelectedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveSelectedFilter.Location = new System.Drawing.Point(11, 305);
			this.buttonRemoveSelectedFilter.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRemoveSelectedFilter.Name = "buttonRemoveSelectedFilter";
			this.buttonRemoveSelectedFilter.Size = new System.Drawing.Size(469, 25);
			this.buttonRemoveSelectedFilter.TabIndex = 6;
			this.buttonRemoveSelectedFilter.Text = "Remove Selected filter";
			this.buttonRemoveSelectedFilter.UseVisualStyleBackColor = true;
			this.buttonRemoveSelectedFilter.Click += new System.EventHandler(this.buttonRemoveSelectedFilter_Click);
			// 
			// buttonAddFilter
			// 
			this.buttonAddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddFilter.Location = new System.Drawing.Point(386, 63);
			this.buttonAddFilter.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAddFilter.Name = "buttonAddFilter";
			this.buttonAddFilter.Size = new System.Drawing.Size(95, 23);
			this.buttonAddFilter.TabIndex = 4;
			this.buttonAddFilter.Text = "Add new filter";
			this.buttonAddFilter.UseVisualStyleBackColor = true;
			this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
			// 
			// checkedListBoxFilterFilters
			// 
			this.checkedListBoxFilterFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkedListBoxFilterFilters.DataSource = this.postFiltersBindingSource;
			this.checkedListBoxFilterFilters.DisplayMember = "Name";
			this.checkedListBoxFilterFilters.FormattingEnabled = true;
			this.checkedListBoxFilterFilters.Location = new System.Drawing.Point(11, 90);
			this.checkedListBoxFilterFilters.Margin = new System.Windows.Forms.Padding(2);
			this.checkedListBoxFilterFilters.Name = "checkedListBoxFilterFilters";
			this.checkedListBoxFilterFilters.Size = new System.Drawing.Size(470, 199);
			this.checkedListBoxFilterFilters.TabIndex = 5;
			this.checkedListBoxFilterFilters.ValueMember = "Enabled";
			this.checkedListBoxFilterFilters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFilterFilters_ItemCheck);
			// 
			// postFiltersBindingSource
			// 
			this.postFiltersBindingSource.DataMember = "PostFilters";
			this.postFiltersBindingSource.DataSource = this.postFilterGroupBindingSource;
			this.postFiltersBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.postFiltersBindingSource_ListChanged);
			// 
			// postFilterGroupBindingSource
			// 
			this.postFilterGroupBindingSource.DataSource = typeof(Facebooky.PostFilterGroup);
			// 
			// comboBoxPriority
			// 
			this.comboBoxPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxPriority.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.postFilterGroupBindingSource, "PostPriority", true));
			this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPriority.FormattingEnabled = true;
			this.comboBoxPriority.Location = new System.Drawing.Point(12, 25);
			this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxPriority.Name = "comboBoxPriority";
			this.comboBoxPriority.Size = new System.Drawing.Size(469, 21);
			this.comboBoxPriority.TabIndex = 1;
			this.comboBoxPriority.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPriority_SelectionChangeCommitted);
			// 
			// textBoxAddFilter
			// 
			this.textBoxAddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAddFilter.Location = new System.Drawing.Point(11, 63);
			this.textBoxAddFilter.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxAddFilter.Name = "textBoxAddFilter";
			this.textBoxAddFilter.Size = new System.Drawing.Size(371, 20);
			this.textBoxAddFilter.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Priority:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postFilterGroupBindingSource, "PostPriority", true));
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Filter Expression:";
			// 
			// FormEditFilterGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 381);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAddFilter);
			this.Controls.Add(this.comboBoxPriority);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonRemoveSelectedFilter);
			this.Controls.Add(this.buttonAddFilter);
			this.Controls.Add(this.checkedListBoxFilterFilters);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postFilterGroupBindingSource, "Name", true));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "FormEditFilterGroup";
			this.Text = "Edit Filter Group";
			((System.ComponentModel.ISupportInitialize)(this.postFiltersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postFilterGroupBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRemoveSelectedFilter;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilterFilters;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.BindingSource postFilterGroupBindingSource;
        private System.Windows.Forms.TextBox textBoxAddFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource postFiltersBindingSource;
    }
}