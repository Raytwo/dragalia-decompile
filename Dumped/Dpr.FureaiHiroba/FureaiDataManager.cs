using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.FureaiHiroba;

public class FureaiDataManager : MonoBehaviour
{
	public enum EffectName
	{
		Sleep
	}

	public static FureaiDataManager Instance;

	private const string Path_MasterData = "fureai/masterdata";

	private const string Path_Prefabs = "fureai/prefabs";

	public const string ASSET_BUNDLE_PATH_FX = "effect/prefab/battle";

	private GameObject FureaiManager;

	public Dictionary<int, UnityEngine.Object> PokeAssets;

	private Dictionary<Type, UnityEngine.Object> MasterData;

	public List<int> EnterblePokeList;

	public static readonly Vector2Int[] DontEnterPoints;

	public List<FureaiPokeScaleTable.SheetTable> scaleTable
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

	public List<FreeSanpoGridPosition.SheetSheet1> gridPositions
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

	public List<PokeWalkingActionNakayoshi.SheetSheet1> nakayoshiHoseiData
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

	public List<PokeWalkingActionSeikaku.SheetSheet1> seikakuHoseiData
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

	public List<HirobaPokeTalk.SheetSheet1> talkList
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

	public List<FreeSanpoKuse.SheetSheet1> ActionKuseList
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

	public List<FreeSanpoCanActions.SheetSheet1> CanActionList
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

	public List<FreeSanpoActionProbability.SheetSheet1> ActionProbabilityList
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

	public List<MonohiroiKinomi.SheetSheet1> MonohiroiKinomiList
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

	public List<MonohiroiSonota.SheetSheet1> MonohiroiSonotaList
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

	public List<EffectPosData> EffectPosData
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

	public List<GameObject> EffectList
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

	private void Awake()
	{
	}

	public void Destroy()
	{
	}

	public IEnumerator Start()
	{
		return null;
	}

	public IEnumerator Init()
	{
		return null;
	}

	public UnityEngine.Object GetPokeAsset(PokemonParam pokePara)
	{
		return null;
	}

	public T GetMD<T>() where T : UnityEngine.Object
	{
		return null;
	}

	public IEnumerator LoadMD()
	{
		return null;
	}

	public static IEnumerator LoadPokeAsset(MonsNo monsNo, Dictionary<int, UnityEngine.Object> Assets, ushort formNo, Sex sex, bool isRare = false, int AssetBundleType = 1)
	{
		return null;
	}

	public IEnumerator LoadManagerPrefab()
	{
		return null;
	}

	public GameObject GetEffect(EffectName effect)
	{
		return null;
	}

	public void GetObjectByName(Transform Tra, string searchName, string path, EffectPosData data)
	{
	}

	public Vector3 GetHeadPosition(int MonsNo)
	{
		return default(Vector3);
	}
}
