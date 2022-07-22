using System.Runtime.InteropServices;
using System.Text;
using Dpr.Message;
using Dpr.Trainer;
using Pml;

namespace Dpr.Battle.Logic;

public class BattleStr
{
	public enum MsgSrcID
	{
		STD,
		SET,
		ATK,
		TALK,
		TRMSG,
		TRMSG_SUB,
		APP,
		POKELIST,
		MAX
	}

	private enum SetStrFormat
	{
		MINE,
		WILD,
		ENEMY,
		TRAINER,
		MAX
	}

	private static readonly string[] MSBT_MSG_FILES;

	private static BattleStr s_Instance;

	private static bool isInitializedOwner;

	private MainModule mainModule;

	private POKECON pokeCon;

	private MessageMsgFile[] _msgFiles;

	private uint clientID;

	private bool fIgnoreFormat;

	private bool fForceTrueName;

	private const int MAX_TAG_NUM = 20;

	private const int BUFIDX_POKE_1ST = 0;

	private const int BUFIDX_POKE_2ND = 1;

	private const int BUFIDX_TRAINER_NAME_1ST = 10;

	private const int BUFIDX_TRAINER_NAME_2ND = 11;

	private static readonly ushort[] USE_TRMSG_SUB_TABLE;

	private StringBuilder checkTagSb;

	private static StringBuilder textSb;

	public static BattleStr Instance => null;

	private MessageMsgFile GetMsgFile(MsgSrcID id)
	{
		return null;
	}

	public static void InitSystem(MainModule mainModule, byte playerClientID, POKECON pokeCon)
	{
	}

	public static void QuitSystem()
	{
	}

	public BattleStr(MainModule mainModule, byte playerClientID, POKECON pokeCon)
	{
	}

	public void SetupMsgFiles()
	{
	}

	private void UnSetupMsgFiles()
	{
	}

	private bool register_PokeNickname(MessageMsgFile msgFile, byte pokeID, int bufID, bool isTruth = false)
	{
		return default(bool);
	}

	private void register_PokeName(MessageMsgFile msgFile, byte pokeID, byte bufID)
	{
	}

	private void register_TrainerType(MessageMsgFile msgFile, byte bufIdx, byte clientID)
	{
	}

	private bool register_TrainerName(MessageMsgFile msgFile, byte bufIdx, byte clientID)
	{
		return default(bool);
	}

	private void register_TrainerTypeAndTrainerName(MessageMsgFile msgFile, byte typeAndNameBufIdx, byte trainerNameBufIdx, byte clientID)
	{
	}

	private void register_ItemName(MessageMsgFile msgFile, byte bufIdx, ItemNo itemNo)
	{
	}

	public MessageTextParseDataModel MakeStringStd(int strID, int[] inArgs)
	{
		return null;
	}

	public MessageTextParseDataModel MakeStringStdWithArgArray(int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_std_simple(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_std_side(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_std_cheer(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_std_useitem(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_std_gshockwave_rank(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private void registerWords(MessageMsgFile msgFile, MessageTextParseDataModel textData, int[] args)
	{
	}

	public MessageTextParseDataModel MakeStringSet(int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_auto(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_default(MessageMsgFile msgFile, int defaultStrID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_poke2(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_rankup(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_rankup_at_once(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_rankup_item(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private MessageTextParseDataModel mkstr_set_rank_limit(MessageMsgFile msgFile, int strID, int[] args)
	{
		return null;
	}

	private SetStrFormat get_strFormat(byte pokeID)
	{
		return default(SetStrFormat);
	}

	private bool isIgnoreStrFormat(byte pokeID)
	{
		return default(bool);
	}

	private int get_setStrID(byte pokeID, int defaultStrID)
	{
		return default(int);
	}

	private int get_setStrID_Poke2(byte pokeID1, byte pokeID2, int defaultStrID)
	{
		return default(int);
	}

	private int get_setPtnStrID(byte pokeID, int originStrID, byte ptnNum)
	{
		return default(int);
	}

	private int searchPokeTagCount(MessageMsgFile msgFile, int strID)
	{
		return default(int);
	}

	public MessageTextParseDataModel MakeStringWaza(byte pokeID, ushort waza)
	{
		return null;
	}

	private MessageTextParseDataModel makeStringWaza(byte pokeID, ushort waza)
	{
		return null;
	}

	public MessageTextParseDataModel MakeStringTrainer(TrainerID trainerID, string msgLabel)
	{
		return null;
	}

	private MsgSrcID GetTrainerMsgSrcFromTrainerID(TrainerID trainerID)
	{
		return default(MsgSrcID);
	}

	public MessageTextParseDataModel MakeStringTalk(int strID, int[] args)
	{
		return null;
	}

	public MessageTextParseDataModel MakeStringTalk_simple(int strID)
	{
		return null;
	}

	private MessageTextParseDataModel formatTextMessage(MessageMsgFile msgFile, MessageTextParseDataModel textData)
	{
		return null;
	}

	private void CheckTagSet(MessageMsgFile msgFile, MessageTextParseDataModel textData, int strID)
	{
	}

	private bool getTextDataModel(MessageMsgFile msgFile, int strID, out MessageTextParseDataModel outTextData)
	{
		return default(bool);
	}

	private MsgSrcID GetMsgSrcID(MessageMsgFile msgFile)
	{
		return default(MsgSrcID);
	}

	public static string MakeText(MessageTextParseDataModel textData)
	{
		return null;
	}

	public string GetFormatUIText(string label, [Optional] MessageMsgFile msgFile)
	{
		return null;
	}

	public string GetFormatUIText(string label, MsgSrcID srcId)
	{
		return null;
	}

	public string GetFormatUIPokeName(string label, byte pokeID, bool isTruth = false, byte bufID = 0)
	{
		return null;
	}

	public string GetFormatUITrainerName(string label, byte clientID, byte bufID = 0)
	{
		return null;
	}

	public static string GetMonsName(MonsNo monsNo)
	{
		return null;
	}

	public static string GetWazaName(WazaNo wazaNo)
	{
		return null;
	}

	public static string GetTokuseiName(TokuseiNo tokuseiNo)
	{
		return null;
	}

	public static string GetItemName(ItemNo itemNo)
	{
		return null;
	}

	public static string GetWazaInfo(WazaNo wazaNo)
	{
		return null;
	}

	public static string GetTokuseiInfo(TokuseiNo tokuseiNo)
	{
		return null;
	}
}
