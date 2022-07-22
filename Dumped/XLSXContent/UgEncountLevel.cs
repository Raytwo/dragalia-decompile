using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgEncountLevel : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public int MinLv;

		public int MaxLv;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
