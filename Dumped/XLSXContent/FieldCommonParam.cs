using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FieldCommonParam : ScriptableObject
{
	[Serializable]
	public class Sheetdata
	{
		public float param;
	}

	public Sheetdata[] data;

	public Sheetdata this[int index] => null;
}
