using System.Collections.Specialized;

namespace Facebooky
{
	class ApplyShortcutsLink : IPostChainLink
	{
		public IPostChainLink NextLink { get; set; }
		public bool Enabled { get; set; }

		private readonly StringDictionary r_ShortcutsToReplace;

		public ApplyShortcutsLink(StringDictionary i_ShortcutsToReplace)
		{
			this.r_ShortcutsToReplace = i_ShortcutsToReplace;
		}

		public void HandlePost(PostInfo i_Post)
		{
			if (Enabled)
			{
				if (r_ShortcutsToReplace.Count > 0)
				{
					foreach (string key in r_ShortcutsToReplace.Keys)
					{

						i_Post.StatusText = i_Post.StatusText.Replace(key, r_ShortcutsToReplace[key]);
					}
				}
			}
			if (NextLink != null)
			{
				NextLink.HandlePost(i_Post);
			}

		}
	}
}
