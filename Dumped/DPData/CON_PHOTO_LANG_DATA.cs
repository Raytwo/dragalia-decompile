using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 24)]
public struct CON_PHOTO_LANG_DATA
{
	public byte styleMonsLangID;

	public byte beautifulMonsLangID;

	public byte cuteMonsLangID;

	public byte cleverMonsLangID;

	public byte strongMonsLangID;

	public long reserved_long01;

	public long reserved_long02;
}
