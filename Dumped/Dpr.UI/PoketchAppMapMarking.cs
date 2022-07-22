using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class PoketchAppMapMarking : PoketchAppBase
{
	[SerializeField]
	private RectTransform _playerCursorRoot;

	[SerializeField]
	private Image _playerCursorImage;

	[SerializeField]
	private Image[] _wanderingPokemonImages;

	[SerializeField]
	private ZoneID[] _hideMapIDs;

	[SerializeField]
	private Image[] _hideMapImages;

	[SerializeField]
	private float _blinkSpeed;

	private int _gridSize;

	private Vector2 _grigBasePosition;

	private TownMapTable.SheetData[] _mapDatas;

	private ZoneID[] _pokeZoneIDs;

	private float _blinkCount;

	protected override void OnInitialize()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnUpdateDraw()
	{
	}

	protected override void OnUpdateControl(bool isAppControlEnable = false, [Optional] PoketchButton targetButton, PoketchWindow.TouchState state = PoketchWindow.TouchState.None)
	{
	}

	public override void OnSizeChanged(bool isLarge)
	{
	}

	private void SetMarker(Transform marker, int px, int py)
	{
	}

	private void ResetButtonsState([Optional] PoketchButton targetButton)
	{
	}
}
