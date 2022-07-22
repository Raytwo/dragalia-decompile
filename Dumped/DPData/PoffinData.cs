using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct PoffinData : IComparable<PoffinData>
{
	public byte MstID;

	public byte Level;

	public byte Taste;

	public bool IsNew;

	public byte[] Flavor;

	public bool IsNull => default(bool);

	public PoffinData(byte id, byte lv, byte taste, byte[] flavor)
	{
	}

	public void ToNull()
	{
	}

	public int GetMostFlavorIndex()
	{
		return default(int);
	}

	public float GetBONUS()
	{
		return default(float);
	}

	public InterviewWork.PoffineTaste GetPoffineType()
	{
		return default(InterviewWork.PoffineTaste);
	}

	public int CompareTo(PoffinData other)
	{
		return default(int);
	}
}
