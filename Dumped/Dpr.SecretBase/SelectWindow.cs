using UnityEngine;

namespace Dpr.SecretBase;

public class SelectWindow<T, Data> : ListView<T, Data> where T : SelectItemBase<Data>
{
	protected enum MoveState
	{
		Idle,
		Move,
		WaitRelease
	}

	[SerializeField]
	protected UICursor uiCursor;

	protected float forcusScale;

	[SerializeField]
	protected float forcusTime;

	[SerializeField]
	private bool isScale;

	[SerializeField]
	protected bool isStopEnd;

	protected int index;

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void Init()
	{
	}

	protected void CursorAttach()
	{
	}

	public virtual int BindItem(Data data, T item)
	{
		return default(int);
	}

	public override int AddItem(Data data)
	{
		return default(int);
	}

	public override void ClearItem()
	{
	}

	public virtual bool SelectNext()
	{
		return default(bool);
	}

	public virtual bool SelectPrev()
	{
		return default(bool);
	}

	public void SetCursorActive(bool value)
	{
	}

	public void SetIndex(int index)
	{
	}

	public int GetIndex()
	{
		return default(int);
	}

	public Data GetData()
	{
		return (Data)null;
	}

	public T GetIcon(int index)
	{
		return null;
	}

	public int GetItemCount()
	{
		return default(int);
	}
}
