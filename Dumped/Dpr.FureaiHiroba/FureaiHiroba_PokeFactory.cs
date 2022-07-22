using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.EvScript;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.FureaiHiroba;

public sealed class FureaiHiroba_PokeFactory : MonoBehaviour
{
	private FureaiDataManager dataMng;

	public List<int> NumberList;

	public List<KeyValuePair<int, int>> PairPosition;

	public int Button01;

	public List<FureaiPokeModel> PokeList
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

	public void Init(FureaiDataManager mng)
	{
	}

	public void CreatePositionNoList(int pokeNum)
	{
	}

	public IEnumerator AddPoke(PokemonParam pokePara, Action<FureaiPokeModel> OnCreateModel, bool CreatePlayerPosition = false, [Optional] Vector2Int InitGrid)
	{
		return null;
	}

	private void OnTalk(EvDataManager.EntityParam param)
	{
	}

	private FureaiPokeModel CreateModel(FieldPokemonEntity pokeEntity, PokemonParam pokePara)
	{
		return null;
	}

	public static void SetPokeScale(Transform pokeTransform, PokemonParam p)
	{
	}

	public void SetFureaiPokeScale(Transform pokeTransform, PokemonParam p)
	{
	}

	public void SetPokePosition(bool CreatePlayerPosition, FieldPlayerEntity PlayerEntity, FureaiPokeModel pokeModel, [Optional] Vector2Int InitGrid)
	{
	}

	public void SetPairModel(FureaiPokeModel model)
	{
	}

	private void OnDestroy()
	{
	}
}
