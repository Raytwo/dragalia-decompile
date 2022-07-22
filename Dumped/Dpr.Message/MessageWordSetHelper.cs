using Dpr.Battle.Logic;
using Pml;
using Pml.PokePara;
using XLSXContent;

namespace Dpr.Message;

public static class MessageWordSetHelper
{
	public static MessageManager manager;

	public static void SetRivalNickNameWord(int tagIndex)
	{
	}

	public static void SetSupporterName(int tagIndex)
	{
	}

	public static void SetPlayerNickNameWord(int tagIndex)
	{
	}

	public static void SetPlayerNickNameWord(int tagIndex, PlayerNameData playerData)
	{
	}

	public static void SetPlayerNickNameWord(int tagIndex, MyStatus status)
	{
	}

	public static void SetSpeakersNameWord(int tagIndex, int speakerId)
	{
	}

	public static void SetPokemonNickNameWord(int tagIndex, CoreParam pp, bool isShowNickName = true)
	{
	}

	public static void SetPokemonNickNameWord(int tagIndex, MonsNameData monsNameData)
	{
	}

	public static void SetMonsNameWord(int tagIndex, MonsNo monsNo)
	{
	}

	public static void SetMonsNameWord(int tagIndex, int monsNo)
	{
	}

	public static void SetMonsNameWord(int tagIndex, CoreParam pp)
	{
	}

	public static void SetParentNameWord(int tagIndex, CoreParam pp)
	{
	}

	public static void SetContestDescriptionWord(int contestWazaIndex)
	{
	}

	public static void SetContestDescriptionWord(ContestWazaInfo.SheetContestWazaData wazaData)
	{
	}

	public static void SetWazaNameWord(int tagIndex, WazaNo wazaNo)
	{
	}

	public static void SetWazaTypeWord(int tagIndex, PokeType pokeTypeNo)
	{
	}

	public static void SetItemWord(int tagIndex, ItemNo itemNo, int itemCount)
	{
	}

	public static void SetItemWord(int tagIndex, int itemNo, int itemCount)
	{
	}

	public static void SetPocketNameWord(int tagIndex, ItemNo itemNo)
	{
	}

	public static void SetPocketNameWord(int tagIndex, int wordIndex)
	{
	}

	public static void SetSealNameWord(int tagIndex, SealID sealID)
	{
	}

	public static void SetSealNameWord(int tagIndex, SealID sealID, int itemCount)
	{
	}

	public static void SetUgItemNameWord(int tagIndex, int ugItemId)
	{
	}

	public static void SetUgItemNameWord(int tagIndex, int ugItemId, int itemCount)
	{
	}

	public static void SetParkItemNameWord(int tagIndex, int parkItemId)
	{
	}

	public static void SetParkItemNameWord(int tagIndex, int parkItemId, int itemCount)
	{
	}

	public static void SetKinomiNameWord(int tagIndex, int kinomiNo)
	{
	}

	public static void SetKinomiNameWord(int tagIndex, int kinomiNo, int itemCount)
	{
	}

	public static void SetRibbonNameWord(int tagIndex, int ribbonNo)
	{
	}

	public static void SetRibbonNameWord(int tagIndex, int ribbonNo, int itemCount)
	{
	}

	public static void SetDressupItemNameWord(int tagIndex, string label)
	{
	}

	public static void SetPoffinNameWord(int tagIndex, string poffinLabelName)
	{
	}

	public static void SetPoffinNameWord(int tagIndex, string poffinLabelName, int itemCount)
	{
	}

	public static void SetPoffinNameWord(int tagIndex, int labelIndex)
	{
	}

	public static void SetPoffinNameWord(int tagIndex, int labelIndex, int itemCount)
	{
	}

	public static void SetTokuseiWord(int tagIndex, TokuseiNo tokuseiNo)
	{
	}

	public static void SetSeikakuWord(int tagIndex, Seikaku seikakuNo)
	{
	}

	public static void SetTrainerNameWord(int tagIndex, string labelName)
	{
	}

	public static void SetTrainerTypeWord(int tagIndex, string labelName)
	{
	}

	public static void SetAreanameWord(int tagIndex, string labelName)
	{
	}

	public static void SetAreanameWord(int tagIndex, int labelIndex)
	{
	}

	public static void SetAreanameIndirectWord(int tagIndex, string labelName)
	{
	}

	public static void SetAreanameIndirectWord(int tagIndex, int labelIndex)
	{
	}

	public static void SetAreanameDisplayWord(int tagIndex, int labelIndex)
	{
	}

	public static void SetAreanameDisplayWord(int tagIndex, string labelName)
	{
	}

	public static void SetAreanameTownmapWord(int tagIndex, string labelName)
	{
	}

	public static void SetAreanameTownmapWord(int tagIndex, int labelIndex)
	{
	}

