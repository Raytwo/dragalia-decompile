using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class CapsuleViewController : MonoBehaviour
{
	[SerializeField]
	private GameObject capsule3DViewPrefab;

	[SerializeField]
	private GameObject capsule2DObject;

	[SerializeField]
	private GameObject capsule3DObject;

	[SerializeField]
	private RawImage capsule3DViewRawImage;

	[SerializeField]
	private RectTransform bgRectTransform;

	[SerializeField]
	private SealSubKeyGuide subKeyGuide;

	private static GameObject capsule3DViewObject;

	private Transform bgParent;

	private bool isBeforeFadeBlurActive;

	private bool isOpenedKeyguide;

	private bool isFading;

	public bool IsInitialized => default(bool);

	public Capsule2DViewController View2DController
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Capsule3DViewController View3DController
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IEnumerator Initialize()
	{
		return null;
	}

	public void Dispose()
	{
	}

	public void Setup(CapsuleInfo capsuleInfo, bool isResetView)
	{
	}

	public void Set3DCapsuleActive(bool isAvtive)
	{
	}

	public void SetDisablePreviewGuide(bool isEnable)
	{
	}

	public IEnumerator ShowPreviewScene(CapsuleInfo capsuleInfo, CapsuleInfo subCapsuleInfo, IEnumerator playFadeWindow, Action onBeforeFadeIn, bool isCallStopScript = true)
	{
		return null;
	}

	public IEnumerator HidePreviewScene(IEnumerator playFadeWindow, Action onBeforeFadeIn, bool isCallOnOpenMenu = true)
	{
		return null;
	}

	public void UpdatePreviewKeyGuide(Keyguide keyguide)
	{
	}

	public bool CheckWaitFade()
	{
		return default(bool);
	}

	private void SetupRawImage(Transform parent)
	{
	}
}
