using System.Collections.Generic;

namespace Dpr.Message;

public class MsbtDataModel
{
	public MessageEnumData.MsgLangId langID;

	public string fileName;

	public int hash;

	private Dictionary<int, int> labelIndexTable;

	private LabelData[] labelDataArray;

	private bool bIsResident;

	private bool bIsCreate;

	private int currentIndex;

	public bool IsCreate => default(bool);

	public bool IsResident => default(bool);

	public LabelData[] LabelDataArray => null;

	public MsbtDataModel(LabelData[] labelDataArray, MessageEnumData.MsgLangId langID, int hash, string fileName, bool isResident)
	{
	}

	public void ClearData()
	{
	}

	public void CreateLabelTable()
	{
	}

	public int GetTextNum()
	{
		return default(int);
	}

	public LabelData GetLabelDataByName(string labelName)
	{
		return null;
	}

	public LabelData GetLabelDataByIndex(int labelIndex)
	{
		return null;
	}
}
