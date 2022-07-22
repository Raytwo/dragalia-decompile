using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace Dpr.Battle.View;

public sealed class BattleMultipleCameraCompositor : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	public enum CameraIndex
	{
		ScreenEffect,
		CharaEffect,
		Depth
	}

	private const CameraEvent FIELD_DEPTH_COMMAND_BUFFER_EVENT = CameraEvent.BeforeForwardAlpha;

	private const CameraEvent RESOLVE_COLOR_COMMAND_BUFFER_EVENT = CameraEvent.BeforeForwardOpaque;

	private const CameraEvent RESOLVE_DEPTH_COMMAND_BUFFER_EVENT = CameraEvent.BeforeForwardAlpha;

	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private Camera _mainCamera;

	[SerializeField]
	private Camera[] _layerCameras;

	private RenderTexture _colorBufferTexture;

	private RenderTexture _depthBufferTexture;

	private RenderTexture _copyDepthBufferTexture;

	private CommandBuffer _fieldDepthBuffer;

	private CommandBuffer _resolveColorCB;

	private CommandBuffer _resolveDepthCB;

	public RenderTexture ColorBufferRT => null;

	public RenderTexture DepthBufferRT => null;

	public RenderTexture CopyDepthBufferRT => null;

	public Camera GetLayerCamera(CameraIndex index)
	{
		return null;
	}

	public void OnViewportChange(int screenWidth, int screenHeight)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnReset()
	{
	}

	public void OnLateUpdate(float deltaTime)
	{
	}

	public void AddLayerCamera(Camera layerCamera)
	{
	}
}
