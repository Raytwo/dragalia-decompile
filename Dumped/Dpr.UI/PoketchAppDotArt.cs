using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppDotArt : PoketchAppBase
{
	[SerializeField]
	private Image _canvasImage;

	[SerializeField]
	private Vector2 _dotSize;

	[SerializeField]
	private Color[] _fillColors;

	private Sprite _lastSettingSprite;

	private Texture2D _canvasTexture;

	private Color[] _canvasColorBuffer;

	private int[] _canvasColorIndexBuffer;

	private const int TEXTURE_PIXEL_WIDTH = 32;

	private const int TEXTURE_PIXEL_HEIGHT = 24;

	private int _lastPosPixelX;

	private int _lastPosPixelY;

	private float _displayMargin;

	private bool _isTouchOld;

	private bool _isModified;

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

	private void OnFillDot(int line, int colmun)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void DrawCanvasTexture(int pxX, int pxY, bool interp)
	{
	}

	private void SetPixelColor(int pxX, int pxY, int addColorIndex)
	{
	}

	private void ClearColorIndexBuffer()
	{
	}

	private void InitializeColorIndexBuffer()
	{
	}

	private void LoadColorIndexBuffer()
	{
	}

	private void SaveColorIndexBuffer()
	{
	}
}
