// Copyright (c) 2016 - 2017 Zachary Snow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace GLFWDotNet
{
	public static partial class GLFW
	{
		private const string LibraryX86 = "glfw3_x86.dll";
		private const string LibraryX64 = "glfw3_x64.dll";

		public const int VERSION_MAJOR = 3;
		public const int VERSION_MINOR = 2;
		public const int VERSION_REVISION = 1;
		public const int TRUE = 1;
		public const int FALSE = 0;
		public const int RELEASE = 0;
		public const int PRESS = 1;
		public const int REPEAT = 2;
		public const int KEY_UNKNOWN = -1;
		public const int KEY_SPACE = 32;
		public const int KEY_0 = 48;
		public const int KEY_1 = 49;
		public const int KEY_2 = 50;
		public const int KEY_3 = 51;
		public const int KEY_4 = 52;
		public const int KEY_5 = 53;
		public const int KEY_6 = 54;
		public const int KEY_7 = 55;
		public const int KEY_8 = 56;
		public const int KEY_9 = 57;
		public const int KEY_A = 65;
		public const int KEY_B = 66;
		public const int KEY_C = 67;
		public const int KEY_D = 68;
		public const int KEY_E = 69;
		public const int KEY_F = 70;
		public const int KEY_G = 71;
		public const int KEY_H = 72;
		public const int KEY_I = 73;
		public const int KEY_J = 74;
		public const int KEY_K = 75;
		public const int KEY_L = 76;
		public const int KEY_M = 77;
		public const int KEY_N = 78;
		public const int KEY_O = 79;
		public const int KEY_P = 80;
		public const int KEY_Q = 81;
		public const int KEY_R = 82;
		public const int KEY_S = 83;
		public const int KEY_T = 84;
		public const int KEY_U = 85;
		public const int KEY_V = 86;
		public const int KEY_W = 87;
		public const int KEY_X = 88;
		public const int KEY_Y = 89;
		public const int KEY_Z = 90;
		public const int KEY_ESCAPE = 256;
		public const int KEY_ENTER = 257;
		public const int KEY_TAB = 258;
		public const int KEY_BACKSPACE = 259;
		public const int KEY_INSERT = 260;
		public const int KEY_DELETE = 261;
		public const int KEY_RIGHT = 262;
		public const int KEY_LEFT = 263;
		public const int KEY_DOWN = 264;
		public const int KEY_UP = 265;
		public const int KEY_PAGE_UP = 266;
		public const int KEY_PAGE_DOWN = 267;
		public const int KEY_HOME = 268;
		public const int KEY_END = 269;
		public const int KEY_CAPS_LOCK = 280;
		public const int KEY_SCROLL_LOCK = 281;
		public const int KEY_NUM_LOCK = 282;
		public const int KEY_PRINT_SCREEN = 283;
		public const int KEY_PAUSE = 284;
		public const int KEY_F1 = 290;
		public const int KEY_F2 = 291;
		public const int KEY_F3 = 292;
		public const int KEY_F4 = 293;
		public const int KEY_F5 = 294;
		public const int KEY_F6 = 295;
		public const int KEY_F7 = 296;
		public const int KEY_F8 = 297;
		public const int KEY_F9 = 298;
		public const int KEY_F10 = 299;
		public const int KEY_F11 = 300;
		public const int KEY_F12 = 301;
		public const int KEY_F13 = 302;
		public const int KEY_F14 = 303;
		public const int KEY_F15 = 304;
		public const int KEY_F16 = 305;
		public const int KEY_F17 = 306;
		public const int KEY_F18 = 307;
		public const int KEY_F19 = 308;
		public const int KEY_F20 = 309;
		public const int KEY_F21 = 310;
		public const int KEY_F22 = 311;
		public const int KEY_F23 = 312;
		public const int KEY_F24 = 313;
		public const int KEY_F25 = 314;
		public const int KEY_KP_0 = 320;
		public const int KEY_KP_1 = 321;
		public const int KEY_KP_2 = 322;
		public const int KEY_KP_3 = 323;
		public const int KEY_KP_4 = 324;
		public const int KEY_KP_5 = 325;
		public const int KEY_KP_6 = 326;
		public const int KEY_KP_7 = 327;
		public const int KEY_KP_8 = 328;
		public const int KEY_KP_9 = 329;
		public const int KEY_KP_DECIMAL = 330;
		public const int KEY_KP_DIVIDE = 331;
		public const int KEY_KP_MULTIPLY = 332;
		public const int KEY_KP_SUBTRACT = 333;
		public const int KEY_KP_ADD = 334;
		public const int KEY_KP_ENTER = 335;
		public const int KEY_KP_EQUAL = 336;
		public const int KEY_LEFT_SHIFT = 340;
		public const int KEY_LEFT_CONTROL = 341;
		public const int KEY_LEFT_ALT = 342;
		public const int KEY_LEFT_SUPER = 343;
		public const int KEY_RIGHT_SHIFT = 344;
		public const int KEY_RIGHT_CONTROL = 345;
		public const int KEY_RIGHT_ALT = 346;
		public const int KEY_RIGHT_SUPER = 347;
		public const int KEY_MENU = 348;
		public const int KEY_LAST = KEY_MENU;
		public const int MOD_SHIFT = 0x0001;
		public const int MOD_CONTROL = 0x0002;
		public const int MOD_ALT = 0x0004;
		public const int MOD_SUPER = 0x0008;
		public const int MOUSE_BUTTON_1 = 0;
		public const int MOUSE_BUTTON_2 = 1;
		public const int MOUSE_BUTTON_3 = 2;
		public const int MOUSE_BUTTON_4 = 3;
		public const int MOUSE_BUTTON_5 = 4;
		public const int MOUSE_BUTTON_6 = 5;
		public const int MOUSE_BUTTON_7 = 6;
		public const int MOUSE_BUTTON_8 = 7;
		public const int MOUSE_BUTTON_LAST = MOUSE_BUTTON_8;
		public const int MOUSE_BUTTON_LEFT = MOUSE_BUTTON_1;
		public const int MOUSE_BUTTON_RIGHT = MOUSE_BUTTON_2;
		public const int MOUSE_BUTTON_MIDDLE = MOUSE_BUTTON_3;
		public const int JOYSTICK_1 = 0;
		public const int JOYSTICK_2 = 1;
		public const int JOYSTICK_3 = 2;
		public const int JOYSTICK_4 = 3;
		public const int JOYSTICK_5 = 4;
		public const int JOYSTICK_6 = 5;
		public const int JOYSTICK_7 = 6;
		public const int JOYSTICK_8 = 7;
		public const int JOYSTICK_9 = 8;
		public const int JOYSTICK_10 = 9;
		public const int JOYSTICK_11 = 10;
		public const int JOYSTICK_12 = 11;
		public const int JOYSTICK_13 = 12;
		public const int JOYSTICK_14 = 13;
		public const int JOYSTICK_15 = 14;
		public const int JOYSTICK_16 = 15;
		public const int JOYSTICK_LAST = JOYSTICK_16;
		public const int NOT_INITIALIZED = 0x00010001;
		public const int NO_CURRENT_CONTEXT = 0x00010002;
		public const int INVALID_ENUM = 0x00010003;
		public const int INVALID_VALUE = 0x00010004;
		public const int OUT_OF_MEMORY = 0x00010005;
		public const int API_UNAVAILABLE = 0x00010006;
		public const int VERSION_UNAVAILABLE = 0x00010007;
		public const int PLATFORM_ERROR = 0x00010008;
		public const int FORMAT_UNAVAILABLE = 0x00010009;
		public const int NO_WINDOW_CONTEXT = 0x0001000A;
		public const int FOCUSED = 0x00020001;
		public const int ICONIFIED = 0x00020002;
		public const int RESIZABLE = 0x00020003;
		public const int VISIBLE = 0x00020004;
		public const int DECORATED = 0x00020005;
		public const int AUTO_ICONIFY = 0x00020006;
		public const int FLOATING = 0x00020007;
		public const int MAXIMIZED = 0x00020008;
		public const int RED_BITS = 0x00021001;
		public const int GREEN_BITS = 0x00021002;
		public const int BLUE_BITS = 0x00021003;
		public const int ALPHA_BITS = 0x00021004;
		public const int DEPTH_BITS = 0x00021005;
		public const int STENCIL_BITS = 0x00021006;
		public const int ACCUM_RED_BITS = 0x00021007;
		public const int ACCUM_GREEN_BITS = 0x00021008;
		public const int ACCUM_BLUE_BITS = 0x00021009;
		public const int ACCUM_ALPHA_BITS = 0x0002100A;
		public const int AUX_BUFFERS = 0x0002100B;
		public const int STEREO = 0x0002100C;
		public const int SAMPLES = 0x0002100D;
		public const int SRGB_CAPABLE = 0x0002100E;
		public const int REFRESH_RATE = 0x0002100F;
		public const int DOUBLEBUFFER = 0x00021010;
		public const int CLIENT_API = 0x00022001;
		public const int CONTEXT_VERSION_MAJOR = 0x00022002;
		public const int CONTEXT_VERSION_MINOR = 0x00022003;
		public const int CONTEXT_REVISION = 0x00022004;
		public const int CONTEXT_ROBUSTNESS = 0x00022005;
		public const int OPENGL_FORWARD_COMPAT = 0x00022006;
		public const int OPENGL_DEBUG_CONTEXT = 0x00022007;
		public const int OPENGL_PROFILE = 0x00022008;
		public const int CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
		public const int CONTEXT_NO_ERROR = 0x0002200A;
		public const int CONTEXT_CREATION_API = 0x0002200B;
		public const int NO_API = 0;
		public const int OPENGL_API = 0x00030001;
		public const int OPENGL_ES_API = 0x00030002;
		public const int NO_ROBUSTNESS = 0;
		public const int NO_RESET_NOTIFICATION = 0x00031001;
		public const int LOSE_CONTEXT_ON_RESET = 0x00031002;
		public const int OPENGL_ANY_PROFILE = 0;
		public const int OPENGL_CORE_PROFILE = 0x00032001;
		public const int OPENGL_COMPAT_PROFILE = 0x00032002;
		public const int CURSOR = 0x00033001;
		public const int STICKY_KEYS = 0x00033002;
		public const int STICKY_MOUSE_BUTTONS = 0x00033003;
		public const int CURSOR_NORMAL = 0x00034001;
		public const int CURSOR_HIDDEN = 0x00034002;
		public const int CURSOR_DISABLED = 0x00034003;
		public const int ANY_RELEASE_BEHAVIOR = 0;
		public const int RELEASE_BEHAVIOR_FLUSH = 0x00035001;
		public const int RELEASE_BEHAVIOR_NONE = 0x00035002;
		public const int NATIVE_CONTEXT_API = 0x00036001;
		public const int EGL_CONTEXT_API = 0x00036002;
		public const int ARROW_CURSOR = 0x00036001;
		public const int IBEAM_CURSOR = 0x00036002;
		public const int CROSSHAIR_CURSOR = 0x00036003;
		public const int HAND_CURSOR = 0x00036004;
		public const int HRESIZE_CURSOR = 0x00036005;
		public const int VRESIZE_CURSOR = 0x00036006;
		public const int CONNECTED = 0x00040001;
		public const int DISCONNECTED = 0x00040002;
		public const int DONT_CARE = -1;

		public struct VidMode
		{
			public int Width;
			public int Height;
			public int RedBits;
			public int GreenBits;
			public int BlueBits;
			public int Refreshrate;
		}

		public struct GammaRamp
		{
			public ushort[] Red;
			public ushort[] Green;
			public ushort[] Blue;
			public uint Size;
		}

		public struct Image
		{
			public int Width;
			public int Height;
			public string Pixels;
		}

		/// <summary>
		/// This is the function signature for error callback functions.
		/// </summary>
		/// <param name="error">
		/// An [error code](@ref errors).
		/// </param>
		/// <param name="description">
		/// A UTF-8 encoded string describing the error.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void ErrorFun(int error, string description);

		/// <summary>
		/// This is the function signature for window position callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that was moved.
		/// </param>
		/// <param name="xpos">
		/// The new x-coordinate, in screen coordinates, of the
		/// upper-left corner of the client area of the window.
		/// </param>
		/// <param name="ypos">
		/// The new y-coordinate, in screen coordinates, of the
		/// upper-left corner of the client area of the window.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowPosFun(IntPtr window, int xpos, int ypos);

		/// <summary>
		/// This is the function signature for window size callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that was resized.
		/// </param>
		/// <param name="width">
		/// The new width, in screen coordinates, of the window.
		/// </param>
		/// <param name="height">
		/// The new height, in screen coordinates, of the window.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowSizeFun(IntPtr window, int width, int height);

		/// <summary>
		/// This is the function signature for window close callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that the user attempted to close.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowCloseFun(IntPtr window);

		/// <summary>
		/// This is the function signature for window refresh callback functions.
		/// </summary>
		/// <param name="window">
		/// The window whose content needs to be refreshed.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowRefreshFun(IntPtr window);

		/// <summary>
		/// This is the function signature for window focus callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that gained or lost input focus.
		/// </param>
		/// <param name="focused">
		/// `GLFW_TRUE` if the window was given input focus, or
		/// `GLFW_FALSE` if it lost it.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowFocusFun(IntPtr window, int focused);

		/// <summary>
		/// This is the function signature for window iconify/restore callback
		/// functions.
		/// </summary>
		/// <param name="window">
		/// The window that was iconified or restored.
		/// </param>
		/// <param name="iconified">
		/// `GLFW_TRUE` if the window was iconified, or
		/// `GLFW_FALSE` if it was restored.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowIconifyFun(IntPtr window, int iconified);

		/// <summary>
		/// This is the function signature for framebuffer resize callback
		/// functions.
		/// </summary>
		/// <param name="window">
		/// The window whose framebuffer was resized.
		/// </param>
		/// <param name="width">
		/// The new width, in pixels, of the framebuffer.
		/// </param>
		/// <param name="height">
		/// The new height, in pixels, of the framebuffer.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void FramebufferSizeFun(IntPtr window, int width, int height);

		/// <summary>
		/// This is the function signature for mouse button callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="button">
		/// The [mouse button](@ref buttons) that was pressed or
		/// released.
		/// </param>
		/// <param name="action">
		/// One of `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </param>
		/// <param name="mods">
		/// Bit field describing which [modifier keys](@ref mods) were
		/// held down.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void MouseButtonFun(IntPtr window, int button, int action, int mods);

		/// <summary>
		/// This is the function signature for cursor position callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="xpos">
		/// The new cursor x-coordinate, relative to the left edge of
		/// the client area.
		/// </param>
		/// <param name="ypos">
		/// The new cursor y-coordinate, relative to the top edge of the
		/// client area.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void CursorPosFun(IntPtr window, double xpos, double ypos);

		/// <summary>
		/// This is the function signature for cursor enter/leave callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="entered">
		/// `GLFW_TRUE` if the cursor entered the window's client
		/// area, or `GLFW_FALSE` if it left it.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void CursorEnterFun(IntPtr window, int entered);

		/// <summary>
		/// This is the function signature for scroll callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="xoffset">
		/// The scroll offset along the x-axis.
		/// </param>
		/// <param name="yoffset">
		/// The scroll offset along the y-axis.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void ScrollFun(IntPtr window, double xoffset, double yoffset);

		/// <summary>
		/// This is the function signature for keyboard key callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="key">
		/// The [keyboard key](@ref keys) that was pressed or released.
		/// </param>
		/// <param name="scancode">
		/// The system-specific scancode of the key.
		/// </param>
		/// <param name="action">
		/// `GLFW_PRESS`, `GLFW_RELEASE` or `GLFW_REPEAT`.
		/// </param>
		/// <param name="mods">
		/// Bit field describing which [modifier keys](@ref mods) were
		/// held down.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void KeyFun(IntPtr window, int key, int scancode, int action, int mods);

		/// <summary>
		/// This is the function signature for Unicode character callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="codepoint">
		/// The Unicode code point of the character.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void CharFun(IntPtr window, uint codepoint);

		/// <summary>
		/// This is the function signature for Unicode character with modifiers callback
		/// functions.  It is called for each input character, regardless of what
		/// modifier keys are held down.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="codepoint">
		/// The Unicode code point of the character.
		/// </param>
		/// <param name="mods">
		/// Bit field describing which [modifier keys](@ref mods) were
		/// held down.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void CharModsFun(IntPtr window, uint codepoint, int mods);

		/// <summary>
		/// This is the function signature for file drop callbacks.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="count">
		/// The number of dropped files.
		/// </param>
		/// <param name="paths">
		/// The UTF-8 encoded file and/or directory path names.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void DropFun(IntPtr window, int count, string[] paths);

		/// <summary>
		/// This is the function signature for monitor configuration callback functions.
		/// </summary>
		/// <param name="monitor">
		/// The monitor that was connected or disconnected.
		/// </param>
		/// <param name="event">
		/// One of `GLFW_CONNECTED` or `GLFW_DISCONNECTED`.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void MonitorFun(IntPtr monitor, int @event);

		/// <summary>
		/// This is the function signature for joystick configuration callback
		/// functions.
		/// </summary>
		/// <param name="joy">
		/// The joystick that was connected or disconnected.
		/// </param>
		/// <param name="event">
		/// One of `GLFW_CONNECTED` or `GLFW_DISCONNECTED`.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void JoystickFun(int joy, int @event);

		static class X86
		{
			[DllImport(LibraryX86, EntryPoint = "glfwInit", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int Init();

			[DllImport(LibraryX86, EntryPoint = "glfwTerminate", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void Terminate();

			[DllImport(LibraryX86, EntryPoint = "glfwGetVersion", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetVersion(out int major, out int minor, out int rev);

			[DllImport(LibraryX86, EntryPoint = "glfwGetVersionString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetVersionString();

			[DllImport(LibraryX86, EntryPoint = "glfwSetErrorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ErrorFun SetErrorCallback(ErrorFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwGetMonitors", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr[] GetMonitors(out int count);

			[DllImport(LibraryX86, EntryPoint = "glfwGetPrimaryMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetPrimaryMonitor();

			[DllImport(LibraryX86, EntryPoint = "glfwGetMonitorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

			[DllImport(LibraryX86, EntryPoint = "glfwGetMonitorPhysicalSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

			[DllImport(LibraryX86, EntryPoint = "glfwGetMonitorName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetMonitorName(IntPtr monitor);

			[DllImport(LibraryX86, EntryPoint = "glfwSetMonitorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern MonitorFun SetMonitorCallback(MonitorFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwGetVideoModes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern VidMode GetVideoModes(IntPtr monitor, out int count);

			[DllImport(LibraryX86, EntryPoint = "glfwGetVideoMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern VidMode GetVideoMode(IntPtr monitor);

			[DllImport(LibraryX86, EntryPoint = "glfwSetGamma", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetGamma(IntPtr monitor, float gamma);

			[DllImport(LibraryX86, EntryPoint = "glfwGetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern GammaRamp GetGammaRamp(IntPtr monitor);

			[DllImport(LibraryX86, EntryPoint = "glfwSetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetGammaRamp(IntPtr monitor, GammaRamp ramp);

			[DllImport(LibraryX86, EntryPoint = "glfwDefaultWindowHints", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void DefaultWindowHints();

			[DllImport(LibraryX86, EntryPoint = "glfwWindowHint", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void WindowHint(int hint, int value);

			[DllImport(LibraryX86, EntryPoint = "glfwCreateWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

			[DllImport(LibraryX86, EntryPoint = "glfwDestroyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void DestroyWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int WindowShouldClose(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowShouldClose(IntPtr window, int value);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowTitle", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowTitle(IntPtr window, string title);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowIcon", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowIcon(IntPtr window, int count, Image images);

			[DllImport(LibraryX86, EntryPoint = "glfwGetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetWindowPos(IntPtr window, out int xpos, out int ypos);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowPos(IntPtr window, int xpos, int ypos);

			[DllImport(LibraryX86, EntryPoint = "glfwGetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetWindowSize(IntPtr window, out int width, out int height);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowSizeLimits", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowAspectRatio", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowAspectRatio(IntPtr window, int numer, int denom);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowSize(IntPtr window, int width, int height);

			[DllImport(LibraryX86, EntryPoint = "glfwGetFramebufferSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetFramebufferSize(IntPtr window, out int width, out int height);

			[DllImport(LibraryX86, EntryPoint = "glfwGetWindowFrameSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

			[DllImport(LibraryX86, EntryPoint = "glfwIconifyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void IconifyWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwRestoreWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void RestoreWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwMaximizeWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void MaximizeWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwShowWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void ShowWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwHideWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void HideWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwFocusWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void FocusWindow(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwGetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetWindowMonitor(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

			[DllImport(LibraryX86, EntryPoint = "glfwGetWindowAttrib", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetWindowAttrib(IntPtr window, int attrib);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowUserPointer(IntPtr window, IntPtr pointer);

			[DllImport(LibraryX86, EntryPoint = "glfwGetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetWindowUserPointer(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowPosFun SetWindowPosCallback(IntPtr window, WindowPosFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowSizeFun SetWindowSizeCallback(IntPtr window, WindowSizeFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowCloseCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowCloseFun SetWindowCloseCallback(IntPtr window, WindowCloseFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowRefreshCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowRefreshFun SetWindowRefreshCallback(IntPtr window, WindowRefreshFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowFocusCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowFocusFun SetWindowFocusCallback(IntPtr window, WindowFocusFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetWindowIconifyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowIconifyFun SetWindowIconifyCallback(IntPtr window, WindowIconifyFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetFramebufferSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern FramebufferSizeFun SetFramebufferSizeCallback(IntPtr window, FramebufferSizeFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwPollEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void PollEvents();

			[DllImport(LibraryX86, EntryPoint = "glfwWaitEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void WaitEvents();

			[DllImport(LibraryX86, EntryPoint = "glfwWaitEventsTimeout", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void WaitEventsTimeout(double timeout);

			[DllImport(LibraryX86, EntryPoint = "glfwPostEmptyEvent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void PostEmptyEvent();

			[DllImport(LibraryX86, EntryPoint = "glfwGetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetInputMode(IntPtr window, int mode);

			[DllImport(LibraryX86, EntryPoint = "glfwSetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetInputMode(IntPtr window, int mode, int value);

			[DllImport(LibraryX86, EntryPoint = "glfwGetKeyName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetKeyName(int key, int scancode);

			[DllImport(LibraryX86, EntryPoint = "glfwGetKey", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetKey(IntPtr window, int key);

			[DllImport(LibraryX86, EntryPoint = "glfwGetMouseButton", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetMouseButton(IntPtr window, int button);

			[DllImport(LibraryX86, EntryPoint = "glfwGetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetCursorPos(IntPtr window, out double xpos, out double ypos);

			[DllImport(LibraryX86, EntryPoint = "glfwSetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetCursorPos(IntPtr window, double xpos, double ypos);

			[DllImport(LibraryX86, EntryPoint = "glfwCreateCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr CreateCursor(Image image, int xhot, int yhot);

			[DllImport(LibraryX86, EntryPoint = "glfwCreateStandardCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr CreateStandardCursor(int shape);

			[DllImport(LibraryX86, EntryPoint = "glfwDestroyCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void DestroyCursor(IntPtr cursor);

			[DllImport(LibraryX86, EntryPoint = "glfwSetCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetCursor(IntPtr window, IntPtr cursor);

			[DllImport(LibraryX86, EntryPoint = "glfwSetKeyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern KeyFun SetKeyCallback(IntPtr window, KeyFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetCharCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CharFun SetCharCallback(IntPtr window, CharFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetCharModsCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CharModsFun SetCharModsCallback(IntPtr window, CharModsFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetMouseButtonCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern MouseButtonFun SetMouseButtonCallback(IntPtr window, MouseButtonFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetCursorPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CursorPosFun SetCursorPosCallback(IntPtr window, CursorPosFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetCursorEnterCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CursorEnterFun SetCursorEnterCallback(IntPtr window, CursorEnterFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetScrollCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ScrollFun SetScrollCallback(IntPtr window, ScrollFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetDropCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern DropFun SetDropCallback(IntPtr window, DropFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwJoystickPresent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int JoystickPresent(int joy);

			[DllImport(LibraryX86, EntryPoint = "glfwGetJoystickAxes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern float[] GetJoystickAxes(int joy, out int count);

			[DllImport(LibraryX86, EntryPoint = "glfwGetJoystickButtons", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetJoystickButtons(int joy, out int count);

			[DllImport(LibraryX86, EntryPoint = "glfwGetJoystickName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetJoystickName(int joy);

			[DllImport(LibraryX86, EntryPoint = "glfwSetJoystickCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern JoystickFun SetJoystickCallback(JoystickFun cbfun);

			[DllImport(LibraryX86, EntryPoint = "glfwSetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetClipboardString(IntPtr window, string @string);

			[DllImport(LibraryX86, EntryPoint = "glfwGetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetClipboardString(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwGetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern double GetTime();

			[DllImport(LibraryX86, EntryPoint = "glfwSetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetTime(double time);

			[DllImport(LibraryX86, EntryPoint = "glfwGetTimerValue", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ulong GetTimerValue();

			[DllImport(LibraryX86, EntryPoint = "glfwGetTimerFrequency", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ulong GetTimerFrequency();

			[DllImport(LibraryX86, EntryPoint = "glfwMakeContextCurrent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void MakeContextCurrent(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwGetCurrentContext", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetCurrentContext();

			[DllImport(LibraryX86, EntryPoint = "glfwSwapBuffers", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SwapBuffers(IntPtr window);

			[DllImport(LibraryX86, EntryPoint = "glfwSwapInterval", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SwapInterval(int interval);

			[DllImport(LibraryX86, EntryPoint = "glfwExtensionSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int ExtensionSupported(string extension);

			[DllImport(LibraryX86, EntryPoint = "glfwGetProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetProcAddress(string procname);

			[DllImport(LibraryX86, EntryPoint = "glfwVulkanSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int VulkanSupported();

			[DllImport(LibraryX86, EntryPoint = "glfwGetRequiredInstanceExtensions", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string[] GetRequiredInstanceExtensions(out uint count);

			[DllImport(LibraryX86, EntryPoint = "glfwGetInstanceProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetInstanceProcAddress(IntPtr instance, string procname);

			[DllImport(LibraryX86, EntryPoint = "glfwGetPhysicalDevicePresentationSupport", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily);

			[DllImport(LibraryX86, EntryPoint = "glfwCreateWindowSurface", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int CreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface);

		}

		static class X64
		{
			[DllImport(LibraryX64, EntryPoint = "glfwInit", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int Init();

			[DllImport(LibraryX64, EntryPoint = "glfwTerminate", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void Terminate();

			[DllImport(LibraryX64, EntryPoint = "glfwGetVersion", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetVersion(out int major, out int minor, out int rev);

			[DllImport(LibraryX64, EntryPoint = "glfwGetVersionString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetVersionString();

			[DllImport(LibraryX64, EntryPoint = "glfwSetErrorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ErrorFun SetErrorCallback(ErrorFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwGetMonitors", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr[] GetMonitors(out int count);

			[DllImport(LibraryX64, EntryPoint = "glfwGetPrimaryMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetPrimaryMonitor();

			[DllImport(LibraryX64, EntryPoint = "glfwGetMonitorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

			[DllImport(LibraryX64, EntryPoint = "glfwGetMonitorPhysicalSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

			[DllImport(LibraryX64, EntryPoint = "glfwGetMonitorName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetMonitorName(IntPtr monitor);

			[DllImport(LibraryX64, EntryPoint = "glfwSetMonitorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern MonitorFun SetMonitorCallback(MonitorFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwGetVideoModes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern VidMode GetVideoModes(IntPtr monitor, out int count);

			[DllImport(LibraryX64, EntryPoint = "glfwGetVideoMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern VidMode GetVideoMode(IntPtr monitor);

			[DllImport(LibraryX64, EntryPoint = "glfwSetGamma", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetGamma(IntPtr monitor, float gamma);

			[DllImport(LibraryX64, EntryPoint = "glfwGetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern GammaRamp GetGammaRamp(IntPtr monitor);

			[DllImport(LibraryX64, EntryPoint = "glfwSetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetGammaRamp(IntPtr monitor, GammaRamp ramp);

			[DllImport(LibraryX64, EntryPoint = "glfwDefaultWindowHints", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void DefaultWindowHints();

			[DllImport(LibraryX64, EntryPoint = "glfwWindowHint", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void WindowHint(int hint, int value);

			[DllImport(LibraryX64, EntryPoint = "glfwCreateWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

			[DllImport(LibraryX64, EntryPoint = "glfwDestroyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void DestroyWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int WindowShouldClose(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowShouldClose(IntPtr window, int value);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowTitle", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowTitle(IntPtr window, string title);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowIcon", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowIcon(IntPtr window, int count, Image images);

			[DllImport(LibraryX64, EntryPoint = "glfwGetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetWindowPos(IntPtr window, out int xpos, out int ypos);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowPos(IntPtr window, int xpos, int ypos);

			[DllImport(LibraryX64, EntryPoint = "glfwGetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetWindowSize(IntPtr window, out int width, out int height);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowSizeLimits", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowAspectRatio", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowAspectRatio(IntPtr window, int numer, int denom);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowSize(IntPtr window, int width, int height);

			[DllImport(LibraryX64, EntryPoint = "glfwGetFramebufferSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetFramebufferSize(IntPtr window, out int width, out int height);

			[DllImport(LibraryX64, EntryPoint = "glfwGetWindowFrameSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

			[DllImport(LibraryX64, EntryPoint = "glfwIconifyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void IconifyWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwRestoreWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void RestoreWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwMaximizeWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void MaximizeWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwShowWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void ShowWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwHideWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void HideWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwFocusWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void FocusWindow(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwGetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetWindowMonitor(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

			[DllImport(LibraryX64, EntryPoint = "glfwGetWindowAttrib", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetWindowAttrib(IntPtr window, int attrib);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetWindowUserPointer(IntPtr window, IntPtr pointer);

			[DllImport(LibraryX64, EntryPoint = "glfwGetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetWindowUserPointer(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowPosFun SetWindowPosCallback(IntPtr window, WindowPosFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowSizeFun SetWindowSizeCallback(IntPtr window, WindowSizeFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowCloseCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowCloseFun SetWindowCloseCallback(IntPtr window, WindowCloseFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowRefreshCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowRefreshFun SetWindowRefreshCallback(IntPtr window, WindowRefreshFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowFocusCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowFocusFun SetWindowFocusCallback(IntPtr window, WindowFocusFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetWindowIconifyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern WindowIconifyFun SetWindowIconifyCallback(IntPtr window, WindowIconifyFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetFramebufferSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern FramebufferSizeFun SetFramebufferSizeCallback(IntPtr window, FramebufferSizeFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwPollEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void PollEvents();

			[DllImport(LibraryX64, EntryPoint = "glfwWaitEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void WaitEvents();

			[DllImport(LibraryX64, EntryPoint = "glfwWaitEventsTimeout", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void WaitEventsTimeout(double timeout);

			[DllImport(LibraryX64, EntryPoint = "glfwPostEmptyEvent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void PostEmptyEvent();

			[DllImport(LibraryX64, EntryPoint = "glfwGetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetInputMode(IntPtr window, int mode);

			[DllImport(LibraryX64, EntryPoint = "glfwSetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetInputMode(IntPtr window, int mode, int value);

			[DllImport(LibraryX64, EntryPoint = "glfwGetKeyName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetKeyName(int key, int scancode);

			[DllImport(LibraryX64, EntryPoint = "glfwGetKey", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetKey(IntPtr window, int key);

			[DllImport(LibraryX64, EntryPoint = "glfwGetMouseButton", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetMouseButton(IntPtr window, int button);

			[DllImport(LibraryX64, EntryPoint = "glfwGetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void GetCursorPos(IntPtr window, out double xpos, out double ypos);

			[DllImport(LibraryX64, EntryPoint = "glfwSetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetCursorPos(IntPtr window, double xpos, double ypos);

			[DllImport(LibraryX64, EntryPoint = "glfwCreateCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr CreateCursor(Image image, int xhot, int yhot);

			[DllImport(LibraryX64, EntryPoint = "glfwCreateStandardCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr CreateStandardCursor(int shape);

			[DllImport(LibraryX64, EntryPoint = "glfwDestroyCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void DestroyCursor(IntPtr cursor);

			[DllImport(LibraryX64, EntryPoint = "glfwSetCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetCursor(IntPtr window, IntPtr cursor);

			[DllImport(LibraryX64, EntryPoint = "glfwSetKeyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern KeyFun SetKeyCallback(IntPtr window, KeyFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetCharCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CharFun SetCharCallback(IntPtr window, CharFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetCharModsCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CharModsFun SetCharModsCallback(IntPtr window, CharModsFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetMouseButtonCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern MouseButtonFun SetMouseButtonCallback(IntPtr window, MouseButtonFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetCursorPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CursorPosFun SetCursorPosCallback(IntPtr window, CursorPosFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetCursorEnterCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern CursorEnterFun SetCursorEnterCallback(IntPtr window, CursorEnterFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetScrollCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ScrollFun SetScrollCallback(IntPtr window, ScrollFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetDropCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern DropFun SetDropCallback(IntPtr window, DropFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwJoystickPresent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int JoystickPresent(int joy);

			[DllImport(LibraryX64, EntryPoint = "glfwGetJoystickAxes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern float[] GetJoystickAxes(int joy, out int count);

			[DllImport(LibraryX64, EntryPoint = "glfwGetJoystickButtons", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetJoystickButtons(int joy, out int count);

			[DllImport(LibraryX64, EntryPoint = "glfwGetJoystickName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetJoystickName(int joy);

			[DllImport(LibraryX64, EntryPoint = "glfwSetJoystickCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern JoystickFun SetJoystickCallback(JoystickFun cbfun);

			[DllImport(LibraryX64, EntryPoint = "glfwSetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetClipboardString(IntPtr window, string @string);

			[DllImport(LibraryX64, EntryPoint = "glfwGetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string GetClipboardString(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwGetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern double GetTime();

			[DllImport(LibraryX64, EntryPoint = "glfwSetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SetTime(double time);

			[DllImport(LibraryX64, EntryPoint = "glfwGetTimerValue", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ulong GetTimerValue();

			[DllImport(LibraryX64, EntryPoint = "glfwGetTimerFrequency", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern ulong GetTimerFrequency();

			[DllImport(LibraryX64, EntryPoint = "glfwMakeContextCurrent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void MakeContextCurrent(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwGetCurrentContext", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetCurrentContext();

			[DllImport(LibraryX64, EntryPoint = "glfwSwapBuffers", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SwapBuffers(IntPtr window);

			[DllImport(LibraryX64, EntryPoint = "glfwSwapInterval", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern void SwapInterval(int interval);

			[DllImport(LibraryX64, EntryPoint = "glfwExtensionSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int ExtensionSupported(string extension);

			[DllImport(LibraryX64, EntryPoint = "glfwGetProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetProcAddress(string procname);

			[DllImport(LibraryX64, EntryPoint = "glfwVulkanSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int VulkanSupported();

			[DllImport(LibraryX64, EntryPoint = "glfwGetRequiredInstanceExtensions", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern string[] GetRequiredInstanceExtensions(out uint count);

			[DllImport(LibraryX64, EntryPoint = "glfwGetInstanceProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr GetInstanceProcAddress(IntPtr instance, string procname);

			[DllImport(LibraryX64, EntryPoint = "glfwGetPhysicalDevicePresentationSupport", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int GetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily);

			[DllImport(LibraryX64, EntryPoint = "glfwCreateWindowSurface", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
			public static extern int CreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface);

		}

		public static class Delegates
		{
			public delegate int Init();

			public delegate void Terminate();

			public delegate void GetVersion(out int major, out int minor, out int rev);

			public delegate string GetVersionString();

			public delegate ErrorFun SetErrorCallback(ErrorFun cbfun);

			public delegate IntPtr[] GetMonitors(out int count);

			public delegate IntPtr GetPrimaryMonitor();

			public delegate void GetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

			public delegate void GetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

			public delegate string GetMonitorName(IntPtr monitor);

			public delegate MonitorFun SetMonitorCallback(MonitorFun cbfun);

			public delegate VidMode GetVideoModes(IntPtr monitor, out int count);

			public delegate VidMode GetVideoMode(IntPtr monitor);

			public delegate void SetGamma(IntPtr monitor, float gamma);

			public delegate GammaRamp GetGammaRamp(IntPtr monitor);

			public delegate void SetGammaRamp(IntPtr monitor, GammaRamp ramp);

			public delegate void DefaultWindowHints();

			public delegate void WindowHint(int hint, int value);

			public delegate IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

			public delegate void DestroyWindow(IntPtr window);

			public delegate int WindowShouldClose(IntPtr window);

			public delegate void SetWindowShouldClose(IntPtr window, int value);

			public delegate void SetWindowTitle(IntPtr window, string title);

			public delegate void SetWindowIcon(IntPtr window, int count, Image images);

			public delegate void GetWindowPos(IntPtr window, out int xpos, out int ypos);

			public delegate void SetWindowPos(IntPtr window, int xpos, int ypos);

			public delegate void GetWindowSize(IntPtr window, out int width, out int height);

			public delegate void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

			public delegate void SetWindowAspectRatio(IntPtr window, int numer, int denom);

			public delegate void SetWindowSize(IntPtr window, int width, int height);

			public delegate void GetFramebufferSize(IntPtr window, out int width, out int height);

			public delegate void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

			public delegate void IconifyWindow(IntPtr window);

			public delegate void RestoreWindow(IntPtr window);

			public delegate void MaximizeWindow(IntPtr window);

			public delegate void ShowWindow(IntPtr window);

			public delegate void HideWindow(IntPtr window);

			public delegate void FocusWindow(IntPtr window);

			public delegate IntPtr GetWindowMonitor(IntPtr window);

			public delegate void SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

			public delegate int GetWindowAttrib(IntPtr window, int attrib);

			public delegate void SetWindowUserPointer(IntPtr window, IntPtr pointer);

			public delegate IntPtr GetWindowUserPointer(IntPtr window);

			public delegate WindowPosFun SetWindowPosCallback(IntPtr window, WindowPosFun cbfun);

			public delegate WindowSizeFun SetWindowSizeCallback(IntPtr window, WindowSizeFun cbfun);

			public delegate WindowCloseFun SetWindowCloseCallback(IntPtr window, WindowCloseFun cbfun);

			public delegate WindowRefreshFun SetWindowRefreshCallback(IntPtr window, WindowRefreshFun cbfun);

			public delegate WindowFocusFun SetWindowFocusCallback(IntPtr window, WindowFocusFun cbfun);

			public delegate WindowIconifyFun SetWindowIconifyCallback(IntPtr window, WindowIconifyFun cbfun);

			public delegate FramebufferSizeFun SetFramebufferSizeCallback(IntPtr window, FramebufferSizeFun cbfun);

			public delegate void PollEvents();

			public delegate void WaitEvents();

			public delegate void WaitEventsTimeout(double timeout);

			public delegate void PostEmptyEvent();

			public delegate int GetInputMode(IntPtr window, int mode);

			public delegate void SetInputMode(IntPtr window, int mode, int value);

			public delegate string GetKeyName(int key, int scancode);

			public delegate int GetKey(IntPtr window, int key);

			public delegate int GetMouseButton(IntPtr window, int button);

			public delegate void GetCursorPos(IntPtr window, out double xpos, out double ypos);

			public delegate void SetCursorPos(IntPtr window, double xpos, double ypos);

			public delegate IntPtr CreateCursor(Image image, int xhot, int yhot);

			public delegate IntPtr CreateStandardCursor(int shape);

			public delegate void DestroyCursor(IntPtr cursor);

			public delegate void SetCursor(IntPtr window, IntPtr cursor);

			public delegate KeyFun SetKeyCallback(IntPtr window, KeyFun cbfun);

			public delegate CharFun SetCharCallback(IntPtr window, CharFun cbfun);

			public delegate CharModsFun SetCharModsCallback(IntPtr window, CharModsFun cbfun);

			public delegate MouseButtonFun SetMouseButtonCallback(IntPtr window, MouseButtonFun cbfun);

			public delegate CursorPosFun SetCursorPosCallback(IntPtr window, CursorPosFun cbfun);

			public delegate CursorEnterFun SetCursorEnterCallback(IntPtr window, CursorEnterFun cbfun);

			public delegate ScrollFun SetScrollCallback(IntPtr window, ScrollFun cbfun);

			public delegate DropFun SetDropCallback(IntPtr window, DropFun cbfun);

			public delegate int JoystickPresent(int joy);

			public delegate float[] GetJoystickAxes(int joy, out int count);

			public delegate string GetJoystickButtons(int joy, out int count);

			public delegate string GetJoystickName(int joy);

			public delegate JoystickFun SetJoystickCallback(JoystickFun cbfun);

			public delegate void SetClipboardString(IntPtr window, string @string);

			public delegate string GetClipboardString(IntPtr window);

			public delegate double GetTime();

			public delegate void SetTime(double time);

			public delegate ulong GetTimerValue();

			public delegate ulong GetTimerFrequency();

			public delegate void MakeContextCurrent(IntPtr window);

			public delegate IntPtr GetCurrentContext();

			public delegate void SwapBuffers(IntPtr window);

			public delegate void SwapInterval(int interval);

			public delegate int ExtensionSupported(string extension);

			public delegate IntPtr GetProcAddress(string procname);

			public delegate int VulkanSupported();

			public delegate string[] GetRequiredInstanceExtensions(out uint count);

			public delegate IntPtr GetInstanceProcAddress(IntPtr instance, string procname);

			public delegate int GetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily);

			public delegate int CreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface);

		}

		/// <summary>
		/// This function initializes the GLFW library.  Before most GLFW functions can
		/// be used, GLFW must be initialized, and before an application terminates GLFW
		/// should be terminated in order to free any resources allocated during or
		/// after initialization.
		/// </summary>
		public static readonly Delegates.Init Init;

		/// <summary>
		/// This function destroys all remaining windows and cursors, restores any
		/// modified gamma ramps and frees any other allocated resources.  Once this
		/// function is called, you must again call @ref glfwInit successfully before
		/// you will be able to use most GLFW functions.
		/// </summary>
		public static readonly Delegates.Terminate Terminate;

		/// <summary>
		/// This function retrieves the major, minor and revision numbers of the GLFW
		/// library.  It is intended for when you are using GLFW as a shared library and
		/// want to ensure that you are using the minimum required version.
		/// </summary>
		public static readonly Delegates.GetVersion GetVersion;

		/// <summary>
		/// This function returns the compile-time generated
		/// [version string](@ref intro_version_string) of the GLFW library binary.  It
		/// describes the version, platform, compiler and any platform-specific
		/// compile-time options.  It should not be confused with the OpenGL or OpenGL
		/// ES version string, queried with `glGetString`.
		/// </summary>
		public static readonly Delegates.GetVersionString GetVersionString;

		/// <summary>
		/// This function sets the error callback, which is called with an error code
		/// and a human-readable description each time a GLFW error occurs.
		/// </summary>
		public static readonly Delegates.SetErrorCallback SetErrorCallback;

		/// <summary>
		/// This function returns an array of handles for all currently connected
		/// monitors.  The primary monitor is always first in the returned array.  If no
		/// monitors were found, this function returns `NULL`.
		/// </summary>
		public static readonly Delegates.GetMonitors GetMonitors;

		/// <summary>
		/// This function returns the primary monitor.  This is usually the monitor
		/// where elements like the task bar or global menu bar are located.
		/// </summary>
		public static readonly Delegates.GetPrimaryMonitor GetPrimaryMonitor;

		/// <summary>
		/// This function returns the position, in screen coordinates, of the upper-left
		/// corner of the specified monitor.
		/// </summary>
		public static readonly Delegates.GetMonitorPos GetMonitorPos;

		/// <summary>
		/// This function returns the size, in millimetres, of the display area of the
		/// specified monitor.
		/// </summary>
		public static readonly Delegates.GetMonitorPhysicalSize GetMonitorPhysicalSize;

		/// <summary>
		/// This function returns a human-readable name, encoded as UTF-8, of the
		/// specified monitor.  The name typically reflects the make and model of the
		/// monitor and is not guaranteed to be unique among the connected monitors.
		/// </summary>
		public static readonly Delegates.GetMonitorName GetMonitorName;

		/// <summary>
		/// This function sets the monitor configuration callback, or removes the
		/// currently set callback.  This is called when a monitor is connected to or
		/// disconnected from the system.
		/// </summary>
		public static readonly Delegates.SetMonitorCallback SetMonitorCallback;

		/// <summary>
		/// This function returns an array of all video modes supported by the specified
		/// monitor.  The returned array is sorted in ascending order, first by color
		/// bit depth (the sum of all channel depths) and then by resolution area (the
		/// product of width and height).
		/// </summary>
		public static readonly Delegates.GetVideoModes GetVideoModes;

		/// <summary>
		/// This function returns the current video mode of the specified monitor.  If
		/// you have created a full screen window for that monitor, the return value
		/// will depend on whether that window is iconified.
		/// </summary>
		public static readonly Delegates.GetVideoMode GetVideoMode;

		/// <summary>
		/// This function generates a 256-element gamma ramp from the specified exponent
		/// and then calls @ref glfwSetGammaRamp with it.  The value must be a finite
		/// number greater than zero.
		/// </summary>
		public static readonly Delegates.SetGamma SetGamma;

		/// <summary>
		/// This function returns the current gamma ramp of the specified monitor.
		/// </summary>
		public static readonly Delegates.GetGammaRamp GetGammaRamp;

		/// <summary>
		/// This function sets the current gamma ramp for the specified monitor.  The
		/// original gamma ramp for that monitor is saved by GLFW the first time this
		/// function is called and is restored by @ref glfwTerminate.
		/// </summary>
		public static readonly Delegates.SetGammaRamp SetGammaRamp;

		/// <summary>
		/// This function resets all window hints to their
		/// [default values](@ref window_hints_values).
		/// </summary>
		public static readonly Delegates.DefaultWindowHints DefaultWindowHints;

		/// <summary>
		/// This function sets hints for the next call to @ref glfwCreateWindow.  The
		/// hints, once set, retain their values until changed by a call to @ref
		/// glfwWindowHint or @ref glfwDefaultWindowHints, or until the library is
		/// terminated.
		/// </summary>
		public static readonly Delegates.WindowHint WindowHint;

		/// <summary>
		/// This function creates a window and its associated OpenGL or OpenGL ES
		/// context.  Most of the options controlling how the window and its context
		/// should be created are specified with [window hints](@ref window_hints).
		/// </summary>
		public static readonly Delegates.CreateWindow CreateWindow;

		/// <summary>
		/// This function destroys the specified window and its context.  On calling
		/// this function, no further callbacks will be called for that window.
		/// </summary>
		public static readonly Delegates.DestroyWindow DestroyWindow;

		/// <summary>
		/// This function returns the value of the close flag of the specified window.
		/// </summary>
		public static readonly Delegates.WindowShouldClose WindowShouldClose;

		/// <summary>
		/// This function sets the value of the close flag of the specified window.
		/// This can be used to override the user's attempt to close the window, or
		/// to signal that it should be closed.
		/// </summary>
		public static readonly Delegates.SetWindowShouldClose SetWindowShouldClose;

		/// <summary>
		/// This function sets the window title, encoded as UTF-8, of the specified
		/// window.
		/// </summary>
		public static readonly Delegates.SetWindowTitle SetWindowTitle;

		/// <summary>
		/// This function sets the icon of the specified window.  If passed an array of
		/// candidate images, those of or closest to the sizes desired by the system are
		/// selected.  If no images are specified, the window reverts to its default
		/// icon.
		/// </summary>
		public static readonly Delegates.SetWindowIcon SetWindowIcon;

		/// <summary>
		/// This function retrieves the position, in screen coordinates, of the
		/// upper-left corner of the client area of the specified window.
		/// </summary>
		public static readonly Delegates.GetWindowPos GetWindowPos;

		/// <summary>
		/// This function sets the position, in screen coordinates, of the upper-left
		/// corner of the client area of the specified windowed mode window.  If the
		/// window is a full screen window, this function does nothing.
		/// </summary>
		public static readonly Delegates.SetWindowPos SetWindowPos;

		/// <summary>
		/// This function retrieves the size, in screen coordinates, of the client area
		/// of the specified window.  If you wish to retrieve the size of the
		/// framebuffer of the window in pixels, see @ref glfwGetFramebufferSize.
		/// </summary>
		public static readonly Delegates.GetWindowSize GetWindowSize;

		/// <summary>
		/// This function sets the size limits of the client area of the specified
		/// window.  If the window is full screen, the size limits only take effect
		/// once it is made windowed.  If the window is not resizable, this function
		/// does nothing.
		/// </summary>
		public static readonly Delegates.SetWindowSizeLimits SetWindowSizeLimits;

		/// <summary>
		/// This function sets the required aspect ratio of the client area of the
		/// specified window.  If the window is full screen, the aspect ratio only takes
		/// effect once it is made windowed.  If the window is not resizable, this
		/// function does nothing.
		/// </summary>
		public static readonly Delegates.SetWindowAspectRatio SetWindowAspectRatio;

		/// <summary>
		/// This function sets the size, in screen coordinates, of the client area of
		/// the specified window.
		/// </summary>
		public static readonly Delegates.SetWindowSize SetWindowSize;

		/// <summary>
		/// This function retrieves the size, in pixels, of the framebuffer of the
		/// specified window.  If you wish to retrieve the size of the window in screen
		/// coordinates, see @ref glfwGetWindowSize.
		/// </summary>
		public static readonly Delegates.GetFramebufferSize GetFramebufferSize;

		/// <summary>
		/// This function retrieves the size, in screen coordinates, of each edge of the
		/// frame of the specified window.  This size includes the title bar, if the
		/// window has one.  The size of the frame may vary depending on the
		/// [window-related hints](@ref window_hints_wnd) used to create it.
		/// </summary>
		public static readonly Delegates.GetWindowFrameSize GetWindowFrameSize;

		/// <summary>
		/// This function iconifies (minimizes) the specified window if it was
		/// previously restored.  If the window is already iconified, this function does
		/// nothing.
		/// </summary>
		public static readonly Delegates.IconifyWindow IconifyWindow;

		/// <summary>
		/// This function restores the specified window if it was previously iconified
		/// (minimized) or maximized.  If the window is already restored, this function
		/// does nothing.
		/// </summary>
		public static readonly Delegates.RestoreWindow RestoreWindow;

		/// <summary>
		/// This function maximizes the specified window if it was previously not
		/// maximized.  If the window is already maximized, this function does nothing.
		/// </summary>
		public static readonly Delegates.MaximizeWindow MaximizeWindow;

		/// <summary>
		/// This function makes the specified window visible if it was previously
		/// hidden.  If the window is already visible or is in full screen mode, this
		/// function does nothing.
		/// </summary>
		public static readonly Delegates.ShowWindow ShowWindow;

		/// <summary>
		/// This function hides the specified window if it was previously visible.  If
		/// the window is already hidden or is in full screen mode, this function does
		/// nothing.
		/// </summary>
		public static readonly Delegates.HideWindow HideWindow;

		/// <summary>
		/// This function brings the specified window to front and sets input focus.
		/// The window should already be visible and not iconified.
		/// </summary>
		public static readonly Delegates.FocusWindow FocusWindow;

		/// <summary>
		/// This function returns the handle of the monitor that the specified window is
		/// in full screen on.
		/// </summary>
		public static readonly Delegates.GetWindowMonitor GetWindowMonitor;

		/// <summary>
		/// This function sets the monitor that the window uses for full screen mode or,
		/// if the monitor is `NULL`, makes it windowed mode.
		/// </summary>
		public static readonly Delegates.SetWindowMonitor SetWindowMonitor;

		/// <summary>
		/// This function returns the value of an attribute of the specified window or
		/// its OpenGL or OpenGL ES context.
		/// </summary>
		public static readonly Delegates.GetWindowAttrib GetWindowAttrib;

		/// <summary>
		/// This function sets the user-defined pointer of the specified window.  The
		/// current value is retained until the window is destroyed.  The initial value
		/// is `NULL`.
		/// </summary>
		public static readonly Delegates.SetWindowUserPointer SetWindowUserPointer;

		/// <summary>
		/// This function returns the current value of the user-defined pointer of the
		/// specified window.  The initial value is `NULL`.
		/// </summary>
		public static readonly Delegates.GetWindowUserPointer GetWindowUserPointer;

		/// <summary>
		/// This function sets the position callback of the specified window, which is
		/// called when the window is moved.  The callback is provided with the screen
		/// position of the upper-left corner of the client area of the window.
		/// </summary>
		public static readonly Delegates.SetWindowPosCallback SetWindowPosCallback;

		/// <summary>
		/// This function sets the size callback of the specified window, which is
		/// called when the window is resized.  The callback is provided with the size,
		/// in screen coordinates, of the client area of the window.
		/// </summary>
		public static readonly Delegates.SetWindowSizeCallback SetWindowSizeCallback;

		/// <summary>
		/// This function sets the close callback of the specified window, which is
		/// called when the user attempts to close the window, for example by clicking
		/// the close widget in the title bar.
		/// </summary>
		public static readonly Delegates.SetWindowCloseCallback SetWindowCloseCallback;

		/// <summary>
		/// This function sets the refresh callback of the specified window, which is
		/// called when the client area of the window needs to be redrawn, for example
		/// if the window has been exposed after having been covered by another window.
		/// </summary>
		public static readonly Delegates.SetWindowRefreshCallback SetWindowRefreshCallback;

		/// <summary>
		/// This function sets the focus callback of the specified window, which is
		/// called when the window gains or loses input focus.
		/// </summary>
		public static readonly Delegates.SetWindowFocusCallback SetWindowFocusCallback;

		/// <summary>
		/// This function sets the iconification callback of the specified window, which
		/// is called when the window is iconified or restored.
		/// </summary>
		public static readonly Delegates.SetWindowIconifyCallback SetWindowIconifyCallback;

		/// <summary>
		/// This function sets the framebuffer resize callback of the specified window,
		/// which is called when the framebuffer of the specified window is resized.
		/// </summary>
		public static readonly Delegates.SetFramebufferSizeCallback SetFramebufferSizeCallback;

		/// <summary>
		/// This function processes only those events that are already in the event
		/// queue and then returns immediately.  Processing events will cause the window
		/// and input callbacks associated with those events to be called.
		/// </summary>
		public static readonly Delegates.PollEvents PollEvents;

		/// <summary>
		/// This function puts the calling thread to sleep until at least one event is
		/// available in the event queue.  Once one or more events are available,
		/// it behaves exactly like @ref glfwPollEvents, i.e. the events in the queue
		/// are processed and the function then returns immediately.  Processing events
		/// will cause the window and input callbacks associated with those events to be
		/// called.
		/// </summary>
		public static readonly Delegates.WaitEvents WaitEvents;

		/// <summary>
		/// This function puts the calling thread to sleep until at least one event is
		/// available in the event queue, or until the specified timeout is reached.  If
		/// one or more events are available, it behaves exactly like @ref
		/// glfwPollEvents, i.e. the events in the queue are processed and the function
		/// then returns immediately.  Processing events will cause the window and input
		/// callbacks associated with those events to be called.
		/// </summary>
		public static readonly Delegates.WaitEventsTimeout WaitEventsTimeout;

		/// <summary>
		/// This function posts an empty event from the current thread to the event
		/// queue, causing @ref glfwWaitEvents or @ref glfwWaitEventsTimeout to return.
		/// </summary>
		public static readonly Delegates.PostEmptyEvent PostEmptyEvent;

		/// <summary>
		/// This function returns the value of an input option for the specified window.
		/// The mode must be one of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or
		/// `GLFW_STICKY_MOUSE_BUTTONS`.
		/// </summary>
		public static readonly Delegates.GetInputMode GetInputMode;

		/// <summary>
		/// This function sets an input mode option for the specified window.  The mode
		/// must be one of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or
		/// `GLFW_STICKY_MOUSE_BUTTONS`.
		/// </summary>
		public static readonly Delegates.SetInputMode SetInputMode;

		/// <summary>
		/// This function returns the localized name of the specified printable key.
		/// This is intended for displaying key bindings to the user.
		/// </summary>
		public static readonly Delegates.GetKeyName GetKeyName;

		/// <summary>
		/// This function returns the last state reported for the specified key to the
		/// specified window.  The returned state is one of `GLFW_PRESS` or
		/// `GLFW_RELEASE`.  The higher-level action `GLFW_REPEAT` is only reported to
		/// the key callback.
		/// </summary>
		public static readonly Delegates.GetKey GetKey;

		/// <summary>
		/// This function returns the last state reported for the specified mouse button
		/// to the specified window.  The returned state is one of `GLFW_PRESS` or
		/// `GLFW_RELEASE`.
		/// </summary>
		public static readonly Delegates.GetMouseButton GetMouseButton;

		/// <summary>
		/// This function returns the position of the cursor, in screen coordinates,
		/// relative to the upper-left corner of the client area of the specified
		/// window.
		/// </summary>
		public static readonly Delegates.GetCursorPos GetCursorPos;

		/// <summary>
		/// This function sets the position, in screen coordinates, of the cursor
		/// relative to the upper-left corner of the client area of the specified
		/// window.  The window must have input focus.  If the window does not have
		/// input focus when this function is called, it fails silently.
		/// </summary>
		public static readonly Delegates.SetCursorPos SetCursorPos;

		/// <summary>
		/// Creates a new custom cursor image that can be set for a window with @ref
		/// glfwSetCursor.  The cursor can be destroyed with @ref glfwDestroyCursor.
		/// Any remaining cursors are destroyed by @ref glfwTerminate.
		/// </summary>
		public static readonly Delegates.CreateCursor CreateCursor;

		/// <summary>
		/// Returns a cursor with a [standard shape](@ref shapes), that can be set for
		/// a window with @ref glfwSetCursor.
		/// </summary>
		public static readonly Delegates.CreateStandardCursor CreateStandardCursor;

		/// <summary>
		/// This function destroys a cursor previously created with @ref
		/// glfwCreateCursor.  Any remaining cursors will be destroyed by @ref
		/// glfwTerminate.
		/// </summary>
		public static readonly Delegates.DestroyCursor DestroyCursor;

		/// <summary>
		/// This function sets the cursor image to be used when the cursor is over the
		/// client area of the specified window.  The set cursor will only be visible
		/// when the [cursor mode](@ref cursor_mode) of the window is
		/// `GLFW_CURSOR_NORMAL`.
		/// </summary>
		public static readonly Delegates.SetCursor SetCursor;

		/// <summary>
		/// This function sets the key callback of the specified window, which is called
		/// when a key is pressed, repeated or released.
		/// </summary>
		public static readonly Delegates.SetKeyCallback SetKeyCallback;

		/// <summary>
		/// This function sets the character callback of the specified window, which is
		/// called when a Unicode character is input.
		/// </summary>
		public static readonly Delegates.SetCharCallback SetCharCallback;

		/// <summary>
		/// This function sets the character with modifiers callback of the specified
		/// window, which is called when a Unicode character is input regardless of what
		/// modifier keys are used.
		/// </summary>
		public static readonly Delegates.SetCharModsCallback SetCharModsCallback;

		/// <summary>
		/// This function sets the mouse button callback of the specified window, which
		/// is called when a mouse button is pressed or released.
		/// </summary>
		public static readonly Delegates.SetMouseButtonCallback SetMouseButtonCallback;

		/// <summary>
		/// This function sets the cursor position callback of the specified window,
		/// which is called when the cursor is moved.  The callback is provided with the
		/// position, in screen coordinates, relative to the upper-left corner of the
		/// client area of the window.
		/// </summary>
		public static readonly Delegates.SetCursorPosCallback SetCursorPosCallback;

		/// <summary>
		/// This function sets the cursor boundary crossing callback of the specified
		/// window, which is called when the cursor enters or leaves the client area of
		/// the window.
		/// </summary>
		public static readonly Delegates.SetCursorEnterCallback SetCursorEnterCallback;

		/// <summary>
		/// This function sets the scroll callback of the specified window, which is
		/// called when a scrolling device is used, such as a mouse wheel or scrolling
		/// area of a touchpad.
		/// </summary>
		public static readonly Delegates.SetScrollCallback SetScrollCallback;

		/// <summary>
		/// This function sets the file drop callback of the specified window, which is
		/// called when one or more dragged files are dropped on the window.
		/// </summary>
		public static readonly Delegates.SetDropCallback SetDropCallback;

		/// <summary>
		/// This function returns whether the specified joystick is present.
		/// </summary>
		public static readonly Delegates.JoystickPresent JoystickPresent;

		/// <summary>
		/// This function returns the values of all axes of the specified joystick.
		/// Each element in the array is a value between -1.0 and 1.0.
		/// </summary>
		public static readonly Delegates.GetJoystickAxes GetJoystickAxes;

		/// <summary>
		/// This function returns the state of all buttons of the specified joystick.
		/// Each element in the array is either `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </summary>
		public static readonly Delegates.GetJoystickButtons GetJoystickButtons;

		/// <summary>
		/// This function returns the name, encoded as UTF-8, of the specified joystick.
		/// The returned string is allocated and freed by GLFW.  You should not free it
		/// yourself.
		/// </summary>
		public static readonly Delegates.GetJoystickName GetJoystickName;

		/// <summary>
		/// This function sets the joystick configuration callback, or removes the
		/// currently set callback.  This is called when a joystick is connected to or
		/// disconnected from the system.
		/// </summary>
		public static readonly Delegates.SetJoystickCallback SetJoystickCallback;

		/// <summary>
		/// This function sets the system clipboard to the specified, UTF-8 encoded
		/// string.
		/// </summary>
		public static readonly Delegates.SetClipboardString SetClipboardString;

		/// <summary>
		/// This function returns the contents of the system clipboard, if it contains
		/// or is convertible to a UTF-8 encoded string.  If the clipboard is empty or
		/// if its contents cannot be converted, `NULL` is returned and a @ref
		/// GLFW_FORMAT_UNAVAILABLE error is generated.
		/// </summary>
		public static readonly Delegates.GetClipboardString GetClipboardString;

		/// <summary>
		/// This function returns the value of the GLFW timer.  Unless the timer has
		/// been set using @ref glfwSetTime, the timer measures time elapsed since GLFW
		/// was initialized.
		/// </summary>
		public static readonly Delegates.GetTime GetTime;

		/// <summary>
		/// This function sets the value of the GLFW timer.  It then continues to count
		/// up from that value.  The value must be a positive finite number less than
		/// or equal to 18446744073.0, which is approximately 584.5 years.
		/// </summary>
		public static readonly Delegates.SetTime SetTime;

		/// <summary>
		/// This function returns the current value of the raw timer, measured in
		/// 1&nbsp;/&nbsp;frequency seconds.  To get the frequency, call @ref
		/// glfwGetTimerFrequency.
		/// </summary>
		public static readonly Delegates.GetTimerValue GetTimerValue;

		/// <summary>
		/// This function returns the frequency, in Hz, of the raw timer.
		/// </summary>
		public static readonly Delegates.GetTimerFrequency GetTimerFrequency;

		/// <summary>
		/// This function makes the OpenGL or OpenGL ES context of the specified window
		/// current on the calling thread.  A context can only be made current on
		/// a single thread at a time and each thread can have only a single current
		/// context at a time.
		/// </summary>
		public static readonly Delegates.MakeContextCurrent MakeContextCurrent;

		/// <summary>
		/// This function returns the window whose OpenGL or OpenGL ES context is
		/// current on the calling thread.
		/// </summary>
		public static readonly Delegates.GetCurrentContext GetCurrentContext;

		/// <summary>
		/// This function swaps the front and back buffers of the specified window when
		/// rendering with OpenGL or OpenGL ES.  If the swap interval is greater than
		/// zero, the GPU driver waits the specified number of screen updates before
		/// swapping the buffers.
		/// </summary>
		public static readonly Delegates.SwapBuffers SwapBuffers;

		/// <summary>
		/// This function sets the swap interval for the current OpenGL or OpenGL ES
		/// context, i.e. the number of screen updates to wait from the time @ref
		/// glfwSwapBuffers was called before swapping the buffers and returning.  This
		/// is sometimes called _vertical synchronization_, _vertical retrace
		/// synchronization_ or just _vsync_.
		/// </summary>
		public static readonly Delegates.SwapInterval SwapInterval;

		/// <summary>
		/// This function returns whether the specified
		/// [API extension](@ref context_glext) is supported by the current OpenGL or
		/// OpenGL ES context.  It searches both for client API extension and context
		/// creation API extensions.
		/// </summary>
		public static readonly Delegates.ExtensionSupported ExtensionSupported;

		/// <summary>
		/// This function returns the address of the specified OpenGL or OpenGL ES
		/// [core or extension function](@ref context_glext), if it is supported
		/// by the current context.
		/// </summary>
		public static readonly Delegates.GetProcAddress GetProcAddress;

		/// <summary>
		/// This function returns whether the Vulkan loader has been found.  This check
		/// is performed by @ref glfwInit.
		/// </summary>
		public static readonly Delegates.VulkanSupported VulkanSupported;

		/// <summary>
		/// This function returns an array of names of Vulkan instance extensions required
		/// by GLFW for creating Vulkan surfaces for GLFW windows.  If successful, the
		/// list will always contains `VK_KHR_surface`, so if you don't require any
		/// additional extensions you can pass this list directly to the
		/// `VkInstanceCreateInfo` struct.
		/// </summary>
		public static readonly Delegates.GetRequiredInstanceExtensions GetRequiredInstanceExtensions;

		/// <summary>
		/// This function returns the address of the specified Vulkan core or extension
		/// function for the specified instance.  If instance is set to `NULL` it can
		/// return any function exported from the Vulkan loader, including at least the
		/// following functions:
		/// </summary>
		public static readonly Delegates.GetInstanceProcAddress GetInstanceProcAddress;

		/// <summary>
		/// This function returns whether the specified queue family of the specified
		/// physical device supports presentation to the platform GLFW was built for.
		/// </summary>
		public static readonly Delegates.GetPhysicalDevicePresentationSupport GetPhysicalDevicePresentationSupport;

		/// <summary>
		/// This function creates a Vulkan surface for the specified window.
		/// </summary>
		public static readonly Delegates.CreateWindowSurface CreateWindowSurface;

		static GLFW()
		{
			if (Environment.Is64BitProcess)
			{
				Init = X64.Init;
				Terminate = X64.Terminate;
				GetVersion = X64.GetVersion;
				GetVersionString = X64.GetVersionString;
				SetErrorCallback = X64.SetErrorCallback;
				GetMonitors = X64.GetMonitors;
				GetPrimaryMonitor = X64.GetPrimaryMonitor;
				GetMonitorPos = X64.GetMonitorPos;
				GetMonitorPhysicalSize = X64.GetMonitorPhysicalSize;
				GetMonitorName = X64.GetMonitorName;
				SetMonitorCallback = X64.SetMonitorCallback;
				GetVideoModes = X64.GetVideoModes;
				GetVideoMode = X64.GetVideoMode;
				SetGamma = X64.SetGamma;
				GetGammaRamp = X64.GetGammaRamp;
				SetGammaRamp = X64.SetGammaRamp;
				DefaultWindowHints = X64.DefaultWindowHints;
				WindowHint = X64.WindowHint;
				CreateWindow = X64.CreateWindow;
				DestroyWindow = X64.DestroyWindow;
				WindowShouldClose = X64.WindowShouldClose;
				SetWindowShouldClose = X64.SetWindowShouldClose;
				SetWindowTitle = X64.SetWindowTitle;
				SetWindowIcon = X64.SetWindowIcon;
				GetWindowPos = X64.GetWindowPos;
				SetWindowPos = X64.SetWindowPos;
				GetWindowSize = X64.GetWindowSize;
				SetWindowSizeLimits = X64.SetWindowSizeLimits;
				SetWindowAspectRatio = X64.SetWindowAspectRatio;
				SetWindowSize = X64.SetWindowSize;
				GetFramebufferSize = X64.GetFramebufferSize;
				GetWindowFrameSize = X64.GetWindowFrameSize;
				IconifyWindow = X64.IconifyWindow;
				RestoreWindow = X64.RestoreWindow;
				MaximizeWindow = X64.MaximizeWindow;
				ShowWindow = X64.ShowWindow;
				HideWindow = X64.HideWindow;
				FocusWindow = X64.FocusWindow;
				GetWindowMonitor = X64.GetWindowMonitor;
				SetWindowMonitor = X64.SetWindowMonitor;
				GetWindowAttrib = X64.GetWindowAttrib;
				SetWindowUserPointer = X64.SetWindowUserPointer;
				GetWindowUserPointer = X64.GetWindowUserPointer;
				SetWindowPosCallback = X64.SetWindowPosCallback;
				SetWindowSizeCallback = X64.SetWindowSizeCallback;
				SetWindowCloseCallback = X64.SetWindowCloseCallback;
				SetWindowRefreshCallback = X64.SetWindowRefreshCallback;
				SetWindowFocusCallback = X64.SetWindowFocusCallback;
				SetWindowIconifyCallback = X64.SetWindowIconifyCallback;
				SetFramebufferSizeCallback = X64.SetFramebufferSizeCallback;
				PollEvents = X64.PollEvents;
				WaitEvents = X64.WaitEvents;
				WaitEventsTimeout = X64.WaitEventsTimeout;
				PostEmptyEvent = X64.PostEmptyEvent;
				GetInputMode = X64.GetInputMode;
				SetInputMode = X64.SetInputMode;
				GetKeyName = X64.GetKeyName;
				GetKey = X64.GetKey;
				GetMouseButton = X64.GetMouseButton;
				GetCursorPos = X64.GetCursorPos;
				SetCursorPos = X64.SetCursorPos;
				CreateCursor = X64.CreateCursor;
				CreateStandardCursor = X64.CreateStandardCursor;
				DestroyCursor = X64.DestroyCursor;
				SetCursor = X64.SetCursor;
				SetKeyCallback = X64.SetKeyCallback;
				SetCharCallback = X64.SetCharCallback;
				SetCharModsCallback = X64.SetCharModsCallback;
				SetMouseButtonCallback = X64.SetMouseButtonCallback;
				SetCursorPosCallback = X64.SetCursorPosCallback;
				SetCursorEnterCallback = X64.SetCursorEnterCallback;
				SetScrollCallback = X64.SetScrollCallback;
				SetDropCallback = X64.SetDropCallback;
				JoystickPresent = X64.JoystickPresent;
				GetJoystickAxes = X64.GetJoystickAxes;
				GetJoystickButtons = X64.GetJoystickButtons;
				GetJoystickName = X64.GetJoystickName;
				SetJoystickCallback = X64.SetJoystickCallback;
				SetClipboardString = X64.SetClipboardString;
				GetClipboardString = X64.GetClipboardString;
				GetTime = X64.GetTime;
				SetTime = X64.SetTime;
				GetTimerValue = X64.GetTimerValue;
				GetTimerFrequency = X64.GetTimerFrequency;
				MakeContextCurrent = X64.MakeContextCurrent;
				GetCurrentContext = X64.GetCurrentContext;
				SwapBuffers = X64.SwapBuffers;
				SwapInterval = X64.SwapInterval;
				ExtensionSupported = X64.ExtensionSupported;
				GetProcAddress = X64.GetProcAddress;
				VulkanSupported = X64.VulkanSupported;
				GetRequiredInstanceExtensions = X64.GetRequiredInstanceExtensions;
				GetInstanceProcAddress = X64.GetInstanceProcAddress;
				GetPhysicalDevicePresentationSupport = X64.GetPhysicalDevicePresentationSupport;
				CreateWindowSurface = X64.CreateWindowSurface;
			}
			else
			{
				Init = X86.Init;
				Terminate = X86.Terminate;
				GetVersion = X86.GetVersion;
				GetVersionString = X86.GetVersionString;
				SetErrorCallback = X86.SetErrorCallback;
				GetMonitors = X86.GetMonitors;
				GetPrimaryMonitor = X86.GetPrimaryMonitor;
				GetMonitorPos = X86.GetMonitorPos;
				GetMonitorPhysicalSize = X86.GetMonitorPhysicalSize;
				GetMonitorName = X86.GetMonitorName;
				SetMonitorCallback = X86.SetMonitorCallback;
				GetVideoModes = X86.GetVideoModes;
				GetVideoMode = X86.GetVideoMode;
				SetGamma = X86.SetGamma;
				GetGammaRamp = X86.GetGammaRamp;
				SetGammaRamp = X86.SetGammaRamp;
				DefaultWindowHints = X86.DefaultWindowHints;
				WindowHint = X86.WindowHint;
				CreateWindow = X86.CreateWindow;
				DestroyWindow = X86.DestroyWindow;
				WindowShouldClose = X86.WindowShouldClose;
				SetWindowShouldClose = X86.SetWindowShouldClose;
				SetWindowTitle = X86.SetWindowTitle;
				SetWindowIcon = X86.SetWindowIcon;
				GetWindowPos = X86.GetWindowPos;
				SetWindowPos = X86.SetWindowPos;
				GetWindowSize = X86.GetWindowSize;
				SetWindowSizeLimits = X86.SetWindowSizeLimits;
				SetWindowAspectRatio = X86.SetWindowAspectRatio;
				SetWindowSize = X86.SetWindowSize;
				GetFramebufferSize = X86.GetFramebufferSize;
				GetWindowFrameSize = X86.GetWindowFrameSize;
				IconifyWindow = X86.IconifyWindow;
				RestoreWindow = X86.RestoreWindow;
				MaximizeWindow = X86.MaximizeWindow;
				ShowWindow = X86.ShowWindow;
				HideWindow = X86.HideWindow;
				FocusWindow = X86.FocusWindow;
				GetWindowMonitor = X86.GetWindowMonitor;
				SetWindowMonitor = X86.SetWindowMonitor;
				GetWindowAttrib = X86.GetWindowAttrib;
				SetWindowUserPointer = X86.SetWindowUserPointer;
				GetWindowUserPointer = X86.GetWindowUserPointer;
				SetWindowPosCallback = X86.SetWindowPosCallback;
				SetWindowSizeCallback = X86.SetWindowSizeCallback;
				SetWindowCloseCallback = X86.SetWindowCloseCallback;
				SetWindowRefreshCallback = X86.SetWindowRefreshCallback;
				SetWindowFocusCallback = X86.SetWindowFocusCallback;
				SetWindowIconifyCallback = X86.SetWindowIconifyCallback;
				SetFramebufferSizeCallback = X86.SetFramebufferSizeCallback;
				PollEvents = X86.PollEvents;
				WaitEvents = X86.WaitEvents;
				WaitEventsTimeout = X86.WaitEventsTimeout;
				PostEmptyEvent = X86.PostEmptyEvent;
				GetInputMode = X86.GetInputMode;
				SetInputMode = X86.SetInputMode;
				GetKeyName = X86.GetKeyName;
				GetKey = X86.GetKey;
				GetMouseButton = X86.GetMouseButton;
				GetCursorPos = X86.GetCursorPos;
				SetCursorPos = X86.SetCursorPos;
				CreateCursor = X86.CreateCursor;
				CreateStandardCursor = X86.CreateStandardCursor;
				DestroyCursor = X86.DestroyCursor;
				SetCursor = X86.SetCursor;
				SetKeyCallback = X86.SetKeyCallback;
				SetCharCallback = X86.SetCharCallback;
				SetCharModsCallback = X86.SetCharModsCallback;
				SetMouseButtonCallback = X86.SetMouseButtonCallback;
				SetCursorPosCallback = X86.SetCursorPosCallback;
				SetCursorEnterCallback = X86.SetCursorEnterCallback;
				SetScrollCallback = X86.SetScrollCallback;
				SetDropCallback = X86.SetDropCallback;
				JoystickPresent = X86.JoystickPresent;
				GetJoystickAxes = X86.GetJoystickAxes;
				GetJoystickButtons = X86.GetJoystickButtons;
				GetJoystickName = X86.GetJoystickName;
				SetJoystickCallback = X86.SetJoystickCallback;
				SetClipboardString = X86.SetClipboardString;
				GetClipboardString = X86.GetClipboardString;
				GetTime = X86.GetTime;
				SetTime = X86.SetTime;
				GetTimerValue = X86.GetTimerValue;
				GetTimerFrequency = X86.GetTimerFrequency;
				MakeContextCurrent = X86.MakeContextCurrent;
				GetCurrentContext = X86.GetCurrentContext;
				SwapBuffers = X86.SwapBuffers;
				SwapInterval = X86.SwapInterval;
				ExtensionSupported = X86.ExtensionSupported;
				GetProcAddress = X86.GetProcAddress;
				VulkanSupported = X86.VulkanSupported;
				GetRequiredInstanceExtensions = X86.GetRequiredInstanceExtensions;
				GetInstanceProcAddress = X86.GetInstanceProcAddress;
				GetPhysicalDevicePresentationSupport = X86.GetPhysicalDevicePresentationSupport;
				CreateWindowSurface = X86.CreateWindowSurface;
			}
		}

	}
}
