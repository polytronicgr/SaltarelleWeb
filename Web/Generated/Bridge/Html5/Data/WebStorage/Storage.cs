﻿namespace Bridge.Html5.Data.WebStorage
{
	[Namespace("false"), External]
	public partial class Storage
	{
		internal extern Storage();

		public extern string this[string key]
		{
			get;
			set;
		}

		public extern void Clear();

		public extern string GetItem(string key);

		public extern string Key(int index);

		public readonly int Length;

		public extern void RemoveItem(string key);

		public extern void SetItem(string key, string value);
	}
}