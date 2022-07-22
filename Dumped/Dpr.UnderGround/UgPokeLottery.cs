using System.Collections.Generic;
using Dpr.SubContents;
using Pml;
using Pml.PokePara;
using Ug;
using XLSXContent;

namespace Dpr.UnderGround;

public class UgPokeLottery
{
	public class PokeSlot
	{
		public PokemonParam param;

		public TypeAndSize ts;

		public PokeType type => default(PokeType);

		public MonsSize size => default(MonsSize);

		public PokeSlot(PokeType type, MonsSize size)
		{
		}
	}

	public struct TypeAndSize
	{
		public MonsSize size;

		public PokeType type;

		public int value;

		public TypeAndSize(PokeType type, MonsSize size)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}

	private struct TypeRate : IHaveWeight
	{
		public PokeType type;

		public int rate;

		float IHaveWeight.lotteryWeight => default(float);

		public TypeRate(PokeType type, int rate)
		{
		}
	}

	private struct PokeRate : IHaveWeight
	{
		public MonsNo monsNo;

		public int rate;

		float IHaveWeight.lotteryWeight => default(float);

		public PokeRate(MonsNo monsNo, int rate)
		{
		}
	}

	private UgRandMark.Sheettable randMarkData;

	private UgEncount monsData;

	private List<KeyValuePair<TypeAndSize, int>> MonsDataIndexs;

	private List<ushort> buf_wazaTable;

	public List<PokeSlot> DoLottery(int randMarkID)
	{
		return null;
	}

	private MonsNo GetRarePoke(int randMarkID, int versionID)
	{
		return default(MonsNo);
	}

	private void LotteryPoke(UgEncount.Sheettable[] origList, List<PokeSlot> slots, byte rareTryCount)
	{
	}

	private PokemonParam CreatePokemonParam_by_Tokusei(MonsNo monsNo, byte rareTryCount)
	{
		return null;
	}

	public short GetTamagoWazaNo(PokemonParam param)
	{
		return default(short);
	}

	public void SetTamagoWaza(PokemonParam param, ushort wazaNo)
	{
	}

	private UgEncount.Sheettable[] GetEnablePokes(int versionNo, int storyNo)
	{
		return null;
	}

	private UgEncount.Sheettable[] GetFilteredListWithTypeAndSize(UgEncount.Sheettable[] list, PokeSlot slot)
	{
		return null;
	}

	private List<PokeSlot> CreateSlots(int Num)
	{
		return null;
	}

	private MonsSize GetRandomSize(List<MonsSize> list, List<MonsSize> existSizeList)
	{
		return default(MonsSize);
	}

	private int GetStoryNo()
	{
		return default(int);
	}

	private int GetVersionNo()
	{
		return default(int);
	}

	private ushort GetPokeLevel(bool SelectForceMax = false)
	{
		return default(ushort);
	}
}
