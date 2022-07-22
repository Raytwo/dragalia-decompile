using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgPokemonPos : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public ZoneID ZoneID;

		public Vector3[] Locator;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
