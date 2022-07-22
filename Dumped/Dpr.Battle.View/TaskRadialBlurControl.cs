using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskRadialBlurControl : TaskPostEffectCotrol
{
	private FromToPair<Vector2> _center;

	private FromToPair<float> _intensity;

	private FromToPair<int> _numSamples;

	protected override bool IsFinishCondition => default(bool);

	public TaskRadialBlurControl(SequenceCameraObject cameraObject, Vector2 center, float intensity, int numSamples, int lifeTime, Ease easingType)
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
