using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	class CheckNetworkLink: IPostChainLink
	{
		public IPostChainLink NextLink { get; set; }
		public bool Enabled { get; set; }
		public User LoggedInUser { get; set; }
		public void HandlePost(PostInfo i_Post)
		{
			if (Enabled)
			{
				bool isNetworkAvalable = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
				if (isNetworkAvalable)
				{
					Status status = LoggedInUser.PostStatus(i_Post.StatusText);
					MessageBox.Show(@"Status Posted! ID: " + status.Id);
				}
				else
				{
					//command!
				}
			}
			else
			{
				//post! without checkingg
			}
			if (NextLink != null)
			{
				NextLink.HandlePost(i_Post);
			}
		}
	}
}
