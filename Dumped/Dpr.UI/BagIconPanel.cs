using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BagIconPanel : MonoBehaviour
{
	[SerializeField]
	private Image headerIconImage;

	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Image overlapIconImage;

	private Sprite[] overlapSprites;

	public void Initialize(bool isMale)
	{
	}

	public void Set(int id)
	{
	}
}
