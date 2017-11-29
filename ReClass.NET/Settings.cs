﻿using System.Drawing;
using ReClassNET.Util;

namespace ReClassNET
{
	public class Settings
	{
		// Application Settings

		public string LastProcess { get; set; } = string.Empty;

		public bool StayOnTop { get; set; } = false;

		// Node Drawing Settings

		public bool ShowNodeAddress { get; set; } = true;

		public bool ShowNodeOffset { get; set; } = true;

		public bool ShowNodeText { get; set; } = true;

		public bool HighlightChangedValues { get; set; } = true;

		// Comment Drawing Settings

		public bool ShowCommentFloat { get; set; } = true;

		public bool ShowCommentInteger { get; set; } = true;

		public bool ShowCommentPointer { get; set; } = true;

		public bool ShowCommentRtti { get; set; } = true;

		public bool ShowCommentSymbol { get; set; } = true;

		public bool ShowCommentString { get; set; } = true;

		public bool ShowCommentPluginInfo { get; set; } = true;

		// Colors

		public Color BackgroundColor { get; set; } = Color.FromArgb(255, 255, 255);

		public Color SelectedColor { get; set; } = Color.FromArgb(240, 240, 240);

		public Color HiddenColor { get; set; } = Color.FromArgb(240, 240, 240);

		public Color OffsetColor { get; set; } = Color.FromArgb(255, 0, 0);

		public Color AddressColor { get; set; } = Color.FromArgb(0, 200, 0);

		public Color HexColor { get; set; } = Color.FromArgb(0, 0, 0);

		public Color TypeColor { get; set; } = Color.FromArgb(0, 0, 255);

		public Color NameColor { get; set; } = Color.FromArgb(32, 32, 128);

		public Color ValueColor { get; set; } = Color.FromArgb(255, 128, 0);

		public Color IndexColor { get; set; } = Color.FromArgb(32, 200, 200);

		public Color CommentColor { get; set; } = Color.FromArgb(0, 200, 0);

		public Color TextColor { get; set; } = Color.FromArgb(0, 0, 255);

		public Color VTableColor { get; set; } = Color.FromArgb(0, 255, 0);

		public Color PluginColor { get; set; } = Color.FromArgb(255, 0, 255);

		private static readonly Color[] highlightColors = {
			Color.Aqua, Color.Aquamarine, Color.Blue, Color.BlueViolet, Color.Chartreuse, Color.Crimson, Color.LawnGreen, Color.Magenta
		};
		public Color HighlightColor => highlightColors[Program.GlobalRandom.Next(highlightColors.Length)];

		// Type Definitions

		public string TypePadding { get; set; } = "char";

		public string TypeBool { get; set; } = "bool";

		public string TypeInt8 { get; set; } = "int8_t";
		public string TypeInt16 { get; set; } = "int16_t";
		public string TypeInt32 { get; set; } = "int32_t";
		public string TypeInt64 { get; set; } = "int64_t";

		public string TypeUInt8 { get; set; } = "uint8_t";
		public string TypeUInt16 { get; set; } = "uint16_t";
		public string TypeUInt32 { get; set; } = "uint32_t";
		public string TypeUInt64 { get; set; } = "uint64_t";

		public string TypeFloat { get; set; } = "float";
		public string TypeDouble { get; set; } = "double";

		public string TypeVector2 { get; set; } = "Vector2";
		public string TypeVector3 { get; set; } = "Vector3";
		public string TypeVector4 { get; set; } = "Vector4";

		public string TypeMatrix3x3 { get; set; } = "Matrix3x3";
		public string TypeMatrix3x4 { get; set; } = "Matrix3x4";
		public string TypeMatrix4x4 { get; set; } = "Matrix4x4";

		public string TypeUTF8Text { get; set; } = "char";
		public string TypeUTF8TextPtr { get; set; } = "char*";
		public string TypeUTF16Text { get; set; } = "wchar_t"; // Should be char16_t, but this type isn't well supported at the moment.
		public string TypeUTF16TextPtr { get; set; } = "wchar_t*";
		public string TypeUTF32Text { get; set; } = "char32_t";
		public string TypeUTF32TextPtr { get; set; } = "char32_t*";

		public string TypeFunctionPtr { get; set; } = "void*";

		public CustomConfig CustomData { get; } = new CustomConfig();

		public Settings Clone() => MemberwiseClone() as Settings;
	}
}
