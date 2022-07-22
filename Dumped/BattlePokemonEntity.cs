using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr;
using Dpr.Battle.View;
using Dpr.Battle.View.Objects;
using Pml.PokePara;
using SmartPoint.Components;
using UnityEngine;
using UnityEngine.Rendering;
using XLSXContent;

public sealed class BattlePokemonEntity : BattleObjectEntity
{
	public new class SequenceID : BaseEntity.SequenceID
	{
		public const int Active = 4096;

		protected new const int User = 8192;

		public const int Attack = 12288;

		public const int Animation = 16384;

		public const int ToDown = 20480;

		public const int ToLandState = 24576;

		public const int ToBlend = 28672;

		public const int ToWaitB = 32768;

		public const int ToWaitC = 36864;
	}

	public enum AnimationState
	{
		WaitA01,
		WaitB01,
		LandA01,
		LandB01,
		LandC01,
		Buturi01,
		Buturi02,
		Buturi03,
		Tokusyu01,
		Tokusyu02,
		Tokusyu03,
		BodyBlow,
		Punch,
		Kick,
		Tail,
		Bite,
		Peck,
		Radial,
		Cry,
		Dust,
		Shot,
		Guard,
		TurnNormal,
		TurnSmile,
		Damage,
		Down,
		Roar01,
		F_Walk,
		F_Happy,
		F_Hate,
		F_Eat,
		F_Happy_A,
		F_Happy_C,
		WaitC01,
		Wait04,
		Max
	}

	[Serializable]
	public struct RenderingParam
	{
		public int stencilRef;

		public CompareFunction stencilComp;

		public StencilOp stencilOp;

		public static RenderingParam Factory()
		{
			return default(RenderingParam);
		}
	}

	public const float DEFAULT_MOTION_TRANSITION_TIME = 0f;

	public const float DEFAULT_MOTION_START_TIME = 0f;

	private const float DEFAULT_MOTION_BLEND_TIME = 0.14f;

	[SerializeField]
	private AnimationPlayer _animationPlayer;

	[SerializeField]
	private Size _size;

	[SerializeField]
	private float _scale;

	[SerializeField]
	private LandingType _landingType;

	[SerializeField]
	private AnimationState _animationState;

	[SerializeField]
	private RenderingParam _renderingParam;

	[SerializeField]
	private SkinnedMeshRendererCluster[] _rendererClusters;

	[SerializeField]
	private PokeAnimSound _pokeAnimSound;

	private MaterialPropertyBlock _propertyBlock;

	private Color _fixMultiplierColor;

	private SimpleParam _simpleParam;

	private Vector3 _adjustScale;

	private Transform _origin;

	private Dictionary<int, int> _renderObjectMasks;

	private float _motionBlendTime;

	public bool isAnimationWaitAWhenDisable;

	private int waitALoopCount;

	private bool _isPokeAnimSoundEnable;

	public bool isZIBAKOIRU;

	public BattleDataTable.SheetPokemonMotionBlendTime PokemonMotionBlendTimeData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override string entityType => null;

	public Size Size => default(Size);

	public LandingType LandingType => default(LandingType);

	public AnimationState CurrentAnimationState
	{
		get
		{
			return default(AnimationState);
		}
		private set
		{
		}
	}

	public bool PokeAnimSoundEnable
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public Color FixMultiplierColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private PokemonVariation PokemonVariation
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public PokemonCustomNodeAnim PokemonCustomNodeAnim
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

	private PokemonAnime PokemonAnime
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private PokemonPrefabInfo PokemonPrefabInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private PatcheelPattern patcheelPattern
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
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

	protected override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnEarlyLateUpdate(float deltatime)
	{
	}

	private void LateUpdate()
	{
	}

	protected override void OnLateUpdate(float deltaTime)
	{
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	public void Initialize(PokemonInfo.SheetCatalog catalog, bool isContest = false)
	{
	}

	private void CreateShadowCastSystem()
	{
	}

	public SimpleParam GetSimpleParam()
	{
		return default(SimpleParam);
	}

	public void ResetAnimation()
	{
	}

	public override AnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	public void RequestAnimationState(AnimationState state, float duration = 0f, float startTime = 0f)
	{
	}

	public void SetAnimationSpeed(float animationSpeed)
	{
	}

	public float GetAnimationSpeed()
	{
		return default(float);
	}

	public void SetBlinkEnabled(bool value)
	{
	}

	public void SetBlinkIntParameter(CharaAutomaticBlinkProcess.BlinkIntParameter param)
	{
	}

	public PokeAnimSound GetPokeAnimSound()
	{
		return null;
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

	public void SetRenderActive(bool isActive)
	{
	}

	private void UpdateFixMultiplyColor()
	{
	}

	public RenderingParam GetRenderingParam()
	{
		return default(RenderingParam);
	}

	public void SetStencilWriteValue(bool f, int value)
	{
	}

	private void AdjustModel()
	{
	}

	public ModelEntityType GetModelEntityType()
	{
		return default(ModelEntityType);
	}

	public void SetPatcheelPattern(uint rand)
	{
	}
}
