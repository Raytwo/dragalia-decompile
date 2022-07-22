using System;
using System.Collections.Generic;
using UnityEngine;

public class PokemonIDDataInfo : MonoBehaviour
{
	[Serializable]
	public class Pantone
	{
		public string Code;

		public Color RGBColor;

		public Color IDColor;
	}

	[Serializable]
	public class PantoneList
	{
		public List<Pantone> List;

		public PantoneList(List<Pantone> list)
		{
		}
	}

	[SerializeField]
	private List<string> LabelList;

	[SerializeField]
	private List<Texture> TextureList;

	[SerializeField]
	private List<PantoneList> PantoneIndexList;

	private Color StringToColor(string colorStr)
	{
		return default(Color);
	}

	public void Clear()
	{
	}

	public void AddIDData(Texture texture, TextAsset textAsset)
	{
	}

	public Texture GetTexture(string label)
	{
		return null;
	}

	public (string, Color) GetPantone(string label, Color idColor)
	{
		return default((string, Color));
	}
}
