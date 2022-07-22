namespace Dpr.Message;

public class LabelTagDataModel
{
	public int index;

	public MessageEnumData.TagPatternID patternID;

	public MessageEnumData.GroupTagID tagGroupID;

	public MessageEnumData.MsgLangId langID;

	public MessageEnumData.ForceGrmID forceGrmID;

	public ushort tagID;

	public string strValue;

	public int tagParameter;

	public string[] tagWords;

	public int forceArticle;

	public bool IsWordTag => default(bool);
}
