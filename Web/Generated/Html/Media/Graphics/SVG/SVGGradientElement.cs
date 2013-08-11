﻿// SVGGradientElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGGradientElement : SVGElement {
		internal SVGGradientElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedTransformList GradientTransform {
			get { return default(SVGAnimatedTransformList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> GradientUnits {
			get { return default(SVGAnimatedEnumeration<SVGUnitType>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get { return default(SVGAnimatedString); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGSpreadMethod> SpreadMethod {
			get { return default(SVGAnimatedEnumeration<SVGSpreadMethod>); }
		}

		[ScriptName("SVG_SPREADMETHOD_PAD")]
		public const ushort SVG_SPREADMETHOD_PAD = 1;

		[ScriptName("SVG_SPREADMETHOD_REFLECT")]
		public const ushort SVG_SPREADMETHOD_REFLECT = 2;

		[ScriptName("SVG_SPREADMETHOD_REPEAT")]
		public const ushort SVG_SPREADMETHOD_REPEAT = 3;

		[ScriptName("SVG_SPREADMETHOD_UNKNOWN")]
		public const ushort SVG_SPREADMETHOD_UNKNOWN = 0;

		[ScriptName("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[ScriptName("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[ScriptName("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;
	}
}