using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppCalenderDay : PoketchButton
{
	[SerializeField]
	private RectTransform _dayGroup;

	[SerializeField]
	private RectTransform _sunDayGroup;

	[SerializeField]
	private Image _dayImage01;

	[SerializeField]
	private Image _dayImage10;

	[SerializeField]
	private Image _sunDayImage01;

	[SerializeField]
	private Image _sunDayImage10;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Image _selectImage;

	[SerializeField]
	private Sprite[] _numberSprites;

	[SerializeField]
	private Sprite[] _numberSpritesSunday;

	[SerializeField]
	private bool _sunday;

	public int Day
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsSelect
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

	public void SetDay(int day)
	{
	}

	public void SetToday(bool today)
	{
	}

	public void SetSelectDay(bool select)
	{
	}

	private void OnValidate()
	{
	}
}
