using System;
using System.Runtime.InteropServices;

namespace Dpr.UI;

public class ShopItemSelectAmount : ItemSelectAmount
{
	private const int ChangeAmountValue = 1;

	private const int ChangeLotAmountValue = 10;

	private Action<int> onDecideSelectAmountCallback;

	private Action onCancelSelectAmountCallback;

	private Action<int> onSelectAmountValueChangedCallback;

	private UIInputController _input;

	public void OnUpdate()
	{
	}

	public void ShowSelectAmount(int min, int max, Action<int> onDecide, Action onCancel, [Optional] Action<int> onAmountValueChanged)
	{
	}

	public void ChangeSelectAmount(bool isAdd, bool isLot)
	{
	}

	public void ResumeSelectAmountChange()
	{
	}

	public void DecideSelectAmount()
	{
	}

	public void CancelSelectAmount()
	{
	}

	public void SetSelectAmountDescriptionText(string text)
	{
	}
}
