using System;
using System.Collections;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class PokemonSelectWindow : PokemonWindowBase
{
	public class Param : BaseParam
	{
		[Flags]
		public enum SelectType
		{
			Default = 1,
			DisableEgg = 2,
			DisableHpZero = 4,
			PofinEat = 0xA
		}

		public SelectType selectType;

		public UnityAction<int> onSelected;
	}

	[SerializeField]
	private PokemonModelView _modelView;

	private Param _param;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnSelectChangedPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void SetupModelView(PokemonParam pokemonParam)
	{
	}

	private void OnClickPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}
}
