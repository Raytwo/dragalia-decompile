using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class StrParam
{
	private class Param
	{
		public ushort ID;

		public ushort type;

		public ushort argCnt;

		public bool fSEAdd;

		public bool fFailMsg;

		public int[] args;

		public void CopyFrom(Param src)
		{
		}

		public void Clear()
		{
		}
	}

	private Param m_param;

	public StrParam()
	{
	}

	public StrParam([In] ref StrParam src)
	{
	}

	public void CopyFrom([In] ref StrParam src)
	{
	}

	public void Clear()
	{
	}

	public bool IsEnable()
	{
		return default(bool);
	}

	public void Setup(BtlStrType type, ushort strID)
	{
	}

	public ushort GetStrID()
	{
		return default(ushort);
	}

	public BtlStrType GetStrType()
	{
		return default(BtlStrType);
	}

	public void AddArg(int arg)
	{
	}

	public void ChangeArg(byte index, int value)
	{
	}

	public ushort GetArgsCount()
	{
		return default(ushort);
	}

	public int[] GetArgs()
	{
		return null;
	}

	public void AddSE(uint SENo)
	{
	}

	public bool IsSEAdded()
	{
		return default(bool);
	}

	public int GetSE()
	{
		return default(int);
	}

	public void SetFailMsgFlag()
	{
	}

	public bool IsFailMsg()
	{
		return default(bool);
	}
}
