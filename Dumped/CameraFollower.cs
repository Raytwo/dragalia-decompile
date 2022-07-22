using UnityEngine;

[ExecuteInEditMode]
public class CameraFollower : MonoBehaviour
{
	[SerializeField]
	private Camera _camera;

	private Transform _cameraTransform;

	private Transform _targetTransform;

	private void OnEnable()
	{
	}

	public bool SetCamera(Camera camera)
	{
		return default(bool);
	}

	private void LateUpdate()
	{
	}
}
