using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace SmartPoint.Rendering;

[ExecuteAlways]
public class PostProcessFilter : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	[SerializeField]
	private ImageEffectObject[] _effects;

	[SerializeField]
	private Camera _camera;

	private RenderTexture _renderTexture;

	private CommandBuffer[] _commandBuffers;

	public void OnViewportChange(int width, int height)
	{
	}

	public T GetEffect<T>() where T : ImageEffectObject
	{
		return null;
	}

	public void OnEnable()
	{
	}

	public void Reset()
	{
	}

	public void OnPreCull()
	{
	}

	private void OnDisable()
	{
	}
}
