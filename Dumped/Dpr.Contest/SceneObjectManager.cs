using System;
using Dpr.Battle.Logic;
using Dpr.Battle.View;
using Dpr.Battle.View.Objects;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.U2D;

namespace Dpr.Contest;

public class SceneObjectManager : SingletonMonoBehaviour<SceneObjectManager>
{
	[SerializeField]
	private SpriteAtlas sceneGraphicTextAtlas;

	private readonly string MAINCAMERA_TAG;

	private readonly string UNTAGGED_NAME;

	private ContestSettings contestSetting;

	private ContestPlayerEntity[] playerEntityArray;

	private Sprite[] uiPlayerNumSprArray;

	private Sprite[] uiPlayerPlateSprArray;

	private StageModelObject stageModelObj;

	private StageEffect stageFx;

	private EnvironmentController envController;

	private Transform pokemonContent;

	private Transform mainCameraTransform;

	private BOCamera mainCamera;

	private BOCamera wazaCamera;

	private Camera wazaRenderCamera;

	private Camera wazaCompositorCamera;

	private ContestViewSystem contestViewSystem;

	private ContestViewSystem wazaViewSystem;

	private ContestHeartEmitter heartEmitter;

	private BOPokemon specialWazaModelPtr;

	private BOPokemon tempWazaModelPtr;

	private SpriteAtlas sceneUISpriteAtlas;

	private float initCompositorDepth;

	private int userIndex;

	private bool bLoadedStage;

	private bool bLoadedCharacter;

	private bool bPlayingWazaAnim;

	public bool IsReady => default(bool);

	public bool IsLoadingFx => default(bool);

	public Vector3 StageModelPosition => default(Vector3);

	public int UserIndex => default(int);

	public BOPokemon SpecialWazaModel => null;

	public EnvironmentController EnvController => null;

	public Camera MainCamera => null;

	public BOCamera MainBOCamera => null;

	public Camera WazaCamera => null;

	public BOCamera WazaBOCamera => null;

	public ContestViewSystem WazaViewSystem => null;

	public bool IsPlayingUserWaza => default(bool);

	public int NowMonitorIndex => default(int);

	public float NowMonitorPlayTime => default(float);

	public void SetScriptableObject(ContestSettings contestSetting)
	{
	}

	public void Initialize(Transform cluster)
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup()
	{
	}

	public void ResetParam(Vector3 initMainCamDofTargetPos, Vector3 initWazaCamDofTargetPos)
	{
	}

	public void StartContest()
	{
	}

	public void ResetDofParam(Vector3 initMainCamDofTargetPos, Vector3 initWazaCamDofTargetPos)
	{
	}

	public void Stop()
	{
	}

	public void CreateStageModel(Transform cluster, string path)
	{
	}

	public void CreatePlayerEntity(Transform cluster, AContestPlayerData playerData)
	{
	}

	public void SetAudienceUpdateFlag(bool flag)
	{
	}

	public void LoadContestFx(ContestDataModel dataModel)
	{
	}

	public void LoadResultFx()
	{
	}

	public void SetUISpriteAtlas(SpriteAtlas spriteAtlas)
	{
	}

	public Sprite GetSpriteByFileName(string fileName)
	{
		return null;
	}

	public Sprite GetUIPlayerNumberSpr(int index)
	{
		return null;
	}

	public void SetUIPlayerNumSpr(int index, Sprite spr)
	{
	}

	public Sprite GetUIPlayerPlateSpr(int index)
	{
		return null;
	}

	public void SetUIPlayerPlateSpr(int index, Sprite spr)
	{
	}

	public Sprite GetGraphicTextByFileName(string fileName)
	{
		return null;
	}

	public ContestPlayerEntity[] GetPlayerEntities()
	{
		return null;
	}

	public ContestPlayerEntity GetUserEntity()
	{
		return null;
	}

	public BattleViewCharacter GetTrainerByPosID(BtlvPos posID)
	{
		return null;
	}

	public BOPokemon GetPokemonByPosID(BtlvPos posID)
	{
		return null;
	}

	public AContestPlayerData GetPlayerDataByPosID(BtlvPos posID)
	{
		return null;
	}

	public AContestPlayerData GetPlayerDataByPosID(int index)
	{
		return null;
	}

	public AContestPlayerData GetUserPlayerData()
	{
		return null;
	}

	public Vector3 GetDefaultPokePos(BtlvPos posID)
	{
		return default(Vector3);
	}

	public Vector3 GetUserDefaultPokePos()
	{
		return default(Vector3);
	}

	public BOPokemon GetUserWazaModelPokemon()
	{
		return null;
	}

	public ObjectEntity GetBallObjEntityByPosID(int index)
	{
		return null;
	}

	public void SetEnvController(EnvironmentController envController)
	{
	}

	public void SetMainCamera(Camera mainCamera, Camera wazaCamera)
	{
	}

	public void ChangeMainCameraTag(bool useMainCamera)
	{
	}

	private void EnableCamera(Camera target)
	{
	}

	private void DisableCamera(Camera target)
	{
	}

	public void SetCameraParent(Transform newParent)
	{
	}

	public void ResetCameraParent()
	{
	}

	public void SetViewSystem(ContestViewSystem contestViewSystem, ContestViewSystem wazaViewSystem)
	{
	}

	public void StartContestWazaAnimation(int playerIndex)
	{
	}

	public void SetStagePositionOnWazaAnim()
	{
	}

	public void FinishContestWazaAnimation(int playerIndex)
	{
	}

	public void StartAnnounceTotalScore()
	{
	}

	public void OnFindSeqCommand_ContestHensin()
	{
	}

	public void PerformContestWaza_Hensin()
	{
	}

	public void SetAllPokemonAnimSound(bool enabled)
	{
	}

	public void PlayAllLightFxActive()
	{
	}

	public void StopAllLightFxActive()
	{
	}

	public void RegistVisualHeartUpdate()
	{
	}

	public void RemoveVisualHeartUpdate()
	{
	}

	public void EmitVisualHeart(int playerIndex)
	{
	}

	public DanceHeartEffect CreatePlayerHeart(Vector2 from, Vector2 to, EmitHeartPattern pattern, Action onComplete)
	{
		return null;
	}

	public DanceHeartEffect CreateNPCHeart(Vector2 from, Vector2 to, EmitHeartPattern pattern, Action onComplete)
	{
		return null;
	}

	public void SwitchMonitor()
	{
	}

	public BtlvBallInfo GetBallInfoByIndex(int index)
	{
		return default(BtlvBallInfo);
	}

	public void PlayAnnounceWinnerFx(int targetPlayerIndex)
	{
	}

	public void PlayConfettiFx(Vector3 emitPos)
	{
	}

	public void DevMovePosition()
	{
	}
}
