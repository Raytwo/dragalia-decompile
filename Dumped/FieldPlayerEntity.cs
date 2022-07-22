using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;
using Dpr;
using Effect;
using UnityEngine;
using XLSXContent;

public class FieldPlayerEntity : FieldCharacterEntity
{
	public new class SequenceID : FieldCharacterEntity.SequenceID
	{
		public const int Jump = 16385;

		public const int Landing = 16386;

		public const int HoleJump = 16387;

		public const int Fishing = 16388;

		public const int BicycleJump = 16389;

		public const int SandClimbFail = 16390;

		public const int SandClimbSucsess = 16391;

		public const int SandFall = 16392;

		public const int EventMove = 16393;

		public const int FormChange = 16400;

		public const int IceFloor = 16401;

		public const int MoveFloor = 16402;

		public const int SwampDeep = 16403;

		public const int HoleOutJump = 16404;

		protected new const int User = 16384;
	}

	public class CheckGridCollisionFunc : FieldGridCollision.ICheckGridFunc
	{
		public FieldGridCollision.GridCollisionType Check(Vector2Int grid)
		{
			return default(FieldGridCollision.GridCollisionType);
		}
	}

	private enum IceFloorStateType
	{
		None,
		Slip,
		SlopeDown
	}

	private enum MoveFloorType
	{
		None,
		Left,
		Right,
		Back,
		Front
	}

	private enum NaminoriEventRequestType
	{
		None,
		StartSwim,
		EndSwim
	}

	public class CheckGridCollisionCheckSwimFunc : FieldGridCollision.ICheckGridFunc
	{
		public FieldGridCollision.GridCollisionType Check(Vector2Int grid)
		{
			return default(FieldGridCollision.GridCollisionType);
		}
	}

	public class CheckGridCollisionCalcSwimFunc : FieldGridCollision.ICheckGridFunc
	{
		public float waterPositionY;

		public FieldGridCollision.GridCollisionType Check(Vector2Int grid)
		{
			return default(FieldGridCollision.GridCollisionType);
		}
	}

	public class CheckGridCollisionEndSwimFunc : FieldGridCollision.ICheckGridFunc
	{
		public FieldGridCollision.GridCollisionType Check(Vector2Int grid)
		{
			return default(FieldGridCollision.GridCollisionType);
		}
	}

	public class CheckGridCollisionCalcSwimEndFunc : FieldGridCollision.ICheckGridFunc
	{
		public float landPositionY;

		public FieldGridCollision.GridCollisionType Check(Vector2Int grid)
		{
			return default(FieldGridCollision.GridCollisionType);
		}
	}

	private enum SwampPhaseType
	{
		Start,
		Start_Move,
		Loop,
		End
	}

	private static readonly int _StencilRefID;

	[SerializeField]
	protected Renderer[] _hatRenderers;

	[SerializeField]
	protected Renderer[] _shoesRenderers;

	[SerializeField]
	protected GameObject _meshGroup;

	[SerializeField]
	protected GameObject _bicycleObject;

	[SerializeField]
	protected Renderer[] _rodRenderers;

	[SerializeField]
	protected Renderer _podRenderer;

	[SerializeField]
	protected Renderer _beadaruRenderer;

	[SerializeField]
	protected Renderer _mukuhawkRenderer;

	[SerializeField]
	protected Color[] _bicycleColors;

	[SerializeField]
	protected Renderer _bicycleRenderer;

	[SerializeField]
	protected int _bicycleMaterialIndex;

	[NonSerialized]
	public bool isExtrudable;

	private JumpCalculator _path;

	private bool _setupMaterials;

	[NonSerialized]
	private bool _hit_se_request;

	[NonSerialized]
	private float _hit_se_wait;

	public Vector3 InputMoveVector;

	private float _beforeAngle;

	public int FormType;

	private MapAttributeTable.SheetData nowAttribute;

	private bool isAttributeStop;

	private bool FootSeWalkStartEvent;

	private CheckGridCollisionFunc CheckGridCollision;

	private int _sandFallSeq;

	private float _sandFallWait;

	private float _sandFallPosZ;

	private bool UpdateInputAngleDisable;

	private int KairikiPushObjectIndex;

	private float KairikiPushTime;

	private float debugInputTime;

	private float debugInputVectolX;

	private bool _isCrossUpdate;

	private Vector2 _crossInputVectol;

	private Vector2 _crossStopPosition;

