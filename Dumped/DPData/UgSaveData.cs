using System;
using System.Runtime.InteropServices;
using Pml.PokePara;
using UnityEngine;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 10144)]
public struct UgSaveData
{
	public int ReturnZoneID;

	public int ReturnGridPosX;

	public int ReturnPosY;

	public int ReturnGridPosZ;

	public LOCATION_WORK ReturnZenmetsu_Ground;

	public DigPos[] DigPoints;

	[SerializeField]
	public SerializedPokemonFull[] EncountPokes;

	[SerializeField]
	public Vector3[] EncountPokePositions;

	public int ReturnUgZoneID;

	public UGRecord ugRecord;

	public UgPlayerInfo[] FriendPlayerList;

	public UgPlayerInfo[] OtherPlayerList;

	public byte[] TalkedNPCsID;

	public Vector2Int ReturnLocator => default(Vector2Int);

	public float ReturnHeight => default(float);

	public void ClearEncountPokes()
	{
	}
}
