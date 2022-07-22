using System.Collections;
using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Demo;

public class DemoSceneManager : MonoBehaviour
{
	public enum DEBUG_DEMO
	{
		_None,
		Eat_Poffin,
		Evolve,
		Hatch,
		Hakase,
		Gosanke,
		Trade,
		MysteryGift,
		HallOfFame,
		PokeViewer,
		ModelViewer,
		TeleScope
	}

	public bool isAutoDestroy;

	public static bool isExist;

	public List<DemoBase> DemoStock;

	public EnvironmentController MyEnvironmentController;

	public EnvironmentController PrevEnviroment;

	public GameObject DemoSceneAsset;

	public GameObject PrevDemoSceneAsset;

	public Canvas UICanvas;

	public RawImage RenderImage;

	public Image Fade;

	private int PrevScreenWidth;

	private DemoBase Demo;

	[SerializeField]
	private DEBUG_DEMO _debug_demo;

	public List<GameObject> DebugAsset;

	public int Button01;

	public int Button03;

	public int TestNo;

	public int Button05;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void MyUpdate(float deltaTime)
	{
	}

	public IEnumerator OpLoadAndPlay(DemoBase demo)
	{
		return null;
	}

	public IEnumerator OpPlay()
	{
		return null;
	}

	public IEnumerator OpLoad(DemoBase demo)
	{
		return null;
	}

	private void ManagerInit(DemoBase demo)
	{
	}

	public static IEnumerator AssetBundleLoad(string path, RequestEventCallback callback)
	{
		return null;
	}

	private Coroutine Play()
	{
		return null;
	}

	private IEnumerator PlayCor()
	{
		return null;
	}

	private IEnumerator SceneStart()
	{
		return null;
	}

	private IEnumerator SceneEnd()
	{
		return null;
	}

	private void CommonInit()
	{
	}

	public void SetFadeEnter(float duration)
	{
	}

	public void SetFadeExit(float duration)
	{
	}

	public WaitForSeconds FadeEnter(float duration)
	{
		return null;
	}

	public WaitForSeconds FadeExit(float duration)
	{
		return null;
	}

	public void AddLightLayer(string layerName)
	{
	}

	public void PlayDebug()
	{
	}

	public void Pofin()
	{
	}

	public void _Test()
	{
	}
}
