using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class ServerRequestGenerator
{
	public class SetupParam
	{
		public ServerCommandGenerator pServerCmdGenerator;

		public ServerCommandQueue pServerCmdQueue;

		public PokeChangeRequest pPokeChangeRequest;

		public SendDataContainer pSendDataContainer;

		public rec.SendTool pRecTool;

		public SVCL_ACTION pClientInstruction;

		public unsafe BTL_RESULT_CONTEXT* pBattleResultContext;

		public TimeLimit pTimeLimit;
	}

	private ServerCommandGenerator m_pServerCmdGenerator;

	private ServerCommandQueue m_pServerCmdQueue;

	private PokeChangeRequest m_pPokeChangeRequest;

	private SendDataContainer m_pSendDataContainer;

	private rec.SendTool m_pRecTool;

	private SVCL_ACTION m_pClientInstructions;

	private unsafe BTL_RESULT_CONTEXT* m_battleResultContext;

	private TimeLimit m_pTimeLimit;

	private unsafe ServerSendData.CONFIRM_COUNTER_POKECHANGE* m_sendData_ConfirmCounterPokeChange;

	private unsafe ServerSendData.CLIENT_LIMIT_TIME* m_sendData_ClientLimitTime;

	private unsafe ServerSendData.RAIDBOSS_CAPTURE_RESULT* m_sendData_CoopCapResult;

	private unsafe ServerSendData.POKECHANGE_REQUEST* m_sendData_PokeChangeRequest;

	private bool m_isBattleInEventOccured;

	private bool m_isEscapeSucceeded;

	private InterruptCode m_interruptCode;

	public ServerRequestGenerator([In] ref SetupParam setupParam)
	{
	}

	public InterruptCode GetInterruptCode()
	{
		return default(InterruptCode);
	}

	public bool IsEscapeSucceededOnChangeOrEscape()
	{
		return default(bool);
	}

	public void SetSendData_ConfirmCounterPokeChange(byte enemyPutPokeID)
	{
	}

	public void SetSendData_RaidBossCaptureResult([In] ref ServerSendData.RAIDBOSS_CAPTURE_RESULT data)
	{
	}

	public unsafe void GenerateSendData(void** data, ref uint dataSize, ServerRequest serverReq, uint serialNo)
	{
	}

	private unsafe void calcSendData(void** data, out uint dataSize, ServerRequest serverReq)
	{
	}

	private unsafe void calcSendData_SELECT_COVER_POKE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_CONFIRM_COUNTER_POKECHANGE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SERVER_CMD_AFTER_COVER_POKE_SELECT(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SELECT_CHANGE_POKE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SERVER_CMD_FIRST_BATTLE_IN(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SERVER_CMD_AFTER_ACTION_SELECT(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SERVER_CMD_ESCAPE_BY_CHANGE_OR_ESCAPE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SERVER_CMD_AFTER_INTERRUPT_POKECHANGE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SERVER_CMD_POKECHANGE_AFTERFIRSTPOKEIN(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_RECORD_BATTLE_START_TIMING(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_RECORD_BATTLE_START_CHAPTER(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_RECORD_ACTION(void** data, ref uint dataSize, rec.Timing timingCode, bool fChapter)
	{
	}

	private unsafe void calcSendData_RECORD_TIMEUP_CHAPTER(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_WILD_WIN(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_WILD_LOSE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_WILD_FORCE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_CAPTURE(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_COMM(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_NPC(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_EXIT_BATTLE_SPOT_TRAINER(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_SYNC_CLIENT_LIMIT_TIME(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_RAID_CAPTURE_RESULT(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_RAID_SCMD_RESULT(void** data, ref uint dataSize)
	{
	}

	private unsafe void calcSendData_RAID_EXIT_LOSE(void** data, ref uint dataSize)
	{
	}
}
