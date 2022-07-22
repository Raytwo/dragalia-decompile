using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.SecretBase;

public class SecretBaseBoot : MonoBehaviour
{
	[SerializeField]
	private SecretBaseController scene;

	private AssetRequestOperation playerRequestOperation;

	[SceneBeforeActivateOperationMethod]
	public IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	private IEnumerator Load()
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
