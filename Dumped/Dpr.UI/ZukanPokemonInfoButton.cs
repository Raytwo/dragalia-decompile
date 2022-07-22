using System.Runtime.CompilerServices;
using Dpr.Message;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanPokemonInfoButton : MonoBehaviour, IUIButton
{
	public enum ViewType
	{
		No,
		Weight,
		Height
	}

	private const string ZukanMessageFileName = "ss_pokedex";

	private const string ZukanNoMessageLabel = "SS_pokedex_131";

	[SerializeField]
	private Image baseImage;

	[SerializeField]
	private Image getIconImage;

	[SerializeField]
	private Image unknownIconImage;

	[SerializeField]
	private PokemonIcon pokemonIcon;

	[SerializeField]
	private UIText noText;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private Sprite unselectBaseSprite;

	[SerializeField]
	private Sprite selectedBaseSprite;

	private int index;

	private RectTransform rectTransform;

	public ZukanInfo Info
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UIText NameText => null;

	public bool IsAllowShowDescription
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

	public int GetIndex()
	{
		return default(int);
	}

	public void SetIndex(int index)
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool isActive)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void SetInfo(ZukanInfo zukanInfo, ViewType viewType)
	{
	}

	public void SetViewType(ViewType viewType)
	{
	}

	public void ChangeLanguage(MessageEnumData.MsgLangId langId)
	{
	}

	public void UpdatePokemonIcon(PokemonParam pokemonParam)
	{
	}

	public void CopyTo(ZukanPokemonInfoButton button)
	{
	}
}
