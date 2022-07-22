using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class CharacterTable : ScriptableObject
{
	[Serializable]
	public class SheetField
	{
		public string Label;

		public string AssetBundleName;
	}

	[Serializable]
	public class SheetBattle
	{
		public string Label;

		public string AssetBundleName;

		public string Type;
	}

	public SheetField[] Field;

	public SheetBattle[] Battle;
}
