using System.Runtime.InteropServices;
using Dpr.BallDeco;
using Pml;
using Pml.PokePara;

[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 172)]
public struct CAPSULEDATA_COMM
{
	public CapsuleData capsule;

	public void SetupFromPlayerWork(PokeParty party, int index)
	{
	}

	public void SetupFromPlayerWork(PokemonParam pp)
	{
	}
}
