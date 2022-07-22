using System.Runtime.CompilerServices;
using Dpr.Battle.View;
using Dpr.Playables;
using UnityEngine;

public class BattleCharacterEntity : BattleObjectEntity
{
	public new class SequenceID : BaseEntity.SequenceID
	{
		public const int Active = 4096;

		protected new const int User = 8192;

		public const int None = 12288;

		public const int Advent = 16384;

		public const int Order = 20480;

		public const int Animation = 24576;

		public const int ToWait = 28672;

		public const int ToLose = 32768;

		public const int ToSpeak = 36864;
	}

	public enum AnimationState
	{
		Advent02_B,
		Advent_B,
		Wait_B,
		Wait02_B,
		Order_B,
		Lose01_B,
		Speak01_B,
		Win01_B,
		Speak02_B,
		Walk_B,
		Run_B,
		Advent03_B,
		Advent04_B,
		Advent05_B
	}

	public enum AnimationStateEye
	{
		Eye01_B
	}

	private const float LOSE_LOOP_START_TIME = 2f;

	[SerializeField]
	protected BattleAnimationPlayer _animationPlayer;

	[SerializeField]
	protected ColorVariation _colorVariation;

	[SerializeField]
	protected float _motionBlendTime;

	protected bool _isEnableAnimationPlayer;

	private float _speakStartTime;

	public override string entityType => null;

	public TrainerSimpleParam TrainerSimpleParam
	{
		[CompilerGenerated]
		get
		{
			return default(TrainerSimpleParam);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public virtual void Initialize(TrainerSimpleParam param, bool isContest = false)
	{
	}

	protected void SetSkinColor(int colorId)
	{
	}

	public int GetSkinColor()
	{
		return default(int);
	}

	private void CreateShadowCastSystem()
	{
	}

	public virtual void SetCaputureDemo()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	public virtual void RequestSequence(int sequenceID)
	{
	}

	public void RequestAnimationState(AnimationState state, float duration = 0.15f, float startTime = 0f, bool isLoop = false)
	{
	}

	public new BattleAnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	public void SetAnimationSpeed(float animationSpeed)
	{
	}

	public virtual void SetRenderActive(bool isActive)
	{
	}
}
