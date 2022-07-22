using UnityEngine;

public class CopyTransform : MonoBehaviour
{
	public Transform target;

	private Transform _transform;

	private Vector3 _savedLocalPosition;

	private Quaternion _savedLocalRotation;

	private Vector3 _savedLocalScale;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}
}
