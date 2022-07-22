using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1604)]
public struct PoffinSaveData
{
	public PoffinData[] Poffins;

	public int CookingCount;

	public void Reset()
	{
	}

	public bool AddPoffin(PoffinData poffin)
	{
		return default(bool);
	}

	public void SortPoffin()
	{
	}

	public bool DelPoffin(PoffinData poffin)
	{
		return default(bool);
	}

	public void _DebugFull()
	{
	}

	public void SetNewFlag(PoffinData poffin, bool newFlag)
	{
	}

	public bool isHavePoffin()
	{
		return default(bool);
	}

	private int GetPoffinNum()
	{
		return default(int);
	}

	public PoffinData GetPoffin(int index)
	{
		return default(PoffinData);
	}

	public PoffinData[] GetHavePoffins()
	{
		return null;
	}

	public bool isCanMakePoffin()
	{
		return default(bool);
	}
}
