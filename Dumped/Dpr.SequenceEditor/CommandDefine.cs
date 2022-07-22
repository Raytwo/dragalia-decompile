namespace Dpr.SequenceEditor;

public class CommandDefine
{
	public const int SEQ_DEF_POS_ATK = 0;

	public const int SEQ_DEF_POS_DEF = 1;

	public const int SEQ_DEF_POS_DEFTRG = 2;

	public const int SEQ_DEF_POS_NEAR1 = 3;

	public const int SEQ_DEF_POS_FAR1 = 4;

	public const int SEQ_DEF_POS_NEAR2 = 5;

	public const int SEQ_DEF_POS_FAR2 = 6;

	public const int SEQ_DEF_POS_NEAR3 = 7;

	public const int SEQ_DEF_POS_FAR3 = 8;

	public const int SEQ_DEF_POS_NEAR4 = 9;

	public const int SEQ_DEF_POS_GROUP = 0;

	public const int SEQ_DEF_SPPOS_SELF_FIELD = 0;

	public const int SEQ_DEF_SPPOS_ENEMY_FIELD = 1;

	public const int SEQ_DEF_SPPOS_ENEMY_CENTER = 2;

	public const int SEQ_DEF_SPPOS_GROUP = 0;

	public const int SEQ_DEF_NODE_ORIGIN = 0;

	public const int SEQ_DEF_NODE_BUTURI = 1;

	public const int SEQ_DEF_NODE_SHOOT = 2;

	public const int SEQ_DEF_NODE_WAIST = 3;

	public const int SEQ_DEF_NODE_HEAD = 4;

	public const int SEQ_DEF_NODE_FRONT = 5;

	public const int SEQ_DEF_NODE_FACE = 6;

	public const int SEQ_DEF_NODE_EYE = 7;

	public const int SEQ_DEF_NODE_MOUTH = 8;

	public const int SEQ_DEF_NODE_HORN = 9;

	public const int SEQ_DEF_NODE_TAIL = 10;

	public const int SEQ_DEF_NODE_HAND1 = 11;

	public const int SEQ_DEF_NODE_HAND2 = 12;

	public const int SEQ_DEF_NODE_FOOT1 = 13;

	public const int SEQ_DEF_NODE_FOOT2 = 14;

	public const int SEQ_DEF_NODE_CENTER = 15;

	public const int SEQ_DEF_NODE_BASE = 16;

	public const int SEQ_DEF_NODE_FRONT_AABB = 30;

	public const int SEQ_DEF_NODE_AABB_FRONT = 31;

	public const int SEQ_DEF_NODE_AABB_CENTER = 32;

	public const int SEQ_DEF_NODE_AABB_BOTTOM = 33;

	public const int SEQ_DEF_NODE_AABB_F_UNDER = 34;

	public const int SEQ_DEF_NODE_ORI_ORIGIN = 35;

	public const int SEQ_DEF_NODE_INTRO = 50;

	public const int SEQ_DEF_NODE_GROUP = 0;

	public const int MOTION_WAIT = 0;

	public const int MOTION_APPEAL = 7;

	public const int MOTION_DAMAGE = 16;

	public const int MOTION_DOWN = 17;

	public const int MOTION_LAND = 6;

	public const int MOTION_ATK_BUTSURI1 = 8;

	public const int MOTION_ATK_BUTSURI2 = 9;

	public const int MOTION_ATK_BUTSURI3 = 10;

	public const int MOTION_ATK_BUTSURI4 = 11;

	public const int MOTION_ATK_TOKUSHU1 = 12;

	public const int MOTION_ATK_TOKUSHU2 = 13;

	public const int MOTION_ATK_TOKUSHU3 = 14;

	public const int MOTION_ATK_TOKUSHU4 = 15;

	public const int MOTION_ATK_WAIT_B = 1;

	public const int MOTION_ATK_WAIT_C = 2;

	public const int POKE_MOTION_ATK_BUTSURI = 30;

	public const int POKE_MOTION_ATK_TOKUSHU = 31;

	public const int POKE_MOTION_ATK_BODYBLOW = 32;

	public const int POKE_MOTION_ATK_PUNCH = 33;

	public const int POKE_MOTION_ATK_KICK = 34;

	public const int POKE_MOTION_ATK_TAIL = 35;

	public const int POKE_MOTION_ATK_BITE = 36;

	public const int POKE_MOTION_ATK_PECK = 37;

	public const int POKE_MOTION_ATK_RADIAL = 38;

	public const int POKE_MOTION_ATK_CRY = 39;

	public const int POKE_MOTION_ATK_DUST = 40;

	public const int POKE_MOTION_ATK_SHOOT = 41;

	public const int POKE_MOTION_ATK_GUARD = 42;

	public const int SEQ_DEF_MOTION_GROUP = 0;

	public const int SEQ_DEF_ATK_MOT_GROUP = 0;

	public const int POKE_EYE_OPEN = 0;

	public const int POKE_EYE_HALF = 1;

	public const int POKE_EYE_CLOSE = 2;

	public const int POKE_EYE_CLOSE2 = 3;

	public const int POKE_EYE_ANGRY = 4;

	public const int POKE_EYE_SMILE = 5;

	public const int POKE_EYE_SAD = 6;

	public const int POKE_EYE_OTHER = 7;

	public const int POKE_EYE_RESET = 31;

	public const int SEQ_DEF_POKE_EYE_GROUP = 0;

	public const int SEQ_DEF_MOVETYPE_LINER = 0;

	public const int SEQ_DEF_MOVETYPE_FAST = 8;

	public const int SEQ_DEF_MOVETYPE_SLOW = 7;

	public const int SEQ_DEF_MOVETYPE_SIN = 9;

	public const int SEQ_DEF_MOVETYPE_LINE = 0;

	public const int SEQ_DEF_MOVETYPE_EASEINSINE = 1;

	public const int SEQ_DEF_MOVETYPE_EASEOUTSINE = 2;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTSINE = 3;

	public const int SEQ_DEF_MOVETYPE_EASEINQUAD = 4;

	public const int SEQ_DEF_MOVETYPE_EASEOUTQUAD = 5;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTQUAD = 6;

	public const int SEQ_DEF_MOVETYPE_EASEINCUBIC = 7;

	public const int SEQ_DEF_MOVETYPE_EASEOUTCUBIC = 8;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTCUBIC = 9;

	public const int SEQ_DEF_MOVETYPE_EASEINQUART = 10;

	public const int SEQ_DEF_MOVETYPE_EASEOUTQUART = 11;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTQUART = 12;

	public const int SEQ_DEF_MOVETYPE_EASEINQUINT = 13;

