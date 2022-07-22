using System.Collections;
using Dpr.Contest;
using Dpr.EvScript;
using UnityEngine;

namespace Dpr.UI;

public class UIContWazaSelect : UIWindow, IContestUIWindow
{
	[SerializeField]
	private MenuHeader _header;

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private WazaManageWazaStatusPanel _wazaPanel;

	[SerializeField]
	private UIPokeStatusSelectPanel _uiPokeStatus;

	private KeyGuideCreater _keyGuide;

	private EvWork.WORK_INDEX _resultWorkIndex;

	private ContestMenuEventID _resultEventID;

	private byte _startSelectIndex;

	private bool _bInputed;

	private bool _bIsOpen;

	private bool _bIsOpening;

	private bool _bIsMultiMode;

	public bool IsOpen => default(bool);

	public ContestMenuEventID ResultEventID => default(ContestMenuEventID);

	public override void OnCreate()
	{
	}

	public void Open(EvWork.WORK_INDEX resultWorkIndex, UIWindowID prevWindowID)
	{
	}

	public void OpenMultiMode(UIWindowID prevWindowID, string minutStr, string secondStr)
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowID)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateInput()
	{
	}

	public void CloseWindow()
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}

	public void SetTimeCount(string minutStr, string secondStr)
	{
	}

	private void ResetContestParam()
	{
	}
}
