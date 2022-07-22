using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.FureaiHiroba;

public sealed class FureaiManager : SingletonMonoBehaviour<FureaiManager>
{
	public bool isUpdateStop;

	public int TalkPokeIndex;

	public int TalkItemNo;

	public int TalkSealNo;

	public bool isCreatingPoke;

	public bool isSyuugouPoke;

	public bool isKaisanPoke;

	public bool isEntering;

	public bool isInHiroba;

	public Action<uint> _EnterHirobaCreate;

	public Action _EnterHirobaKaisan;

	public Action _ExitHirobaSyuugou;

	private int Debug_EffectRemoveNum;

	public FureaiDataManager fureaiDataManager;

	[SerializeField]
	private PokeWalkManager pokeWalkMng;

	[SerializeField]
	private FureaiHiroba_PokeFactory pokeFactory;

	private List<FureaiPokeModel> fureaiPokeModels;

	private IEnumerator AddPokeCor;

	[SerializeField]
	private int MaxPitch;

	[SerializeField]
	private int MinPitch;

	[SerializeField]
	private int MaxFov;

	[SerializeField]
	private int MinFov;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float fov;

	[SerializeField]
	private float far;

	private Tweener Tw_CamPitch;

	private Tweener Tw_CamFov;

	public static List<int> MemoryDebugList;

	private bool isAlreadyKutibue;

	public int AnimID;

	private static readonly Vector2Int[] EnterPosArrayLeft;

	private static readonly Vector2Int[] EnterPosArrayRight;

	public static readonly int[] HappyAnimID;

	private static readonly EffectFieldID[] effectFieldIDs;

	private int effIndex;

	private FureaiPokeModel firstMod;

	public int Button05;

	public int Button03;

	public int Button01;

	public int Button011;

	public int button00;

	public int Button001;

	public int button99;

	public int button01;

	public int button02;

	public int button03;

	public int button04;

	public int button05;

	public int button06;

	public int button07;

	public int button08;

	public int button09;

	public int button10;

	public int button11;

	public int button12;

	public int button13;

	public int button14;

	public int button15;

	public int button16;

	public int button17;

	public int button18;

	public int button19;

	public int button20;

	public int button21;

	public int button22;

	public int button23;

	public int button24;

	public int button25;

	public int button26;

	public int button27;

	public int button28;

	public bool isCanCreatePoke => default(bool);

	public bool isCanSyuugou => default(bool);

	public bool isCanKaisan => default(bool);

	private bool isOn_PulsOrMinus => default(bool);

	private bool isRelease_PulsOrMinus => default(bool);

	private IEnumerator Start()
	{
		return null;
	}

	public void SetDataManager(FureaiDataManager dataManager)
	{
	}

	public bool IsEnterble(int monsNo)
	{
		return default(bool);
	}

	private void MyUpdate(float deltaTime)
	{
	}

	private bool CheckLongPush(float duration)
	{
		return default(bool);
	}

	private bool KutibueInput()
	{
		return default(bool);
	}

	private void Kutibue_Yobiyose()
	{
	}

	private void Kutibue_Kaisan()
	{
	}

	private Tweener ToCameraDefault(float duration = 0.5f)
	{
		return null;
	}

	private void MyLateUpdate(float deltaTime)
	{
	}

	public void WalkCountClear(int TemotiNo)
	{
	}

	public FieldObjectEntity GetPokeEntityByTemotiNo(int temotiNo)
	{
		return null;
	}

	public void DelPoke(FureaiPokeModel model)
	{
	}

	public void Destroy()
	{
	}

	private void FureaiEnterPokeCreate(uint SelectTemotiNo)
	{
	}

	private IEnumerator CreatePokeForFureaiEnter(uint SelectPoke_TemotiNo)
	{
		return null;
	}

	public void HirobaEnterKaisan()
	{
	}

	public void HirobaExitSyuugou()
	{
	}

	private IEnumerator DoEndofFrame(Action act)
	{
		return null;
	}

	private IEnumerator RouteCheck(List<FureaiPokeModel> list)
	{
		return null;
	}

	private void AddFirstPoke()
	{
	}

	public void SetSelectWalkingPoke(uint temotiNo)
	{
	}

	public int GetSelectWalkingPokeTemotiNo()
	{
		return default(int);
	}

	public void SelectPokeHide()
	{
	}

	public void SelectPokeGotoPlayerNear()
	{
	}

	public void TalkStart(int temoti)
	{
	}

	private IEnumerator WaitEventEnd(FureaiPokeModel poke)
	{
		return null;
	}

	public void PlayVoice_TemotiID(uint temoti)
	{
	}

	public List<FureaiPokeModel> GetWalkingPokes()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void DebugSE()
	{
	}

	public void AddPokeWalkDebug()
	{
	}

	public void DebugAddPoke(bool CreatePlayerPosition = false)
	{
	}

	public void DelPoke()
	{
	}

	public void SubPoke()
	{
	}

	private void Debug_EnterPokeCreate()
	{
	}

	public void _DebugGetNearEmptyPosition()
	{
	}

	public void DebugStopTime()
	{
	}

	public void DebugCreatePoke()
	{
	}
}
