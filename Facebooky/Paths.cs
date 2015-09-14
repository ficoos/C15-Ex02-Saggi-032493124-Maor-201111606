using System;
using System.IO;

using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	public class UserPaths
	{
		public User User { get; private set; }

		public UserPaths(User i_User)
		{
			User = i_User;
		}
		
		public string UserSettingsPath
		{
			get
			{
				string configFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string finalPath = Path.Combine(configFolderPath, "Facebooky", User.Id);
				Directory.CreateDirectory(finalPath);
				return finalPath;
			}
		}

		public string PostFiltersPath
		{
			get
			{
				return Path.Combine(UserSettingsPath, "filters.xml");
			}
		}
		public string ShortcutsPath
		{
			get
			{
				return Path.Combine(UserSettingsPath, "Shortcuts.xml");
			}
		}
		public string CannedPostsDirectory
		{
			get
			{
				string result = Path.Combine(UserSettingsPath, "CannedPosts");
				Directory.CreateDirectory(result);
				return result;
			}
		}
	}
}