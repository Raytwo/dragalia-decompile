namespace Dpr;

public static class Regulation
{
	public enum LevelRangeType : byte
	{
		SAME,
		DRAG_DOWN,
		NONE
	}

	public struct Data
	{
		public byte select_num_lo;

		public byte select_num_hi;

		public LevelRangeType level_range;

		private byte _bitsA;

		private const int bitsA0_sz = 1;

		private const int bitsA0_loc = 0;

		private const int bitsA1_sz = 1;

		private const int bitsA1_loc = 1;

		private const int bitsA2_sz = 1;

		private const int bitsA2_loc = 2;

		private const int bitsA0_mask = 1;

		private const int bitsA1_mask = 2;

		private const int bitsA2_mask = 4;

		public bool enable_legend
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool enable_same_poke
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool enable_same_item
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Data(byte pokeNumMin, byte pokeNumMax, LevelRangeType levelRange = LevelRangeType.SAME, bool isEnableLegend = true, bool isEnableSamePoke = true, bool isEnableSameItem = true)
		{
		}
	}
}
