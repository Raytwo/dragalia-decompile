using System.Collections;
using System.Runtime.InteropServices;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class PokemonWindow : PokemonWindowBase
{
	public class Param : BaseParam
	{
	}

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private RectTransform _gotoBox;

	private WazaNo _fieldWazaNo;

	private PokemonPartyItem _fieldWazaPartyItem;

	private bool _itemSwapSelect;

	private int _checkFormChangeCount;

	private Coroutine _coroutineFormChangeLoadModel;

	private Param _param;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private bool IsSwapMode()
	{
		return default(bool);
	}

	private bool IsEnableBox()
	{
		return default(bool);
	}

	private void OnSelectChangedPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void SetupKeyguide()
	{
	}

	private bool HasItemByParty()
	{
		return default(bool);
	}

	private void SetupModelView(PokemonParam pokemonParam)
	{
	}

	private void OnClickPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void ShowPartyItemName(bool enabled)
	{
	}

	private void OpenContextMenu(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void FieldWaza(WazaNo fieldWazaNo, PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void OpenBagWindow(UIBag.ModeType modeType, PokemonParam selectPokemonParam)
	{
	}

	private void GiveItem(bool isChain)
	{
	}

	private void PokemonSwap()
	{
	}

	private void SelectPokemonByFieldWaza(WazaNo wazaNo, PokemonPartyItem partyItem)
	{
	}

	private void UseFieldWaza(PokemonPartyItem partyItem)
	{
	}

	private void CheckFormChange(PokemonPartyItem pokemonPartyItem, [Optional] UnityAction onComplete)
	{
	}

	private void SetInputEnable(bool enable)
	{
	}
}
