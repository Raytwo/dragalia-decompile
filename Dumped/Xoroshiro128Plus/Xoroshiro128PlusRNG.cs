using System;

namespace Xoroshiro128Plus;

public class Xoroshiro128PlusRNG : Random
{
	private Xoroshiro128Plus xoroshiro;

	public Xoroshiro128Plus Internal => null;

	public override int Next()
	{
		return default(int);
	}

	public Xoroshiro128PlusRNG(ulong seed)
	{
	}

	public Xoroshiro128PlusRNG(Random r)
	{
	}

	public Xoroshiro128PlusRNG()
	{
	}

	public Xoroshiro128PlusRNG(ulong state0, ulong state1)
	{
	}

	public Xoroshiro128PlusRNG(decimal bits)
	{
	}

	public Xoroshiro128PlusRNG(byte[] bits, int startindex)
	{
	}

	public Xoroshiro128PlusRNG(byte[] bits)
	{
	}

	public Xoroshiro128PlusRNG(Xoroshiro128Plus other)
	{
	}

	public Xoroshiro128PlusRNG(Xoroshiro128PlusRNG other)
	{
	}

	private float fracture(float f)
	{
		return default(float);
	}

	public override int Next(int maxValue)
	{
		return default(int);
	}

	public override int Next(int minValue, int maxValue)
	{
		return default(int);
	}

	public override void NextBytes(byte[] buffer)
	{
	}

	public override double NextDouble()
	{
		return default(double);
	}

	protected override double Sample()
	{
		return default(double);
	}
}
