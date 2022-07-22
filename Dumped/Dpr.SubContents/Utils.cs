using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Audio;
using Dpr.Demo;
using Dpr.Message;
using Dpr.MsgWindow;
using Effect;
using Pml;
using Pml.PokePara;
using Ug;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

namespace Dpr.SubContents;

public static class Utils
{
	public class AssetUnloader
	{
		public const int ID_FUREAI = 1;

		public const int ID_FIELD_TUREARUKI = 2;

		private List<(string, int)> paths;

		public void AddPath(string path, int id = 0)
		{
		}

		public void Unload(int id = 0)
		{
		}
	}

	public enum MoveTypeResult
	{
		OK,
		CantMoveType,
		CantEnter
	}

	public const int GAME_FPS = 30;

	public const float GURUGURU_HEIGHT_UNION = 10f;

	public const float GURUGURU_HEIGHT_OTHER = 20f;

	private static readonly int[] RandMotions;

	private static readonly int[] pikaRandomVoices;

	private static readonly int[] evRandomVoices;

	private static readonly int[] pikaRankVoices;

	private static readonly int[] evRankVoices;

	private static readonly int[] pikaNoticeVoice;

	private static readonly int[] evNoticeVoice;

	private static readonly int[] FT_motionIndex;

	private static readonly int[] Pffin_motionIndex;

	private static readonly int[] pikaPoffinVoice;

	private static readonly int[] evPoffinVoice;

	private static readonly int[] pikaDrowseVoice;

	private static readonly int[] evDrowseVoice;

	public static readonly Vector2Int[] directList;

	private static readonly DIR[] dirs;

	private const int GROUP_NAME_LNGTH = 5;

	private const int POKE_RARITY_VERY_RARE = 3;

	private const int POKE_RARITY_LEGEND_RARE = 2;

	private const int POKE_RARITY_SUB_LEGEND_RARE = 1;

	public static readonly MonsNo[] very_rare_monsno;

	public static readonly MonsNo[] legend_rare_monsno;

	public static readonly MonsNo[] sub_legend_rare_monsno;

	public static bool PushA => default(bool);

	public static bool PushB => default(bool);

	public static bool PushX => default(bool);

	public static bool PushY => default(bool);

	public static bool PushR => default(bool);

	public static bool PushL => default(bool);

	public static bool PushZL => default(bool);

	public static bool PushZR => default(bool);

	public static bool PushPulsMinus => default(bool);

	public static bool PushRStick => default(bool);

	public static bool PushAorB => default(bool);

	public static bool PressA => default(bool);

	public static bool PressB => default(bool);

	public static bool PressX => default(bool);

	public static bool PressY => default(bool);

	public static bool PressR => default(bool);

	public static bool PressL => default(bool);

	public static bool PressZR => default(bool);

	public static bool PressZL => default(bool);

	public static bool KeyLeft => default(bool);

	public static bool KeyRight => default(bool);

	public static bool KeyDown => default(bool);

	public static bool KeyUp => default(bool);

	public static IEnumerator LoadEffect(EffectFieldID id, UnityAction<EffectData> OnLoad)
	{
		return null;
	}

	public static IEnumerator LoadEffect(EffectBattleID id, UnityAction<EffectData> OnLoad)
	{
		return null;
	}

	public static IEnumerator LoadEffect(EffectContestID id, UnityAction<EffectData> OnLoad)
	{
		return null;
	}

	public static IEnumerator LoadAsset(string path, Action<UnityEngine.Object> OnLoad, bool isVariant = false)
	{
		return null;
	}

	public static string GetPokemonAssetbundleName(string AssetBundleName)
	{
		return null;
	}

	public static string GetBattlePokemonAssetbundleName(string AssetBundleName)
	{
		return null;
	}

	public static string GetAssetNamebyPath(string AssetBundlePath)
	{
		return null;
	}

	public static PokemonInfo.SheetCatalog GetPokemonCatalog(PokemonParam p)
	{
		return null;
	}

	public static string GetBallModelPath(BallId ballId)
	{
		return null;
	}

	public static void DrawMessage(MsgWindowParam param, ref Dpr.MsgWindow.MsgWindow window)
	{
	}

	public static MsgWindowParam CreateMsgWindowParam(string msgFileName, string labelName, bool inputClose = false, bool inputEnable = false)
	{
		return null;
	}

	public static int GetUISortingOrderMax()
	{
		return default(int);
	}

	public static int KinomiID_to_ItemID(int kinomiID)
	{
		return default(int);
	}

	public static IEnumerator ZukanTouroku(PokemonParam p, DemoSceneManager manager)
	{
		return null;
	}

	public static IEnumerator ZukanTouroku(PokemonParam p, DemoSceneManager manager, bool isGetMons)
	{
		return null;
	}

	public static AudioInstance PlayVoice(MonsNo monsNo, int formNo, int voiceNo, [Optional] UnityAction<AudioInstance> onFinished)
	{
		return null;
	}

	public static AudioInstance PlayVoiceEV(MonsNo monsNo, int formNo, int voiceNo, [Optional] UnityAction<AudioInstance> onFinished, [Optional] Transform t)
	{
		return null;
	}

	public static AudioInstance PlayVoice(MonsNo monsNo, int formNo, int voiceNo, VoicePlayerAmbient voicePlayer)
	{
		return null;
	}

	public static void StopVoice()
	{
	}

	public static string GetVoiceID_EV(MonsNo monsNo, int formNo, int voiceNo)
	{
		return null;
	}

	public static string GetVoiceID(MonsNo monsNo, int formNo, int voiceNo)
	{
		return null;
	}

	public static bool IsPikaV(MonsNo monsNo)
	{
		return default(bool);
	}

