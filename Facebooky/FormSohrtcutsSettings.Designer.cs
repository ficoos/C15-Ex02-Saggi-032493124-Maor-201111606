namespace Facebooky
{
	partial class FormShortcutsSettings
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
			this.labelReplaceFrom = new System.Windows.Forms.Label();
			this.labelTo = new System.Windows.Forms.Label();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.textBoxTo = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRemoveSelected = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.listBoxShortcutsList = new Facebooky.KeyValueListBox();
			this.SuspendLayout();
			// 
			// labelReplaceFrom
			// 
			this.labelReplaceFrom.AutoSize = true;
			this.labelReplaceFrom.Location = new System.Drawing.Point(22, 24);
			this.labelReplaceFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelReplaceFrom.Name = "labelReplaceFrom";
			this.labelReplaceFrom.Size = new System.Drawing.Size(73, 13);
			this.labelReplaceFrom.TabIndex = 0;
			this.labelReplaceFrom.Text = "Replace from:";
			// 
			// labelTo
			// 
			this.labelTo.AutoSize = true;
			this.labelTo.Location = new System.Drawing.Point(237, 26);
			this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTo.Name = "labelTo";
			this.labelTo.Size = new System.Drawing.Size(23, 13);
			this.labelTo.TabIndex = 1;
			this.labelTo.Text = "To:";
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Location = new System.Drawing.Point(105, 24);
			this.textBoxFrom.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(115, 20);
			this.textBoxFrom.TabIndex = 2;
			// 
			// textBoxTo
			// 
			this.textBoxTo.Location = new System.Drawing.Point(275, 24);
			this.textBoxTo.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new System.Drawing.Size(115, 20);
			this.textBoxTo.TabIndex = 3;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(401, 17);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(69, 27);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonRemoveSelected
			// 
			this.buttonRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveSelected.Location = new System.Drawing.Point(25, 286);
			this.buttonRemoveSelected.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRemoveSelected.Name = "buttonRemoveSelected";
			this.buttonRemoveSelected.Size = new System.Drawing.Size(446, 27);
			this.buttonRemoveSelected.TabIndex = 8;
			this.buttonRemoveSelected.Text = "Remove Selected";
			this.buttonRemoveSelected.UseVisualStyleBackColor = true;
			this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 344);
			this.splitter1.TabIndex = 9;
			this.splitter1.TabStop = false;
			// 
			// listBoxShortcutsList
			// 
			this.listBoxShortcutsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxShortcutsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.listBoxShortcutsList.FormattingEnabled = true;
			this.listBoxShortcutsList.Location = new System.Drawing.Point(25, 49);
			this.listBoxShortcutsList.Name = "listBoxShortcutsList";
			this.listBoxShortcutsList.Size = new System.Drawing.Size(445, 238);
			this.listBoxShortcutsList.TabIndex = 10;
			// 
			// FormShortcutsSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 344);
			this.Controls.Add(this.listBoxShortcutsList);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.buttonRemoveSelected);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxTo);
			this.Controls.Add(this.textBoxFrom);
			this.Controls.Add(this.labelTo);
			this.Controls.Add(this.labelReplaceFrom);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormShortcutsSettings";
			this.Text = "Shortcuts Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelReplaceFrom;
		private System.Windows.Forms.Label labelTo;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.TextBox textBoxTo;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonRemoveSelected;
		private System.Windows.Forms.Splitter splitter1;
		private KeyValueListBox listBoxShortcutsList;
	}
}