using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class GimmickGraphics : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public string AssetPath;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
