namespace Dpr.Message;

public class FormatTagGrammar
{
	private enum PatchumId
	{
		None,
		Ha,
		Wo,
		Ga,
		To,
		Ni,
		Ya,
		San
	}

	public string FormatENTag(MessageEnumData.ENID enId, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string GetEN_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetEN_IndArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private MessageEnumData.InitialSoundID CheckENInitialSound(string str, MessageEnumData.ENInitialSoundID initialSound)
	{
		return default(MessageEnumData.InitialSoundID);
	}

	public string FormatFRTag(MessageEnumData.FRID frId, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	public string GetElisionStr(MessageTagDataModel tagDataModel, string[] tagWords)
	{
		return null;
	}

	private string GetFRDefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetFRIndArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetFR_A_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetFR_De_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetDeWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetQueWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private MessageEnumData.InitialSoundID CheckFRInitialsVowel(MessageTagDataModel tagDataModel)
	{
		return default(MessageEnumData.InitialSoundID);
	}

	private bool IsNickName(MessageEnumData.GroupTagID groupTagId, int tagId)
	{
		return default(bool);
	}

	public string FormatITTag(MessageEnumData.ITID itId, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	public string GetDateITStr(MessageTagDataModel tagDataModel, string[] tagWords)
	{
		return null;
	}

	private string GetIT_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetIT_IndArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetDi_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetSu_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetIT_A_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetIn_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetEdWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetAdWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private MessageEnumData.InitialSoundID CheckITInitialsVowel(string str, MessageEnumData.ITInitialSoundID initialSound)
	{
		return default(MessageEnumData.InitialSoundID);
	}

	public string FormatDETag(MessageEnumData.DEID deId, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string GetDE_DefArtNomWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetDE_IndArtNomWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetDefArtAccWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetIndArtAccWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	public string FormatESTag(MessageEnumData.ESID esId, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string GetES_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetES_IndArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetES_De_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetES_A_DefArtWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetDefArt_TrTypeAndNameWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string GetA_DefArt_TrTypeAndNameWord(MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string GetDe_DefArt_TrTypeAndNameWord(MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string Gety_eWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	private string Geto_uWord(MessageTagDataModel tagDataModel, bool isCap)
	{
		return null;
	}

	public string FormatKorTag(MessageEnumData.KorID korId, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string GetParticleStr(int tagParameter, MessageTagDataModel tagDataModel)
	{
		return null;
	}

	private string GetLastString(string str)
	{
		return null;
	}

	private int GetParticlePatternCode(string lastStr)
	{
		return default(int);
	}

	private int GetParticlePatternCodeByDigit(int count)
	{
		return default(int);
	}
}
