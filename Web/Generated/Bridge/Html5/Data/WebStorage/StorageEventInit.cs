﻿namespace Bridge.Html5.Data.WebStorage
{
	[External, Serializable]
	public partial class StorageEventInit : EventInit
	{
		public string Key;

		public string NewValue;

		public string OldValue;

		public Storage StorageArea;

		public string Url;
	}
}