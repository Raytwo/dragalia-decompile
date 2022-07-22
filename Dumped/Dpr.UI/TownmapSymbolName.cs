using UnityEngine;
using XLSXContent;

namespace Dpr.UI;

public class TownmapSymbolName : MonoBehaviour
{
	[SerializeField]
	private UIText _text;

	private bool _isActived;

	private TownMapTable.SheetData _data;

	public void SetActive(bool isActive)
	{
	}

	public void Setup(Townmap.Cell cell, Vector3 pos)
	{
	}
}
