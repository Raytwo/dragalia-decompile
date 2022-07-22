using System.Collections;
using System.Collections.Generic;
using FieldCommon;
using Pml;
using Pml.PokePara;
using XLSXContent;

namespace GameData;

public class DataManager
{
	public delegate void OnPostLoadDataDelegate();

	private class ComparerCatalog : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class ComparerKinomi : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	public static CharacterGraphics CharacterGraphics;

	public static TrainerTable TrainerTable;

	public static Dictionary<string, PlaceData> PlaceData;

	public static Dictionary<string, MapWarp> MapWarpData;

	public static Dictionary<string, StopData> StopData;

	public static GimmickGraphics GimmickGraphics;

	public static PokemonInfo PokemonInfo;

	public static ContestWazaInfo ContestWazaInfo;

	public static ShopTable ShopTable;

	public static CharacterDressData CharacterDressData;

	public static KinomiData KinomiData;

	public static KinomiPlaceData KinomiPlaceData;

	public static HoneyTree HoneyTree;

	public static MonohiroiTable MonohiroiTable;

	public static UgJumpPos UgJumpPos;

	public static TowerTrainerTable TowerTrainerTable;

	public static TowerMatchingTable TowerMatchingTable;

	public static TowerSingleStockTable TowerSingleStockTable;

	public static TowerDoubleStockTable TowerDoubleStockTable;

	public static AdventureNoteData AdventureNoteData;

	public static Dictionary<int, List<AdventureNoteData.SheetData>> AdventureNoteDataDict;

	public static TowerBattlePoint TowerBattlePoint;

	public static TagPlaceData TagPlaceData;

	public static LocalKoukanData LocalKoukanData;

	public static ContestCommonData ContestCommonData;

	public static TvDataTable TvDataTable;

	public static TvSchedule TvSchedule;

	public static OnPostLoadDataDelegate onPostLoadData;

	public static FieldCommonParam FieldCommonParam;

	public static FieldWazaCutInParam FieldWazaCutInParam;

	public static ZenmetuZone ZenmetuZone;

	public static MoveAfterSaveGrid MoveAfterSaveGrid;

	private static ComparerCatalog _comparerCatalog;

	private static ComparerKinomi _comparerKinomi;

	public static StatueEffectRawData statueEffectRawData;

	public static IEnumerator StartUpLoad()
	{
		return null;
	}

	public static IEnumerator Load(string assetBundleName)
	{
		return null;
	}

	public static bool IsLoaded()
	{
		return default(bool);
	}

	public static PokemonInfo.SheetCatalog GetPokemonCatalog(MonsNo monsNo, int formNo, Sex sex, bool isRare, bool isEgg = false)
	{
		return null;
	}

	public static PokemonInfo.SheetCatalog GetPokemonCatalog(int uniqueId)
	{
		return null;
	}

	public static int GetUniqueID(PokemonParam pokemonParam)
	{
		return default(int);
	}

	public static int GetUniqueID(MonsNo monsNo, int formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return default(int);
	}

	public static int GetUniqueID(MonsNo monsNo, int formNo, Sex sex, bool isRare, bool isEgg)
	{
		return default(int);
	}

	public static bool IsEggByUniqueID(int uniqueId)
	{
		return default(bool);
	}

	public static SealTable.SheetSealData GetSealData(SealID sealId)
	{
		return null;
	}

	public static SealTable.SheetEffectPositionOffset GetSealEffectPositionOffset(Size size)
	{
		return null;
	}

	public static SealTable.SheetFixedPositionEffect GetFixedSealEffectData(SealID sealID)
	{
		return null;
	}

	public static CharacterDressData.SheetData GetCharacterDressData(int dressId)
	{
		return null;
	}

	public static ShopTable.SheetBoutiqueShop GetBoutiqueShopData(int dressId)
	{
		return null;
	}

	public static KinomiData.SheetData GetKinomiDataByItemNo(ItemNo itemNo)
	{
		return null;
	}

	public static float GetFieldCommonParam(ParamIndx paramIndex)
	{
		return default(float);
	}

	private static IEnumerator Load_statueeffectdata()
	{
		return null;
	}
}
