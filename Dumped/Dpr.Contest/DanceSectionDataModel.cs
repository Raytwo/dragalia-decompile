using System;
using System.Collections.Generic;
using UnityEngine;
using XLSXContent;

namespace Dpr.Contest;

public class DanceSectionDataModel
{
	private class SkillComboData
	{
		public bool IsContain;

		public int score;

		public void Reset()
		{
		}
	}

	private const float ONE_MINUTE = 60f;

	private SceneObjectManager objManager;

	private PlayerDanceDataModel[] playerDataArray;

	private PlayerDanceDataModel userDataModel;

	private Dictionary<int, TensionData> tensionTable;

	private List<NotesDataModel> currentNoteDataList;

	private CollectNotesDataModel collectNotesDataModel;

	private Vector2 notesSpan;

	private int currentDataIndex;

	private int musicBpm;

	private Dictionary<int, float> tapTimingTable;

	private Dictionary<int, float> longTapTimeSpanTable;

	private TapResultData tapResultData;

	private NoteIcon longStartNote;

	private float totalSec;

	private float startElapsedTime;

	private float endTapSec;

	private Dictionary<int, int[]> scoreTable;

	private SkillComboData[] comboBonusDataArray;

	private ApplyScoreResult applyScoreResult;

	private int maxScore;

	private int totalVisualScore;

	private int totalScore;

	private int checkStackHeartNum;

	private float successScoreRatio;

	private ComboBonusDataModel comboBonus;

	private double launchSkillElapsedTime;

	private float skillChainDuration;

	private float downVolumePersent;

	private int chainCount;

	private int lastUsePlayerIndex;

	private bool canUpdateChain;

	private NotesDataModel lastNoteData;

	public float BeatSec => default(float);

	public bool IsFinishCreate => default(bool);

	public bool IsLongTap => default(bool);

	public float SuccessScoreRatio => default(float);

	public bool CanUpdateAcceptChain => default(bool);

	public int ChainCount => default(int);

	public int LastUsePlayerIndex => default(int);

	public float DownVolumePersent => default(float);

	public NotesDataModel LastNoteData => null;

	public bool IsAlreadyUseUserSkill => default(bool);

	public void Initialize()
	{
	}

	public void SetDanceSectionData(DanceSectionData danceSectionData)
	{
	}

	private void CreateNoteDataList(DanceSectionData danceSectionData)
	{
	}

	private void SetNotesSpan()
	{
	}

	public void ResetParam(DanceSectionData danceSectionData)
	{
	}

	public void CreateGameParameterFromContestDataModel(ContestDataModel contestDataModel)
	{
	}

	private void CreateTapScoreTable(ContestConfigDatas.SheetTapScoreData[] scoreDataArray)
	{
	}

	private void CreateTapTimingData(ContestConfigDatas.SheetTapTimingData[] taimingDataArray)
	{
	}

	private void CreateChangeTensionDataTable(ContestConfigDatas.SheetTapScoreData[] scoreDataArray)
	{
	}

	private void CreateComboBonusData(ContestConfigDatas.SheetComboBonusData[] bonusDataArray)
	{
	}

	public PlayerDanceDataModel GetUserDanceData()
	{
		return null;
	}

	public PlayerDanceDataModel GetPlayerDanceDataByIndex(int index)
	{
		return null;
	}

	public bool CanEmitHeartByPlayerIndex(int playerIndex)
	{
		return default(bool);
	}

	public DanceUser CreatePlayer(int index, ContestPlayerEntity entity, Action<ADancePlayer> onLockSkill)
	{
		return null;
	}

	public DanceNPC CreateNPC(int index, ContestPlayerEntity entity, Action<ADancePlayer> onLockSkill)
	{
		return null;
	}

	public DanceOtherUser CreateOtherUser(int index, ContestPlayerEntity entity, Action<ADancePlayer> onLockSkill)
	{
		return null;
	}

	private void SetPlayerData(int index, PlayerDanceDataModel playerData)
	{
	}

	private TensionData GetTensionDataByID(TensionID tensionID)
	{
		return null;
	}

	public TapResultData UpdatePlayerDataByTimingID(NoteTapTimingID timingId)
	{
		return null;
	}

	public TapResultData UpdatePlayerDataByTimingID(int playerIndex, NoteTapTimingID timingId)
	{
		return null;
	}

	public TapResultData UpdatePlayerDataByTimingID(PlayerDanceDataModel danceDataModel, NoteTapTimingID timingId)
	{
		return null;
	}

	private void UpdatePlayerTensionByTimingID(PlayerDanceDataModel playerData, NoteTapTimingID timingId)
	{
	}

	private void UpdateHeartGauge(PlayerDanceDataModel playerData, NoteTapTimingID timingId)
	{
	}

	private int GetHeartGaugeScore(TensionID tensionID, NoteTapTimingID timingID)
	{
		return default(int);
	}

	public float GetHeartGaugeRatio()
	{
		return default(float);
	}

	public NotesDataModel FindNextTargetTypeNoteData(int startIndex, NoteTypeID targetType)
	{
		return null;
	}

	public bool CheckCreateNextNote(double checkTime, out NotesDataModel nextNoteData)
	{
		return default(bool);
	}

	public NotesDataModel GetNextNoteData()
	{
		return null;
	}

	public NoteTapTimingID CheckTapTiming(float noteLifeTime)
	{
		return default(NoteTapTimingID);
	}

	public void StartLongTap(NoteIcon startNote, float startElapsedTime)
	{
	}

	public NoteTapTimingID CheckLongHoldSpanTimingID(float elapsedTime)
	{
		return default(NoteTapTimingID);
	}

	public NoteTapTimingID CheckHoldTimeByTimeRatio(float holdTimeRatio)
	{
		return default(NoteTapTimingID);
	}

	public TapResultData OnReleaseHold(int playerIndex, NoteTapTimingID holdTimingID)
	{
		return null;
	}

	public void FinishLongTap()
	{
	}

	public TapResultData OnNPCReleaseHold(int playerIndex, NoteTapTimingID holdTimingID)
	{
		return null;
	}

	public bool CanUpdateProgressGauge(double elapsedTime, out float gaugeRatio)
	{
		return default(bool);
	}

	public ResultID CheckScoreSuccess()
	{
		return default(ResultID);
	}

	public bool ApplyTotalScoreFromPlayer(int playerIndex, out ApplyScoreResult result)
	{
		return default(bool);
	}

	public float CalcTotalRatio()
	{
		return default(float);
	}

	public bool IsShowChainCount()
	{
		return default(bool);
	}

	public void LaunchSkill(double elapsedTime, int playerIndex, bool isPrevSameWazaType)
	{
	}

	private void CheckUntilUseSkillPlayer()
	{
	}

	public void OnLockPlayerContestSkill()
	{
	}

	private void PlayLaunchWazaSE(int playerIndex, bool isPrevSameWazaType)
	{
	}

	public float CalcChaniGaugeRatio(double elapsedTime)
	{
		return default(float);
	}

	public PlayerDanceDataModel CalcPlayerScoreAfterContestWaza(PlayerDanceDataModel danceDataModel, double startElapsedTime, double endElapsedTime, bool isUser)
	{
		return null;
	}

	public void ApplyScoreBonus()
	{
	}

	public bool CheckSamePrevWazaType()
	{
		return default(bool);
	}

	public bool CheckSameUserWazaType(int palyerIndex)
	{
		return default(bool);
	}
}
