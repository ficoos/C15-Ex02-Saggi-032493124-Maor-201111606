namespace Facebooky
{
	public interface IPostChainLink
	{
		IPostChainLink NextLink { get; set; }
		void HandlePost(PostInfo i_Post);

	}
}
