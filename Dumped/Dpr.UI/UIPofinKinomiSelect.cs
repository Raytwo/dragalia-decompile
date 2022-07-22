using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Dpr.Item;
using Dpr.MsgWindow;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIPofinKinomiSelect : UIWindow
{
	public static bool isPofinPlaying;

	public static bool isPofinEnd;

	[SerializeField]
	private BagItemPanel bagItemPanel;

	[SerializeField]
	private RectTransform startButton;

	private ItemListMemory itemListMemory;

	private ItemInfo.CategoryType[] categoryTypes;

	private UIMsgWindowController msgWindowController;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private List<BagItemButton> GrayButtons;

	private bool isEnd;

	private bool isSortSelect;

	[SerializeField]
	private Image[] berryImages;

	private List<ItemInfo> itemList;

	private Dpr.MsgWindow.MsgWindow msgWindow;

	private HorizontalLayoutGroup horizontalLayout;

	[SerializeField]
	private int posy;

	private List<Tweener> Tws;

	private Keyguide.Param keyguideParam;

	private const string QuestionSortMessageLabel = "SS_bag_083";

	private const string NewSortMessageLabel = "SS_bag_079";

	private const string CancelSortMessageLabel = "SS_bag_082";

	private const string FavoriteSortMessageLabel = "SS_bag_081";

	private const string TypeSortMessageLabel = "SS_bag_077";

	private const string NameSortMessageLabel = "SS_bag_078";

	private const string NumberSortMessageLabel = "SS_bag_080";

	private const string TypeSortResultMessageLabel = "SS_bag_084";

	private const string NameSortResultMessageLabel = "SS_bag_085";

	private const string NewSortResultMessageLabel = "SS_bag_088";

	private const string FavoriteSortResultMessageLabel = "SS_bag_087";

	private const string NumberSortResultMessageLabel = "SS_bag_086";

	private bool isPushB => default(bool);

	private bool isPushA => default(bool);

	private bool isPushX => default(bool);

	private bool isPushY => default(bool);

	private bool isPushPlus => default(bool);

	public override void OnCreate()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateDefault()
	{
	}

	private void KinomiUndo()
	{
	}

	private void KinomiRedo()
	{
	}

	private Image GetEmptyImage()
	{
		return null;
	}

	private void SetSprite(Image image, ItemInfo item)
	{
	}

	public static Sprite GetKinomiImage(int kinomiID)
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}

	private bool RemoveLastItem()
	{
		return default(bool);
	}

	private void ShowConfirmMessage([Optional] Action OnCancel)
	{
	}

	private void GotoCooking()
	{
	}

	public void Open(bool isResult = false)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	public IEnumerator OpOpen(bool isResult)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	public void EnterStartButton()
	{
	}

	public void ExitStartButton()
	{
	}

	private void StartSortItems()
	{
	}

	private void SortItems(ItemInfo.SortType sortType)
	{
	}

	private void ShowSortResultMessage(ItemInfo.SortType sortType)
	{
	}
}
