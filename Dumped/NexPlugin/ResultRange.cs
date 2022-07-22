namespace NexPlugin;

public class ResultRange
{
	internal uint offset;

	internal uint size;

	public ResultRange(uint uiOffset = 0u, uint uiSize = 20u)
	{
	}

	public void SetOffset(uint uiOffset = 0u)
	{
	}

	public uint GetOffset()
	{
		return default(uint);
	}

	public void SetSize(uint uiSize = 20u)
	{
	}

	public uint GetSize()
	{
		return default(uint);
	}

	public static ResultRange operator ++(ResultRange r)
	{
		return null;
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
