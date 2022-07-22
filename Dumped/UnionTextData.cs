public static class UnionTextData
{
	public enum SpeakerID
	{
		MINE,
		OPPONENT,
		SYSTEM
	}

	public struct MsgStringParamData
	{
		public string msgFileName;

		public string labelName;

		public MsgStringParamData(string msgFile, string label)
		{
		}
	}

	public const int TAG_INDEX_PLAYERNAME = 0;

	public const string UNION_UNIONROOM_MESSAGE_FILE_NAME = "dlp_net_union_room";

	public const string UNION_MENU_NET_COMMUNICATION_MESSAGE_FILE_NAME = "dp_net_communication";

	public const string UNION_MENU_BATTLE_FILE_NAME = "dp_options";

	public const string UNION_UNDERGROUND_MESSAGE_FILE_NAME = "dlp_underground";

	public const string UNION_SS_NET_NET_BTL_MESSGAE_FILE_NAME = "ss_net_net_btl";

	public const string UNION_SS_BOX_MESSGAE_FILE_NAME = "ss_box";

	public const string UNION_SS_NET_LIVE_COMM_MESSGAE_FILE_NAME = "ss_net_live_comm";

	public const string UNION_SS_NET_MESSAGE_ERROR_FILE_NAME = "ss_net_message_error";

	public const string UNION_GMSTATION_FILE_NAME = "dlp_gmstation";

	public static readonly string[] UNION_START_MENU_MASSEAGES;

	public static readonly string UNION_EXIT_MESSAGE;

	public static readonly string GLOBAL_EXIT_MESSAGE;

	public static readonly string COLISEUM_EXIT_MESSAGE;

	public static readonly string UNION_WAIT_SS_GAMING_MESSAGE;

	public static readonly string UNION_WAITOTHER_SS_GAMING_MESSAGE;

	public static readonly string[] UNION_START_MASSEAGES;

	public static readonly string[] UNION_MENU_DESCRIPTION;

	public static readonly string[] GLOBAL_MENU_DESCRIPTION;

	public static readonly string[] UNION_MENU_MASSEAGES;

	public static readonly string[] GLOBAL_MENU_MASSEAGES;

	public static readonly string[] UNION_BATTLE_TYPE;

	public static readonly string[] UNION_SYSTEM_BATTLE;

	public static readonly string[] UNION_NETWORK_ERROR;

	public static readonly string[] UNION_TARDE_ERROR;

	public static readonly string[] UNION_SYSTEM_GREETING;

	public static readonly string[] UNION_SYSTEM_BALLDECO;

	public static readonly string[] UNION_SYSTEM_GREETIMG;

	public static readonly string[] UNION_SYSTEM_COMMUNICATE;

	public static readonly string[] UNION_TALK_BATTLE;

	public static readonly string[] UNION_TALK_TRADE;

	public static readonly string[] UNION_TALK_RECODE;

	public static readonly string[] UNION_TALK_GREETING;

	public static readonly string[] UNION_TALK_BALLDECO;

	public static readonly string UNION_TEADE_PENALTY;

	public static readonly string[] UNION_TALK_NPC;

	public static readonly string[] GLOBAL_TALK_NPC;

	public static readonly string[] UNION_TALK_NPC_START_CONTEXT;

	public static readonly string UNION_DESCRIPTION_START;

	public static readonly string[] UNION_TALK_NPC_STATE_DESCRIPTION;

	public static readonly string[] GLOBAL_TALK_NPC_STATE_DESCRIPTION;

	public static readonly string[] UNION_TALK_NPC_NO_PLAYER;

	public static readonly string[] UNION_TALK_NPC_OTHER_PLAYER;

	public static readonly string[] UNION_TALK_NPC_SETTING_ROOM;

	public static readonly string[] UNION_TALK_NPC_CHANGE_GLOBAL_MODE;

	public static readonly string[] UNION_INTERNET_START;

	public static readonly string UNION_INTERNET_CONNECT_WAIT;

	public static readonly string[] UNION_CHECK_END;

	public static readonly string[] UNION_NPC_TRADE;

	public static readonly string[] COLISEUM_TALK_NPC;

	public static readonly string[] COLISEUM_TALK_NPC_START_CONTEXT;

	public static readonly string[] COLISEUM_TALK_NPC_STATE_DESCRIPTION;

	public static readonly string[] COLISEUM_TALK_NPC_END;

	public static readonly string[] COLISEUM_TALK_NOT_CHANGE_BATTLERULE;

	public static readonly string[] COLISEUM_TALK_NPC_SETTING_BATTLE_RULE;

	public static readonly string[] COLISEUM_TALK_CHECK_BATTLERULE;

	public static readonly string[] COLISEUM_BATTLE_RULE_SELECT;

	public static readonly string[] UNION_SYSTEM_MESSAGE;

	public static readonly string UNION_SECURITY_TRADE_ERROR;

	public static readonly string UNION_CANCEL_TRADE_MATCH;

	public static readonly string[] UNION_SECURITY_TRADE_WAIT_CANCEL;

	public static readonly string[] BATTLE_DESCRIPTION;

	public static readonly string UNION_RECODE_TRADE_MATCH_HOST;

	public static readonly string UNION_RECODE_TRADE_CHECK;

	public static readonly string UNION_RECODE_TRADE_MATCH_GUEST;

	public static readonly string[] UNION_RECODE_TRADE_CHECK_JOIN;

	public static readonly string COLISEUM_MATCH_WAITING;

	public static readonly string COLISEUM_BATTLE_START;
}
