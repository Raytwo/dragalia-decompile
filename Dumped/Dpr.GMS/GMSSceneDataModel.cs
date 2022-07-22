using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DPData;
using Dpr.Demo;
using Dpr.Message;
using Dpr.SubContents;
using Dpr.UI;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.U2D;
using XLSXContent;

namespace Dpr.GMS;

public class GMSSceneDataModel
{
	private readonly Rect VIEWPORT_RECT;

	private readonly Vector2 SCREE_SIZE;

	private GMSMasterData gmsMasterData;

	private GMSConfig gmsConfig;

	private GMSPointDataContainer dataContainer;

	private GMSResourceContainer resourceContainer;

	private UIManager uiManagerPtr;

	private Camera mainCameraPtr;

	private GMSPointDataModel lastUpdatePointData;

	private Keyguide keyguide;

	private KeyguidePattern keyguidePattern;

	private ArenaInfo.SheetArenaData currentArenaData;

	private MessageManager msgManagerPtr;

	private MessageMsgFile monsNameMsgFile;

	private MessageMsgFile gmsMsgFile;

	private Dictionary<int, string> monsNameTable;

	private Transform keyGuideParent;

	private RenderTexture renderTexture;

	private GMSMode selectGMSMode;

	private SceneState nowSceneState;

	private Coroutine coroutineCreatePointHistoryData;

	private BoxWindow.SelectedPokemon selectBoxPokemon;

	private int nowTotalPutPointNum;

	private int maxPointNum;

	private int lastSelectModeIndex;

	private ushort tradeListIndex;

	private ushort browsingListIndex;

	private byte achievementStep;

	private bool bIsReady;

	private SpriteAtlas graphicTextAtlas;

	private Demo_Trade tradeDemoParam;

	private TradeResultData tradeResultData;

	public bool IsReady => default(bool);

	public SceneState NowSceneState => default(SceneState);

	public GMSMode SelectGMSMode => default(GMSMode);

	public RenderTexture RenderTexture => null;

	public GMSPointDataContainer DataContainer => null;

	public int LastSelectModeIndex => default(int);

	public float ShowMsgTime => default(float);

	public int TotalPutPointNum => default(int);

	public bool CanControllCameraInBrowsingMode => default(bool);

	public Demo_Trade TradeDemoParam => null;

	public TradeResultData TradeData => null;

	public int ReceivePointIndex => default(int);

	private bool IsRankMax => default(bool);

	public void Initialize(Transform keyGuideParent)
	{
	}

	private ArenaInfo.SheetArenaData FindGMSArenaInfo()
	{
		return null;
	}

	public void SetGMSMasterData(GMSMasterData gmsMasterData)
	{
	}

	public void SetGMSConfig(GMSConfig gmsConfig)
	{
	}

	private void CreatePointDatas()
	{
	}

	private int FirstCalcPutPointNum()
	{
		return default(int);
	}

	private IEnumerator IE_CreatePointHistoryData()
	{
		return null;
	}

	public void ResetData()
	{
	}

	public void ResetPointDataStatus()
	{
	}

	public void OnFinalize()
	{
	}

	private void UnloadAssetBundle()
	{
	}

	public void SetSceneState(SceneState newState)
	{
	}

	public void ChangeGMSMode(GMSMode selectGMSMode)
	{
	}

	public float GetEarthRadius()
	{
		return default(float);
	}

	public bool CanSnapPoint()
	{
		return default(bool);
	}

	public string GetGroundAssetPath()
	{
		return null;
	}

	public EnvironmentSettings GetStageRenderSetting()
	{
		return null;
	}

	public string GetResourcePath(int dataIndex)
	{
		return null;
	}

	public EmitEffectParam[] GetGMSEffects()
	{
		return null;
	}

	public string GetSpriteAtlasPath()
	{
		return null;
	}

	public void SetSpriteAtlas(SpriteAtlas atlas)
	{
	}

	public Sprite GetSpriteByIndex(int index)
	{
		return null;
	}

	private string GetSpriteName(int index)
	{
		return null;
	}

	public float GetAutoCloseMsgTime()
	{
		return default(float);
	}