	public static void PlayVoicePikaBui_NakayoshiRank(MonsNo monsNo, int FriendRank, VoicePlayerAmbient voicePlayer)
	{
	}

	public static int GetVoicePikaBui_NakayoshiRank(MonsNo monsNo, int FriendRank)
	{
		return default(int);
	}

	public static int GetNakayoshiRankMotion(int FriendRank)
	{
		return default(int);
	}

	public static void PlayVoicePikaBui_Notice(MonsNo monsNo, int FriendRank, VoicePlayerAmbient voicePlayer)
	{
	}

	public static void PlayVoicePikaBui_Poffin(MonsNo monsNo, int motionID)
	{
	}

	public static void PlayVoicePikaBui_Yobiyose(MonsNo monsNo, VoicePlayerAmbient voicePlayer)
	{
	}

	public static void PlayVoicePikaBui_Kaisan(MonsNo monsNo, VoicePlayerAmbient voicePlayer)
	{
	}

	public static void PlayVoicePikaBui_Roar(MonsNo monsNo, VoicePlayerAmbient voicePlayer)
	{
	}

	public static void PlayVoicePikaBui_Drowse(MonsNo monsNo, int sequence, VoicePlayerAmbient voicePlayer)
	{
	}

	public static void PlayVoicePikaBui_Touch(MonsNo monsNo, VoicePlayerAmbient voicePlayer)
	{
	}

	private static bool IsExistAnim(int index, AnimationPlayer animPlayer)
	{
		return default(bool);
	}

	public static int GetExistAnim(FieldObjectEntity entity, int[] AnimationIdList)
	{
		return default(int);
	}

	public static int GetExistAnim(AnimationPlayer animPlayer, int[] AnimationIdList)
	{
		return default(int);
	}

	public static void WaitFrame(int frame, Action act)
	{
	}

	private static IEnumerator WaitFrameCoroutine(int frame, Action act)
	{
		return null;
	}

	public static int GetNakayoshiRank(uint friendship)
	{
		return default(int);
	}

	public static void ArrayDestroy(object[] objects)
	{
	}

	public static float Vector2ToAngle(Vector2 input, float offset)
	{
		return default(float);
	}

	public static bool IsInDistance(Vector3 pos1, Vector3 pos2, float targetDistance)
	{
		return default(bool);
	}

	public static void GetAttribute(Vector3 pos, out int code, out int stop)
	{
	}

	public static bool CheckAttributeEnterable(Vector2Int pos)
	{
		return default(bool);
	}

	public static bool CheckAttributeEnterable(Vector3 pos)
	{
		return default(bool);
	}

	public static DIR GetWallDir(Vector2Int pos)
	{
		return default(DIR);
	}

	public static bool IsAdjacent(Vector2Int pos, Vector2Int targetPos)
	{
		return default(bool);
	}

	public static MoveTypeResult isEnterbleAttribute(Vector3 pos, MoveType moveType, bool isFureai = false)
	{
		return default(MoveTypeResult);
	}

	public static MoveTypeResult isEnterbleAttribute(int code, int stop, MoveType moveType)
	{
		return default(MoveTypeResult);
	}

	public static bool isNotExistsCollision(Vector3 pos)
	{
		return default(bool);
	}

	public static void GuruguruRisingStart()
	{
	}

	public static void GuruguruFallStart()
	{
	}

	public static IEnumerator PlayerGuruguruStop(float angle, float height, bool isRising, Action OnComplete)
	{
		return null;
	}

	public static IEnumerator PlayerFallStop(float height, bool isRising, Action OnComplete)
	{
		return null;
	}

	public static IEnumerator OtherPlayerRising(float height, FieldObjectEntity entity, Action OnComplete)
	{
		return null;
	}

	public static void PlayerGuruguru(float deltaTime)
	{
	}

	public static void PlayerRising(float deltaTime)
	{
	}

	public static void PlayerFall(float deltaTime)
	{
	}

	public static float GetGuruGuruHeight(ZoneID zoneID)
	{
		return default(float);
	}

	public static void PlayGuruguruSE(bool isRising)
	{
	}

	public static IEnumerator CreateNPC(Vector2Int grid, string assetPath, Action<FieldObjectEntity> OnLoad)
	{
		return null;
	}

	public static void BGM_FadeOut(float duration, [Optional] Action OnComplete)
	{
	}

	public static void PlayCurrentFieldBGM(bool isIgnoreEvent = false)
	{
	}

	public static string CheckNGTrainerName(ref string trainerName, MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public static string CheckNGTrainerName(ref string trainerName, MessageEnumData.MsgLangId langId, int cassetVersion)
	{
		return null;
	}

	private static int GetPersonNameLength()
	{
		return default(int);
	}

	public static string CheckNGPokeName(ref string nickname, MonsNo monsNo, MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public static string CheckNGPokeName(PokemonParam param)
	{
		return null;
	}

	private static int GetMonsNameLength()
	{
		return default(int);
	}

	public static string CheckNGGroupName(ref string groupName, MessageEnumData.MsgLangId langId, int cassetVersion)
	{
		return null;
	}

	private static string GetReplacedNGName(int cassetVersion)
	{
		return null;
	}

	public static void OpenPasswordSoftwareKeyboard(Action<bool, string> result)
	{
	}

	public static int GetPokeRarityNum(MonsNo monsNo)
	{
		return default(int);
	}

	public static bool CheckInvalidTradePoke(MonsNo monsNo)
	{
		return default(bool);
	}

	public static string GetPlayerIdText(uint id)
	{
		return null;
	}

	public static uint GetPlayerPartyCount()
	{
		return default(uint);
	}

	public static PokemonParam UpdateTranerMemo(PokemonParam updateParam)
	{
		return null;
	}
}
