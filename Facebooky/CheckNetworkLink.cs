using System.Windows.Forms;
using System.Net.NetworkInformation;
using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	class CheckNetworkLink : IPostChainLink
	{
		public IPostChainLink NextLink { get; set; }
		public bool Enabled { get; set; }
		public User LoggedInUser { get; set; }
		public void HandlePost(PostInfo i_Post)
		{
			SendPostCommand postCommand = new SendPostCommand { Post = i_Post, LoggedInUser = this.LoggedInUser };
			bool networkAvalable = NetworkInterface.GetIsNetworkAvailable();
			if (Enabled && !networkAvalable)
			{
				MessageBox.Show(@"Network is unavailable. The post will be posted when network is returns.");
				NetworkChange.NetworkAvailabilityChanged +=
					postCommand.DoWhenNetworkChange;
			}
			else
			{
				postCommand.Execute();
			}
			if (NextLink != null)
			{
				NextLink.HandlePost(i_Post);
			}
		}
	}
}
