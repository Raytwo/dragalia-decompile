using UnityEngine;

namespace Dpr.GMS;

public class GMSInput
{
	private enum KeyAssignId
	{
		Left,
		Right,
		Up,
		Down,
		Decide,
		Cancel,
		FarCamera,
		NearCamera
	}

	private class KeyAssignIdValue
	{
		public const int Left = 1;

		public const int Right = 2;

		public const int Up = 4;

		public const int Down = 8;

		public const int Decide = 16;

		public const int Cancel = 32;

		public const int FarCamera = 64;

		public const int NearCamera = 128;
	}

	public static GMSInput input;

	private GameController.LogicalInput localInput;

	public static bool RollLeft => default(bool);

	public static bool RollRight => default(bool);

	public static bool RollUp => default(bool);

	public static bool RollDown => default(bool);

	public static bool Decide => default(bool);

	public static bool Touch => default(bool);

	public static Vector2 Analog => default(Vector2);

	public static bool LookUpNorth => default(bool);

	public static void CreateInstance()
	{
	}

	public static void DestroyInstance()
	{
	}

	public void Subscribe()
	{
	}

	public void Remove()
	{
	}

	private void AssignKeyLeft()
	{
	}

	private void AssignKeyRight()
	{
	}

	private void AssignKeyUp()
	{
	}

	private void AssignKeyDown()
	{
	}

	private void AssignKeyDecide()
	{
	}

	private void AssignKeyCancel()
	{
	}

	private void AssignKeyFarCamera()
	{
	}

	private void AssignKeyNearCamera()
	{
	}

	public static bool RepeatLeft()
	{
		return default(bool);
	}

	public static bool ReleaseLeft()
	{
		return default(bool);
	}

	public static bool RepeatRight()
	{
		return default(bool);
	}

	public static bool ReleaseRight()
	{
		return default(bool);
	}

	public static bool RepeatUp()
	{
		return default(bool);
	}

	public static bool ReleaseUp()
	{
		return default(bool);
	}

	public static bool RepeatDown()
	{
		return default(bool);
	}

	public static bool ReleaseDown()
	{
		return default(bool);
	}

	public static bool PushDecide()
	{
		return default(bool);
	}

	public static bool PushCancel()
	{
		return default(bool);
	}

	public static bool PushFarCamera()
	{
		return default(bool);
	}

	public static bool PushNearCamera()
	{
		return default(bool);
	}

	private static bool IsEasyInput()
	{
		return default(bool);
	}

	private bool IsPush(int assignValue)
	{
		return default(bool);
	}

	private bool IsRepeat(int assignValue)
	{
		return default(bool);
	}

	private bool IsRelease(int assignValue)
	{
		return default(bool);
	}
}
