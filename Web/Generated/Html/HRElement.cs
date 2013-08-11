﻿// HRElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HR'"), ScriptName("Element")]
	public partial class HRElement : Element {
		internal HRElement() {
		}

		[IntrinsicProperty]
		public string Align {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Color {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public bool NoShade {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Size {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Width {
			get { return null; }
			set { }
		}
	}
}