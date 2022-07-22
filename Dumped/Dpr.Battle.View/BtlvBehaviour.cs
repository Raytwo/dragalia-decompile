using UnityEngine;

namespace Dpr.Battle.View;

public abstract class BtlvBehaviour : MonoBehaviour
{
	private Transform _cachedTransform;

	public new Transform transform => null;
}
