﻿namespace Bridge.Html5.Media.Audio
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum BiquadFilterType
	{
		[Name("0")]
		_0,
		[Name("1")]
		_1,
		[Name("2")]
		_2,
		[Name("3")]
		_3,
		[Name("4")]
		_4,
		[Name("5")]
		_5,
		[Name("6")]
		_6,
		[Name("7")]
		_7,
		Allpass,
		Bandpass,
		Highpass,
		Highshelf,
		Lowpass,
		Lowshelf,
		Notch,
		Peaking
	}
}