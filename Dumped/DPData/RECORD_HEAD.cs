using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 48)]
public struct RECORD_HEAD
{
	public string username;

	public byte reserved_byte1;

	public byte reserved_byte2;

	public int language;

	public byte sex;

	public byte reserved_byte4;

	public byte reserved_byte5;

	public byte reserved_byte6;

	public int body_type;

	public uint uniqueID;

	public int reserved_int2;
}
