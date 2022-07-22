using System.Runtime.CompilerServices;
using Effect;
using UnityEngine;

public class BattleReadyPoint : EnterCollision
{
	private const float PLAYER_RADIUS = 0.5f;

	private bool isActivePoint;

	private EffectData waitEffect;

	private EffectData readyEffect;

	private EffectInstance effectInstance;

	public int PointNum
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Init(int num)
	{
	}

	public void SetIsActiveMode(bool flag)
	{
	}

	public bool GetIsActiveMode()
	{
		return default(bool);
	}

	public void Create(float rad, GameObject target, EffectData wait, EffectData ready)
	{
	}

	public override void OnDestroy()
	{
	}

	public void Enter()
	{
	}

	public void Leave()
	{
	}

	public bool IsContact()
	{
		return default(bool);
	}

	public void PlayWaitEffect()
	{
	}

	public void PlayReadyEffect()
	{
	}

	private new bool IsInCircle()
	{
		return default(bool);
	}
}
