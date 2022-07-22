using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DPData;
using Dpr.BallDeco;
using Dpr.Battle.Logic;
using Dpr.Battle.View;
using Dpr.Battle.View.Objects;
using Dpr.Battle.View.Systems;
using Dpr.SequenceEditor;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.SealPreview;

public sealed class SealPreviewViewSystem : ISequenceViewSystem
{
	private bool m_isFinalize;

	private BTLV_WAZA_EFF_PARAM m_wazaParam;

	private BattleViewSystem.SequenceSeq m_sequenceSeq;

	private bool m_seqKeepResource;

	private bool m_isStartMsgDisplay;

	private int m_wazaMsgFrame;

	private bool m_reqCheckPinch;

	private bool m_canChangePinch;

	private bool m_isSoundPlayingFinishCheckInvalid;

	private int m_soundPlayingFinishWaitCount;

	private string m_playingSeqFileNameHash;

	private BattleDataTable m_battleDataTable;

	private BattleDefaultPlacementData m_defaultPlacementData;

	private BtlvPos[] m_comTargetPoke;

	private BtlvPos[] m_comTargetDamage;

	private BtlvPos[] m_comTargetTrainer;

	private BallId[] m_effectBallId;

	private BtlvBallInfo[] m_effectBallInfo;

	private Dictionary<int, HashSet<ObjectEntity>> m_uPtrModelHash;

	private Dictionary<int, HashSet<BtlvEffectInstance>> m_uPtrParticleVectorHash;

	private Stack<Tuple<int, uint, uint>> m_uPtrSoundPlayingIDHash;

	private BattleSequenceSystem m_iPtrSequenceSystem;

	private BattleCharacterSystem m_iPtrCharacterSystem;

	private SealPreviewCameraSystem m_iPtrCameraSystem;

	private BattleWeatherSystem m_iPtrWeatherSystem;

	private BattleGroundEffectSystem m_iPtrBattleGroundEffectSystem;

	private BattleStatusEffectObserverSystem m_iPtrStatusEffectObserverSystem;

	private Func<bool> m_pComWaitFunc;

	private TaskManager m_iPtrTaskManager;

	private TaskManager m_iPtrTaskManagerLate;

	private TaskManager m_iPtrTaskManagerAlways;

	private MainModule m_pMainModule;

	private BOTrainer[] trainers;

	private BattleCharacterEntity[] trainerEntities;

	private BOPokemon[] pokemons;

	private BattlePokemonEntity[] pokemonEntities;

	private AffixSealData[][] affixSealDatas;

	private int[] affixSealCounts;

	private List<BtlvEffectInstance> sealEffectInstances;

	private string setupIntroSequenceFilePath;

	private string playSequenceFilePath;

	private BtlRule btlRule;

	private bool isPause;

	private SealPreviewController _sealPreviewController;

	private BattleViewSystem.InitializeSequenceStateType _initializeSequenceState;

	private int _loadObjectCnt;

	private int _subSeq;

	private bool IsSoundPlayingFinishCheckInvalid => default(bool);

	private bool IsAllTaskFinished => default(bool);

	public bool IsReady => default(bool);

	public bool IsPlayEnd => default(bool);

	public bool IsStencilEnable
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float blurry
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private bool __IsSuspendSequenceSystem__ => default(bool);

	public TaskManager GetTaskManagerAlways()
	{
		return null;
	}

	public SealPreviewViewSystem(MainModule mainModule, BOCamera camera)
	{
	}

	public void SetTrainer(BtlvPos vPos, BOTrainer trainer, BattleCharacterEntity battleCharacterEntity)
	{
	}

	public void SetPokemon(BtlvPos vPos, BOPokemon pokemon, BattlePokemonEntity battlePokemonEntity)
	{
	}

	public void SetSealEffectData(BtlvPos vPos, AffixSealData[] affixSealDatas, int affixSealCount)
	{
	}

	public void RegisterSealEffectInstances(List<BtlvEffectInstance> instances)
	{
	}

	public void Setup()
	{
	}

	public void SetBattleRule(BtlRule btlRule)
	{
	}

	public bool GetSealEffectData(BtlvPos vPos, out AffixSealData[] affixSealDatas, out int affixSealCount)
	{
		return default(bool);
	}

	public void Dispose()
	{
	}

	private void SetupInrtoSequence()
	{
	}

	private void SetupThrowBallSequence()
	{
	}

	public IEnumerator SetupIntro()
	{
		return null;
	}

	public void Play()
	{
	}

