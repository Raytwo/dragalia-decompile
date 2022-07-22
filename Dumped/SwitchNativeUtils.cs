using UnityEngine;

public static class SwitchNativeUtils
{
	public const float VolumeValueMin = 0f;

	public const float VolumeValueMax = 1f;

	private static extern void Native_SetExpectedVolumeBalance(float applicationVolume, float sdkVolume);

	public static void SetExpectedVolumeBalance(float applicationVolume, float sdkVolume)
	{
	}

	private unsafe static extern void Native_GetExpectedVolumeBalance(float* pApplicationVolume, float* pSdkVolume);

	public static Vector2 GetExpectedVolumeBalance()
	{
		return default(Vector2);
	}
}
