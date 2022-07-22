using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppDowsing : PoketchAppBase
{
	private enum PoketchAppDowsingState
	{
		None,
		OnSonar,
		SonarFindItem,
		SonarFindItemSomewhere,
		End
	}

	[SerializeField]
	private RectTransform _sonarCanvas;

	[SerializeField]
	private RectTransform _sonarRoot;

	[SerializeField]
	private RectTransform _circleInner;

	[SerializeField]
	private RectTransform _circleOuter;

	[SerializeField]
	private Image _circleInnerImage;

	[SerializeField]
	private Image _circleOuterImage;

	[SerializeField]
	private Image[] _itemImages;

	[SerializeField]
	private float _sonarWaitTime;

	[SerializeField]
	private float _sonarTime;

	[SerializeField]
	private float _sonarSize;

	[SerializeField]
	private float _sonarThicness;

	private PoketchAppDowsingState _state;

	private float _sonarTimeCount;

	private Vector2 _windowMin;

	private Vector2 _windowMax;

	private FieldPoketch.DowsingResult _result;

	private List<Image> _findItemImageList;

	private const float CenterOffsetRateY = 0.06999999f;

	private Vector2Int _playerPosition;

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

	private void StartDowsing()
	{
	}

	private void UpdateDowsing(float deltaTime)
	{
	}

	private void SetSonarAlpha(float alpha)
	{
	}
}
