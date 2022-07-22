using System;
using DG.Tweening;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class TaskDepthOfFieldControl : TaskPostEffectCotrol
{
	private enum Mode
	{
		SWSH,
		DPR
	}

	private Mode _mode;

	private bool _isAutoFocus;

	private Tuple<float, float> _fNumber;

	private Tuple<float, float> _focusDistance;

	private Tuple<float, float> _farDepth;

	private Tuple<float, float> _focalLength;

	private Tuple<float, float> _distance;

	private Tuple<float, float> _blurry;

	protected override bool IsFinishCondition => default(bool);

	public TaskDepthOfFieldControl(SequenceCameraObject cameraObject, bool isAutoFocus, float fNumber, float focusDistance, int lifeTime, Ease easingType)
	{
	}

	public TaskDepthOfFieldControl(SequenceCameraObject cameraObject, float farDepth, float focalLength, float distance, float blurry, int lifeTime, Ease easingType)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override PfxParam OnUpdate(int frame, float raito, ref PfxParam pfxParam)
	{
		return default(PfxParam);
	}
}
