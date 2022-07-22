using System.Runtime.CompilerServices;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Contest;

public class ContestCameraSystem : SequenceCameraSystem
{
	public WaitCameraStateType WaitCameraState
	{
		[CompilerGenerated]
		get
		{
			return default(WaitCameraStateType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsPlayWaitCamera => default(bool);

	public Transform GetTargetTransform()
	{
		return null;
	}

	public ContestCameraSystem(ISequenceViewSystem cameraView, Camera mainCamera)
	{
	}

	public override void OnLateUpdate(float deltaTime)
	{
	}

	private void LateUpdateWaitCamera()
	{
	}
}
