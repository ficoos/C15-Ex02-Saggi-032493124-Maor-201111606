﻿namespace Facebooky
{
	partial class FormMain
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
            
			if (disposing && (this.components != null))
			{
				this.components.Dispose();
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
			this.buttonLogIn = new System.Windows.Forms.Button();
			this.buttonSetStatus = new System.Windows.Forms.Button();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureSmallProfile = new System.Windows.Forms.PictureBox();
			this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
			this.buttonFetchNewsFeed = new System.Windows.Forms.Button();
			this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
			this.listBoxCheckins = new System.Windows.Forms.ListBox();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.buttonFetchEvents = new System.Windows.Forms.Button();
			this.buttonFetchCheckIns = new System.Windows.Forms.Button();
			this.buttonFilterSettings = new System.Windows.Forms.Button();
			this.checkBoxShowFiltered = new System.Windows.Forms.CheckBox();
			this.buttonCannedPost = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureSmallProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonLogIn
			// 
			this.buttonLogIn.Location = new System.Drawing.Point(12, 12);
			this.buttonLogIn.Name = "buttonLogIn";
			this.buttonLogIn.Size = new System.Drawing.Size(75, 23);
			this.buttonLogIn.TabIndex = 0;
			this.buttonLogIn.Text = "Log In...";
			this.buttonLogIn.UseVisualStyleBackColor = true;
			this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
			// 
			// buttonSetStatus
			// 
			this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSetStatus.Enabled = false;
			this.buttonSetStatus.Location = new System.Drawing.Point(737, 12);
			this.buttonSetStatus.Name = "buttonSetStatus";
			this.buttonSetStatus.Size = new System.Drawing.Size(75, 23);
			this.buttonSetStatus.TabIndex = 49;
			this.buttonSetStatus.Text = "Post";
			this.buttonSetStatus.UseVisualStyleBackColor = true;
			this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxStatus.Enabled = false;
			this.textBoxStatus.Location = new System.Drawing.Point(163, 14);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.Size = new System.Drawing.Size(568, 20);
			this.textBoxStatus.TabIndex = 48;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = "Post Status:";
			// 
			// pictureSmallProfile
			// 
			this.pictureSmallProfile.Location = new System.Drawing.Point(12, 41);
			this.pictureSmallProfile.Name = "pictureSmallProfile";
			this.pictureSmallProfile.Size = new System.Drawing.Size(200, 166);
			this.pictureSmallProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureSmallProfile.TabIndex = 50;
			this.pictureSmallProfile.TabStop = false;
			// 
			// listBoxNewsFeed
			// 
			this.listBoxNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxNewsFeed.DisplayMember = "name";
			this.listBoxNewsFeed.Enabled = false;
			this.listBoxNewsFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxNewsFeed.FormattingEnabled = true;
			this.listBoxNewsFeed.ItemHeight = 19;
			this.listBoxNewsFeed.Location = new System.Drawing.Point(219, 70);
			this.listBoxNewsFeed.Name = "listBoxNewsFeed";
			this.listBoxNewsFeed.Size = new System.Drawing.Size(733, 118);
			this.listBoxNewsFeed.TabIndex = 51;
			// 
			// buttonFetchNewsFeed
			// 
			this.buttonFetchNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFetchNewsFeed.Enabled = false;
			this.buttonFetchNewsFeed.Location = new System.Drawing.Point(219, 41);
			this.buttonFetchNewsFeed.Name = "buttonFetchNewsFeed";
			this.buttonFetchNewsFeed.Size = new System.Drawing.Size(546, 23);
			this.buttonFetchNewsFeed.TabIndex = 52;
			this.buttonFetchNewsFeed.Text = "Fetch News Feed";
			this.buttonFetchNewsFeed.UseVisualStyleBackColor = true;
			this.buttonFetchNewsFeed.Click += new System.EventHandler(this.buttonFetchNewsFeed_Click);
			// 
			// pictureBoxEvent
			// 
			this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxEvent.Location = new System.Drawing.Point(794, 242);
			this.pictureBoxEvent.Name = "pictureBoxEvent";
			this.pictureBoxEvent.Size = new System.Drawing.Size(160, 209);
			this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxEvent.TabIndex = 55;
			this.pictureBoxEvent.TabStop = false;
			// 
			// listBoxCheckins
			// 
			this.listBoxCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBoxCheckins.DisplayMember = "name";
			this.listBoxCheckins.Enabled = false;
			this.listBoxCheckins.FormattingEnabled = true;
			this.listBoxCheckins.Location = new System.Drawing.Point(12, 242);
			this.listBoxCheckins.Name = "listBoxCheckins";
			this.listBoxCheckins.Size = new System.Drawing.Size(200, 199);
			this.listBoxCheckins.TabIndex = 53;
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxEvents.DisplayMember = "name";
			this.listBoxEvents.Enabled = false;
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.Location = new System.Drawing.Point(220, 242);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(568, 199);
			this.listBoxEvents.TabIndex = 54;
			this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
			// 
			// buttonFetchEvents
			// 
			this.buttonFetchEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFetchEvents.Enabled = false;
			this.buttonFetchEvents.Location = new System.Drawing.Point(220, 213);
			this.buttonFetchEvents.Name = "buttonFetchEvents";
			this.buttonFetchEvents.Size = new System.Drawing.Size(732, 23);
			this.buttonFetchEvents.TabIndex = 56;
			this.buttonFetchEvents.Text = "Fetch News Events";
			this.buttonFetchEvents.UseVisualStyleBackColor = true;
			this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
			// 
			// buttonFetchCheckIns
			// 
			this.buttonFetchCheckIns.Enabled = false;
			this.buttonFetchCheckIns.Location = new System.Drawing.Point(12, 213);
			this.buttonFetchCheckIns.Name = "buttonFetchCheckIns";
			this.buttonFetchCheckIns.Size = new System.Drawing.Size(200, 23);
			this.buttonFetchCheckIns.TabIndex = 57;
			this.buttonFetchCheckIns.Text = "Fetch Check Ins";
			this.buttonFetchCheckIns.UseVisualStyleBackColor = true;
			this.buttonFetchCheckIns.Click += new System.EventHandler(this.buttonFetchCheckIns_Click);
			// 
			// buttonFilterSettings
			// 
			this.buttonFilterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFilterSettings.Enabled = false;
			this.buttonFilterSettings.Location = new System.Drawing.Point(862, 41);
			this.buttonFilterSettings.Margin = new System.Windows.Forms.Padding(2);
			this.buttonFilterSettings.Name = "buttonFilterSettings";
			this.buttonFilterSettings.Size = new System.Drawing.Size(88, 24);
			this.buttonFilterSettings.TabIndex = 58;
			this.buttonFilterSettings.Text = "Filter Settings...";
			this.buttonFilterSettings.UseVisualStyleBackColor = true;
			this.buttonFilterSettings.Click += new System.EventHandler(this.buttonFilterSettings_Click);
			// 
			// checkBoxShowFiltered
			// 
			this.checkBoxShowFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxShowFiltered.AutoSize = true;
			this.checkBoxShowFiltered.Checked = true;
			this.checkBoxShowFiltered.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowFiltered.Enabled = false;
			this.checkBoxShowFiltered.Location = new System.Drawing.Point(770, 45);
			this.checkBoxShowFiltered.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxShowFiltered.Name = "checkBoxShowFiltered";
			this.checkBoxShowFiltered.Size = new System.Drawing.Size(90, 17);
			this.checkBoxShowFiltered.TabIndex = 59;
			this.checkBoxShowFiltered.Text = "Show Filtered";
			this.checkBoxShowFiltered.UseVisualStyleBackColor = true;
			this.checkBoxShowFiltered.CheckedChanged += new System.EventHandler(this.checkBoxShowFiltered_CheckedChanged);
			// 
			// buttonCannedPost
			// 
			this.buttonCannedPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCannedPost.Enabled = false;
			this.buttonCannedPost.Location = new System.Drawing.Point(818, 12);
			this.buttonCannedPost.Name = "buttonCannedPost";
			this.buttonCannedPost.Size = new System.Drawing.Size(132, 23);
			this.buttonCannedPost.TabIndex = 60;
			this.buttonCannedPost.Text = "Canned Post...";
			this.buttonCannedPost.UseVisualStyleBackColor = true;
			this.buttonCannedPost.Click += new System.EventHandler(this.buttonCannedPost_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 456);
			this.Controls.Add(this.buttonCannedPost);
			this.Controls.Add(this.checkBoxShowFiltered);
			this.Controls.Add(this.buttonFilterSettings);
			this.Controls.Add(this.buttonFetchCheckIns);
			this.Controls.Add(this.buttonFetchEvents);
			this.Controls.Add(this.pictureBoxEvent);
			this.Controls.Add(this.listBoxCheckins);
			this.Controls.Add(this.listBoxEvents);
			this.Controls.Add(this.buttonFetchNewsFeed);
			this.Controls.Add(this.listBoxNewsFeed);
			this.Controls.Add(this.pictureSmallProfile);
			this.Controls.Add(this.buttonSetStatus);
			this.Controls.Add(this.textBoxStatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonLogIn);
			this.MinimumSize = new System.Drawing.Size(560, 410);
			this.Name = "FormMain";
			this.Text = "FaceBook App";
			((System.ComponentModel.ISupportInitialize)(this.pictureSmallProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogIn;
		private System.Windows.Forms.Button buttonSetStatus;
		private System.Windows.Forms.TextBox textBoxStatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureSmallProfile;
		private System.Windows.Forms.ListBox listBoxNewsFeed;
		private System.Windows.Forms.Button buttonFetchNewsFeed;
		private System.Windows.Forms.PictureBox pictureBoxEvent;
		private System.Windows.Forms.ListBox listBoxCheckins;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Button buttonFetchEvents;
		private System.Windows.Forms.Button buttonFetchCheckIns;
        private System.Windows.Forms.Button buttonFilterSettings;
        private System.Windows.Forms.CheckBox checkBoxShowFiltered;
		private System.Windows.Forms.Button buttonCannedPost;
	}
}

