using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UnionCharacterTable : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int ID;

		public string AssetName;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
