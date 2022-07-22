using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class AttributeMatrix : ScriptableObject
{
	public AttributeBlock[] AttributeBlocks;

	public int Width;

	public AttributeBlock this[int index] => null;

	public AttributeBlock this[int gridX, int gridY] => null;
}
