using System.Runtime.InteropServices;
using Audio;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

namespace Dpr.UI;

public class PokemonModelView : ModelViewBase
{
	public class Param
	{
		public UIModelViewController.ModelViewType type;

		public PokemonParam pokemonParam;

		public float offsetX;

		public Canvas canvas;
	}

	[SerializeField]
	private Transform _transModel;

	[SerializeField]
	private float _fov;

	[SerializeField]
	private float _reflectionAlpha;

	[SerializeField]
	private float _rotateSpeed;

	private Param _param;

	private AudioInstance _voiceInstance;

	private UIDatabase.SheetPokemonVoice _voiceData;

	private Vector2 _rotationLimitX;

	private int _animationIdle;

	private int _animActionIndex;

	public int animActionIndex => default(int);

	protected override void OnEnable()
	{
	}

	public void Setup(Param param, [Optional] UnityAction<PokemonParam> onSetup)
	{
	}

	public bool IsEnableAction()
	{
		return default(bool);
	}

	public bool OnUpdate(float deltaTime, UIInputController input, int playAnimButtonMask = 48, int rotYPlusButtonMask = 0, int rotYMinusButtonMask = 0, int rotXPlusButtonMask = 0, int rotXMinusButtonMask = 0)
	{
		return default(bool);
	}

	private void AddRotationX(float speed)
	{
	}

	public void PlayAnimation(bool looped = false)
	{
	}

	public bool IsPlayAnimation()
	{
		return default(bool);
	}

	public void Pause(bool paused)
	{
	}

	public void Loop(bool looped)
	{
	}

	public void PlayVoice()
	{
	}

	protected override void UpdateAnimation(float deltaTime)
	{
	}
}
