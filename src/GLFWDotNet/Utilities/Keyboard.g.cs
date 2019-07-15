using System;

namespace GLFWDotNet.Utilities
{
	public partial class Keyboard
	{
		private readonly bool[] keyMap = new bool[107];

		private int GetKeyMapIndex(Keys key)
		{
			switch(key)
			{
				case Keys.Space: return 0;
				case Keys.D0: return 1;
				case Keys.D1: return 2;
				case Keys.D2: return 3;
				case Keys.D3: return 4;
				case Keys.D4: return 5;
				case Keys.D5: return 6;
				case Keys.D6: return 7;
				case Keys.D7: return 8;
				case Keys.D8: return 9;
				case Keys.D9: return 10;
				case Keys.A: return 11;
				case Keys.B: return 12;
				case Keys.C: return 13;
				case Keys.D: return 14;
				case Keys.E: return 15;
				case Keys.F: return 16;
				case Keys.G: return 17;
				case Keys.H: return 18;
				case Keys.I: return 19;
				case Keys.J: return 20;
				case Keys.K: return 21;
				case Keys.L: return 22;
				case Keys.M: return 23;
				case Keys.N: return 24;
				case Keys.O: return 25;
				case Keys.P: return 26;
				case Keys.Q: return 27;
				case Keys.R: return 28;
				case Keys.S: return 29;
				case Keys.T: return 30;
				case Keys.U: return 31;
				case Keys.V: return 32;
				case Keys.W: return 33;
				case Keys.X: return 34;
				case Keys.Y: return 35;
				case Keys.Z: return 36;
				case Keys.Escape: return 37;
				case Keys.Enter: return 38;
				case Keys.Tab: return 39;
				case Keys.Backspace: return 40;
				case Keys.Insert: return 41;
				case Keys.Delete: return 42;
				case Keys.Right: return 43;
				case Keys.Left: return 44;
				case Keys.Down: return 45;
				case Keys.Up: return 46;
				case Keys.PageUp: return 47;
				case Keys.PageDown: return 48;
				case Keys.Home: return 49;
				case Keys.End: return 50;
				case Keys.CapsLock: return 51;
				case Keys.ScrollLock: return 52;
				case Keys.NumLock: return 53;
				case Keys.PrintScreen: return 54;
				case Keys.Pause: return 55;
				case Keys.F1: return 56;
				case Keys.F2: return 57;
				case Keys.F3: return 58;
				case Keys.F4: return 59;
				case Keys.F5: return 60;
				case Keys.F6: return 61;
				case Keys.F7: return 62;
				case Keys.F8: return 63;
				case Keys.F9: return 64;
				case Keys.F10: return 65;
				case Keys.F11: return 66;
				case Keys.F12: return 67;
				case Keys.F13: return 68;
				case Keys.F14: return 69;
				case Keys.F15: return 70;
				case Keys.F16: return 71;
				case Keys.F17: return 72;
				case Keys.F18: return 73;
				case Keys.F19: return 74;
				case Keys.F20: return 75;
				case Keys.F21: return 76;
				case Keys.F22: return 77;
				case Keys.F23: return 78;
				case Keys.F24: return 79;
				case Keys.F25: return 80;
				case Keys.KeyPad0: return 81;
				case Keys.KeyPad1: return 82;
				case Keys.KeyPad2: return 83;
				case Keys.KeyPad3: return 84;
				case Keys.KeyPad4: return 85;
				case Keys.KeyPad5: return 86;
				case Keys.KeyPad6: return 87;
				case Keys.KeyPad7: return 88;
				case Keys.KeyPad8: return 89;
				case Keys.KeyPad9: return 90;
				case Keys.KeyPadDecimal: return 91;
				case Keys.KeyPadDivide: return 92;
				case Keys.KeyPadMultiply: return 93;
				case Keys.KeyPadSubtract: return 94;
				case Keys.KeyPadAdd: return 95;
				case Keys.KeyPadEnter: return 96;
				case Keys.KeyPadEqual: return 97;
				case Keys.LeftShift: return 98;
				case Keys.LeftControl: return 99;
				case Keys.LeftAlt: return 100;
				case Keys.LeftSuper: return 101;
				case Keys.RightShift: return 102;
				case Keys.RightControl: return 103;
				case Keys.RightAlt: return 104;
				case Keys.RightSuper: return 105;
				case Keys.Menu: return 106;
			}

			return -1;
		}
	}
}
