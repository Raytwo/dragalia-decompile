using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Field.Walking;
using Effect;
using UnityEngine;

namespace Dpr.FureaiHiroba;

public sealed class FureaiPokeController : WalkingCharacterController
{
	[SerializeField]
	private PokeWalkerDebug pokeWalkerDebug;

	public List<string> Animations;

	[SerializeField]
	private string _DebugNowState;

	private bool isStep01;

	private bool isStep02;

	private EffectInstance Eff_Step01;

	private EffectInstance Eff_Step02;

	public int Button011;

	public int Button012;

	public new FureaiPokeModel model => null;

	public new WalkData walkModel => null;

	public new FureaiPokeView view => null;

	public event EventHandler<FureaiPokeModel> OnPlayerNear
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<FureaiPokeModel> OnWalkingKaizyo
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<FureaiPokeModel> OnGotoSanpo
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<FureaiPokeModel> OnReturn
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void SetModel(WalkingCharacterModel model)
	{
	}

	public override AIModel CreateAIModel()
	{
		return null;
	}

	public override void AISetting()
	{
	}

	public void SetDebugDrawActive(bool isActive)
	{
	}

	protected override void ModelUpdate(float deltaTime)
	{
	}

	public override void MyUpdate(float deltaTime)
	{
	}

	public void PlayerNear()
	{
	}

	protected override List<FureaiPokeModel> GetWalkingCharacters()
	{
		return null;
	}

	public void Amity()
	{
	}

	private void Tes()
	{
	}

	private void Tes2()
	{
	}
}
