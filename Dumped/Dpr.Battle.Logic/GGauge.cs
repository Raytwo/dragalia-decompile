using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class GGauge
{
	public const byte MAX_VALUE = 7;

	private byte m_value;

	public void Initialize()
	{
	}

	public void CopyFrom([In] ref GGauge src)
	{
	}

	public byte GetValue()
	{
		return default(byte);
	}

	public bool IsFull()
	{
		return default(bool);
	}

	public void IncValue()
	{
	}

	public void SetEmpty()
	{
	}
}
