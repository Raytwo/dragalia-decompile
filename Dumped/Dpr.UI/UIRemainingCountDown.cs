using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIRemainingCountDown : MonoBehaviour
{
	[SerializeField]
	private Image countImage;

	[SerializeField]
	private int startCount;

	private DOTweenAnimation[] tweenArray;

	private Sprite[] countSprArray;

	private RectTransform imageRect;

	private Vector3 initScale;

	private float initAlpha;

	private bool bIsActive;

	private void Start()
	{
	}

	private void SetupCountSpr()
	{
	}

	public void DOCountDown(int count)
	{
	}

	public void Deactivate()
	{
	}

	private void OnDestroy()
	{
	}
}
