using System;
using System.Runtime.CompilerServices;
using Effect;
using UnityEngine;
using XLSXContent;

public class FieldCharacterEntity : FieldObjectEntity
{
	public new class SequenceID : FieldObjectEntity.SequenceID
	{
		protected new const int User = 12288;
	}

	public class Animation
	{
		public const int Idle = 0;

		public const int Walk = 1;

		public const int Run = 2;

		public const int Gesture0 = 3;

		public const int Gesture1 = 4;

		public const int FinishingStart = 5;

		public const int FinishingLoop = 6;

		public const int FinishingHit = 7;

		public const int FinishingEnd = 8;

		public const int HandOver = 9;

		public const int Sit = 10;

		public const int Waterning = 11;

		public const int Squat = 12;

		public const int GetPause = 13;

		public const int Poketch = 14;

		public const int Spin = 15;

		public const int BikeIdle = 16;

		public const int BikeWalk = 17;

		public const int BikeRun = 18;

		public const int JumpStart = 20;

		public const int JumpLoop = 21;

		public const int JumpEnd = 22;

		public const int Gesture2 = 23;

		public const int WallWalk = 24;

		public const int FishingFinishSuccsess = 25;

		public const int Suprised = 26;

		public const int SuprisedLoop = 27;

		public const int FishingHitLoop = 28;

		public const int FishingFinishSuccsessLoop = 29;

		public const int GrassWalk = 30;

		public const int GrassRun = 31;

		public const int WateringLoop = 32;

		public const int WateringEnd = 33;

		public const int OperationLoop = 36;

		public const int OperationEnd = 37;

		public const int SwampStart = 38;

		public const int SwampLoop = 39;

		public const int SwampEnd = 40;

		public const int NaminoriStart = 65;

		public const int NaminoriLoop = 12;

		public const int NaminoriEnd = 66;

		public const int NaminoriFishingStart = 67;

		public const int NaminoriFishingLoop = 68;

		public const int NaminoriFishingHit = 69;

		public const int NaminoriFishingHitLoop = 70;

		public const int NaminoriFishingEnd = 71;

		public const int NaminoriFishingSuccess = 72;

		public const int NaminoriFishingSuccessLoop = 73;

		public const int RockClimbUp = 74;

		public const int RockClimbDown = 75;

		public const int FlyStart = 76;

		public const int FlyEnd = 77;

		public const int NaminoriOperationStart = 78;

		public const int NaminoriOperationLoop = 79;

		public const int NaminoriOperationEnd = 80;

		public const int MaxLength = 78;
	}

	protected static readonly Vector2[] FaceUVs;

	public static float ViewerHandScale;

	public float HandScale;

	[SerializeField]
	protected AnimationPlayer _animationPlayer;

	[SerializeField]
	protected CurvePatterns _blinkPatterns;

	[SerializeField]
	protected FieldCharacterVariation[] _variations;

	[SerializeField]
	protected int _eyePatternIndex;

	[SerializeField]
	protected int _mouthPatternIndex;

	[SerializeField]
	protected int _currentVariation;

	[SerializeField]
	protected Renderer _watchRenderer;

	private int _blinkCurveIndex;

	private float _blinkTime;

	private int _UVOffsetID;

	protected MaterialPropertyBlock _propertyBlock;

	protected const float _MaxCoolTime = 13f / 30f;

	protected float[] _effectCoolTime;

	public Vector3 NeckAngle;

	public Vector3 _updateNeckAngle;

	public Vector3 _updateNeckAngle2;

	private Transform _subductionNode;

	private Transform _hipNode;

	public float SubductionDepth;

	private EffectInstance SwimEffect;

	private bool isPlayingSwimEffect;

	private EffectInstance _swimWalkEffect;

	private bool _isPlayingSwimWalkEffect;

	private bool _reqestStopFootEffect;

	private bool _isStopFootEffect;

	private float _stopFootEffectRetrunTime;

	private int _oldAnimEventIndex;

	private int _oldAnimClipIndex;

	private CharcterAnimeEvent.SheetanimeEvent[][] _animEvents;

	private Func<AnimationPlayer, bool> animeEndCallBack;

	public override string entityType => null;

	public Renderer watchRender
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool watchVisibility
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public FieldCharacterVariation[] variations
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CurvePatterns blinkPattern
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int eyePatternIndex => default(int);

	public int mouthPatternIndex => default(int);

	public int currentVariation => default(int);

	public Transform hipNode => null;

	public bool IsForceBlink
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

	public bool IsStopFootEffect
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override AnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	protected virtual void OnFootSE()
	{
	}

	protected virtual void OnFootEffect(int index)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnLateUpdate(float deltaTime)
	{
	}

	protected override bool SwitchToNext()
	{
		return default(bool);
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	private void LateUpdateNeckAngle(float deltaTime)
	{
	}

	public virtual void GetIdleAnimationIndex(out int index, out float duration)
	{
	}

	public int GetWalkAnimationIndex()
	{
		return default(int);
	}

	public void SetEyePattern(int index)
	{
	}

	public void SetMouthPattern(int index)
	{
	}

	public void SetAnimationEvents(CharcterAnimeTable tbl)
	{
	}

	private void UpdateSubductionDepth()
	{
	}

	private static float CalcSubductionDepth(Vector3 worldPotision)
	{
		return default(float);
	}

	private static float CalcSubductionDepthX(Vector3 gridPos, float worldPosX)
	{
		return default(float);
	}

	private static float GetSubductionDepth(Vector3 worldPosition)
	{
		return default(float);
	}

	private static float GetSubductionDepth(Vector2Int gridPosition, float height)
	{
		return default(float);
	}

	private static bool CheckSubductionEnableAttribute(Vector2Int gridPosition, float height)
	{
		return default(bool);
	}

	public bool IsSwimCharacter()
	{
		return default(bool);
	}

	private void UpdateSwim()
	{
	}

	private static bool CheckSwimEnableAttribute(Vector2Int gridPosition, float height)
	{
		return default(bool);
	}

	private void UpdateAnimEvent()
	{
	}

	public void SetAnimeEndCallBack(Func<AnimationPlayer, bool> callback)
	{
	}
}
