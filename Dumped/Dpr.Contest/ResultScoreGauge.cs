using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class ResultScoreGauge : MonoBehaviour
{
	private UIText nameText;

	private RectTransform rect;

	private Image gaugeImage;

	private Image medalImage;

	private Animator medalAnimator;

	public void Create(int index)
	{
	}

	public void Setup(string name)
	{
	}

	public void SetGaugeRatio(float ratio)
	{
	}

	public void ShowMedal(Sprite medalSpr, int animHash)
	{
	}
}
