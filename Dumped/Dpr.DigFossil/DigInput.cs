using UnityEngine;

namespace Dpr.DigFossil;

public static class DigInput
{
	public static bool Left => default(bool);

	public static bool Right => default(bool);

	public static bool Up => default(bool);

	public static bool Down => default(bool);

	public static bool Dig => default(bool);

	public static bool Touch => default(bool);

	public static Vector2 TouchPos => default(Vector2);

	public static bool Decide => default(bool);

	public static bool SwitchTool => default(bool);

	public static Vector2 Analog => default(Vector2);

	public static bool ToggleCameraShake => default(bool);

	private static bool IsEasyInput()
	{
		return default(bool);
	}
}
