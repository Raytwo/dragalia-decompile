using UnityEngine;

public class EvEntityCommand
{
	public enum EntityType
	{
		Chara,
		Poke,
		Obj
	}

	public EntityType entityType;

	private FieldObjectEntity _entity;

	private EvData.Script _moveData;

	private int _moveIndex;

	private float _moveUpdateTime;

	private int _moveLoopCount;

	private float _moveGrid;

	private float _moveEndTime;

	private Vector3 _moveOffset;

	private Vector3 _moveStartPos;

	private float _moveStartRot;

	private bool _moveStop;

	private Balloon _moveBallon;

	private float _moveRotateStart;

	private float _moveRotateEnd;

	private Vector3 _moveVector3;

	private bool _isMoveRotateClockWise;

	private float _moveStartFrame;

	private bool _dirPause;

	private bool _anmPause;

	private Vector3 _neckRotate;

	private bool _isResetIdleAnimEnable;

	private bool _isNeckUpdate;

	private bool _isNeckRotate;

	private Transform _neckTarget;

	private float _neckAngle;

	private float _neckAngleDiff;

	private FieldCharacterEntity _charEntity;

	private FieldPlayerEntity _playerEntity;

	private bool _isStopWalkAnime;

	private float _forceDuration;

	public EvEntityCommand(FieldObjectEntity entity)
	{
	}

	public void ScriptMove(float deltatime)
	{
	}

	public void SetScriptMoveData(EvData.Script evmove, float startFrame = 0f)
	{
	}

	public void ForceScriptMove()
	{
	}

	public bool IsScriptMoveEnd()
	{
		return default(bool);
	}

	public void ScriptMovePause(bool flag)
	{
	}

	private void SetAnimation(int anime, float duration = 0f, bool restart = false)
	{
	}

	private void SetMoveData()
	{
	}

	public void ScritpStopState()
	{
	}

	public void ScritpStopStateEnd()
	{
	}

	public void ReleaseMoveData()
	{
	}

	public void SetResetIdleAnimEnable(bool enable)
	{
	}

	private void SetDirPause(bool pause)
	{
	}

	private void SetAnimPause(bool pause)
	{
	}

	private void ApplyAnimSpeed()
	{
	}

	public void SetEventNeckRotate(Transform target)
	{
	}

	private bool UpdateEventNeck(float deltatime)
	{
		return default(bool);
	}

	private void CalcNeckRotate()
	{
	}

	public void ReleaseEventNeck()
	{
	}

	private void StopFootEffect(bool stop)
	{
	}

	private bool GetIsDirPlayWalking()
	{
		return default(bool);
	}

	private float GetDirMoveTime()
	{
		return default(float);
	}

	private float GetWalkTime()
	{
		return default(float);
	}
}
