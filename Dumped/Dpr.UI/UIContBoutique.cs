using System;
using System.Collections;
using System.Collections.Generic;
using Dpr.Contest;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIContBoutique : ShopBase, IContestUIWindow
{
	[SerializeField]
	private MenuHeader _header;

	[SerializeField]
	private CharacterModelView _modelView;

	[SerializeField]
	private float modelOffsetZ;

	private List<ShopBoutiqueItemItem.Param> _itemParams;

	private ShopBoutiqueItemItem _selectShopItem;

	private KeyGuideCreater keyguide;

	private Action onFinish;

	private ShopBoutique.BoutiqueType _boutiqueType;

	private ContestMenuEventID _resultEventID;

	private int _selectIndex;

	private bool _bIsSelected;

	private bool _bIsOpen;

	private bool _bIsOpening;

	public bool IsOpen => default(bool);

	public ContestMenuEventID ResultEventID => default(ContestMenuEventID);

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId, Action onFinish)
	{
	}

	public void OpenMultiMode(UIWindowID prevWindowID, string minutStr, string secondStr)
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void InsertSecondContestDress(bool isMale)
	{
	}

	private int FindStartIndex()
	{
		return default(int);
	}

	protected void OnUpdate(float deltaTime)
	{
	}

	protected bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void SetupModelView()
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnDecidedSelectItem()
	{
	}

	private void ChangeSelectDressIcon()
	{
	}

	public void CloseWindow()
	{
	}

	private IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	public void SetTimeCount(string minutStr, string secondStr)
	{
	}
}
