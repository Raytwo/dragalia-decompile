using System;
using TMPro;
using UnityEngine;

namespace Dpr.Message;

public class TextMsgApplier : MonoBehaviour
{
	[Serializable]
	public class UITextParameter
	{
		public TextMeshProUGUI uiText;

		public int fontMaterialIndex;

		public int msgFileIndex;

		public string labelName;

		public int labelIndex;
	}

	[SerializeField]
	private string[] msbtNameArray;

	[SerializeField]
	private UITextParameter[] paramArray;

	private MessageMsgFile[] msgFileArray;

	private MessageEnumData.MsgLangId langId;

	public MessageMsgFile GetMsgFile(int arrayIndex)
	{
		return null;
	}

	public void Apply()
	{
	}

	private void SetMsgFile()
	{
	}

	private void UpdateTextComponent()
	{
	}

	private void UpdateFontAsset(UITextParameter textParam)
	{
	}

	private void UpdateMessage(UITextParameter textParam)
	{
	}

	private bool CheckOutOfArrayIndex(int msgArrayIndex)
	{
		return default(bool);
	}

	private void OnDestroy()
	{
	}

	private void DisposeMsgFiles()
	{
	}
}
