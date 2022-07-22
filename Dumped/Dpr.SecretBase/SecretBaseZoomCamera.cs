using UnityEngine;

namespace Dpr.SecretBase;

public class SecretBaseZoomCamera : MonoBehaviour
{
	[SerializeField]
	private Camera zoomCamera;

	[SerializeField]
	private float initFOV;

	[SerializeField]
	private float offsetPosY;

	[SerializeField]
	private float offsetRotationX;

	[SerializeField]
	private float offsetRotationY;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private float rotateLimitX;

	[SerializeField]
	private float rotateLimitYTop;

	[SerializeField]
	private float rotateLimitYBottom;

	[SerializeField]
	private float moveLimit;

	[SerializeField]
	private Vector3 offsetY;

	[SerializeField]
	private float farDepth;

	private float normalDepthFar;

	private float totalRotateX;

	private float totalRotateY;

	private float totalMove;

	private Vector3 initDistance;

	private int facial;

	public void Initialize(FieldConnector fieldConnector)
	{
	}

	public void OnUpdate()
	{
	}

	private void ZoomCameraRotateUpdate()
	{
	}

	private void UpdateFacial()
	{
	}
}
