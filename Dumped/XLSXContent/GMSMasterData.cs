using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class GMSMasterData : ScriptableObject
{
	[Serializable]
	public class SheetPoints
	{
		public bool valid_flag;

		public ushort id;

		public ushort index;

		public Vector3 point;
	}

	[Serializable]
	public class SheetPutRank
	{
		public bool valid_flag;

		public ushort id;

		public int rank;

		public int nextRankCount;

		public int texIndex;
	}

	[Serializable]
	public class SheetWindowMessage
	{
		public bool valid_flag;

		public ushort id;

		public string msbt;

		public string msgLabel;
	}

	[Serializable]
	public class SheetLangIconData
	{
		public bool valid_flag;

		public ushort id;

		public string texName;
	}

	[Serializable]
	public class SheetResourceData
	{
		public bool valid_flag;

		public ushort id;

		public string assetbundlePath;
	}

	[Serializable]
	public class SheetGraphicTextName
	{
		public bool valid_flag;

		public ushort id;

		public string spriteName;
	}

	[Serializable]
	public class SheetValueData
	{
		public bool valid_flag;

		public int value;
	}

	public SheetPoints[] Points;

	public SheetPutRank[] PutRank;

	public SheetWindowMessage[] WindowMessage;

	public SheetLangIconData[] LangIconData;

	public SheetResourceData[] ResourceData;

	public SheetGraphicTextName[] GraphicTextName;

	public SheetValueData[] ValueData;

	public SheetPoints this[int index] => null;
}
