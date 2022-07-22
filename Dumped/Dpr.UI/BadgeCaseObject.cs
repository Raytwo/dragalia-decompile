using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class BadgeCaseObject : MonoBehaviour
{
	public const string BadgeCaseModelAssetPathFormat = "objects/ob1009_{0}";

	public const string BadgeModelAssetPath = "objects/ob1009_09";

	public const string BadgeAnimeAssetPath = "objects/ob1009_00";

	public const string BadgeCaseModelName = "ob1009_BadgeCase";

	public const string BadgeModelName = "ob1009_Badges";

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Transform maskTransform;

	[SerializeField]
	private Transform showBadgePositionTransform;

	[SerializeField]
	private Color diamondCaseColor;

	[SerializeField]
	private Color diamondCaseTitleColor;

	[SerializeField]
	private Color diamondGymleaderFrameColor;

	[SerializeField]
	private Color diamondCaseButtonFrameColor;

	[SerializeField]
	private Color pearlCaseColor;

	[SerializeField]
	private Color pearlCaseTitleColor;

	[SerializeField]
	private Color pearlGymleaderFrameColor;

	[SerializeField]
	private Color pearlCaseButtonFrameColor;

	[SerializeField]
	private float polishedRange;

	[SerializeField]
	private float badgeTouchRotateSpeed;

	[SerializeField]
	private float badgeAutoRotateStartTime;

	[SerializeField]
	private float badgeAutoRotateDuration;

	[SerializeField]
	private CardAnimationController animationController;

	[SerializeField]
	private BadgeCaseAnimationEvent animationEvent;

	private UITouchInputController touchInputController;

	private UIInputController input;

	private Transform badgeCaseTransform;

	private Transform badgeTransform;

	private Transform buttonTransform;

	private BadgeObject[] badgeObjects;

	private BadgeObject selectedBadgeObject;

	private Vector2 tempStartPoint;

	private Vector3 beforeBadgePosition;

	private Quaternion beforeBadgeRotation;

	private float noTouchTime;

	private Camera screenCamera;

	private RaycastHit[] raycastHits;

	private Animator badgeCaseAnimator;

	private Animator badgeAnimator;

	private bool isDisposed;

	private bool isShowBadge;

	private bool IsBadgeGet;

	public bool IsReady
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsOpen => default(bool);

	public bool IsEnd
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsAnimation => default(bool);

	public void Initialize(Camera screenCamera, UIInputController input, bool isBadgeGet = false)
	{
	}

	public void Dispose()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void OpenCover()
	{
	}

	public void CloseCover()
	{
	}

	public void Show()
	{
	}

	public void PlayBadgeConditionEffects()
	{
	}

	public void StopBadgeConditionEffects()
	{
	}

	public void PlayAnimationBadgeGet(string animeName)
	{
	}

	public IEnumerator LoadBadgeGetAnimation()
	{
		return null;
	}

	public Transform GetBadgeTransform(int badgeNo)
	{
		return null;
	}

	private void SetActive(bool isActive)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private string GetBadgeCaseModelAssetPath()
	{
		return null;
	}

	private void LoadModel()
	{
	}

	private IEnumerator SetupModels()
	{
		return null;
	}

	private bool Raycast(Vector3 point, out bool isHitButton, out BadgeObject hitBadgeObject)
	{
		return default(bool);
	}

	private void SwitchBadgeCaseOpenClose()
	{
	}

	private void PlayCaseButtonEffect()
	{
	}
}
