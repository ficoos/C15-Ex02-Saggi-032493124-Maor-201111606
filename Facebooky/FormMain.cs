namespace Facebooky
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Windows.Forms;
	using System.Xml.Serialization;

	using Facebooky;

	using FacebookWrapper;
	using FacebookWrapper.ObjectModel;

	public partial class FormMain : Form
	{
		private const string k_ApplicationId = "1444340485893858";

		private static readonly string[] sr_RequiredPermissions = 
		{
			"user_about_me",
			"user_friends",
			"publish_actions",
			"user_events",
			"user_posts",
			"user_photos",
			"user_status"
		};

		private static void saveAccessToken(string i_AccessToken)
		{
			Properties.Settings.Default.LastKnownAccessToken = i_AccessToken;
			Properties.Settings.Default.Save();
		}

		private static string loadLastKnownAccessToken()
		{
			return Properties.Settings.Default.LastKnownAccessToken;
		}

		private static void copyFileTree(string i_SourceDirectory, string i_TargetDirectory)
		{
			foreach (string dirPath in Directory.GetDirectories(i_SourceDirectory, "*", SearchOption.AllDirectories))
			{
				Directory.CreateDirectory(dirPath.Replace(i_SourceDirectory, i_TargetDirectory));
			}

			foreach (string newPath in Directory.GetFiles(i_SourceDirectory, "*.*", SearchOption.AllDirectories))
			{
				File.Copy(newPath, newPath.Replace(i_SourceDirectory, i_TargetDirectory), overwrite: true);
			}
		}

		private List<PostFilterGroup> m_PostFilterGroups;

		private User m_LoggedInUser;

		private UserPaths m_UserPaths;

		public FormMain()
		{
            this.m_PostFilterGroups = new List<PostFilterGroup>();
			this.InitializeComponent();
		}

		private void logIn()
		{
			LoginResult result = null;
			string lastKnownAccessToken = loadLastKnownAccessToken();

			if (!string.IsNullOrEmpty(lastKnownAccessToken))
			{
				DialogResult quickLogInResult = MessageBox.Show(
					@"Would you like to quick log in using the same user?",
					@"Would you like to quick log in?",
					MessageBoxButtons.YesNo);
				if (quickLogInResult == DialogResult.Yes)
				{
					result = FacebookService.Connect(lastKnownAccessToken);
				}
			}

			if (result == null || string.IsNullOrEmpty(result.AccessToken))
			{
				result = FacebookService.Login(k_ApplicationId, sr_RequiredPermissions);
			}

			if (string.IsNullOrEmpty(result.AccessToken))
			{
				MessageBox.Show(result.ErrorMessage);
			}
			else
			{
				this.m_LoggedInUser = result.LoggedInUser;
				this.m_UserPaths = new UserPaths(this.m_LoggedInUser);
				saveAccessToken(result.AccessToken);
			}

			this.initializeUserDirectory();
		}

		private void initializeUserDirectory()
		{
			if (!File.Exists(this.m_UserPaths.PostFiltersPath))
			{
				copyFileTree(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DefaultContent"), this.m_UserPaths.UserSettingsPath);
			}
		}

		private void buttonLogIn_Click(object i_Sender, EventArgs i_Args)
		{
			this.logIn();
			if (this.m_LoggedInUser != null)
			{
				userBindingSource.DataSource = m_LoggedInUser;
				this.enableControls();
				this.loadPostFilters();
			}
		}

		private void enableControls()
		{
			this.textBoxStatus.Enabled = true;
			this.buttonFetchNewsFeed.Enabled = true;
			this.buttonFetchEvents.Enabled = true;
			this.buttonSetStatus.Enabled = true;
			this.buttonFilterSettings.Enabled = true;
			this.buttonCannedPost.Enabled = true;
			this.checkBoxShowFiltered.Enabled = true;
			this.listBoxEvents.Enabled = true;
			this.listBoxNewsFeed.Enabled = true;
		}

		private void fetchEvents()
		{
			m_LoggedInUser.ReFetch("events");
			resetBinding();
		}

		private void resetBinding()
		{
			const bool v_MetadataChanged = true;
			userBindingSource.ResetBindings(!v_MetadataChanged);
		}

        private void fetchNewsFeed()
        {
			m_LoggedInUser.ReFetch("feed");
			resetBinding();
			return;

            if (this.m_LoggedInUser != null)
            {
                if (!this.checkBoxShowFiltered.Checked)
                {
                    this.listBoxNewsFeed.DataSource = this.m_LoggedInUser.NewsFeed;
                }
                else
                {
					List<Post> posts = this.m_LoggedInUser.NewsFeed.Where(i_Post => this.getPostPriority(i_Post) != ePostPriority.Hidden).ToList();
					posts.Sort((i_Post, i_OtherPost) => this.getPostPriority(i_OtherPost).CompareTo(this.getPostPriority(i_Post)));                  
	                this.listBoxNewsFeed.DataSource = posts;
                }
            }
        }

		private ePostPriority getPostPriority(Post i_Post)
		{
			ePostPriority postPriority = ePostPriority.None;
			foreach (PostFilterGroup filterGroup in this.m_PostFilterGroups)
			{
				if (filterGroup.IsMatch(i_Post))
				{
					postPriority = (ePostPriority)Math.Min((int)filterGroup.PostPriority, (int)postPriority);
				}

				if (postPriority == ePostPriority.Hidden)
				{
					break;
				}
			}

			return postPriority;
		}
		
		private void buttonFetchEvents_Click(object i_Sender, EventArgs i_Args)
		{
			this.fetchEvents();
		}

		private void buttonFetchNewsFeed_Click(object i_Sender, EventArgs i_Args)
		{
			this.fetchNewsFeed();
		}

		private void buttonSetStatus_Click(object i_Sender, EventArgs i_Args)
		{
			string statusText = this.textBoxStatus.Text.Trim();
			if (!string.IsNullOrEmpty(statusText))
			{
				Status status = this.m_LoggedInUser.PostStatus(this.textBoxStatus.Text);
				MessageBox.Show(@"Status Posted! ID: " + status.Id);
			}
		}

        private void buttonFilterSettings_Click(object i_Sender, EventArgs i_Args)
        {
            FormFilterSettings filterSettingsDialog = new FormFilterSettings();
            filterSettingsDialog.PostFilterGroup = this.m_PostFilterGroups;
            filterSettingsDialog.ShowDialog();
	        this.savePostFilters();
        }
		
		private void savePostFilters()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<PostFilterGroup>));
			using (TextWriter writer = new StreamWriter(this.m_UserPaths.PostFiltersPath))
			{
				serializer.Serialize(writer, this.m_PostFilterGroups);
			}
		}

        private void loadPostFilters()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PostFilterGroup>));
			if (File.Exists(this.m_UserPaths.PostFiltersPath))
	        {
				using (TextReader reader = new StreamReader(this.m_UserPaths.PostFiltersPath))
		        {
			        this.m_PostFilterGroups = (List<PostFilterGroup>)serializer.Deserialize(reader);
		        }
	        }
	        else
	        {
		        this.m_PostFilterGroups = new List<PostFilterGroup>();
	        }
        }

        private void checkBoxShowFiltered_CheckedChanged(object i_Sender, EventArgs i_Args)
        {
            this.fetchNewsFeed();
        }

		private void buttonCannedPost_Click(object i_Sender, EventArgs i_Args)
		{
			FormSelectCannedPost form = new FormSelectCannedPost
			{
				CannedPostsDirectoryPath = this.m_UserPaths.CannedPostsDirectory
			};

			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				FormPostCannedPost cannedPost = new FormPostCannedPost
				{
					CannedPost = form.SelectedPost
				};

				cannedPost.ShowDialog();
				if (cannedPost.DialogResult == DialogResult.OK)
				{
					this.m_LoggedInUser.PostStatus(cannedPost.CompiledPost.StatusText);
				}
			}
		}
	}
}
