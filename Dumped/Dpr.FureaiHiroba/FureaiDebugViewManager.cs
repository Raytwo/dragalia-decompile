using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.FureaiHiroba;

public class FureaiDebugViewManager : SequenceMonoBehaviour
{
	[SerializeField]
	private Font font;

	[SerializeField]
	private PokeWalkManager pokeWalkMng;

	private bool isVisible;

	private List<FureaiDebugView> debugViewList;

	private List<FureaiPokeModel> models => null;

	private void Awake()
	{
	}

	public void AddDebugView(FureaiPokeModel model)
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}
}
