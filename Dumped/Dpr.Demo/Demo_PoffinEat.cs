using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DPData;
using Effect;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.Demo;

public class Demo_PoffinEat : DemoBase
{
	private List<GameObject> Points;

	private PokemonParam pokePara;

	private PoffinData poffin;

	private GameObject Poffin3D;

	private FieldPokemonEntity pokeEntity;

	private EffectData bgEff;

	private bool isEndThrow;

	public ConditionParam ConditionParam
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

	public Demo_PoffinEat()
	{
	}

	public Demo_PoffinEat(PokemonParam pokePara, PoffinData poffin)
	{
	}

	public override void Destroy()
	{
	}

	public override void Init()
	{
	}

	private IEnumerator test()
	{
		return null;
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	private void CreateCurvePoint(GameObject poke)
	{
	}

	public override IEnumerator Main()
	{
		return null;
	}

	private void MotionUpdate(float deltaTime)
	{
	}

	public override IEnumerator Exit()
	{
		return null;
	}

	public Vector3 PofinThrow()
	{
		return default(Vector3);
	}

	private Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	public override void LightUpdate()
	{
	}

	private void Calc_EatPoffin()
	{
	}
}
