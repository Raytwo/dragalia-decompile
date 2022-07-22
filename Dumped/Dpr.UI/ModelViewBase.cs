using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ModelViewBase : MonoBehaviour
{
	[SerializeField]
	protected Image _imageModelBg;

	[SerializeField]
	protected RawImage _rawImageModelView;

	protected Transform _transBg;

	public RawImage rawImageModelView => null;

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public void Clear(bool isFinish = false)
	{
	}

	public void UpdateTexture()
	{
	}

	public void SetRawImageAlpha(float alpha)
	{
	}

	private void OnLateUpdate(float deltaTime)
	{
	}

	protected virtual void UpdateAnimation(float deltaTime)
	{
	}
}
