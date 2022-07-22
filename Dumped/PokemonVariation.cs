using System;
using UnityEngine;

public class PokemonVariation : MonoBehaviour
{
	public enum PokeType
	{
		NORMAL,
		SHINYCOLOR,
		TEST
	}

	[Serializable]
	public class VisibilityParam
	{
		public GameObject[] boneVisibilitys;

		public string variation;
	}

	[Serializable]
	public class MaterialArray
	{
		public Material[] materials;

		public MaterialArray(int num)
		{
		}
	}

	[Serializable]
	public class MaterialVariation
	{
		public MaterialArray[] materialArrays;

		public Material[] materials_default;

		public Material[] materials_rare;

		public Material[] GetMaterials(PokeType pt)
		{
			return null;
		}
	}

	[Serializable]
	public class MaterialParam
	{
		public string variation;

		public MaterialVariation materialVariation;

		public MaterialParam()
		{
		}

		public MaterialParam(MaterialParam source)
		{
		}
	}

	[Serializable]
	public class RendererMaterial
	{
		public Renderer renderer;

		public Material[] materials;

		public int[] materialIndexs;
	}

	[SerializeField]
	private PokeType pokeType;

	public string[] variations;

	public string variation;

	public VisibilityParam[] mVisibilitys;

	[HideInInspector]
	public RendererMaterial[] rendererMaterials;

	[SerializeField]
	private Material[] mBaseMaterials;

	public MaterialParam[] mMaterialParams;

	public float[] mVariationScale;

	public bool debugKey;

	public PokeType Type
	{
		get
		{
			return default(PokeType);
		}
		set
		{
		}
	}

	public float ScaleVariation => default(float);

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateVariation()
	{
	}

	public void ChangeVariation(string newVri)
	{
	}

	public void ChangePrevVariation()
	{
	}

	public void ChangeNextVariation()
	{
	}

	public void ChangeType(PokeType type)
	{
	}
}
