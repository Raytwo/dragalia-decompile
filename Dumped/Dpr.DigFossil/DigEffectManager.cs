using System.Collections;
using System.Collections.Generic;
using Effect;
using UnityEngine;

namespace Dpr.DigFossil;

public class DigEffectManager : MonoBehaviour
{
	public enum EffectId
	{
		KnockWithHummer,
		KnockWithPickaxe,
		BreakBuildupWithPickaxe,
		KnockHardStone,
		DigOutNormal,
		DigOutRare,
		Crumbling,
		Collapse,
		BreakBuildupWithHummer,
		OpenBox,
		Completed,
		Crack,
		Count
	}

	[SerializeField]
	private Camera targetCamera;

	[SerializeField]
	private Transform pos_cursor;

	[SerializeField]
	private Transform pos_collapse;

	[SerializeField]
	private Transform pos_crumbling;

	[SerializeField]
	private Transform pos_crack_start;

	[SerializeField]
	private Transform pos_crack_end;

	private readonly List<EffectFieldID> effectIds;

	private readonly Dictionary<int, EffectData> effectData;

	private readonly List<EffectInstance> effectInstances;

	private List<int> playedCrumblingEffectPosIndices;

	private Dictionary<int, Transform> cursorPosDic;

	private static float CrackCosTotal;

	private void Start()
	{
	}

	public void AddCursor(int index, Transform cursor)
	{
	}

	public void PlayOneShotToCursor(EffectId id, int cursorNum)
	{
	}

	public void PlayOneShot(EffectId id, Vector3 pos)
	{
	}

	public void PlayToCrumbling(int x, float delay = 0f)
	{
	}

	public EffectInstance PlayToCollapse()
	{
		return null;
	}

	public EffectInstance PlayToAllDigouted()
	{
		return null;
	}

	public EffectInstance PlayToCrack(float t)
	{
		return null;
	}

	public EffectInstance Play(EffectId id, Vector3 pos, bool isNearScreen = true)
	{
		return null;
	}

	public IEnumerator Load()
	{
		return null;
	}

	private IEnumerator PlayWithDelay(EffectId id, Vector3 pos, float delay)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
