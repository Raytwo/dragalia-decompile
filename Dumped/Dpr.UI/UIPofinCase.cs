using System;
using System.Collections;
using System.Runtime.InteropServices;
using DPData;
using Dpr.Demo;
using Dpr.Message;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

namespace Dpr.UI;

public class UIPofinCase : UIWindow
{
	private static readonly Vector2 MsgWindowAnchorPos;

	[SerializeField]
	private UIPofinCase_CategorySelector categorySelector;

	[SerializeField]
	private UIPofinCase_TasteLump tasteLump;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private UIText subText;

	[SerializeField]
	private GameObject noDataTextObject;

	[SerializeField]
	private GameObject[] noDataDisableObjects;

	private PokemonParam selectedPokemonParam;

	private Action<ConditionParam> onResultCallback;

	private PoffinResult.SheetSheet1[] poffinResultDatas;

	private PoffinData[] poffinDatas;

	private int selectedIndex;

	public int selectPartyIndex;

	private float scrollPos;

	private UIPofinCase_ItemButton currentItemButton;

	private MessageMsgFile poffinMainMsgFile;

	private Coroutine removeNewIconCoroutine;

	private Demo_ModelViewer poffin3DModel;

	public ConditionParam conditionParam;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void Open(PokemonParam pokemonParam, Action<ConditionParam> onResult, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
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

	public void InputUpdate(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
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

	private void ReloadScrollView(int selectIndex = 0, float scrollPos = 0f)
	{
	}

	private void SetNoDataDisableObject(bool isActive)
	{
	}

	private void SetTaste(PoffinData poffinData)
	{
	}

	private void ShowItemContextMenu()
	{
	}

	private void DropPoffin(PoffinData poffinData)
	{
	}

	private IEnumerator LoadMD([Optional] Action onLoaded)
	{
		return null;
	}

	private string GetPoffinNameLabel(int mstId)
	{
		return null;
	}

	private string GetPoffinNameStr(int mstId)
	{
		return null;
	}

	private void SetupSubText(UIPofinCase_CategorySelector.Category category)
	{
	}

	private void PlayEatPoffinDemo(PokemonParam pokemonParam, PoffinData poffinData, [Optional] Action<ConditionParam> onComplete)
	{
	}

	private void OpenPokemonStatusWindow(PokemonParam pokemonParam, ConditionParam conditionParam, [Optional] Action onComplete)
	{
	}

	private IEnumerator SetupPoffin3D([Optional] Action onComplete)
	{
		return null;
	}

	private void LoadPoffin3DModel(PoffinData data)
	{
	}

	private void HidePoffin3DModel()
	{
	}
}
