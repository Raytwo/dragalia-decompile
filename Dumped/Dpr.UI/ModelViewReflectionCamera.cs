using UnityEngine;

namespace Dpr.UI;

public class ModelViewReflectionCamera : MonoBehaviour
{
	[SerializeField]
	private Material _material;

	[SerializeField]
	private Camera _camera;

	private readonly int _propBgTexture;

	private readonly int _propAlpha;

	public Camera camera => null;

	private void Awake()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	public void SetBgTexture(Texture bgTexture)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
