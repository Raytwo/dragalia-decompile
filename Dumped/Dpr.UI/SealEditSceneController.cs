using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class SealEditSceneController : MonoBehaviour
{
	private enum DecideActionResult
	{
		None,
		Default,
		AffixedSeal,
		PickedSeal
	}

	private const float CursorMoveValue = 20f;

	[SerializeField]
	private SealEditCursor cursor;

	[SerializeField]
	private RectTransform cursorMovableRectTransform;

	[SerializeField]
	private CapsuleViewController capsuleViewController;

	[SerializeField]
	private RectTransform sealPalletRectTransform;

	[SerializeField]
	private RectTransform pullDownRectTransform;

	[SerializeField]
	private GameObject switchPalletIconObject;

	[SerializeField]
	private SealEditSealCountView sealEditSealCountView;

	private UIInputController input;

	private UIMsgWindowController msgWindowController;

	private Keyguide keyguide;

	private CapsuleInfo currentCapsuleInfo;

	private Dictionary<int, SealInfo[]> categoryzedSealInfoDic;

	private SealCategoryButton[] categoryButtons;

	private SealCategoryButton pullDownCategoryButton;

	private SealButton[] pullDownSealButtons;

	private int[] palletCategoryIds;

	private IndexSelector categoryIndexSelector;

	private IndexSelector pullDownIndexSelector;

	private Transform currentHitTransform;

	private Vector3 beforeCursorPosition;

	private bool isShowPullDown;

	private bool isBindCategoryTab;

	private bool canSwitchPallet;

	private bool isAllowSwicthPallet;

	private bool isHoverCategoryTab;

	private bool isHoverSetSealGridCell;

	private bool isAnimation;

	private int selectPalletIndex;

	private int maxPalletIndex;

	private Capsule2DGridCell selectedCapsule2DGridCell;

	private Capsule2DGridCell pickedCapsule2DGridCell;

	private int pickedAffixSealId;

	private int pickedLatestPalletIndex;

	private int pickedLatestCategoryIndex;

	private Seal3DObject selectedSeal3DObject;

	private Seal3DObject pickedSeal3DObject;

	private GameObject dummyPalletObject;

	private Keyguide.Param keyguideParam;

	private List<KeyguideID> keyguideIdList;

	private Vector3[] rectCorners;

	private RaycastHit2D[] raycastHit2Ds;

	private bool isChangeRotate;

	private bool canResetRotate => default(bool);

	public Capsule2DViewController Capsule2DViewController => null;

	public Capsule3DViewController Capsule3DViewController => null;

	public bool IsShow
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

	public bool IsAllowPreview => default(bool);

	public Action OnSelectSealWhenAffixSealMaxCount
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public IEnumerator Initialize(UIInputController input, UIMsgWindowController msgWindowController)
	{
		return null;
	}

	public void SetKeyguid(Keyguide keyguide)
	{
	}

	public void Show(CapsuleInfo capsuleInfo)
	{
	}

	public void Hide()
	{
	}

	public void PlayReportCurrentCapsuleData()
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private bool OnUpdateDefault(float deltaTime)
	{
		return default(bool);
	}

	private void OnUpdateCategoryTab(float deltaTime)
	{
	}

	private void OnUpdatePullDown(float deltaTime)
	{
	}

	private void OnUpdate3DMode(float deltaTime)
	{
	}

	private void OnUpdate2DMode(float deltaTime)
	{
	}

	private SealCategoryButton GetNearCategoryButton(Vector3 pos)
	{
		return null;
	}

	public void UpdateKeyGuide(bool isForce = false)
	{
	}

	private void MoveCursor(float x, float y)
	{
	}

	private DecideActionResult Decide()
	{
		return default(DecideActionResult);
	}

	private void SwitchMode()
	{
	}

	private void ShowPullDown(Vector3 pos)
	{
	}

	private void HidePullDown()
	{
	}

	private void UpdatePullDownCursor()
	{
	}

	private void UpdateCursorPositionToCurrentCategory()
	{
	}

	private bool MoveCurrentCategoryButtonNearestGrid()
	{
		return default(bool);
	}

	private void CheckCursorRaycast(bool isForce = false, bool isCheckMovable = true, bool isSelectSe = true)
	{
	}

	private IEnumerator DelayCheckCursorRaycast(bool isForce = false, bool isCheckMovable = true, bool isSelectSe = true)
	{
		return null;
	}

	private void RefreshShowPullDown(bool isMoveCursorCurrentCategory = true)
	{
	}

	private void RefreshCapsuleInfo(bool isReset = false)
	{
	}

	private void UpdatePallet()
	{
	}

	private void SwitchPallet()
	{
	}

	private void CheckCategoryButtonEnable(SealCategoryButton button)
	{
	}

	private void SetupPullDown(SealCategoryButton categoryButton)
	{
	}

	private void UpdateSealCountView()
	{
	}

	private void UpdateSwitchPalletIconActive()
	{
	}

	private void SetPickedSeal(Capsule2DGridCell capsule2DGridCell)
	{
	}

	private void SetPickedSeal(Seal3DObject seal3DObject)
	{
	}

	private void ClearPickedSeal()
	{
	}

	private void OnReverseCapsule2D()
	{
	}

	private void CheckCursorInMovableRect()
	{
	}

	private Rect GetRect(RectTransform rectTransform)
	{
		return default(Rect);
	}
}
