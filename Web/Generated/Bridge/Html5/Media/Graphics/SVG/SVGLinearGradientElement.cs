﻿namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGLinearGradientElement : SVGGradientElement
	{
		internal extern SVGLinearGradientElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener, bool capture);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, Action listener);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener, bool capture);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGLinearGradientElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener, bool capture);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener, bool capture);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGLinearGradientElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength X1;

		public readonly SVGAnimatedLength X2;

		public readonly SVGAnimatedLength Y1;

		public readonly SVGAnimatedLength Y2;
	}
}