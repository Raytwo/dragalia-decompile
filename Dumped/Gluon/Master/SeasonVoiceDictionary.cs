using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class SeasonVoiceDictionary : SerializableDictionary<int, SeasonVoiceElement>
	{
	}
}
