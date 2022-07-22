using System;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgSpecialPokemon : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int id;

		public MonsNo monsno;

		public int version;

		public int Dspecialrate;

		public int Pspecialrate;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
