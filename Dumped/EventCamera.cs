using System.Runtime.CompilerServices;
using SmartPoint.Rendering;
using UnityEngine;

public class EventCamera
{
	private FieldCamera camera;

	private EventCameraData cameraData;

	private Vector3 workPosition;

	private Vector3 workRotate;

	private Vector3 retrunDefaultPosition;

	private Vector3 returnDefaultRotate;

	private DepthOfField _dof;

	private float[] default_dof;

	private float[] work_dof;

	private Vector3 default_dof_offset;

	private Vector3 before_dof_offset;

	private Vector3 work_dof_offset;

	private EventCameraTable _cameraTbl;

	private float workFov;

	private float beforeFov;

	private float defaultFov;

	public Vector3 defaultPosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector3 defaultRotate
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector3 beforePosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector3 beforeRotate
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsEnd
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EventCamera(FieldCamera cam)
	{
	}

	public void SetCameraData(EventCameraTable tbl, int index)
	{
	}

	public void SetCameraData(EventCameraTable tbl, EventCameraData data)
	{
	}

	public void Release()
	{
	}

	public void lateUpdate(float deltatime)
	{
	}

	private bool PathUpdate(EventCameraData.PathData path, float t)
	{
		return default(bool);
	}

	private bool PathUpdate2(EventCameraData.PathData2 path, float t)
	{
		return default(bool);
	}

	private bool RotationUpdate(EventCameraData.RotationData path, float t)
	{
		return default(bool);
	}

	private bool ReturnDefault(EventCameraData.ReturnDefault path, float t)
	{
		return default(bool);
	}

	private bool ReturnDefaultRotate(EventCameraData.ReturnDefault path, float t)
	{
		return default(bool);
	}

	private bool FieldOfViewUpdate(EventCameraData.FovData path, float t)
	{
		return default(bool);
	}

	private void FadeUpdate(EventCameraData.FadeData fade)
	{
	}
}
