using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class BoxPartyItem : BoxItem
{
	[SerializeField]
	private RectTransform _infoRoot;

	[SerializeField]
	private UIText _name;

	[SerializeField]
	private UIText _level;

	public override PokemonParam pokemonParam => null;

	public override void Setup(Param param)
	{
	}

	public override void Clear()
	{
	}

	public override void SetIconDefault(bool isShow = true)
	{
	}

	public override void Select(bool isSelect, bool isImmidiate = false)
	{
	}

	public void SelectOnlyIcon(bool isSelect, bool isImmidiate = false)
	{
	}

	public void ShowName(bool enabled)
	{
	}
}
