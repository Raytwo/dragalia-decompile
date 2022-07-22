using System.Collections.Generic;
using UnityEngine;

public class DemoPokeHeightAutoAdjuster : MonoBehaviour
{
	private FieldPokemonEntity pokeEntity;

	private List<float> heightList;

	public Transform Head;

	public Vector3 defaultPos;

	public float heightLimit;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Update()
	{
	}
}
