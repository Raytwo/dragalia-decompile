using System.Collections.Generic;
using Audio;

public static class AudioAmbientManager
{
	private static HashSet<AudioInstance> _audioInstanceHash;

	private static bool _enabled;

	public static bool isEnabled => default(bool);

	public static void SetEnabled(bool enabled)
	{
	}

	internal static void _Add(AudioInstance audioInstance)
	{
	}

	internal static void _Remove(AudioInstance audioInstance)
	{
	}
}
