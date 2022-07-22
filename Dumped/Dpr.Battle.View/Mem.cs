using System;
using System.Collections;
using System.Collections.Generic;

namespace Dpr.Battle.View;

public static class Mem
{
	public static void Del<T>(ref T p)
	{
	}

	public static void Del<T>(T p)
	{
	}

	public static void DelAry<T>(ref T[] p)
	{
	}

	public static void DelAry<T>(T[] p)
	{
	}

	public static void DelICollection<T>(ref List<T> p)
	{
	}

	public static void DelICollection<T>(List<T> p)
	{
	}

	public static void DelICollection(ref IDictionary p)
	{
	}

	public static void DelICollection(IDictionary p)
	{
	}

	public static void DelICollection<T>(ref Queue<T> p)
	{
	}

	public static void DelICollection<T>(Queue<T> p)
	{
	}

	public static void DelIDisposable<T>(ref T p) where T : IDisposable
	{
	}

	public static void DelAryIDisposable<T>(T[] p) where T : IDisposable
	{
	}

	public static void DelAryIDisposable<T>(ref T[] p) where T : IDisposable
	{
	}

	public static void DelIDisposable<T>(T p) where T : IDisposable
	{
	}

	public static void ClearICollection<T>(ref List<T> p)
	{
	}

	public static void ClearICollection<T>(List<T> p)
	{
	}

	public static void ClearICollection<T>(ref Queue<T> p)
	{
	}

	public static void ClearICollection<T>(Queue<T> p)
	{
	}
}
