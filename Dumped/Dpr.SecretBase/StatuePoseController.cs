using UnityEngine;

namespace Dpr.SecretBase;

public class StatuePoseController : MonoBehaviour
{
	private enum Step
	{
		FirstFrame,
		PlayAnimation,
		StopAnimation,
		ShowModel,
		DisableAnimator,
		Idle
	}

	private int MotionPrefixLength;

	private StatueEffectData statueData;

	private SkinnedMeshRenderer[] renderers;

	private Step step;

	public void Initialize(StatueEffectData statueData, SkinnedMeshRenderer[] renderers)
	{
	}

	private void LateUpdate()
	{
	}

	private void PlayAnimation()
	{
	}

	private void StopAnimation()
	{
	}

	private void DisableAnimator()
	{
	}

	private void OnEnable()
	{
	}
}
