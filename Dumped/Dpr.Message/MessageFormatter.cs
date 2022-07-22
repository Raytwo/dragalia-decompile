using System.Collections.Generic;
using System.Text;

namespace Dpr.Message;

public class MessageFormatter
{
	private const int INIT_LIST_CAPACITY = 16;

	private List<MessageTextLineDataModel> lineMessageDataList;

	private StringBuilder strBuilder;

	private FormatTagCommon commonFormatter;

	private FormatTagGrammar grammarFormatter;

	public void Initialize()
	{
	}

	public void Dispose()
	{
	}

	public string FormatGlossary(MessageGlossaryParseDataModel parseDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public string FormatSimple(MessageTextParseDataModel parseDataModel)
	{
		return null;
	}

	public MessageTextLineDataModel[] Format(MessageTextParseDataModel parseDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private void ApplyGlossaryName(MessageTextParseDataModel parseDataModel)
	{
	}

	private MessageGlossaryParseDataModel GetParseDataModelByCount(int labelIndex, MessageEnumData.QtyID qtyId, string singleMsbtName, string pluralMsbtName)
	{
		return null;
	}

	private MessageGlossaryParseDataModel GetGlossaryDataModel(string msbtName, int itemNumber)
	{
		return null;
	}

	private MessageGlossaryParseDataModel GetGlossaryDataModel(string msbtName, string labelName)
	{
		return null;
	}

	private void FormatMessage(MessageTextParseDataModel parseDataModel, MessageEnumData.MsgLangId languageId)
	{
	}

	private void AddStrData(MessageTextLineDataModel lineMessageData, MessageEnumData.MsgLangId languageId, float strWidth, float tagValue = 0f, MessageEnumData.MsgEventID endEventId = MessageEnumData.MsgEventID.None)
	{
	}

	private void AddLineDataModel(MessageEnumData.MsgEventID endEventId, MessageTextLineDataModel lineMessageData, MessageEnumData.MsgLangId languageId, float strWidth)
	{
	}

	private void AddLineMessageDataList(MessageTextLineDataModel addData)
	{
	}

	private string GetTagNameDataStr(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string FormatNameTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string FormatDigitTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string FormatENTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	private string FormatFRTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	private string FormatITTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	private string FormatDETagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	private string FormatESTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	private string FormatKorTagProcess(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	private string FormatSCTagProcess(MessageTagDataModel tagDataModel)
	{
		return null;
	}
}