	public const int SEQ_DEF_MOVETYPE_EASEOUTQUINT = 14;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTQUINT = 15;

	public const int SEQ_DEF_MOVETYPE_EASEINEXPO = 16;

	public const int SEQ_DEF_MOVETYPE_EASEOUTEXPO = 17;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTEXPO = 18;

	public const int SEQ_DEF_MOVETYPE_EASEINCIRC = 19;

	public const int SEQ_DEF_MOVETYPE_EASEOUTCIRC = 20;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTCIRC = 21;

	public const int SEQ_DEF_MOVETYPE_EASEINBACK = 22;

	public const int SEQ_DEF_MOVETYPE_EASEOUTBACK = 23;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTBACK = 24;

	public const int SEQ_DEF_MOVETYPE_EASEINELASTIC = 25;

	public const int SEQ_DEF_MOVETYPE_EASEOUTELASTIC = 26;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTELASTIC = 27;

	public const int SEQ_DEF_MOVETYPE_EASEINBOUNCE = 28;

	public const int SEQ_DEF_MOVETYPE_EASEOUTBOUNCE = 29;

	public const int SEQ_DEF_MOVETYPE_EASEINOUTBOUNCE = 30;

	public const int SEQ_DEF_MOVETYPE_GROUP = 0;

	public const int SEQ_DEF_MODETYPE_UNIFORM = 0;

	public const int SEQ_DEF_MODETYPE_ADAPTIVE = 1;

	public const int SEQ_DEF_MODETYPE_GROUP = 0;

	public const int SEQ_DEF_DRAWTYPE_NORMAL = 0;

	public const int SEQ_DEF_DRAWTYPE_NO_EDGE = 1;

	public const int SEQ_DEF_DRAWTYPE_SCREEN = 2;

	public const int SEQ_DEF_DRAWTYPE_BEFORE = 3;

	public const int SEQ_DEF_DRAWTYPE_NORMAL_AFTER = 4;

	public const int SEQ_DEF_DRAWTYPE_POST_OUTLINE = 5;

	public const int SEQ_DEF_DRAWTYPE_POST_FOG = 6;

	public const int SEQ_DEF_DRAWTYPE_BALL = 7;

	public const int SEQ_DEF_DRAWTYPE_BG_EFF = 8;

	public const int SEQ_DEF_DRAWTYPE_GROUP = 0;

	public const int SEQ_DEF_ROTATE_ORDER_DEF = 6;

	public const int SEQ_DEF_ROTATE_ORDER_XYZ = 0;

	public const int SEQ_DEF_ROTATE_ORDER_XZY = 1;

	public const int SEQ_DEF_ROTATE_ORDER_YXZ = 2;

	public const int SEQ_DEF_ROTATE_ORDER_YZX = 3;

	public const int SEQ_DEF_ROTATE_ORDER_ZXY = 4;

	public const int SEQ_DEF_ROTATE_ORDER_ZYX = 5;

	public const int SEQ_DEF_ROTATE_ORDER_GROUP = 0;

	public const int SEQ_DEF_EFF_DRAWTYPE_NORAML = 0;

	public const int SEQ_DEF_EFF_DRAWTYPE_SCREEN = 1;

	public const int SEQ_DEF_EFF_DRAWTYPE_BEFORE = 2;

	public const int SEQ_DEF_EFF_DRAWTYPE_LOW = 3;

	public const int SEQ_DEF_EFF_DRAWTYPE_HIGHT = 4;

	public const int SEQ_DEF_EFF_DRAWTYPE_GROUP = 0;

	public const int SEQ_DEF_FADE_UPPER = 0;

	public const int SEQ_DEF_FADE_LOWER = 1;

	public const int SEQ_DEF_FADE_BOTH = 2;

	public const int SEQ_DEF_FADE_WHITE = 0;

	public const int SEQ_DEF_FADE_BLACK = 1;

	public const int SEQ_DEF_AXIS_X = 0;

	public const int SEQ_DEF_AXIS_Y = 1;

	public const int SEQ_DEF_AXIS_Z = 2;

	public const int SEQ_DEF_AXIS_X_ROT = 3;

	public const int SEQ_DEF_AXIS_Z_ROT = 4;

	public const int SEQ_DEF_AXIS_GROUP = 0;

	public const int SEQ_DEF_TRAINER_SELF1 = 0;

	public const int SEQ_DEF_TRAINER_ENEMY1 = 1;

	public const int SEQ_DEF_TRAINER_SELF2 = 2;

	public const int SEQ_DEF_TRAINER_ENEMY2 = 3;

	public const int SEQ_DEF_TRAINER_SELF3 = 4;

	public const int SEQ_DEF_TRAINER_ENEMY3 = 5;

	public const int SEQ_DEF_TRAINER_SELF4 = 6;

	public const int SEQ_DEF_TRAINER_SEQ_TARGET1 = 7;

	public const int SEQ_DEF_TRAINER_SEQ_TARGET2 = 8;

	public const int SEQ_DEF_TRAINER_ATK = 9;

	public const int SEQ_DEF_TRAINER_DEF = 10;

	public const int SEQ_DEF_TRAINER_DEFTRG = 11;

	public const int SEQ_DEF_TRAINER_FIELD_ORIGIN = 12;

	public const int SEQ_DEF_TRAINER_GROUP = 0;

	public const int SEQ_DEF_TRAINER_GROUP_ADD = 0;

	public const int SEQ_DEF_TR_MOTION_IN = 0;

	public const int SEQ_DEF_TR_MOTION_BALL = 1;

	public const int SEQ_DEF_TR_MOTION_ORDER = 2;

	public const int SEQ_DEF_TR_MOTION_LOSE = 3;

	public const int SEQ_DEF_TR_MOTION_WAIT1 = 4;

	public const int SEQ_DEF_TR_MOTION_WAIT2 = 5;

	public const int SEQ_DEF_TR_MOTION_IN2 = 6;

	public const int SEQ_DEF_TR_MOTION_BALL2 = 7;

	public const int SEQ_DEF_TR_MOTION_LOSE2 = 8;

	public const int SEQ_DEF_TR_MOTION_BALL3 = 9;

	public const int SEQ_DEF_TR_MOTION_BALL_M = 10;

	public const int SEQ_DEF_TR_MOTION_IN3 = 11;

	public const int SEQ_DEF_TR_MOTION_BALL3_2 = 12;

	public const int SEQ_DEF_TR_MOTION_LOSE3 = 13;

	public const int SEQ_DEF_TR_MOTION_ZWAZA = 14;

	public const int SEQ_DEF_TR_MOTION_MULTI_0 = 15;

	public const int SEQ_DEF_TR_MOTION_IN4 = 16;

