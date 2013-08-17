﻿using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SharedWorker : EventTarget {
		internal SharedWorker() {
		}

		public SharedWorker(string scriptURL) {
		}

		public SharedWorker(string scriptURL, string name) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture) {
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public MessagePort Port {
			get {
				return default(MessagePort);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture) {
		}
	}
}
