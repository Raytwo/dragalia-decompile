using System.Text;

namespace Dpr.Message;

public class WordDataModel
{
	public bool isUse;

	public StringBuilder sb;

	public MessageEnumData.MsgEventID endEventId;

	public MessageEnumData.MsgLangId languageId;

	public float tagValue;

	public float strWidth;

	public bool bIsRichTextTag;

	public int Length => default(int);

	public int StrLength => default(int);

	public bool IsNewLineEvent => default(bool);

	public void Init()
	{
	}

	private void Reset()
	{
	}

	public void AppendStr(string message)
	{
	}

	public string GetMessage()
	{
		return null;
	}

	public string GetMessageSubstring(int startIndex)
	{
		return null;
	}

	public void Clear()
	{
	}
}