	public static void SetPlaceNameWord(int tagIndex, int placeID)
	{
	}

	public static void SetPlaceNameWord(int tagIndex, string labelName)
	{
	}

	public static void SetStatusNameWord(int tagIndex, PowerID powerId, uint totalValue)
	{
	}

	public static void SetDigitWord(int tagIndex, int number)
	{
	}

	public static void SetDigitWord(int tagIndex, string numberStr)
	{
	}

	public static void SetCentiSizeUnitWord(float centimeterSize, int integerTagIndex, int decimalTagIndex)
	{
	}

	public static void SetStringWord(int tagIndex, string str)
	{
	}

	public static void SetStringWord(int tagIndex, string str, MessageEnumData.MsgLangId langId)
	{
	}

	public static void SetRivalTypeAndNameWord(int tagIndex, string typeLabel)
	{
	}

	public static void SetSingleTrainerTypeAndNameWord(int tagIndex, string typeLabel, string nameLabel)
	{
	}

	public static void SetSingleTrainerTypeAndNameWord(int tagIndex, int typeLabelIndex, int nameLabelIndex)
	{
	}

	public static void SetRivalTagTrainerTypeAndNameWord(int rivalTagIndex, string rivalTypeLabel, int pairTagIndex, string pairTagTypeLabel, string pairTagNameLabel)
	{
	}

	public static void SetRivalTagTrainerTypeAndNameWord(int rivalTagIndex, string rivalTypeLabel, int pairTagIndex, int pairTagTypeLabelIndex, int pairTagNameLabelIndex)
	{
	}

	public static void SetSameTagTrainerTypeAndNameWord(int tagIndex1, string typeLabel, string nameLabel1, int tagIndex2, string nameLabel2)
	{
	}

	public static void SetSameTagTrainerTypeAndNameWord(int tagIndex1, int typeLabelIndex, int nameLabelIndex1, int tagIndex2, int nameLabelIndex2)
	{
	}

	public static void SetDiffTagTrainerTypeAndNameWord(int tagIndex1, string typeLabel1, string nameLabel1, int tagIndex2, string typeLabel2, string nameLabel2)
	{
	}

	public static void SetDiffTagTrainerTypeAndNameWord(int tagIndex1, int typeLabelIndex1, int nameLabelIndex1, int tagIndex2, int typeLabelIndex2, int nameLabelIndex2)
	{
	}

	private static TrTypeAndNameData CreateTrTypeAndNameDataFromLabelName(string typeLabel, string nameLabel)
	{
		return null;
	}

	private static TrTypeAndNameData CreateTrTypeAndNameDataFromLabelIndex(int typeLabelIndex, int nameLabelIndex)
	{
		return null;
	}

	private static TrTypeAndNameData CreateTrTypeAndNameData(MessageGlossaryParseDataModel typeDataModel, MessageGlossaryParseDataModel nameDataModel)
	{
		return null;
	}

	private static TrTypeAndNameData CreateRivalTrTypeAndNameData(string typeLabel)
	{
		return null;
	}

	public static void SetPocketchWord(int tagIndex, int labelIndex)
	{
	}

	public static void SetPocketchNameWord(int tagIndex, int appId)
	{
	}

	public static void SetGlossaryWord(int index, string msbtName, string labelName)
	{
	}

	public static void SetGlossaryWord(int index, string msbtName, string labelName, int count)
	{
	}

	public static void SetGlossaryWord(int index, string msbtName, int labelIndex)
	{
	}

	public static void SetGlossaryWord(int index, string msbtName, int labelIndex, int count)
	{
	}

	public static void SetGlossaryWordFromMsgFile(int index, MessageMsgFile msgFile, string label)
	{
	}

	public static void SetGlossaryWordFromMsgFile(int index, MessageMsgFile msgFile, int labelIndex)
	{
	}

	public static void SetStringWordFromMsgFile(int index, MessageMsgFile msgFile, string label)
	{
	}

	public static void SetStringWordFromMsgFile(int index, MessageMsgFile msgFile, int labelIndex)
	{
	}

	private static string GetWordStr(string msbtName, int labelIndex)
	{
		return null;
	}

	private static string GetWordStr(string msbtName, string labelName)
	{
		return null;
	}

	private static MessageGlossaryParseDataModel GetWordDataModel(string msbtName, int labelIndex)
	{
		return null;
	}

	private static MessageGlossaryParseDataModel GetWordDataModel(string msbtName, string labelName)
	{
		return null;
	}

	private static int GetLabelIndexByLabelName(string msbtName, string labelName)
	{
		return default(int);
	}

	private static string GetLabelNameByIndex(string msbtName, int labelIndex)
	{
		return null;
	}

	private static bool CheckEnableIndex(string msbtName, int labelIndex)
	{
		return default(bool);
	}
}
