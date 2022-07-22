using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Net.Data;

[StructLayout(0, Pack = 4, Size = 1)]
public struct Signal
{
	public byte param;
}
