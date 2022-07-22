using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class CharacterDressData : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public int Index;

		public string ID;

		public string BattleGraphic;

		public string FieldGraphic;

		public int Scale;

		public string MSLabel;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
