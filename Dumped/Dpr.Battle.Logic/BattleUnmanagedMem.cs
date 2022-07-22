using System.Collections.Generic;
using Unity.Collections;

namespace Dpr.Battle.Logic;

public static class BattleUnmanagedMem
{
	private struct ELEM
	{
		public unsafe void* pAddr;

		public Allocator allocator;
	}

	private static List<ELEM> m_Elems;

	public unsafe static void* Malloc(long size, Allocator allocator = Allocator.Persistent, int alignment = 16)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	public unsafe static void Free(void* pAddr)
	{
	}

	public static void FreeAll()
	{
	}
}
