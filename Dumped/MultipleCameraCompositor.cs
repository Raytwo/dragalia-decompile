using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class MultipleCameraCompositor : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	public static readonly int OPAQUE_DEPTHTEX_ID;

	public static readonly int GLOBAL_DEPTHTEX_ID;

	[SerializeField]
	private Camera _mainCamera;

	[SerializeField]
	private Camera[] _layerCameras;

	private Camera _camera;

	private RenderTexture _colorBufferTexture;

	private RenderTexture _depthBufferTexture;

	private CommandBuffer _resolveColorCB;

	private CommandBuffer _resolveDepthCB;

	public RenderTexture colorBufferTexture => null;

	public RenderTexture depthBufferTexture => null;

	public void OnViewportChange(int width, int height)
	{
	}

	private void OnEnable()
	{
	}

	private void OnReset()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void AddLayerCamera(Camera layerCamera)
	{
	}
}
