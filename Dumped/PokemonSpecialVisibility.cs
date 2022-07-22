using System;
using UnityEngine;

public class PokemonSpecialVisibility : MonoBehaviour
{
	[Serializable]
	public class RendererVisibility
	{
		public GameObject[] dispMeshes;
	}

	[SerializeField]
	private RendererVisibility[] rendererVisibilities;

	[SerializeField]
	private int dispNo;

	public int DispNo => default(int);

	public int DispNoNum => default(int);

	public void SetDispNo(int no)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
