using System.Collections;
using DG.Tweening;
using Pml;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Demo;

public class Demo_Gosanke : DemoBase
{
	private Animator BagAnimator;

	private RectTransform CursolParent;

	private Image CursolImage;

	private PokeRenderViewer PokemonViewer;

	private Transform RenderCamera;

	private Vector2[] CursolPositions;

	private Image Blur;

	private bool isSelectEnd;

	private int[] CatalogIDs;

	private static readonly MonsNo[] monsNos;

	private static readonly int _pokeLightColorID;

	private static readonly int _pokeReflectionColorID;

	private bool isEnd;

	private int nowCursolPosIndex;

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

	public override void PostProcessSetting()
	{
	}

	public override IEnumerator Main()
	{
		return null;
	}

	public override IEnumerator Exit()
	{
		return null;
	}

	public override void LightUpdate()
	{
	}

	private IEnumerator BagAnimation()
	{
		return null;
	}

	private IEnumerator SelectPoke()
	{
		return null;
	}

	private IEnumerator PokeConfirm(int pokeNo)
	{
		return null;
	}

	private void UpdateCursolPos()
	{
	}

	private void ShowCursol(bool isVisible)
	{
	}

	private void UpdateBallAnimation()
	{
	}

	private Tweener ShowPokeView(int cursolIndex)
	{
		return null;
	}

	private Tweener HidePokeView()
	{
		return null;
	}

	public override void _DebugMethod(int TestNo)
	{
	}
}
