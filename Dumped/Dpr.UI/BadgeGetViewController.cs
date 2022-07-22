using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dpr.UI;

public class BadgeGetViewController : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	[SerializeField]
	private Transform modelCameraRoot;

	[SerializeField]
	private Camera modelCamera;

	[SerializeField]
	private EnvironmentController environmentController;

	[SerializeField]
	private EnvironmentSettings badgeCaseEnvironmentSettings;

	[SerializeField]
	private BadgeCaseObject badgeCaseObject;

	private bool isPlayingZoom;

	private float zoomTime;

	private float zoomProgressTime;

	private Vector3 defaultPosition;

	private Vector3 zoomPrevPosition;

	private Vector3 zoomNextPosition;

	private float defaultFOV;

	private float zoomPrevFOV;

	private float zoomNextFOV;

	public bool IsReady => default(bool);

	public void OnViewportChange(int screenWidth, int screenHeight)
	{
	}

	public void Initialize(UIInputController input)
	{
	}

	public void Dispose()
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

	public void Setup(RenderTexture renderTexture)
	{
	}

	public IEnumerator LoadBadgeGetAnimation()
	{
		return null;
	}

	public void PlayAnimationBadgeGet(string animeName)
	{
	}

	public void PlayEffectBadgeGet(int badgeNo)
	{
	}

	public void ZoomIn(float time, int badgeNo)
	{
	}

	public void ZoomOut(float time, int badgeNo)
	{
	}
}
