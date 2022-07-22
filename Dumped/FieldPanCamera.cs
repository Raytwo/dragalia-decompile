using SmartPoint.Rendering;
using UnityEngine;

public class FieldPanCamera : MonoBehaviour
{
	private Camera _camera;

	private DepthOfField _dof;

	[SerializeField]
	private float _distance;

	[SerializeField]
	private float _pitch;

	[SerializeField]
	private float _fov;

	[SerializeField]
	private float _zOffset;

	[SerializeField]
	private float _top_offset;

	[SerializeField]
	private float _bottom_offset;

	[SerializeField]
	private bool _autoCalculation;

	[SerializeField]
	private Vector3 minPosition;

	[SerializeField]
	private Vector3 maxPosition;

	private ZoneID zoneID;

	private Bounds _bounds;

	private bool _initialized;

	public void onEnable()
	{
	}

	public void onDisable()
	{
	}

	public void PanUpdate()
	{
	}

	public void SetPanCameraData(ZoneID zoneID)
	{
	}
}
