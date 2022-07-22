using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;

[DisallowMultipleComponent]
public class EffectActivator : MonoBehaviour
{
	[SceneBeforeActivateOperationMethod]
	public IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	protected virtual IEnumerator OnActivateOperation()
	{
		return null;
	}
}
