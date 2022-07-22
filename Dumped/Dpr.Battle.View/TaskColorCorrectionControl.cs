using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskColorCorrectionControl : TaskPostEffectCotrol
{
	private FromToPair<Vector3> _colorScale;

	private FromToPair<Vector3> _colorBias;

	private FromToPair<float> _brightness;

	private FromToPair<float> _saturation;

	private FromToPair<float> _contrast;

	private FromToPair<float> _temperature;

	private FromToPair<float> _sepiaToneWeight;

	protected override bool IsFinishCondition => default(bool);

	public TaskColorCorrectionControl(SequenceCameraObject cameraObject, Vector3 colorScale, Vector3 colorBias, float brightness, float saturation, float contrast, float temperature, float sepiaToneWeight, int lifeTime, Ease easeingType)
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
