using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.DigFossil;

public class DigAudioManager : MonoBehaviour, IDigAudioManager
{
	public enum SeId
	{
		Beacon,
		KnockHummer,
		KnockPickaxe,
		FoundItem,
		DigOutItem,
		KnockHardStone,
		DigOutAllItems,
		CollapseWall,
		Decide,
		AppearStatue
	}

	private readonly List<string> seNames;

	private readonly List<uint> seIds;

	private readonly Dictionary<SeId, Coroutine> delayBuffer;

	public void Initialize()
	{
	}

	public void PlaySe(SeId id, float delay = 0f)
	{
	}

	public void StopDelaySe(SeId id)
	{
	}

	public void StopDelaySeAll()
	{
	}

	private IEnumerator PlayDelaySe(SeId id, float delay)
	{
		return null;
	}
}
