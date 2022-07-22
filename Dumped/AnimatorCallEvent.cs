using UnityEngine;
using UnityEngine.Events;

public class AnimatorCallEvent : MonoBehaviour
{
	private Animator mAnimator;

	private bool hasLayerOverride;

	public bool dispLog;

	public UnityAction<string, int> mAction_AK_EffectStart00;

	public UnityAction<string, int> mAction_AK_EffectStart01;

	public UnityAction<string, int> mAction_AK_ButuriStart01;

	public UnityAction<string, int> mAction_AK_SEStart01;

	public UnityAction<string, int> mAction_AK_SEStart02;

	public UnityAction<string, int> mAction_AK_SEStart03;

	public UnityAction<string, int> mAction_AK_PartsMaterial01;

	private int loop01Weight;

	public int Loop01Weight => default(int);

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void DispLog(string log)
	{
	}

	private void AK_EffectStart00(int value)
	{
	}

	private void AK_EffectStart01(int value)
	{
	}

	private void AK_ButuriStart01(int value)
	{
	}

	private void AK_SEStart01(int value)
	{
	}

	private void AK_SEStart02(int value)
	{
	}

	private void AK_SEStart03(int value)
	{
	}

	private void AK_PartsMaterial01(int value)
	{
	}

	private void AK_PartsSkel01(int value)
	{
	}
}
