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
			this.listBoxShortcutsList = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRemoveSelected = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelReplaceFrom
			// 
			this.labelReplaceFrom.AutoSize = true;
			this.labelReplaceFrom.Location = new System.Drawing.Point(33, 37);
			this.labelReplaceFrom.Name = "labelReplaceFrom";
			this.labelReplaceFrom.Size = new System.Drawing.Size(108, 20);
			this.labelReplaceFrom.TabIndex = 0;
			this.labelReplaceFrom.Text = "Replace from:";
			// 
			// labelTo
			// 
			this.labelTo.AutoSize = true;
			this.labelTo.Location = new System.Drawing.Point(355, 40);
			this.labelTo.Name = "labelTo";
			this.labelTo.Size = new System.Drawing.Size(31, 20);
			this.labelTo.TabIndex = 1;
			this.labelTo.Text = "To:";
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Location = new System.Drawing.Point(158, 37);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(171, 26);
			this.textBoxFrom.TabIndex = 2;
			// 
			// textBoxTo
			// 
			this.textBoxTo.Location = new System.Drawing.Point(412, 37);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new System.Drawing.Size(171, 26);
			this.textBoxTo.TabIndex = 3;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(601, 26);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(104, 42);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// listBoxShortcutsList
			// 
			this.listBoxShortcutsList.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.listBoxShortcutsList.DisplayMember = "Count";
			this.listBoxShortcutsList.FormattingEnabled = true;
			this.listBoxShortcutsList.ItemHeight = 20;
			this.listBoxShortcutsList.Location = new System.Drawing.Point(37, 154);
			this.listBoxShortcutsList.Name = "listBoxShortcutsList";
			this.listBoxShortcutsList.Size = new System.Drawing.Size(320, 264);
			this.listBoxShortcutsList.TabIndex = 5;
			this.listBoxShortcutsList.ValueMember = "Count";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBox1.Location = new System.Drawing.Point(377, 154);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(328, 264);
			this.textBox1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(257, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Left: original input, Right: output";
			// 
			// btnRemoveSelected
			// 
			this.btnRemoveSelected.Location = new System.Drawing.Point(37, 440);
			this.btnRemoveSelected.Name = "btnRemoveSelected";
			this.btnRemoveSelected.Size = new System.Drawing.Size(292, 42);
			this.btnRemoveSelected.TabIndex = 8;
			this.btnRemoveSelected.Text = "Remove Selected";
			this.btnRemoveSelected.UseVisualStyleBackColor = true;
			this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
			// 
			// FormShortcutsSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 529);
			this.Controls.Add(this.btnRemoveSelected);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBoxShortcutsList);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxTo);
			this.Controls.Add(this.textBoxFrom);
			this.Controls.Add(this.labelTo);
			this.Controls.Add(this.labelReplaceFrom);
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
		private System.Windows.Forms.ListBox listBoxShortcutsList;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRemoveSelected;
	}
}