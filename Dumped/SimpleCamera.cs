using UnityEngine;

public class SimpleCamera : MonoBehaviour
{
	private Camera _camera;

	private Transform _cameraTransform;

	private bool _drag;

	private Transform _dragTarget;

	private Vector3 _interestPoint;

	private float _distance;

	private bool _controllable;

	public BoundingSphere _boundingSphere;

	public Bounds _bounds;

	private Transform _cameraTarget;

	public Transform dragTarget
	{
		set
		{
		}
	}

	public Transform cameraTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoundingSphere boundingSphere
	{
		get
		{
			return default(BoundingSphere);
		}
		set
		{
		}
	}

	public Bounds bounds
	{
		get
		{
			return default(Bounds);
		}
		set
		{
		}
	}

	public bool controllable
	{
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void Track(float x, float y)
	{
	}

	private void Tumble(float yaw, float pitch)
	{
	}

	private void Pan(float yaw, float pitch)
	{
	}

	public void SetTarget(GameObject instance, bool fit = true)
	{
	}

	private Vector3[] GetPositions(GameObject instance)
	{
		return null;
	}

	private Bounds ComputeBounds(Vector3[] positions)
	{
		return default(Bounds);
	}

	private BoundingSphere ComputeBoundingSphereFast(Vector3[] positions)
	{
		return default(BoundingSphere);
	}

	public void FitSphere(BoundingSphere sphere)
	{
	}

	public void FitSphere()
	{
	}

	public void FitBox()
	{
	}
}
