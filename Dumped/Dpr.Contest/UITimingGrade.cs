using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class UITimingGrade : MonoBehaviour
{
	private readonly Vector3 INACTIVE_POS;

	private readonly Vector3 VECTOR_ONE;

	private DOTweenAnimation[] tweenArray;

	private Image gardeImage;

	private RectTransform rect;

	private float initPosY;

	private bool isInitialize;

	private bool isActive;

	public bool IsActive => default(bool);

	public void Initialize()
	{
	}

	public void Show(Sprite spr)
	{
	}

	private void ResetParameter()
	{
	}

	public void OnComplete()
	{
	}
}
