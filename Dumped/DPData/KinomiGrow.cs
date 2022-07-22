using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct KinomiGrow
{
	public int tagNo;

	public int harvestCount;

	public int minutes;

	private byte _wet;

	private byte _selfPlant;

	private byte _padding0;

	private byte _padding1;

	public bool wet
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool selfPlant
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}
}
