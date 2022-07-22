using System.Collections.Generic;
using Nintendo.MessageStudio.Lib;
using TMPro;

namespace Dpr.Message;

public class MsbtParser
{
	private class MsbtFileData
	{
		public MessageEnumData.MsgLangId langID;

		public LabelDataModel[] labelDataModelArray;

		public BinMsgFile binMsgFile;

		public int LabelNum => default(int);

		public MessageAttributeDataModel GetAttributeDataModel(int labelIndex)
		{
			return null;
		}

		public MessageEnumData.MsgControlID CheckControlID(int labelIndex)
		{
			return default(MessageEnumData.MsgControlID);
		}

		public int GetMaxDataIndex()
		{
			return default(int);
		}

		public int GetIndexAttributeData(int labelIndex)
		{
			return default(int);
		}
	}

	private class LabelDataModel
	{
		public LabelParseDataModel parseDataModel;

		public string labelName;

		public int labelIndex;

		public int arrayIndex;

		public int styleIndex;

		public int patchVersion;

		public List<LabelTagDataModel> TagDataList => null;
	}

	private class MsgEventData
	{
		public MessageEnumData.MsgEventID endEventId;

		public float tagParameter;
	}

	private const char NEW_LINE_CHAR = '\r';

	private List<WordData> wordDataList;

	private LabelParseProcessor parseProcessor;

	private MessageEnumData.MsgLangId msgLangID;

	private TMP_FontAsset fontAsset;

	private float fontSize;

	private MessageEnumData.MsgLangId fontTagLangID;

	private int sizeTagScale;

	public void Initialize()
	{
	}

	public LabelData[] ParseMsbtBinData(byte[] binDataArray, MessageEnumData.MsgLangId langID, int patchVersion)
	{
		return null;
	}

	private MsbtFileData ParseMsbtFileData(byte[] msbtByteDataArray)
	{
		return null;
	}

	private LabelData[] ConvertParseTextDataToFormatMsbtData(MsbtFileData dataModel, int patchVersion)
	{
		return null;
	}

	private StyleInfo CreateStyleInfo(int styleIndex, MessageEnumData.MsgControlID controlID)
	{
		return null;
	}

	private int[] CreateAttributeInfo(MessageAttributeDataModel attributeDataModel)
	{
		return null;
	}

	private TagData[] CreateTagDataArray(LabelDataModel dataModel)
	{
		return null;
	}

	private void SetForceTagReference(List<LabelTagDataModel> tagDataList)
	{
	}

	private void GrmTagReference(int listIndex, MessageEnumData.GrmID tagId, List<LabelTagDataModel> tagDataList)
	{
	}

	private void ENTagReference(int listIndex, LabelTagDataModel tagData, List<LabelTagDataModel> tagDataList)
	{
	}

	private void FRTagReference(int listIndex, LabelTagDataModel tagData, List<LabelTagDataModel> tagDataList)
	{
	}

	private void ITTagReference(int listIndex, LabelTagDataModel tagData, List<LabelTagDataModel> tagDataList)
	{
	}

	private void DETagReference(int listIndex, LabelTagDataModel tagData, List<LabelTagDataModel> tagDataList)
	{
	}

	private void ESTagReference(int listIndex, LabelTagDataModel tagData, List<LabelTagDataModel> tagDataList)
	{
	}

	private void SetForceGrmId(int listIndex, List<LabelTagDataModel> tagDataList, MessageEnumData.ForceGrmID forceGrmId)
	{
	}

	private WordData[] CreateWordDataArray(LabelParseDataModel parseDataModel, out string errorMsg)
	{
		return null;
	}

	private MsgEventData CreateEventDataByCtrl2ID(MessageEnumData.Ctrl2ID tagId, float tagParameter)
	{
		return null;
	}

	private void AddStrWordData(string str)
	{
	}

	private void AddNewLineWordData(MessageEnumData.MsgEventID eventID, string str)
	{
	}

	public void SetFontAsset(MessageEnumData.MsgLangId langID)
	{
	}

	private float CalcStrWidth(string str)
	{
		return default(float);
	}
}
