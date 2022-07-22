using System;
using System.Runtime.InteropServices;

namespace AK.Wwise;

[Serializable]
public class Bank : BaseType
{
	public WwiseBankReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override WwiseObjectType WwiseObjectType => default(WwiseObjectType);

	public void Load(bool decodeBank = false, bool saveDecodedBank = false)
	{
	}

	public void LoadAsync([Optional] AkCallbackManager.BankCallback callback)
	{
	}

	public void Unload()
	{
	}
}
