﻿using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("HTMLElement")]
	public partial class Element : XmlElement
	{
		internal extern Element();

		public string AccessKey;

		public readonly string AccessKeyLabel;

		public extern void AddEventListener(ElementEvents type, Action listener);

		public extern void AddEventListener(ElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void AddEventListener(ElementEvents type, IEventListener listener);

		public extern void AddEventListener(ElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void Blur();

		public string ClassName;

		public extern void Click();

		public string ContentEditable;

		public readonly MenuElement ContextMenu;

		public readonly DOMStringMap Dataset;

		public string Dir;

		public bool Draggable;

		public extern void Focus();

		public bool Hidden;

		public readonly bool IsContentEditable;

		public string ItemId;

		public readonly DOMSettableTokenList ItemProp;

		public readonly DOMSettableTokenList ItemRef;

		public bool ItemScope;

		public readonly DOMSettableTokenList ItemType;

		public object ItemValue;

		public string Lang;

		public readonly int OffsetHeight;

		public readonly int OffsetLeft;

		public readonly Element OffsetParent;

		public readonly int OffsetTop;

		public readonly int OffsetWidth;

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("onblur")]
		public HtmlEventHandler OnBlur;

		[Name("oncanplay")]
		public HtmlEventHandler OnCanplay;

		[Name("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough;

		[Name("onchange")]
		public HtmlEventHandler OnChange;

		[Name("onclick")]
		public HtmlEventHandler OnClick;

		[Name("oncontextmenu")]
		public HtmlEventHandler OnContextmenu;

		[Name("oncopy")]
		public HtmlEventHandler OnCopy;

		[Name("oncut")]
		public HtmlEventHandler OnCut;

		[Name("ondblclick")]
		public HtmlEventHandler OnDblclick;

		[Name("ondrag")]
		public HtmlEventHandler OnDrag;

		[Name("ondragend")]
		public HtmlEventHandler OnDragend;

		[Name("ondragenter")]
		public HtmlEventHandler OnDragenter;

		[Name("ondragleave")]
		public HtmlEventHandler OnDragleave;

		[Name("ondragover")]
		public HtmlEventHandler OnDragover;

		[Name("ondragstart")]
		public HtmlEventHandler OnDragstart;

		[Name("ondrop")]
		public HtmlEventHandler OnDrop;

		[Name("ondurationchange")]
		public HtmlEventHandler OnDurationchange;

		[Name("onemptied")]
		public HtmlEventHandler OnEmptied;

		[Name("onended")]
		public HtmlEventHandler OnEnded;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onfocus")]
		public HtmlEventHandler OnFocus;

		[Name("oninput")]
		public HtmlEventHandler OnInput;

		[Name("oninvalid")]
		public HtmlEventHandler OnInvalid;

		[Name("onkeydown")]
		public HtmlEventHandler OnKeydown;

		[Name("onkeypress")]
		public HtmlEventHandler OnKeypress;

		[Name("onkeyup")]
		public HtmlEventHandler OnKeyup;

		[Name("onload")]
		public HtmlEventHandler OnLoad;

		[Name("onloadeddata")]
		public HtmlEventHandler OnLoadeddata;

		[Name("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata;

		[Name("onloadstart")]
		public HtmlEventHandler OnLoadstart;

		[Name("onmousedown")]
		public HtmlEventHandler OnMousedown;

		[Name("onmouseenter")]
		public HtmlEventHandler OnMouseenter;

		[Name("onmouseleave")]
		public HtmlEventHandler OnMouseleave;

		[Name("onmousemove")]
		public HtmlEventHandler OnMousemove;

		[Name("onmouseout")]
		public HtmlEventHandler OnMouseout;

		[Name("onmouseover")]
		public HtmlEventHandler OnMouseover;

		[Name("onmouseup")]
		public HtmlEventHandler OnMouseup;

		[Name("onpaste")]
		public HtmlEventHandler OnPaste;

		[Name("onpause")]
		public HtmlEventHandler OnPause;

		[Name("onplay")]
		public HtmlEventHandler OnPlay;

		[Name("onplaying")]
		public HtmlEventHandler OnPlaying;

		[Name("onpointercancel")]
		public HtmlEventHandler OnPointercancel;

		[Name("onpointerdown")]
		public HtmlEventHandler OnPointerdown;

		[Name("onpointerenter")]
		public HtmlEventHandler OnPointerenter;

		[Name("onpointerleave")]
		public HtmlEventHandler OnPointerleave;

		[Name("onpointermove")]
		public HtmlEventHandler OnPointermove;

		[Name("onpointerout")]
		public HtmlEventHandler OnPointerout;

		[Name("onpointerover")]
		public HtmlEventHandler OnPointerover;

		[Name("onpointerup")]
		public HtmlEventHandler OnPointerup;

		[Name("onprogress")]
		public HtmlEventHandler OnProgress;

		[Name("onratechange")]
		public HtmlEventHandler OnRatechange;

		[Name("onreset")]
		public HtmlEventHandler OnReset;

		[Name("onscroll")]
		public HtmlEventHandler OnScroll;

		[Name("onseeked")]
		public HtmlEventHandler OnSeeked;

		[Name("onseeking")]
		public HtmlEventHandler OnSeeking;

		[Name("onselect")]
		public HtmlEventHandler OnSelect;

		[Name("onshow")]
		public HtmlEventHandler OnShow;

		[Name("onstalled")]
		public HtmlEventHandler OnStalled;

		[Name("onsubmit")]
		public HtmlEventHandler OnSubmit;

		[Name("onsuspend")]
		public HtmlEventHandler OnSuspend;

		[Name("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate;

		[Name("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel;

		[Name("ontouchend")]
		public HtmlEventHandler OnTouchend;

		[Name("ontouchenter")]
		public HtmlEventHandler OnTouchenter;

		[Name("ontouchleave")]
		public HtmlEventHandler OnTouchleave;

		[Name("ontouchmove")]
		public HtmlEventHandler OnTouchmove;

		[Name("ontouchstart")]
		public HtmlEventHandler OnTouchstart;

		[Name("onvolumechange")]
		public HtmlEventHandler OnVolumechange;

		[Name("onwaiting")]
		public HtmlEventHandler OnWaiting;

		public extern void RemoveEventListener(ElementEvents type, Action listener);

		public extern void RemoveEventListener(ElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public bool Scrollgrab;

		public bool Spellcheck;

		public readonly Style Style;

		public int TabIndex;

		public string Title;
	}
}