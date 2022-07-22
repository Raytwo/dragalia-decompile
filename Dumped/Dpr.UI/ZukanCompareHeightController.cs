using Dpr.Playables;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class ZukanCompareHeightController : MonoBehaviour
{
	private enum State
	{
		None,
		BeforeLoad,
		StartLoad,
		LoadPlayer,
		LoadPlayerEnd,
		LoadPokemon,
		LoadWait,
		Show
	}

	private static readonly int AnimatorStateInitialize;

	private static readonly int AnimatorStateWait;

	private static readonly int AnimatorParamTransId;

	private const string AnimatorTransLayerName = "Trans";

	private const int TransIdIn = 1;

	private const int TransIdOut = 2;

	[SerializeField]
	private PokemonModelView pokemonModelView;

	private ushort playerHeight;

	private PokemonParam currentPokemonParam;

	private State currentState;

	private UIModelViewController.ModelParam playerModelParam;

	private AnimationLayer playerModelAnimationLayer;

	private int playerModelWaitAnimationIndex;

	private bool isDisposed;

	public bool IsLoadEnd => default(bool);

	public void Initialize(ushort playerHeight)
	{
	}

	public void Dispose()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void SetRawImageEnable(bool isEnable)
	{
	}

	public void Setup(ZukanInfo zukanInfo)
	{
	}

	public void RequestLoadModel()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void LoadPlayerModel()
	{
	}

	private void LoadPokemonModel(PokemonParam pokemonParam)
	{
	}

	private UIModelViewController.ModelParam GetLatestModelParam()
	{
		return null;
	}

	private void SetupMaterials(GameObject obj)
	{
	}

	private int GetPlayerWaitAnimationIndex(AnimationLayer animationLayer)
	{
		return default(int);
	}
}
