using System.Runtime.CompilerServices;

namespace Nintendo.MessageStudio.Lib;

public class SizeTagInfo : ITagInfo
{
	public ushort Tag => default(ushort);

	public ushort TagGroup => default(ushort);

	public ushort Size
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

	public SizeTagInfo(byte[] param)
	{
	}
}
