using System;

namespace Dpr.Message;

[Serializable]
public class StyleInfo
{
	public int styleIndex;

	public int colorIndex;

	public int fontSize;

	public int maxWidth;

	public MessageEnumData.MsgControlID controlID;
}
