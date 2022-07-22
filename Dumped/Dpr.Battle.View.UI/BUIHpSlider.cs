using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUIHpSlider : MonoBehaviour
{
	public enum HpStatus
	{
		Dead,
		Danger,
		Allert,
		Normal
	}

	public const float HpAllert = 0.5f;

	public const float HpDanger = 0.25f;

	public const float HpDead = 0f;

	[SerializeField]
	private Slider _hpSlider;

	[SerializeField]
	private Image _hpImage;

	[SerializeField]
	private Sprite _hpNormal;

	[SerializeField]
	private Sprite _hpAllert;

	[SerializeField]
	private Sprite _hpDanger;

	private const float _actionAfterDelay = 0.25f;

	private Ease _ease;

	private float _duration;

	public bool IsPlaying
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

	public static HpStatus GetHpStatus(uint currentHP, uint maxHP)
	{
		return default(HpStatus);
	}

	public void Initialize(uint currentHP, uint maxHP, Ease ease, float duration)
	{
	}

	public bool SetHpBar(uint currentHP, uint maxHP)
	{
		return default(bool);
	}

	public bool ChangeBarSprite(Sprite sp)
	{
		return default(bool);
	}

	public void PlayDamage(uint afterHP)
	{
	}
}
