namespace Dpr.Message;

public class TagWordBuffer
{
	private AWordParamBase[] wordParamArray;

	private MessageEnumData.MsgLangId languageId;

	private MessageManager msgManager;

	public AWordParamBase[] WordParamArray => null;

	public void Initialize(MessageManager msgManager, MessageEnumData.MsgLangId languageId)
	{
	}

	public void SetLanguageId(MessageEnumData.MsgLangId languageId)
	{
	}

	public void ClearWordParam()
	{
	}

	public void SetWordParams(AWordParamBase[] wordParams)
	{
	}

	public void SetWordParam(int index, AWordParamBase wordParam)
	{
	}

	public bool IsSetTagWordParam(int index)
	{
		return default(bool);
	}

	public void SetGlossaryWordParam(int index, MessageGlossaryParseDataModel dataModel)
	{
	}

	public void SetGlossaryWordParam(int index, MessageGlossaryParseDataModel dataModel, int count)
	{
	}

	public void SetItemWordParam(int index, int itemNumber, int count)
	{
	}

	public void SetUserPokemonWordParam(int index, string nickName, int genderId, bool isEgg, MessageEnumData.MsgLangId languageid, int initialSound = 0)
	{
	}

	public void SetUserNickNameWordParam(int index, string nickName, int genderId, MessageEnumData.MsgLangId languageid)
	{
	}

	public void SetRivalNameWordParam(int index, string nickName, int genderId)
	{
	}

	public void SetSupporterName(int index, string nickName, int genderId)
	{
	}

	public void SetPlaceWordParam(int index, string labelName)
	{
	}

	public void SetStrWordParam(int index, string str, float strWidth = -1f)
	{
	}

	public void SetStrWordParam(int index, string str, MessageEnumData.MsgLangId langId, float strWidth = -1f)
	{
	}

	public void SetDigitWordParam(int index, int count)
	{
	}

	public void SetDigitWordParam(int index, int count, MessageEnumData.ForceGrmID forceGrmID)
	{
	}

	public void SetDigitStrWordParam(int index, string countStr)
	{
	}

	public void SetSingleTrTypeAndNameWordParam(int index, TrTypeAndNameData typeAndNameData)
	{
	}

	public void SetSameTypePairTrTypeAndNameWordParam(int index1, TrTypeAndNameData typeAndNameData1, int index2, TrTypeAndNameData typeAndNameData2)
	{
	}

	public void SetDiffTypePairTrTypeAndNameWordParam(int index1, TrTypeAndNameData typeAndNameData1, int index2, TrTypeAndNameData typeAndNameData2)
	{
	}
}
