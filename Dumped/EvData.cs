using System;
using System.Collections.Generic;
using UnityEngine;

public class EvData : ScriptableObject
{
	public enum ArgType
	{
		Command,
		Float,
		Work,
		Flag,
		SysFlag,
		String
	}

	[Serializable]
	public struct Aregment
	{
		public ArgType argType;

		public int data;
	}

	[Serializable]
	public class Script
	{
		public string Label;

		public List<Command> Commands;
	}

	[Serializable]
	public class Command
	{
		public List<Aregment> Arg;
	}

	public List<Script> Scripts;

	public List<string> StrList;

	public string GetString(int index)
	{
		return null;
	}
}
