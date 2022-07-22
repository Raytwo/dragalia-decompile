using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class AdventureNote : MonoBehaviour
{
	[Serializable]
	private class TypeParam
	{
		public RectTransform root;

		public UIText detail;

		public Image image;
	}

	[SerializeField]
	private UIText _title;

	[SerializeField]
	private UIText _page;

	[SerializeField]
	private Image[] _arrows;

	[SerializeField]
	private TypeParam[] _typeParams;

	public void Setup(List<AdventureNoteData.SheetData> datas, int pageIndex)
	{
	}

	public static string GetTextLabel(AdventureNoteData.SheetData data)
	{
		return null;
	}
}
