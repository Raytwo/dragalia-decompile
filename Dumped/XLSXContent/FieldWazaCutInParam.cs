using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FieldWazaCutInParam : ScriptableObject
{
	[Serializable]
	public class SheetPokemonParam
	{
		public int UniqueID;

		public float ModelScale;

		public string ModelMotion;

		public Vector3 ModelOffset;

		public Vector3 ModelRotationAngle;
	}

	[Serializable]
	public class SheetCommonParam
	{
		public float param;
	}

	public SheetPokemonParam[] PokemonParam;

	public SheetCommonParam[] CommonParam;

	public SheetPokemonParam this[int index] => null;
}
