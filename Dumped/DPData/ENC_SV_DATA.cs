using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 392)]
public struct ENC_SV_DATA
{
	public int encountWalkCount;

	public int SafariRandSeed;

	public int GenerateRandSeed;

	public HILL_BACK_DATA HillBackData;

	public HONEY_TREE HoneyTree;

	public SWAY_GRASS_HIST SwayGrassHist;

	public PLAYER_ZONE_HIST PlayerZoneHist;

	public MV_POKE_DATA[] MovePokeData;

	public bool GenerateValid;

	public short SprayCount;

	public byte SprayType;

	public byte BtlSearcherCharge;

	public byte PokeToreCharge;

	public byte VidroType;
}
