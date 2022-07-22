using System;
using AttributeData;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class MapAttributeTable : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public int Code;

		public MapAttribute Attribute;

		public bool Entry;

		public bool Water;

		public bool Encount;

		public string FieldEncount;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
