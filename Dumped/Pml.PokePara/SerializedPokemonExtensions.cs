using System.Runtime.InteropServices;

namespace Pml.PokePara;

public static class SerializedPokemonExtensions
{
	public static void Serialize_Full(this PokemonParam self, ref SerializedPokemonFull buffer)
	{
	}

	public static void Deserialize_Full(this PokemonParam self, [In] ref SerializedPokemonFull serializedData)
	{
	}

	public static void Serialize_Core(this PokemonParam self, ref SerializedPokemonCore buffer)
	{
	}

	public static void Deserialize_Core(this PokemonParam self, [In] ref SerializedPokemonCore serializedData)
	{
	}
}
