using UnityEngine;

public class ReflectionCameraFollower : MonoBehaviour
{
	[SerializeField]
	private Camera _target;

	[SerializeField]
	private float _fovScale;

	private Camera _camera;

	private Transform _targetTransform;

	private Transform _cameraTransform;

	private int _ReflectionTexID;

	private int _ReflectionVP;

	private RenderTexture _targetTexture;

	private int customWidth;

	private int customHeight;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetCustomResolution(int width, int height)
	{
	}
}
