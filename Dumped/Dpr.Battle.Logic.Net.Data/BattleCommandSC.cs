using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Net.Data;

[StructLayout(0, Pack = 4, Size = 12)]
public struct BattleCommandSC
{
	public ulong cmdseqno;

	public byte clientId;

	public byte divmax;

	public byte divcur;

	public byte _padding;
}
