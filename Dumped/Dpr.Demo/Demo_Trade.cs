using System.Collections;
using Dpr.Message;
using Dpr.SubContents;
using Pml.PokePara;

namespace Dpr.Demo;

public class Demo_Trade : DemoBase
{
	private enum TradeState
	{
		Start,
		Recive1,
		Recive2
	}

	public class Param
	{
		public int myTranerId;

		public int friendTranerId;

		public string friendTranerName;

		public bool isMiracle;

		public MessageEnumData.MsgLangId langId;
	}

	private TimeLineBinder timeLine;

	public PokemonParam MyPokeParam_Copy;

	public PokemonParam FriendPokeParam_Copy;

	public UnionTradeManager.BoxPokeData FriendPokeParam;

	private TradeState nowState;

	private Param _param;

	private MarkerReceiver receiver;

	private bool isTimelineComplete;

	public int Debug_RemoveEffectsNum;

	public bool UsePreGetCheck;

	public bool IsGetMonsNo;

	public bool IsGetEvolvedMonsNo;

	private float[] displayTime;

	public override void Destroy()
	{
	}

	public void SetParam(int myId, int friendId, string friendName, bool isMiracle = false, MessageEnumData.MsgLangId msgLangId = MessageEnumData.MsgLangId.JPN)
	{
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	public override IEnumerator Main()
	{
		return null;
	}

	public override IEnumerator Exit()
	{
		return null;
	}

	private void SetMessage()
	{
	}

	private void GoNextState()
	{
	}
}
