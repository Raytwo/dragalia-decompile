using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 40)]
public struct UgPlayerInfo
{
	public string name;

	public int id;

	public byte langID;

	public byte sex;

	public byte avatorID;

	public bool isPreset;
}
