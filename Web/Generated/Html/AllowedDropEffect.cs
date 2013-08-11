﻿// AllowedDropEffect.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, NamedValues]
	public enum AllowedDropEffect {
		None,
		Copy,
		CopyLink,
		CopyMove,
		Link,
		LinkMove,
		Move,
		All,
		Uninitialized,
	}
}