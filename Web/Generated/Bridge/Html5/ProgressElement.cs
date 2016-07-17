﻿namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class ProgressElement : Element
	{
		internal extern ProgressElement();

		public extern void AddEventListener(ProgressElementEvents type, Action listener);

		public extern void AddEventListener(ProgressElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		public extern void AddEventListener(ProgressElementEvents type, IEventListener listener);

		public extern void AddEventListener(ProgressElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		public double Max;

		public readonly double Position;

		public extern void RemoveEventListener(ProgressElementEvents type, Action listener);

		public extern void RemoveEventListener(ProgressElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		public extern void RemoveEventListener(ProgressElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ProgressElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		public double Value;
	}
}