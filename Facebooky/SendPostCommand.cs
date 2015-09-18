using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Net.NetworkInformation;

namespace Facebooky
{
	class SendPostCommand : ICommand
	{
		public User LoggedInUser { get; set; }

		public PostInfo Post { get; set; }

		public void Execute()
		{
			Status status = LoggedInUser.PostStatus(Post.StatusText);
			MessageBox.Show(@"Status Posted! ID: " + status.Id);
		}

		public void DoWhenNetworkChange(object i_Sender, EventArgs i_Args)
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				this.Execute();
				NetworkChange.NetworkAvailabilityChanged -= DoWhenNetworkChange;	
			}
		}
	}
}
