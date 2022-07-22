using System.Runtime.CompilerServices;

namespace Nintendo.MessageStudio.Lib;

public class FontTagInfo : ITagInfo
{
	public ushort Tag => default(ushort);

	public ushort TagGroup => default(ushort);

	public ushort Index
	{
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FontTagInfo(byte[] param)
	{
	}
}
