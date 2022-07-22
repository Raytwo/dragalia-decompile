using System;
using Pml;
using Ug;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgPokemonData : ScriptableObject
{
	[Serializable]
	public class Sheettable
	{
		public MonsNo monsno;

		public int type1ID;

		public int type2ID;

		public MonsSize size;

		public MoveType movetype;

		public int[] reactioncode;

		public int[] move_rate;

		public int[] submove_rate;

		public int[] reaction;

		public int[] flagrate;

		public int rateup;
	}

	public Sheettable[] table;

	public Sheettable this[int index] => null;
}