	private DIR _crossInputDir;

	private float _crossKey_pushTime;

	private Vector3 _eventMoveTargetPosition;

	private float _eventMoveTargetAngle;

	private bool _eventMoveEnd;

	private bool _eventRotateEnd;

	private int currentForm;

	private int nextForm;

	private Action formFinish;

	private bool changeFormRetInput;

	private BicycleJump _bicJump;

	private bool _isCycDownHillMode;

	private float _bicOldAcceleration;

	private float _bicAccelerationTime;

	private float _bicDecelerateTime;

	private bool _isBicMaxSpeed;

	private IceFloorStateType IceFloorState;

	private Vector3 IceFloorDirection;

	private int IceSlidingLevel;

	private float IceSlidingSpeed;

	private bool IsIceSlope;

	private float IceFloorStopTime;

	private Vector3 IceFloorStartGridCenterPos;

	private FieldObjectMove IceSlopeDownMove;

	private FieldObjectRotateYaw IceSlidingRotate;

	private DIR IceFloorDirtyNextDir;

	private MoveFloorType CurrentMoveFloor;

	private MoveFloorType NextMoveFloor;

	private float MoveFloorTime;

	private float PrevRotateOffset;

	private FieldObjectRotateYaw MoveFloorRotate;

	private const float RotateAnimeOneCycleTime = 0.5f;

	private const float NaminoriCheckDistance = 0.7f;

	public const float NaminoriWaterSurfaceOfs = 0.5f;

	public bool ForcePlayNaminoriEffect;

	private EffectInstance NaminoriEffect;

	private AudioInstance NaminoriAudio;

	private bool IsPlayNaminoriEffect;

	private const float NaminoriSeWaitTime = 0.6f;

	private float NaminoriSeWait;

	private NaminoriEventRequestType NaminoriEventRequest;

	private CheckGridCollisionCheckSwimFunc CheckGridCollisionCheckSwim;

	private CheckGridCollisionCalcSwimFunc CheckGridCollisionCalcSwim;

	private CheckGridCollisionEndSwimFunc CheckGridCollisionEndSwim;

	private CheckGridCollisionCalcSwimEndFunc CheckGridCollisionCalcSwimEnd;

	private Vector3 BiidaruPosOriginal;

	private Vector3 BiidaruMoveStartPos;

	private Vector3 BiidaruMoveEndPos;

	private FieldFloatMove BiidaruMoveTime;

	private EffectInstance RockClimbEffect;

	private DIR SwampDeepInputDir;

	private int SwampDeepInputCount;

	private SwampPhaseType SwampPhase;

	private FieldObjectMove SwampMove;

	private FieldFloatMove SwampWait;

	private bool isPlayedSwampStartEffect;

	private bool isSwampLoopEffect;

	private const float WaterFallUpCheckDistance = 0.7f;

	private const float WaterFallDownCheckDistance = 0.7f;

	public override string entityType => null;

	public Renderer[] rodRenderers
	{
		set
		{
		}
	}

	public Renderer podRenderer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject meshGroup
	{
		set
		{
		}
	}

	public GameObject bicycleObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Renderer beadaruRenderer
	{
		set
		{
		}
	}

	public Renderer mukuhawkRenderer
	{
		set
		{
		}
	}

	public Color[] bicycleColors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Renderer bicycleRenderer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int bicycleMaterialIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int bicycleColorIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int hatVariation
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int shoesVariation
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int rodVariation
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool podVisibility
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool beadaruVisibility
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool mukuhawkVisibility
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool DashFlag
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

	public Func<FieldPlayerEntity, bool> LateUpdateEvent
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

	public float MoveSpeed
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int FashionTableID
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform BiidaruTransform
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

	public FieldFloatMove VisiblePodMove
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

	public void ChangeVariation(int index)
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnFootSE()
	{
	}

	protected override void OnFootEffect(int index)
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnLateUpdate(float deltaTime)
	{
	}

	private bool CheckMapCollision_AfterCharacterHit(Vector3 moveVelocity, out Vector3 afterMoveVector, out Vector3 hitNormal)
	{
		return default(bool);
	}

