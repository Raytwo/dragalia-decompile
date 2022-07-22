using System.Collections;
using Audio;
using Dpr.Contest;
using Dpr.EvScript;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class UIContCapsuleSelect : UIWindow, IContestUIWindow
{
	[SerializeField]
	private MenuHeader _header;

	[SerializeField]
	private UIScrollView _capsuleScrollView;

	[SerializeField]
	private CapsuleViewController _capsuleViewController;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private RectTransform bgParent;

	[SerializeField]
	private RectTransform bgRectTransform;

	private CapsuleInfo[] _capsuleInfos;

	private PokemonParam[] _attachPokemonParamArray;

	private CapsuleItemButton _selectedCapsuleItemButton;

	private AudioManager audioManagerPtr;

	private KeyGuideCreater _keyGuide;

	private EvWork.WORK_INDEX _resultWorkIndex;

	private ContestMenuEventID _resultEventID;

	private float _currentScrollPosition;

	private int _currentSelectIndex;

	private int _startSelectIndex;

	private bool _bIsOpen;

	private bool _bIsOpening;

	private bool _bIsMultiMode;

	public bool IsOpen => default(bool);

	public ContestMenuEventID ResultEventID => default(ContestMenuEventID);

	public override void OnCreate()
	{
	}

	private void CreateCapsuleInfos()
	{
	}

	public void OpenSingleMode(int resultTemp, UIWindowID prevWindowId)
	{
	}

	public void OpenMultiMode(UIWindowID prevWindowID, string minutStr, string secondStr)
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateInputSelect()
	{
	}

	private void UpdateInputAction()
	{
	}

	private void UpdateInputRot()
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

	private void OnReverseCapsule2D()
	{
	}

	private void SetupCapsuleView()
	{
	}

	public void CloseWindow()
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}

	private void OnClose()
	{
	}

	public void SetTimeCount(string minutStr, string secondStr)
	{
	}

	private void ResetContestParam()
	{
	}
}
