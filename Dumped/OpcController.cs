using System.Collections.Generic;
using Dpr.NetworkUtils;
using UnityEngine;

public abstract class OpcController : OnlinePlayerCharacter
{
	protected const int POS_LIST_LENGTH = 20;

	protected const int ANIM_INDEX_IDLE = 0;

	protected const int ANIM_INDEX_WALK = 1;

	protected const int ANIM_INDEX_RUN = 2;

	protected const float MOVE_THRESHOLD = 0.0001f;

	protected FieldObjectEntity _Entity;

	protected List<Vector2> _PosList;

	protected List<float> _RotList;

	protected OpcCharacterMove _CharacterMove;

	protected AnimationPlayer _AnimationPlayer;

	protected float _RotY;

	protected bool _IsAnimStop;

	public OpcManager.CharaData _CharaData;

	public bool isUseDashAnimation;

	private bool _isInitialized;

	[SerializeField]
	private string _TalkLabel;

	[SerializeField]
	private Vector2 _ContactSize;

	[SerializeField]
	private float _Speed;

	[SerializeField]
	private float _RotSpeed;

	[SerializeField]
	private float _TargetDistance;

	[SerializeField]
	private float _MinSpeed;

	[SerializeField]
	private float _MaxSpeed;

	[SerializeField]
	private float _AddSpeedRate;

	private float _CurrentSpeed;

	private float _CurrentDistance;

	private float _IdleTransutuonTime;

	protected override void Start()
	{
	}

	public void AddNextPosition(Vector2 pos, float rotY)
	{
	}

	public void SetRotationY(float rotY)
	{
	}

	public void ClearPos()
	{
	}

	public void SetCharaData(OpcManager.CharaData data)
	{
	}

	public bool IsArriveTargetPosition(Vector3 pos)
	{
		return default(bool);
	}

	public void TalkLog()
	{
	}

	public void Log()
	{
	}

	protected override void MyUpdate(float deltaTime)
	{
	}

	public virtual void SetNetData(INetData netData)
	{
	}

	public FieldObjectEntity GetEntity()
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}

	private void SetNPCParamater()
	{
	}

	private void PlayAnimMove()
	{
	}
}
