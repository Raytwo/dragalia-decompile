using System;
using XLSXContent;

namespace Dpr.Battle.View.Objects;

[Serializable]
public struct MotionTimingData
{
	public int Buturi01;

	public int Buturi02;

	public int Buturi03;

	public int Tokusyu01;

	public int Tokusyu02;

	public int Tokusyu03;

	public int BodyBlow;

	public int Punch;

	public int Kick;

	public int Tail;

	public int Bite;

	public int Peck;

	public int Radial;

	public int Cry;

	public int Dust;

	public int Shot;

	public int Guard;

	public int LandingFall;

	public int LandingFallEase;

	public MotionTimingData(BattleDataTable.SheetMotionTimingData data)
	{
	}

	public static MotionTimingData Factory()
	{
		return default(MotionTimingData);
	}

	public int GetTiming(BattlePokemonEntity.AnimationState state)
	{
		return default(int);
	}
}
