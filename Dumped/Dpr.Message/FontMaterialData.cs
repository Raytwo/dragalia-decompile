using UnityEngine;

namespace Dpr.Message;

[CreateAssetMenu]
public class FontMaterialData : ScriptableObject
{
	public FontMaterialProperty defaultMaterialProperty;

	public FontMaterialProperty[] materialPropertyArray;
}
