using System;
using System.Collections.Generic;
using Dpr.NetworkUtils;

public class UgOpcManager : OpcManager
{
	public OpcState.OnlineState MyState;

	private List<int> CreatingOpcList;

	public Action<int> OnCreateOpc;

	public override void SetNetData(INetData netData)
	{
	}

	public override void RemoveCharacter(int stationIndex, bool isGameObjectDestroy = true)
	{
	}

	public override void CreateCharacter(INetData joinData)
	{
	}

	public override void Destroy()
	{
	}
}
