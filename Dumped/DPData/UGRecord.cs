using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 624)]
public struct UGRecord
{
	public uint talkPlayerDataID;

	public uint talkPlayerCount;

	public UgSecretBase myBase;
}
