﻿namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External]
	public partial class RTCIdentityAssertion
	{
		internal extern RTCIdentityAssertion();

		public extern RTCIdentityAssertion(string idp, string name);

		public string Idp;

		public string Name;
	}
}