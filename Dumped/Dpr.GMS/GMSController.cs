using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.GMS;

public class GMSController : MonoBehaviour
{
	[SerializeField]
	private GMSCamera gmsCamera;

	private UIGMSScene sceneUI;

	private UIPointMarkManager uiGMSMark;

	private UIPointListManager uiPointDataList;

	private UIAchievementAnim uiAchievementAnim;

	private GMSSceneDataModel dataModel;

	private GMSMessageWindow msgWindow;

	private GMSResourceLoader resourceLoader;

	private GMSResourceLoader asyncResourceLoader;

	private GameObject earthObj;

	private Texture2D bgTexture;

	private EffectEmitter effectEmitter;

	private void StartNetworkTrade()
	{
	}

	private IEnumerator IE_SaveReportProcess(Action onFinishedReport)
	{
		return null;
	}

	private void OnConnectSuccess()
	{
	}

	private void StartValidateCheck()
	{
	}

	private void OnConnectFalied()
	{
	}

	private void OnFailedValidate(ValidateResultID resultID)
	{
	}

	private void OnCompleteTrade(GMSTradeResult result)
	{
	}

	private IEnumerator IE_Save(Action onCompleteSave)
	{
		return null;
	}

	private void OnFinishTrade(TradeResult result)
	{
	}

	private void OnTradeSuccess()
	{
	}

	private void OnTradeTimeout()
	{
	}

	private void OnTradeCancel()
	{
	}

	private void OnTradeFailed()
	{
	}

	private void UpdateNetworkTrade(float deltaTime)
	{
	}

	[SceneBeforeActivateOperationMethod]
	public IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	private IEnumerator IE_WaitManagerInitialize()
	{
		return null;
	}

	private IEnumerator IE_LoadMasterDatas()
	{
		return null;
	}

	private void LoadResourcesBackGround()
	{
	}

	private void AppendLoadResource()
	{
	}

	private void SceneInitialize()
	{
	}

	private void LoadEffect()
	{
	}

	private void Start()
	{
	}

	private void SetupEnvironment()
	{
	}

	private void Setup()
	{
	}

	private void OnDestroy()
	{
	}

	private void ChangeSceneStateLaunchAnim()
	{
	}

	private void ChangeSceneStateModeSelect()
	{
	}

	private void OnClosedModeSelectMenu()
	{
	}

	private void OpenSelectTradeMonsBox()
	{
	}

	private void StartBrowsingMode()
	{
	}

	private void ChangeSceneStateEnterAnim()
	{
	}

	private void ChangeSceneStateEndGMSModeAnim()
	{
	}

	private void ChangeSceneStateMain()
	{
	}

	private void ChangeSceneStateSelectReplaceData()
	{
	}

	private void ChangeSceneStateAchievement()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateStateLaunchAnim()
	{
	}

	private void UpdateStateStartGMSModeAnim()
	{
	}

	private void UpdateStateMain(float deltaTime)
	{
	}

	private void UpdateInput(float deltaTime)
	{
	}

	private bool CanExitScene()
	{
		return default(bool);
	}

	private void UpdateSelectReplaceData()
	{
	}

	private void UpdateStateEndGMSModeAnim()
	{
	}

	private void UpdateAchievementAnim()
	{
	}

	private void OnLateUpdate(float deltaTime)
	{
	}

	private void UpdatePointMark()
	{
	}

	private void OnSelectListData(PointHistoryDataModel selectData)
	{
	}

	private void StartTradeFlow()
	{
	}

	private void OnEndTradeDemo(PointDataStatus pointDataStatus, int pointIndex)
	{
	}

	private void OnFinishedTradeDemo(PointDataStatus pointDataStatus)
	{
	}

	private void OpenConfirmReplaceDataMsg()
	{
	}

	private void JumpPoint(int pointIndex, Action onMoveEnd)
	{
	}

	private void OpenChoicePointOperationMenu(PointHistoryDataModel selectData)
	{
	}

	private void ChoiceMark()
	{
	}

	private void ChoiceDeleteMark()
	{
	}

	private void OnChoiceDelete()
	{
	}

	private bool DeletePointDataByIndex(int pointIndex, int dataIndex)
	{
		return default(bool);
	}

	private void OnChoiceReplaceData()
	{
	}

	private void OnStopCameraMove()
	{
	}

	private void OnReleaseListInput()
	{
	}

	private void OnCancelList()
	{
	}

	private void OnSelectStayData()
	{
	}

	private void DecideSelectPoint()
	{
	}

	private void PlayTradeDemo([Optional] Action onEndDemo)
	{
	}

	private void ConfirmExitGMSScene()
	{
	}

	private void ExitScene()
	{
	}

	private void OnChoiceNo()
	{
	}
}
