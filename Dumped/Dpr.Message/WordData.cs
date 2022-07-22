using System;

namespace Dpr.Message;

[Serializable]
public class WordData
{
	public MessageEnumData.WordDataPatternID patternID;

	public MessageEnumData.MsgEventID eventID;

	public int tagIndex;

	public float tagValue;

	public string str;

	public float strWidth;
}
