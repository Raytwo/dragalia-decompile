using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FureaiPokeScaleTable : ScriptableObject
{
	[Serializable]
	public class SheetTable
	{
		public int PokeID;

		public float Hosei;
	}

	public SheetTable[] Table;

	public SheetTable this[int index] => null;
}
