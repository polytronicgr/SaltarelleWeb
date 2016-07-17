﻿namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class ScriptProcessorNode : AudioNode
	{
		internal extern ScriptProcessorNode();

		public extern void AddEventListener(ScriptProcessorNodeEvents type, Action listener);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, IEventListener listener);

		public extern void AddEventListener(ScriptProcessorNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture);

		public readonly int BufferSize;

		[Name("onaudioprocess")]
		public HtmlEventHandler OnAudioprocess;

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, Action listener);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(ScriptProcessorNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture);
	}
}