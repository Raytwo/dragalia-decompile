namespace Dpr.Battle.Logic;

public sealed class PosEffect
{
	public enum EffectParamType
	{
		PARAM_TYPE_NONE,
		PARAM_TYPE_DELAY_ATTACK,
		PARAM_TYPE_DELAY_RECOVER
	}

	public struct EffectParam
	{
		private const int sz0 = 16;

		private const int loc0 = 0;

		private const int mask0 = 65535;

		private const int sz1 = 4;

		private const int loc1 = 16;

		private const int mask1 = 983040;

		private const int sz2 = 4;

		private const int loc2 = 20;

		private const int mask2 = 15728640;

		private const int sz3 = 8;

		private const int loc3 = 24;

		private const int mask3 = -16777216;

		private int raw;

		public uint Raw_param1
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public ushort DelayAttack_wazaNo
		{
			get
			{
				return default(ushort);
			}
			set
			{
			}
		}

		public byte DelayAttack_execTurnMax
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public byte DelayAttack_execTurnCount
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}
	}

	public const int POSEFF_PARAM_MAX = 4;

	private static readonly EffectParamType[] ParamTypeTable;

	public static EffectParamType GetEffectParamType(BtlPosEffect posEffect)
	{
		return default(EffectParamType);
	}
}
