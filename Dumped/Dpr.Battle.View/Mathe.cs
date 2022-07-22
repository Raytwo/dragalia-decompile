using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Dpr.Battle.View;

public static class Mathe
{
	public static class Easing
	{
		public static Vector4 EasedValue(Vector4 from, Vector4 to, float raito, Ease easingType)
		{
			return default(Vector4);
		}

		public static float EasedValue(float from, float to, float raito, Ease easingType)
		{
			return default(float);
		}
	}

	public static class Btlv
	{
		public static void RotRad(ref float x, ref float z, [In] ref float rad)
		{
		}

		public static void RotDeg(ref float x, ref float z, [In] ref float deg)
		{
		}

		public static void RotDegXZ(ref Vector3 vec, [In] ref float deg)
		{
		}

		public static Vector3 Rotate([In] ref Vector3 origin, [In] ref Quaternion rotation)
		{
			return default(Vector3);
		}
	}

	public static int Rewind([In] ref int value, [In] ref int min, [In] ref int max)
	{
		return default(int);
	}

	public static float FrameToSecond([In] ref int frame)
	{
		return default(float);
	}

	public static float FrameToSecond([In] ref int frame, [In] ref int fps = 30)
	{
		return default(float);
	}

	public static int SecondToFrame([In] ref float time)
	{
		return default(int);
	}

	public static int SecondToFrame([In] ref float time, [In] ref int fps = 30)
	{
		return default(int);
	}

	public static bool Limit([In] ref int value, [In] ref int limit)
	{
		return default(bool);
	}

	public static float Inverse(float val)
	{
		return default(float);
	}

	public static int Inverse(int val)
	{
		return default(int);
	}

	public static Vector3 Inverse(Vector3 vec)
	{
		return default(Vector3);
	}

	public static void SinCosRad(ref float sin, ref float cos, [In] ref float radian)
	{
	}

	public static void SinCosDeg(ref float sin, ref float cos, [In] ref float degree)
	{
	}

	public static float SinDeg([In] ref float degree)
	{
		return default(float);
	}

	public static float DegreeToRadian([In] ref float degree)
	{
		return default(float);
	}

	public static float Atan2([In] ref float y, [In] ref float x)
	{
		return default(float);
	}

	public static float Atan2Deg([In] ref float y, [In] ref float x)
	{
		return default(float);
	}

	public static float Length([In] ref float x, [In] ref float y)
	{
		return default(float);
	}

	public static float Rate([In] ref int value)
	{
		return default(float);
	}

	public static Vector3 Offset([In] ref Vector3 from, [In] ref Vector3 to)
	{
		return default(Vector3);
	}

	public static Vector3 VectorMulPerElem([In] ref Vector3 vec1, [In] ref Vector3 vec2)
	{
		return default(Vector3);
	}

	public static Vector4 VectorMulPerElem([In] ref Vector4 vec1, [In] ref Vector4 vec2)
	{
		return default(Vector4);
	}

	public static float CM2M([In] ref float val)
	{
		return default(float);
	}

	public static Vector3 CM2M([In] ref Vector3 vec)
	{
		return default(Vector3);
	}

	public static Vector3 M2CM([In] ref Vector3 vec)
	{
		return default(Vector3);
	}

	public static Vector3 CoordinateAdjust(Vector3 vec, bool toSWSH = false)
	{
		return default(Vector3);
	}

	public static Vector3 RotationAdjust(Vector3 vec)
	{
		return default(Vector3);
	}

	public static void RotationAdjust360(ref float value)
	{
	}

	public static int Bool2Int(bool value)
	{
		return default(int);
	}

	public static bool Int2Bool(int value)
	{
		return default(bool);
	}

	public static int Max([In] ref int a, [In] ref int b)
	{
		return default(int);
	}

	public static float Min([In] ref float a, [In] ref float b)
	{
		return default(float);
	}

	public static int Min([In] ref int a, [In] ref int b)
	{
		return default(int);
	}

	public static float Raito([In] ref int a, [In] ref int b)
	{
		return default(float);
	}

	public static float Raito([In] ref float mn, [In] ref float mx, [In] ref float nw)
	{
		return default(float);
	}

	public static int ClampMin([In] ref int val, [In] ref int min = 0)
	{
		return default(int);
	}

	public static float ClampMin([In] ref float val, [In] ref float min = 0f)
	{
		return default(float);
	}

	public static void SetVectorSelectElem(ref Vector3 retVec, ref Vector3 vec, [In] ref bool[] enableFlags)
	{
	}

	public static void Swap<T>(ref T a, ref T b)
	{
	}
}
