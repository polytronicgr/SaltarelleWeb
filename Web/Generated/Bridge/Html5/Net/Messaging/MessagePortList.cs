﻿namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External, Name("Object")]
	public partial class MessagePortList
	{
		internal extern MessagePortList();

		public extern MessagePort this[int index]
		{
			get;
		}

		public extern MessagePort Item(int index);

		public readonly int Length;
	}
}