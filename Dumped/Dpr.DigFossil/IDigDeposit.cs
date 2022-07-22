using UnityEngine;

namespace Dpr.DigFossil;

public interface IDigDeposit
{
	GameObject gameObject { get; }

	void Initialize(DigMasterDataManager.IDeposit depositData, Vector3 pos, Vector2 size, int turn, Sprite sprite, Material material, DigEffectManager effectManager);

	void RequestDigOutDirection();
}
