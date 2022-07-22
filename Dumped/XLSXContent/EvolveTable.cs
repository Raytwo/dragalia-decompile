using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class EvolveTable : ScriptableObject
{
	[Serializable]
	public class SheetEvolve
	{
		public int id;

		public ushort[] ar;
	}

	public SheetEvolve[] Evolve;
}
