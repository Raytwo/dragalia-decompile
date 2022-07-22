using System;
using System.Collections.Generic;
using System.Globalization;
using Dpr.Battle.View.Playables;
using UnityEngine;

namespace Dpr.SequenceEditor;

[Serializable]
public class Macro
{
	[Serializable]
	public struct Value
	{
		public string Name;

		public List<string> Values;

		public string this[int index] => null;
	}

	public static Macro Default;

	public CommandNo CommandNo;

	public string Name;

	public List<Value> Values;

	public CameraFilePlayable CamFile;

	private static CultureInfo culture_us;

	public Macro()
	{
	}

	public Macro(Macro other)
	{
	}

	public Value GetValue(string key)
	{
		return default(Value);
	}

	public static string ParseString(Value value, string def = "")
	{
		return null;
	}

	public static int ParseInt(Value value, int def = -1)
	{
		return default(int);
	}

	public static Vector3 ParseVector3(Value value, float def = 0f)
	{
		return default(Vector3);
	}

	public static Vector3 ParseVector3(Value value, float defX, float defY, float defZ = 0f)
	{
		return default(Vector3);
	}

	public static float ParseFloat(Value value, float def = 0f)
	{
		return default(float);
	}

	public static bool ParseBool(Value value, bool def = false)
	{
		return default(bool);
	}

	public static bool ParseBool(Value value, int def)
	{
		return default(bool);
	}

	public static bool[] ParseBoolArray(Value value, bool def = true)
	{
		return null;
	}

	public static bool[] ParseBoolArray(Value value, int def0, int def1, int def2)
	{
		return null;
	}

	public static CLUSTER_SPAWN Parse_CLUSTER_SPAWN(Value value, CLUSTER_SPAWN def = CLUSTER_SPAWN.CLUSTER_SPAWN_POINT)
	{
		return default(CLUSTER_SPAWN);
	}

	public static CLUSTER_POS_AXIS Parse_CLUSTER_POS_AXIS(Value value, CLUSTER_POS_AXIS def = (CLUSTER_POS_AXIS)0)
	{
		return default(CLUSTER_POS_AXIS);
	}

	public static SEQ_DEF_MOVETYPE Parse_SEQ_DEF_MOVETYPE(Value value, SEQ_DEF_MOVETYPE defaultMoveType = SEQ_DEF_MOVETYPE.SEQ_DEF_MOVETYPE_LINER)
	{
		return default(SEQ_DEF_MOVETYPE);
	}

	public static SEQ_DEF_POS Parse_SEQ_DEF_POS(Value value)
	{
		return default(SEQ_DEF_POS);
	}

	public static SEQ_DEF_NODE Parse_SEQ_DEF_NODE(Value value, SEQ_DEF_NODE def = SEQ_DEF_NODE.SEQ_DEF_NODE_ORIGIN)
	{
		return default(SEQ_DEF_NODE);
	}

	public static SEQ_DEF_TR_ENV Parse_SEQ_DEF_TR_ENV(Value value, SEQ_DEF_TR_ENV def = SEQ_DEF_TR_ENV.SEQ_DEF_TR_ENV_TOUJYO)
	{
		return default(SEQ_DEF_TR_ENV);
	}

	public static SEQ_DEF_TRAINER Parse_SEQ_DEF_TRAINER(Value value, SEQ_DEF_TRAINER def = SEQ_DEF_TRAINER.SEQ_DEF_TRAINER_SELF1)
	{
		return default(SEQ_DEF_TRAINER);
	}

	public static SEQ_DEF_SPPOS Parse_SEQ_DEF_SPPOS(Value value, SEQ_DEF_SPPOS def = SEQ_DEF_SPPOS.SEQ_DEF_SPPOS_SELF_FIELD)
	{
		return default(SEQ_DEF_SPPOS);
	}

	public static SEQ_DEF_ROTATE_ORDER Parse_SEQ_DEF_ROTATE_ORDER(Value value, SEQ_DEF_ROTATE_ORDER def = SEQ_DEF_ROTATE_ORDER.SEQ_DEF_ROTATE_ORDER_XYZ)
	{
		return default(SEQ_DEF_ROTATE_ORDER);
	}

	public static SEQ_DEF_MOTION Parse_SEQ_DEF_MOTION(Value value, SEQ_DEF_MOTION def = SEQ_DEF_MOTION.MOTION_WAIT)
	{
		return default(SEQ_DEF_MOTION);
	}

