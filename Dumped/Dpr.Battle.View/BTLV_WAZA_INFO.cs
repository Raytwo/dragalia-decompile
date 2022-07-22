using Pml;
using Pml.WazaData;

namespace Dpr.Battle.View;

public struct BTLV_WAZA_INFO
{
	public PokeType PokeType;

	public WazaNo WazaNo;

	public string WazaName;

	public ushort PP;

	public ushort MaxPP;

	public WazaDamageType WazaDamageType;

	public uint Power;

	public ushort Dex;

	public string Description;
}
