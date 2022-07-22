using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Battle.View.UI;

public class BUIResult : BattleViewUICanvasBase
{
	[Serializable]
	private class PokeStatus
	{
	}

	[Serializable]
	private class LevelupInfo
	{
	}

	[SerializeField]
	private List<PokeStatus> _pokeStatusList;

	public void Initialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}
}
