using UnityEngine;

public class UnionCharacterData : MonoBehaviour
{
	[SerializeField]
	private string charaAssetName;

	[SerializeField]
	private int colorVariationID;

	public void SetCharaAssetName(string name)
	{
	}

	public string GetCharaAssetName()
	{
		return null;
	}

	public void SetColorVariationID(int id)
	{
	}

	public int GetColorVariationID()
	{
		return default(int);
	}
}
