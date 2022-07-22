using System.Runtime.CompilerServices;

namespace Nintendo.MessageStudio.Lib;

public class RubyTagInfo : ITagInfo
{
	public ushort Tag => default(ushort);

	public ushort TagGroup => default(ushort);

	public ushort ParentLength
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

	public string Ruby
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

	public RubyTagInfo(byte[] param)
	{
	}
}
