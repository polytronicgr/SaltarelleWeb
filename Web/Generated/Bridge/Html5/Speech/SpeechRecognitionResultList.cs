﻿namespace Bridge.Html5.Speech
{
	[Namespace("false"), External]
	public partial class SpeechRecognitionResultList
	{
		internal extern SpeechRecognitionResultList();

		public extern SpeechRecognitionResult this[int index]
		{
			get;
		}

		public extern SpeechRecognitionResult Item(int index);

		public readonly int Length;
	}
}