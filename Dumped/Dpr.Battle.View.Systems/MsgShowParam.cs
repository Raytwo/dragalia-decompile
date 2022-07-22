namespace Dpr.Battle.View.Systems;

public struct MsgShowParam
{
	public static readonly MsgShowParam Default;

	public int MsgAfterglow;

	public bool IsKeyWait;

	public MsgShowParam(bool isKeyWait, int wait = 12)
	{
	}
}
