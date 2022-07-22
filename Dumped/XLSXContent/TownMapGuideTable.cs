using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TownMapGuideTable : ScriptableObject
{
	[Serializable]
	public class SheetGuide
	{
		public int Id;

		public int TownMapX;

		public int TownMapY;

		public string MSFile;

		public string MSLabel;
	}

	public SheetGuide[] Guide;

	public SheetGuide this[int index] => null;
}
