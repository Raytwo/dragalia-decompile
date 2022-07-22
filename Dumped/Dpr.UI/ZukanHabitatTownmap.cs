using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class ZukanHabitatTownmap : Townmap
{
	[SerializeField]
	private RectTransform[] _habitatRoots;

	[SerializeField]
	private Image _habitatItem;

	[SerializeField]
	private RectTransform _notFound;

	private SheetDistributionTable.HabitatType _type;

	private bool[] _notfounds;

	private bool _isNotfound;

	public SheetDistributionTable.HabitatType habitatType => default(SheetDistributionTable.HabitatType);

	public bool isNotfound => default(bool);

	public void Setup(PokemonParam pokemonParam, SheetDistributionTable.TimeZoneType timeZone, UnityAction<Cell, bool> onCellChanged)
	{
	}

	private void SetupSpecial(List<Vector2Int> grids, SheetDistributionTable distData, SheetDistributionTable.HabitatType habitatType, SheetDistributionTable.SpecialType type)
	{
	}

	private void SetupNormal(List<Vector2Int> grids, SheetDistributionTable distData, SheetDistributionTable.HabitatType type, SheetDistributionTable.TimeZoneType timeZone)
	{
	}

	private void SetupHabitat(List<Vector2Int> grids, SheetDistributionTable distData, SheetDistributionTable.HabitatType type, SheetDistributionTable.TimeZoneType timeZone)
	{
	}

	private UIDatabase.SheetDistributionMapchip GetMapchipData(Vector2Int grid, SheetDistributionTable.HabitatType type, SheetDistributionTable.TimeZoneType timeZone)
	{
		return null;
	}

	public void ShowHabitat(SheetDistributionTable.HabitatType type, SheetDistributionTable.TimeZoneType timeZone)
	{
	}

	protected override bool UpdateMove(float deltaTime, UIInputController input)
	{
		return default(bool);
	}
}