	public const int SEQ_DEF_TR_MOTION_BALL4 = 17;

	public const int SEQ_DEF_TR_MOTION_LOSE4 = 18;

	public const int SEQ_DEF_TR_MOTION_POSE = 99;

	public const int SEQ_DEF_TR_MOTION_BALL_M0 = 98;

	public const int SEQ_DEF_TR_MOTION_GROUP = 0;

	public const int SEQ_DEF_TR_TEX_MAIN = 0;

	public const int SEQ_DEF_TR_TEX_SHADOW = 1;

	public const int SEQ_DEF_TR_TEX_SUB = 2;

	public const int SEQ_DEF_TR_TEX_GROUP = 0;

	public const int SEQ_DEF_TR_ENV_TOUJYO = 0;

	public const int SEQ_DEF_TR_ENV_LOSE = 1;

	public const int SEQ_DEF_TR_ENV_GROUP = 0;

	public const int SEQ_DEF_TR_CAM_FILE = 0;

	public const int SEQ_DEF_TR_CAM_INTRO = 1;

	public const int SEQ_DEF_TR_CAM_THROW = 2;

	public const int SEQ_DEF_TR_CAM_LOSE = 3;

	public const int SEQ_DEF_TR_CAM_GTHROW_START = 4;

	public const int SEQ_DEF_TR_CAM_GTHROW_LOOP = 5;

	public const int SEQ_DEF_TR_CAM_GTHROW_END = 6;

	public const int SEQ_DEF_TR_CAM_INTRO_THROW = 7;

	public const int SEQ_DEF_TR_CAM_GROUP = 0;

	public const int SEQ_DEF_FOLLOW_PARTICLE = 0;

	public const int SEQ_DEF_FOLLOW_MODEL = 1;

	public const int SEQ_DEF_FOLLOW_GROUP = 0;

	public const int SEQ_DEF_SEPAN_NONE = 0;

	public const int SEQ_DEF_SEPAN_ATK = 1;

	public const int SEQ_DEF_SEPAN_DEF = 2;

	public const int SEQ_DEF_SEPAN_GROUP = 0;

	public const int CLUSTER_SPAWN_POINT = 0;

	public const int CLUSTER_SPAWN_SPHERE = 1;

	public const int CLUSTER_SPAWN_CYLINDER1 = 2;

	public const int CLUSTER_SPAWN_CYLINDER2 = 3;

	public const int CLUSTER_SPAWN_BOX = 4;

	public const int CLUSTER_SPAWN_GROUP = 0;

	public const int CLUSTER_ORIGIN = 0;

	public const int CLUSTER_AXIS_X = 1;

	public const int CLUSTER_AXIS_Y = 2;

	public const int CLUSTER_AXIS_Z = 3;

	public const int CLUSTER_PLANE_X = 4;

	public const int CLUSTER_PLANE_Y = 5;

	public const int CLUSTER_PLANE_Z = 6;

	public const int CLUSTER_POS_GROUP = 0;

	public const int CLUSTER_POS_GROUP_AXIS = 0;

	public const int CLUSTER_POS_GROUP_PLANE = 0;

	public const int CLUSTER_REFRECT_NONE = 0;

	public const int CLUSTER_REFRECT_NORMAL = 1;

	public const int CLUSTER_REFRECT_STOP = 2;

	public const int CLUSTER_REFRECT_DEATH = 3;

	public const int CLUSTER_REFRECT_GROUP = 0;

	public const int CLUSTER_CHILD_NONE = 0;

	public const int CLUSTER_CHILD_TIME = 1;

	public const int CLUSTER_CHILD_REFRECT = 2;

	public const int CLUSTER_CHILD_DEATH = 3;

	public const int CLUSTER_CHILD_GROUP = 0;

	public const int SEQ_DEF_WAIT_KEY = 0;

	public const int SEQ_DEF_WAIT_MESSAGE = 1;

	public const int SEQ_DEF_WAIT_LOAD = 2;

	public const int SEQ_DEF_WAIT_LOAD_POKE = 3;

	public const int SEQ_DEF_WAIT_LOAD_BG = 4;

	public const int SEQ_DEF_WAIT_POKE_INTRO = 5;

	public const int SEQ_DEF_WAIT_SELECT_MESSAGE = 6;

	public const int SEQ_DEF_WAIT_FADE = 10;

	public const int SEQ_DEF_WAIT_DEMOFADE_SYNC = 11;

	public const int SEQ_DEF_WAIT_UI_BAG = 12;

	public const int SEQ_DEF_WAIT_UI_TRAINER_NAME = 13;

	public const int SEQ_DEF_WAIT_UI_FOG = 14;

	public const int SEQ_DEF_WAIT_GROUP = 0;

	public const int SEQ_DEF_WEATHER_NONE = 0;

	public const int SEQ_DEF_WEATHER_SHINE = 1;

	public const int SEQ_DEF_WEATHER_RAIN = 2;

	public const int SEQ_DEF_WEATHER_SNOW = 3;

	public const int SEQ_DEF_WEATHER_SAND = 4;

	public const int SEQ_DEF_WEATHER_STORM = 5;

	public const int SEQ_DEF_WEATHER_DAY = 6;

	public const int SEQ_DEF_WEATHER_TURBULENCE = 7;

	public const int SEQ_DEF_WEATHER_GROUP = 0;

	public const int SEQ_DEF_FWAZA_TYPE_NONE = 0;

	public const int SEQ_DEF_FWAZA_TYPE_GRASS = 1;

	public const int SEQ_DEF_FWAZA_TYPE_MIST = 2;

	public const int SEQ_DEF_FWAZA_TYPE_ELEC = 3;

	public const int SEQ_DEF_FWAZA_TYPE_PHYCO = 4;

	public const int SEQ_DEF_FWAZA_TYPE_FOG01 = 5;

	public const int SEQ_DEF_FWAZA_TYPE_FOG02 = 6;

	public const int SEQ_DEF_FWAZA_TYPE_GROUP = 0;

	public const int ROTOM_EFFECT_WILD = 0;

	public const int ROTOM_EFFECT_LOOP = 1;

	public const int ROTOM_EFFECT_CLOSE = 99;

	public const int ROTOM_EFFECT_GROUP = 0;

	public const int BALL_ANIME_NONE = 0;

	public const int BALL_ANIME_INTRO = 1;

	public const int BALL_ANIME_FALL = 2;

	public const int BALL_ANIME_GROUP = 0;

	public const int LIGHT_TYPE_RESET = 0;

	public const int LIGHT_TYPE_WORLD = 1;

	public const int LIGHT_TYPE_POKE = 2;

