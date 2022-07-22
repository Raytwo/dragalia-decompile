using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;
using DG.Tweening;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class PoketchWindow : UIWindow
{
	public enum TouchState
	{
		None,
		Touch,
		Hold,
		Release,
		Push
	}

	private const float _buttonOffsetX = 140f;

	private const float _buttonOffsetY = 260f;

	private const float _changeButtonUnderOffset = 16f;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private RawImage _imageBg;

	[SerializeField]
	private RectTransform _root;

	[SerializeField]
	private RectTransform _rootTopShutter;

	[SerializeField]
	private RectTransform _rootBottomShutter;

	[SerializeField]
	private PoketchButton _changeButton;

	[SerializeField]
	private Image _cursor;

	[SerializeField]
	private RawImage _appBG;

	[SerializeField]
	private Image[] _bodyImages;

	[SerializeField]
	private Sprite[] _bodySprites;

	[SerializeField]
	private Image[] _numImages;

	[SerializeField]
	private Sprite[] _numSprites;

	[SerializeField]
	private List<PoketchAppBase> _poketchAppList;

	[SerializeField]
	private float _resizeDuration;

	[SerializeField]
	private float _changeDuration;

	[SerializeField]
	private float _closeWait;

	[SerializeField]
	private float _changeWait;

	[SerializeField]
	private float _smallScale;

	[SerializeField]
	private float _largeScale;

	[SerializeField]
	private Vector3 _smallPos;

	[SerializeField]
	private Vector3 _largePos;

	[SerializeField]
	private float _toSmallDelay;

	[SerializeField]
	private float _toLargeDelay;

	[SerializeField]
	private Color32 _lightColor;

	[SerializeField]
	private Color32[] _bgColors;

	[SerializeField]
	private float _cursolMoveValue;

	[SerializeField]
	private float _voiceWait;

	private UIInputButton _buttonR;

	private UIInputButton _buttonSR;

	private bool _isSizeChanging;

	private bool _isBackLight;

	private bool _isTouch;

	private bool _isSelecting;

	private PoketchButton _preButton;

	private Coroutine _appChangeCoroutine;

	private float _appCloseTime;

	private DG.Tweening.Sequence _twSeqence;

	private Coroutine _openColoutine;

	private Coroutine _closeColoutine;

	private MonsNo _voiceMonsNo;

	private AudioInstance _voiceInstance;

	private UIDatabase.SheetPokemonVoice _voiceData;

	private float _voiceTimer;

	private float _cursorMinX;

	private float _cursorMaxX;

	private float _cursorMinY;

	private float _cursorMaxY;

	public int AppWidth;

	public int AppHeight;

	private float _cursorX;

	private float _cursorY;

	private TouchState _touchState;

	public int CurrentAppIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsLarge
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

	public bool IsPauseContinue
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsCloseOnce
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public PoketchAppBase CurrentApp => null;

	public bool IsControlPoketch => default(bool);

	public Image Cursor => null;

	public float CursorX => default(float);

	public float CursorY => default(float);

	public float Scale => default(float);

	public static PoketchWindow Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void OnCreate()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void Clean()
	{
	}

	public void Open(UIWindowID prevWindowId)
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close([Optional] UnityAction<UIWindow> onClosed_)
	{
	}

	private IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnInputButton(int button, UIInputButton.State state)
	{
	}

	public void ChangePoketchSize(bool notReleaseUncontrol = false, [Optional] UnityAction callback)
	{
	}

	private bool IsInRange(PoketchButton target, float posX, float posY)
	{
		return default(bool);
	}

	private void SetCursorPosition(float posX, float posY)
	{
	}

	private void OnInputPrev(int button, UIInputButton.State state)
	{
	}

	private void OnInputNext(int button, UIInputButton.State state)
	{
	}

	private void SelectApp(bool isForward)
	{
	}

	private IEnumerator ChangeAppProc(int nextIndex)
	{
		return null;
	}

	private IEnumerator ShutterProc(bool isOpen)
	{
		return null;
	}

	private void ChangeApp(int nextIndex)
	{
	}

	public void SetAppColor(int index)
	{
	}

	public void SetAppBackLight()
	{
	}

	public void SetBackLight(bool isEnable)
	{
	}

	public void PlayPokemonVoice(MonsNo monsNo, int formNo = 0, Sex monsSex = Sex.NUM, RareType rareType = RareType.NOT_RARE)
	{
	}

	public bool IsCursorOnDisplay()
	{
		return default(bool);
	}

	public static void SetNumImage(ulong num, int digit, Image[] numImage, Sprite[] numSprite, int dispIndex = 0)
	{
	}
}