	public PointDataStatus CheckPointDataStatus(int pointIndex)
	{
		return default(PointDataStatus);
	}

	public GMSPointDataModel GetPointDataModelByIndex(int index)
	{
		return null;
	}

	private int CalcTotalPutPointNum()
	{
		return default(int);
	}

	private PointHistoryDataModel CreatePointHistoryDataModelByHistoryData(GMS_POINT_HISTORY_DATA hitsoryData, GMS_POINT_HISTORY_EXT_DATA extData)
	{
		return null;
	}

	private PointHistoryDataModel CreateHistoryDataModel(IntermediatePointData data)
	{
		return null;
	}

	private string CreateMonsNameStr(MonsNo monsNo)
	{
		return null;
	}

	private void LoadMonsIconSpr(MonsNo monsNo, ushort formNo, Sex sex, Action<Sprite> onLoadComplete)
	{
	}

	public GMSPointDataModel FindNearPointDataFromCamera(ref Vector3 cameraNormal)
	{
		return null;
	}

	public void MarkHistoryData(int pointIndex, int dataIndex)
	{
	}

	public void MarkLastHistoryData(int pointIndex)
	{
	}

	public void AddHistoryData(int pointIndex, IntermediatePointData newData, bool isNew, bool isSave)
	{
	}

	public void InsertHistoryData(int pointIndex, IntermediatePointData newData, bool isMark, bool isNew)
	{
	}

	public void DeleteHistoryData(int pointIndex, int dataIndex)
	{
	}

	public void DeleteLastHistoryData(int pointIndex)
	{
	}

	public void UpdatePointPosition(GMSPointDataModel target, [In] ref Vector3 cameraNormal)
	{
	}

	private bool IsViewCamera(GMSPointDataModel target, [In] ref Vector3 cameraNormal)
	{
		return default(bool);
	}

	public int GetStartListIndex(GMSMode gmsMode)
	{
		return default(int);
	}

	public int GetNowSelectModeListIndex()
	{
		return default(int);
	}

	public void SetTradeListIndex(int index)
	{
	}

	public void SetBrowsingListIndex(int index)
	{
	}

	public void ApplyTradeDemoParam()
	{
	}

	public void ClearTradeDemoParam()
	{
	}

	public void OnExitScene()
	{
	}

	public void OpenBoxWindow(Action onSelectMons, Action onCancel)
	{
	}

	private BoxWindow.OpenParam CreateBoxWindowParam()
	{
		return null;
	}

	public void SettingSendDataModel(int selectPointIndex)
	{
	}

	public void SetReceiveDataModel(ReceiveMonsDataModel receiveDataModel)
	{
	}

	public void OnReceivePokeData(int pointNo, byte[] coreData)
	{
	}

	private void CheckEvelov(PokemonParam pokeParam)
	{
	}

	public void DeleteSendPokeData()
	{
	}

	public void RestoreSendPokeData()
	{
	}

	public void ClearTradeResultData()
	{
	}

	public bool CheckPutRankup()
	{
		return default(bool);
	}

	public Sprite GetAchievementStepSpr()
	{
		return null;
	}

	public GMSMasterData.SheetWindowMessage[] GetWindowMessageMD()
	{
		return null;
	}

	public string GetMessageLabelByID(MessageID messageID)
	{
		return null;
	}

	public void OpenKeyguide(KeyguidePattern pattern)
	{
	}

	private Keyguide.Param CreateKeyguidePatternTop()
	{
		return null;
	}

	private Keyguide.Param CreateKeyguidePatternTrade()
	{
		return null;
	}

	private Keyguide.Param CreateKeyguidePatternMatching()
	{
		return null;
	}

	private Keyguide.Param CreateKeyguidePatternTradeHistory()
	{
		return null;
	}

	private Keyguide.Param CreateKeyguidePatternBrowsing()
	{
		return null;
	}

	private Keyguide.Param CreateKeyguidePatternBrowsingHistory()
	{
		return null;
	}

	private Keyguide.Param CreateKeyguidePatternEmpty()
	{
		return null;
	}

	public void CloseKeyguide()
	{
	}

	public void SetGMSPlayerData()
	{
	}
}
