using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CustomNodeProperty
{
	public enum PropertyType
	{
		FLOAT,
		UV,
		UV_POKEDEFAULT_COL0TEX,
		UV_POKEDEFAULT_LAYERTEX,
		UVSL_POKEDEFAULT_COL0TEX,
		SUV_POKEDEFAULT_COL0TEX,
		UV_GROUNDEFFECT_GROUNDEffECTMASKTEX,
		UVSL_POKEDEFAULT_LAYERTEX,
		UV_POKEDEFAULT_LAYERTEX_NOT_ROUND
	}

	public GameObject bone;

	public GameObject boneSub;

	public string propertyName;

	public PropertyType pType;

	public Vector2 baseUV;

	public Vector2 baseScale;

	private string propertyName_U;

	private string propertyName_V;

	protected float GetAttributeFloat(IDictionary<string, object> dictAttr, string attrName)
	{
		return default(float);
	}

	public void SetUp()
	{
	}

	public void Update(Material mat)
	{
	}

	public void UpdateSmokeMask(Material mat)
	{
	}

	public void UpdatePropertyBlock(MaterialPropertyBlock mpb)
	{
	}

	public void UpdatePropertyBlockSmokeMask(MaterialPropertyBlock mpb)
	{
	}
}
