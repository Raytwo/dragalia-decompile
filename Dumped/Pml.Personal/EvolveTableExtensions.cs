using XLSXContent;

namespace Pml.Personal;

public static class EvolveTableExtensions
{
	private const byte NEXT_FORMNO_INHERIT = byte.MaxValue;

	private const int UNITLEN_AR = 5;

	public static int Length(this EvolveTable.SheetEvolve self)
	{
		return default(int);
	}

	public static byte GetEvolutionRouteNum(this EvolveTable.SheetEvolve self)
	{
		return default(byte);
	}

	public static EvolveCond GetEvolutionCondition(this EvolveTable.SheetEvolve self, int index)
	{
		return default(EvolveCond);
	}

	public static EvolveCond GetEvolutionCondition(this EvolveTable.SheetEvolve self, MonsNo next_monsno)
	{
		return default(EvolveCond);
	}

	public static ushort GetEvolutionParam(this EvolveTable.SheetEvolve self, int index)
	{
		return default(ushort);
	}

	public static MonsNo GetEvolvedMonsNo(this EvolveTable.SheetEvolve self, int index)
	{
		return default(MonsNo);
	}

	public static byte GetEvolvedFormNo(this EvolveTable.SheetEvolve self, int index)
	{
		return default(byte);
	}

	public static bool IsEvolvedFormNoSpecified(this EvolveTable.SheetEvolve self, int route_index)
	{
		return default(bool);
	}

	public static byte GetEvolveEnableLevel(this EvolveTable.SheetEvolve self, int index)
	{
		return default(byte);
	}
}
