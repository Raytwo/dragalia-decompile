using System;

namespace Dpr.Message;

[Serializable]
public class TextParameter
{
	[Serializable]
	public class FontSize
	{
		public MessageEnumData.UIFontSizeID fontSizeId;

		public int fontSize;
	}

	public MessageEnumData.MsgLangId langId;

	public float baseLineHeight;

	public float lineHeight;

	public FontSize[] absFontSizeArray;
}
