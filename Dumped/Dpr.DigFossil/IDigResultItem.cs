using UnityEngine;

namespace Dpr.DigFossil;

public interface IDigResultItem
{
	int LabelID { get; }

	int UgItemId { get; }

	GameObject gameObject { get; }

	void Initialize(Sprite sprite, DigMasterDataManager.DepositItemData data);

	void Show();

	void Hide();
}
