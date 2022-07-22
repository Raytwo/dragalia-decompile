using System.Collections.Generic;
using System.Text;

namespace Dpr.Message;

public class MessageGlossaryParseDataModel
{
	private List<MessageTagDataModel> tagDataList;

	private SetupTagReference setupTagRef;

	private MessageFormatter msgFormatter;

	private LabelData labelData;

	private MessageEnumData.MsgLangId langID;

	private StringBuilder textSb;

	private AttributeInfo attributeInfo;

	private float strWidth;

	private float fontSize;

	public List<MessageTagDataModel> TagDataList => null;

	public AttributeInfo AttributeDataModel => null;

	public WordData[] WordDataArray => null;

	public float FontSize => default(float);

	public float StrWidth => default(float);

	public void Dispose()
	{
	}

	public void SetLabelData(LabelData labelData, MessageEnumData.MsgLangId langID)
	{
	}

	public void SetTagWord(int setTargetIndex, string word, float strWidth)
	{
	}

	public string GetName()
	{
		return null;
	}
}
