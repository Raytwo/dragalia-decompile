using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UISeal : UIWindow
{
	private enum ActionType
	{
		None,
		Copy,
		Swap,
		CopyOnly
	}

	private static readonly Vector2 MsgWindowAnchorPos;

	public const string QuestionCapsuleActionMessageLabel = "DLP_stickers_003";

	public const string CantAffixSealMoreMessageLabel = "DLP_stickers_005";

	public const string QuestionRemoveAllAffixSealsMessageLabel = "DLP_stickers_007";

	public const string QuestionSwitchModeMessageLabel1 = "DLP_stickers_035";

	public const string QuestionSwitchModeMessageLabel2 = "DLP_stickers_036";

	public const string QuestionCopySealMessageLabel = "DLP_stickers_028";

	public const string DontCopyExistAffixSealMessageLabel = "DLP_stickers_029";

	public const string DontCopySameCapsuleMessageLabel = "DLP_stickers_030";

	public const string QuestionCopyPartSeal1MessageLabel = "DLP_stickers_031";

	public const string QuestionCopyPartSeal2MessageLabel = "DLP_stickers_032";

	public const string ResultCopySealMessageLabel = "DLP_stickers_033";

	public const string DontCopyNotEnoughSealMessageLabel = "DLP_stickers_034";

	public const string RemoveAllAffixSealResultMessageLabel = "DLP_stickers_022";

	public const string CantAffixSealMessageLabel = "DLP_stickers_025";

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private GameObject headerObject;

	[SerializeField]
	private RectTransform capsuleBaseRectTransform;

	[SerializeField]
	private UIScrollView capsuleScrollView;

	[SerializeField]
	private CapsuleViewController capsuleViewController;

	[SerializeField]
	private GameObject listSceneObject;

	[SerializeField]
	private SealEditSceneController sealEditSceneController;

	[SerializeField]
	private RectTransform contextMenuPosition;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private UIMsgWindowController msgWindowController;

	private Keyguide keyguide;

	private CapsuleInfo[] capsuleInfos;

	private CapsuleItemButton selectedCapsuleItemButton;

	private CapsuleInfo actionSelectedCapsuleInfo;

	private Vector3 initialCapsuleBaseAnchorPosition;

	private int currentSelectIndex;

	private float currentScrollPosition;

	private bool isCopyOnly;

	private bool isUnionRoomView;

	private bool isCallFromEvent;

	private bool isEditMode;

	private ActionType actionType;

	private Action<bool> onCopyOnlyEndCallback;

	public override void OnCreate()
	{
	}

	public void Open(bool isCallFromEvent = false, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void OpenCopyOnly(CapsuleInfo capsuleInfo, bool isCallFromEvent = false, [Optional] Action<bool> onEndCallback, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void OpenUnionRoomView(CapsuleInfo[] capsuleInfos, UIWindowID prevWindowId = (UIWindowID)(-2))
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

	private void OnUpdateSelect(float deltaTime)
	{
	}

	private void OnUpdateDefault(float deltaTime)
	{
	}

	private void OnUpdateCopyOnly(float deltaTime)
	{
	}

	private void OnUpdatePreview(float deltaTime)
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

	private void ReloadScrollView()
	{
	}

	private void SetupCapsuleView()
	{
	}

	private void ShowEditMode(CapsuleInfo capsuleInfo)
	{
	}

	private void HideEditMode()
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

	private void StartRemoveAllAffixSeals(CapsuleItemButton capsuleItemButton)
	{
	}

	private void StartCapsuleAction(ActionType actionType, CapsuleItemButton capsuleItemButton)
	{
	}

	private void EndCapsuleAction(CapsuleItemButton capsuleItemButton)
	{
	}

	private void SwitchMode()
	{
	}

	private void OnReverseCapsule2D()
	{
	}

	private void CopyOnlyDecide()
	{
	}

	private void CopyCapsule(CapsuleInfo sourceCapsule, CapsuleInfo destCapsule, bool isQuestionBeforeCopy, Action onCancel, Action onEnd)
	{
	}

	private void OpenCapsuleContextMenu(CapsuleItemButton capsuleItemButton)
	{
	}

	private void OpenContextMenu(ContextMenuID[] contextMenuIDs, Action<ContextMenuID> onSelected, Vector2 pivot, Vector3 pos, [Optional] Action onClosed)
	{
	}
}
