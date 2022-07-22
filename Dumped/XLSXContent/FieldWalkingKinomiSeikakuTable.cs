using System;
using Pml.PokePara;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FieldWalkingKinomiSeikakuTable : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public Seikaku Seikaku;

		public int TableID;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