	public static SEQ_DEF_ATK_MOT Parse_SEQ_DEF_ATK_MOT(Value value, SEQ_DEF_ATK_MOT def = (SEQ_DEF_ATK_MOT)0)
	{
		return default(SEQ_DEF_ATK_MOT);
	}

	public static SEQ_DEF_AXIS Parse_SEQ_DEF_AXIS(Value value, SEQ_DEF_AXIS def = SEQ_DEF_AXIS.SEQ_DEF_AXIS_X)
	{
		return default(SEQ_DEF_AXIS);
	}

	public static SEQ_DEF_GPOKE_EFFECT Parse_SEQ_DEF_GPOKE_EFFECT(Value value, SEQ_DEF_GPOKE_EFFECT def = SEQ_DEF_GPOKE_EFFECT.GPOKE_EFFECT_ALL)
	{
		return default(SEQ_DEF_GPOKE_EFFECT);
	}

	public static SEQ_DEF_ANIMCONF Parse_SEQ_DEF_ANIMCONF(Value value, SEQ_DEF_ANIMCONF def = SEQ_DEF_ANIMCONF.SEQ_DEF_ANIMCONF_BATTLE)
	{
		return default(SEQ_DEF_ANIMCONF);
	}

	public static SEQ_DEF_TRAINER_ADD Parse_SEQ_DEF_TRAINER_ADD(Value value, SEQ_DEF_TRAINER_ADD def = SEQ_DEF_TRAINER_ADD.SEQ_DEF_TRAINER_SELF1)
	{
		return default(SEQ_DEF_TRAINER_ADD);
	}

	public static SEQ_DEF_TR_CAM Parse_SEQ_DEF_TR_CAM(Value value, SEQ_DEF_TR_CAM def = SEQ_DEF_TR_CAM.SEQ_DEF_TR_CAM_FILE)
	{
		return default(SEQ_DEF_TR_CAM);
	}

	public static SEQ_DEF_EFF_DRAWTYPE Parse_SEQ_DEF_EFF_DRAWTYPE(Value value, SEQ_DEF_EFF_DRAWTYPE def = SEQ_DEF_EFF_DRAWTYPE.SEQ_DEF_EFF_DRAWTYPE_NORAML)
	{
		return default(SEQ_DEF_EFF_DRAWTYPE);
	}

	public static SEQ_DEF_DRAWTYPE Parse_SEQ_DEF_DRAWTYPE(Value value, SEQ_DEF_DRAWTYPE def = SEQ_DEF_DRAWTYPE.SEQ_DEF_DRAWTYPE_NORMAL)
	{
		return default(SEQ_DEF_DRAWTYPE);
	}

	public static BALL_ANIME Parse_BALL_ANIME(Value value, BALL_ANIME def = BALL_ANIME.BALL_ANIME_NONE)
	{
		return default(BALL_ANIME);
	}

	public static SEQ_DEF_TR_TEX Parse_SEQ_DEF_TR_TEX(Value value, SEQ_DEF_TR_TEX def = SEQ_DEF_TR_TEX.SEQ_DEF_TR_TEX_MAIN)
	{
		return default(SEQ_DEF_TR_TEX);
	}

	public static SEQ_DEF_MONS_SEX Parse_SEQ_DEF_MONS_SEX(Value value, SEQ_DEF_MONS_SEX def = SEQ_DEF_MONS_SEX.SEQ_DEF_MONS_SEX_MALE)
	{
		return default(SEQ_DEF_MONS_SEX);
	}

	public static SEQ_DEF_FOLLOW Parse_SEQ_DEF_FOLLOW(Value value, SEQ_DEF_FOLLOW def = SEQ_DEF_FOLLOW.SEQ_DEF_FOLLOW_PARTICLE)
	{
		return default(SEQ_DEF_FOLLOW);
	}

	public static VOICE_TYPE Parse_VOICE_TYPE(Value value, VOICE_TYPE def = VOICE_TYPE.VOICE_TYPE_NORMAL)
	{
		return default(VOICE_TYPE);
	}

	public static SEQ_DEF_UI_FOG Parse_SEQ_DEF_UI_FOG(Value value, SEQ_DEF_UI_FOG def = SEQ_DEF_UI_FOG.SEQ_DEF_UI_FOG_LV0)
	{
		return default(SEQ_DEF_UI_FOG);
	}

	public static FADE_TYPE Parse_FADE_TYPE(Value value, FADE_TYPE def = FADE_TYPE.FADE_TYPE_NORMAL)
	{
		return default(FADE_TYPE);
	}

