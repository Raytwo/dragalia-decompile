using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FieldWalkingKinomiTable : ScriptableObject
{
	[Serializable]
	public class SheetA
	{
		public int MstID;

		public int Rate;

		public int TableID;
	}

	[Serializable]
	public class SheetB
	{
		public int MstID;

		public int Rate;

		public int TableID;
	}

	[Serializable]
	public class SheetC
	{
		public int MstID;

		public int Rate;

		public int TableID;
	}

	public SheetA[] A;

	public SheetB[] B;

	public SheetC[] C;

	public SheetA this[int index] => null;
}
