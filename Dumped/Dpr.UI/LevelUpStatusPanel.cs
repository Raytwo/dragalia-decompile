using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class LevelUpStatusPanel : MonoBehaviour
{
	private const float AppearMoveX = -10f;

	private const float FadeDuration = 0.3f;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private LevelUpStatusText[] levelUpStatusTexts;

	private int state;

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

	public bool IsShow
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

	public void SetStatus(UILevelUp.PokemonStatus beforeStatus, UILevelUp.PokemonStatus currentStatus)
	{
	}

	public void Show()
	{
	}

	public void HideImmediate()
	{
	}

	public void Next()
	{
	}

	private void FadeInAddStatusValues()
	{
	}

	private void FadeOutAddStatusValues()
	{
	}

	private void Hide()
	{
	}
}
