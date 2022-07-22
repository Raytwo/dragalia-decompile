using System.Collections.Generic;
using Dpr.Message;
using Dpr.UI;
using Pml;
using UnityEngine;
using XLSXContent;

namespace Dpr.GMS;

public class GMSResourceContainer
{
	private UIManager uiManagerPtr;

	private Dictionary<int, Sprite> langIconSprTable;

	private Dictionary<int, string> langIconDataTable;

	private MonsIconData[] monsIconDataArray;

	private Sprite[] sexSprArray;

	public void Initialize()
	{
	}

	public void CreateLangIconDataTable(GMSMasterData.SheetLangIconData[] langIconData)
	{
	}

	public void OnFinalize()
	{
	}

	public Sprite GetSexSpr(Sex sex)
	{
		return null;
	}

	public Sprite GetLangIconSpr(MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	public bool CheckHasMonsIcon(MonsNo monsNo, uint formNo)
	{
		return default(bool);
	}

	public Sprite GetMonsIconSpr(MonsNo monsNo, uint formNo)
	{
		return null;
	}

	public void AddMonsIconSpr(MonsNo monsNo, uint formNo, Sprite iconSpr)
	{
	}

	private int ConvertMonsNoToIndex(MonsNo monsNo)
	{
		return default(int);
	}
}
