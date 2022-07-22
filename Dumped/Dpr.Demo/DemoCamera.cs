using System.Collections.Generic;
using DG.Tweening;
using SmartPoint.Rendering;
using UnityEngine;

namespace Dpr.Demo;

public class DemoCamera : MonoBehaviour
{
	public float LeapValue;

	public Camera cam;

	[SerializeField]
	private List<Transform> CameraPosList;

	[SerializeField]
	private int DebugLeapPosIndex1;

	[SerializeField]
	private int DebugLeapPosIndex2;

	public const int RenderSettings_Gosanke = 0;

	public const int RenderSettings_Hakase = 1;

	public const int RenderSettings_DemoCommon = 2;

	public const int RenderSettings_UI02 = 3;

	public const int RenderSettings_UI04 = 4;

	public const int RenderSettings_PoffinEat = 5;

	public List<EnvironmentSettings> environmentSettings;

	private RenderTexture tex;

	private Animator animator;

	public PostProcessFilter postProcessFilter;

	[SerializeField]
	private float DebugDuration;

	[SerializeField]
	private Ease DebugEase;

	public int Button01;

	private AnimationClip _nowClip;

	private int TargetFrame;

	public string DebugAnimName;

	public int Button02;

	private AnimationClip nowClip => null;

	private void Awake()
	{
	}

	public RenderTexture CreateRenderTex(bool isUseAlpha, bool isSetCamera = true)
	{
		return null;
	}

	private void OnValidate()
	{
	}

	private void OnDestroy()
	{
	}

	private void LeapMove(Transform tra1, Transform tra2)
	{
	}

	public void TweenMove(int PosIndex1, int PosIndex2, float duration)
	{
	}

	public void DebugMove()
	{
	}

	public void SetAnimatorController(RuntimeAnimatorController controller)
	{
	}

	public void PlayAnim(string animName, float time = 0f)
	{
	}

	public void PauseAnim()
	{
	}

	public void ResumeAnim()
	{
	}

	public void SetPauseTargetFrame(int i_frame)
	{
	}

	public void UnSetPause()
	{
	}

	private void TargetFramePause(float deltaTime)
	{
	}

	public void PlayTargetFrame(int i_frame, string animName)
	{
	}

	public void _DebugPlay()
	{
	}

	public void ResetPostProcess()
	{
	}
}
