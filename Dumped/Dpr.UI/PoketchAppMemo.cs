using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppMemo : PoketchAppBase
{
	private enum PoketchAppMemoState
	{
		None,
		Write,
		Erace
	}

	[SerializeField]
	private Image _canvasImage;

	[SerializeField]
	private Sprite[] _cursorIconSprites;

	[SerializeField]
	private Image[] _unselectedImages;

	[SerializeField]
	private int _texturePixelWidth;

	[SerializeField]
	private int _texturePixelHeight;

	[SerializeField]
	private Color _pencolor;

	private PoketchAppMemoState _state;

	private Image _cursorImage;

	private Texture2D _canvasTexture;

	private Color[] _canvasColorBuffer;

	private int _pxWriteThickness;

	private int _pxEraceThickness;

	private int _lastPosPixelX;

	private int _lastPosPixelY;

	private float _displayMargin;

	private bool _isTouchOld;

	private const float DefaultButtonHeight = 220f;

	private const float PressButtonHeight = 208f;

	private Vector2 IconSize;

	private Vector2 IconOffset;

	private Vector2 _defaultIconSize;

	private Vector2 _defaultIconOffset;

	private bool _isCloseOnce;

	protected override void OnInitialize()
	{
	}

	protected override void OnUninitialize()
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

	private void SetState(PoketchAppMemoState state, bool isSetCursor = true)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetCursor(PoketchAppMemoState state)
	{
	}

	private void DrawCanvasTexture(Color color, int pxX, int pxY, int pxThickness, bool interp)
	{
	}

	private void SetPixelColor(Color color, int pxX, int pxY, int pxThickness)
	{
	}
}
