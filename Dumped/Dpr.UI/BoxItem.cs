using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxItem : MonoBehaviour
{
	public class Param
	{
		public BoxInfinityScrollItem.BaseParam scrollParam;

		public bool isSearchTarget;

		public bool isForceHide;

		public bool isForceSelect;

		public bool isExSelected;

		public int index;
	}

	public static readonly Vector3 _selectIconOffset;

	public static readonly Vector3 _moveIconOffset;

	[SerializeField]
	protected PokemonIcon _root;

	[SerializeField]
	protected Image _shadow;

	[SerializeField]
	protected Image _imageSelect;

	[SerializeField]
	protected UINavigator _navigator;

	private Vector3 _swapRootPos;

	protected Param _param;

	protected bool _isItemMode;

	public UINavigator navigator => null;

	public virtual PokemonParam pokemonParam => null;

	public virtual bool isSearchTarget => default(bool);

	public virtual bool isForceHide => default(bool);

	public virtual bool isForceSelect => default(bool);

	public virtual bool isExSelected => default(bool);

	private void Awake()
	{
	}

	public virtual void Setup(Param param)
	{
	}

	public virtual void Setup()
	{
	}

	public virtual void Clear()
	{
	}

	public virtual PokemonIcon GetSwapRoot()
	{
		return null;
	}

	public virtual void SetIconDefault(bool isShow = true)
	{
	}

	public void SetDefaultPosition()
	{
	}

	public virtual void Select(bool isSelect, bool isImmidiate = false)
	{
	}

	private void SetIconSelect(bool isSelect)
	{
	}

	public virtual void SetSearch(bool isSearchTarget)
	{
	}

	public virtual void SetItemState(bool isEnable)
	{
	}

	public virtual void ReturnItemInBag()
	{
	}

	public void SetExternalSelectIcon(bool isSelect)
	{
	}
}
