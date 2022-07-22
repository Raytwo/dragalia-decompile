using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class TownmapInfo : MonoBehaviour
{
	[SerializeField]
	private Image[] _images;

	private Townmap.NoticeType _selectType;

	private UnityAction<Townmap.NoticeType> _onSelectChanged;

	public void Setup(UnityAction<Townmap.NoticeType> onSelectChanged)
	{
	}

	public void Select(Townmap.NoticeType type, bool isInitialized)
	{
	}

	public bool OnUpdate(float deltaTime, UIInputController input)
	{
		return default(bool);
	}
}
