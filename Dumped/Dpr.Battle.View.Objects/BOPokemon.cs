using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Dpr.SequenceEditor;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.View.Objects;

public sealed class BOPokemon : BattleViewCharacter
{
	private const float MIGAWARI_SIZE_M = 1.5f;

	private const float MIGAWARI_SIZE_L = 2f;

	private const float DHIGUDA_STONE_SIZE = 0.2f;

	private const float DAGUTORIO_STONE_SIZE = 0.4f;

	private const float ANIM_SPEED_STATUS_ABNORMALITY = 0.5f;

	private const float ANIM_SPEED_STATUS_ABNORMALITY_KOORI = 0f;

	private BattlePokemonEntity _entity;

	private PokemonParam _param;

	private BattlePokemonEntity.AnimationState _lastPlayAnimationState;

	private MotionTimingData _motionTimingData;

	private BattleDataTable.SheetMotionReplaceData _motionReplaceData;

	private bool m_isPlayPinchSoundRTPC;

	private bool m_isPlayPinchSound;

	private ObjectEntity _iPtrMigawariObject;

	private ObjectEntity _iPtrDigudaStone;

	public BattlePokemonEntity Entity => null;

	public PokemonParam Param => null;

	public bool IsEnableFloat
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsVisibleDigudaStone
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

	public bool HitBackFlg
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

	public bool IsVisibleMigawari
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

	public ObjectEntity MigawariObject => null;

	public bool IsVisibleTame
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

	public GState IsGChange => default(GState);

	public bool IsDisp => default(bool);

	public BattlePokemonEntity.AnimationState CurrentAnimationState => default(BattlePokemonEntity.AnimationState);

	public float CurrentRemaingTime => default(float);

	public void Initialize(BtlvPos vPos, PokemonParam param)
	{
	}

	private static int GetUniqueID(MonsNo monsNo, int formNo)
	{
		return default(int);
	}

	private void SetupAdjustHeight()
	{
	}

	public override void StartDelete()
	{
	}

	public override void OnUpdatePreJob(float deltaTime)
	{
	}

	protected override void UpdateVisible()
	{
	}

	public Size GetSize()
	{
		return default(Size);
	}

	public LandingType GetPokeLandingType()
	{
		return default(LandingType);
	}

	public LandingType GetPokeLandingEXType()
	{
		return default(LandingType);
	}

	public MotionTimingData GetMotionTimingData()
	{
		return default(MotionTimingData);
	}

	public void SetMotionTimingData(MotionTimingData data)
	{
	}

	public float GetCamAdjustHeight()
	{
		return default(float);
	}

	public float GetAdjustHeight()
	{
		return default(float);
	}

	public PokeEffWeight CheckPokemonEffectWeight()
	{
		return default(PokeEffWeight);
	}

	public void GetNodeBasePositionSequence(SEQ_DEF_NODE node, ref Vector3 pRetPos)
	{
	}

	public void GetNodePositionSequence(SEQ_DEF_NODE node, ref Vector3 pos)
	{
	}

	private bool GetNodeBaseMatrixSequenceCore(SEQ_DEF_NODE node, ref Vector3 pos)
	{
		return default(bool);
	}

	public bool GetNodeJointModelSpaceMatrix(JointName jointName, ref Vector3 retPos)
	{
		return default(bool);
	}

	public Transform GetNodeTransformSequence(SEQ_DEF_NODE node)
	{
		return null;
	}

	public BattlePokemonEntity.AnimationState GetLastPlayAnim()
	{
		return default(BattlePokemonEntity.AnimationState);
	}

	public BattlePokemonEntity.AnimationState CheckReplaceWazaAnimationState(BattlePokemonEntity.AnimationState state, WazaNo wazaNo)
	{
		return default(BattlePokemonEntity.AnimationState);
	}

	public BattlePokemonEntity.AnimationState CheckReplaceAnimationState(BattlePokemonEntity.AnimationState state)
	{
		return default(BattlePokemonEntity.AnimationState);
	}

	public void ChangeAnimStatePoke(BattlePokemonEntity.AnimationState state, float duration = 0.15f, float startTime = 0f)
	{
	}

	protected override void UpdateAnimSpeed()
	{
	}

	public void PostPokeVoice(JointName joint, string voiceName, VOICE_TYPE voiceType)
	{
	}

	private void PostEventAnimationSoundComponent(string eventName, JointName joint)
	{
	}

	public PokeVoiceParameter GetPokeVoiceParams(string voiceName, VOICE_TYPE voiceType)
	{
		return default(PokeVoiceParameter);
	}

	public bool GetRTPC_IsPlayPinchSound()
	{
		return default(bool);
	}

	public void SetRTPC_IsPlayPinchSound(bool value)
	{
	}

	public bool GetIsPlayPinchSound()
	{
		return default(bool);
	}

	public void SetIsPlayPinchSound(bool value)
	{
	}

	public void SetEnableFloat(bool flg)
	{
	}

	public void SetVisibleDigudaStone(bool value)
	{
	}

	private void CreateDigudaStone()
	{
	}

	public void SetVisibleTame(bool value)
	{
	}

	public void SetVisibleMigawari(bool value)
	{
	}

	public bool IsLoadedMigawari()
	{
		return default(bool);
	}

	private void CreateMigawari()
	{
	}

	public void DisableSleepEye(bool value)
	{
	}

	public override void SetVisibleShadow(bool value)
	{
	}
}
