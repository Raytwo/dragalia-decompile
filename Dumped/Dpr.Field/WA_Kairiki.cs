using Pml;
using UnityEngine;

namespace Dpr.Field;

public class WA_Kairiki
{
	private static WA_Kairiki instance;

	private const MonsNo monsNo = MonsNo.BIIDARU;

	private const uint voiceEventId = 284194096u;

	private bool isVoiceEnd;

	private int seqNo;

	public static bool Action(float deltatime)
	{
		return default(bool);
	}

	public static bool PushEntity(FieldPlayerEntity player, DIR dir, FieldObjectEntity target, out Vector2Int outgrid, out bool hit)
	{
		return default(bool);
	}
}
