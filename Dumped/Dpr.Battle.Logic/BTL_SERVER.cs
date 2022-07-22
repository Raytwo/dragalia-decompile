using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class BTL_SERVER
{
	private delegate void SequenceFunc(ref int seqStep, ref ServerSequence pNextSeq);

	private class ClientData
	{
		public Adapter adapter;

		public BTL_PARTY party;

		public ClientSendData.RAID_BALL_SELECT sendData_RaidBallSelect;
	}

	private enum seq_POKECHANGE_AFTERFIRSTPOKEIN_RECORDSeq
	{
		SEQ_Record,
		SEQ_Record_Wait,
		SEQ_ClientLimitTimeReq,
		SEQ_ClientLimitTimeReq_Wait,
		SEQ_ClientLimitTimeSync,
		SEQ_ClientLimitTimeSync_Wait,
		SEQ_End
	}

	private enum seq_ACTION_SELECT_RECORDSeq
	{
		SEQ_Record,
		SEQ_Record_Wait,
		SEQ_ClientLimitTimeReq,
		SEQ_ClientLimitTimeReq_Wait,
		SEQ_ClientLimitTimeSync,
		SEQ_ClientLimitTimeSync_Wait,
		SEQ_End
	}

	private enum seq_COVER_SELECT_RECORDSeq
	{
		SEQ_Record,
		SEQ_Record_Wait,
		SEQ_ClientLimitTimeReq,
		SEQ_ClientLimitTimeReq_Wait,
		SEQ_ClientLimitTimeSync,
		SEQ_ClientLimitTimeSync_Wait,
		SEQ_End
	}

	private enum seq_INTERRUPT_POKECHANGE_RECORDSeq
	{
		SEQ_Record,
		SEQ_Record_Wait,
		SEQ_ClientLimitTimeReq,
		SEQ_ClientLimitTimeReq_Wait,
		SEQ_ClientLimitTimeSync,
		SEQ_ClientLimitTimeSync_Wait,
		SEQ_End
	}

	private ServerSequence m_currentSeq;

	private int m_seqStep;

	private MainModule m_pMainModule;

	private BattleEnv m_pBattleEnv;

	private SendDataContainer m_pSendDataContainer;

	private ushort m_sendDataSerialNo;

	private ClientData[] m_clientData;

	private rec.SendTool m_recTool;

	private unsafe BTL_RESULT_CONTEXT* m_btlResultContext;

	private SVCL_ACTION m_clientInstruction;

	private ServerRequestGenerator m_serverRequestGenerator;

	private BattleDriver m_battleDriver;

	public BTL_SERVER(MainModule pMainModule, ulong randSeed, BattleEnv pBattleEnv, SendDataContainer pSendDataContainer)
	{
	}

	public void createBattleDriver()
	{
	}

	public void createServerRequestGenerator()
	{
	}

	public void AttachAdapter(BTL_CLIENT_ID clientID, Adapter adapter)
	{
	}

	public void Startup()
	{
	}

	public void StartupAsNewServer()
	{
	}

	public bool IsWaitingClientReply()
	{
		return default(bool);
	}

	public unsafe void CMDCHECK_RestoreActionData(void* recData, uint recDataSize)
	{
	}

	public void CMDCHECK_RestoreClientLimitTime([In] ref ServerSendData.CLIENT_LIMIT_TIME syncData)
	{
	}

	public unsafe bool CMDCHECK_Make(rec.Timing timingCode, void* recvedCmd, uint recvedCmdSize)
	{
		return default(bool);
	}

	public bool MainLoop()
	{
		return default(bool);
	}

	private bool updateSeq()
	{
		return default(bool);
	}

	private void changeSequence(ServerSequence nextSeq)
	{
	}

	private void seq_BATTLE_START_SETUP(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_BATTLE_START_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_BATTLE_START_TIMING(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_BATTLE_START_COMMAND(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_BATTLE_START_RECORD(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_BATTLE_START_SWITCH_AFTER_FIRST_POKEIN(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_POKECHANGE_AFTERFIRSTPOKEIN_POKESELECT(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_POKECHANGE_AFTERFIRSTPOKEIN_RECORD(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_POKECHANGE_AFTERFIRSTPOKEIN_COMMAND(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_POKECHANGE_AFTERFIRSTPOKEIN_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_ACTION_SELECT_START(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_ACTION_SELECT_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_ACTION_SELECT_RECORD(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_ACTION_SELECT_COMMAND(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_ACTION_SELECT_COMMAND_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private bool isPokeCoverEscapeMode()
	{
		return default(bool);
	}

	private void seq_CHANGE_OR_ESCAPE_START(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_CHANGE_OR_ESCAPE_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_CHANGE_OR_ESCAPE_ESCAPE_SELECTED(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_COVER_SELECT_START(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_COVER_COMFIRM_PLAYER_POKECHANGE(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_COVER_SELECT_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_COVER_SELECT_RECORD(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_COVER_COMMAND(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_COVER_COMMAND_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private bool irekae_IsNeedConfirm()
	{
		return default(bool);
	}

	private byte irekae_GetEnemyPutPokeID()
	{
		return default(byte);
	}

	private void seq_INTERRUPT_POKECHANGE_POKESELECT(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_INTERRUPT_POKECHANGE_POKESELECT_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_INTERRUPT_POKECHANGE_RECORD(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_INTERRUPT_POKECHANGE_COMMAND(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_INTERRUPT_POKECHANGE_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_TIMEUP_RECORD(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_TIMEUP_COMMAND(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_RAID_CAPTURE_START(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_RAID_CAPTURE_SELECT_BALL(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void storeClientSendData_RaidBallSelect()
	{
	}

	private void seq_RAID_CAPTURE_RESULT(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void checkRaidBossCaptureResult()
	{
	}

	private void checkRaidBossCaptureResult(ref ServerSendData.RAIDBOSS_CAPTURE_RESULT pResult)
	{
	}

	private void checkRaidBossCaptureResult(ref ServerSendData.RAIDBOSS_CAPTURE_RESULT pResult, BTL_CLIENT_ID clientID)
	{
	}

	private void seq_RAID_EXIT_WIN(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_RAID_EXIT_LOSE(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_COMMON(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_WILD_WIN(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_WILD_LOSE(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_WILD_FORCE(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_WILD_CAPTURE(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_COMM(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_NPC(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_BATTLE_SPOT_TRAINER(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_FADEOUT(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_EXIT_QUIT(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_NEW_STARTUP_SEND_LATEST_REPLY(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void seq_NEW_STARTUP_SWITCH(ref int pSeqStep, ref ServerSequence pNextSeq)
	{
	}

	private void notifyBattleResult()
	{
	}

	private void checkBattleResult(out BtlResult pResult, out ResultCause pJudgeCause)
	{
	}

	private bool checkRaidBattleWin()
	{
		return default(bool);
	}

	private BtlRule getRule()
	{
		return default(BtlRule);
	}

	private void storeClientInstruction()
	{
	}

	private void clearClientInstruction()
	{
	}

	private void storeClientLimitTime()
	{
	}

	private bool isClientLimitTimeOver()
	{
		return default(bool);
	}

	private void sendClientLimitTimeToLiveCupWatchMember()
	{
	}

	private void sendRequest(ServerRequest request)
	{
	}

	private void sendRequestAlone(ServerRequest request, byte clientID)
	{
	}

	private void sendRequestCore(ServerRequest request, byte clientID)
	{
	}

	public unsafe void setSendDataInAllAdapter(ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, void* sendData, uint dataSize)
	{
	}

	public unsafe void setSendDataInSingleAdapter(ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, void* sendData, uint dataSize, byte clientID)
	{
	}

	public unsafe void registerSendData(ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, void* data, uint dataSize)
	{
	}

	private bool waitAllAdapterReply()
	{
		return default(bool);
	}

	private void resetAdapterCmd()
	{
	}

	private void initAllAdapter()
	{
	}

	private void clearClientData()
	{
	}

	private void setupClientData(BTL_CLIENT_ID clientID, Adapter adapter, BTL_PARTY party)
	{
	}

	private Adapter getClientAdapter(BTL_CLIENT_ID clientID)
	{
		return null;
	}

	private bool isClientExist(BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}
}
