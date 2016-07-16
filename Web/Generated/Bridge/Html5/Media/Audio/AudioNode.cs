﻿namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioNode : EventTarget
	{
		internal AudioNode()
		{
		}

		public void AddEventListener(AudioNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(AudioNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(AudioNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(AudioNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener)
		{
		}

		public void AddEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture)
		{
		}

		public void AddEventListener(AudioNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(AudioNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public int ChannelCount
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public ChannelCountMode ChannelCountMode
		{
			get {
				return default(ChannelCountMode);
			}
			set {
			}
		}

		[FieldProperty]
		public ChannelInterpretation ChannelInterpretation
		{
			get {
				return default(ChannelInterpretation);
			}
			set {
			}
		}

		public void Connect(AudioNode destination)
		{
		}

		public void Connect(AudioNode destination, int output)
		{
		}

		public void Connect(AudioNode destination, int output, int input)
		{
		}

		public void Connect(AudioParam destination)
		{
		}

		public void Connect(AudioParam destination, int output)
		{
		}

		[FieldProperty]
		public AudioContext Context
		{
			get {
				return default(AudioContext);
			}
		}

		public void Disconnect()
		{
		}

		public void Disconnect(int output)
		{
		}

		[FieldProperty]
		public int NumberOfInputs
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int NumberOfOutputs
		{
			get {
				return 0;
			}
		}

		public void RemoveEventListener(AudioNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(AudioNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture)
		{
		}
	}
}
