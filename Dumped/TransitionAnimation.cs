using System;
using System.Collections;

public static class TransitionAnimation
{
	public const int GAME_FPS = 30;

	public const float GURUGURU_HEIGHT_UNION = 10f;

	public const float GURUGURU_HEIGHT_OTHER = 20f;

	public static FieldCharacterEntity targetChara;

	public static void GuruguruRisingStart()
	{
	}

	public static void GuruguruFallStart(FieldCharacterEntity targetEntity)
	{
	}

	public static IEnumerator PlayerGuruguruStop(FieldCharacterEntity targetEntity, float angle, float height, bool isRising, Action OnComplete)
	{
		return null;
	}

	public static IEnumerator EntityTransitionAnimationStop(FieldCharacterEntity targetEntity, float height, float angle, bool isRising, Action OnComplete, bool isGuruGuru = true)
	{
		return null;
	}

	public static IEnumerator AgEntityTransitionAnimationStop(FieldCharacterEntity targetEntity, float height, float angle, bool isRising, Action OnComplete, bool isGuruGuru = true)
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
}
