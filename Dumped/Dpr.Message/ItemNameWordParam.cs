using System;

namespace Dpr.Message;

[Serializable]
public class ItemNameWordParam : AWordParamBase
{
	private int itemNumber;

	public ItemNameWordParam(int itemNumber, int count, MessageEnumData.MsgLangId languageId)
	{
	}

	public override void SetWordParam(MessageTagDataModel tagDataModel)
	{
	}
}
