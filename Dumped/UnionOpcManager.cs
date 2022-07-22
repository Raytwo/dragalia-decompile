using Dpr.NetworkUtils;
using Dpr.UI;
using UnityEngine;

public class UnionOpcManager : OpcManager
{
	private const string INVALID_ASSET_NAME = "fc2003_00";

	private const string UNION_SESSION_START_MESSAGE_FILE_NAME = "dlp_net_union_room";

	private Vector2 CONTEXT_MENU_POSITION;

	private static readonly string[] UNION_START_MASSEAGES;

	public override void CreateCharacter(INetData joinData)
	{
	}

	private (bool, string) OnInputCheck(string resultText, SoftwareKeyboard.ErrorState errorState)
	{
		return default((bool, string));
	}

	public void SetIsMatchWait(bool isMatchWait, int stationIndex)
	{
	}
}
