using System.Collections.Generic;
using System.Text;

namespace Dpr.Message;

public class MessageTextLineDataModel
{
	private const int INIT_LIST_CAPACITY = 16;

	private List<WordDataModel> lineWordDataList;

	private StringBuilder lineStringBuilder;

	private MessageEnumData.MsgEventID currentEventId;

	private WordDataModel lastShowMsgObjData;

	private int totalStrLength;

	private int wordDataIndex;

	private int charIndex;

	private int nowStrIndex;

	private int tempCharIndex;

	private bool bIsCenter;

	public bool HasMessageData => default(bool);

	public List<WordDataModel> LineWordDataList => null;

	public bool IsCenterMessage => default(bool);

	public int TotalStringLength => default(int);

	public MessageEnumData.MsgEventID NowEventId => default(MessageEnumData.MsgEventID);

	public bool IsViewComplete => default(bool);

	~MessageTextLineDataModel()
	{
	}

	public void Dispose()
	{
	}

	public MessageEnumData.MsgEventID GetLineEndEventId()
	{
		return default(MessageEnumData.MsgEventID);
	}

	public float GetNowMessageDataValue()
	{
		return default(float);
	}

	public int CalcLineWidth(float textFontScale)
	{
		return default(int);
	}

	public void ResetMessageData()
	{
	}

	public string GetText()
	{
		return null;
	}

	public string GetTextUntilIndex(int index)
	{
		return null;
	}

	public string GetNextTextStr()
	{
		return null;
	}

	public bool HasShowMessageData()
	{
		return default(bool);
	}

	public void AddTextData(string str, MessageEnumData.MsgLangId languageID, float strWidth, float tagValue, MessageEnumData.MsgEventID endEventId)
	{
	}

	public void AddNameTextData(string str, MessageEnumData.MsgLangId languageID, float strWidth, bool isNameWord)
	{
	}

	private void AddNickNameStrData(string str, MessageEnumData.MsgLangId languageID, float strWidth)
	{
	}

	public void AddFontTagData(WordData wordData, MessageEnumData.MsgLangId languageId)
	{
	}

	public void AddLineWordData(WordDataModel wordDataModel)
	{
	}

	public void FinishLineMessageData(string str, MessageEnumData.MsgEventID endEventId, MessageEnumData.MsgLangId languageID, float strWidth)
	{
	}

	private void SettingLineStringDataInfo()
	{
	}

	private WordDataModel CreateFontTagObj(string str, MessageEnumData.MsgLangId languageID)
	{
		return null;
	}
}
