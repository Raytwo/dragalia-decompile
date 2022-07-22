using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class RareFishTable : ScriptableObject
{
	[Serializable]
	public class Sheettengan
	{
		public int X_axis;

		public int Y_axis;
	}

	public Sheettengan[] tengan;

	public Sheettengan this[int index] => null;
}
