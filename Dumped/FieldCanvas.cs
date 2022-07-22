using System.Runtime.InteropServices;
using Dpr.Demo;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class FieldCanvas : MonoBehaviour
{
	private static FieldCanvas _instance;

	public static bool useLateUpdate;

	private const int BALLOON_MAX = 20;

	public Image BalloonImage;

	public Vector3 BalloonOffset;

	private Balloon[] _balloonArray;

	public GameObject controller;

	public GameObject left;

	public GameObject right;

	[SerializeField]
	private SpriteAtlas BalloonIconsAtlas;

	[SerializeField]
	private Sprite ugHoleSprite;

	private Canvas canvas;

	private AreaNameWindow areaNameWindow;

	private DisplayMessage displayMessage;

	private FieldFader fieldFader;

	public int Button;

	public float BaseFov;

	public float BaseDistance;

	private static DemoSceneManager demoMng;

	public static bool isNPCTrading;

	public static bool isNPCTradeEnd;

	public int Button01;

	public int Button02;

	public int Button05;

	public static Sprite UgHoleSprite => null;

	public void Warp()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateProc(float deltaTime)
	{
	}

	private void MyUpdate(float deltaTime)
	{
	}

	private void MyLateUpdate(float deltaTime)
	{
	}

	private void UpdateBalloonPos(Balloon bln)
	{
	}

	public static Balloon SetBalloon(int type, Transform target)
	{
		return null;
	}

	public static void DeleteBalloon([Optional] Balloon balloon)
	{
	}

	public static void ShowHostIcon(Balloon balloon)
	{
	}

	public static void StopHostEmoticon(Balloon balloon)
	{
	}

	private Balloon _setBalloon(int type, Transform target)
	{
		return null;
	}

	private void _deleteBalloon([Optional] Balloon balloon)
	{
	}

	private void _showHostIcon(Balloon balloon)
	{
	}

	private void _backEmotiocnNormal(Balloon balloon)
	{
	}

	public static void OpenAreaNameWindow(string labelName)
	{
	}

	public static void ResetAreaNameWindow()
	{
	}

	public static void ImmidiateCloseAreaNameWindow()
	{
	}

	public static void ShowDisplayMessage(string labelName, string msbtName = "", bool bIsUseTag = false)
	{
	}

	public static void CloseDisplayMessage()
	{
	}

	public static void RedGyaradosMessage(bool flag)
	{
	}

	public static void Debug_ShowDisplayMessage(string message)
	{
	}

	public static void PlayDemoOrStock(DemoBase demo)
	{
	}

	public static void PlayDemo(DemoBase demo)
	{
	}

	public static void PlayDemo()
	{
	}

	public static Coroutine LoadDemo(DemoBase demo)
	{
		return null;
	}

	public static void UgSetUp(bool isUgEnter)
	{
	}

	public static void CanvasEnable(bool isEnable)
	{
	}

	public void TestCreateTurearuki()
	{
	}

	public void TestDeleteTurearuki()
	{
	}

	public void Bikkuri()
	{
	}

	public static bool IsFieldFadeBusy()
	{
		return default(bool);
	}

	public static void FadeOut(FieldFader.FieldFadeType type = FieldFader.FieldFadeType.NONE, float time = 0.5f)
	{
	}

	public static void FadeIn(FieldFader.FieldFadeType type = FieldFader.FieldFadeType.NONE, float time = 0.5f)
	{
	}
}
