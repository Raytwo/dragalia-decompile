using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Trainer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealTemplateWindow : UIWindow
{
	private class SealTemplateInfo
	{
		public int SealId;

		public int Count;
	}

	private static readonly Vector2 MsgWindowAnchorPos;

	[SerializeField]
	private UIText trainerTitleText;

	[SerializeField]
	private UIText trainerNameText;

	[SerializeField]
	private Image trainerImage;

	[SerializeField]
	private Image trainerEmblemImage;

	[SerializeField]
	private GameObject playerObject;

	[SerializeField]
	private GameObject npcObject;

	[SerializeField]
	private RectTransform pagingLeftArrow;

	[SerializeField]
	private RectTransform pagingRightArrow;

	[SerializeField]
	private UIText listPageNumberText;

	[SerializeField]
	private UIPagingListView listView;

	[SerializeField]
	private CapsuleViewController capsuleViewController;

	private List<SealTemplateInfo> sealTemplateInfos;

	private CapsuleInfo currentCapsuleInfo;

	private Keyguide keyguide;

	private bool isShowCapsuleView;

	public bool IsCopyRequest
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void OnCreate()
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}

	public void Open(SealTemplateID sealTemplateId, UIWindowID prevWindowId)
	{
	}

	public void Open(string playerName, CapsuleInfo capsuleInfo, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
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

	private void OnUpdateCapsuleView(float deltaTime)
	{
	}

	private void OnUpdateListView(float deltaTime)
	{
	}

	private void OnUpdatePreview(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void SetupTrainer(SealTemplateID sealTemplateId)
	{
	}

	private void SetupPlayer(string playerName, CapsuleInfo capsuleInfo)
	{
	}

	private void SetupSealData(CapsuleInfo capsuleInfo)
	{
	}

	private void SetupListView()
	{
	}

	private void OnReverseCapsule2D()
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void UpdateListPageNumberText()
	{
	}

	private void OpenContextMenu()
	{
	}

	private IEnumerator ShowPreview()
	{
		return null;
	}

	private IEnumerator HidePreview()
	{
		return null;
	}
}
