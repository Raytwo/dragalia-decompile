using System;
using Dpr.EvScript;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class AdventureNoteData : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public int Index;

		public int Version;

		public int Category;

		public string TitleLabel;

		public string TextLabel;

		public string TextLabelPatch;

		public bool NoteShowFlag;

		public string Image;

		public EvWork.FLAG_INDEX OpenFlag;
	}

	[Serializable]
	public class SheetTIPS
	{
		public int Category;

		public string FieldDisplay;

		public string MessageLabel;

		public string TipsTitleName;
	}

	public SheetData[] Data;

	public SheetTIPS[] TIPS;

	public SheetData this[int index] => null;
}
