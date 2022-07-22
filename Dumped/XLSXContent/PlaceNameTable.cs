using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class PlaceNameTable : ScriptableObject
{
	[Serializable]
	public class SheetDprPlaceName
	{
		public int Index;

		public string MessageFile;

		public string MessageLabel;
	}

	public SheetDprPlaceName[] DprPlaceName;

	public SheetDprPlaceName this[int index] => null;
}
