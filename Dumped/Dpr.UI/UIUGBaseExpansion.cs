using System;
using System.Collections;
using Dpr.SubContents;
using Pml.UgFather;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIUGBaseExpansion : UIWindow
{
	[Serializable]
	public struct UIRequiredItem
	{
		public Image itemIconImage;

		public UIText itemNameText;

		public UIText priceText;

		public UIText haveCountText;
	}

	private const int NOT_ENOUGHT_COLOR_INDEX = 1;

	[SerializeField]
	private UIRequiredItem[] uiRequiredItemArray;

	[SerializeField]
	private UIText expansionInfoText;

	private UgFatherDataManager.RequiredExpansionItemData[] requiredItemDataArray;

	private ShowMessageWindow msgWindow;

	private bool canExpansion;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void Setup()
	{
	}

	private void StartMessage()
	{
	}

	private void OnSelectYes()
	{
	}

	private void UpdatePlayerItem()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	private IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}
}
