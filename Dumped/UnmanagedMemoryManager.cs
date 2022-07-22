using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class UnmanagedMemoryManager
{
	public class AllocInfo
	{
		public IntPtr ptr
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int size
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

		public AllocInfo(IntPtr _ptr, int _size)
		{
		}
	}

	public static List<AllocInfo> s_NeedFreeList;

	public static IntPtr Alloc(int size)
	{
		return default(IntPtr);
	}

	public static IntPtr Alloc<T>()
	{
		return default(IntPtr);
	}

	public static bool Free(IntPtr p)
	{
		return default(bool);
	}

	public static void DestroyStructure<T>(IntPtr p)
	{
	}

	public static IntPtr WriteObject<T>(T obj, ref int bufferSize, int allocSize = 0)
	{
		return default(IntPtr);
	}

	public static bool ReadObject<T>(IntPtr p, ref T obj)
	{
		return default(bool);
	}

	public static IntPtr WriteArray<T>(T[] array, ref int bufferSize)
	{
		return default(IntPtr);
	}

	public static bool ReadArray<T>(IntPtr p, int arrayLength, ref T[] array)
	{
		return default(bool);
	}

	public static IntPtr WriteList<T>(List<T> list, ref int bufferSize)
	{
		return default(IntPtr);
	}

	public static bool ReadList<T>(IntPtr p, int listCount, ref List<T> list)
	{
		return default(bool);
	}

	public static IntPtr WriteUtf8(string str, ref int bufferSize)
	{
		return default(IntPtr);
	}

	public static string ReadUtf8(IntPtr pStr, int stringSize)
	{
		return null;
	}

	public static IntPtr WriteUtf16(string str, ref int bufferSize)
	{
		return default(IntPtr);
	}

	public static string ReadUtf16(IntPtr pStr, int stringSize)
	{
		return null;
	}

	public static void ValidateAllocInfo()
	{
	}
}
