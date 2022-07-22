using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using UnityEngine;

namespace DG.Tweening;

public class DOTweenAnimation : ABSAnimationComponent
{
	public enum AnimationType
	{
		None,
		Move,
		LocalMove,
		Rotate,
		LocalRotate,
		Scale,
		Color,
		Fade,
		Text,
		PunchPosition,
		PunchRotation,
		PunchScale,
		ShakePosition,
		ShakeRotation,
		ShakeScale,
		CameraAspect,
		CameraBackgroundColor,
		CameraFieldOfView,
		CameraOrthoSize,
		CameraPixelRect,
		CameraRect,
		UIWidthHeight
	}

	public enum TargetType
	{
		Unset,
		Camera,
		CanvasGroup,
		Image,
		Light,
		RectTransform,
		Renderer,
		SpriteRenderer,
		Rigidbody,
		Rigidbody2D,
		Text,
		Transform,
		tk2dBaseSprite,
		tk2dTextMesh,
		TextMeshPro,
		TextMeshProUGUI
	}

	public bool targetIsSelf;

	public GameObject targetGO;

	public bool tweenTargetIsTargetGO;

	public float delay;

	public float duration;

	public Ease easeType;

	public AnimationCurve easeCurve;

	public LoopType loopType;

	public int loops;

	public string id;

	public bool isRelative;

	public bool isFrom;

	public bool isIndependentUpdate;

	public bool autoKill;

	public bool isActive;

	public bool isValid;

	public Component target;

	public AnimationType animationType;

	public TargetType targetType;

	public TargetType forcedTargetType;

	public bool autoPlay;

	public bool useTargetAsV3;

	public float endValueFloat;

	public Vector3 endValueV3;

	public Vector2 endValueV2;

	public Color endValueColor;

	public string endValueString;

	public Rect endValueRect;

	public Transform endValueTransform;

	public bool optionalBool0;

	public float optionalFloat0;

	public int optionalInt0;

	public RotateMode optionalRotationMode;

	public ScrambleMode optionalScrambleMode;

	public string optionalString;

	private bool _tweenCreated;

	private int _playCount;

	public static event Action<DOTweenAnimation> OnReset
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Reset()
	{
	}

	private void OnDestroy()
	{
	}

	public void CreateTween()
	{
	}

	public override void DOPlay()
	{
	}

	public override void DOPlayBackwards()
	{
	}

	public override void DOPlayForward()
	{
	}

	public override void DOPause()
	{
	}

	public override void DOTogglePause()
	{
	}

	public override void DORewind()
	{
	}

	public override void DORestart()
	{
	}

	public override void DORestart(bool fromHere)
	{
	}

	public override void DOComplete()
	{
	}

	public override void DOKill()
	{
	}

	public void DOPlayById(string id)
	{
	}

	public void DOPlayAllById(string id)
	{
	}

	public void DOPauseAllById(string id)
	{
	}

	public void DOPlayBackwardsById(string id)
	{
	}

	public void DOPlayBackwardsAllById(string id)
	{
	}

	public void DOPlayForwardById(string id)
	{
	}

	public void DOPlayForwardAllById(string id)
	{
	}

	public void DOPlayNext()
	{
	}

	public void DORewindAndPlayNext()
	{
	}

	public void DORewindAllById(string id)
	{
	}

	public void DORestartById(string id)
	{
	}

	public void DORestartAllById(string id)
	{
	}

	public List<Tween> GetTweens()
	{
		return null;
	}

	public static TargetType TypeToDOTargetType(Type t)
	{
		return default(TargetType);
	}

	public Tween CreateEditorPreview()
	{
		return null;
	}

	private GameObject GetTweenGO()
	{
		return null;
	}

	private void ReEvaluateRelativeTween()
	{
	}
}
