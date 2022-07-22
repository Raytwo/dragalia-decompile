using UnityEngine;

namespace Dpr.SequenceEditor;

[CreateAssetMenu]
public class SplinePositionData : ScriptableObject
{
	[SerializeField]
	private Vector3[] _positions;

	public Vector3[] GetPositions()
	{
		return null;
	}
}
