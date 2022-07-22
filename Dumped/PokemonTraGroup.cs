using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class PokemonTraGroup : MonoBehaviour
{
	[Serializable]
	public class TraGrope
	{
		public MaterialUsing[] materialUsings;

		public int[] prioritys;

		public GameObject node;
	}

	[SerializeField]
	private int baseRenderQueue;

	[SerializeField]
	private TraGrope[] traGropes;

	[SerializeField]
	private bool needSort;

	private SkinnedMeshRenderer[] _skinnedMeshRenderers;

	public TraGrope[] GetGropes()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public int SetBaseRenderQueue(int value, [Optional] Camera camera)
	{
		return default(int);
	}

	private void Start()
	{
	}
}
