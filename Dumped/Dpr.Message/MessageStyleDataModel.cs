using UnityEngine;

namespace Dpr.Message;

public class MessageStyleDataModel : MessageStyleData
{
	public int styleIndex;

	public Color fontColor;

	public int fontSize;

	public int maxTextWidth;

	public Color GetFontColor => default(Color);

	public MessageStyleDataModel(int styleIndex, MessageStyleData formatData)
	{
	}
}
