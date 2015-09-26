using System.Collections.Generic;

namespace Facebooky
{
	public class ApplyShortcutsPostHandler : IPostHandler
	{
		public string Name
		{
			get
			{
				return "Apply Shortcuts";
			}
		}

		public bool Enabled { get; set; }

		private readonly IEnumerable<KeyValuePair<string, string>> r_ShortcutsToReplace;

		public ApplyShortcutsPostHandler(IEnumerable<KeyValuePair<string, string>> i_ShortcutsToReplace)
		{
			this.r_ShortcutsToReplace = i_ShortcutsToReplace;
		}

		public void HandlePost(PostInfo i_Post)
		{
			if (Enabled)
			{
				foreach (KeyValuePair<string, string> pair in r_ShortcutsToReplace)
				{
					i_Post.StatusText = i_Post.StatusText.Replace(pair.Key, pair.Value);
				}
			}
		}
	}
}
