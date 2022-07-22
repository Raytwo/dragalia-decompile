using DPData;
using TMPro;
using UnityEngine;

namespace Dpr.MsgWindow;

public class WindowUIContents : MonoBehaviour
{
	private Sprite[] windowBGSprArrayPtr;

	private Sprite[] windowFrameSprArrayPtr;

	private UIWindowLayout uiLayout;

	private UIRoadsign uiRoadsign;

	private UISpeakerName uiSpeakerName;

	private UIKeywaitIcon uiKeywaitIcon;

	private UILoadingIcon uiLoadingIcon;

	private GameObject uiContent;

	private Vector2 defaultWindowAnchorPos;

	private float defaultMessagePosX;

	private int defaultSortingOrder;

	private bool isPrevNetworkFlag;

	private bool isMoveMessagePosX;

	public int SortingOrder => default(int);

	public void Initialize(MsgWindowDataModel dataModel, MsgWindowConfig config, MsgWindowDataContainer dataContainer)
	{
	}

	public void SetupAssetBundleResource(MsgWindowDataContainer dataContainer)
	{
	}

	public void OnFinalize()
	{
	}

	public void SetupLayout(Vector2? anchorPos, int sortingOrder, bool isNetwork)
	{
	}

	public void ChangeFontAsset(TMP_FontAsset useFontAsset)
	{
	}

	private void SetWindowPosition(Vector2? anchorPos)
	{
	}

	private void SetSortingOrder(int sortingOrder)
	{
	}

	public void SetWindowWidth(float width)
	{
	}

	public void ChangeWndType(WINTYPE winType)
	{
	}

	public void ResetDefaultWndFrame()
	{
	}

	public void SetBoardWndFrame(MsgWindowDataModel.WindowFrameType winType)
	{
	}

	public void SetNetworkFrame()
	{
	}

	public void ShowRoadsign(RoadsignViewData viewData, float posX)
	{
	}

	private void ResetOffsetPosX()
	{
	}

	public void ShowKeywaitIcon()
	{
	}

	public void HideKeywaitIcon()
	{
	}

	public void UpdateKeywaitIcon(float deltaTime)
	{
	}

	public void ShowLoadingIcon()
	{
	}

	public void HideLoadingIcon()
	{
	}

	public void ShowSpeakerName(string speakerName)
	{
	}

	public void HideSpeakerName()
	{
	}
}