	public const int LIGHT_TYPE_GROUP = 0;

	public const int SEQ_DEF_LIGHT_TRG_SIDE_ALL = 0;

	public const int SEQ_DEF_LIGHT_TRG_SIDE_ATK = 1;

	public const int SEQ_DEF_LIGHT_TRG_SIDE_DEF = 2;

	public const int SEQ_DEF_LIGHT_TRG_SIDE_GROUP = 0;

	public const int VOICE_TYPE_NORMAL = 0;

	public const int VOICE_TYPE_DOWN = 1;

	public const int VOICE_TYPE_ATTACK = 2;

	public const int VOICE_TYPE_GROUP = 0;

	public const int FADE_TYPE_NORMAL = 0;

	public const int FADE_TYPE_TRAINER = 1;

	public const int FADE_TYPE_LEGEND = 2;

	public const int FADE_TYPE_GROUP = 0;

	public const int SEQ_STENCIL_TARGET_NONE = 0;

	public const int SEQ_STENCIL_TARGET_POKEMON = 1;

	public const int SEQ_STENCIL_TARGET_TRAINER = 2;

	public const int SEQ_STENCIL_TARGET_EFFECTMODEL = 3;

	public const int SEQ_STENCIL_TARGET_PARTICLE = 4;

	public const int SEQ_STENCIL_TARGET_GROUP = 0;

	public const int GPOKE_EFFECT_ALL = 0;

	public const int GPOKE_EFFECT_CLOUD = 1;

	public const int GPOKE_EFFECT_UNDERLIGHT = 2;

	public const int GPOKE_EFFECT_THUNDER = 4;

	public const int GPOKE_EFFECT_STORM = 8;

	public const int GPOKE_EFFECT_UL_THU = 6;

	public const int SEQ_DEF_GPOKE_EFFECT_GROUP = 0;

	public const int SEQ_DEF_MASK_TEX_PATTERN_1 = 0;

	public const int SEQ_DEF_MASK_TEX_PATTERN_2 = 1;

	public const int SEQ_DEF_MASK_TEX_PATTERN_3 = 2;

	public const int SEQ_DEF_MASK_TEX_PATTERN_4 = 3;

	public const int SEQ_DEF_MASK_TEX_PATTERN_5 = 4;

	public const int SEQ_DEF_MASK_TEX_PATTERN_6 = 5;

	public const int SEQ_DEF_MASK_TEX_PATTERN_7 = 6;

	public const int SEQ_DEF_MASK_TEX_PATTERN_8 = 7;

	public const int SEQ_DEF_MASK_TEX_PATTERN_9 = 8;

	public const int SEQ_DEF_MASK_TEX_PATTERN_10 = 9;

	public const int SEQ_DEF_MASK_TEX_PATTERN_GROUP = 0;

	public const int SEQ_DEF_FOG_MODE_LINEAR = 0;

	public const int SEQ_DEF_FOG_MODE_EXP1 = 1;

	public const int SEQ_DEF_FOG_MODE_EXP2 = 2;

	public const int SEQ_DEF_FOG_MODE_LUT = 3;

	public const int SEQ_DEF_FOG_MODE_GROUP = 0;

	public const int SEQ_DEF_INPUT_UP = 0;

	public const int SEQ_DEF_INPUT_RIGHT = 1;

	public const int SEQ_DEF_INPUT_DOWN = 2;

	public const int SEQ_DEF_INPUT_LEFT = 3;

	public const int SEQ_DEF_INPUT_A = 4;

	public const int SEQ_DEF_INPUT_B = 5;

	public const int SEQ_DEF_INPUT_X = 6;

	public const int SEQ_DEF_INPUT_Y = 7;

	public const int SEQ_DEF_INPUT_DECIDE = 8;

	public const int SEQ_DEF_INPUT_CANCEL = 9;

	public const int SEQ_DEF_INPUT_GROUP = 0;

	public const int SEQ_DEF_WINDOW_NORMAL = 0;

	public const int SEQ_DEF_WINDOW_EMPHASIS = 1;

	public const int SEQ_DEF_WINDOW_CLOUD = 2;

	public const int SEQ_DEF_WINDOW_TYPE_GROUP = 0;

	public const int SEQ_DEF_UI_FOG_LV0 = 0;

	public const int SEQ_DEF_UI_FOG_LV1 = 1;

	public const int SEQ_DEF_UI_FOG_LV2 = 2;

	public const int SEQ_DEF_UI_FOG_GROUP = 0;

	public const int SEQ_DEF_LG_LUM_COLOR = 0;

	public const int SEQ_DEF_LG_LUM_DEPTH = 1;

	public const int SEQ_DEF_LG_LUM_ONE = 2;

	public const int SEQ_DEF_LG_LUM_GROUP = 0;

	public const int SEQ_DEF_LG_SHAPE_DISABLE = 0;

	public const int SEQ_DEF_LG_SHAPE_TYPE_A0 = 1;

	public const int SEQ_DEF_LG_SHAPE_TYPE_A1 = 2;

	public const int SEQ_DEF_LG_SHAPE_TYPE_A2 = 3;

	public const int SEQ_DEF_LG_SHAPE_TYPE_A3 = 4;

	public const int SEQ_DEF_LG_SHAPE_TYPE_B0 = 5;

	public const int SEQ_DEF_LG_SHAPE_TYPE_B1 = 6;

	public const int SEQ_DEF_LG_SHAPE_TYPE_B2 = 7;

	public const int SEQ_DEF_LG_SHAPE_TYPE_B3 = 8;

	public const int SEQ_DEF_LG_SHAPE_TYPE_C0 = 9;

	public const int SEQ_DEF_LG_SHAPE_TYPE_C1 = 10;

	public const int SEQ_DEF_LG_SHAPE_TYPE_C2 = 11;

	public const int SEQ_DEF_LG_SHAPE_TYPE_C3 = 12;

	public const int SEQ_DEF_LG_SHAPE_TYPE_D0 = 13;

	public const int SEQ_DEF_LG_SHAPE_TYPE_D1 = 14;

	public const int SEQ_DEF_LG_SHAPE_TYPE_D2 = 15;

	public const int SEQ_DEF_LG_SHAPE_TYPE_D3 = 16;

	public const int SEQ_DEF_LG_SHAPE_TYPE_E0 = 17;

	public const int SEQ_DEF_LG_SHAPE_TYPE_E1 = 18;

	public const int SEQ_DEF_LG_SHAPE_TYPE_E2 = 19;

	public const int SEQ_DEF_LG_SHAPE_TYPE_E3 = 20;

	public const int SEQ_DEF_LG_SHAPE_GROUP = 0;

