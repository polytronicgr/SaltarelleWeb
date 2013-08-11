﻿// ModElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'INS' || {this}.tagName === 'DEL')"), ScriptName("Element")]
	public partial class ModElement : Element {
		internal ModElement() {
		}

		[IntrinsicProperty]
		public string Cite {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string DateTime {
			get { return null; }
			set { }
		}
	}
}