using System;

namespace Dpr.Message;

[Serializable]
public class DigitWordParam : AWordParamBase
{
	private MessageEnumData.ForceGrmID forceGrmId;

	public DigitWordParam(int count)
	{
	}

	public DigitWordParam(string countStr)
	{
	}

	public DigitWordParam(int count, MessageEnumData.ForceGrmID forceGrmId)
	{
	}

	public override void SetWordParam(MessageTagDataModel tagDataModel)
	{
	}
}
