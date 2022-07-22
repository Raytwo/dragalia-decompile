using System;
using System.Runtime.CompilerServices;
using Dpr;
using SmartPoint.Components;
using UnityEngine;

public class FieldPokemonEntity : FieldObjectEntity
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

		public const int JumpOut = 3;

		public const int Fall = 4;

		public const int Landing = 5;

		public const int Buturi01 = 6;

		public const int Tokusyu01 = 7;

		public const int Roar01 = 9;

		public const int Damage = 15;

		public const int BaWaitToFiWait = 17;

		public const int BaWaitToKwWait = 18;

		public const int FiWaitToBaWait = 19;

		public const int FiWaitToKwWait = 20;

		public const int KwWaitToBaWait = 21;

		public const int KwWaitToFiWait = 22;

		public const int FieldWait1 = 24;

		public const int FieldWait2 = 25;

		public const int WaitToWalk = 26;

		public const int WalkToWait = 27;

		public const int RunToWait = 28;

		public const int WaitToRun = 29;

		public const int RunToWalk = 30;

		public const int WalkToRun = 31;

		public const int Kw_Wait = 32;

		public const int Kw_Turn = 34;

		public const int Kw_DrowseA = 36;

		public const int Kw_DrowseB = 37;

		public const int Kw_DrowseC = 38;

		public const int Hate = 41;

		public const int Happy01 = 43;

		public const int Happy02 = 44;

		public const int Happy03 = 45;

		public const int MoveA = 46;

		public const int MoveB = 47;

		public const int MoveC = 48;

		public const int MoveD = 49;

		public const int Lonely = 50;

		public const int EatA = 54;

		public const int EatB = 55;

		public const int EatC = 56;

		public const int CloseEye = 57;
	}

	[SerializeField]
	private float scale;

	[SerializeField]
	protected AnimationPlayer _animationPlayer;

	[SerializeField]
	protected SkinnedMeshRendererCluster[] _rendererClusters;

	[SerializeField]
	protected PokeAnimSound _pokeAnimSound;

	[SerializeField]
	protected bool[] _blinkEnables;

	[SerializeField]
	public bool hasLandingSequence;

	[SerializeField]
	public int eyeIndex;

	[SerializeField]
	public bool autoBlinkEnable;

	[NonSerialized]
	public bool updateEnable;

	private MaterialPropertyBlock _propertyBlock;

	private Transform _originBone;

	private readonly int[] _blinkPatterns;

	private const float BlinkIntervalMax = 12f;

	private const float BlinkIntervalMin = 3f;

	private float _blinkIntervalTime;

	private float _blinkTime;

	private int _blinkIndex;

	private bool _enablePlayInitialIdleAnimation;

	private Animator _animator;

	private bool reOnEnable;

	private int wait;

	public override string entityType => null;

	public bool[] blinkEnables
	{
		set
		{
		}
	}

	public PokemonPrefabInfo PrefabInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SkinnedMeshRendererCluster[] rendererCluster => null;

	public override AnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	public PokeAnimSound GetPokeAnimSound()
	{
		return null;
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

	public int GetIdleAnimationIndex()
	{
		return default(int);
	}

	public int GetWalkAnimationIndex()
	{
		return default(int);
	}

	public void EnablePlayInitialIdleAnimation(bool enabled)
	{
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	private void AK_EffectStart00(int value)
	{
	}

	private void AK_EffectStart01(int value)
	{
	}

	private void AK_ButuriStart01(int value)
	{
	}

	private void AK_SEStart01(int value)
	{
	}

	private void AK_SEStart02(int value)
	{
	}

	private void AK_SEStart03(int value)
	{
	}

	private void AK_SEStart04(int value)
	{
	}

	private void AK_PartsMaterial01(int value)
	{
	}

	private void AK_PartsSkel01(int value)
	{
	}

	public void SetAlwaysAnimateCullingMode()
	{
	}

	private void ReOnEnable()
	{
	}
}
