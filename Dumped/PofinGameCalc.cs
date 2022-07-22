using System;
using System.Collections.Generic;
using Dpr.FureaiHiroba;
using UnityEngine;

[Serializable]
public class PofinGameCalc
{
	private Tuple<int, int>[] RotSpeedTarget;

	public bool isRotRight;

	public int SearCount;

	public int SpillCount;

	public float NamerakasaHosei;

	public int MAX_ROTATE_SPEED;

	public float DOWN_SPEED;

	public float ACCEL_POWER;

	public float accel;

	public float prevAngleR;

	public float prevAngleL;

	public float rotateTime;

	public float PlayingTime;

	public float EndTime;

	public float RotCount;

	public int[] NeedPhaseChangeRotCounts;

	public int CookPhase;

	public float deltaAccel;

	private float searTime;

	private float spillTime;

	public Action OnSear;

	public Action OnSpill;

	public Action OnSearZone;

	public Action OnSpillZone;

	public Action OnNoMiss;

	private bool isSmoke;

	public Action OnSmoke;

	public int SpeedVal;

	public float BlendHoten;

	private float NoMissTime;

	private float RotMagni;

	private List<FureaiPokeModel> pokeModels;

	public bool isGameEnd => default(bool);

	public float SpeedHosei => default(float);

	public float BatterColorRate => default(float);

	public bool IsCorrect(float rotDirection)
	{
		return default(bool);
	}

	public void SetPokeModel(List<FureaiPokeModel> pokeModels)
	{
	}

	public void Update(float deltaTime)
	{
	}

	private bool IsSearZone()
	{
		return default(bool);
	}

	private bool IsSpillZone()
	{
		return default(bool);
	}

	private void CheckSear()
	{
	}

	private void CheckSpill()
	{
	}

	private void CheckStepAndTime()
	{
	}

	public float GetBlendValue()
	{
		return default(float);
	}

	public float CalcRot(float angleR, float angleL, float deltaTime)
	{
		return default(float);
	}

	private void PhaseNext()
	{
	}

	public bool CheckNeedChangeRotateDirection(float deltaTime)
	{
		return default(bool);
	}

	private int GetSpeedValue()
	{
		return default(int);
	}

	public float GetNearAngle(float angle, float prevAngle)
	{
		return default(float);
	}

	public float Vector2ToAngle(Vector2 input)
	{
		return default(float);
	}
}
