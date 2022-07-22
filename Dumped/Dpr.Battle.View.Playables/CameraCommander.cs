using System.Runtime.CompilerServices;
using Dpr.Battle.View.Objects;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View.Playables;

public sealed class CameraCommander : BtlvBehaviour
{
	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private BOCamera _targetCamera;

	private CameraData _cameraData;

	private Transform _aimTarget;

	public BOCamera TargetCamera => null;

	public Camera Camera => null;

	private bool IsStop
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform AimTarget => null;

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	public void Initialize(ISequenceViewSystem viewSystem, CameraData cameraData, Transform aimTarget)
	{
	}
}
