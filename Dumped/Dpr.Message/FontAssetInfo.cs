using System.Collections.Generic;
using TMPro;

namespace Dpr.Message;

public class FontAssetInfo
{
	public TMP_FontAsset fontAsset;

	public TextParameter textParam;

	private Dictionary<int, int> absFontSizeTable;

	public MessageEnumData.MsgLangId LangId => default(MessageEnumData.MsgLangId);

	public int LanguageIdToInt => default(int);

	public FontAssetInfo(TextParameter textParam, TMP_FontAsset fontAsset)
	{
	}

	public float GetBaseLine()
	{
		return default(float);
	}

	public int GetAbsFontSizeBySizeID(MessageEnumData.UIFontSizeID fontSizeId)
	{
		return default(int);
	}

	public void AddCharacters(string str)
	{
	}

	public void ClearFallbackFontAtlas()
	{
	}
}