	public const int SEQ_DEF_ANIMCONF_BATTLE = 0;

	public const int SEQ_DEF_ANIMCONF_CAMP = 1;

	public const int SEQ_DEF_ANIMCONF_GROUP = 0;

	public const int SEQ_DEF_FIXPARAM_CALC_SET = 0;

	public const int SEQ_DEF_FIXPARAM_CALC_ADD = 1;

	public const int SEQ_DEF_FIXPARAM_CALC_MULT = 2;

	public const int SEQ_DEF_FIXPARAM_CALC_GROUP = 0;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_NONE = 0;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_ATTACK = 1;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_ATTACK2 = 2;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_DEFENSE = 3;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_DEFENSE2 = 4;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_AGILITY = 5;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_AGILITY2 = 6;

	public const int SEQ_DEF_FAIRY_QUIZ_TYPE_GROUP = 0;

	public const int SEQ_DEF_FAIRY_QUIZ_RESULT_NONE = 0;

	public const int SEQ_DEF_FAIRY_QUIZ_RESULT_CORRECT = 1;

	public const int SEQ_DEF_FAIRY_QUIZ_RESULT_INCORRECT = 2;

	public const int SEQ_DEF_FAIRY_QUIZ_RESULT_GROUP = 0;

	public const int SEQ_DEF_RENDERER_TYPE_MAIN = 0;

	public const int SEQ_DEF_RENDERER_TYPE_SUB = 1;

	public const int SEQ_DEF_RENDERER_TYPE_ALL = 2;

	public const int SEQ_DEF_RENDERER_TYPE_GROUP = 0;

	public const int SEQ_DEF_TIME_ZONE_MORNING = 0;

	public const int SEQ_DEF_TIME_ZONE_NOON = 1;

	public const int SEQ_DEF_TIME_ZONE_EVENING = 2;

	public const int SEQ_DEF_TIME_ZONE_NIGHT = 3;

	public const int SEQ_DEF_TIME_ZONE_LATENIGHT = 4;

	public const int SEQ_DEF_TIME_ZONE_NONE = 5;

	public const int SEQ_DEF_TIME_ZONE_GROUP = 0;

	public const int SEQ_DEF_VIGNETTE_TYPE_STANDARD = 0;

	public const int SEQ_DEF_VIGNETTE_TYPE_OPTIMGCIR = 1;

	public const int SEQ_DEF_VIGNETTE_TYPE_GROUP = 0;

	public const int SEQ_DEF_POKE_G_NONE = 0;

	public const int SEQ_DEF_POKE_G_NORMAL = 1;

	public const int SEQ_DEF_POKE_G_SPECIAL = 2;

	public const int SEQ_DEF_POKE_G_GROUP = 0;

	public const int SEQ_DEF_MONS_SEX_MALE = 0;

	public const int SEQ_DEF_MONS_SEX_FEMALE = 1;

	public const int SEQ_DEF_MONS_SEX_UNKNOWN = 2;

	public const int SEQ_DEF_MONS_SEX_GROUP = 0;

	public const int SEQ_DEF_PLACE_DEFAULT = 0;

	public const int SEQ_DEF_PLACE_INTRO = 1;

	public const int SEQ_DEF_PATHTYPE_LINE = 0;

	public const int SEQ_DEF_PATHTYPE_BEZIER = 1;

	public const int SEQ_DEF_NODE_MODEL_ORIGIN = 0;

	public const int SEQ_DEF_NODE_MODEL_WAIST = 1;

	public const int SEQ_DEF_NODE_MODEL_SPINE1 = 2;

	public const int SEQ_DEF_NODE_MODEL_SPINE2 = 3;

	public const int SEQ_DEF_NODE_MODEL_RTOEC1 = 4;

	public const int SEQ_DEF_NODE_MODEL_HEAD = 5;

	public const int SEQ_DEF_NODE_MODEL_LFINGER = 6;

	public const int SEQ_DEF_NODE_MODEL_JAW = 7;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK01_01 = 8;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK01_02 = 9;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK01_03 = 10;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK01_04 = 11;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK02_01 = 12;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK02_02 = 13;

	public const int SEQ_DEF_NODE_MODEL_EFFATTACK03_01 = 14;

	public const int SEQ_DEF_NODE_MODEL_EFFCENTER01 = 15;

	public const int SEQ_DEF_NODE_MODEL_EFFCENTER02 = 16;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE01 = 17;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE02 = 18;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE03 = 19;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE04 = 20;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE05 = 21;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE06 = 22;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE07 = 23;

	public const int SEQ_DEF_NODE_MODEL_EFFEYE08 = 24;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT01 = 25;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT02 = 26;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT03 = 27;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT04 = 28;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT05 = 29;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT06 = 30;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT07 = 31;

	public const int SEQ_DEF_NODE_MODEL_EFFFOOT08 = 32;

	public const int SEQ_DEF_NODE_MODEL_EFFFRONT01 = 33;

	public const int SEQ_DEF_NODE_MODEL_EFFGCLOUD01 = 34;

	public const int SEQ_DEF_NODE_MODEL_EFFHAND01 = 35;

	public const int SEQ_DEF_NODE_MODEL_EFFHAND02 = 36;

	public const int SEQ_DEF_NODE_MODEL_EFFHAND03 = 37;

	public const int SEQ_DEF_NODE_MODEL_EFFHAND04 = 38;

	public const int SEQ_DEF_NODE_MODEL_EFFHAND05 = 39;

	public const int SEQ_DEF_NODE_MODEL_EFFHAND06 = 40;

	public const int SEQ_DEF_NODE_MODEL_EFFHEADCENTER01 = 41;

	public const int SEQ_DEF_NODE_MODEL_EFFHEADCENTER02 = 42;

	public const int SEQ_DEF_NODE_MODEL_EFFHEADCENTER03 = 43;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN01 = 44;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN02 = 45;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN03 = 46;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN04 = 47;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN05 = 48;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN06 = 49;

	public const int SEQ_DEF_NODE_MODEL_EFFHORN07 = 50;

	public const int SEQ_DEF_NODE_MODEL_EFFMOUTH01 = 51;

	public const int SEQ_DEF_NODE_MODEL_EFFMOUTH02 = 52;

	public const int SEQ_DEF_NODE_MODEL_EFFMOUTH03 = 53;

	public const int SEQ_DEF_NODE_MODEL_EFFMOUTH04 = 54;

	public const int SEQ_DEF_NODE_MODEL_EFFMOUTH05 = 55;

	public const int SEQ_DEF_NODE_MODEL_EFFMOUTH06 = 56;

	public const int SEQ_DEF_NODE_MODEL_EFFOVERHEAD01 = 57;