	public static LIGHT_TYPE Parse_LIGHT_TYPE(Value value, LIGHT_TYPE def = LIGHT_TYPE.LIGHT_TYPE_RESET)
	{
		return default(LIGHT_TYPE);
	}

	public static SEQ_DEF_LIGHT_TRG_SIDE Parse_SEQ_DEF_LIGHT_TRG_SIDE(Value value, SEQ_DEF_LIGHT_TRG_SIDE def = SEQ_DEF_LIGHT_TRG_SIDE.SEQ_DEF_LIGHT_TRG_SIDE_ALL)
	{
		return default(SEQ_DEF_LIGHT_TRG_SIDE);
	}

	public static CLUSTER_POS Parse_CLUSTER_POS(Value value, CLUSTER_POS def = CLUSTER_POS.CLUSTER_ORIGIN)
	{
		return default(CLUSTER_POS);
	}

	public static CLUSTER_POS_PLANE Parse_CLUSTER_POS_PLANE(Value value, CLUSTER_POS_PLANE def = (CLUSTER_POS_PLANE)0)
	{
		return default(CLUSTER_POS_PLANE);
	}

	public static CLUSTER_REFRECT Parse_CLUSTER_REFRECT(Value value, CLUSTER_REFRECT def = CLUSTER_REFRECT.CLUSTER_REFRECT_NONE)
	{
		return default(CLUSTER_REFRECT);
	}

	public static CLUSTER_CHILD Parse_CLUSTER_CHILD(Value value, CLUSTER_CHILD def = CLUSTER_CHILD.CLUSTER_CHILD_NONE)
	{
		return default(CLUSTER_CHILD);
	}

	public static SEQ_DEF_WINDOW_TYPE Parse_SEQ_DEF_WINDOW_TYPE(Value value, SEQ_DEF_WINDOW_TYPE def = SEQ_DEF_WINDOW_TYPE.SEQ_DEF_WINDOW_NORMAL)
	{
		return default(SEQ_DEF_WINDOW_TYPE);
	}

	public static SEQ_DEF_FAIRY_QUIZ_TYPE Parse_SEQ_DEF_FAIRY_QUIZ_TYPE(Value value, SEQ_DEF_FAIRY_QUIZ_TYPE def = SEQ_DEF_FAIRY_QUIZ_TYPE.SEQ_DEF_FAIRY_QUIZ_TYPE_NONE)
	{
		return default(SEQ_DEF_FAIRY_QUIZ_TYPE);
	}

	public static SEQ_DEF_FAIRY_QUIZ_RESULT Parse_SEQ_DEF_FAIRY_QUIZ_RESULT(Value value, SEQ_DEF_FAIRY_QUIZ_RESULT def = SEQ_DEF_FAIRY_QUIZ_RESULT.SEQ_DEF_FAIRY_QUIZ_RESULT_NONE)
	{
		return default(SEQ_DEF_FAIRY_QUIZ_RESULT);
	}

	public static SEQ_DEF_WAIT Parse_SEQ_DEF_WAIT(Value value, SEQ_DEF_WAIT def = SEQ_DEF_WAIT.SEQ_DEF_WAIT_KEY)
	{
		return default(SEQ_DEF_WAIT);
	}

	public static SEQ_DEF_WEATHER Parse_SEQ_DEF_WEATHER(Value value, SEQ_DEF_WEATHER def = SEQ_DEF_WEATHER.SEQ_DEF_WEATHER_NONE)
	{
		return default(SEQ_DEF_WEATHER);
	}

	public static SEQ_DEF_POKE_G Parse_SEQ_DEF_POKE_G(Value value, SEQ_DEF_POKE_G def = SEQ_DEF_POKE_G.SEQ_DEF_POKE_G_NONE)
	{
		return default(SEQ_DEF_POKE_G);
	}

	public static SEQ_DEF_FWAZA_TYPE Parse_SEQ_DEF_FWAZA_TYPE(Value value, SEQ_DEF_FWAZA_TYPE def = SEQ_DEF_FWAZA_TYPE.SEQ_DEF_FWAZA_TYPE_NONE)
	{
		return default(SEQ_DEF_FWAZA_TYPE);
	}

	public static SEQ_DEF_INPUT Parse_SEQ_DEF_INPUT(Value value, SEQ_DEF_INPUT def = SEQ_DEF_INPUT.SEQ_DEF_INPUT_UP)
	{
		return default(SEQ_DEF_INPUT);
	}

