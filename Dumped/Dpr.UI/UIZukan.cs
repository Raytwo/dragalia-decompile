using System.Collections;
using System.Collections.Generic;
using DPData;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIZukan : UIWindow
{
	public enum ShowZukanType
	{
		None,
		Shinou,
		Zenkoku
	}

	private const string ZukanMessageFileName = "ss_pokedex";

	private const string ShinouZukanNameMessageLabel = "SS_pokedex_183";

	private const string NationalZukanNameMessageLabel = "SS_pokedex_184";

	private const string NumberSortMessageLabel = "SS_pokedex_092";

	private const string NameSortMessageLabel = "SS_pokedex_093";

	private const string HeavierSortMessageLabel = "SS_pokedex_094";

	private const string LighterSortMessageLabel = "SS_pokedex_095";

	private const string HigherSortMessageLabel = "SS_pokedex_096";

	private const string LowerSortMessageLabel = "SS_pokedex_097";

	private const string CancelSortMessageLabel = "SS_pokedex_098";

	private const string NumberSortNameMessageLabel = "SS_pokedex_086";

	private const string NameSortNameMessageLabel = "SS_pokedex_087";

	private const string HeavierSortNameMessageLabel = "SS_pokedex_088";

	private const string LighterSortNameMessageLabel = "SS_pokedex_089";

	private const string HigherSortNameMessageLabel = "SS_pokedex_090";

	private const string LowerSortNameMessageLabel = "SS_pokedex_091";

	private const int ScrollListUpDownMoveValue = 1;

	private const int ScrollListLeftRightMoveValue = 9;

	private const float SliderIconRotateDuration = 0.3f;

	private const float SliderIconRotateValue = 15f;

	private const int StopLoadModelCount = -1;

	private const int StartLoadModelCount = 3;

	private const int SwitchZukanButton = 192;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	[SerializeField]
	private RectTransform header;

	[SerializeField]
	private Image headerImage;

	[SerializeField]
	private Sprite[] headerSprites;

	[SerializeField]
	private Image fadeImage;

	[SerializeField]
	private RectTransform sliderIconRectTransform;

	[SerializeField]
	private UIScrollView listScrolView;

	[SerializeField]
	private Image titleImage;

	[SerializeField]
	private UIText getCountText;

	[SerializeField]
	private UIText foundCountText;

	[SerializeField]
	private UIText sortNameText;

	[SerializeField]
	private ZukanDescriptionPanel descriptionPanel;

	[SerializeField]
	private RectTransform descriptionHideModelViewPosition;

	[SerializeField]
	private RectTransform descriptionHideInfoButtonPosition;

	[SerializeField]
	private RectTransform contextMenuPosition;

	private UIMsgWindowController msgWindowController;

	private List<ZukanInfo> zukanInfoList;

	private List<ZukanInfo> viewZukanInfoList;

	private List<ZukanInfo> getZukanInfoList;

	private Dictionary<int, int> nameSortOrderDic;

	private ZukanPokemonInfoButton.ViewType buttonViewType;

	private ZukanPokemonInfoButton selectedZukanPokemonInfoButton;

	private bool canSwitchZukan;

	private bool canShowDescription;

	private bool isWaitUpdate;

	private bool isShowZenkokuZukan;

	private int loadModelCount;

	private ShowZukanType showZukanType;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId, MonsNo showDescriptionMonsNo = MonsNo.NULL, ShowZukanType showZukanType = ShowZukanType.None)
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId, MonsNo showDescriptionMonsNo = MonsNo.NULL)
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

	private void OnUpdateDefault()
	{
	}

	private void OnUpdateDescriptionPanel()
	{
	}

	private void UpdateLoadModelRequest(float deltaTime)
	{
	}

	private void Initialize()
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void SetupZukan()
	{
	}

	private void ReloadZukanList(MonsNo selectMonsNo = MonsNo.NULL)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void HideKeyGuide()
	{
	}

	private void RotateSliderIcon(bool isNegative)
	{
	}

	private void RequestLoadModel()
	{
	}

	private void SwitchZukan()
	{
	}

	private void ShowHabitatWindow(PokemonParam pokemonParam)
	{
	}

	private void ShowMovingWindow(PokemonParam pokemonParam)
	{
	}

	private void ShowCompareWindow()
	{
	}

	private void Rating()
	{
	}

	private void ShowSortListContextMenu()
	{
	}

	private void SortList(ZUKAN_SORT_TYPE sortType)
	{
	}

	private void SetSortNameText(ZUKAN_SORT_TYPE sortType)
	{
	}

	private void CreateNameSortOrderData()
	{
	}

	private void SaveWorkCurrent()
	{
	}

	private void ShowDescriptionPanel()
	{
	}

	private void HideDescriptionPanel()
	{
	}
}
