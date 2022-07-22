using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Net.Data;

[StructLayout(0, Pack = 4, Size = 4)]
public struct ServerVersion
{
	public byte commPos;

	public byte serverVersion;

	public ushort recivedFlag;
}
