using System.Collections.Generic;
using UnityEngine;

public class CameraSortTragroups : MonoBehaviour
{
	private Camera _camera;

	private static List<(PokemonTraGroup, Transform)> _traGroupAndTransforms;

	private void Awake()
	{
	}

	public static void Register(PokemonTraGroup traGroup)
	{
	}

	public static void Unregister(PokemonTraGroup traGroup)
	{
	}

	private void OnPreCull()
	{
	}
}
