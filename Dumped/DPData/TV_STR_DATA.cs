using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 1, Size = 20)]
public struct TV_STR_DATA
{
	public string value;

	public byte language;

	public byte genderId;

	public byte reserved2;

	public byte reserved3;
}
