using DG.Tweening;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class TaskFeedBackEffectControl : TaskPostEffectCotrol
{
	private FromToPair<float> _feedbackEffectWeight;

	private FromToPair<float> _feedbackEffectRotation;

	private FromToPair<float> _feedbackEffectScale;

	private FromToPair<float> _feedbackEffectHue;

	private FromToPair<float> _feedbackEffectSaturation;

	private FromToPair<float> _feedbackEffectBrightness;

	private FromToPair<float> _feedbackEffectContrast;

	protected override bool IsFinishCondition => default(bool);

	public TaskFeedBackEffectControl(SequenceCameraObject cameraObject, float feedbackEffectWeight, float feedbackEffectRotation, float feedbackEffectScale, float feedbackEffectHue, float feedbackEffectSaturation, float feedbackEffectBrightness, float feedbackEffectContrast, Ease easingType, int lifeTime)
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
