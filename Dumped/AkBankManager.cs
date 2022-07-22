using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class AkBankManager
{
	private class BankHandle
	{
		protected readonly string bankName;

		protected uint m_BankID;

		public int RefCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BankHandle(string name)
		{
		}

		public virtual AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		public void LoadBank()
		{
		}

		public virtual void UnloadBank()
		{
		}

		public void IncRef()
		{
		}

		public void DecRef()
		{
		}

		protected void LogLoadResult(AKRESULT result)
		{
		}
	}

	private class AsyncBankHandle : BankHandle
	{
		private readonly AkCallbackManager.BankCallback bankCallback;

		public AsyncBankHandle(string name, AkCallbackManager.BankCallback callback)
		{
		}

		private static void GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie)
		{
		}

		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}
	}

	private class DecodableBankHandle : BankHandle
	{
		private readonly bool decodeBank;

		private readonly string decodedBankPath;

		private readonly bool saveDecodedBank;

		public DecodableBankHandle(string name, bool save)
		{
		}

		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		public override void UnloadBank()
		{
		}
	}

	private static readonly Dictionary<string, BankHandle> m_BankHandles;

	private static readonly List<BankHandle> BanksToUnload;

	internal static void DoUnloadBanks()
	{
	}

	internal static void Reset()
	{
	}

	public static void LoadInitBank(bool doReset = true)
	{
	}

	public static void UnloadInitBank()
	{
	}

	public static void LoadBank(string name, bool decodeBank, bool saveDecodedBank)
	{
	}

	public static void LoadBankAsync(string name, [Optional] AkCallbackManager.BankCallback callback)
	{
	}

	public static void UnloadBank(string name)
	{
	}
}
