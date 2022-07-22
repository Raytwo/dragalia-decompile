using System.Collections;
using Dpr.Playables;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dpr.UI;

public class CardModelViewController : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	[SerializeField]
	private Camera bgCamera;

	[SerializeField]
	private Transform modelCameraRoot;

	[SerializeField]
	private Camera modelCamera;

	[SerializeField]
	private Transform modelRoot;

	[SerializeField]
	private RectTransform bgRoot;

	[SerializeField]
	private EnvironmentController environmentController;

	[SerializeField]
	private EnvironmentSettings playerModelEnvironmentSettings;

	[SerializeField]
	private EnvironmentSettings badgeCaseEnvironmentSettings;

	[SerializeField]
	private BadgeCaseObject badgeCaseObject;

	[SerializeField]
	private CardAnimationController animationController;

	[SerializeField]
	private Transform characterRoot;

	[SerializeField]
	private string playerModelObjectName;

	private Transform currentBgParentTransform;

	private Transform currentBgTransform;

	private int currentBgSiblingIndex;

	private GameObject playerModelObject;

	private Transform playerModelTransform;

	private AnimationLayer playerModelAnimationLayer;

	private int playerModelWaitAnimationIndex;

	private string loadedAssetBundlePath;

	public bool IsReady => default(bool);

	public bool IsShowBadgeCase => default(bool);

	public bool IsEndBadgeCase => default(bool);

	public bool IsCardFront => default(bool);

	public bool IsAnimation => default(bool);

	public bool IsAnimationAll => default(bool);

	public void OnViewportChange(int screenWidth, int screenHeight)
	{
	}

	public void Initialize(UIInputController input, Animator cardAnimator)
	{
	}

	public void Dispose()
	{
	}

	public void SetEnviromentLight(bool isActive)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public IEnumerator Redraw()
	{
		return null;
	}

	public void CreateRenderTexture(RawImage rawImage)
	{
	}

	public void Setup(RenderTexture renderTexture, Transform bgTransform)
	{
	}

	public void RotatePlayerModel(float value)
	{
	}

	public void ResetRotatePlayerModel()
	{
	}

	public void ShowCard()
	{
	}

	public void SwitchCardFrontBack()
	{
	}

	public void ShowBadgeCase()
	{
	}

	public void OpenBadgeCase()
	{
	}

	public void CloseBadgeCase()
	{
	}

	public void LoadModels(byte fashion, byte bodyType, bool sex)
	{
	}

	private int GetPlayerWaitAnimationIndex(AnimationLayer animationLayer)
	{
		return default(int);
	}

	private void PlayPlayerModelWaitMotion()
	{
	}
}
