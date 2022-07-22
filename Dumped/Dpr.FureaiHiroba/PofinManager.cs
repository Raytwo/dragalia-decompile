using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using DG.Tweening;
using Dpr.Item;
using Dpr.UI;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.FureaiHiroba;

public class PofinManager : SequenceMonoBehaviour
{
	[SerializeField]
	private Transform PofinMachineParent;

	private Transform PofinKiji;

	[SerializeField]
	private Text DebugText;

	[SerializeField]
	private List<Transform> PosList;

	[SerializeField]
	private Camera cam;

	[SerializeField]
	private Transform CamPos01;

	[SerializeField]
	private Transform CamPos02;

	private UIPofinResult uiPofinResult;

	private UIPofinPlaying PofinUI;

	private PofinPlayingPokeManager pokeManager;

	private List<ItemInfo> kinomiList;

	[SerializeField]
	private float PofinHeightMin;

	[SerializeField]
	private float PofinHeightMax;

	[SerializeField]
	private float PofinScaleMin;

	[SerializeField]
	private float PofinScaleMax;

	private float BlendValue;

	private Material pofinMat;

	private Material LEDMat;

	private Color nowLEDColor;

	private AudioInstance kakimazeSE;

	private static readonly Color[] LEDColors;

	[SerializeField]
	private PofinGameCalc calc;

	public Action OnEndPofinPlaying;

	private bool isEnableUpdate;

	[SerializeField]
	private float duration;

	[SerializeField]
	private Ease ease;

	private PofinEffectManager effectMng;

	private float KakimazeSE_Interval;

	public float DebugTime;

	private bool isSEPlaying;

	public int Button03;

	public int Button04;

	public int Button05;

	public IEnumerator Start()
	{
		return null;
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	private void _UpdateDebugText()
	{
	}

	private void BatterUpdate(float deltaTime)
	{
	}

	private void LED_Update(float deltaTime)
	{
	}

	private void EndCooking()
	{
	}

	public void SetKinomi(List<ItemInfo> kinomiList)
	{
	}

	public Tweener CameraMove()
	{
		return null;
	}

	public void CameraReset()
	{
	}

	private void GotoPofinResult(PofinCookModel model)
	{
	}

	private void EndPofinResult()
	{
	}

	public void SetFureaiPoke(List<FureaiPokeModel> fureaiPokes)
	{
	}

	public void DebugCreatePofin()
	{
	}

	public static ItemInfo[] GetRandomKinomis(int num)
	{
		return null;
	}
}
