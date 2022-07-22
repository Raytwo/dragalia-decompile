namespace Dpr.Message;

public class MessageTagDataModel : MessageTagData
{
	public bool IsAssignmentTag => default(bool);

	public void SetTagData(TagData tagData)
	{
	}

	public void SetWordParam(string strValue, int count, int attriGender, int attriInitialSound, int attriArticle, int attriCountability, float strWidth, bool bIsPokemonNickname)
	{
	}

	public void SetWordParam(string strValue, int count, int attriGender, int attriInitialSound, int attriArticle, int attriCountability, float strWidth, MessageEnumData.ForceGrmID forceGrmID)
	{
	}

	public void SetPlaceWordParam(string strValue, int count, int attriGender, int attriInitialSound, int attriArticle, int attriCountability, float strWidth)
	{
	}

	public void SetGlossaryData(MessageGlossaryParseDataModel glossaryDataModel)
	{
	}

	public string GetStrValue()
	{
		return null;
	}

	public bool IsCountability()
	{
		return default(bool);
	}

	public MessageEnumData.QtyID GetQtyId()
	{
		return default(MessageEnumData.QtyID);
	}

	public MessageEnumData.GenderID GetGenderId()
	{
		return default(MessageEnumData.GenderID);
	}

	public bool IsUseArticle()
	{
		return default(bool);
	}

	public bool IsUserInputWordTag()
	{
		return default(bool);
	}

	public bool IsNameWord()
	{
		return default(bool);
	}

	public MessageEnumData.ENInitialSoundID GetENInitialSoundId()
	{
		return default(MessageEnumData.ENInitialSoundID);
	}

	public MessageEnumData.FRInitialSoundID GetFRInitialSoundId()
	{
		return default(MessageEnumData.FRInitialSoundID);
	}

	public MessageEnumData.ITInitialSoundID GetITInitialSoundId()
	{
		return default(MessageEnumData.ITInitialSoundID);
	}

	public MessageEnumData.ESInitialSoundID GetESInitialSoundId()
	{
		return default(MessageEnumData.ESInitialSoundID);
	}

	public MessageEnumData.NameID GetNameTagId()
	{
		return default(MessageEnumData.NameID);
	}
}
