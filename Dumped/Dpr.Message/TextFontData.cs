using UnityEngine;

namespace Dpr.Message;

[CreateAssetMenu]
public class TextFontData : ScriptableObject
{
	public TextParameter[] textParamArray;

	public TextParameter GetTextParamByLanguageId(MessageEnumData.MsgLangId langId)
	{
		return null;
	}
}
