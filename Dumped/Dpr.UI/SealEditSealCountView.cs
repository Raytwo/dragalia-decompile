using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealEditSealCountView : MonoBehaviour
{
	[SerializeField]
	private Image limitNumber02Image;

	[SerializeField]
	private Image limitNumber01Image;

	[SerializeField]
	private Sprite[] limitNumberSprites;

	[SerializeField]
	private Image countNumber02Image;

	[SerializeField]
	private Image countNumber01Image;

	[SerializeField]
	private Sprite[] countNumberSprites;

	[SerializeField]
	private Image maxIconImage;

	private int maxCount;

	public void Initialize(int maxCount)
	{
	}

	public void Set(int count)
	{
	}

	public void SetCountNumberColor(Color color)
	{
	}

	public void SetLimitNumberColor(Color color)
	{
	}

	private void SetNumberSprite(int num, Image digit2Image, Image digit1Image, Sprite[] numberSprites)
	{
	}
}
