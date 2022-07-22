public class PiaPluginReckoning
{
	public class Value3d
	{
		private static extern PiaPlugin.Result SetValue3dNative(ushort port, ulong destConstantId, float posX, float posY, float posZ, bool isStop);

		public static PiaPlugin.Result SetValue(ushort port, ulong destConstantId, float posX, float posY, float posZ, bool isStop)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result SetValueToAll3dNative(ushort port, float posX, float posY, float posZ, bool isStop);

		public static PiaPlugin.Result SetValueToAll(ushort port, float posX, float posY, float posZ, bool isStop)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result GetValue3dNative(ushort port, out ulong destConstantId, out float posX, out float posY, out float posZ);

		public static PiaPlugin.Result GetValue(ushort port, out ulong destConstantId, out float pPosX, out float pPosY, out float pPosZ)
		{
			return default(PiaPlugin.Result);
		}

		private static extern void SetSamplingDistance3dNative(ushort port, float distance);

		public static void SetSamplingDistance(ushort port, float distance)
		{
		}

		private static extern float GetSamplingDistance3dNative(ushort port);

		public static float GetSamplingDistance(ushort port)
		{
			return default(float);
		}

		private static extern bool IsInCommunication3dNative(ushort port);

		public static bool IsInCommunication(ushort port)
		{
			return default(bool);
		}

		private static extern bool Reset3dNative(ushort port);

		public static void Reset(ushort port)
		{
		}

		private static extern void SetClock3dNative(ushort port, ulong clock);

		public static void SetClock(ushort port, ulong clock)
		{
		}

		private static extern void SetReckoningTimeout3dNative(ushort port, ulong clock);

		public static void SetReckoningTimeout(ushort port, ulong clock)
		{
		}
	}

	public class Value1d
	{
		private static extern PiaPlugin.Result SetValue1dNative(ushort port, ulong destConstantId, float value, bool isStop);

		public static PiaPlugin.Result SetValue(ushort port, ulong destConstantId, float value, bool isStop)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result SetValueToAll1dNative(ushort port, float value, bool isStop);

		public static PiaPlugin.Result SetValueToAll(ushort port, float value, bool isStop)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result GetValue1dNative(ushort port, out ulong destConstantId, out float pValue);

		public static PiaPlugin.Result GetValue(ushort port, out ulong destConstantId, out float pValue)
		{
			return default(PiaPlugin.Result);
		}

		private static extern void SetSamplingDistance1dNative(ushort port, float value);

		public static void SetSamplingDistance(ushort port, float value)
		{
		}

		private static extern float GetSamplingDistance1dNative(ushort port);

		public static float GetSamplingDistance(ushort port)
		{
			return default(float);
		}

		private static extern bool IsInCommunication1dNative(ushort port);

		public static bool IsInCommunication(ushort port)
		{
			return default(bool);
		}

		private static extern bool Reset1dNative(ushort port);

		public static void Reset(ushort port)
		{
		}

		private static extern void SetClock1dNative(ushort port, ulong clock);

		public static void SetClock(ushort port, ulong clock)
		{
		}

		private static extern void SetReckoningTimeout1dNative(ushort port, ulong clock);

		public static void SetReckoningTimeout(ushort port, ulong clock)
		{
		}
	}
}
