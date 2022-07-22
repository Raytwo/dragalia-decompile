using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.Contest;
using XLSXContent;

namespace Dpr.UI;

public class ContestMatchingPreparation
{
	private enum PreparationState
	{
		Confirm,
		UIMenu,
		WaitAllMemberPreparation,
		LoadingWazaSquence,
		SendPlayerData,
		WaitReceivePlayerDatas,
		WaitHostContestLevel,
		SendContestData,
		LoadMemberModel,
		CheckEntryMember,
		WaitAllMemberReady,
		Finish
	}

	private enum UIMenuState
	{
		PokeSelect,
		WazaSelect,
		CapsuleSelect,
		BoutiqueSelect
	}

	private readonly string[] CONTEXTMENU_LABELS;

	private readonly List<UIWindowID> USE_WINDOW_ID_ARRAY;

	private bool[] activeMemberArray;

	private ushort[] fashionIDArray;

	private ContestMatchingUI contestMatchingUIPtr;

	private ContestMatchingNetwork networkPtr;

	private UISelectorWindow selectorWindowPtr;

	private UIManager uiManager;

	private IContestUIWindow nowOpenWindow;

	private ContestViewSystem wazaViewSystem;

	private ContestMasterDatas contestMasterDatas;

	private Action<ContestMatching.FinishPattern> onFinish;

	private PreparationState currentState;

	private UIMenuState menuState;

	private int loadCount;

	private int currentJoinNum;

	private bool bIsAlreadyChangeFinishPreparation;

	private bool bIsReceivedStageRank;

	private bool bIsCountDown;

	private bool bIsActive;

	public void Initialize(ContestMatchingUI contestMatchingUI, ContestMatchingNetwork network, Action<ContestMatching.FinishPattern> onFinish)
	{
	}

	public void OnFinalize()
	{
	}

	private void Reset()
	{
	}

	public void StartProcess(float startCountDown, ContestMasterDatas contestMasterDatas, UISelectorWindow selectorWindow)
	{
	}

	private void ResetContestParam()
	{
	}

	private IEnumerator IE_PreLoadUIWindows(float startCountDown)
	{
		return null;
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateWaitAllMemberPreparation(float deltaTime)
	{
	}

	private void UpdateLoadingWazaSquence(float deltaTime)
	{
	}

	private void UpdateWaitReceivePlayerDatas(float deltaTime)
	{
	}

	private void UpdateWaitHostContestLevel()
	{
	}

	private void UpdateLoadMemberModel()
	{
	}

	private void UpdateWaitAllMemberReady(float deltaTime)
	{
	}

	private void UpdateCountDown(float deltaTime)
	{
	}

	private void Timeup()
	{
	}

	private void ChangeState(PreparationState newState)
	{
	}

	private void OnChangeStateConfirm()
	{
	}

	private void OnChangeStateWaitAllMemberPreparation()
	{
	}

	private void OnChangeStateLoadingWazaSeq()
	{
	}

	private void OnChangeStateSendPlayerData()
	{
	}

	private void SendMyEntryDataToAll()
	{
	}

	private void OnChangeStateSendContestData()
	{
	}

	private void OnChangeStateLoadMemberModel()
	{
	}

	private void CheckLoadPlayerModel(int stationIndex, ushort newFashionID, [Optional] Action onComplete)
	{
	}

	private void OnChangeStateCheckEntryMember()
	{
	}

	private void LoadNPCModel(int index, int npcDataIndex)
	{
	}

	private void ShowGoContestSceneMessage()
	{
	}

	private void OnChangeStateWaitAllMemberReady()
	{
	}

	private void OnChangeStateFinish()
	{
	}

	private void ChangeStateUIMenu(UIMenuState newState)
	{
	}

	private void OpenPokeSelectWindow()
	{
	}

	private void OpenWazaSelectWindow()
	{
	}

	private void OpenCapsuleSelectWindow()
	{
	}

	private void OpenBoutiqueSelectWindow()
	{
	}

	private void OnFinishPreparation()
	{
	}

	private T OpenUIWIndow<T>(UIWindowID openWindowID, Action onDecide, Action onCancel) where T : UIWindow, IContestUIWindow
	{
		return null;
	}

	private void OnCompletePreparation(int stationIndex)
	{
	}

	public void OnChangeHostMine()
	{
	}

	public void OnLeaveOtherPlayer(int stationIndex)
	{
	}

	private void ForceCloseUIWindow()
	{
	}

	public void Deactivate()
	{
	}

	public bool IsFinishPreparation()
	{
		return default(bool);
	}

	public void OnReceiveCountDownData(CountDownNetData timeData)
	{
	}

	private bool CheckTimeUp()
	{
		return default(bool);
	}

	public void OnReceiveEntryNPCData(ContestEntryNPCNetData entryNPCData)
	{
	}

	public void OnReceiveEntryPlayerData(int stationIndex)
	{
	}

	public void OnReceiveContestInfoData(ContestInfoNetData contestData)
	{
	}

	public void OnReceiveReadyData(int stationIndex, NoticeID noticeID)
	{
	}
}
