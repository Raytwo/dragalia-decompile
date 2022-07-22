using System.Collections;
using SmartPoint.AssetAssistant;

public class SceneEventObserver
{
	private static readonly string BATTLE_SCENE_PATH;

	private static readonly string FIELD_SCENE_PATH;

	[AssetAssistantInitializeMethod(0)]
	private static void Initialize()
	{
	}

	private static IEnumerator PrepareForSceneSwitching(SceneEntity currentScene, SceneEntity targetScene)
	{
		return null;
	}

	private static void OnBeforeSceneChanged(SceneEntity currentScene, SceneEntity targetScene)
	{
	}

	private static void OnSceneNavigated(SceneEntity currentScene, SceneEntity targetScene)
	{
	}
}
