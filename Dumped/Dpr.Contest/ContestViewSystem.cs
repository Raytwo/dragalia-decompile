using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View;
using Dpr.Battle.View.Objects;
using Dpr.Battle.View.Systems;
using Dpr.Message;
using Dpr.SequenceEditor;
using Pml;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.Contest;

public class ContestViewSystem : ISequenceViewSystem
{
	public enum ViewSystemType
	{
		Main,
		Waza
	}

	private const float INVALID_COMMAND_OFFSET_END_TIME = 3f;

	private Dictionary<int, HashSet<ObjectEntity>> hashTabel;

	private SceneObjectManager objManager;

	private BattleViewSystem.SequenceSeq m_sequenceSeq;

	private BattleSequenceSystem m_iPtrSequenceSystem;

	private SequenceCameraSystem cameraSystem;

	private BTLV_ATTR_EFF_PARAM m_attrEffParam;

	private Dictionary<int, HashSet<BtlvEffectInstance>> m_uPtrParticleVectorHash;

	private Stack<Tuple<int, uint, uint>> m_uPtrSoundPlayingIDHash;

	private BattleScreenObject m_iPtrScreenObject;

	private Func<bool> m_pComWaitFunc;

	private BTLV_WAZA_EFF_PARAM m_wazaParam;

	private TaskManager m_iPtrTaskManager;

	private TaskManager m_iPtrTaskManagerLate;

	private TaskManager m_iPtrTaskManagerAlways;

	private Coroutine coroutine;

	private MessageMsgFile contestMsgFile;

	private int m_soundPlayingFinishWaitCount;

	private ViewSystemType currentViewSystemType;

	private Action<CommandNo, ContestViewSystem> onFindCommand;

	private Action<CommandNo, ContestViewSystem, Macro> onPerformCommand;

	private string seqFilePath;

	private bool m_seqKeepResource;

	private bool canOpenMsgWindowFlag;

	private bool ready;

	public bool IsReady => default(bool);

	public bool IsLoaded => default(bool);

	public bool IsPause => default(bool);

	public ViewSystemType SystemType => default(ViewSystemType);

	public bool IsEnd => default(bool);

	public float MaxTime => default(float);

	private bool __IsSuspendSequenceSystem__ => default(bool);

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

	public bool CanOpenMsgWindow => default(bool);

	public void CMD_ACT_WazaEffect_Start(MonsNo monsNo, WazaNo wazaNo, int formNo, PokeType type1, PokeType type2, SequenceCameraSystem cameraSystem, Action<CommandNo, ContestViewSystem> onFindCommand, Action<CommandNo, ContestViewSystem, Macro> onPerformCommand)
	{
	}

	public void CMD_ACT_ContestMain_Start(string path, SequenceCameraSystem cameraSystem, Action<CommandNo, ContestViewSystem> onFindCommand, Action<CommandNo, ContestViewSystem, Macro> onPerformCommand)
	{
	}

	private void SetupSequence(string path)
	{
	}

	private void CommonSettings(SequenceCameraSystem cameraSystem)
	{
	}

	private IEnumerator IE_SetupSequence()
	{
		return null;
	}

	public void UnloadAb()
	{
	}

	public void OnFinalize()
	{
	}

	public void Play()
	{
	}

	public void SetPause(bool pause)
	{
	}

	public void CMD_ACT_WazaEffect_Load(MonsNo monsNo, WazaNo wazaNo, int formNo, PokeType type1, PokeType type2)
	{
	}

	public void SetAudioListenerPositionUpdate(bool flag)
	{
	}

	public BattleScreenObject GetScreenObject()
	{
		return null;
	}

	private void SetupWazaParam(WazaNo waza)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateSuspendSequenceSystem()
	{
	}

	private void __UpdateSequence__()
	{
	}

	public void OnLateUpdate(float deltaTime)
	{
	}

	private bool __WaitLoadSequence__()
	{
		return default(bool);
	}

	public BTL_POKEPARAM GetBattlePokeParam(BtlvPos pos)
	{
		return null;
	}

	public byte GetBtlvPosToClientId(BtlvPos vpos)
	{
		return default(byte);
	}

	public byte GetClientID()
	{
		return default(byte);
	}

	public byte GetEnemyClientID(byte idx)
	{
		return default(byte);
	}

	public MainModule GetMainModule()
	{
		return null;
	}

	public Dictionary<int, HashSet<ObjectEntity>> GetModelHashTable()
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

	public ushort GetTrainerType(byte clientID)
	{
		return default(ushort);
	}

	public BTLV_WAZA_EFF_PARAM GetWazaParam()
	{
		return default(BTLV_WAZA_EFF_PARAM);
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

	public BTLV_ATTR_EFF_PARAM GetAttrEffParam()
	{
		return default(BTLV_ATTR_EFF_PARAM);
	}

	public string GetBallModelPath(int idx)
	{
		return null;
	}

	public string GetBttleWazaModelPath(string idx)
	{
		return null;
	}

	public SequenceCameraSystem GetCameraSystem()
	{
		return null;
	}

	public BattleCharacterSystem GetCharacterSystem()
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

	public bool __IsCanChangePinch__()
	{
		return default(bool);
	}

	public bool __IsReqCheckPinch__()
	{
		return default(bool);
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

	public void SetSuspendSequenceFunc(SEQ_DEF_WAIT type)
	{
	}

	public BattleSequenceSystem GetSequenceSystem()
	{
		return null;
	}

	public void __ClearSetWords__()
	{
	}

	public MessageTextParseDataModel __GetTextParseData__(string labelName)
	{
		return null;
	}

	public AContestPlayerData __GetPlayerData__(int index)
	{
		return null;
	}

	public AContestPlayerData __GetUserData_()
	{
		return null;
	}

	public bool CheckCanPlayCommand(CommandParam param)
	{
		return default(bool);
	}

	private BtlvPos ConvertPokeTrgTovPos(int value)
	{
		return default(BtlvPos);
	}

	public void FindContestCommand(Macro macro)
	{
	}

	public void PerformContestCommand(Macro macro)
	{
	}

	public void SetCanOpenMsgWindowFlag(bool flag)
	{
	}

	public void SetTerrainChipVisibility(bool disp)
	{
	}

	public void StartWeather(BtlWeather weather)
	{
	}

	public BattleWeatherSystem GetBattleWeatherSystem()
	{
		return null;
	}

	public BattleGroundEffectSystem GetBattleGroundEffectSystem()
	{
		return null;
	}

	public BtlvBallInfo SeqComFunc_GetEffectBallInfo(int idx)
	{
		return default(BtlvBallInfo);
	}
}
