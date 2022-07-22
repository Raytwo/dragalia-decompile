using System.Runtime.CompilerServices;
using Dpr;
using UnityEngine;
using XLSXContent;

public class FieldCamera : MonoBehaviour
{
	private Transform _target;

	private Camera _camera;

	[SerializeField]
	private float _pitch;

	[SerializeField]
	private float _fov;

	[SerializeField]
	private float _targetRange;

	[SerializeField]
	private float _defocusStart;

	[SerializeField]
	private float _defocusEnd;

	private float _start_pitch;

	private float _start_fov;

	private float _start_targetRange;

	private float _start_defocusStart;

	private float _start_defocusEnd;

	private float _end_pitch;

	private float _end_fov;

	private float _end_targetRange;

	private float _end_defocusStart;

	private float _end_defocusEnd;

	private float _pitch_time;

	private float _pitch_work_wait;

	private Vector3 oldPosition;

	[SerializeField]
	private float _cameraLerpRate;

	public Camera EncountEffectCamera;

	public bool IsUpdateStop;

	private bool isPanCamera;

	private FieldPanCamera _panCamera;

	private GameObject DarkWindow;

	private float _scriptFardepth;

	private float _scriptFardepthTime;

	private float _scriptFardepthTimeVectol;

	private float _fovOffset;

	private float _fovOffsetStart;

	private float _fovOffsetEnd;

	private float _fovOffsetTime;

	private float _fovOffsetTimeScale;

	private Transform returnDofTransform;

	private GameObject tempDofTransform;

	private bool IsStopDofTarget;

	public Vector3 offset
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 offsetAngle
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EventCamera EventCamera
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FieldCameraShake FieldCameraShake
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FieldFloatMove TargetRangeOffset
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float Fov
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public AfterImage AfterImage
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float TargetRange => default(float);

	public void SetPanCameraFlag(bool flag)
	{
	}

	public bool GetPanCameraFlag()
	{
		return default(bool);
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void ForceUpdateCamera()
	{
	}

	private void CameraUpdate(float deltaTime)
	{
	}

	public void FixedPosition()
	{
	}

	public void SetTempNormalCamera(float pitch, float fov, float far)
	{
	}

	public void SetTempNormalCamera(float pitch, float fov, float targetRange, float defocusStart, float defocusEnd, bool isForse = true, float wait = 0f)
	{
	}

	public void SetTempNormalCamera(MapInfo.SheetCamera data, bool isForse, float wait)
	{
	}

	public void UpdateMapInfoParam(float time)
	{
	}

	public bool IsMoveStop()
	{
		return default(bool);
	}

	public void CameraComponentEnable(bool flag)
	{
	}

	public void InstantiateDarkWindow(GameObject darkWindow)
	{
	}

	public void DestroyDarkWindow()
	{
	}

	public GameObject GetDarkWindow()
	{
		return null;
	}

	public void ScriptFarDepth(float depth, float frame)
	{
	}

	public void ChangeDofTarget(ref Vector3 postion)
	{
	}

	public void ResetChangeDofTarget()
	{
	}

	public void SetCameraDirect(Vector3 position, Vector3 rotate)
	{
	}

	public Camera GetCamera()
	{
		return null;
	}

	public void SetFovOffset(float offset, float time)
	{
	}

	public float GetFov()
	{
		return default(float);
	}
}
