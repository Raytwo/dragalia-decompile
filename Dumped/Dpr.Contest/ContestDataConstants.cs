namespace Dpr.Contest;

public static class ContestDataConstants
{
	public const int MAX_CON_PHOTO_DATA_NUM = 5;

	public const int MAX_PHOTO_FX_DATA_NUM = 5;

	public const string OPENING_PREFAB_NAME = "Opening";

	public const string VISUAL_PREFAB_NAME = "Visual";

	public const string DANCE_PREFAB_NAME = "Dance";

	public const string RESULT_PREFAB_NAME = "Result";

	public const string OBJECT_MANAGER_PREFAB_NAME = "ObjectManager";

	public const string PREFAB_AB_NAME = "prefabs/contest_scene_prefabs";

	public const string SPRITE_ATLAS_AB_NAME = "textures/contest_scene_sprite_atlas";

	public const string MASTERDATA_AB_NAME = "md/contest_masterdatas";

	public const string SETTINGDATA_AB_NAME = "scriptableobjects/contest_settings";

	public const string SEQUENCE_FILE_PATH = "sequence/{0}";

	public const string WAZA_SEQUENCE_FILE_PATH = "waza_sequence/cw{0:D3}";

	public const string UNIQUE_WAZA_SEQUENCE_FILE_PATH = "waza_sequence/cw{0:D3}_only";

	public const string NOTES_DATA_FILE_PATH = "music/{0}";

	public const string PLAYER_MODEL_PATH = "persons/battle/pc00{0:D2}_{1:D2}";

	public const string BALL_MODEL_PATH = "objects/ob02{0:D2}_00";

	public static readonly ushort[] CONTEST_DRESS_ID_ARRAY;

	public const string MEDAL_TEX_PATH = "textures/rank/{0}";

	public const string WAZA_TYPE_TEX_FILE_NAME = "cnt_waza_type_{0:D2}";

	public const string CONT_TITLE_TEX_NAME = "cnt_title_logo";

	public const string TAP_GRADE_BRILLIANT_TEX_NAME = "cnt_grade_txt_01_brilliant";

	public const string TAP_GRADE_SHINING_TEX_NAME = "cnt_grade_txt_02_shining";

	public const string TAP_GRADE_GREAT_TEX_NAME = "cnt_grade_txt_03_great";

	public const string TAP_GRADE_NICE_TEX_NAME = "cnt_grade_txt_04_nice";

	public const string TAP_GRADE_FAST_TEX_NAME = "cnt_grade_txt_05_fast";

	public const string TAP_GRADE_SLOW_TEX_NAME = "cnt_grade_txt_06_slow";

	public const string CHAIN_COUNT_TEX_NAME = "cnt_combo_number_{0:D2}";

	public const string RESULT_SUCCESS_TITLE_TEX_NAME = "cnt_result_live_clear_title_00";

	public const string RESULT_FAILED_TITLE_TEX_NAME = "cnt_result_live_clear_title_01";

	public const string CONTEST_MSBT_FILE_NAME = "dp_contest";

	public const int MAX_PARTICIPANT_NUM = 4;

	public const int MOTION_NO_ON_GO_CONTEST = 4;

	public const float CREATE_TIME_RANGE = 5f;

	public const int INIT_CREATE_NOTE_POOL_NUM = 15;

	public const int INIT_CREATE_NOTE_BG_NUM = 5;

	public const int MAX_HEART_GAUGE_VALUE = 100;

	public const float RECEPTION_COMBO_DURATION = 6f;

	public const float POSITION_OFFSET_ON_LAUNCH_WAZA = 100f;

	public const int ADD_SCORE_ON_GAUGEMAX = 1;

	public static readonly int[] SKILL_APPEAL_POINT_ARRAY;

	public const int PHOTO_PERSENT = 1000;

	public const uint MAX_REC_ENTRY_CNT = 9999u;

	public const uint MAX_REC_WIN_CNT = 9999u;

	public const uint MAX_REC_GET_RIBBON_NUM = 65536u;

	public const int CONTEST_RANKING_NUMBER = 1;

	public const int GENERATE_TIMING_GRADE_POOL_COUNT = 4;

	public const int TAP_FX_POOL_COUNT = 6;

	public const int HEART_FX_POOL_COUNT = 20;

	public const int UI_PLAYER_STATUS_FX_POOL_COUNT = 5;

	public const int UI_SAME_TYPE_FX_POOL_COUNT = 4;

	public const int RANK_UP_POOL_COUNT = 2;
}
