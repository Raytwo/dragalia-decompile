using System.Collections.Generic;
using Dpr.Battle.View.Objects;
using UnityEngine;

namespace Dpr.SubContents;

public class TimeLineMotion : MonoBehaviour
{
	private BattlePlayerEntity playerEntity;

	private BattlePokemonEntity pokeEntity;

	private BOPokemon boPokemon;

	public Color AddColor;

	private float LoopSec;

	private Transform Waist;

	private List<float> heightList;

	public float HeightLimit;

	public uint Pattern;

	public bool updatePattern;

	private float prevScale;

	public int DebugIndex;

	public int Button01;

	private void OnDestroy()
	{
	}

	public void CallMotion(int AnimID)
	{
	}

	public void SetLoopSec(float sec)
	{
	}

	private void SetEntity()
	{
	}

	public void Update()
	{
	}

	public void Test()
	{
	}
}
