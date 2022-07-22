using System.Collections.Generic;
using UnityEngine;

namespace Dpr.SecretBase;

public class ListView<T, Data> : MonoBehaviour where T : SelectItemBase<Data>
{
	[SerializeField]
	protected RectTransform content;

	[SerializeField]
	protected T itemBase;

	protected List<T> itemList;

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected virtual void Init()
	{
	}

	public virtual int AddItem(Data data)
	{
		return default(int);
	}

	public virtual void ClearItem()
	{
	}
}
