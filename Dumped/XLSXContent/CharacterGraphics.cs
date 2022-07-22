using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class CharacterGraphics : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public string ID;

		public string FieldGraphic;

		public float Scale;

		public float HandScale;

		public CharcterAnimeTable animTbl;
	}

	public SheetData[] Data;
}
