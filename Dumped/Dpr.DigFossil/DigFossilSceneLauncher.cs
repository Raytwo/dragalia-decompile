using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.DigFossil;

public class DigFossilSceneLauncher : MonoBehaviour
{
	private DigFossilController scene;

	[SceneBeforeActivateOperationMethod]
	public IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
