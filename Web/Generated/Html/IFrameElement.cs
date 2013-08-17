﻿using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IFRAME'"), ScriptName("Element")]
	public partial class IFrameElement : Element {
		internal IFrameElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool AllowFullscreen {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public DocumentBase ContentDocument {
			get {
				return default(DocumentBase);
			}
		}

		[IntrinsicProperty]
		public WindowInstance ContentWindow {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public string FrameBorder {
			get {
				return null;
			}
			set {
			}
		}

		public DocumentBase GetSVGDocument() {
			return default(DocumentBase);
		}

		[IntrinsicProperty]
		public string Height {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string LongDesc {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string MarginHeight {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string MarginWidth {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Sandbox {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Scrolling {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Src {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Srcdoc {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Width {
			get {
				return null;
			}
			set {
			}
		}
	}
}
