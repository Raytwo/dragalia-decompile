using System.Runtime.CompilerServices;
using Effect;
using Pml;
using UnityEngine;

namespace Dpr.UnderGround.LightStone;

public class LightStone : MonoBehaviour
{
	private enum State
	{
		Uninitialized,
		Idle,
		DigAnimation,
		LightStone,
		Empty
	}

	[SerializeField]
	private Transform root;

	[SerializeField]
	private Transform monsterRoot;

	[SerializeField]
	private Transform effectRoot;

	private State state;

	private State nextState;

	private MonsNo monsNo;

	private FieldPokemonEntity entity;

	private EffectInstance lightStoneEffect;

	public Vector2Int Pos
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Init(Vector2Int pos)
	{
	}

	public void LoadModel(MonsNo monsNo)
	{
	}

	public void ReturnUnUsed()
	{
	}

	public void ReturnUnUsedWithAnimation()
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	public bool IsContact()
	{
		return default(bool);
	}

	public bool IsUnuse()
	{
		return default(bool);
	}

	public void OnHit()
	{
	}

	public void DigStart()
	{
	}

	private void PLayDigAnimation()
	{
	}

	public void FindLightStone()
	{
	}

	public bool IsAliveModel()
	{
		return default(bool);
	}

	private void PlaySmokeEffect(float delay)
	{
	}

	public void PlayLightStoneEffect(float delay)
	{
	}

	private void PlayPokeSE()
	{
	}

	private void SetState(State state)
	{
	}
}