	public static SEQ_DEF_RENDERER_TYPE Parse_SEQ_DEF_RENDERER_TYPE(Value value, SEQ_DEF_RENDERER_TYPE def = SEQ_DEF_RENDERER_TYPE.SEQ_DEF_RENDERER_TYPE_MAIN)
	{
		return default(SEQ_DEF_RENDERER_TYPE);
	}

	public static SEQ_DEF_TIME_ZONE Parse_SEQ_DEF_TIME_ZONE(Value value, SEQ_DEF_TIME_ZONE def = SEQ_DEF_TIME_ZONE.SEQ_DEF_TIME_ZONE_MORNING)
	{
		return default(SEQ_DEF_TIME_ZONE);
	}

	public static ROTOM_EFFECT Parse_ROTOM_EFFECT(Value value, ROTOM_EFFECT def = ROTOM_EFFECT.ROTOM_EFFECT_WILD)
	{
		return default(ROTOM_EFFECT);
	}

	public static SEQ_DEF_SEPAN Parse_SEQ_DEF_SEPAN(Value value, SEQ_DEF_SEPAN def = SEQ_DEF_SEPAN.SEQ_DEF_SEPAN_NONE)
	{
		return default(SEQ_DEF_SEPAN);
	}

	public static SEQ_DEF_VIGNETTE_TYPE Parse_SEQ_DEF_VIGNETTE_TYPE(Value value, SEQ_DEF_VIGNETTE_TYPE def = SEQ_DEF_VIGNETTE_TYPE.SEQ_DEF_VIGNETTE_TYPE_STANDARD)
	{
		return default(SEQ_DEF_VIGNETTE_TYPE);
	}

	public static SEQ_DEF_FOG_MODE Parse_SEQ_DEF_FOG_MODE(Value value, SEQ_DEF_FOG_MODE def = SEQ_DEF_FOG_MODE.SEQ_DEF_FOG_MODE_LINEAR)
	{
		return default(SEQ_DEF_FOG_MODE);
	}

	public static SEQ_DEF_FIXPARAM_CALC Parse_SEQ_DEF_FIXPARAM_CALC(Value value, SEQ_DEF_FIXPARAM_CALC def = SEQ_DEF_FIXPARAM_CALC.SEQ_DEF_FIXPARAM_CALC_SET)
	{
		return default(SEQ_DEF_FIXPARAM_CALC);
	}

	public static SEQ_DEF_LG_LUM Parse_SEQ_DEF_LG_LUM(Value value, SEQ_DEF_LG_LUM def = SEQ_DEF_LG_LUM.SEQ_DEF_LG_LUM_COLOR)
	{
		return default(SEQ_DEF_LG_LUM);
	}

	public static SEQ_DEF_LG_SHAPE Parse_SEQ_DEF_LG_SHAPE(Value value, SEQ_DEF_LG_SHAPE def = SEQ_DEF_LG_SHAPE.SEQ_DEF_LG_SHAPE_DISABLE)
	{
		return default(SEQ_DEF_LG_SHAPE);
	}

	public static SEQ_DEF_MASK_TEX_PATTERN Parse_SEQ_DEF_MASK_TEX_PATTERN(Value value, SEQ_DEF_MASK_TEX_PATTERN def = SEQ_DEF_MASK_TEX_PATTERN.SEQ_DEF_MASK_TEX_PATTERN_1)
	{
		return default(SEQ_DEF_MASK_TEX_PATTERN);
	}

	public static SEQ_STENCIL_TARGET Parse_SEQ_STENCIL_TARGET(Value value, SEQ_STENCIL_TARGET def = SEQ_STENCIL_TARGET.SEQ_STENCIL_TARGET_NONE)
	{
		return default(SEQ_STENCIL_TARGET);
	}

	public static SEQ_DEF_MODETYPE Parse_SEQ_DEF_MODETYPE(Value value, SEQ_DEF_MODETYPE def = SEQ_DEF_MODETYPE.SEQ_DEF_MODETYPE_UNIFORM)
	{
		return default(SEQ_DEF_MODETYPE);
	}

	public static SEQ_DEF_DEFAULT_PLACEMENT Parse_SEQ_DEF_DEFAULT_PLACEMENT(Value value, SEQ_DEF_DEFAULT_PLACEMENT def = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
		return default(SEQ_DEF_DEFAULT_PLACEMENT);
	}

	public static float float_Parse(string s)
	{
		return default(float);
	}
}
