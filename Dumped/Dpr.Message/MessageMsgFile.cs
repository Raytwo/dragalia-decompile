namespace Dpr.Message;

public class MessageMsgFile
{
	private MsbtDataModel msbtDataModel;

	public MessageEnumData.MsgLangId LanguageID => default(MessageEnumData.MsgLangId);

	public string FileName => null;

	public MessageMsgFile(MsbtDataModel msbtDataModel)
	{
	}

	public void ReplaceMsbtDataModel(MsbtDataModel msbtDataModel)
	{
	}

	public bool IsValidData()
	{
		return default(bool);
	}

	public LabelData[] GetAllLabelDataArray()
	{
		return null;
	}

	public int GetLabelIndex(string label)
	{
		return default(int);
	}

	public string GetLabel(int index)
	{
		return null;
	}

	public int GetTotalTextNum()
	{
		return default(int);
	}

	public bool HasLabelByIndex(int labelIndex)
	{
		return default(bool);
	}

	public string GetNameStr(string label)
	{
		return null;
	}

	public string GetNameStr(int labelIndex)
	{
		return null;
	}

	public MessageGlossaryParseDataModel GetNameDataModelByIndex(int labelIndex)
	{
		return null;
	}

	public MessageGlossaryParseDataModel GetNameDataModel(string label)
	{
		return null;
	}

	public string GetSimpleMessage(string label)
	{
		return null;
	}

	public string GetSimpleMessage(int labelIndex)
	{
		return null;
	}

	public string GetFormattedMessage(string label)
	{
		return null;
	}

	public string GetFormattedMessage(int labelIndex)
	{
		return null;
	}

	public MessageTextParseDataModel GetTextDataModel(string label)
	{
		return null;
	}

	public MessageTextParseDataModel GetTextDataModelByIndex(int index)
	{
		return null;
	}

	public void ClearWordParam()
	{
	}

	public bool IsSetWordParam(int index)
	{
		return default(bool);
	}
}
