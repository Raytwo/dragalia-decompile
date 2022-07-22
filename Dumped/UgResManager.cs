using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.UnderGround;
using Pml;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

public class UgResManager
{
	public class AppendData
	{
		public AssetRequestOperation Operation;

		public Action<GameObject> callback;
	}

	public const string DataAssetName = "data/ugdata";

	private static Dictionary<string, UgEncount> UgEncounts;

	private static UgPokemonData UgPokemonData;

	private static GameObject UgEmoticonSetPrefab;

	private static GameObject UgInfoSetPrefab;

	private static bool _isDataLoadRequest;

	private static bool _isDataLoadEnd;

	private static Action _onPostLoaded;

	private static GameObject UgCanvas;

	private static GameObject _createDigManagerPrefab;

	private static List<AppendData> _assetOpe;

	public static UgRandMark UgRandMark
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

	public static UgMiniMap UgMiniMap
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

	public static UgIconImages UgIconImages
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

	public static GameObject UgCanvasPrefab
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

	public static GameObject UgFieldManagerPrefab
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

	public static UgEmoticonSet UgEmoticonSet
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

	public static UgInfoSet UgInfoSet
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

	public static UgEncountLevel UgEncountLevel
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

	public static UgSpecialPokemon UgSpecialPokemon
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

	public static UgPokemonPos UgPokemonPos
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

	public static UgNpcPos UgNpcPos
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

	public static UgNpcList UgNpcList
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

	public static UgNpcTalk UgNpcTalk
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

	public static UgDrillUsablePositions UgDrillUsablePositions
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

	public static UgDigFossilePosGroups UgDigFossilePosGroups
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

	public static UgAllDigFossilePos UgAllDigFossilePos
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

	public static UgTamagoWazaIgnoreTable UgTamagoWazaIgnoreTable
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

	public static GameObject GetUgCanvas()
	{
		return null;
	}

	public static void AppendAsset(PokemonParam param, Action<GameObject> callback)
	{
	}

	public static IEnumerator DispathAsset()
	{
		return null;
	}

	public static void AssetBundleUnload()
	{
	}

	public static UgEncount GetUgEncount(int randMarkID)
	{
		return null;
	}

	public static UgPokemonData.Sheettable GetUgPokeData(MonsNo monsNo)
	{
		return null;
	}
}
