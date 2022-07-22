using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Audio;
using DG.Tweening;
using UnityEngine;

namespace Dpr.UI;

public class UISelectorWindow : MonoBehaviour
{
	public enum WindowItemID
	{
		CategorySelector,
		RankSelector,
		DecideButton,
		Num
	}

	private enum WindowFrameType
	{
		Selector,
		View
	}

	private enum WindowState
	{
		Deactive,
		Active,
		WaitStartDecideAnim,
		WaitCursorAnim,
		Closing
	}

	[SerializeField]
	private List<AWindowItem> windowItemList;

	[SerializeField]
	private GameObject[] frameObjArray;

	[SerializeField]
	private DOTweenAnimation scaleTween;

	private UIInputController inputController;

	private AudioManager audioManager;

	private WindowState windowState;

	private float timer;

	private float waitTime;

	private bool bActive;

	private Action onClosed;

	private Action<WindowItemID> onItemEvent;

	private RectTransform cursorRect;

	private GameObject arrowParent;

	private Cursor cursorFrame;

	private AWindowItem currentSelectItem;

	private int cursorIndex;

	private bool bIsOpen;

	public bool IsOpen => default(bool);

	public void Initialize()
	{
	}

	private void SetupCursor()
	{
	}

	public void OnFinalize()
	{
	}

	public T GetItem<T>(int index) where T : AWindowItem
	{
		return null;
	}

	private void Clear()
	{
	}

	private void ResetIndex()
	{
	}

	public void SetWindowActive(bool active)
	{
	}

	public void OpenSelectWindow(string[] contestNameArray, string[] rankNameArray, Action<WindowItemID> onEvent)
	{
	}

	public void ShowCategoryAndRank(string categoryName, string rankName)
	{
	}

	private void SetCategoryAndRankText(string categoryName, string rankName)
	{
	}

	private void SetFrameActive(WindowFrameType frameType, bool active)
	{
	}

	private void SetObjectActive(bool active)
	{
	}

	public void Close([Optional] Action onClosed)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateWindowActive(float deltaTime)
	{
	}

	private void UpdateWaitStartDecideAnim()
	{
	}

	private void UpdateWaitCursorAnim(float deltaTime)
	{
	}

	private bool CheckCursorAnimState(int state)
	{
		return default(bool);
	}

	private void OnItemEvent(AWindowItem item)
	{
	}

	public void OnCompleteRewind()
	{
	}

	private void CursorUp()
	{
	}

	private void CursorDown()
	{
	}

	private void SetCursorIndex(int index)
	{
	}

	private void UpdateCursor()
	{
	}

	private void SetCursorView(bool active)
	{
	}
}
