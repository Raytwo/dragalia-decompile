using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeDungeonSystemHaltTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeDungeonSystemHaltResponse> onSuccess;

		private Action<ErrorType, int, DmodeDungeonSystemHaltResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeDungeonSystemHaltTask(DmodeDungeonSystemHaltRequest request, Action<DmodeDungeonSystemHaltResponse> onSuccess, Action<ErrorType, int, DmodeDungeonSystemHaltResponse> onError)
		{
		}

		public void SetHeader(string key, string value)
		{
		}

		public IWebRequest Send(string url)
		{
			return null;
		}

		public bool Deserialize(byte[] body)
		{
			return default(bool);
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
