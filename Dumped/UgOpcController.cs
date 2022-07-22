using System;
using Dpr;
using Dpr.NetworkUtils;

public class UgOpcController : OpcController
{
	private FieldObjectMove _fieldObjectMove;

	public Action OnStartFinished;

	private bool isSwim;

	private void Awake()
	{
	}

	protected override void Start()
	{
	}

	public override void SetNetData(INetData netData)
	{
	}

	private void StateChange(INetData netData)
	{
	}

	public override void SetOpcOnlineState(OpcState.OnlineState state)
	{
	}

	private void DoNaminori(INetData netData)
	{
	}

	public void SetNaminoriState(bool isSwim)
	{
	}

	protected override void MyUpdate(float deltaTime)
	{
	}

	protected override void OnDestroy()
	{
	}
}
