using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DPData;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public abstract class PoketchAppBase : MonoBehaviour
{
	[SerializeField]
	public PoketchButton[] Buttons;

	protected PoketchWindow _poketchInstance;

	protected bool isInitialized;

	public POKETCH_APPID AppID
	{
		[CompilerGenerated]
		get
		{
			return default(POKETCH_APPID);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public PoketchButton PreButton
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public PoketchWindow.TouchState PreState
	{
		[CompilerGenerated]
		get
		{
			return default(PoketchWindow.TouchState);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public void Initialize()
	{
	}

	protected abstract void OnInitialize();

	public void Uninitialize()
	{
	}

	protected virtual void OnUninitialize()
	{
	}

	public void Open(PoketchWindow poketch)
	{
	}

	protected abstract void OnOpen();

	public void Close()
	{
	}

	protected abstract void OnClose();

	public void OnUpdate(bool isAppControlEnable, [Optional] PoketchButton currentButton, PoketchWindow.TouchState currentState = PoketchWindow.TouchState.None)
	{
	}

	protected abstract void OnUpdateDraw();

	protected abstract void OnUpdateControl(bool isAppControlEnable = false, [Optional] PoketchButton targetButton, PoketchWindow.TouchState state = PoketchWindow.TouchState.None);

	public virtual void OnSizeChanged(bool isLarge)
	{
	}

	public virtual void OnAppChanged()
	{
	}

	public void ChangeSize(bool notReleaseUncontrol = false, [Optional] UnityAction callback)
	{
	}

	protected bool CloseWithPoketchBody()
	{
		return default(bool);
	}

	protected void ResetButtons()
	{
	}
}
