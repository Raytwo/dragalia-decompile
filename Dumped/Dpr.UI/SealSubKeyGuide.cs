using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealSubKeyGuide : MonoBehaviour
{
	[SerializeField]
	protected Image rotationIconImage;

	[SerializeField]
	private Sprite rotation2DIconSprite;

	[SerializeField]
	private Sprite rotation3DIconSprite;

	[SerializeField]
	private Image disableKeyGuidePreviewImage;

	public void Set(bool is3D)
	{
	}

	public void SetDisablePreviewGuide(bool isEnable)
	{
	}
}
