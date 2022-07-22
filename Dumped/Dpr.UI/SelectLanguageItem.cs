using Dpr.Message;
using UnityEngine;

namespace Dpr.UI;

public class SelectLanguageItem : SelectOpeningItem
{
	[SerializeField]
	private MessageEnumData.MsgLangId _langId;

	[SerializeField]
	private bool _useKanji;

	public MessageEnumData.MsgLangId langId => default(MessageEnumData.MsgLangId);

	public bool useKanji => default(bool);
}
