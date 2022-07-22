using System.Runtime.CompilerServices;

namespace Nintendo.MessageStudio.Lib;

public class ColorTagInfo : ITagInfo
{
	public ushort Tag => default(ushort);

	public ushort TagGroup => default(ushort);

	public LMSColor Color
	{
		[CompilerGenerated]
		get
		{
			return default(LMSColor);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

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

	public ColorTagInfo(byte[] param)
	{
	}
}