	protected override bool SwitchToNext()
	{
		return default(bool);
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	public void GetInputVectorIgnoreUpdateInputAngle(out Vector2 stickL, out float stickPowerSq, float deltatime, out bool analogstick)
	{
	}

	public void GetInputVector(out Vector2 stickL, out float stickPowerSq, float deltatime, out bool analogstick)
	{
	}

	private bool IsStickInput()
	{
		return default(bool);
	}

	private bool GetCrossKeyVector(ref Vector2 stickL, ref float stickPowerSq, float deltatime)
	{
		return default(bool);
	}

	private void StopCrossUpdate()
	{
	}

	private void UpdateCrossInputMove(ref Vector2 stickL, ref float stickPowerSq, float deltatime)
	{
	}

	private void LateUpdateCrossInput()
	{
	}

	private void LimitedCrossInput(ref Vector2 stick)
	{
	}

	public float InputAtanAngle(ref Vector2 stickL)
	{
		return default(float);
	}

	public float InputYawAngle(float angle)
	{
		return default(float);
	}

	private float UpdateInputAngle(ref Vector2 stickL)
	{
		return default(float);
	}

	private bool IsInputStop()
	{
		return default(bool);
	}

	private void UpdateInputOperation(float deltaTime)
	{
	}

	private FieldGridCollision.GridCollisionType CheckGridCollisionCore(Vector2Int grid)
	{
		return default(FieldGridCollision.GridCollisionType);
	}

	private float GetMoveSpeed(bool isDash, float deltatime, bool gear, bool colHit, bool isdebug)
	{
		return default(float);
	}

	private bool CanEntryAttribute(Vector2Int grid, float height)
	{
		return default(bool);
	}

	private static bool CanEntryAttribute(Vector2Int grid, float height, bool isRideBicyclelse, bool isSwim)
	{
		return default(bool);
	}

	private static bool CanEntryAttributeCommon(int code, int stop)
	{
		return default(bool);
	}

	private static bool CanEntryAttributeBycJump(int code, int stop, Vector3 forward, out Vector3 jumpvector)
	{
		return default(bool);
	}

	private bool IsBicJumpObjectEntity(ref Vector2Int grid, float vectolx)
	{
		return default(bool);
	}

	private bool CanEntryNomoseGymWaterGrid(Vector2Int grid, float height)
	{
		return default(bool);
	}

	public void OnEventEnter(float deltaTime, FieldEventEntity eventEntity)
	{
	}

	public void OnEventStay(float deltaTime, FieldEventEntity eventEntity)
	{
	}

	public void OnEventLeave(float deltaTime, FieldEventEntity eventEntity)
	{
	}

	private void OnGroundTrigger()
	{
	}

	public void SetNormalForm([Optional] Action onfinish)
	{
	}

	private void SettingAttributeFlags()
	{
	}

	private void HitSeRequest()
	{
	}

	private void HitSEReset()
	{
	}

	private void LaetPlayHitSE(float time)
	{
	}

	private bool DashJudgment(double inputforce)
	{
		return default(bool);
	}

	public void SetEventCorrectionMove(Vector3 position, float angle)
	{
	}

	public void StartEventCorrectionMove()
	{
	}

	public bool IsEventCorrectionMoveEnd()
	{
		return default(bool);
	}

	private bool CorrectionMove(Vector3 position, float deltaTime)
	{
		return default(bool);
	}

	private bool CorrectionRotate(float angle)
	{
		return default(bool);
	}

	private bool IsIgnoreWalkCountZone(ZoneID zoneId)
	{
		return default(bool);
	}

	private bool IsIgnoreEggHatchCountZone(ZoneID zoneId)
	{
		return default(bool);
	}

	private void UpdateWalkCount()
	{
	}

	private bool NoWalkUpdateAttribute()
	{
		return default(bool);
	}

	private bool IsEncount()
	{
		return default(bool);
	}

	public void ChangeForm(int form, Action onFinish)
	{
	}

	private void ChangeAnime(float time)
	{
	}

	public void JumpPlayerActionEvent(string label)
	{
	}

	private void KairikiPushObject(float deltaTime)
	{
	}

	private void LimitHeight()
	{
	}

	public void WorkApplyVisibility()
	{
	}

	private void UpdateIdle()
	{
	}

	private int GetNextGesture()
	{
		return default(int);
	}

	public void PlayIdle(float duration)
	{
	}

	public void PlayIdle()
	{
	}

	public override void GetIdleAnimationIndex(out int index, out float duration)
	{
	}

	public bool IsIdle()
	{
		return default(bool);
	}

	public void GetWalkAnimationIndex(out int index, out float duration)
	{
	}

	public void PlayWalk()
	{
	}

	public bool IsWalk()
	{
		return default(bool);
	}

	public void PlayRun()
	{
	}

	public bool IsRun()
	{
		return default(bool);
	}

	public void PlayWallWalk()
	{
	}

	public void PlayNaminoriStart()
	{
	}

	public void PlayNaminoriEnd()
	{
	}

	public void PlayNaminoriLoop()
	{
	}

	public void PlayJumpStart()
	{
	}

	public void PlayJumpLoop()
	{
	}

	public void PlayJumpEnd()
	{
	}

	public void PlayHandOver()
	{
	}

	public void PlaySit()
	{
	}

	public void PlaySquat()
	{
	}

	public void PlayGetPause()
	{
	}

	public void PlayPoketchStart()
	{
	}

	public void PlayPoketchLoop()
	{
	}

	public void PlayPoketchEnd()
	{
	}

	public bool IsPlayPoketchLoop()
	{
		return default(bool);
	}

	public void PlaySwampStart()
	{
	}

	public void PlaySwampLoop()
	{
	}

	public void PlaySwampEnd()
	{
	}

	public void PlaySpin(bool restart = false)
	{
	}

	public void PlayWatering()
	{
	}

	public void PlayWateringLoop()
	{
	}

	public void PlayWateringEnd()
	{
	}

	public void PlayFlyStart()
	{
	}

	public void PlayFlyEnd()
	{
	}

	public void PlayRockClimbUp()
	{
	}

	public void PlayRockClimbDown()
	{
	}

	public bool IsFishingStart()
	{
		return default(bool);
	}

	public void PlayFishingStart()
	{
	}

	public void PlayFishingLoop()
	{
	}

	public void PlayFishingHit()
	{
	}

	public void PlayFishingHitLoop()
	{
	}

	public void PlayFishingEnd()
	{
	}

	public void PlayFishingSuccess()
	{
	}

	public void PlayFishingSuccessLoop()
	{
	}

	private void BicycleDecelerate(float deltatime)
	{
	}

	public void SetRideBicycle([Optional] Action onfinish)
	{
	}

	public bool IsRideBicycle()
	{
		return default(bool);
	}

	private void ChangeBicycleGear(bool gear)
	{
	}

	private bool GetBicycleGear()
	{
		return default(bool);
	}

	public void StopBicycleDecelerate()
	{
	}

	public void MaxBicycleDecelerate()
	{
	}

	public void SetIceFloorDirty()
	{
	}

	private bool CheckIceFloor(float deltaTime)
	{
		return default(bool);
	}

	private Vector3 CalcIceMoveDirection(Vector3 inputVector)
	{
		return default(Vector3);
	}

	private void StartIceFloor()
	{
	}

	private void EndIceFloor()
	{
	}

	private void UpdateIceFloor(float deltaTime)
	{
	}

	private Vector3 CalcAdjustIceFloorMoveDirection()
	{
		return default(Vector3);
	}

	private void CheckColSnowBall(Vector3 direction, float speed)
	{
	}

	private void CrashSnowBall(FieldObjectEntity entity)
	{
	}

	private bool CheckColIceFloor(Vector3 direction, float speed, out Vector3 outVelocity)
	{
		return default(bool);
	}

	private bool CheckColNpcIceFloor(Vector3 direction, float speed)
	{
		return default(bool);
	}

	private float UpdateIceSpeed(float deltaTime)
	{
		return default(float);
	}

	private void CheckIceSlope()
	{
	}

	private Vector2Int CheckIceSlopeFloor()
	{
		return default(Vector2Int);
	}

	private bool IsIceGrid(Vector2Int grid, float height)
	{
		return default(bool);
	}

	private bool CheckMoveFloor(float deltaTime)
	{
		return default(bool);
	}

	private MoveFloorType CheckMoveFloorGrid(Vector2Int grid, float height)
	{
		return default(MoveFloorType);
	}

	private void StartMoveFloor()
	{
	}

	private void EndMoveFloor()
	{
	}

	private void UpdateMoveFloor(float deltaTime)
	{
	}

	private Vector3 GetMoveFloorDirection()
	{
		return default(Vector3);
	}

	private bool CheckColMoveFloor(Vector3 direction, float speed, out Vector3 outVelocity)
	{
		return default(bool);
	}

	public void ChangeSwim(bool swim)
	{
	}

	public bool IsSwim()
	{
		return default(bool);
	}

	private Vector3 CalcCheckFrontGridDirection()
	{
		return default(Vector3);
	}

	public bool CheckSwim()
	{
		return default(bool);
	}

	private FieldGridCollision.GridCollisionType CheckGridCollisionCheckSwimCore(Vector2Int grid)
	{
		return default(FieldGridCollision.GridCollisionType);
	}

	public Vector3 CalcSwimTargetPosition()
	{
		return default(Vector3);
	}

	private FieldGridCollision.GridCollisionType CheckGridCollisionCalcSwimCore(Vector2Int grid, float waterPositionY)
	{
		return default(FieldGridCollision.GridCollisionType);
	}

	private bool UpdateSwim(float deltaTime)
	{
		return default(bool);
	}

	private bool CheckEndSwim(Vector2 inputDir)
	{
		return default(bool);
	}

	private FieldGridCollision.GridCollisionType CheckGridCollisionEndSwimCore(Vector2Int grid)
	{
		return default(FieldGridCollision.GridCollisionType);
	}

	public Vector3 CalcSwimEndTargetPosition()
	{
		return default(Vector3);
	}

	private FieldGridCollision.GridCollisionType CheckGridCollisionCalcSwimEndCore(Vector2Int grid, float landPositionY)
	{
		return default(FieldGridCollision.GridCollisionType);
	}

	public void RequestStartSwimEvent()
	{
	}

	private void RequestEndSwimEvent()
	{
	}

	public void StartSwimEvent()
	{
	}

	private void EndSwimEvent()
	{
	}

	public void AppearSwimBiidaru(float ofs, float time)
	{
	}

	public void DisappearSwimBiidaru(float ofs, float time)
	{
	}

	public void UpdateSwimEffect(float time)
	{
	}

	public void PlaySwimEffect()
	{
	}

	private void PlayNaminoriLoopSE(float time)
	{
	}

	public void PlayWaterFallUpEffect()
	{
	}

	public void PlayWaterFallDownEffect()
	{
	}

	private void PlayWaterFallEffectCommon(float yawAngle)
	{
	}

	public void StopSwimEffect()
	{
	}

	public bool IsBusySwimEffect()
	{
		return default(bool);
	}

	private void UpdateParts(float deltaTime)
	{
	}

	private void LateUpdateParts(float deltaTime)
	{
	}

	public void ResetBiidaruOffset()
	{
	}

	private void MoveBiidaruOffset(Vector3 start, Vector3 end, float time)
	{
	}

	private void UpdateBiidaru(float deltaTime)
	{
	}

	private void UpdateBiidaruNode()
	{
	}

	public void VisiblePod(bool visible)
	{
	}

	private void UpdateVisiblePod(float deltaTime)
	{
	}

	public Transform GetPodEffectAttachTransform()
	{
		return null;
	}

	public bool CheckRockClimbing(FieldObjectEntity eventObject)
	{
		return default(bool);
	}

	public void CalcRockClimbingTargetPosition(FieldObjectEntity eventObject, out Vector3 climbStart, out Vector3 climbEnd, out Vector3 standPos)
	{
	}

	public Vector3 CalcRockClimbingAnotherTalkPosition(FieldObjectEntity eventObject)
	{
		return default(Vector3);
	}

	private Vector3 CalcRockClimbingDirection(FieldObjectEntity eventObject)
	{
		return default(Vector3);
	}

	public void PlayRockClimbEffect()
	{
	}

	public void StopRockClimbEffect()
	{
	}

	private bool CheckSwampDeep(float deltaTime)
	{
		return default(bool);
	}

	private void StartSwampDeep()
	{
	}

	private void EndSwampDeep()
	{
	}

	private void UpdateSwampDeep(float deltaTime)
	{
	}

	private bool IsSwampDeepGrid(Vector2Int grid, float height)
	{
		return default(bool);
	}

	private bool CheckWaterfallDown(Vector2 inputDir)
	{
		return default(bool);
	}

	public Vector3 CalcWaterfallDownTargetPosition()
	{
		return default(Vector3);
	}

	public bool CheckWaterfallUp()
	{
		return default(bool);
	}

	public Vector3 CalcWaterfallUpTargetPosition()
	{
		return default(Vector3);
	}

	public void WaterfallUpEvent()
	{
	}

	private void WaterfallDownEvent()
	{
	}
}