	public void SetPause(bool isPause)
	{
	}

	public void Play(string path, bool isKeepResource = false)
	{
	}

	public BattleSequenceSystem GetSequenceSystem()
	{
		return null;
	}

	public BattleCharacterSystem GetCharacterSystem()
	{
		return null;
	}

	public SequenceCameraSystem GetCameraSystem()
	{
		return null;
	}

	public BattleWeatherSystem GetBattleWeatherSystem()
	{
		return null;
	}

	public BattleGroundEffectSystem GetBattleGroundEffectSystem()
	{
		return null;
	}

	public BTL_POKEPARAM GetBattlePokeParam(BtlvPos pos)
	{
		return null;
	}

	public MainModule GetMainModule()
	{
		return null;
	}

	public Dictionary<int, HashSet<BtlvEffectInstance>> GetParticleVectorHashTable()
	{
		return null;
	}

	public Stack<Tuple<int, uint, uint>> GetSoundPlayingIDHashTable()
	{
		return null;
	}

	public TaskManager GetTaskManager()
	{
		return null;
	}

	public TaskManager GetTaskManagerLate()
	{
		return null;
	}

	public BTLV_WAZA_EFF_PARAM GetWazaParam()
	{
		return default(BTLV_WAZA_EFF_PARAM);
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void SEQ_CMD_ResetDefaultCamera(int frame, SEQ_DEF_MOVETYPE moveType, SequenceCameraSystem system)
	{
	}

	public BTLV_WAZA_EFF_PARAM SetWazaParam(BTLV_WAZA_EFF_PARAM param)
	{
		return default(BTLV_WAZA_EFF_PARAM);
	}

	public void CheckWazaDataPath_Particle(ref string path, int idx, bool isBallEffect, bool isCapture, bool isAttributeEffect, bool isStreamLineEffect)
	{
	}

	private BallId __SeqComFunc_GetEffectBallId__(int idx)
	{
		return default(BallId);
	}

	public BtlvBallInfo SeqComFunc_GetEffectBallInfo(int idx)
	{
		return default(BtlvBallInfo);
	}

	public string GetBallModelPath(int idx)
	{
		return null;
	}

	public string GetBttleWazaModelPath(string idx)
	{
		return null;
	}

	public void GetDefaultPokePos(BtlvPos vPos, ref Vector3 pos, ref int deg, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	public PartyDesc __GetPartySetupParam__(byte clientId)
	{
		return null;
	}

	public BOPokemon GetPokeModel(BtlvPos vPos)
	{
		return null;
	}

	public Size GetPokeSize(BattleViewSystem.BattleViewSide side, bool isGPoke = false)
	{
		return default(Size);
	}

	public BattleViewCharacter GetTrainerModel(BtlvPos vPos)
	{
		return null;
	}

	public void ResetAll()
	{
	}

	public void ResetPokemon(BtlvPos vPos, int frame, SEQ_DEF_MOVETYPE moveType, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	public void ResetTrainer(BtlvPos vPos, bool isOrigin, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	public void SeqComFunc_CalcPokeDir(Vector3 nowPos, BtlvPos trgPoke, SEQ_DEF_NODE trgNode, ref Vector3 retRot, bool isVertical)
	{
	}

	public void SeqComFunc_CalcPosDir(Vector3 nowPos, Vector3 trgPos, ref Vector3 retRot, bool isVertical)
	{
	}

	public void SeqComFunc_GetPokeFiledPos(ref Vector3 retPos, ref Vector3 retRot, BtlvPos plater, bool isAttack)
	{
	}

	public void SeqComFunc_GetPokeRelativePos(ref RELARIVE_POKE_OPTION opt, ref Vector3 pRetPos, ref Vector3 pRetRot, ref Vector3 pRetScale, bool isCameraAdjust)
	{
	}

	public void SeqComFunc_GetSpecialPos(SEQ_DEF_SPPOS trgType, ref Vector3 retPos, ref Vector3 retRot)
	{
	}

	public BtlvPos SeqComFunc_GetTargetCharaVPos(SEQ_DEF_TRAINER target, int index = 0)
	{
		return default(BtlvPos);
	}

	public BattleViewCharacter SeqComFunc_GetTargetChara(SEQ_DEF_TRAINER trg, int idx = 0)
	{
		return null;
	}

	public BattleViewCharacter SeqComFunc_GetTargetChara(SEQ_DEF_TRAINER_ADD trg, int idx = 0)
	{
		return null;
	}

	public int SeqComFunc_GetTargetPokeNum(bool isCheck = true)
	{
		return default(int);
	}

	public BtlvPos SeqComFunc_GetTargetPokeSub(SEQ_DEF_POS target)
	{
		return default(BtlvPos);
	}

	public BtlvPos SeqComFunc_GetTargetPoke_Org(int idx)
	{
		return default(BtlvPos);
	}

	public BtlvPos SeqComFunc_GetTargetPoke(SEQ_DEF_POS target, int index = 0)
	{
		return default(BtlvPos);
	}

	public bool SeqComFunc_IsFlipEffect(BtlvPos target, BtlvPos subTarget)
	{
		return default(bool);
	}

	public void SeqComFunc_MoveRelativePoke(ITranslationObject iPtrObj, int frame, RELARIVE_POKE_OPTION opt, bool isTrainer = false)
	{
	}

	public void SeqComFunc_MoveSpecialPos(ITranslationObject iPtrObj, int frame, SEQ_DEF_SPPOS trgType, Vector3 ofs, bool isRotate, bool isFlip)
	{
	}

	public void __SetCanChangePinch__(bool value)
	{
	}

	public void SetIsSoundPlayingFinishCheckInvalid(bool value)
	{
	}

	public void __SetReqCheckPinch__(bool value)
	{
	}

	public void SetTerrainChipVisibility(bool disp)
	{
	}

	public void StartWeather(BtlWeather weather)
	{
	}

	public void SetSuspendSequenceFunc(SEQ_DEF_WAIT type)
	{
	}

	private bool __SeqComWaitFunc_Message__()
	{
		return default(bool);
	}

	private bool __SeqComWaitFunc_LoadPoke__()
	{
		return default(bool);
	}

	private bool __SeqComWaitFunc_SelectMessage__()
	{
		return default(bool);
	}

	private bool __SeqComWaitFunc_UIBag__()
	{
		return default(bool);
	}

	private bool __SeqComWaitFunc_UITrainerName__()
	{
		return default(bool);
	}

	private bool __SeqComWaitFunc_UIFog__()
	{
		return default(bool);
	}

	public bool CheckCanPlayCommand(CommandParam param)
	{
		return default(bool);
	}

	public void OnLateUpdate(float deltaTime)
	{
	}

	private void __UpdateSequence__()
	{
	}

	private void __UpdateSuspendSequenceSystem__()
	{
	}

	private void __GetDefaultTrainerPos__(BtlvPos vPos, ref Vector3 pPos, ref int pDeg, bool isOrigin, SEQ_DEF_DEFAULT_PLACEMENT placement)
	{
	}

	private void __StartLoadSequence__()
	{
	}

	private void __SaveFog__()
	{
	}

	private bool __WaitSequenceResource__()
	{
		return default(bool);
	}

	private bool __WaitLoadSequence__()
	{
		return default(bool);
	}

	private bool __IsWazaMsgCommandSeq__()
	{
		return default(bool);
	}

	private void __StartWazaMsgCommand__()
	{
	}

	private bool __WaitWazaMsgCommand__()
	{
		return default(bool);
	}

	private void __SetComTargetReset__()
	{
	}

	public BtlRule GetBattleRule()
	{
		return default(BtlRule);
	}

	private BallId __GetCaptureBall__(BtlvPos vPos)
	{
		return default(BallId);
	}

	private BtlvBallInfo __GetBallInfo__(BtlvPos vPos)
	{
		return default(BtlvBallInfo);
	}

	public bool IsFriendExist()
	{
		return default(bool);
	}

	private void __PlaySequenceCore__(string path, bool keepResource = false)
	{
	}

	private SealPreviewSetupParam GetSetupParam()
	{
		return default(SealPreviewSetupParam);
	}

	public SealPreviewViewSystem([In] ref SealPreviewController controller)
	{
	}

	public void UnInitialize()
	{
	}

	public bool Initialize()
	{
		return default(bool);
	}

	private IEnumerator SetupBackground()
	{
		return null;
	}

	private void LoadTrainerModel(MYSTATUS status, BtlvPos vPos)
	{
	}

	private void LoadPokemonModel(PokemonParam param, BtlvPos vPos)
	{
	}

	private void StartGround()
	{
	}

	public void CMD_StartSetup_ThrowSelf()
	{
	}

	public bool CMD_WaitStartSetup_ThrowSelf()
	{
		return default(bool);
	}

	private void PlaySequenceCore(string path, bool isKeepResource = false)
	{
	}

	private bool __WaitSequence__()
	{
		return default(bool);
	}
}
