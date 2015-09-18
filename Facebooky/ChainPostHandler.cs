using System.Collections;
using System.Collections.Generic;

namespace Facebooky
{
	public class ChainPostHandler : IPostHandler, IEnumerable<IPostHandler>
	{
		public string Name
		{
			get
			{
				return PostHandler != null ? PostHandler.Name : string.Empty;
			}
		}

		public bool Enabled
		{
			get
			{
				return PostHandler.Enabled;
			}

			set
			{
				PostHandler.Enabled = value;
			}
		}

		public IPostHandler PostHandler { get; set; }

		public ChainPostHandler NextPostHandler { get; set; }

		public ChainPostHandler(IPostHandler i_PostHandler, ChainPostHandler i_NextPostHandler = null)
		{
			PostHandler = i_PostHandler;
			NextPostHandler = i_NextPostHandler;
		}

		public ChainPostHandler()
		{
		}

		public void HandlePost(PostInfo i_Post)
		{
			if (PostHandler != null)
			{
				PostHandler.HandlePost(i_Post);
			}

			if (NextPostHandler != null)
			{
				NextPostHandler.HandlePost(i_Post);
			}
		}

		public IEnumerator<IPostHandler> GetEnumerator()
		{
			ChainPostHandler currentChainPostHandler = this;
			do
			{
				yield return currentChainPostHandler.PostHandler;
				currentChainPostHandler = currentChainPostHandler.NextPostHandler;
			}
			while (currentChainPostHandler != null);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
