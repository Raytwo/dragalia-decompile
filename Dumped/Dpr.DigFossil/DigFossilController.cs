using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.NetworkUtils;
using Dpr.SecretBase;
using Effect;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigFossilController : MonoBehaviour
{
	public class DigParam
	{
		public int NumOfOtherParticipants;

		public float DropUpCorrection;

		public float Bonus => default(float);
	}

	private enum GameState
	{
		Init,
		FadeIn,
		FirstEvent,
		StartMessageShow,
		Dig,
		EndDirection,
		EndMessageShow,
		ResultCommonItem,
		ResultCommonItemWait,
		ResultStoneBox,
		MessageWait,
		MessageCloseWait
	}

	[SerializeField]
	private float startMessageWaitTime;

	[SerializeField]
	private int horiBonusMinCount;

	[SerializeField]
	private int horiBonusMaxCount;

	[SerializeField]
	private int horiGaugeBonus;

	[SerializeField]
	private float cameraShakeDuration;

	[SerializeField]
	private float waitingTimeToDigOutAllItemsResult;

	[SerializeField]
	private List<float> cameraShakeStrength;

	[SerializeField]
	private List<int> crumblingEffectNum;

	[SerializeField]
	private Vector2 toResultBlackOut;

	[SerializeField]
	private Vector2 toResultBlackIn;

	[SerializeField]
	private Vector2 toBoxResultBlackOut;

	[SerializeField]
	private Vector2 toBoxResultBlackIn;

	[SerializeField]
	private float boxOpenMotionSpeed;

	[SerializeField]
	private float boxOpenEffectDelay;

	[SerializeField]
	private Vector2 toAppearStatueWhiteOut;

	[SerializeField]
	private Vector2 toAppearStatueWhiteIn;

	[SerializeField]
	private float tonariModeDropUpCorrection;

	[SerializeField]
	private float tonariModeGaugeDownCorrection;

	[SerializeField]
	private int debugLotStatueId;

	[SerializeField]
	private DigCursor cursor;

	[SerializeField]
	private DigBuildupViewManager buildupViewManager;

	[SerializeField]
	private DigDepositViewManager digDepositViewManager;

	[SerializeField]
	private DigToolSwitch toolSwitch;

	[SerializeField]
	private DigCameraShaker cameraShaker;

	[SerializeField]
	private DigCameraManager cameraManager;

	[SerializeField]
	private DigGauge gauge;

	[SerializeField]
	private DigFade fade;

	[SerializeField]
	private GameObject UIRoot;

	[SerializeField]
	private Transform stoneBoxPos;

	[SerializeField]
	private DigFallBoardDirection fallBoradDirection;

	[SerializeField]
	private DigItemResult itemResult;

	[SerializeField]
	private DigBoard board;

	[SerializeField]
	private DigEffectManager effectManager;

	[SerializeField]
	private DigAudioManager audioManager;

	[SerializeField]
	private GameObject resultBg;

	[SerializeField]
	private DigVibration vibration;

	[SerializeField]
	private DigMasterDataManager masterDataManager;

	[SerializeField]
	private DigStatueCameraSelector statueCameraSelector;

	[SerializeField]
	private StatueModelLoader statueModelLoader;

	[SerializeField]
	private Text tableTypeText;

	[SerializeField]
	private Text tonariNumText;

	[SerializeField]
	private EnvironmentSettings inGameEnvironmentSettings;

	[SerializeField]
	private EnvironmentSettings resultEnvironmentSettings;

	[SerializeField]
	private EnvironmentController environmentController;

	[SerializeField]
	private List<DigCursor> tonariCursorList;

	private const int COST_DIG_HUMMER = 8;

	private const int COST_DIG_PIC = 4;

	private const int DIG_GAUGE_START = 196;

	private readonly IDigMessage message;

	private float digGauge;

	private int digGaugeMax;

	private EffectInstance directionEffectInstance;

	private DigDepositViewManager.PlacementInfo stoneBoxData;

	private readonly IDigStoneBoxResult stoneBoxResult;

	private GameState gameState;

	private bool isDisplayDebugInfo;

	private UgNetworkManager ugNetworkManager;

	private Dictionary<int, DigCursor> tonariCursorDic;

	private DigParam digParam;

	private bool isHost => default(bool);

	public IEnumerator ActivateOperation()
	{
		return null;
	}

	private IEnumerator IE_LoadResource()
	{
		return null;
	}

	private IEnumerator SetupKeyguide()
	{
		return null;
	}

	private void OpenKeyguide()
	{
	}

	private void CloseKeyguide()
	{
	}

	private IEnumerator GameInitialize()
	{
		return null;
	}

	private IEnumerator ShowStartMessage()
	{
		return null;
	}

	private void SystemInitialize()
	{
	}

	private void OnClicked([In] ref Vector2 inPos)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private IEnumerator WaitForSeconds(float wait, Action onCompleted)
	{
		return null;
	}

	private IEnumerator ResultDirection()
	{
		return null;
	}

	private void SetState(GameState newState)
	{
	}

	private void SetUIAndCamera(DigCameraManager.CameraSet set)
	{
	}

	private void SetDebugText(ref Text text, bool isDuty, string message)
	{
	}

	private void ExitDigFossil(bool isDig)
	{
	}

	private void SaveReport()
	{
	}

	private void SetDisplayDebugInfo(bool isDisplay)
	{
	}

	private void SendDigData(Vector2 pos, bool isHammer)
	{
	}

	private void OnReceiveDigFossileNetData(INetData data)
	{
	}

	private void HostEnd()
	{
	}

	private bool AddCursor(int stationIndex)
	{
		return default(bool);
	}

	private void TonariDigAttack(NetDigAttackData data)
	{
	}
}
