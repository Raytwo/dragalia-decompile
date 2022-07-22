using System.Runtime.CompilerServices;

namespace Nintendo.MessageStudio.Lib;

public class CustomTagInfo : ITagInfo
{
	public ushort Tag
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

	public ushort TagGroup
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

	public byte[] Params
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CustomTagInfo(ushort group, ushort tag, byte[] param)
	{
	}
}
