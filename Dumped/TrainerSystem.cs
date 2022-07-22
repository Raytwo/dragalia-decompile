using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.BallDeco;
using Dpr.Battle.Logic;
using Dpr.Trainer;
using Pml;
using Pml.PokePara;
using XLSXContent;

public static class TrainerSystem
{
	public class CompTowerMatching : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	public class CompTowerSingleStock : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	public class CompTowerDoubleStock : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	public class CompTowerTrainerPoke : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	public struct PokeParamForCreate
	{
		public ushort MonsNo;

		public ushort FormNo;

		public bool IsRare;

		public byte Level;

		public Sex Sex;

		public byte Seikaku;

		public TokuseiNo TokuseiNo;

		public ushort Waza1;

		public ushort Waza2;

		public ushort Waza3;

		public ushort Waza4;

		public ushort Item;

		public BallId Ball;

		public byte TalentHp;

		public byte TalentAtk;

		public byte TalentDef;

		public byte TalentSpAtk;

		public byte TalentSpDef;

		public byte TalentAgi;

		public byte EffortHp;

		public byte EffortAtk;

		public byte EffortDef;

		public byte EffortSpAtk;

		public byte EffortSpDef;

		public byte EffortAgi;

		public SealTemplateID SealID;

		public bool Setup(TrainerTable.SheetTrainerPoke pokeData, int index)
		{
			return default(bool);
		}

		public void Setup(TowerTrainerTable.SheetTrainerPoke pokeData)
		{
		}
	}

	private struct TagTableElem
	{
		public TrainerType typeA;

		public TrainerType typeB;

		public TrainerType tagType;

		public TagTableElem(TrainerType typeA, TrainerType typeB, TrainerType tagType)
		{
		}
	}

	private static CompTowerMatching _comparerTowerMatching;

	private static CompTowerSingleStock _comparerTowerSingleStock;

	private static CompTowerDoubleStock _comparerTowerDoubleStock;

	private static CompTowerTrainerPoke _compareTowerTrainerPoke;

	private static readonly TagTableElem[] TAG_TABLE;

	private static TowerTrainerTable TowerTrainerTable => null;

	private static TowerMatchingTable TowerMatchingTable => null;

	private static TowerSingleStockTable TowerSingleStockTable => null;

	private static TowerDoubleStockTable TowerDoubleStockTable => null;

	private static TrainerTable TrainerTable => null;

	public static PokemonParam createPokemon([In] ref PokeParamForCreate pokeData, TowerTrainerTable.SheetTrainerData trainerData, TrainerTable.SheetTrainerType trainerTypeData, ulong personal_rand)
	{
		return null;
	}

	public static TowerLotResult CreateTowerLotResult(TowerLotRule lotRule, TowerLotCls lotCls, int rank, int round, ulong seed)
	{
		return null;
	}

	public static TowerLotResult CreateTowerLotResultByIndex(TowerLotRule lotRule, TowerLotCls lotCls, int rank, int round, int _index)
	{
		return null;
	}

	public static TowerTrainerTable.SheetTrainerData GetTowerTrainerData(TowerTrID towerTrId)
	{
		return null;
	}

	public static TowerTrainerTable.SheetTrainerPoke GetTowerPoke(uint pokeID)
	{
		return null;
	}

	public static TowerTrainerTable.SheetTrainerPoke GetTowerPokeByIndex(int index)
	{
		return null;
	}

	public static TowerMatchingTable.SheetTowerMatching GetTowerMatching(int matchingID)
	{
		return null;
	}

	public static TowerSingleStockTable.SheetTowerSingleStock GetTowerSingleStock(uint StockID)
	{
		return null;
	}

	public static TowerDoubleStockTable.SheetTowerDoubleStock GetTowerDoubleStock(uint StockID)
	{
		return null;
	}

	public static void GetTowerSingleStockRange(List<TowerSingleStockTable.SheetTowerSingleStock> recordList, uint StockIDMin, uint StockIDMax)
	{
	}

	public static void GetTowerDoubleStockRange(List<TowerDoubleStockTable.SheetTowerDoubleStock> recordList, uint StockIDMin, uint StockIDMax)
	{
	}

	private static bool getTowerSingleStockRange(out int outIndexMin, out int outIndexMax, uint StockIDMin, uint StockIDMax)
	{
		return default(bool);
	}

	private static int getTowerSingleStockIndex(uint MatchingID)
	{
		return default(int);
	}

	private static bool getTowerDoubleStockRange(out int outIndexMin, out int outIndexMax, uint StockIDMin, uint StockIDMax)
	{
		return default(bool);
	}

	private static int getTowerDoubleStockIndex(uint MatchingID)
	{
		return default(int);
	}

	public static int GetTowerMatchingID(TowerLotRule lotRule, TowerLotCls lotCls, int rank, int round)
	{
		return default(int);
	}

	public static bool IsSingleTowerMatchinID(int id)
	{
		return default(bool);
	}

	private static int LeftSegmentIndex(int index, int arrayLength)
	{
		return default(int);
	}

	public static void CheckTowerTable()
	{
	}

	public static TrainerTable.SheetTrainerType GetTrainerType(TrainerType trainerType)
	{
		return null;
	}

	public static TrainerTable.SheetTrainerData GetTrainerData(TrainerID trainerID)
	{
		return null;
	}

	public static TrainerTable.SheetTrainerPoke GetTrainerPoke(TrainerID trainerID)
	{
		return null;
	}

	public static TrainerTable.SheetSealTemplate GetSealTemplate(SealTemplateID trainerSealId)
	{
		return null;
	}

	public static TrainerTable.SheetSkirtGraphicsChara GetSkirtGraphicsChara(string modelId)
	{
		return null;
	}

	public static void EncountTrainerPersonalDataMake(BSP_TRAINER_DATA pBattleTrainerData, TrainerID trainerID)
	{
	}

	public static void EncountTrainerPokeDataMake(PokeParty pPokeParty, PartyDesc pPartyDesc, TrainerID trainerID, CapsuleData[] capsuleDatas)
	{
	}

	public static void SetupSealTemplate(ref CapsuleData dst, SealTemplateID sealTemplateID, PokemonParam pp)
	{
	}

	private static void createPokeParty(PokeParty pPokeParty, TrainerTable.SheetTrainerPoke trainerPoke, TrainerTable.SheetTrainerData trainerData, TrainerTable.SheetTrainerType trainerTypeData, CapsuleData[] capsuleDatas)
	{
	}

	public static PokemonParam createPokemon([In] ref PokeParamForCreate pokeData, TrainerTable.SheetTrainerData trainerData, TrainerTable.SheetTrainerType trainerTypeData, [Optional] PokeParty pokePartyForRndCheck)
	{
		return null;
	}

	private static bool FindPersnalRnd(PokeParty pokePartyForRndCheck, uint personal_rand)
	{
		return default(bool);
	}

	private static void setupInitSpec(InitialSpec pInitSpec, [In] ref PokeParamForCreate pokeData, ulong personal_rand, byte trainerSex)
	{
	}

	private static void setupPokemon(PokemonParam pPokeParam, [In] ref PokeParamForCreate pokeData, TrainerTable.SheetTrainerType trainerTypeData, bool isApplyPPUp)
	{
	}

	private static void setupPokemon_Waza(PokemonParam pPokeParam, [In] ref PokeParamForCreate pokeData)
	{
	}

	private static void setupPokemon_WazaPPUp(PokemonParam pPokeParam)
	{
	}

	public static TrainerType GetTagTrainerType(TrainerType trtype1, TrainerType trtype2)
	{
		return default(TrainerType);
	}
}
