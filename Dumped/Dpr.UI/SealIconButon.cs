using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealIconButon : MonoBehaviour
{
	private static readonly int GrayscaleAmountPropertyId;

	private const string CategoryIconAssetNameFormat = "cup_ico_sealcategory_{0:00}";

	public const int NoneCategoryId = 0;

	[SerializeField]
	private Shader iconShader;

	[SerializeField]
	protected Image iconImage;

	[SerializeField]
	private Image bodyImage;

	[SerializeField]
	private Sprite normalBodySprite;

	[SerializeField]
	private Sprite disableBodySprite;

	private void Awake()
	{
	}

	public void SetSealIcon(SealInfo sealInfo)
	{
	}

	public void SetCategoryIcon(int categoryId)
	{
	}

	public void SetEnable(bool isEnable)
	{
	}

	private void SetGrayscale(bool isGrayscale)
	{
	}
}
