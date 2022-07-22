using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.SecretBase;

public class StatuePlacementEditBoot : MonoBehaviour
{
	[SerializeField]
	private StatuePlacementEditController scene;

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
