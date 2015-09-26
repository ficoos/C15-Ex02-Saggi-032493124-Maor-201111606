using System.Windows.Forms;
using System.Net.NetworkInformation;
using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	public class CheckNetworkPostHandler : IPostHandler
	{
		public string Name
		{
			get
			{
				return "Check Network Status";
			}
		}

		public bool Enabled { get; set; }

		public User LoggedInUser { get; set; }

		public void HandlePost(PostInfo i_Post)
		{
			SendPostCommand postCommand = new SendPostCommand { Post = i_Post, LoggedInUser = this.LoggedInUser };
			bool networkAvalable = NetworkInterface.GetIsNetworkAvailable();
			if (Enabled && !networkAvalable)
			{
				MessageBox.Show(@"Network is unavailable. The post will be posted when network is returns.");
				NetworkCommandScheduler.ScheduleOnNetworkAvailability(postCommand);
			}
			else
			{
				postCommand.Execute();
			}
		}
	}
}
