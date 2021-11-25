using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonStartStartMultiResponse> onSuccess;

		private Action<ErrorType, int, DungeonStartStartMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonStartStartMultiTask(DungeonStartStartMultiRequest request, Action<DungeonStartStartMultiResponse> onSuccess, Action<ErrorType, int, DungeonStartStartMultiResponse> onError)
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
