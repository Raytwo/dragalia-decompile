using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public sealed class BUITargetButton : BUIButtonBase<BUITargetButton>
{
	private enum ButtonType
	{
		Player,
		Enemy,
		Disable
	}

	[SerializeField]
	private PokemonIcon _pokeIcon;

	[SerializeField]
	private Image _sexIcon;

	[SerializeField]
	private Image _effectiveFrame;

	[SerializeField]
	private TextMeshProUGUI _effectiveText;

	[SerializeField]
	private Image _effectiveImage;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Sprite[] _bgSprite;

	[SerializeField]
	private Sprite[] _frameSprite;

	public bool IsGrayOut
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

	public bool Initialize(BTL_POKEPARAM btlParam, bool isSelected, bool isPlayerSide, [Optional] Sprite effectiveSprite, string effectiveStr = "")
	{
		return default(bool);
	}

	public bool InitializeForAppearanceDisable(BTL_POKEPARAM btlParam, bool isSelected, bool isPlayerSide, [Optional] Sprite effectiveSprite, string effectiveStr = "")
	{
		return default(bool);
	}

	private bool SetEnable(bool isPlayerSide)
	{
		return default(bool);
	}

	private void SetPokemon(BTL_POKEPARAM btlParam, bool isPlayerSide)
	{
	}

	private void SetDisablePokemon()
	{
	}

	private bool SetDisable()
	{
		return default(bool);
	}

	private bool SetAppearanceDisable()
	{
		return default(bool);
	}

	private void SetEffective(bool isPlayerSide, bool isSelected, [Optional] Sprite effectiveSprite, string effectiveStr = "")
	{
	}
}
