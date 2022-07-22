using System.Collections;
using System.Collections.Generic;
using Dpr.Item;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIKinomi : UIWindow
{
	private const string PoffinMessageFileName = "dp_poffin_main";

	[SerializeField]
	private SpriteAtlas iconSpriteAtlas;

	[SerializeField]
	private RectTransform upArrowTransform;

	[SerializeField]
	private RectTransform downArrowTransform;

	[SerializeField]
	private UIText numberText;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private UIText sizeText;

	[SerializeField]
	private UIText hardnessText;

	[SerializeField]
	private UIText descriptionText;

	[SerializeField]
	private RaderChart raderChart;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private UIMsgWindowController msgWindowController;

	private List<KinomiInfo> kinomiInfos;

	private IndexSelector indexSelector;

	public int SelectedKinomiItemId => default(int);

	public override void OnCreate()
	{
	}

	public void Open(List<ItemInfo> itemInfoList, ItemInfo selectedItemInfo, UnityAction<UIWindow> onClosedAction)
	{
	}

	public IEnumerator OpOpen()
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

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateDefault(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void UpdateKinomiInfo()
	{
	}
}
