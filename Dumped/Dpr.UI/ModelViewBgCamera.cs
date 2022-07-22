using UnityEngine;

namespace Dpr.UI;

public class ModelViewBgCamera : MonoBehaviour
{
	[SerializeField]
	private Camera _camera;

	private RenderTexture _renderTexture;

	public RenderTexture renderTexture => null;

	public Camera camera => null;

	public void Setup()
	{
	}
}
