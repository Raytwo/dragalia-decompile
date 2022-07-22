using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1712)]
public struct PLAYER_NETWORK_DATA
{
	public byte[] publicKeyBASE64;

	public byte[] bcatFlagArray;

	public ulong nexUniqueId;

	public ulong nexUniqueIdPassword;

	public ushort publicKeyversion;
}
