﻿namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Worker : EventTarget
	{
		internal Worker()
		{
		}

		public Worker(string scriptURL)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener, bool capture)
		{
		}

		public void AddEventListener(WorkerEvents type, Action listener)
		{
		}

		public void AddEventListener(WorkerEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(WorkerEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(WorkerEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener)
		{
		}

		public void AddEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener, bool capture)
		{
		}

		public void AddEventListener(WorkerEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(WorkerEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmessage")]
		public HtmlEventHandler OnMessage
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void PostMessage(object message)
		{
		}

		public void PostMessage(object message, object[] transfer)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerEvents type, Action listener)
		{
		}

		public void RemoveEventListener(WorkerEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(WorkerEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener)
		{
		}

		public void RemoveEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(WorkerEvents type, IEventListener listener, bool capture)
		{
		}

		public void Terminate()
		{
		}
	}
}
