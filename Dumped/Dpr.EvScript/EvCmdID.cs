namespace Dpr.EvScript;

public class EvCmdID
{
	public enum NAME
	{
		_NONE_USE_NUMBER,
		_NOP,
		_DUMMY,
		_END,
		_TIME_WAIT,
		_LD_REG_VAL,
		_LD_REG_WDATA,
		_LD_REG_ADR,
		_LD_ADR_VAL,
		_LD_ADR_REG,
		_LD_REG_REG,
		_LD_ADR_ADR,
		_CP_REG_REG,
		_CP_REG_VAL,
		_CP_REG_ADR,
		_CP_ADR_REG,
		_CP_ADR_VAL,
		_CP_ADR_ADR,
		_CMPVAL,
		_CMPWK,
		_DEBUG_WATCH_WORK,
		_VM_ADD,
		_CHG_COMMON_SCR,
		_CHG_LOCAL_SCR,
		_JUMP,
		_OBJ_ID_JUMP,
		_BG_ID_JUMP,
		_PLAYER_DIR_JUMP,
		_CALL,
		_RET,
		_IF_JUMP,
		_IF_CALL,
		_IFVAL_JUMP,
		_IFVAL_CALL,
		_IFWK_JUMP,
		_IFWK_CALL,
		_SWITCH,
		_CASE_JUMP,
		_CASE_CANCEL,
		_ADD_WAITICON,
		_DEL_WAITICON,
		_FLAG_SET,
		_ARRIVE_FLAG_SET,
		_FLAG_RESET,
		_FLAG_CHECK,
		_IF_FLAGON_JUMP,
		_IF_FLAGOFF_JUMP,
		_IF_FLAGON_CALL,
		_IF_FLAGOFF_CALL,
		_FLAG_CHECK_WK,
		_FLAG_SET_WK,
		_TRAINER_FLAG_SET,
		_TRAINER_FLAG_RESET,
		_TRAINER_FLAG_CHECK,
		_IF_TR_FLAGON_JUMP,
		_IF_TR_FLAGOFF_JUMP,
		_IF_TR_FLAGON_CALL,
		_IF_TR_FLAGOFF_CALL,
		_ADD_WK,
		_SUB_WK,
		_LDVAL,
		_LDWK,
		_LDWKVAL,
		_TALKMSG_ALLPUT,
		_TALKMSG_ALLPUT_ARC,
		_TALKMSG_ARC,
		_TALKMSG_ALLPUT_PMS,
		_TALKMSG_PMS,
		_TALKMSG_BTOWER_APPEAR,
		_TALKMSG_NG_POKE_NAME,
		_TALKMSG,
		_TALKMSG_SP,
		_TALKMSG_SP_AUTO,
		_TALKMSG_NOSKIP,
		_TALKMSG_CON_SIO,
		_TALKMSG_AUTOGET,
		_AB_KEYWAIT,
		_AB_KEY_TIME_WAIT,
		_LAST_KEYWAIT,
		_NEXT_ANM_LAST_KEYWAIT,
		_TALK_OPEN,
		_TALK_CLOSE,
		_TALK_CLOSE_NO_CLEAR,
		_TALK_KEYWAIT,
		_EASY_OBJ_MSG,
		_EASY_MSG,
		_BOARD_MAKE,
		_INFOBOARD_MAKE,
		_BOARD_REQ,
		_BOARD_REQ_WAIT,
		_BOARD_MSG,
		_BOARD_END_WAIT,
		_EASY_BOARD_MSG,
		_EASY_INFOBOARD_MSG,
		_MENU_REQ,
		_BG_SCROLL,
		_YES_NO_WIN,
		_GUINNESS_WIN,
		_BMPMENU_INIT,
		_BMPMENU_INIT_EX,
		_BMPMENU_MAKE_LIST,
		_BMPMENU_MAKE_LIST16,
		_BMPMENU_START,
		_SEL_WIN_JUMP,
		_BMPLIST_INIT,
		_BMPLIST_INIT_EX,
		_BMPLIST_MAKE_LIST,
		_BMPLIST_START,
		_BMPMENU_HV_START,
		_SE_PLAY,
		_SE_STOP,
		_SE_WAIT,
		_VOICE_PLAY,
		_VOICE_WAIT,
		_EASY_VOICE_MSG,
		_ME_PLAY,
		_ME_WAIT,
		_SND_INITIAL_VOL_SET,
		_BGM_PLAY,
		_BGM_PLAY_CHECK,
		_BGM_STOP,
		_BGM_NOW_MAP_PLAY,
		_BGM_SPECIAL_SET,
		_BGM_SPECIAL_CLR,
		_BGM_FADEOUT,
		_BGM_FADEOUT_PLAY,
		_BGM_FADEIN,
		_BGM_PLAYER_PAUSE,
		_PLAYER_FIELD_DEMO_BGM_PLAY,
		_CTRL_BGM_FLAG_SET,
		_CTRL_BGM_FLAG_RESET,
		_PERAP_DATA_CHECK,
		_PERAP_REC_START,
		_PERAP_REC_STOP,
		_PERAP_SAVE,
		_SND_CLIMAX_DATA_LOAD,
		_OBJ_ANIME,
		_OBJ_ANIME_POS,
		_ANIME_LABEL,
		_ANIME_DATA,
		_OBJ_ANIME_WAIT,
		_TALK_OBJ_PAUSE_ALL,
		_OBJ_PAUSE_ALL,
		_OBJ_PAUSE_CLEAR_ALL,
		_OBJ_PAUSE,
		_OBJ_PAUSE_CLEAR,
		_OBJ_ADD,
		_OBJ_DEL,
		_VANISH_DUMMY_OBJ_ADD,
		_VANISH_DUMMY_OBJ_DEL,
		_TURN_HERO_SITE,
		_TALK_OBJ_START,
		_TALK_OBJ_START_TURN_NOT,
		_TALK_OBJ_END,
		_TALK_START,
		_EVENT_START,
		_TALK_END,
		_EVENT_END,
		_PLAYER_POS_GET,
		_OBJ_POS_GET,
		_PLAYER_POS_OFFSET_SET,
		_PLAYER_DIR_GET,
		_NOT_ZONE_DEL_SET,
		_MOVE_CODE_CHANGE,
		_MOVE_CODE_GET,
		_PAIR_OBJID_SET,
		_EVENT_DATA,
		_EVENT_DATA_END,
		_SP_EVENT_DATA_END,
		_SCENE_CHANGE_LABEL,
		_SCENE_CHANGE_DATA,
		_SCENE_CHANGE_END,
		_FLAG_CHANGE_LABEL,
		_OBJ_CHANGE_LABEL,
		_INIT_CHANGE_LABEL,
		_ADD_GOLD,
		_SUB_GOLD,
		_COMP_GOLD,
		_GOLD_WIN_WRITE,
		_GOLD_WIN_DEL,
		_GOLD_WRITE,
		_COIN_WIN_WRITE,
		_COIN_WIN_DEL,
		_COIN_WRITE,
		_GET_COIN_NUM,
		_ADD_COIN,
		_SUB_COIN,
		_FLD_ITEM_EVENT,
		_HIDE_ITEM_EVENT,
		_ADD_ITEM,
		_SUB_ITEM,
		_ADD_ITEM_CHK,
		_ITEM_CHK,
		_WAZA_ITEM_CHK,
		_GET_POCKET_NO,
		_CHECK_POCKET,
		_ADD_BOX_ITEM,
		_CHK_BOX_ITEM,
		_ADD_GOODS,
		_SUB_GOODS,
		_ADD_GOODS_CHK,
		_GOODS_CHK,
		_ADD_TRAP,
		_SUB_TRAP,
		_ADD_TRAP_CHK,
		_TRAP_CHK,
		_ADD_TREASURE,
		_SUB_TREASURE,
		_ADD_TREASURE_CHK,
		_TREASURE_CHK,
		_ADD_TAMA,
		_SUB_TAMA,
		_ADD_TAMA_CHK,
		_TAMA_CHK,
		_CB_SEAL_KIND_NUM_GET,
		_CB_ITEM_NUM_GET,
		_CB_ITEM_NUM_ADD,
		_UNKNOWN_FORM_GET,
		_ADD_POKEMON,
		_ADD_TAMAGO,
		_CHG_POKE_WAZA,
		_CHK_POKE_WAZA,
		_CHK_POKE_WAZA_GROUP,
		_APPROVE_POISON_DEAD,
		_REVENGE_TRAINER_SEARCH,
		_INIT_WEATHER,
		_SET_WEATHER,
		_UPDATE_WEATHER,
		_GET_MAP_POS,
		_GET_TEMOTI_POKE_NUM,
		_SET_MAP_PROC,
		_FINISH_MAP_PROC,
		_WIFI_AUTO_REG,
		_WIFI_P2P_MATCH_EVENT_CALL,
		_WIFI_P2P_MATCH_SET_DEL,
		_COMM_GET_CURRENT_ID,
		_DENDOU_NUM_GET,
		_POKE_WINDOW_PUT,
		_POKE_WINDOW_PUT_PP,
		_POKE_WINDOW_DEL,
		_POKE_WINDOW_ANM,
		_POKE_WINDOW_ANM_WAIT,
		_BTL_SEARCHER_EVENT_CALL,
		_BTL_SEARCHER_DIR_MV_SET,
		_MSG_BOY_EVENT,
		_IMAGE_CLIP_SET_PROC,
		_IMAGE_CLIP_VIEW_TV_SET_PROC,
		_IMAGE_CLIP_VIEW_CON_SET_PROC,
		_CUSTOM_BALL_EVENT_CALL,
		_TMAP_BG_SET_PROC,
		_BOX_SET_PROC,
		_OEKAKI_BOARD_SET_PROC,
		_TR_CARD_SET_PROC,
		_TRADE_LIST_SET_PROC,
		_RECORD_CORNER_SET_PROC,
		_DENDOU_SET_PROC,
		_PC_DENDOU_SET_PROC,
		_WORLDTRADE_SET_PROC,
		_DPW_INIT_PROC,
		_FIRST_POKE_SELECT_PROC,
		_FIRST_POKE_SELECT_SET_AND_DEL,
		_BAG_SET_PROC_NORMAL,
		_BAG_SET_PROC_KINOMI,
		_BAG_GET_RESULT,
		_POKELIST_SET_PROC,
		_NPC_TRADE_POKELIST_SET_PROC,
		_UNION_POKELIST_SET_PROC,
		_POKELIST_GET_RESULT,
		_CON_POKELIST_SET_PROC,
		_CON_POKELIST_GET_RESULT,
		_CON_POKESTATUS_SET_PROC,
		_POKESTATUS_GET_RESULT,
		_WIFI_EARTH_SET_PROC,
		_EYE_TRAINER_MOVE_SET,
		_EYE_TRAINER_MOVE_CHECK,
		_EYE_TRAINER_TYPE_GET,
		_EYE_TRAINER_ID_GET,
		_NAMEIN,
		_NAMEIN_POKE,
		_WIPE_FADE_START,
		_WIPE_FADE_END_CHECK,
		_WHITE_OUT,
		_WHITE_IN,
		_BLACK_OUT,
		_BLACK_IN,
		_MAP_CHANGE,
		_MAP_CHANGE_NONE_FADE,
		_COLOSSEUM_MAP_CHANGE_IN,
		_COLOSSEUM_MAP_CHANGE_OUT,
		_GET_BEFORE_ZONE_ID,
		_GET_NOW_ZONE_ID,
		_KABENOBORI,
		_NAMINORI,
		_BICYCLE_CHECK,
		_BICYCLE_REQ,
		_BICYCLE_REQ_NON_BGM,
		_CYCLING_ROAD_SET,
		_PLAYER_FORM_GET,
		_PLAYER_REQ_BIT_ON,
		_PLAYER_REQ_START,
		_TAKINOBORI,
		_SORAWOTOBU,
		_HIDEN_FLASH,
		_HIDEN_KIRIBARAI,
		_CUTIN,
		_CON_HERO_CHANGE,
		_PLAYER_NAME,
		_RIVAL_NAME,
		_SUPPORT_NAME,
		_POKEMON_NAME,
		_ITEM_NAME,
		_POCKET_NAME,
		_ITEM_WAZA_NAME,
		_WAZA_NAME,
		_NUMBER_NAME,
		_NUMBER_NAME_EX,
		_BIRTH_DAY_CHECK,
		_ANOON_SEE_NUM,
		_NICK_NAME,
		_POKETCH_NAME,
		_TR_TYPE_NAME,
		_MY_TR_TYPE_NAME,
		_POKEMON_NAME_EXTRA,
		_FIRST_POKEMON_NAME,
		_RIVAL_POKEMON_NAME,
		_SUPPORT_POKEMON_NAME,
		_FIRST_POKE_NO_GET,
		_NUTS_NAME,
		_SEIKAKU_NAME,
		_GOODS_NAME,
		_TRAP_NAME,
		_TAMA_NAME,
		_ZONE_NAME,
		_GENERATE_INFO_GET,
		_TRAINER_ID_GET,
		_TRAINER_BTL_SET,
		_TRAINER_MULTI_BTL_SET,
		_TRAINER_MSG_SET,
		_TRAINER_TALK_TYPE_GET,
		_REVENGE_TRAINER_TALK_TYPE_GET,
		_TRAINER_TYPE_GET,
		_TRAINER_BGM_SET,
		_TRAINER_LOSE,
		_TRAINER_LOSE_CHECK,
		_NORMAL_LOSE,
		_LOSE_CHECK,
		_SEACRET_POKE_RETRY_CHECK,
		_HAIFU_POKE_RETRY_CHECK,
		_2VS2_BATTLE_CHECK,
		_DEBUG_BTL_SET,
		_DEBUG_TRAINER_FLAG_SET,
		_DEBUG_TRAINER_FLAG_ON_JUMP,
		_DEBUG_TR_TALK_BTL,
		_SEL_PARENT_WIN,
		_SEL_CHILD_WIN,
		_DEBUG_PARENT_WIN,
		_DEBUG_CHILD_WIN,
		_DEBUG_SIO_ENCOUNT,
		_DEBUG_SIO_CONTEST,
		_CONSIO_TIMING_SEND,
		_CONSIO_TIMING_CHECK,
		_CON_SYSTEM_CREATE,
		_CON_SYSTEM_EXIT,
		_CON_JUDGE_NAME_GET,
		_CON_BREEDER_NAME_GET,
		_CON_NICK_NAME_GET,
		_CON_NUM_TAG_SET,
		_CON_SIO_PARAM_INIT_SET,
		_CONTEST_PROC,
		_CON_RANK_NAME_GET,
		_CON_TYPE_NAME_GET,
		_CON_VICTORY_BREEDER_NAME_GET,
		_CON_VICTORY_ITEM_NO_GET,
		_CON_VICTORY_NICK_NAME_GET,
		_CON_RANKING_CHECK,
		_CON_VICTORY_ENTRY_NO_GET,
		_CON_MY_ENTRY_NO_GET,
		_CON_OBJ_CODE_GET,
		_CON_POPULARITY_GET,
		_CON_DESK_MODE_GET,
		_CON_HAVE_RIBBON_CHECK,
		_CON_RIBBON_NAME_GET,
		_CON_ACCE_NO_GET,
		_CON_ENTRY_PARAM_GET,
		_CON_CAMERA_FLASH_SET,
		_CON_CAMERA_FLASH_CHECK,
		_CON_HBLANK_STOP,
		_CON_HBLANK_START,
		_CON_ENDING_SKIP_CHECK,
		_CON_RECORD_DISP,
		_CON_MSGPRINT_FLAG_SET,
		_CON_MSGPRINT_FLAG_RESET,
		_SP_LOCATION_SET,
		_ELEVATOR_FLOOR_GET,
		_ELEVATOR_FLOOR_WRITE,
		_SHINOU_ZUKAN_SEE_NUM,
		_SHINOU_ZUKAN_GET_NUM,
		_ZENKOKU_ZUKAN_SEE_NUM,
		_ZENKOKU_ZUKAN_GET_NUM,
		_CHK_ZENKOKU_ZUKAN,
		_GET_HYOUKA_MSGID,
		_WILD_BTL_SET,
		_SP_WILD_BTL_SET,
		_FIRST_BTL_SET,
		_CAPTURE_BTL_SET,
		_HONEY_TREE,
		_GET_HONEY_TREE_STATE,
		_HONEY_TREE_BTL_SET,
		_HONEY_TREE_AFTER_SET,
		_TSIGN_SET_PROC,
		_REPORT_SAVE_CHECK,
		_REPORT_SAVE,
		_REPORT_WIN_OPEN,
		_REPORT_WIN_CLOSE,
		_CLIP_TVSAVEDATA_CHECK,
		_CLIP_CONSAVEDATA_CHECK,
		_CLIP_TV_TITLE_SAVE,
		_GET_POKETCH,
		_GET_POKETCH_FLAG,
		_POKETCH_ADD,
		_POKETCH_CHECK,
		_COMM_SYNCHRONIZE,
		_COMM_RESET,
		_UNION_PARENT_CARD_TALK_NO,
		_UNION_GET_INFO_TALK_NO,
		_UNION_BEACON_CHANGE,
		_UNION_CONNECT_TALK_DENIED,
		_UNION_CONNECT_TALK_OK,
		_UNION_TRAINER_NAME_REGIST,
		_UNION_RETURN_SETUP,
		_UNION_CONNECT_CUT_RESTART,
		_UNION_GET_TALK_NUMBER,
		_UNION_ID_SET,
		_UNION_RESULT_GET,
		_UNION_OBJ_ALL_VANISH,
		_UNION_SCRIPT_RESULT_SET,
		_UNION_PARENT_START_COMMAND_SET,
		_UNION_CHILD_SELECT_COMMAND_SET,
		_UNION_CONNECT_START,
		_UNION_MAP_CHANGE,
		_UNION_VIEW_TR_SEL_SET,
		_UNION_VIEW_TR_TYPE_MSG_GET,
		_UNION_VIEW_TR_TYPE_NO_GET,
		_UNION_VIEW_MY_STATUS_SET,
		_SYS_FLAG_ZUKAN_GET,
		_SYS_FLAG_ZUKAN_SET,
		_SYS_FLAG_SHOES_GET,
		_SYS_FLAG_SHOES_SET,
		_SYS_FLAG_BADGE_GET,
		_SYS_FLAG_BADGE_SET,
		_SYS_FLAG_BADGE_COUNT,
		_SYS_FLAG_BAG_GET,
		_SYS_FLAG_BAG_SET,
		_SYS_FLAG_PAIR_GET,
		_SYS_FLAG_PAIR_SET,
		_SYS_FLAG_PAIR_RESET,
		_SYS_FLAG_ONE_STEP_GET,
		_SYS_FLAG_ONE_STEP_SET,
		_SYS_FLAG_ONE_STEP_RESET,
		_SYS_FLAG_GAME_CLEAR_GET,
		_SYS_FLAG_GAME_CLEAR_SET,
		_SYS_FLAG_KAIRIKI_SET,
		_SYS_FLAG_KAIRIKI_RESET,
		_SYS_FLAG_KAIRIKI_GET,
		_SYS_FLAG_FLASH_SET,
		_SYS_FLAG_FLASH_RESET,
		_SYS_FLAG_FLASH_GET,
		_SYS_FLAG_KIRIBARAI_SET,
		_SYS_FLAG_KIRIBARAI_RESET,
		_SYS_FLAG_KIRIBARAI_GET,
		_SHOP_CALL,
		_FIX_SHOP_CALL,
		_FIX_GOODS_CALL,
		_FIX_SEAL_CALL,
		_ACCE_SHOP_CALL,
		_PLAYER_REPORT_DRAW_SET,
		_PLAYER_REPORT_DRAW_DEL,
		_GAME_OVER_CALL,
		_SET_WARP_ID,
		_GET_MY_SEX,
		_PC_KAIFUKU,
		_UG_MAN_SHOP_NPC_RAND_PLACE,
		_COMM_DIRECT_END,
		_COMM_DIRECT_END_TIMING,
		_COMM_DIRECT_ENTER_BTL_ROOM,
		_COMM_PLAYER_SET_DIR,
		_SET_UP_DOOR_ANIME,
		_WAIT_3D_ANIME,
		_FREE_3D_ANIME,
		_SEQ_OPEN_DOOR,
		_SEQ_CLOSE_DOOR,
		_PMS_INPUT_SINGLE,
		_PMS_INPUT_DOUBLE,
		_PMS_BUF,
		_GET_SEED_STATUS,
		_GET_SEED_TYPE,
		_GET_SEED_COMPOST,
		_GET_SEED_GROUND,
		_GET_SEED_COUNT,
		_SET_SEED_COMPOST,
		_SET_SEED_NUTS,
		_SET_SEED_WATER,
		_TAKE_SEED,
		_SXY_POS_CHANGE,
		_OBJ_POS_CHANGE,
		_SXY_MV_CHANGE,
		_SXY_DIR_CHANGE,
		_SXY_EXIT_POS_CHANGE,
		_SXY_BG_POS_CHANGE,
		_OBJ_DIR_CHANGE,
		_RETURN_SCRIPT_WK_SET,
		_MSGEXPANDBUF,
		_GET_SODATE_NAME,
		_GET_SODATEYA_ZIISAN,
		_INIT_WATER_GYM,
		_PUSH_WATER_GYM_BUTTON,
		_INIT_GHOST_GYM,
		_MOVE_GHOST_GYM_LIFT,
		_INIT_STEEL_GYM,
		_INIT_COMBAT_GYM,
		_INIT_ELEC_GYM,
		_ROTATE_ELEC_GYM_GEAR,
		_GET_POKE_COUNT,
		_GET_POKE_COUNT2,
		_GET_POKE_COUNT3,
		_GET_POKE_COUNT4,
		_GET_TAMAGO_COUNT,
		_UG_SHOP_MENU_INIT,
		_UG_SHOP_TALK_START,
		_UG_SHOP_TALK_END,
		_UG_SHOP_ITEM_NAME,
		_UG_SHOP_TRAP_NAME,
		_DEL_SODATEYA_EGG,
		_GET_SODATEYA_EGG,
		_MSG_SODATEYA_AISHOU,
		_MSG_AZUKE_SET,
		_SET_SODATEYA_POKE,
		_SODATEYA_POKELIST,
		_HIKITORI_LIST,
		_SODATE_POKE_LEVEL_STR,
		_HIKITORI_RYOUKIN,
		_HIKITORI_POKE,
		_TAMAGO_DEMO,
		_TEMOTI_MONSNO,
		_MONS_OWN_CHK,
		_CHK_TEMOTI_POKERUS,
		_TEMOTI_POKE_SEX_GET,
		_SUB_MY_GOLD,
		_COMP_MY_GOLD,
		_OBJ_VISIBLE,
		_OBJ_INVISIBLE,
		_MAILBOX,
		_GET_MAILBOX_DATANUM,
		_RANKING_VIEW,
		_GET_TIME_ZONE,
		_GET_RND,
		_GET_RND_NEXT,
		_GET_NATSUKI,
		_ADD_NATSUKI,
		_SUB_NATSUKI,
		_HIKITORI_LIST_NAME_SET,
		_GET_SODATEYA_AISHOU,
		_SODATEYA_TAMAGO_CHK,
		_TEMOTI_POKE_CHK,
		_OOKISA_RECORD_CHK,
		_OOKISA_RECORD_SET,
		_OOKISA_TEMOTI_SET_BUF,
		_OOKISA_KIROKU_SET_BUF,
		_OOKISA_KURABE_INIT,
		_WAZALIST_SET_PROC,
		_WAZALIST_GET_RESULT,
		_WAZA_COUNT,
		_WAZA_DEL,
		_TEMOTI_WAZANO,
		_TEMOTI_WAZA_NAME,
		_FNOTE_START_SET,
		_FNOTE_DATA_MAKE,
		_FNOTE_DATA_SAVE,
		_IMC_ACCE_ADD_ITEM,
		_IMC_ACCE_ADD_ITEM_CHK,
		_IMC_ACCE_ITEM_CHK,
		_IMC_BG_ADD_ITEM,
		_IMC_BG_ITEM_CHK,
		_NUTMIXER_CALL,
		_NUTMIXER_PLAY_CHECK,
		_ZUKAN_CHK_SHINOU,
		_ZUKAN_CHK_NATIONAL,
		_ZUKAN_RECONGNIZE_SHINOU,
		_ZUKAN_RECONGNIZE_NATIONAL,
		_URAYAMA_ENCOUNT_SET,
		_URAYAMA_ENCOUNT_NO_CHK,
		_POKE_MAIL_CHK,
		_PAPERPLANE_SET,
		_POKE_MAIL_DEL,
		_KASEKI_COUNT,
		_ITEMLIST_SET_PROC,
		_ITEMLIST_GET_RESULT,
		_ITEMNO_TO_MONSNO,
		_KASEKI_ITEMNO,
		_POKE_LEVEL_CHK,
		_BTOWER_APP_CALL,
		_BTOWER_WORK_CLEAR,
		_BTOWER_WORK_INIT,
		_BTOWER_WORK_RELEASE,
		_BTOWER_TOOLS,
		_BTOWER_SEVEN_POKE_GET,
		_BTOWER_PRIZE_GET,
		_BTOWER_PRIZEMAN_SET,
		_BTOWER_SEND_BUF,
		_BTOWER_RECV_BUF,
		_BTOWER_GET_LEADER_ROOMID,
		_BTOWER_IS_LEADER_EXIST,
		_RECORD_INC,
		_RECORD_GET,
		_RECORD_ADD,
		_RECORD_SET,
		_RECORD_SETIFLARGE,
		_SAFARI_START,
		_SAFARI_END,
		_CALL_SAFARI_SCOPE,
		_CLIMAX_DEMO,
		_INIT_SAFARI_TRAIN,
		_MOVE_SAFARI_TRAIN,
		_CHECK_SAFARI_TRAIN,
		_PLAYER_HEGIHT_VALID,
		_GET_POKE_SEIKAKU,
		_CHK_POKE_SEIKAKU_ALL,
		_UNDERGROUND_TALK_COUNT,
		_NATURAL_PARK_WALK_COUNT_CLEAR,
		_NATURAL_PARK_WALK_COUNT_GET,
		_NATURAL_PARK_ACCESSORY_NO_GET,
		_GET_NEWS_POKE_NO,
		_NEWS_COUNT_SET,
		_NEWS_COUNT_CHK,
		_START_GENERATE,
		_ADD_MOVE_POKE,
		_OSHIE_WAZA_COUNT,
		_REMAIND_WAZA_COUNT,
		_OSHIE_WAZALIST_SET_PROC,
		_REMAIND_WAZALIST_SET_PROC,
		_OSHIE_WAZALIST_GET_RESULT,
		_REMAIND_WAZALIST_GET_RESULT,
		_NORMAL_WAZALIST_SET_PROC,
		_NORMAL_WAZALIST_GET_RESULT,
		_FLD_TRADE_ALLOC,
		_FLD_TRADE_MONSNO,
		_FLD_TRADE_CHG_MONSNO,
		_FLD_TRADE_EVENT,
		_FLD_TRADE_DEL,
		_ZUKAN_TEXT_VER_UP,
		_ZUKAN_SEX_VER_UP,
		_ZENKOKU_ZUKAN_FLAG,
		_CHK_RIBBON_COUNT,
		_CHK_RIBBON_COUNT_ALL,
		_CHK_RIBBON,
		_SET_RIBBON,
		_RIBBON_NAME,
		_CHK_PRMEXP,
		_CHK_WEEK,
		_TV_ENTRY_WATCH_HIDE_ITEM,
		_TV_ENTRY_WATCH_CHANGE_NAME,
		_REGULATION_LIST_CALL,
		_ASHIATO_CHK,
		_PC_RECOVER_ANM,
		_ELEVATOR_ANM,
		_CALL_SHIP_DEMO,
		_DEBUG_PRINT_WORK,
		_DEBUG_PRINT_FLAG,
		_DEBUG_PRINT_WORK_STATIONED,
		_DEBUG_PRINT_FLAG_STATIONED,
		_PM_VERSION_GET,
		_FRONT_POKEMON,
		_TEMOTI_POKE_TYPE,
		_AIKOTOBA_KABEGAMI_SET,
		_GET_UG_HATA_NUM,
		_SETUP_PASO_ANM,
		_START_PASO_ON_ANM,
		_START_PASO_OFF_ANM,
		_GET_KUJI_ATARI_NUM,
		_KUJI_ATARI_CHK,
		_KUJI_ATARI_INIT,
		_NICK_NAME_PC,
		_TV_INTERVIEWER_CHECK,
		_COUNT_MONSBOX_SPACE,
		_POKEPARK_CONTROL,
		_POKEPARK_DEPOSIT_COUNT,
		_POKEPARK_TRANS_MONS,
		_POKEPARK_GET_SCORE,
		_DENDOU_BALL_ANM,
		_INIT_FLD_LIFT,
		_MOVE_FLD_LIFT,
		_CHECK_FLD_LIFT,
		_SETUP_RAH_CYL,
		_START_RAH_CYL,
		_ADD_SCORE,
		_ACCE_NAME,
		_PARTY_MONSNO_CHECK,
		_PARTY_DEOKISISUFORM_CHANGE,
		_CHECKMINOMUCHICOMP,
		_POKETCH_HOOK_SET,
		_POKETCH_HOOK_RESET,
		_SLOT_MACHINE,
		_GET_NOW_HOUR,
		_FLDOBJ_SHAKE_ANM,
		_FLDOBJ_BLINK_ANM,
		_D20R0106_LEGEND_IS_UNSEAL,
		_DRESSING_IMC_ACCE_CHECK,
		_AGB_CARTRIDGE_VER_GET,
		_UNDERGROUND_TALK_COUNT_CLEAR,
		_HIDEMAP_STATE_CHG,
		_NAMEIN_MONUMENT,
		_MONUMENT_NAME,
		_IMC_BG_NAME,
		_COMP_COIN,
		_SLOT_RENTYAN_CHK,
		_ADD_COIN_CHK,
		_LEVEL_JIJII_NO,
		_POKE_LEVEL_GET,
		_IMC_ACCE_SUB_ITEM,
		_C08R0801SCOPECAMERASET,
		_LEVEL_JIJII_INIT,
		_NEW_NANKAI_WORD_SET,
		_REGULAR_CHECK,
		_NEW_NANKAI_WORD_COMPLETE_CHECK,
		_TEMOTI_POKE_CONTEST_STATUS_GET,
		_D17SYSTEM_MAP_SELECT,
		_UNDERGROUND_TOOL_GIVE_COUNT,
		_UNDERGROUND_KASEKI_DIG_COUNT,
		_UNDERGROUND_TRAP_HIT_COUNT,
		_POFIN_ADD,
		_POFIN_ADD_CHK,
		_IS_HAIHU_EVENT_ENABLE,
		_SODATEYA_POKELIST_SET_PROC,
		_SODATEYA_POKELIST_GET_RESULT,
		_GET_RANDOM_HIT,
		_UNDERGROUND_TALK_COUNT2,
		_HIDENEFF_START,
		_ZISHIN,
		_BTL_POINT_WIN_WRITE,
		_BTL_POINT_WIN_DEL,
		_BTL_POINT_WRITE,
		_GET_BTL_POINT,
		_BTL_POINT_ADD,
		_BTL_POINT_SUB,
		_COMP_BTL_POINT,
		_GET_BP_GIFT,
		_UG_BALLITEM_CHECK,
		_AUSU_ITEM_CHECK,
		_CHECK_MY_GSID,
		_FRIEND_DATA_NUM,
		_GET_COIN_GIFT,
		_SUB_WK_COIN,
		_COMP_WK_COIN,
		_AIKOTOBA_OKURIMONO_CHK,
		_WIFI_HUSIGINAOKURIMONO_OPEN_FLAG_SET,
		_UNION_GET_CARD_TALK_NO,
		_WIRELESS_ICON_EASY,
		_WIRELESS_ICON_EASY_END,
		_SAVE_FIELD_OBJ,
		_SEAL_NAME,
		_SET_ESCAPE_LOCATION,
		_FIELDOBJ_BITSET_FELLOWHIT,
		_DAME_TAMAGO_CHK_ALL,
		_UNION_BMPMENU_START,
		_UNION_BATTLE_START_CHECK,
		_GET_TRCARD_RANK,
		_FLD_SCOPE_MODE_ON,
		_FLD_SCOPE_MODE_OFF,
		AC_UP,
		AC_DOWN,
		AC_LEFT,
		AC_RIGHT,
		AC_LOOP,
		AC_DIR_U,
		AC_DIR_R,
		AC_DIR_D,
		AC_DIR_L,
		ACMD_END,
		AC_DIR_VAL,
		AC_WAIT,
		_SET_TURN_HERO_FRAME,
		_SET_TURN_OBJ_FRAME,
		_DEBUG_PRINT,
		AC_MARK_GYOE,
		_FADE_WAIT,
		_HERO_MOVE_GRID_CENTER,
		AC_WORLD_X,
		AC_WORLD_Z,
		AC_HERO_MATCH_X,
		AC_HERO_MATCH_Z,
		_SET_POS_HERO_MATCH_X,
		_SET_POS_HERO_MATCH_Z,
		AC_UP_CENTER,
		AC_DOWN_CENTER,
		AC_LEFT_CENTER,
		AC_RIGHT_CENTER,
		AC_DIR_UP_CENTER,
		AC_DIR_DOWN_CENTER,
		AC_DIR_LEFT_CENTER,
		AC_DIR_RIGHT_CENTER,
		AC_VANISH_ON,
		AC_VANISH_OFF,
		AC_DIR_PAUSE_ON,
		AC_DIR_PAUSE_OFF,
		AC_ANM_PAUSE_ON,
		AC_ANM_PAUSE_OFF,
		AC_PC_BOW,
		AC_HIDE_PULLOFF,
		AC_HERO_BANZAI,
		AC_MARK_SAISEN,
		AC_HERO_BANZAI_UKE,
		ACMD_NOT,
		_GET_LANGUAGE,
		_GET_REL_POS_HERO,
		_CAMERA_TARGET_HERO,
		_CAMERA_TARGET_DUMMY,
		_DUMMY_ANIME,
		_DUMMY_ANIME_WAIT,
		_DUMMY_SET_POS,
		_DUMMY_SET_POS_HERO,
		_SET_CUSTUM_WIN_MSBT,
		_ADD_CUSTUM_WIN_LABEL,
		_OPEN_CUSTUM_WIN,
		_VISIBLE_OBJ_PROP,
		_INVISIBLE_OBJ_PROP,
		_EVENT_CAMERA_MODE,
		_SET_EVENT_CAMERA_PARAM,
		_EVENT_CAMERA_WAIT,
		_EVENT_CAMERA_FRAME,
		_HIT_DOOR_ANIME,
		_HIT_DOOR_ANIME_WAIT,
		_SET_DOOR_OBJ,
		_ROTOMU_FORM_CHECK,
		_TEMOTI_ROTOMU_FORM_WAZA_CHG,
		_EVENT_GET_TEMOTI_POKE_CHK_GET_POS,
		_TURN_HERO_TALK_OBJ,
		_FADE_SPEED,
		_FADE_BALL,
		_FADE_DEFAULT,
		_DOOR_FORCE_ANIME_END,
		_LDVAL_VERSION,
		_LDVAL_SEX,
		_TV_ENTRY_PARKINFO_INIT,
		_TV_ENTRY_PARKINFO_ITEM,
		_TV_ENTRY_PARKINFO_ACCE,
		_GROUP_EXIST_CHECK,
		_GROUP_ENTRY_CHECK,
		_GROUP_NAME,
		_GROUP_LEADER_NAME,
		_GROUP_NAME_IN,
		_GROUP_ENTRY,
		_GROUP_MAKE,
		_MYSTERY_POSTMAN_INIT,
		_MYSTERY_PRESENT_CHECK,
		_MYSTERY_GET_PRESENT_ID,
		_MYSTERY_RECEIVE_CHECK,
		_MYSTERY_RECEIVE_PRESENT,
		_MYSTERY_DISABLE_MSG,
		_MYSTERY_ENABLE_MSG,
		_MYSTERY_POSTMAN_END,
		_MYSTERY_POSTMAN_SAVE_END,
		_UNKNOWN_MSG,
		_TV_INTERVIEW_MSG,
		_TV_INTERVIEW_ENTRY,
		_TV_START,
		_TV_END,
		_TV_START_NUMBER,
		_TV_SET_ENDFLAG,
		_TV_MAKE_MSG,
		_TV_GET_DATA_TOTAL,
		AC_INDEX_ANIME,
		AC_INDEX_ANIME_WAIT,
		_DEBUG_RESET_WORK,
		_SET_SYS_FLAG,
		_RESET_SYS_FLAG,
		_CAMERA_SET_COS_ANGLE,
		_CAMERA_COS_ANGLE_WAIT,
		_HERO_MOVE_GRID_CENTER_FRONT,
		_WARP_ENABLE_SET,
		_DOOR_ENABLE_SET,
		_AC_ANIM_LOCK,
		_AC_ANIM_RELEASE,
		_SET_OFFSET,
		_OFFSET_WAIT,
		_NAMINORI_END,
		_TAKIKUDARI,
		_KABENOBORI_CHECK,
		_TALK_POKE_GET_TEMOTI_INDEX,
		_NATURAL_PARK_GET_MONOHIROI_ITEM_NO,
		_CON_OPEN_POKE_SELECT_MENU,
		_CON_OPEN_CAPSULE_SELECT_MENU,
		_CON_OPEN_BOUTIQUE_SELECT_MENU,
		_CON_WAIT_CONTEST_MENU,
		_CON_MY_ENTRY_NO_WORD_SET,
		_CON_BEST_PERFORMER_CHECK,
		_CON_CATEGORY_RIBBON_NAME_SET,
		_CON_HAVE_CONTEST_STAR_CHECK,
		_CON_CONTEST_STAR_NAME_SET,
		_CON_REWARD_NAME_SET,
		_OBJ_ANIME_FUREAI,
		AC_MARK_EMO,
		_CON_CATEGORY_AND_RANK_SET,
		_CON_RANK_SET,
		_NATURAL_PARK_POKE_CREATE,
		_NATURAL_PARK_POKE_KAISAN,
		_NATURAL_PARK_POKE_SYUUGOU,
		_CON_CHECK_ENTRY_POKE,
		_NATURAL_PARK_POKE_SELECT_MENU,
		AC_NECK_ROTATE,
		_CON_RESET_PARAMETER,
		_CON_SELECT_SINGLE_MODE,
		_CON_SELECT_MULTI_MODE,
		_DPR_SHOP_OPEN,
		_DPR_SHOP_OPEN_WAIT,
		_DOOR_TRANSITION_ZONE_SET,
		_IMAGE_CLIP_VIEW_CON_CHECK_PROC,
		_MOVE_COMBAT_GYM_WALL,
		_EV_ENTITY_PLAYER_MOVE_START,
		_EV_ENTITY_PLAYER_MOVE_END,
		_EV_ENTITY_PLAYER_MOVE_RESET,
		_CHECK_CAN_SEED_WATER,
		_SHOP_OPEN_FIXED,
		_SHOP_OPEN_SEAL,
		_SHOP_OPEN_BATTLE,
		_SHOP_OPEN_FLOWER,
		_SHOP_OPEN_OTENKI,
		_SHOP_OPEN_SELL,
		AC_OFFSET,
		_GET_COSTUME,
		_SHOP_OPEN_BOUTIQUE_BUY,
		_SHOP_OPEN_BOUTIQUE_CHANGE,
		_CON_REWARD_SHOWMASTER_NAME_SET,
		_CON_TWINKLE_STAR_NAME_SET,
		_ANAWOHORU,
		_ANANUKENOHIMO,
		_TELEPORT,
		_AMAIKAORI,
		_CHECK_POFIN,
		_AMAIMITU,
		_WARP_START_ANIMATION,
		_WARP_END_ANIMATION,
		_SAFARI_SCOPE_SEQUENCE,
		_EVENT_CAMERA_INDEX,
		_EVENT_CAMERA_END_WAIT,
		_SHOP_OPEN_PALPARK,
		_BTOWER_APP_WAIT,
		_FLOOR_OPEN,
		_FLOOR_CLOSE,
		_MONEY_OPEN,
		_MONEY_CLOSE,
		_AZUKARIYA_EXIST_EGG,
		_AZUKARIYA_STORED_COUNT,
		_AZUKARIYA_SET_STORED_NAME,
		_AZUKARIYA_STORE,
		_AZUKARIYA_RESTORE,
		_AZUKARIYA_LOVE_LEVEL,
		_AZUKARIYA_GET_STORED_MONSNO,
		_AZUKARIYA_GET_EGG,
		_AZUKARIYA_DISCARD_EGG,
		_AZUKARIYA_SET_STORED_INFO_STR,
		_AZUKARIYA_GET_STORED_SEX,
		_AZUKARIYA_OLDMAN_INIT,
		_ADD_CUSTUM_WIN_LABEL_WORD_SET,
		_OPEN_CUSTUM_WIN_WORD_SET,
		AC_INVISIBLE_ON,
		AC_INVISIBLE_OFF,
		_BTL_ENCSEQ_LOAD,
		_USE_SPRAY,
		_BIRTH_MOUNTH_INPUT,
		_BIRTH_DAY_INPUT,
		_SPEAKERS_NAME,
		_GET_PLAYER_CAP,
		_CAMERA_SHAKE,
		_EVENT_ENTITY_CLIP_PLAY,
		_EVENT_ENTITY_CLIP_WAIT,
		_FACE_INDEX,
		AC_FACE_INDEX,
		_TEMOTI_BALL_LOAD,
		_TEMOTI_BALL_LOAD_WAIT,
		_POKECEN_PUT_BALL,
		_POKECEN_CLEAR_BALL,
		_CHARA_LOOK_LOCK,
		_CHARA_LOOK_RELEASE,
		_TALK_OBJ_START_LOOK_NONE,
		_BOUKENNOOTO_TIPS_OPEN,
		_HIDENEFF_WAIT,
		_GET_URAYAMA_ENCOUNT_INDEX,
		_CUSTOM_BALL_NUM_ADD,
		_CHANGE_FASHION_REQ,
		_WARP_PANEL_START,
		_WARP_PANEL_END,
		_CON_OPEN_MATCHING_MENU,
		_OPEN_PASSWORD_SWKEYBOARD,
		_DENDOU_NUM_SET,
		_TEMOTI_BOX_POKE_CHK,
		_TEMOTI_BOX_MONSNO,
		_CALL_WAZA_OMOIDASHI_UI,
		_CALL_WAZA_WASURE_UI,
		_CALL_WAZA_OSHIE_UI,
		_CHECK_WAZA_OSHIE,
		_CHECK_WAZA_OSHIE_ALL,
		_TEMOTI_BOX_POKEMON_NAME,
		_BTWR_TOOL_CHK_ENTRY_POKE_NUM,
		_BTWR_TOOL_CLEAR_PLAY_DATA,
		_BTWR_TOOL_PUSH_NOW_LOCATION,
		_BTWR_TOOL_POP_NOW_LOCATION,
		_BTWR_TOOL_GET_WIFI_RANK,
		_BTWR_TOOL_SET_PLAY_MODE,
		_BTWR_TOOL_SET_NOW_WIN,
		_BTWR_TOOL_SET_RANK,
		_BTWR_SUB_CHK_ENTRY_POKE,
		_BTWR_SUB_GET_NOW_ROUND,
		_BTWR_SUB_INC_ROUND,
		_BTWR_SUB_IS_CLEAR,
		_BTWR_SUB_GET_RENSHOU_CNT,
		_BTWR_SUB_SET_SCORE,
		_BTWR_SUB_CHOICE_BTL_PARTNER,
		_BTWR_SUB_LOCAL_BTL_CALL,
		_BTWR_SUB_GET_PLAY_MODE,
		_BTWR_SUB_SET_LEADER_CLEAR_FLAG,
		_BTWR_SUB_GET_LEADER_CLEAR_FLAG,
		_BTWR_SUB_ADD_BATTLE_POINT,
		_BTWR_SUB_RENSHOU_RIBBON_SET,
		_BTWR_SUB_GET_MINE_OBJ,
		_BTWR_SUB_UPDATE_RANDOM,
		_BTWR_DEB_IS_WORK_NULL,
		_BOUKENNOOTO_TIPS_WAIT,
		_SAVE_RENDOU_ENABLE,
		_RETURN_LOOP,
		_INPUT_JUMP,
		_BTWR_SUB_BTL_TRAINER_SET,
		_BTWR_SUB_GET_RANK,
		_BTWR_SUB_RANK_DOWN_LOSE,
		_BTWR_SUB_RANK_DOWN_LOSE_RESET,
		_BTWR_SUB_ADD_LOSE,
		_SET_VISIBILITY,
		_LOAD_CAMERA_CONTROLLER,
		_LOAD_WAIT_CAMERA_CONTROLLER,
		_CAMERA_CONTROLLER_PLAY,
		_CAMERA_CONTROLLER_END,
		_TEMOTI_ROTOMU_FORM_CHG_CHECK,
		_TEMOTI_POKE_CHK_NUM,
		_TEMOTI_ROTOMU_FORM_GET,
		_POKELIST_FORM_CHANGE_SET_PROC,
		_POKELIST_FORM_CHANGE_GET_RESULT,
		_TUREARUKI_POKEMON_TALK,
		_TUREARUKI_POKEMON_INDEX,
		_TUREARUKI_TAKE_ITEM,
		_TUREARUKI_ITEM_TIMER_SET,
		_RELEASE_CAMERA_CONTROLLER,
		_FIND_BG_ENABLE,
		_FIND_BG_DISABLE,
		_CALL_EFFECT,
		_STOP_EFFECT,
		_RELEASE_EFFECT,
		_CASSET_VERSION_GET,
		_BOX_OPEN_NORMAL,
		_BOX_OPEN_SELECT,
		_CALL_EFFECT_OBJ,
		_SORAWOTOBU_END,
		_CON_OPEN_RESUME_MATCHING_MENU,
		_BOX_SEAL_UI_WAIT,
		_OBJ_POS_CHANGE_WORLD,
		_OPEN_SPECIAL_WIN_LABEL,
		_WAIT_SPECIAL_WIN_LABEL,
		_AK_LISNER_TRA,
		_AK_LISNER_POS,
		_AK_LISNER_ROT,
		_UNION_PROC,
		_CAMERA_CONTROLLER_WAIT,
		_SET_TV_INT,
		_SET_TV_PLAYER_NAME,
		_SET_TV_POKE_NICK_NAME,
		_TV_TPIC_ENABLE,
		_TV_TPIC_BRANCH,
		_TUREARUKI_POKE_CREATE,
		_TUREARUKI_POKE_DELETE,
		_AUTO_TANKEN_SET,
		_SET_MATCHING_GROUP,
		_AUTO_TANKEN_SET_WAIT,
		_USE_TANKENSET,
		_TALK_UNION_NPC,
		_CHECK_ONLINE_ACCOUNT,
		_WAIT_CHECK_ONLINE_ACCOUNT,
		_LOCALKOUKAN_APPLY,
		_ZUKAN_TOUROKU,
		_ZUKAN_TOUROKU_WAIT,
		_CHK_ZUKAN_TOUROKU,
		_AUTO_SAVE,
		_ENDING_DEMO,
		_AZUKARIYA_TAKE_OVER_POKE,
		_POKETORE_GET_CHARGE,
		_POKETORE_START,
		_BICYCLE_COLOR_SET,
		_BICYCLE_COLOR_GET,
		_PARK_ITEM_NAME,
		_LOAD_UMA_ANIME,
		_RELEASE_UMA_ANIME,
		_LOAD_UMA_ANIME_WAIT,
		_UMA_ANIME_PLAY,
		_UMA_ANIME_ATTACH,
		_UMA_PLAY_WAIT,
		_OBJ_ANIME_SPEED,
		_OBJ_SCALE,
		_BADGE_GET,
		_ADD_UG_ITEM,
		_TOBARI_4F_SHOP_OPEN,
		_DOF_FAR_DEPTH,
		_DISPLAY_MESSAGE,
		_DISPLAY_MESSAGE_CLOSE,
		_CUSTOM_BALL_TRAINER_PAGE,
		_CUSTOM_BALL_TRAINER_COPY_OPEN,
		_RECONGNIZE_TOKIKAKE,
		_RECONGNIZE_OPEN_WAIT,
		_UG_ITEM_NAME,
		_FUREAI_TALK_START,
		_FUREAI_TALK_END,
		_PLAY_FUREAI_VOICE_NAKAYOSHIRANK,
		_CREATE_HYOUTA,
		_CALL_SHIP_DEMO_SEA_MAP,
		_SETUP_SHIP,
		_PC_DENDOU_SET_PROC_OPEN_WAIT,
		_GET_POKETCH_APP_ID,
		_FADE_DUNGEON_OUT,
		_FADE_DUNGEON_IN,
		_FADE_BUILDING_OUT,
		_FADE_BUILDING_IN,
		_FADE_AREA_OUT,
		_FADE_AREA_IN,
		_CUSTOM_BALL_TRAINER_PAGE_WAIT,
		_C08R0801SCOPECAMERA_SEQUENCE,
		_EMBANKMENT,
		_ENTRY_UWASA_ZUKAN,
		_TALK_UG_NPC,
		_TRAINING_OPEN,
		_TRAINING_OPEN_WAIT,
		_CAMERA_CONTROLLER_IS_NULL,
		_UMA_IS_NULL,
		_GET_IS_HAVE_SECRETBASE,
		_GET_UG_NPC_TALK_COUNT,
		_RESET_UG_NPC_TALK_COUNT,
		_TEMOTI_POKE_CHK_GET_POS,
		AC_STOP_WALK_ANIME,
		_SET_FORCE_BLINK,
		_CHECK_SECRET_BASE_EXPANTION,
		_TV_TOPIC_BRANCH_GET,
		_TV_TOPIC_INT_GET,
		_TV_TOPIC_STR_WORD_SET,
		_OOKISA_VALUE_SET_BUF,
		_SET_LIGHTINTENSITY,
		_SET_LIGHTINTENSITY_CHARCTER,
		_SET_LIGHTINTENSITY_POKE,
		_END_LIGHTINTENSITY,
		_END_LIGHTINTENSITY_CHARCTER,
		_END_LIGHTINTENSITY_POKE,
		AC_ANIME_DURATION,
		_TV_RED_GYARADOS_ON,
		_TV_RED_GYARADOS_OFF,
		_PARTNER_NAME_SET,
		_TV_MONITOR_SET,
		_TV_MONITOR_RESET,
		_EFF_SCALE,
		_GET_ITEM_COUNT,
		_PLAY_EMO_SE,
		_AUTO_MSG,
		_AUTO_MSG_STOP,
		_GET_TAG_PATNER_ID,
		_ADD_WAZA,
		_NICKNAME_PLACEMENT,
		_UNIQUE_POKE_TEMP,
		_UNIQUE_POKE_FIX,
		_GET_FORM,
		_NICK_NAME_ALL,
		_DOF_CHANGE_TARGET_POS,
		_DOF_RESET_TARGET_POS,
		_ADD_MAROYAKA_POFFIN,
		_ALL_MONSNO,
		_ALL_MONS_OWN_CHK,
		_CON_CATEGORY_NAME,
		_CON_RANK_NAME,
		_POKE_TYPE_NAME,
		_POFFIN_NAME,
		_DRESS_NAME,
		_EVENT_ENTITY_VISIBLE,
		_UG_LEAVE_HOYUTA,
		_AZUKARIYA_STORE_UI,
		_SET_TELEPORT_ID,
		_POKE_LVUP_HOW_MANY,
		_USE_SPECIAL_ITEM,
		_GET_BP,
		_FOV_OFFSET_RATE,
		_OBJ_DIR_CHANGE_WORLD,
		_OBJ_POS_CHANGE_WORLD_FIND,
		_ZONE_NAME2,
		_TALK_COLISEUM_NPC,
		_USE_SUB_ATTRIBUTE,
		_ADD_CUSTUM_WIN_LABEL_TWO_WINDOW,
		_POKE_LEVEL_GET_ALL,
		_RESET_SAVEBGM,
		_BTWR_SUB_SELECT_POKE,
		_BTWR_SUB_GET_ENTRY_POKE,
		_SET_GLOBALWATERFIELD,
		_TV_INTERVIEW_STR_WORD_SET,
		_ZONE_NAME_LABEL,
		_AUTO_SAVE_BACK_UP_ON,
		_GET_STATUE_NUM,
		_BTWR_PLAYER_WIN_CHECK,
		_GET_GOLD,
		_AG_TRANSITION_HOYUTA,
		_ADD_POKEMON_UI,
		_GET_FUREAI_SELECT_POKE_TEMOTI_NO,
		_TV_TOPIC_STR_GENDER_WORD_SET,
		_EVENT_ENTITY_CLIP_ATTACH_PLAYER,
		_GET_POKE_COUNT5,
		_ADD_UNIQUE_POKEMON_UI,
		_BTWR_SUB_ADD_BATTLE_POINT_MANUAL,
		_POKE_TARENT_POW_MAX,
		_OPEN_BATTLE_WIN,
		_OJIGI,
		_DARKNESS_TEMPORARILY_OFF,
		_DARKNESS_TEMPORARILY_ON,
		_SAVE_PLAYREPORT,
		_SET_STOP_EYE_ENCOUNT,
		_RESET_STOP_EYE_ENCOUNT,
		_OPEN_CUSTUM_WIN_FIXED,
		_PLAY_REPORT_TRAINING,
		_PLAY_REPORT_BTLTOWER_WIN,
		CMD_NAME_END
	}
}
