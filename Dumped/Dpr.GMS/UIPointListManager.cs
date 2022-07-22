using System;
using System.Text;
using Audio;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIPointListManager : MonoBehaviour
{
	public enum ViewState
	{
		TradePointView,
		BrowsingPointView,
		BrowsingHistoryView,
		SelectHistoryDataView,
		None
	}

	private readonly Vector2 HIDE_SCROLL_VIEW_POSITION;

	private UIGMSPointDataScrollView tradePointScrollView;

	private UIGMSPointDataScrollView browsingPointScrollView;

	private UIGMSPointDataScrollView browsingPointHistoryScrollView;

	private GMSPointDataContainer dataContainerPtr;

	private ViewState viewState;

	private AudioManager audioManager;

	private Image listMaskImage;

	private StringBuilder markDataTitleSb;

	private StringBuilder emptyDataTitleSb;

	private StringBuilder emptyDataNameSb;

	private Action<PointHistoryDataModel> onSelectPointData;

	private Action onReleaseInput;

	private Action onCancelList;

	private GMSMode gmsMode;

	private int currentSelectPointIndex;

	private int browsingDataIndex;

	private bool bIsShowPointHistoryView;

	public bool IsShowPointHistoryView => default(bool);

	public bool PlayingPointDataList => default(bool);

	public int TradePointListIndex => default(int);

	public int BrowsingPointListIndex => default(int);

	public int BrowsingDataIndex => default(int);

	public int CurrentSelectPointHistoryIndex => default(int);

	public void Initialize(Action<PointHistoryDataModel> onSelectPointData, Action onReleaseInput, Action onCancelSelect)
	{
	}

	private void InitializeScrollView()
	{
	}

	public void Setup(GMSPointDataContainer dataContainer, int startTradeListIndex, int startBrowsingListIndex)
	{
	}

	public void OnFinalize()
	{
	}

	public void SetInputEnabled(bool enabled)
	{
	}

	public void OnChangeStateMain(GMSMode gmsMode, int index, bool canControllList)
	{
	}

	public void HideAllUI()
	{
	}

	public void ShowTradePointList(int index)
	{
	}

	private void HideTradePointList()
	{
	}

	private void ShowBrowsingPointList(int index)
	{
	}

	private void HideBrowsingPointList()
	{
	}

	public void ShowPointHistoryInTrade(int pointIndex)
	{
	}

	private void ShowHistoryList()
	{
	}

	public void HideBrowsingHistoryList()
	{
	}

	private void SetShowHistoryFlag(bool flag)
	{
	}

	public void OnDeleteAllHistoryData()
	{
	}

	public void MoveTradePointListIndex(int index)
	{
	}

	public void MovePointDataListIndex(int index)
	{
	}

	private void ReloadBrowsingPointList(int startIndex)
	{
	}

	public void ResetDataListItemView()
	{
	}

	private void ReloadHistoryViewData()
	{
	}

	public void OnUpdate()
	{
	}

	private void OnRequiredTradePointItem(AUIGMSScrollItem item)
	{
	}

	private void OnMoveTradePointView(int index)
	{
	}

	private void OnSelectTradePointItem()
	{
	}

	private void OnRequiredBrowsingPointItem(AUIGMSScrollItem item)
	{
	}

	private void UpdatePointDataIconView(GMSPointDataModel newData, UIBrowsingPointDataItem targetItem)
	{
	}

	private void OnMoveBrowsingPointView(int index)
	{
	}

	private void OnSelectBrowsingPointItem()
	{
	}

	private void OnRequiredHistoryDataItem(AUIGMSScrollItem item)
	{
	}

	private void OnSelectHistoryItem()
	{
	}

	private PointHistoryDataModel GetMonsData()
	{
		return null;
	}

	private void OnCancelHistory()
	{
	}

	private void OnReleaseListInput()
	{
	}
}
