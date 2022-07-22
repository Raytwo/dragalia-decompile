using System;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgNpcList : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public ushort NpcId;

		public bool IsRandom;

		public ZoneID ZoneID;

		public Sex Sex;

		public string CharacterID;

		public byte ColorID;

		public string NameLabel;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
