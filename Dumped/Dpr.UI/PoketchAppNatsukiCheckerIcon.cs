using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppNatsukiCheckerIcon : MonoBehaviour
{
	private enum NatsukiCheckerIconState
	{
		Idle,
		Move,
		Approach,
		Escape,
		Jump,
		Heart,
		End
	}

	[SerializeField]
	private PokemonIcon _pokemonIcon;

	[SerializeField]
	private RectTransform _iconTransform;

	[SerializeField]
	private Image _shadowImage;

	[SerializeField]
	private Image[] _heartImages;

	[SerializeField]
	private Vector2 _colisionSize;

	[SerializeField]
	private int _likeFriendShipRank;

	[SerializeField]
	private float[] _touchMoveSpeed;

	[SerializeField]
	private float _minMoveSpeed;

	[SerializeField]
	private float _maxMoveSpeed;

	[SerializeField]
	private float _minMoveDistance;

	[SerializeField]
	private float _maxMoveDistance;

	[SerializeField]
	private float _minIdleTime;

	[SerializeField]
	private float _maxIdleTime;

	[SerializeField]
	private float _friendShipDistance;

	[SerializeField]
	private float _jumpHeight;

	[SerializeField]
	private float _jumpAirTime;

	[SerializeField]
	private float _jumpIntervalTime;

	[SerializeField]
	private int[] _heartDisplayNum;

	[SerializeField]
	private float[] _heartDisplayTime;

	[SerializeField]
	private float[] _heartScale;

	private Animator _heartAnimator;

	private NatsukiCheckerIconState _state;

	private MonsNo _monsNo;

	private ushort _formNo;

	private bool _bIsSetGetDefaultPosition;

	private Vector2 _minDisplayMargin;

	private Vector2 _maxDisplayMargin;

	private Vector2 _defaultPosition;

	private Vector2 _position;

	private bool _isFriendShip;

	private int _friendShipRank;

	private float _timeCounter;

	private Vector2 _touchPos;

	private bool _isTouch;

	private bool _isTouchOld;

	private float _idleTime;

	private float _moveSpeed;

	private float _moveDistance;

	private Vector2 _moveVec;

	private Vector2 _beforePostion;

	private bool _isDisableReverce;

	private Vector2 _defaultIconPosition;

	private const string animationStateNameHeartMove = "Poketch_NatsukiChecker_Heart01";

	private const string animationStateNameHeartNone = "Poketch_NatsukiChecker_Heart02";

	public void Initialize(Material mat, Vector2 windowSize, float windowMargin)
	{
	}

	public void SetData(PokemonParam pp, bool isDisableReverce)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateIdleState(float deltaTime)
	{
	}

	private void UpdateMoveState(float deltaTime)
	{
	}

	private void UpdateApproachState(float deltaTime)
	{
	}

	private void UpdateEscapeState(float deltaTime)
	{
	}

	private void UpdateJumpState(float deltaTime)
	{
	}

	private void UpdateHeartState(float deltaTime)
	{
	}

	private void SetState(NatsukiCheckerIconState state)
	{
	}

	private void SetImageDirection(bool left)
	{
	}

	private void UpdateMove(Vector2 moveVec)
	{
	}

	private void UpdateMoveInterp(float deltaTime)
	{
	}

	private bool IsInFriendShipDistance()
	{
		return default(bool);
	}

	public void OnTouchDispaly(Vector2 touchPos)
	{
	}

	public void OnReleaseDispaly()
	{
	}

	public void OnDoubleTap()
	{
	}

	public bool IsColision(Vector2 pos)
	{
		return default(bool);
	}

	public Vector2 ColisionPosMin(bool enableScale)
	{
		return default(Vector2);
	}

	public Vector2 ColisionPosMax(bool enableScale)
	{
		return default(Vector2);
	}
}
