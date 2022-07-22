using System;

namespace Dpr.Field.Walking;

[Serializable]
public class DeltaTime
{
	public static bool isPause;

	public static float TimeScale;

	public static float deltaTime => default(float);

	public void Update()
	{
	}

	public static void Pause()
	{
	}

	public static void UnPause()
	{
	}
}
