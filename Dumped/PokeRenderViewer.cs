using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PokeRenderViewer : MonoBehaviour
{
	private RectTransform rectTra;

	private List<Tweener> Tws;

	public FieldPokemonEntity entity;

	private Coroutine PokeAnimationUpdateCor;

	private Transform PositionTra;

	private Transform Waist;

	public int AnimationID;

	private RenderTexture tex;

	[SerializeField]
	private Sprite[] CircleImages;

	public Image CircleUI;

	public RawImage PokeImage;

	private static readonly Color ClearColor;

	public int Button01;

	private void Awake()
	{
	}

	public Tweener ShowPokeView(Object PokeAsset, Vector2 posFrom, Vector2 posTo, Transform RenderCamera, Vector2 size, bool isNoMotion = false)
	{
		return null;
	}

	public void StopMotion()
	{
	}

	public void OpenWindow(Vector2 posFrom, Vector2 posTo, Vector2 Size)
	{
	}

	public Tweener HidePokeView()
	{
		return null;
	}

	private IEnumerator PokeAnimationUpdate()
	{
		return null;
	}

	public void SetScalePoke3D(Vector3 scale)
	{
	}

	public void SetPositionPoke3D(Vector3 pos)
	{
	}

	public void ChangeCircleImage(int index)
	{
	}

	private void OnDestroy()
	{
	}
}
