using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.UnderGround.LightStone;
using Pml;
using UnityEngine;
using XLSXContent;

public class LightStoneResourcesManager
{
	private const string DataAssetName = "lightstone/prefabs/lightstonemanager";

	private const string PokemonAssetPath = "pokemons/field/{0}";

	private static GameObject ugLightStoneManagerPrefab;

	private static bool _isDataLoadRequest;

	private static bool _isDataLoadEnd;

	private static Action _onPostLoaded;

	public static LightStoneManager LightStoneManager
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

	public static GameObject DhigudaPrefab
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

	public static GameObject DagutorioPrefab
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

	public static PokemonInfo.SheetCatalog DhigudaCatalog
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

	public static PokemonInfo.SheetCatalog DagutorioCatalog
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

	public static bool IsDataLoadEnd => default(bool);

	public static void UnLoad()
	{
	}

	public static void DataLoadRequest(Action callback)
	{
	}

	private static IEnumerator DataLoad()
	{
		return null;
	}

	public static IEnumerator CreateAsset()
	{
		return null;
	}

	private static PokemonInfo.SheetCatalog GetPokemonCatalog(MonsNo monsNo)
	{
		return null;
	}
}
