using System;

namespace Xoroshiro128Plus;

public class Xoroshiro128Plus
{
	private const int a = 24;

	private const int b = 16;

	private const int c = 37;

	private readonly ulong[] JUMP;

	private readonly ulong[] LONG_JUMP;

	private ulong state0;

	private ulong state1;

	public ulong[] State
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Xoroshiro128Plus Clone()
	{
		return null;
	}

	public Xoroshiro128Plus(ulong seed)
	{
	}

	public Xoroshiro128Plus Seed()
	{
		return null;
	}

	public Xoroshiro128Plus(Xoroshiro128Plus other)
	{
	}

	public Xoroshiro128Plus(ulong state0, ulong state1)
	{
	}

	public Xoroshiro128Plus()
	{
	}

	public Xoroshiro128Plus(Random r)
	{
	}

	public Xoroshiro128Plus(decimal seed)
	{
	}

	public Xoroshiro128Plus Seed(ulong seed)
	{
		return null;
	}

	public Xoroshiro128Plus Seed(ulong state0, ulong state1)
	{
		return null;
	}

	private ulong rotate(ulong x, int k)
	{
		return default(ulong);
	}

	private static ulong splitmix64(ref ulong x)
	{
		return default(ulong);
	}

	public static ulong Splitmix64(ref ulong x)
	{
		return default(ulong);
	}

	public static ulong Splitmix64(ulong x)
	{
		return default(ulong);
	}

	public long NextLong()
	{
		return default(long);
	}

	public ulong NextULong()
	{
		return default(ulong);
	}

	public uint NextUInt()
	{
		return default(uint);
	}

	public int NextInt()
	{
		return default(int);
	}

	public short NextShort()
	{
		return default(short);
	}

	public ushort NextUShort()
	{
		return default(ushort);
	}

	public byte NextByte()
	{
		return default(byte);
	}

	public sbyte NextSByte()
	{
		return default(sbyte);
	}

	public void NextBytes(byte[] bytes)
	{
	}

	public bool NextBool()
	{
		return default(bool);
	}

	public double NextDouble()
	{
		return default(double);
	}

	public float NextFloat()
	{
		return default(float);
	}

	private ulong next()
	{
		return default(ulong);
	}

	public void Jump(int n)
	{
	}

	public void LongJump(int n)
	{
	}

	public void Jump()
	{
	}

	public Xoroshiro128Plus JumpInto()
	{
		return null;
	}

	public void LongJump()
	{
	}

	public Xoroshiro128Plus LongJumpInto()
	{
		return null;
	}
}
