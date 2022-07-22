using System.Runtime.CompilerServices;
using Dpr.Message;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanLanguageButton : MonoBehaviour, IUIButton
{
	private const string LanguageSpriteNameFormat = "cmn_ico_txt_lang_{0}_";

	[SerializeField]
	private Image image;

	private int index;

	private RectTransform rectTransform;

	private Sprite selectSprite;

	private Sprite unselectSprite;

	public MessageEnumData.MsgLangId LangId
	{
		[CompilerGenerated]
		get
		{
			return default(MessageEnumData.MsgLangId);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int GetIndex()
	{
		return default(int);
	}

	public void SetIndex(int index)
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool isActive)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void SetLanguage(MessageEnumData.MsgLangId langId)
	{
	}
}
