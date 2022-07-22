using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 308)]
public struct SYSTEMDATA
{
	public GMTIME StartTime;

	public GMTIME SaveTime;

	public GMTIME PenaltyTime;

	public GMTIME DailyEventLastTime;

	public byte[] nxSnapshot;

	public uint fd_bgmEvnet;

	public long reserved_long0;

	public long reserved_long1;

	public long reserved_long2;

	public long reserved_long3;

	public long reserved_long4;

	public long reserved_long5;
}
