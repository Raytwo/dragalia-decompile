using System;
using System.Collections.Generic;

namespace Dpr.Field.Walking;

public static class ListExtension
{
	public delegate bool FindDelegate<T>(T model);

	public static T GetRandomofMaxpriority<T>(this List<T> list) where T : ActionModel
	{
		return null;
	}

	public static T GetRandom<T>(this List<T> list)
	{
		return (T)null;
	}

	public static void FindDoAll<T>(this List<T> list, FindDelegate<T> find, Action<T> act)
	{
	}

	public static TSource FindMin<TSource, TResult>(this IEnumerable<TSource> self, Func<TSource, TResult> selector)
	{
		return (TSource)null;
	}

	public static TSource FindMax<TSource, TResult>(this IEnumerable<TSource> self, Func<TSource, TResult> selector)
	{
		return (TSource)null;
	}
}
