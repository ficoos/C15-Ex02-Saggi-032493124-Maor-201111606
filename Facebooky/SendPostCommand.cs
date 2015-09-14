using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

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
	}
}
