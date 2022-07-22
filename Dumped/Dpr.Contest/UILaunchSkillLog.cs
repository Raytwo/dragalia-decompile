using DG.Tweening;
using UnityEngine;

namespace Dpr.Contest;

public class UILaunchSkillLog : MonoBehaviour
{
	[SerializeField]
	private Vector2 itemSize;

	private readonly Vector2 HIDE_POS;

	private DOTweenAnimation moveTween;

	private DOTweenAnimation fadeTween;

	private RectTransform rect;

	private RectTransform contentRect;

	private GameObject appealObj;

	private Vector2 frameSize;

	private float timer;

	private float showDuration;

	private int orderCount;

	private bool bIsSameType;

	private bool bShow;

	public bool Showing => default(bool);

	public void Create(bool isPlayer, string playerName, Sprite frameSpr, Sprite wazaTypeIconSpr)
	{
	}

	public void ResetParam()
	{
	}

	public void ShowSkillLog(bool isSameType, float showTime)
	{
	}

	public void MovePosition()
	{
	}

	public void Hide()
	{
	}

	private void HideAppealObj()
	{
	}

	public void UpdateShowLogTime(float deltaTime)
	{
	}

	public void OnCompleteTween()
	{
	}
}
