using System.Text;

namespace Dpr.Message;

public class FormatTagCommon
{
	private StringBuilder strBuilder;

	private char charComma;

	private char charPreriod;

	private char charHarfSpace;

	private char charQuaterSpace;

	public void Initialize()
	{
	}

	public string FormatNameTag(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string GetNameUpperCase(MessageTagDataModel tagDataModel, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public string FormatDigitTag(MessageEnumData.DigitID digitTagId, int tagParameter, int count, string strValue, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string ConvertValueToString(int count)
	{
		return null;
	}

	private string ConvertValueToDigitGroupingStr(int tagParameter, int value, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string ConvertValueToStrByLanguage(int value, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private string GetNumStrGroupingByChar(char c, int value, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private bool CheckIsFourDigitInESP(int value, MessageEnumData.MsgLangId languageId)
	{
		return default(bool);
	}

	public string GetGenderStr(int refValue, MessageTagDataModel refTagData, string[] words)
	{
		return null;
	}

	public string GetQtyStr(MessageTagDataModel refTagData, string[] words, MessageEnumData.MsgLangId langID)
	{
		return null;
	}

	public string GetGenderQty(MessageTagDataModel refTagData, string[] words)
	{
		return null;
	}

	public string GetDEGenderQty(MessageTagDataModel refTagData, string[] words)
	{
		return null;
	}

	private MessageEnumData.DEGenderQtyID GetDEGenderQtyId(MessageEnumData.GenderID genderId, MessageEnumData.QtyID qtyId)
	{
		return default(MessageEnumData.DEGenderQtyID);
	}

	public string GetQtyZeroStr(MessageTagDataModel refTagData, string[] words)
	{
		return null;
	}
}
