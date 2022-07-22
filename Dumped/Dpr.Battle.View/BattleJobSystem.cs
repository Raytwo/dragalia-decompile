using System.Collections.Generic;

namespace Dpr.Battle.View;

public static class BattleJobSystem
{
	private static HashSet<ITranslationObject> _translationObjects;

	static BattleJobSystem()
	{
	}

	public static bool Add(ITranslationObject item)
	{
		return default(bool);
	}

	public static bool Remove(ITranslationObject item)
	{
		return default(bool);
	}

	public static void Clear()
	{
	}

	public static void OnUpdatePreJob(float deltaTime)
	{
	}

	public static void OnUpdatePostJob(float deltaTime)
	{
	}
}
