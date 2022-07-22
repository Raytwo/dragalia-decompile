using System;
using System.Runtime.CompilerServices;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class BagWazaSelectPanel : MonoBehaviour
{
	[SerializeField]
	private PokemonStatusWazaItem[] wazaItems;

	[SerializeField]
	protected Cursor _cursor;

	private IndexSelector indexSelector;

	private UIInputController inputController;

	private Action<int> onDecideCallback;

	private Action onCancelCallback;

	public bool IsShow
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Setup(PokemonParam pokemonParam, Action<int> onDecideCallback, Action onCancelCallback)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void OnUpdateSelect(float deltaTime)
	{
	}
}
