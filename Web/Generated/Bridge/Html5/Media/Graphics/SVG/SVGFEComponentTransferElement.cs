﻿namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGFEComponentTransferElement : SVGElement
	{
		internal extern SVGFEComponentTransferElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}