using Dpr.Battle.View;
using Dpr.Message;
using Pml;
using Pml.PokePara;

namespace Dpr.Contest;

public class EntryPlayerData
{
	public BtlvBallInfo ballInfo;

	public string playerName;

	public string pokemonNickName;

	public string trainerModelPath;

	public ushort fashion;

	public PlayerType playerType;

	public WazaNo wazaNo;

	public MonsNo monsNo;

	public Sex playerSex;

	public Sex monsSex;

	public RareType rareType;

	public ushort itemNo;

	public MessageEnumData.MsgLangId userLangID;

	public MessageEnumData.MsgLangId monsLangID;

	public float wazaSeqTime;

	public uint formNo;

	public int cassetVersion;

	public int colorID;

	public int npcDataIndex;

	public WazaNo npcWazaNo;

	public byte style;

	public byte beautiful;

	public byte cute;

	public byte clever;

	public byte strong;

	public byte fur;

	public bool isRare;

	public bool isDpClear;

	public void Reset()
	{
	}
}
