using System;
using Audio;
using Dpr.UI;
using UnityEngine;

namespace Dpr.GMS;

public class UIGMSPointDataScrollView : MonoBehaviour
{
	private readonly Vector3 HIDE_POS;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private UIText listTitle;

	[SerializeField]
	private UIText emptyMessage;

	[SerializeField]
	private Dpr.UI.Cursor cursorPtr;

	[SerializeField]
	private RectTransform cursorContent;

	[SerializeField]
	private RectTransform cursorRect;

	private AudioManager audioManager;

	private AUIGMSScrollItem lastSelectItem;

	private RectTransform scrollViewRect;

	private Vector2 defaultPosition;

	private int maxIndex;

	private int prevSelectIndex;

	private int currentSelectIndex;

	private bool bIsPlayingInput;

	private bool bInputEnabled;

	private Action<AUIGMSScrollItem> onRequiredItem;

	private Action<int> onMoveScrollView;

	private Action onSelect;

	private Action onCancel;

	private Action onReleaseInput;

	public int CurrentSelectIndex => default(int);

	public bool IsPlayingInput => default(bool);

	public AUIGMSScrollItem LastSelectItem => null;

	public void Initialize(Action<AUIGMSScrollItem> onRequiredItem, Action<int> onMoveScrollView, Action onSelect, Action onCancel, Action onReleaseInput)
	{
	}

	public void Setup(int dataNum, int startIndex)
	{
	}

	public void OnFinalize()
	{
	}

	public void SetInputEnabled(bool enabled)
	{
	}

	public void Show(string title = "")
	{
	}

	public void SettingCursor()
	{
	}

	public void Hide(Vector2 hidePosition)
	{
	}

	private void SetListTitle(string title)
	{
	}

	private void SetAnchoredPosition(Vector2 anchoredPosition)
	{
	}

	public void OnUpdate()
	{
	}

	private void UpdateInput()
	{
	}

	private void UpdateCursorPos()
	{
	}

	public void DoMoveScrollView(int moveIndex, bool playMoveSE = true)
	{
	}

	public void ReleaseInput()
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
}
