using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_Simulation_Damage : Section
{
	public class Description
	{
		public byte atkPokeID;

		public byte defPokeID;

		public WazaNo waza;

		public bool isAffinityEnable;

		public bool isRandomEnable;
	}

	public class Result
	{
		public ushort damage;
	}

	public Section_Simulation_Damage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private TypeAffinity.AffinityID checkTypeAffinity(byte attackerID, byte defenderID, WazaNo waza)
	{
		return default(TypeAffinity.AffinityID);
	}

	private BtlWeather getLoaclWeather(byte pokeID)
	{
		return default(BtlWeather);
	}
}
