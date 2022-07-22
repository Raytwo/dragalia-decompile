using DG.Tweening;
using Dpr.SequenceEditor;
using Pml;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.Battle.View;

public static class BattleViewDefine
{
	public static class Path
	{
		public const string ASSET_BUNDLE_PATH = "btlv";

		public const string ASSET_BUNDLE_PATH_SEAL_FX = "effect/prefab";

		public const string ASSET_BUNDLE_PATH_FX = "effect/prefab/battle";

		public const string ASSET_BUNDLE_PATH_MODEL = "effmodel";

		public const string ASSET_BUNDLE_PATH_CHARACTERS = "objects";

		public static string GetScreenObjectPath()
		{
			return null;
		}

		public static string GetUISystemPath()
		{
			return null;
		}

		public static string GetDataTablePath(string dataTableName)
		{
			return null;
		}

		public static string GetSequencePath(string seqName)
		{
			return null;
		}

		public static string GetFXPath(string path)
		{
			return null;
		}

		public static string GetSealFXPath(string path)
		{
			return null;
		}

		public static string GetModelPath(string path)
		{
			return null;
		}

		public static string GetWaitCameraPath(string fileName)
		{
			return null;
		}

		public static string GetBallPath(BallId ballID)
		{
			return null;
		}

		public static string GetObjectPath(string fileName)
		{
			return null;
		}
	}

	public static class StringFormat
	{
		public const string TRAINER_MODEL_ID_HERO = "{0}";

		public const string TRAINER_AB_NAME = "persons/battle/{0}";

		public const string POKE_AB_NAME = "pokemons/battle/{0}";
	}

	public const int ANIMATION_FRAME_FPS = 30;

	public const int TRAINER_NUM = 7;

	public const int POKEMON_NUM = 7;

	public const string DEFAULT_HERO_MODEL_ID = "pc0002_00";

	public const string DEFAULT_TRAINER_MODEL_ID = "tr0028_00";

	public const string MIGAWARI_MODEL_ID = "ob0301_00";

	public const string DIGUDA_STONE_ID = "digda_rock";

	public const int POKE_BALL_MAX_NUM = 4;

	private const int BALL_MODEL_INDEX_BUFFER = 200;

	public const int STRANGE_BALL_ID = 99;

	public const int STENCILE_TARGET_MAX = 4;

	public const int DEFAULT_HASH_MODEL_MAX = 64;

	public const int DEFAULT_HASH_SOUND_PLAYING_ID_MAX = 64;

	public const Size DEFAULT_SAFARI_FRIEND_POKE_SIZE = Size.L;

	public const string CAPTURE_TUTORIAL_TALK_SEQ = "bk001";

	public const float CANVAS_SHOW_ALPHA = 1f;

	public const float CANVAS_HIDE_ALPHA = 0f;

	public const Ease DEFAULT_CANVAS_TRANSITION_EASE = Ease.OutSine;

	public const float DEFAULT_CANVAS_TRANSITION_DURATION = 0.25f;

	public const float DEFAULT_CANVAS_TRANSITION_DELAY = 0f;

	public const int DEFAULT_SELECT_WAZA_RESULT = -1;

	public const int WAZA_MAX_NUM = 4;

	public static readonly Color BATTLE_FADE_OUT_FADER_COLOR;

	public static string GetPlayerNoCapModelName(Sex sex)
	{
		return null;
	}

	public static string GetCameraName(SequenceCameraSystem.CameraStateType type)
	{
		return null;
	}
}