	public const int SEQ_DEF_NODE_MODEL_EFFSHOOT01_01 = 58;

	public const int SEQ_DEF_NODE_MODEL_EFFSHOOT02_01 = 59;

	public const int SEQ_DEF_NODE_MODEL_EFFSHOOT03_01 = 60;

	public const int SEQ_DEF_NODE_MODEL_EFFTAIL01 = 61;

	public const int SEQ_DEF_NODE_MODEL_EFFTAIL02 = 62;

	public const int SEQ_DEF_NODE_MODEL_EFFTAIL03 = 63;

	public const int SEQ_DEF_NODE_MODEL_EFFTAIL04 = 64;

	public const int SEQ_DEF_NODE_MODEL_EFFTAIL05 = 65;

	public const int SEQ_DEF_NODE_MODEL_EFFTAIL06 = 66;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE01 = 67;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE02 = 68;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE03 = 69;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE04 = 70;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE05 = 71;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE06 = 72;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE07 = 73;

	public const int SEQ_DEF_NODE_MODEL_EFFWIDEUSE08 = 74;

	public const int SEQ_DEF_NODE_MODEL_LITEM1 = 75;

	public const int SEQ_DEF_NODE_MODEL_LITEM2 = 76;

	public const int SEQ_DEF_NODE_MODEL_RITEM1 = 77;

	public const int SEQ_DEF_NODE_MODEL_RITEM2 = 78;

	public const int SEQ_DEF_TRAINER_MOTION_ADVENT02_B = 0;

	public const int SEQ_DEF_TRAINER_MOTION_ADVENT_B = 1;

	public const int SEQ_DEF_TRAINER_MOTION_WAIT_B = 2;

	public const int SEQ_DEF_TRAINER_MOTION_WAIT02_B = 3;

	public const int SEQ_DEF_TRAINER_MOTION_ORDER_B = 4;

	public const int SEQ_DEF_TRAINER_MOTION_LOSE01_B = 5;

	public const int SEQ_DEF_TRAINER_MOTION_SPEAK01_B = 6;

	public const int SEQ_DEF_TRAINER_MOTION_WIN01_B = 7;

	public const int SEQ_DEF_TRAINER_MOTION_SPEAK02_B = 8;

	public const int SEQ_DEF_TRAINER_MOTION_WALK_B = 9;

	public const int SEQ_DEF_TRAINER_MOTION_RUN_B = 10;

	public const int SEQ_DEF_TRAINER_MOTION_ADVENT03_B = 11;

	public const int SEQ_DEF_POKE_MOTION_WAITA01 = 0;

	public const int SEQ_DEF_POKE_MOTION_WAITB01 = 1;

	public const int SEQ_DEF_POKE_MOTION_LANDA01 = 2;

	public const int SEQ_DEF_POKE_MOTION_LANDB01 = 3;

	public const int SEQ_DEF_POKE_MOTION_LANDC01 = 4;

	public const int SEQ_DEF_POKE_MOTION_BUTURI01 = 5;

	public const int SEQ_DEF_POKE_MOTION_BUTURI02 = 6;

	public const int SEQ_DEF_POKE_MOTION_BUTURI03 = 7;

	public const int SEQ_DEF_POKE_MOTION_TOKUSYU01 = 8;

	public const int SEQ_DEF_POKE_MOTION_TOKUSYU02 = 9;

	public const int SEQ_DEF_POKE_MOTION_TOKUSYU03 = 10;

	public const int SEQ_DEF_POKE_MOTION_BODYBLOW = 11;

	public const int SEQ_DEF_POKE_MOTION_PUNCH = 12;

	public const int SEQ_DEF_POKE_MOTION_KICK = 13;

	public const int SEQ_DEF_POKE_MOTION_TAIL = 14;

	public const int SEQ_DEF_POKE_MOTION_BITE = 15;

	public const int SEQ_DEF_POKE_MOTION_PECK = 16;

	public const int SEQ_DEF_POKE_MOTION_RADIAL = 17;

	public const int SEQ_DEF_POKE_MOTION_CRY = 18;

	public const int SEQ_DEF_POKE_MOTION_DUST = 19;

	public const int SEQ_DEF_POKE_MOTION_SHOT = 20;

	public const int SEQ_DEF_POKE_MOTION_GUARD = 21;

	public const int SEQ_DEF_POKE_MOTION_TURNNORMAL = 22;

	public const int SEQ_DEF_POKE_MOTION_TURNSMILE = 23;

	public const int SEQ_DEF_POKE_MOTION_DAMAGE = 24;

	public const int SEQ_DEF_POKE_MOTION_DOWN = 25;

	public const int SEQ_DEF_POKE_MOTION_ROAR01 = 26;

	public const int SEQ_DEF_TRAINER_MOTION_THROW_BALL_ADVENT = 0;

	public const int SEQ_DEF_TRAINER_MOTION_THROW_BALL_CAPTURE = 1;

	public const int SEQ_DEF_TRAINER_MOTION_THROW_BALL_GROUP = 0;

	public const int GRP_OPT_NONE = 0;

	public const int GRP_OPT_SINGLE = 1;

	public const int GRP_OPT_DOUBLE = 2;

	public const int GRP_OPT_ROYAL = 3;

	public const int GRP_OPT_NOT_SINGLE = 4;

	public const int GRP_OPT_NOT_WILD_SINGLE = 5;

	public const int GRP_OPT_RAID = 6;

	public const int GRP_OPT_NOT_RAID = 7;

	public const int GRP_OPT_RULE_GROUP = 0;

	public const int GRP_OPT_ATK_NEAR = 1;

	public const int GRP_OPT_ATK_FAR = 2;

	public const int GRP_OPT_DEF_NEAR = 3;

	public const int GRP_OPT_DEF_FAR = 4;

	public const int GRP_OPT_POS_GROUP = 0;

	public const int GRP_OPT_ATK_R_NEAR = 1;

	public const int GRP_OPT_ATK_R_RIGHT = 2;

	public const int GRP_OPT_ATK_R_FAR = 3;

	public const int GRP_OPT_ATK_R_LEFT = 4;

	public const int GRP_OPT_POS_R_GROUP = 0;

	public const int GRP_OPT_NOT_COMM = 40;

	public const int GRP_OPT_COMM = 41;

	public const int GRP_OPT_COMM_GROUP = 0;

	public const int GRP_OPT_TIME_DAY = 50;

	public const int GRP_OPT_TIME_EVENING = 51;

	public const int GRP_OPT_TIME_NIGHT = 52;

	public const int GRP_OPT_TIME_DAY_CLOUD = 53;

	public const int GRP_OPT_TIME_EVENING_CLOUD = 54;

