using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class HpBar : MonoBehaviour
{
	private const float TweenDuration = 1f;

	[SerializeField]
	private Slider barSlider;

	[SerializeField]
	private Image bodyImage;

	[SerializeField]
	private Sprite[] bodySprites;

	[SerializeField]
	private float[] switchSpriteRatioValues;

	private TextMeshProUGUI hpText;

	private int spriteIndex;

	private int min;

	private int max;

	private float duration;

	private float afterDuration;

	public bool IsAnimation
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void SetHpText(TextMeshProUGUI text)
	{
	}

	public void Setup(int min, int max, int value, float duration = 1f, float afterDuration = 0f)
	{
	}

	public void SetHpImmidiate(int value)
	{
	}

	public void UpdateMaxHP(uint maxHp)
	{
	}

	public void SetDuration(float duration)
	{
	}

	public void SetHp(int hp, [Optional] Action onComplete, [Optional] Action<int> onUpdate)
	{
	}

	private void UpdateHp([Optional] Action<int> onUpdate)
	{
	}

	public HpStatus GetHpStatus(uint currentHP, uint maxHP)
	{
		return default(HpStatus);
	}
}
