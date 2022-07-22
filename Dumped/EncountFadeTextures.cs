using UnityEngine;

[CreateAssetMenu]
public class EncountFadeTextures : ScriptableObject
{
	[SerializeField]
	private Texture[] _textures;

	public Texture this[int index] => null;
}
