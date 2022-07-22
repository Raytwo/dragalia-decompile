using System.Collections.Generic;
using System.Text;

namespace Dpr.Message;

public class MessageDataModel
{
	public enum LoadResult
	{
		Success,
		IsLoaded,
		Failed,
		IsRunning
	}

	private const int LOAD_PROCESS_NUM = 20;

	private const string UNDER_BAR = "_";

	private Dictionary<int, MsbtDataModel> msbtDataTable;

	private MessageEnumData.MsgLangId userLanguageId;

	private LoadMsbtOperation loadMsbtOp;

	private StringBuilder fileNameCapSb;

	private string[] languageVariants;

	private bool bIsKanji;

	private bool bInit;

	private bool bInitialized;

	public bool Initialized => default(bool);

	public bool IsCalledInitialize => default(bool);

	public LoadMsbtOperation LoadMsbtOperation => null;

	public bool IsAlreadySetLoadOpData => default(bool);

	public MessageEnumData.MsgLangId UserSelectLanguageID => default(MessageEnumData.MsgLangId);

	public bool IsKanji => default(bool);

	public string[] Variants => null;

	public void Initialize(MessageEnumData.MsgLangId languageId)
	{
	}

	public void InitializedManager()
	{
	}

	public void Dispose()
	{
	}

	public void SetUserSelectLanguageID(MessageEnumData.MsgLangId languageId)
	{
	}

	public void SetJPNKanjiFlag(bool flag)
	{
	}

	public string GetFileNameCapStr(MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public string GetJPNKanjiFileNameCapStr()
	{
		return null;
	}

	public string ConvertMSBTFileKey(string fileName, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public string ConvertMSBTFileKey(string fileName, MessageEnumData.MsgLangId languageId, bool kanji)
	{
		return null;
	}

	public string GetAssetBundleName(MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public string GetJPNKanjiAssetBundleName()
	{
		return null;
	}

	private string GetAssetFolderNameByLanguageId(MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public bool IsAlreadyLoadFile(string fileKey)
	{
		return default(bool);
	}

	public MessageMsgFile GetMsgFile(string fileName, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public void AddMsgDataFile(string fileName, MsbtData msbtData)
	{
	}

	public void CreateAllLabelTable()
	{
	}

	public void SetLoadOperationData()
	{
	}

	public void AddBinMsbtFileData(LoadMsbtFileTask loadTask)
	{
	}

	public void UnloadMSBTFileByLanguageId(MessageEnumData.MsgLangId langId)
	{
	}

	public AttributeInfo GetAttributeInfo(string fileName, string label, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public MessageGlossaryParseDataModel GetGloosaryParseData(string fileName, string label, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public MessageGlossaryParseDataModel GetGloosaryParseData(string fileName, int labelIndex, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public MessageTextParseDataModel GetTextParseData(string fileName, string label, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	public MessageTextParseDataModel GetTextParseData(string fileName, int labelIndex, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private LabelData GetLabelData(string fileName, string labelName, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}

	private LabelData GetLabelData(string fileName, int labelIndex, MessageEnumData.MsgLangId languageId)
	{
		return null;
	}
}
