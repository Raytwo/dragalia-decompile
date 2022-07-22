using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Net.Data;

[StructLayout(0, Pack = 4, Size = 28)]
public struct ServerParam
{
	public ulong randomSeed;

	public uint debugFlagBit;

	public ushort LimitTimeGame;

	public ushort LimitTimeClient;

	public ushort LimitTimeCommand;

	public byte msgSpeed;

	public bool fWazaEffectEnable;

	public bool isNotifiedParam;
}
