using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Dpr.MsgWindow;
using Pml;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.Demo;

[Serializable]
public abstract class DemoBase
{
	protected enum BGType
	{
		PoffinEat,
		HakaseRed,
		HakaseBlue,
		Evolve,
		Gosanke
	}

	public DemoCamera cameraController;

	public DemoSceneManager manager;

	public Transform parent;

	protected List<Tweener> Tws;

	public Action OnEndDemo;

	public IEnumerator OnPreEndDemo;

	public bool UseCamera;

	public bool DisableEnvironmentController;

	public bool isUseAlpha;

	public bool isDisableEndLightSet;

	public bool isDisablePostProcess;

	public bool isDisableMainCamera;

	public int AddSortOrder;

	protected List<MsgWindowParam> Messages;

	protected Dpr.MsgWindow.MsgWindow _messageWindow;

	protected int nowMessageNo;

	public string AssetBundlePath;

	protected const string POKE_VIEW_PREFAB_PATH = "demo/pokemonview";

	protected const string RENDERCAMERA_PREFAB_PATH = "demo/demorendercamera";

	protected List<Coroutine> coroutines;

	protected Dictionary<int, UnityEngine.Object> PokeAssets;

	protected UnityEngine.Object PokeAsset;

	protected UnityEngine.Object BG;

	protected bool is2DBG;

	protected BGType bgType;

	protected static readonly string[] BGPaths;

	public bool UseStartEnterFade;

	public bool UseStartExitFade;

	public bool UseEndEnterFade;

	public bool UseEndExitFade;

	public float StartEnterFadeDuration;

	public float StartExitFadeDuration;

	public float EndEnterFadeDuration;

	public float EndExitFadeDuration;

	public Color FadeColor;

	protected Camera cam => null;

	protected bool PushA => default(bool);

	protected bool PushB => default(bool);

	protected bool PushX => default(bool);

	protected bool PushY => default(bool);

	protected bool PushAorB => default(bool);

	protected bool KeyLeft => default(bool);

	protected bool KeyRight => default(bool);

	protected bool KeyDown => default(bool);

	protected bool KeyUp => default(bool);

	protected bool isMessageFinished => default(bool);

	protected MsgWindowParam nowMSG => null;

	protected bool isEnableInput => default(bool);

	public Color ClearColor => default(Color);

	public virtual AssetRequestOperation PreloadAssetBundles()
	{
		return null;
	}

	public virtual void ReleasePreloadedAssetBundles()
	{
	}

	public string GetPokemonAssetBundle(MonsNo monsNo, ushort formNo, Sex sex, bool isRare, bool isBattleModel = false)
	{
		return null;
	}

	public virtual void Init()
	{
	}

	public virtual IEnumerator Enter()
	{
		return null;
	}

	public virtual IEnumerator Main()
	{
		return null;
	}

	public virtual IEnumerator Exit()
	{
		return null;
	}

	public virtual void Destroy()
	{
	}

	public virtual void PostProcessSetting()
	{
	}

	public virtual void _DebugMethod(int TestNo)
	{
	}

	public virtual void LightUpdate()
	{
	}

	protected IEnumerator WaitMessageWindow(bool isCloseWindow = true, float autoCloseTime = 0f)
	{
		return null;
	}

	protected MsgWindowParam DrawNextMessage()
	{
		return null;
	}

	protected MsgWindowParam DrawMessage(int NextMessageNo)
	{
		return null;
	}

	protected void CloseWindow()
	{
	}

	protected MsgWindowParam CreateMsgWindowParam(string msgFileName, string labelName, bool isCloseMessage = true)
	{
		return null;
	}

	protected IEnumerator LoadBackGround([Optional] Action<GameObject> OnLoad)
	{
		return null;
	}

	public IEnumerator LoadPokeAsset(PokemonParam param, bool isHideRare = false, bool isBattleModel = false)
	{
		return null;
	}

	public IEnumerator LoadPokeAsset(MonsNo monsNo, ushort formNo, Sex sex, bool isRare, bool isEgg = false, bool isBattleModel = false)
	{
		return null;
	}

	public void FadeSetting(bool fade1, bool fade2, bool fade3, bool fade4)
	{
	}

	public void SetFadeTime(float t1, float t2, float t3, float t4)
	{
	}

	public Tweener RenderImageFade(float alpha, float duration)
	{
		return null;
	}

	public Tweener RenderImageScale(float scale, float duration)
	{
		return null;
	}
}
