using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class HirobaEnterablePoke : ScriptableObject
{
	[Serializable]
	public class SheetEnterablePoke
	{
		public int PokeID;

		public int ZenkokuPokeID;
	}

	public SheetEnterablePoke[] EnterablePoke;

	public SheetEnterablePoke this[int index] => null;
}
