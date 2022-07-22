using System.Collections.Generic;
using System.Text;
using Dpr.BallDeco;
using Dpr.Battle.View;
using Dpr.Message;
using Dpr.SequenceEditor;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.Contest;

public class ContestDataModel
{
	private ContestRewardDataModel contestResultDataModel;

	private ResultDataModel resultData;

	private MessageMsgFile wazaNameMsgFile;

	private MessageMsgFile nameMsgFile;

	private ArenaInfo.SheetArenaData currentArenaData;

	private CaptureData mainCaptureData;

	private CaptureData wazaCaptureData;

	private ShadowResolution backupShadowResolution;

	private Sprite contestTitleSpr;

	private Sprite contestCategorySpr;

	private Sprite contestRankSpr;

	private int captureCommandNum;

	private int maxCaptureCommandNum;

	private int userContestPoint;

	private int userIndex;

	private const int INIT_CAPACITY = 32;

	private Dictionary<int, ContestMasterDatas.SheetNPCCapsuleData> npcCapsuleTable;

	private Dictionary<int, ContestMasterDatas.SheetSealData> sealDataTable;

	private Dictionary<int, ContestMasterDatas.SheetItemData> itemDataTable;

	private ContestMasterDatas contestMasterDatas;

	private ContestConfigDatas contestConfigDatas;

	private ContestMasterDatas.SheetContestData useContestData;

	private ContestMasterDatas.SheetBgmData useBgmData;

	private ContestMasterDatas.SheetRewardData useRewardData;

	private DanceSectionData danceSectionData;

	private StringBuilder categoryTexNameSb;

	private StringBuilder useNotesDataFilePathSb;

	private StringBuilder useSequenceFilePathSb;

	private uint mainBgmEventID;

	private uint userContestRank;

	public CategoryID ContestCategoryID => default(CategoryID);

	public bool IsTutorial => default(bool);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	private void UnloadResource()
	{
	}

	public void UnloadAssetBundle()
	{
	}

	public void SetContestMasterData(Object asset)
	{
	}

	public void FormatMasterData()
	{
	}

	private void SettingContestMDRef()
	{
	}

	private string GetTutorialSeName(bool isDprB)
	{
		return null;
	}

	public string GetStringData(int dataID)
	{
		return null;
	}

	public int GetValueData(int dataID)
	{
		return default(int);
	}

	public ContestConfigDatas GetConfigData()
	{
		return null;
	}

	public Vector3 CreateInitMainCameraDofTargetPos()
	{
		return default(Vector3);
	}

	public Vector3 CreateInitWazaCameraDofTargetPos()
	{
		return default(Vector3);
	}

	public string GetMusicFilePath()
	{
		return null;
	}

	public string GetSequenceFilePath()
	{
		return null;
	}

	public DanceSectionData GetDanceSectionData()
	{
		return null;
	}

	public uint GetMainBgmEventID()
	{
		return default(uint);
	}

	public string GetStagePath()
	{
		return null;
	}

	public EnvironmentSettings GetStageRenderSetting()
	{
		return null;
	}

	public Sprite GetContestTitleSpr()
	{
		return null;
	}

	public Sprite GetCategorySpr()
	{
		return null;
	}

	public string GetMedalTexturePath()
	{
		return null;
	}

	public Sprite GetRankSpr()
	{
		return null;
	}

	public Sprite GetProgressIconSpr()
	{
		return null;
	}

	public string CreateUIPlayerNumFileName(int number)
	{
		return null;
	}

	public string CreateUIPlayerPlateFileName(int number)
	{
		return null;
	}

	public void SetQuaritySettings()
	{
	}

	public void ResetQuaritySettings()
	{
	}

	public MonsNo GetPlayerMonsNo()
	{
		return default(MonsNo);
	}

	public WazaNo GetPlayerWazaNo()
	{
		return default(WazaNo);
	}

	public int GetPlayerFormNo()
	{
		return default(int);
	}

	public PokeType GetPlayerPokeType1()
	{
		return default(PokeType);
	}

	public PokeType GetPlayerPokeType2()
	{
		return default(PokeType);
	}

	public uint GetUserRank()
	{
		return default(uint);
	}

	public AContestPlayerData[] CreateContestEntryPlayerDataArray()
	{
		return null;
	}

	private void CreateSingleModeNPCDatas()
	{
	}

	private void SetPlayerCommonParam(AContestPlayerData playerData, EntryPlayerData entryPlayerData)
	{
	}

	private ContestUserData CreateUserPlayerData(int entryNumber, EntryPlayerData entryPlayerData)
	{
		return null;
	}

