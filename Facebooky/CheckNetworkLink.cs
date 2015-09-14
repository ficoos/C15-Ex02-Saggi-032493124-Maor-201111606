using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

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
			SendPostCommand postCommand = new SendPostCommand();
			postCommand.Post = i_Post;
			postCommand.LoggedInUser = LoggedInUser;
			bool networkAvalable = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
			if (Enabled && !networkAvalable)
			{
				System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged += (i_Sender, i_Args) => { postCommand.Execute(); };
				MessageBox.Show(@"Network is unavailable. The post will be posted when network is returns.");
				System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged +=
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
