using UnityEngine.Events;

namespace Dpr.UI;

public abstract class GiftSubWindow : UIWindow
{
	public void Initialize(UnityAction<UIWindow> onClosedCallback)
	{
	}

	protected abstract void OnInitialize();

	public abstract void OnUpdate(float deltaTime);

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	protected void SetupKeyguide(KeyguideID[] keyguideIDs)
	{
	}
}
