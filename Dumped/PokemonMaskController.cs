using System.Collections.Generic;
using UnityEngine;

public class PokemonMaskController
{
	private struct MaskAndCore
	{
		public int entryIndex;

		public SkinnedMeshRenderer[] mask;

		public SkinnedMeshRenderer[] core;

		public SkinnedMeshRenderer[] other;
	}

	private static readonly int STENCIL_ID;

	private static readonly int STENCIL_OP_ID;

	private static readonly int POKEMON_STENCIL_ID;

	private static readonly int ZWRITE_ID;

	private static readonly int ZTEST_ID;

	private const int START_STENCIL_ID = 8;

	private const int STENCIL_ENTRY_SIZE = 32;

	private static bool[] _stencilEntries;

	private static Dictionary<BaseEntity, MaskAndCore> _maskGroups;

	private static int FindEntry()
	{
		return default(int);
	}

	public static void Register(BaseEntity baseEntity)
	{
	}

	public static void Unregister(BaseEntity baseEntity)
	{
	}
}
