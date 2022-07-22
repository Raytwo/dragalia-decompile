using System;
using Dpr.Battle.View;
using Dpr.Battle.View.Systems;
using Dpr.Trainer;
using UnityEngine;

public abstract class BattleObjectEntity : BaseEntity
{
	public enum ModelEntityType
	{
		Unknown = -1,
		Battle,
		Contest
	}

	[Serializable]
	public class CharaAutomaticBlinkProcess
	{
		public enum BlinkType
		{
			Unknown = -1,
			Pokemon,
			Trainer
		}

		public enum EyeType
		{
			Normal,
			HalfClosed,
			Closed,
			Damage,
			Angry,
			Happy,
			Sad,
			Reserve
		}

		public enum BlinkIntParameter
		{
			Default = 0,
			Sleep = 3
		}

		public enum CurveValueType
		{
			LocalRotation,
			LocalPosition,
			LocalScale
		}

		public enum BlinkPhase
		{
			NONE,
			ONCE,
			TWICE
		}

		[Serializable]
		public class BlinkValue
		{
			[SerializeField]
			private Transform _targetNode;

			[SerializeField]
			private CurveValueType _curveValueType;

			[SerializeField]
			private Vector4[] _values;

			public Transform TargetNode
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public CurveValueType CurveValueType
			{
				get
				{
					return default(CurveValueType);
				}
				set
				{
				}
			}

			public Vector4[] Values
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public const EyeType EYE_TYPE_NEUTRAL = EyeType.Normal;

		public const float BLINKING_TIME_MAX = 2f;

		private static readonly EyeType[] EYE_BLINK_TABLE;

		[SerializeField]
		private BlinkType _blinkType;

		[SerializeField]
		private bool _isBlinkEnabled;

		[SerializeField]
		private bool[] _eye01;

		[SerializeField]
		private BlinkValue[] _blinkValues;

		[SerializeField]
		private EyeType _currentEyeType;

		private int _currentState;

		public TrainerAge trainerAge;

		public int blinkIntervalTimeMin;

		public int blinkIntervalTimeMax;

		public int blinkTwiceRate;

		private bool _isConstantBlink;

		private BlinkPhase _prevExecuteBlinkPhase;

		private BlinkPhase _blinkPhase;

		private BlinkIntParameter _prevParameter;

		private BlinkIntParameter _requestParameter;

		private BattleObjectEntity _entity;

		private float _blinkIntervalTime;

		private float _blinkingTime;

		private int _blinkStep;

		public bool IsConstantBlink
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void CreateBlinkProcess(BattleObjectEntity entity)
		{
		}

		public void SetConstantBlink(bool isEnable)
		{
		}

		public void SetBlinkEnabled(bool value)
		{
		}

		public bool IsBlinkEnabled()
		{
			return default(bool);
		}

		public bool IsBlinking()
		{
			return default(bool);
		}

		public void SetBlinkTriggerParam(BlinkIntParameter param)
		{
		}

		private void SetBlinkState(EyeType type)
		{
		}

		public bool IsDefaultEyeTypeAnimState()
		{
			return default(bool);
		}

		public void OnUpdate(float deltaTime)
		{
		}

		private void OnUpdateBlink(float deltaTime)
		{
		}

		private bool UpdateBlink(float deltaTime)
		{
			return default(bool);
		}

		private void StartBlink()
		{
		}

		private void DoSettingOnEndBlink()
		{
		}

		private void ChangeBlinkPhase(BlinkPhase phase)
		{
		}

		private void ResetBlinkPhace()
		{
		}

		private BlinkPhase DecideNextBlinkPhase()
		{
			return default(BlinkPhase);
		}

		private bool CanFirstBlinkStart()
		{
			return default(bool);
		}

		private bool CanSecondBlinkStart()
		{
			return default(bool);
		}
	}

	[SerializeField]
	protected CharaAutomaticBlinkProcess _blinkProcess;

	[SerializeField]
	protected Renderer[] _renderers;

	[SerializeField]
	protected Transform[] _locators;

	[SerializeField]
	protected ModelEntityType _modelEntityType;

	protected float _animationSpeed;

	protected BattleShadowCastSystem _shadowCastSystem;

	protected Animator _animator;

	protected RendererInfo[] _rendererInfos;

	public Animator Animator => null;

	public Renderer[] Renderers => null;

	public BattleShadowCastSystem ShadowCastSystem => null;

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

	protected virtual void OnEarlyLateUpdate(float deltatime)
	{
	}

	protected virtual void OnPostLateUpdate(float deltaTime)
	{
	}

	public Transform GetJoint(JointName jointName)
	{
		return null;
	}

	public Transform GetJointByName(string name)
	{
		return null;
	}

	public CharaAutomaticBlinkProcess GetAutomaticBlinkProcess()
	{
		return null;
	}

	protected void InitializeRendererInfos()
	{
	}
}
