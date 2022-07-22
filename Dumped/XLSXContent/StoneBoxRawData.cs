using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class StoneBoxRawData : ScriptableObject
{
	[Serializable]
	public class SheetBox
	{
		public short type;

		public short boxId;

		public string shape;

		public int ratio1;

		public int ratio2;
	}

	public SheetBox[] Box;

	public SheetBox this[int index] => null;
}
