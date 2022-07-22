using System.Collections;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class ZukanHabitatWindow : TownmapWindowBase
{
	public class Param
	{
		public PokemonParam pokemonParam;
	}

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private ZukanHabitatTownmap _townmap;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private ZukanTimeZone _timeZone;

	[SerializeField]
	private ZukanHabitatSpecialInfo _specialInfo;

	[SerializeField]
	private ZukanHabitatTypeSelector _typeSelector;

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

	private void OnCellChanged(Townmap.Cell cell, bool isReset)
	{
	}

	private void SetupKeyguide(Townmap.Cell cell)
	{
	}

	protected override bool IsFly(Townmap.Cell cell)
	{
		return default(bool);
	}

	public override void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void EnableCursor()
	{
	}

	private void UpdateCursor()
	{
	}
}
