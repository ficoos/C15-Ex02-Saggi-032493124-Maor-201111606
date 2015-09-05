namespace Facebooky
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
			this.components = new System.ComponentModel.Container();
			this.buttonLogIn = new System.Windows.Forms.Button();
			this.buttonSetStatus = new System.Windows.Forms.Button();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureSmallProfile = new System.Windows.Forms.PictureBox();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
			this.proxyDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.newsFeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonFetchNewsFeed = new System.Windows.Forms.Button();
			this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
			this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.buttonFetchEvents = new System.Windows.Forms.Button();
			this.buttonFilterSettings = new System.Windows.Forms.Button();
			this.checkBoxShowFiltered = new System.Windows.Forms.CheckBox();
			this.buttonCannedPost = new System.Windows.Forms.Button();
			this.checkinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureSmallProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proxyDataSourceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newsFeedBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonLogIn
			// 
			this.buttonLogIn.Location = new System.Drawing.Point(18, 18);
			this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLogIn.Name = "buttonLogIn";
			this.buttonLogIn.Size = new System.Drawing.Size(112, 35);
			this.buttonLogIn.TabIndex = 0;
			this.buttonLogIn.Text = "Log In...";
			this.buttonLogIn.UseVisualStyleBackColor = true;
			this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
			// 
			// buttonSetStatus
			// 
			this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSetStatus.Enabled = false;
			this.buttonSetStatus.Location = new System.Drawing.Point(770, 18);
			this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSetStatus.Name = "buttonSetStatus";
			this.buttonSetStatus.Size = new System.Drawing.Size(112, 35);
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
			this.textBoxStatus.Location = new System.Drawing.Point(244, 22);
			this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.Size = new System.Drawing.Size(514, 26);
			this.textBoxStatus.TabIndex = 48;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(140, 26);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 20);
			this.label3.TabIndex = 47;
			this.label3.Text = "Post Status:";
			// 
			// pictureSmallProfile
			// 
			this.pictureSmallProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
			this.pictureSmallProfile.Location = new System.Drawing.Point(18, 63);
			this.pictureSmallProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureSmallProfile.Name = "pictureSmallProfile";
			this.pictureSmallProfile.Size = new System.Drawing.Size(300, 255);
			this.pictureSmallProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureSmallProfile.TabIndex = 50;
			this.pictureSmallProfile.TabStop = false;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// listBoxNewsFeed
			// 
			this.listBoxNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxNewsFeed.DataSource = this.proxyDataSourceBindingSource;
			this.listBoxNewsFeed.Enabled = false;
			this.listBoxNewsFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxNewsFeed.FormattingEnabled = true;
			this.listBoxNewsFeed.ItemHeight = 29;
			this.listBoxNewsFeed.Location = new System.Drawing.Point(328, 108);
			this.listBoxNewsFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxNewsFeed.Name = "listBoxNewsFeed";
			this.listBoxNewsFeed.Size = new System.Drawing.Size(762, 178);
			this.listBoxNewsFeed.TabIndex = 51;
			// 
			// proxyDataSourceBindingSource
			// 
			this.proxyDataSourceBindingSource.DataSource = typeof(object);
			// 
			// newsFeedBindingSource
			// 
			this.newsFeedBindingSource.DataMember = "NewsFeed";
			this.newsFeedBindingSource.DataSource = this.userBindingSource;
			// 
			// buttonFetchNewsFeed
			// 
			this.buttonFetchNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFetchNewsFeed.Enabled = false;
			this.buttonFetchNewsFeed.Location = new System.Drawing.Point(328, 63);
			this.buttonFetchNewsFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonFetchNewsFeed.Name = "buttonFetchNewsFeed";
			this.buttonFetchNewsFeed.Size = new System.Drawing.Size(483, 35);
			this.buttonFetchNewsFeed.TabIndex = 52;
			this.buttonFetchNewsFeed.Text = "Fetch News Feed";
			this.buttonFetchNewsFeed.UseVisualStyleBackColor = true;
			this.buttonFetchNewsFeed.Click += new System.EventHandler(this.buttonFetchNewsFeed_Click);
			// 
			// pictureBoxEvent
			// 
			this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventsBindingSource, "ImageNormal", true));
			this.pictureBoxEvent.Location = new System.Drawing.Point(855, 372);
			this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBoxEvent.Name = "pictureBoxEvent";
			this.pictureBoxEvent.Size = new System.Drawing.Size(240, 322);
			this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxEvent.TabIndex = 55;
			this.pictureBoxEvent.TabStop = false;
			// 
			// eventsBindingSource
			// 
			this.eventsBindingSource.DataMember = "Events";
			this.eventsBindingSource.DataSource = this.userBindingSource;
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxEvents.DataSource = this.eventsBindingSource;
			this.listBoxEvents.DisplayMember = "Name";
			this.listBoxEvents.Enabled = false;
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 20;
			this.listBoxEvents.Location = new System.Drawing.Point(18, 372);
			this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(826, 304);
			this.listBoxEvents.TabIndex = 54;
			this.listBoxEvents.ValueMember = "AttendingUsers";
			// 
			// buttonFetchEvents
			// 
			this.buttonFetchEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFetchEvents.Enabled = false;
			this.buttonFetchEvents.Location = new System.Drawing.Point(18, 328);
			this.buttonFetchEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonFetchEvents.Name = "buttonFetchEvents";
			this.buttonFetchEvents.Size = new System.Drawing.Size(1074, 35);
			this.buttonFetchEvents.TabIndex = 56;
			this.buttonFetchEvents.Text = "Fetch Events";
			this.buttonFetchEvents.UseVisualStyleBackColor = true;
			this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
			// 
			// buttonFilterSettings
			// 
			this.buttonFilterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFilterSettings.Enabled = false;
			this.buttonFilterSettings.Location = new System.Drawing.Point(957, 63);
			this.buttonFilterSettings.Name = "buttonFilterSettings";
			this.buttonFilterSettings.Size = new System.Drawing.Size(132, 37);
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
			this.checkBoxShowFiltered.Location = new System.Drawing.Point(822, 69);
			this.checkBoxShowFiltered.Name = "checkBoxShowFiltered";
			this.checkBoxShowFiltered.Size = new System.Drawing.Size(132, 24);
			this.checkBoxShowFiltered.TabIndex = 59;
			this.checkBoxShowFiltered.Text = "Show Filtered";
			this.checkBoxShowFiltered.UseVisualStyleBackColor = true;
			this.checkBoxShowFiltered.CheckedChanged += new System.EventHandler(this.checkBoxShowFiltered_CheckedChanged);
			// 
			// buttonCannedPost
			// 
			this.buttonCannedPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCannedPost.Enabled = false;
			this.buttonCannedPost.Location = new System.Drawing.Point(891, 18);
			this.buttonCannedPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCannedPost.Name = "buttonCannedPost";
			this.buttonCannedPost.Size = new System.Drawing.Size(198, 35);
			this.buttonCannedPost.TabIndex = 60;
			this.buttonCannedPost.Text = "Canned Post...";
			this.buttonCannedPost.UseVisualStyleBackColor = true;
			this.buttonCannedPost.Click += new System.EventHandler(this.buttonCannedPost_Click);
			// 
			// checkinsBindingSource
			// 
			this.checkinsBindingSource.DataMember = "Checkins";
			this.checkinsBindingSource.DataSource = this.userBindingSource;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1108, 702);
			this.Controls.Add(this.buttonCannedPost);
			this.Controls.Add(this.checkBoxShowFiltered);
			this.Controls.Add(this.buttonFilterSettings);
			this.Controls.Add(this.buttonFetchEvents);
			this.Controls.Add(this.pictureBoxEvent);
			this.Controls.Add(this.listBoxEvents);
			this.Controls.Add(this.buttonFetchNewsFeed);
			this.Controls.Add(this.listBoxNewsFeed);
			this.Controls.Add(this.pictureSmallProfile);
			this.Controls.Add(this.buttonSetStatus);
			this.Controls.Add(this.textBoxStatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonLogIn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(829, 601);
			this.Name = "FormMain";
			this.Text = "FaceBook App";
			((System.ComponentModel.ISupportInitialize)(this.pictureSmallProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proxyDataSourceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newsFeedBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).EndInit();
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
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Button buttonFilterSettings;
        private System.Windows.Forms.CheckBox checkBoxShowFiltered;
		private System.Windows.Forms.Button buttonCannedPost;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.BindingSource newsFeedBindingSource;
		private System.Windows.Forms.BindingSource eventsBindingSource;
		private System.Windows.Forms.BindingSource checkinsBindingSource;
		private System.Windows.Forms.BindingSource proxyDataSourceBindingSource;
	}
}

