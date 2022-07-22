using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskChromaticAberrationControl : TaskPostEffectCotrol
{
	private FromToPair<Vector2> _disper;

	protected override bool IsFinishCondition => default(bool);

	public TaskChromaticAberrationControl(SequenceCameraObject cameraObject, Vector2 disper, int lifeTime, Ease easingType)
	{
	}

	protected override PfxParam OnUpdate(int frame, float raito, ref PfxParam pfxParam)
	{
		return default(PfxParam);
	}
}
