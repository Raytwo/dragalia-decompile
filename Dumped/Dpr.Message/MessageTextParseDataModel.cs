using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Dpr.Message;

public class MessageTextParseDataModel
{
	private List<MessageTagDataModel> tagDataList;

	private SetupTagReference setupTagRef;

	private MessageFormatter msgFormatter;

	private MessageTextLineDataModel[] lineMessageDataArray;

	private LabelData labelData;

	private MessageEnumData.MsgLangId langID;

	private StringBuilder textSb;

	public int LabelIndex => default(int);

	public string LabelName => null;

	public bool IsLabelNull => default(bool);

	public int StyleIndex => default(int);

	public float FontSize => default(float);

	public int TextWidth => default(int);

	public bool IsUnknownMessage => default(bool);

	private StyleInfo StyleInfo => null;

	public List<MessageTagDataModel> TagDataList => null;

	public TagData[] TagDataArray => null;

	public WordData[] WordDataArray => null;

	public void Dispose()
	{
	}

	public void SetLabelData(LabelData labelData, MessageEnumData.MsgLangId langID)
	{
	}

	public Color GetFontColor()
	{
		return default(Color);
	}

	[Obsolete]
	public bool HasAssignmentTag()
	{
		return default(bool);
	}

	public TagData GetTagDataByIndex(int index)
	{
		return null;
	}

	public string CreateSimpleMessage()
	{
		return null;
	}

	public void ApplyFormat()
	{
	}

	public void ApplyFormat(bool reparse)
	{
	}

	private void SetTagWords(AWordParamBase[] wordParamArray)
	{
	}

	public bool HasOverWidthLineData(float textFontScale, int viewWidth, out float fontScale)
	{
		return default(bool);
	}

	public string GetAllText()
	{
		return null;
	}

	public MessageTextLineDataModel[] GetLineMessageDataArray()
	{
		return null;
	}

	public bool IsOneLineTagMessage()
	{
		return default(bool);
	}

	public MessageTextLineDataModel[] CreateOneLineMessageDataArray(float textFontScale, float viewWidth)
	{
		return null;
	}

	private float GetSpaceStrWidth(float textFontScale)
	{
		return default(float);
	}

	private MessageTextLineDataModel ConcateLineDatas(int startIndex, int lastIndex, MessageEnumData.MsgEventID lineEndEventID, float totalLineWidth)
	{
		return null;
	}
}