	private ContestNPCData CreateNPCPlayerData(int entryNumber, EntryPlayerData entryPlayerData)
	{
		return null;
	}

	private int GetNPCVisualScore(ContestMasterDatas.SheetNPCData data)
	{
		return default(int);
	}

	private BtlvBallInfo CreateNPCBallInfo(ContestMasterDatas.SheetNPCCapsuleData npcCapsuleData)
	{
		return default(BtlvBallInfo);
	}

	public ContestOtherUserData CreateOtherPlayerData(int entryNumber, EntryPlayerData entryPlayerData)
	{
		return null;
	}

	private PokemonInfo CreatePokemonInfo(EntryPlayerData entryPlayerData)
	{
		return null;
	}

	private string CreatePokeModelPath(string pokeAssetBundleName)
	{
		return null;
	}

	private int CalcVisualScore(CoreParam pokeParam, bool isPlayer)
	{
		return default(int);
	}

	private float CalcConditionScore(byte conditionValue, int compatibility)
	{
		return default(float);
	}

	private ContestMasterDatas.SheetConditionScoreData FindConditionDataByParameter(int parameter)
	{
		return null;
	}

	private int CalcVisualScoreByCapsuleData(AffixSealData[] affixSealData)
	{
		return default(int);
	}

	private int CalcItemScore(int itemNo)
	{
		return default(int);
	}

	public void SetSkillAnimDuration(float seqMaxTime)
	{
	}

	private AContestSkillBase CreateContestSkill(uint contestSkillID, PokeType wazaType, AContestPlayerData playerData)
	{
		return null;
	}

	public EffectContestID[] CreateMonitorIDs()
	{
		return null;
	}

	public void OnFindCaptureCommand(ContestViewSystem targetViewSystem)
	{
	}

	public void OnPerformCaptureCommand(ContestViewSystem targetViewSystem, Macro macro)
	{
	}

	private void SetWazaEffectData(CaptureData targetData)
	{
	}

	private void SetCaptureData(CaptureData target)
	{
	}

	private int GetCaptureCommandFrame(CaptureData target)
	{
		return default(int);
	}

	private bool CheckCaptureProbability(int persent)
	{
		return default(bool);
	}

	public ContestConfigDatas.SheetTapScoreData[] GetScoreDataArray()
	{
		return null;
	}

	public ContestConfigDatas.SheetTapTimingData[] GetTapTimingDataArray()
	{
		return null;
	}

	public float GetValidTapTimeRange()
	{
		return default(float);
	}

	public ContestConfigDatas.SheetComboBonusData[] GetComboBonusDataArray()
	{
		return null;
	}

	public void SetNotesData(NotesInfo notesData)
	{
	}

	private bool IsCaptureContest()
	{
		return default(bool);
	}

	public ResultDataModel CreateModeResultData(ResultID resultID)
	{
		return null;
	}

	private ContestConfigDatas.SheetResultCameraTween GetResultCameraParam()
	{
		return null;
	}

	private ContestConfigDatas.SheetResultMotion GetResultMotionData()
	{
		return null;
	}

	private ResultPlayerDataModel[] CreateResultPlayerData()
	{
		return null;
	}

	private int FindTopScore(ContestPlayerEntity[] entities)
	{
		return default(int);
	}

	private void SetResultVoiceData(bool isUserWin)
	{
	}

	public void CreateMultiModeResultData(int result)
	{
	}

	public void OnFinishedContest()
	{
	}

	private void ApplyResultDataIntoPlayerWork()
	{
	}

	private void ApplyContestRewardData()
	{
	}

	private void CheckClearContestFlag()
	{
	}

	private void CheckContestReward(PokemonParam targetPokeParam)
	{
	}

	private void CheckRewardItem()
	{
	}

	private ContestMasterDatas.SheetRewardItemData FindRewardItemData()
	{
		return null;
	}

	private void CheckRewardCategoryRibbon(PokemonParam targetPokeParam)
	{
	}

	private void CheckRewardClearAllMasterRank(PokemonParam targetPokeParam)
	{
	}

	private bool IsAllMasterRankClear(PokemonParam targetPokeParam)
	{
		return default(bool);
	}

	private void CheckMasterContestReward(PokemonParam targetPokeParam)
	{
	}

	private void CheckCaptureData()
	{
	}

	private void PerformSaveCaptureData(CaptureData targetData)
	{
	}

	public void ChangeTutorialSecondPlayData()
	{
	}

	public float GetSyncScoreSpan()
	{
		return default(float);
	}
}
