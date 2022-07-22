using System;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class KinomiData : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public int TagNo;

		public ItemNo ItemNo;

		public float Size;

		public int Firmness;

		public int Spicy;

		public int Dry;

		public int Sweet;

		public int Bitter;

		public int Sour;

		public int Taste;

		public int GrowTime;

		public int MinHarvests;

		public int MaxHarvests;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
