using System.Collections;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Dpr.SequenceEditor;
using INL1;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.Contest;

public class ContestController : MonoBehaviour
{
	private const float LIMIT_TIMEOUT = 10f;

	private ContestMatchingNetwork network;

	private WaitTimer waitTimer;

	private bool bCanStartContest;

	private bool bIsRecieveWaitTime;

	private bool canSectionUpdate;

	private bool bIsStartMultiContest;

	[SerializeField]
	private Camera wazaCamera;

	private SceneObjectManager objectManagerPtr;

	private OpeningSection openingSection;

	private VisualSection visualSection;

	private DanceSection danceSection;

	private ResultSection resultSection;

	private ContestDataModel dataModel;

	private SceneResourceLoader resourceLoader;

	private ContestViewSystem contestViewSystem;

	private ContestViewSystem wazaViewSystem;

	private SectionID currentSectionID;

	private SectionID nextSectionID;

	private ResultDataModel resultDataModel;

	private bool hasRequestChangeSectionID;

	private bool IsCompleteSection => default(bool);

	private void InitMultiMode()
	{
	}

	private void StartNetworkContest()
	{
	}

	private void SetupNetwork()
	{
	}

	private IEnumerator IE_ActivateMultiMode()
	{
		return null;
	}

	private bool CanStartNetworkContest()
	{
		return default(bool);
	}

	private void UpdateWaitAsync()
	{
	}

	private void UpdateNetworkError()
	{
	}

	private void OnChangeSectionWaitAsync()
	{
	}

	private void OnRecievePacket(byte dataID, PacketReader pr)
	{
	}

	private void OnReceiveNotice(NoticeNetData noticeData)
	{
	}

	private void OnSessionEvent(SessionEventData result)
	{
	}

	private void OnLeaveOtherPlayer(int stationIndex)
	{
	}

	private bool IsGaming()
	{
		return default(bool);
	}

	private void ChangeAllOtherPlayerToNPC()
	{
	}

	private void OnChangeHostMine()
	{
	}

	private void OnChangeHostOtherPlayer()
	{
	}

	private void OnSessionError()
	{
	}

	private void OnFinishedSession()
	{
	}

	[SceneBeforeActivateOperationMethod]
	public IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	private void CloseUIWindow()
	{
	}

	private IEnumerator IE_LoadScenePrefabs(Transform cluster)
	{
		return null;
	}

	private void SceneInitialize()
	{
	}

	private IEnumerator IE_LoadMasterDatas()
	{
		return null;
	}

	private void SystemInitialize()
	{
	}

	private IEnumerator IE_PreLoadResource(Transform cluster)
	{
		return null;
	}

	private void AppendLoadNotesData()
	{
	}

	private void AppendOpeningResource()
	{
	}

	private void AppendLoadModel(Transform cluster)
	{
	}

	private void LoadMainSequence()
	{
	}

	private void LoadWazaSequence()
	{
	}

	private void SetupUITexture()
	{
	}

	private void Start()
	{
	}

	private void PrevSetup()
	{
	}

	private IEnumerator IE_Start()
	{
		return null;
	}

	private void AfterSetup()
	{
	}

	private void OnDestroy()
	{
	}

	private void StartContest()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void FinishedContest()
	{
	}

	private void UpdateSection(float deltaTime, float elapsedTime)
	{
	}

	private void UpdateOpeningSection()
	{
	}

	private void UpdateVisualSection()
	{
	}

	private void UpdateDanceSection(float deltaTime, float elapsedTime)
	{
	}

	private void UpdateResultSection(float deltaTime)
	{
	}

	private IEnumerator IE_LoadResultResource()
	{
		return null;
	}

	private void OnLateUpdate(float deltaTime)
	{
	}

	private void DoNextSection()
	{
	}

	private void LateUpdateSection()
	{
	}

	private void ChangeSectionOpening()
	{
	}

	private void RequestChangeSectionId(SectionID newSectionId)
	{
	}

	private void OnFindCommand(CommandNo commandNo, ContestViewSystem viewSystem)
	{
	}

	private void LoadMigawariModel()
	{
	}

	private void OnPerformedCommand(CommandNo commandNo, ContestViewSystem viewSystem, Macro macro)
	{
	}

	private void ForceStopContest()
	{
	}

	private IEnumerator IE_RestartContest()
	{
		return null;
	}

	private IEnumerator IE_ReloadTutorialSeq()
	{
		return null;
	}

	private IEnumerator IE_LoadTutorialResource()
	{
		return null;
	}

	private void ResetParam()
	{
	}
}
