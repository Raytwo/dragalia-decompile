using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UINetworkIcon : MonoBehaviour
{
	private DOTweenAnimation[] matchingIconTweens;

	private DOTweenAnimation[] attentionIconTweens;

	private GameObject matchingIconObj;

	private GameObject attentionIconObj;

	private Image matchingIconImage;

	private Image attentionIconImage;

	private RectTransform matchingIconRect;

	private RectTransform attentionIconRect;

	public Vector3 MatchingIconPos => default(Vector3);

	public void Initialize()
	{
	}

	public void ShowMatchingIcon()
	{
	}

	public void HideMatchingIcon()
	{
	}

	public void ShowAttentionIcon()
	{
	}

	public void HideAttentionIcon()
	{
	}
}
