namespace NexPlugin;

public class Ranking2GetParam
{
	internal ulong nexUniqueId;

	internal uint category;

	internal uint offset;

	internal uint length;

	internal ulong principalId;

	internal Ranking2.Ranking2GetOptionFlags optionFlags;

	internal Ranking2.Ranking2SortFlags sortFlags;

	internal Ranking2.Ranking2Mode mode;

	internal byte numSeasonsToGoBack;

	public Ranking2.Ranking2Mode GetMode()
	{
		return default(Ranking2.Ranking2Mode);
	}

	public void SetMode(Ranking2.Ranking2Mode mode_)
	{
	}

	public uint GetCategory()
	{
		return default(uint);
	}

	public void SetCategory(uint category_)
	{
	}

	public byte GetNumSeasonsToGoBack()
	{
		return default(byte);
	}

	public void SetNumSeasonsToGoBack(byte numSeasonsToGoBack_)
	{
	}

	public uint GetOffset()
	{
		return default(uint);
	}

	public void SetOffset(uint offset_)
	{
	}

	public uint GetLength()
	{
		return default(uint);
	}

	public void SetLength(uint length_)
	{
	}

	public ulong GetPrincipalId()
	{
		return default(ulong);
	}

	public void SetPrincipalId(ulong principalId_)
	{
	}

	public ulong GetNexUniqueId()
	{
		return default(ulong);
	}

	public void SetNexUniqueId(ulong nexUniqueId_)
	{
	}

	public Ranking2.Ranking2SortFlags GetSortFlags()
	{
		return default(Ranking2.Ranking2SortFlags);
	}

	public void SetSortFlags(Ranking2.Ranking2SortFlags sortFlags_)
	{
	}

	public Ranking2.Ranking2GetOptionFlags GetOptionFlags()
	{
		return default(Ranking2.Ranking2GetOptionFlags);
	}

	public void SetOptionFlags(Ranking2.Ranking2GetOptionFlags optionFlags_)
	{
	}

	public void Reset()
	{
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
