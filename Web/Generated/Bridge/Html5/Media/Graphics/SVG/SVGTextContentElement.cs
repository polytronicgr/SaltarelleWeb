﻿namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTextContentElement : SVGGraphicsElement
	{
		internal SVGTextContentElement()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, Action listener)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(SVGTextContentElementEvents type, IEventListener listener, bool capture)
		{
		}

		public int GetCharNumAtPosition(SVGPoint point)
		{
			return 0;
		}

		public double GetComputedTextLength()
		{
			return 0;
		}

		public SVGPoint GetEndPositionOfChar(int charnum)
		{
			return default(SVGPoint);
		}

		public SVGRect GetExtentOfChar(int charnum)
		{
			return default(SVGRect);
		}

		public int GetNumberOfChars()
		{
			return 0;
		}

		public double GetRotationOfChar(int charnum)
		{
			return 0;
		}

		public SVGPoint GetStartPositionOfChar(int charnum)
		{
			return default(SVGPoint);
		}

		public double GetSubStringLength(int charnum, int nchars)
		{
			return 0;
		}

		[FieldProperty]
		public SVGAnimatedEnumeration<SVGLengthAdjust> LengthAdjust
		{
			get {
				return default(SVGAnimatedEnumeration<SVGLengthAdjust>);
			}
		}

		[Name("LENGTHADJUST_SPACING")]
		public const ushort LENGTHADJUST_SPACING = 1;

		[Name("LENGTHADJUST_SPACINGANDGLYPHS")]
		public const ushort LENGTHADJUST_SPACINGANDGLYPHS = 2;

		[Name("LENGTHADJUST_UNKNOWN")]
		public const ushort LENGTHADJUST_UNKNOWN = 0;

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(SVGTextContentElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void SelectSubString(int charnum, int nchars)
		{
		}

		[FieldProperty]
		public SVGAnimatedLength TextLength
		{
			get {
				return default(SVGAnimatedLength);
			}
		}
	}
}