	public const int GRP_OPT_TIME_NIGHT_CLOUD = 55;

	public const int GRP_OPT_TIME_GROUP = 0;

	public const int GRP_OPT_ATK_RARE = 60;

	public const int GRP_OPT_ATK_NO_RARE = 61;

	public const int GRP_OPT_RARE_GROUP = 0;

	public const int GRP_OPT_DEF_G = 62;

	public const int GRP_OPT_DEF_NO_G = 63;

	public const int GRP_OPT_DEF_G_GROUP = 0;

	public const int GRP_OPT_DEF_WALL = 64;

	public const int GRP_OPT_DEF_NO_WALL = 65;

	public const int GRP_OPT_DEF_WALL_GROUP = 0;

	public const int GRP_OPT_GPOKE_EXIST = 66;

	public const int GRP_OPT_GPOKE_NOT_EXIST = 67;

	public const int GRP_OPT_GPOKE_ENEMY_EXIST = 68;

	public const int GRP_OPT_GPOKE_SELF_EXIST = 69;

	public const int GRP_OPT_GPOKE_BOTH_EXIST = 70;

	public const int GRP_OPT_GPOKE_EXIST_GROUP = 0;

	public const int GRP_OPT_TRG1_SELF = 70;

	public const int GRP_OPT_TRG1_ENEMY = 71;

	public const int GRP_OPT_TRG2_SELF = 72;

	public const int GRP_OPT_TRG2_ENEMY = 73;

	public const int GRP_OPT_TRAINER_TRG_GROUP = 0;

	public const int GRP_OPT_DEF_CAPTURE_DEMO = 80;

	public const int GRP_OPT_DEF_NOT_CAPTURE_DEMO = 81;

	public const int GRP_OPT_CAPTURE_DEMO_GROUP = 0;

	public const int GRP_OPT_DEF_WIN = 90;

	public const int GRP_OPT_DEF_CTR = 91;

	public const int GRP_OPT_PLATFORM_GROUP = 0;

	public const int GRP_OPT_ATK_L = 100;

	public const int GRP_OPT_ATK_UNDER_M = 101;

	public const int GRP_OPT_DEF_L = 102;

	public const int GRP_OPT_DEF_UNDER_M = 103;

	public const int GRP_OPT_ATK_SIZE_OTHER = 104;

	public const int GRP_OPT_DEF_SIZE_OTHER = 105;

	public const int GRP_OPT_POKE_SIZE_GROUP = 0;

	public const int GRP_OPT_DEF_LASTPOKE = 110;

	public const int GRP_OPT_PLAY_LASTPOKE = 111;

	public const int GRP_OPT_EE_PERS_GROUP = 0;

	public const int GRP_OPT_POKE_LAND_NORMAL = 120;

	public const int GRP_OPT_POKE_LAND_FLY = 121;

	public const int GRP_OPT_POKE_LAND_GROUND = 122;

	public const int GRP_OPT_POKE_LAND_EX_NORMAL = 123;

	public const int GRP_OPT_POKE_LAND_EX_FLY = 124;

	public const int GRP_OPT_POKE_LAND_EX_GROUND = 125;

	public const int GRP_OPT_POKE_LAND_EX_FL_GRO = 126;

	public const int GRP_OPT_POKE_LAND_EX_GRO_FL = 127;

	public const int GRP_OPT_POKE2_LAND_NORMAL = 128;

	public const int GRP_OPT_POKE2_LAND_FLY = 129;

	public const int GRP_OPT_POKE2_LAND_GROUND = 130;

	public const int GRP_OPT_POKE_LAND_GROUP = 0;

	public const int GRP_OPT_TRG1_POKE_SELF = 130;

	public const int GRP_OPT_TRG1_POKE_ENEMY = 131;

	public const int GRP_OPT_TRG2_POKE_SELF = 132;

	public const int GRP_OPT_TRG2_POKE_ENEMY = 133;

	public const int GRP_OPT_TRG1_POKE_SELF1 = 134;

	public const int GRP_OPT_TRG1_POKE_SELF2 = 135;

	public const int GRP_OPT_TRG1_POKE_SELF3 = 136;

	public const int GRP_OPT_TRG1_POKE_SELF4 = 137;

	public const int GRP_OPT_POKE_TRG_GROUP = 0;

	public const int GRP_OPT_ATK_UNDER_L = 0;

	public const int GRP_OPT_ATK_LL = 0;

	public const int GRP_OPT_DEF_UNDER_L = 0;

	public const int GRP_OPT_DEF_LL = 0;

	public const int GRP_OPT_THIS_LL = 0;

	public const int GRP_OPT_THIS_NOT_LL = 0;

	public const int GRP_OPT_BACK_LL = 0;

	public const int GRP_OPT_BACK_NOT_LL = 0;

	public const int GRP_OPT_LL_GROUP = 0;

	public const int GRP_OPT_ATK_TR1 = 75;

	public const int GRP_OPT_ATK_TR2 = 76;

	public const int GRP_OPT_DEF_TR1 = 77;

	public const int GRP_OPT_DEF_TR2 = 78;

	public const int GRP_OPT_TRAINER_NUM_GROUP = 0;

	public const int GRP_OPT_ATK_OVER_DEF = 105;

	public const int GRP_OPT_ATK_UNDEF_DEF = 106;

	public const int GRP_OPT_SIZE_COMP_GROUP = 0;

	public const int GRP_OPT_ATK_BUDDY = 0;

	public const int GRP_OPT_ATK_NOT_BUDDY = 0;

	public const int GRP_OPT_DEF_BUDDY = 0;

	public const int GRP_OPT_DEF_NOT_BUDDY = 0;

	public const int GRP_OPT_BUDDY_GROUP = 0;

	public const int GRP_OPT_VER_ORI_K = 140;

	public const int GRP_OPT_VER_ORI_T = 141;

	public const int GRP_OPT_VERSION_GROUP = 0;

	public const int GRP_OPT_MSG_SELECT_A = 150;

	public const int GRP_OPT_MSG_SELECT_B = 151;

	public const int GRP_OPT_MSG_SELECT_C = 152;

	public const int GRP_OPT_MSG_SELECT_GROUP = 0;

	public const int GRP_OPT_BTL_LEGEND = 160;

	public const int GRP_OPT_BTL_NOT_LEGEND = 161;

	public const int GRP_OPT_BTL_LEGEND_GROUP = 0;

	public const int GRP_OPT_BTL_JOKER_1 = 170;

	public const int GRP_OPT_BTL_JOKER_2 = 171;

	public const int GRP_OPT_BTL_JOKER_3 = 172;

	public const int GRP_OPT_BTL_NOT_JOKER = 173;

