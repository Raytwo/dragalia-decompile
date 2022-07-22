using System.Collections;
using DG.Tweening;
using Pml;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Demo;

public class Demo_PokeViewer : DemoBase
{
	private PokeRenderViewer PokemonViewer;

	private Transform RenderCamera;

	private MonsNo monsNo;

	private ushort formNo;

	private Sex sex;

	public bool isNoMotion;

	public bool isUseUIRenderSettings;

	private Image bg;

	private IEnumerator ienum;

	private Vector2 CircleSize;

	private Vector2 CirclePos;

	public Demo_PokeViewer(MonsNo monsNo, ushort formNo, Sex sex)
	{
	}

	public override void Destroy()
	{
	}

	public override void Init()
	{
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	private void CameraReset()
	{
	}

	private Tween ExitView()
	{
		return null;
	}

	public override void _DebugMethod(int TestNo)
	{
	}

	public IEnumerator DebugChange()
	{
		return null;
	}

	public override void LightUpdate()
	{
	}
}
