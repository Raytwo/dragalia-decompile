namespace Dpr.Message;

public abstract class AWordParamBase
{
	protected string strValue;

	protected MessageEnumData.MsgLangId languageId;

	protected int count;

	protected int gender;

	protected int initialSound;

	protected int countablity;

	protected int articlePresence;

	protected float strWidth;

	protected bool bIsPokemonNickname;

	public virtual void SetWordParam(MessageTagDataModel tagDataModel)
	{
	}
}
