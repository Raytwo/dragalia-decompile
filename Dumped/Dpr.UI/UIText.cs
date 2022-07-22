using System.Runtime.InteropServices;
using Dpr.Message;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIText : TextMeshProUGUI
{
	[SerializeField]
	private MessageEnumData.UIFontSizeID _sizeId;

	[SerializeField]
	private bool _useMessage;

	[SerializeField]
	private string _messageFile;

	[SerializeField]
	private string _messageId;

	[SerializeField]
	private bool _useTag;

	[SerializeField]
	private bool _isManual;

	[SerializeField]
	private int _fontMaterialDataIndex;

	[SerializeField]
	private bool _uiTextEnable;

	private MessageMsgFile _msgFile;

	private int _messageIndex;

	public bool useTag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool useMessage
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnChangeKanjiMode(bool isKanji)
	{
	}

	protected override void Start()
	{
	}

	public void SetupMessage(string messageFile, string messageId)
	{
	}

	public void SetupMessage(string messageFile, int messageIndex)
	{
	}

	public void SetFormattedText(UnityAction onSet, [Optional] string messageFile, [Optional] string messageId)
	{
	}

	public void ChangeLanguage(MessageEnumData.MsgLangId langId)
	{
	}

	private void UpdateMessage(bool isForce = false, MessageEnumData.MsgLangId langId = MessageEnumData.MsgLangId.Num)
	{
	}
}
