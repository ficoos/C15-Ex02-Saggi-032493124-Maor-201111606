namespace Facebooky
{
	public interface IPostHandler
	{
		string Name { get; }

		bool Enabled { get; set; }

		void HandlePost(PostInfo i_Post);
	}
}
