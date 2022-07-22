using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

public class FieldPokemonCenterMonitorEntity : FieldEventEntity
{
	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private PokemonIcon[] pokemonIcons;

	[SerializeField]
	private float defaultScale;

	[SerializeField]
	private float animationScale;

	private Image[] pokemonImages;

	private int currentDisplayIndex;

	private float animationTime;

	private float progressTime;

	private bool isPlayingHealAnimation;

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	public void DisplayIcon(int index, int pokemonIndex)
	{
	}

	public void PlayHealAnimation()
	{
	}

	public void DestroyAllIcons()
	{
	}

	private void DestroyIcon(int index)
	{
	}

	private void SetScale(int index, float scale)
	{
	}
}
