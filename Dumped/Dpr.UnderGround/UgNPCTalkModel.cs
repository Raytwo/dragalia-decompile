using Dpr.MsgWindow;
using XLSXContent;

namespace Dpr.UnderGround;

public class UgNPCTalkModel
{
	public bool NPCTalking;

	public bool NPCTalkEnd;

	public string talkMessageLabel;

	private UgNpcList.SheetSheet1 NpcData;

	private Dpr.MsgWindow.MsgWindow window;

	private MsgWindowParam msgParam;

	private bool isShowFinishedMessage;

	private int seq;

	public byte NPC_ID => default(byte);

	public string NameLabel => null;

	public void InputUpdate(float deltaTime)
	{
	}

	private void SetShowFinished(MsgWindowParam param)
	{
	}

	public UgNPCTalkModel(UgNpcList.SheetSheet1 Npc)
	{
	}

	public void Aisatsu()
	{
	}

	public void JikoSyoukai()
	{
	}

	public void TalkMessage()
	{
	}
}
