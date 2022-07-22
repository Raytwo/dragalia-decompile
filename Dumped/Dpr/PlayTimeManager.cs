using System;

namespace Dpr;

public static class PlayTimeManager
{
	private static bool _isInitialized;

	private static DateTime _prevDateTime;

	private static int _limitSec;

	private static int _limitAddSec;

	public static bool isInitialized => default(bool);

	public static void Initialize()
	{
	}

	private static void OnUpdate(float deltaTime)
	{
	}
}