	public const int GRP_OPT_BTL_JOKER_GROUP = 0;

	public const int GRP_OPT_ATK_G = 180;

	public const int GRP_OPT_ATK_NO_G = 181;

	public const int GRP_OPT_ATK_G_GROUP = 0;

	public const int GRP_OPT_FIELD_STADIUM = 190;

	public const int GRP_OPT_FIELD_NO_STADIUM = 191;

	public const int GRP_OPT_FIELD_NO_AUDIENCE = 192;

	public const int GRP_OPT_FIELD_GROUP = 0;

	public const int GRP_OPT_EXCIT_NONE = 200;

	public const int GRP_OPT_EXCIT_CRITICAL = 201;

	public const int GRP_OPT_EXCIT_SICK = 202;

	public const int GRP_OPT_EXCIT_INTRO_POKE = 203;

	public const int GRP_OPT_EXCIT_LAST_INTRO_POKE = 204;

	public const int GRP_OPT_EXCIT_CHANGE_GPOKE = 205;

	public const int GRP_OPT_EXCIT_POKE_DOWN = 206;

	public const int GRP_OPT_EXCIT_GPOKE_DOWN = 207;

	public const int GRP_OPT_EXCIT_FINISH = 208;

	public const int GRP_OPT_EXCIT_GROUP = 0;

	public const int GRP_OPT_SPE_TRG1_POKE_HIMEU_N = 210;

	public const int GRP_OPT_SPE_TRG1_POKE_NO_HIMEU = 211;

	public const int GRP_OPT_SPE_TRG1_POKE_HIMEU_A = 212;

	public const int GRP_OPT_SPE_TRG1_POKE_HIMEU_B = 213;

	public const int GRP_OPT_SPE_TRG1_PSV_NONE = 214;

	public const int GRP_OPT_SPE_TRG1_PSV_PIKA_NOR = 215;

	public const int GRP_OPT_SPE_TRG1_PSV_PIKA_SATO = 216;

	public const int GRP_OPT_SPE_TRG1_PSV_PIKA_SP_G = 217;

	public const int GRP_OPT_SPE_TRG1_PSV_IIBUI_NOR = 218;

	public const int GRP_OPT_SPE_TRG1_PSV_IIBUI_SP_G = 219;

	public const int GRP_OPT_SPE_TRG1_PSV_NYAASU_SP_G = 220;

	public const int GRP_OPT_SPE_TRG1_POKE_NO_USAGI3 = 221;

	public const int GRP_OPT_SPE_TRG1_POKE_USAGI3 = 222;

	public const int GRP_OPT_SPE_TRG1_PSV_PIKA_G_NOR = 223;

	public const int GRP_OPT_SPE_TRG1_PSV_PIKA_G_SATO = 224;

	public const int GRP_OPT_SPE_TRG1_PSV_IIBUI_G_NOR = 225;

	public const int GRP_OPT_SPE_TRG_POKE_GROUP = 0;

	public const int GRP_OPT_STADIUM_SIZE_WIDE = 220;

	public const int GRP_OPT_STADIUM_SIZE_NARROW = 221;

	public const int GRP_OPT_STADIUM_SIZE_GROUP = 0;

	public const int GRP_OPT_SPE_TRG1_POKE_RARE_NONE = 230;

	public const int GRP_OPT_SPE_TRG1_POKE_RARE_A = 231;

	public const int GRP_OPT_SPE_TRG1_POKE_RARE_B = 232;

	public const int GRP_OPT_SPE_TRG2_POKE_RARE_NONE = 233;

	public const int GRP_OPT_SPE_TRG2_POKE_RARE_A = 234;

	public const int GRP_OPT_SPE_TRG2_POKE_RARE_B = 235;

	public const int GRP_OPT_SPE_TRG3_POKE_RARE_NONE = 236;

	public const int GRP_OPT_SPE_TRG3_POKE_RARE_A = 237;

	public const int GRP_OPT_SPE_TRG3_POKE_RARE_B = 238;

	public const int GRP_OPT_SPE_TRG4_POKE_RARE_NONE = 239;

	public const int GRP_OPT_SPE_TRG4_POKE_RARE_A = 240;

	public const int GRP_OPT_SPE_TRG4_POKE_RARE_B = 241;

	public const int GRP_OPT_SPE_TRG_POKE_RARE_GROUP = 0;

	public const int GRP_OPT_TRG1_TYPE_GYMKUSA = 240;

	public const int GRP_OPT_TRG1_TYPE_GYMMIZU = 241;

	public const int GRP_OPT_TRG1_TYPE_GYMHONOO = 242;

	public const int GRP_OPT_TRG1_TYPE_GYMKAKUTOO = 243;

	public const int GRP_OPT_TRG1_TYPE_GYMGHOST = 244;

	public const int GRP_OPT_TRG1_TYPE_GYMFAIRY = 245;

	public const int GRP_OPT_TRG1_TYPE_GYMIWA = 246;

	public const int GRP_OPT_TRG1_TYPE_GYMKOORI = 247;

	public const int GRP_OPT_TRG1_TYPE_GYMAKU = 248;

	public const int GRP_OPT_TRG1_TYPE_GYMDRAGON = 249;

	public const int GRP_OPT_TRG1_TYPE_YELL = 250;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_KUSA = 251;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_MIZU = 252;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_HONOO = 253;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_KAKUTOO = 254;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_GHOST = 255;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_FAIRY = 256;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_IWA = 257;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_KOORI = 258;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_AKU = 259;

	public const int GRP_OPT_TRG1_TYPE_GYM_L_DRAGON = 260;

	public const int GRP_OPT_TRAINER_TYPE_GROUP = 0;

	public const int GRP_OPT_PC_MALE = 270;

	public const int GRP_OPT_PC_FEMALE = 271;

	public const int GRP_OPT_PC_SEX_GROUP = 0;

	public const int GRP_OPT_POKE_SIZE_NEAR1_L = 272;

	public const int GRP_OPT_POKE_SIZE_NEAR1_UNDER_M = 273;

	public const int GRP_OPT_POKE_SIZE_NEAR2_L = 274;

	public const int GRP_OPT_POKE_SIZE_NEAR2_UNDER_M = 275;

	public const int GRP_OPT_POKE_SIZE_FAR1_L = 276;

	public const int GRP_OPT_POKE_SIZE_FAR1_UNDER_M = 277;

	public const int GRP_OPT_POKE_SIZE_FAR2_L = 278;

	public const int GRP_OPT_POKE_SIZE_FAR2_UNDER_M = 279;

	public const int GRP_OPT_POKE_SIZE_VPOS_GROUP = 0;
}
