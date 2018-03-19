// MIT License
// Copyright (c) 2016 - 2018 Zachary Snow
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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Security;

namespace GLFWDotNet
{
	public static partial class GLFW
	{
		private const string Library = "glfw3";

		public const int GLFW_VERSION_MAJOR = 3;
		public const int GLFW_VERSION_MINOR = 2;
		public const int GLFW_VERSION_REVISION = 1;
		public const int GLFW_TRUE = 1;
		public const int GLFW_FALSE = 0;
		public const int GLFW_RELEASE = 0;
		public const int GLFW_PRESS = 1;
		public const int GLFW_REPEAT = 2;
		public const int GLFW_KEY_UNKNOWN = -1;
		public const int GLFW_KEY_SPACE = 32;
		public const int GLFW_KEY_0 = 48;
		public const int GLFW_KEY_1 = 49;
		public const int GLFW_KEY_2 = 50;
		public const int GLFW_KEY_3 = 51;
		public const int GLFW_KEY_4 = 52;
		public const int GLFW_KEY_5 = 53;
		public const int GLFW_KEY_6 = 54;
		public const int GLFW_KEY_7 = 55;
		public const int GLFW_KEY_8 = 56;
		public const int GLFW_KEY_9 = 57;
		public const int GLFW_KEY_A = 65;
		public const int GLFW_KEY_B = 66;
		public const int GLFW_KEY_C = 67;
		public const int GLFW_KEY_D = 68;
		public const int GLFW_KEY_E = 69;
		public const int GLFW_KEY_F = 70;
		public const int GLFW_KEY_G = 71;
		public const int GLFW_KEY_H = 72;
		public const int GLFW_KEY_I = 73;
		public const int GLFW_KEY_J = 74;
		public const int GLFW_KEY_K = 75;
		public const int GLFW_KEY_L = 76;
		public const int GLFW_KEY_M = 77;
		public const int GLFW_KEY_N = 78;
		public const int GLFW_KEY_O = 79;
		public const int GLFW_KEY_P = 80;
		public const int GLFW_KEY_Q = 81;
		public const int GLFW_KEY_R = 82;
		public const int GLFW_KEY_S = 83;
		public const int GLFW_KEY_T = 84;
		public const int GLFW_KEY_U = 85;
		public const int GLFW_KEY_V = 86;
		public const int GLFW_KEY_W = 87;
		public const int GLFW_KEY_X = 88;
		public const int GLFW_KEY_Y = 89;
		public const int GLFW_KEY_Z = 90;
		public const int GLFW_KEY_ESCAPE = 256;
		public const int GLFW_KEY_ENTER = 257;
		public const int GLFW_KEY_TAB = 258;
		public const int GLFW_KEY_BACKSPACE = 259;
		public const int GLFW_KEY_INSERT = 260;
		public const int GLFW_KEY_DELETE = 261;
		public const int GLFW_KEY_RIGHT = 262;
		public const int GLFW_KEY_LEFT = 263;
		public const int GLFW_KEY_DOWN = 264;
		public const int GLFW_KEY_UP = 265;
		public const int GLFW_KEY_PAGE_UP = 266;
		public const int GLFW_KEY_PAGE_DOWN = 267;
		public const int GLFW_KEY_HOME = 268;
		public const int GLFW_KEY_END = 269;
		public const int GLFW_KEY_CAPS_LOCK = 280;
		public const int GLFW_KEY_SCROLL_LOCK = 281;
		public const int GLFW_KEY_NUM_LOCK = 282;
		public const int GLFW_KEY_PRINT_SCREEN = 283;
		public const int GLFW_KEY_PAUSE = 284;
		public const int GLFW_KEY_F1 = 290;
		public const int GLFW_KEY_F2 = 291;
		public const int GLFW_KEY_F3 = 292;
		public const int GLFW_KEY_F4 = 293;
		public const int GLFW_KEY_F5 = 294;
		public const int GLFW_KEY_F6 = 295;
		public const int GLFW_KEY_F7 = 296;
		public const int GLFW_KEY_F8 = 297;
		public const int GLFW_KEY_F9 = 298;
		public const int GLFW_KEY_F10 = 299;
		public const int GLFW_KEY_F11 = 300;
		public const int GLFW_KEY_F12 = 301;
		public const int GLFW_KEY_F13 = 302;
		public const int GLFW_KEY_F14 = 303;
		public const int GLFW_KEY_F15 = 304;
		public const int GLFW_KEY_F16 = 305;
		public const int GLFW_KEY_F17 = 306;
		public const int GLFW_KEY_F18 = 307;
		public const int GLFW_KEY_F19 = 308;
		public const int GLFW_KEY_F20 = 309;
		public const int GLFW_KEY_F21 = 310;
		public const int GLFW_KEY_F22 = 311;
		public const int GLFW_KEY_F23 = 312;
		public const int GLFW_KEY_F24 = 313;
		public const int GLFW_KEY_F25 = 314;
		public const int GLFW_KEY_KP_0 = 320;
		public const int GLFW_KEY_KP_1 = 321;
		public const int GLFW_KEY_KP_2 = 322;
		public const int GLFW_KEY_KP_3 = 323;
		public const int GLFW_KEY_KP_4 = 324;
		public const int GLFW_KEY_KP_5 = 325;
		public const int GLFW_KEY_KP_6 = 326;
		public const int GLFW_KEY_KP_7 = 327;
		public const int GLFW_KEY_KP_8 = 328;
		public const int GLFW_KEY_KP_9 = 329;
		public const int GLFW_KEY_KP_DECIMAL = 330;
		public const int GLFW_KEY_KP_DIVIDE = 331;
		public const int GLFW_KEY_KP_MULTIPLY = 332;
		public const int GLFW_KEY_KP_SUBTRACT = 333;
		public const int GLFW_KEY_KP_ADD = 334;
		public const int GLFW_KEY_KP_ENTER = 335;
		public const int GLFW_KEY_KP_EQUAL = 336;
		public const int GLFW_KEY_LEFT_SHIFT = 340;
		public const int GLFW_KEY_LEFT_CONTROL = 341;
		public const int GLFW_KEY_LEFT_ALT = 342;
		public const int GLFW_KEY_LEFT_SUPER = 343;
		public const int GLFW_KEY_RIGHT_SHIFT = 344;
		public const int GLFW_KEY_RIGHT_CONTROL = 345;
		public const int GLFW_KEY_RIGHT_ALT = 346;
		public const int GLFW_KEY_RIGHT_SUPER = 347;
		public const int GLFW_KEY_MENU = 348;
		public const int GLFW_KEY_LAST = GLFW_KEY_MENU;
		public const int GLFW_MOD_SHIFT = 0x0001;
		public const int GLFW_MOD_CONTROL = 0x0002;
		public const int GLFW_MOD_ALT = 0x0004;
		public const int GLFW_MOD_SUPER = 0x0008;
		public const int GLFW_MOUSE_BUTTON_1 = 0;
		public const int GLFW_MOUSE_BUTTON_2 = 1;
		public const int GLFW_MOUSE_BUTTON_3 = 2;
		public const int GLFW_MOUSE_BUTTON_4 = 3;
		public const int GLFW_MOUSE_BUTTON_5 = 4;
		public const int GLFW_MOUSE_BUTTON_6 = 5;
		public const int GLFW_MOUSE_BUTTON_7 = 6;
		public const int GLFW_MOUSE_BUTTON_8 = 7;
		public const int GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
		public const int GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
		public const int GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
		public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
		public const int GLFW_JOYSTICK_1 = 0;
		public const int GLFW_JOYSTICK_2 = 1;
		public const int GLFW_JOYSTICK_3 = 2;
		public const int GLFW_JOYSTICK_4 = 3;
		public const int GLFW_JOYSTICK_5 = 4;
		public const int GLFW_JOYSTICK_6 = 5;
		public const int GLFW_JOYSTICK_7 = 6;
		public const int GLFW_JOYSTICK_8 = 7;
		public const int GLFW_JOYSTICK_9 = 8;
		public const int GLFW_JOYSTICK_10 = 9;
		public const int GLFW_JOYSTICK_11 = 10;
		public const int GLFW_JOYSTICK_12 = 11;
		public const int GLFW_JOYSTICK_13 = 12;
		public const int GLFW_JOYSTICK_14 = 13;
		public const int GLFW_JOYSTICK_15 = 14;
		public const int GLFW_JOYSTICK_16 = 15;
		public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
		public const int GLFW_NOT_INITIALIZED = 0x00010001;
		public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
		public const int GLFW_INVALID_ENUM = 0x00010003;
		public const int GLFW_INVALID_VALUE = 0x00010004;
		public const int GLFW_OUT_OF_MEMORY = 0x00010005;
		public const int GLFW_API_UNAVAILABLE = 0x00010006;
		public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
		public const int GLFW_PLATFORM_ERROR = 0x00010008;
		public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
		public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
		public const int GLFW_FOCUSED = 0x00020001;
		public const int GLFW_ICONIFIED = 0x00020002;
		public const int GLFW_RESIZABLE = 0x00020003;
		public const int GLFW_VISIBLE = 0x00020004;
		public const int GLFW_DECORATED = 0x00020005;
		public const int GLFW_AUTO_ICONIFY = 0x00020006;
		public const int GLFW_FLOATING = 0x00020007;
		public const int GLFW_MAXIMIZED = 0x00020008;
		public const int GLFW_RED_BITS = 0x00021001;
		public const int GLFW_GREEN_BITS = 0x00021002;
		public const int GLFW_BLUE_BITS = 0x00021003;
		public const int GLFW_ALPHA_BITS = 0x00021004;
		public const int GLFW_DEPTH_BITS = 0x00021005;
		public const int GLFW_STENCIL_BITS = 0x00021006;
		public const int GLFW_ACCUM_RED_BITS = 0x00021007;
		public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
		public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
		public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
		public const int GLFW_AUX_BUFFERS = 0x0002100B;
		public const int GLFW_STEREO = 0x0002100C;
		public const int GLFW_SAMPLES = 0x0002100D;
		public const int GLFW_SRGB_CAPABLE = 0x0002100E;
		public const int GLFW_REFRESH_RATE = 0x0002100F;
		public const int GLFW_DOUBLEBUFFER = 0x00021010;
		public const int GLFW_CLIENT_API = 0x00022001;
		public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
		public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
		public const int GLFW_CONTEXT_REVISION = 0x00022004;
		public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
		public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
		public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007;
		public const int GLFW_OPENGL_PROFILE = 0x00022008;
		public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
		public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
		public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
		public const int GLFW_NO_API = 0;
		public const int GLFW_OPENGL_API = 0x00030001;
		public const int GLFW_OPENGL_ES_API = 0x00030002;
		public const int GLFW_NO_ROBUSTNESS = 0;
		public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;
		public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;
		public const int GLFW_OPENGL_ANY_PROFILE = 0;
		public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;
		public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;
		public const int GLFW_CURSOR = 0x00033001;
		public const int GLFW_STICKY_KEYS = 0x00033002;
		public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
		public const int GLFW_CURSOR_NORMAL = 0x00034001;
		public const int GLFW_CURSOR_HIDDEN = 0x00034002;
		public const int GLFW_CURSOR_DISABLED = 0x00034003;
		public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
		public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
		public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;
		public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;
		public const int GLFW_EGL_CONTEXT_API = 0x00036002;
		public const int GLFW_ARROW_CURSOR = 0x00036001;
		public const int GLFW_IBEAM_CURSOR = 0x00036002;
		public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
		public const int GLFW_HAND_CURSOR = 0x00036004;
		public const int GLFW_HRESIZE_CURSOR = 0x00036005;
		public const int GLFW_VRESIZE_CURSOR = 0x00036006;
		public const int GLFW_CONNECTED = 0x00040001;
		public const int GLFW_DISCONNECTED = 0x00040002;
		public const int GLFW_DONT_CARE = -1;

		public struct GLFWvidmode
		{
			public int width;
			public int height;
			public int redBits;
			public int greenBits;
			public int blueBits;
			public int refreshRate;
		}

		public struct GLFWgammaramp
		{
			public ushort[] red;
			public ushort[] green;
			public ushort[] blue;
			public uint size;
		}

		public struct GLFWimage
		{
			public int width;
			public int height;
			public string pixels;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWerrorfun(int error, string description);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWwindowposfun(IntPtr window, int xpos, int ypos);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWwindowsizefun(IntPtr window, int width, int height);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWwindowclosefun(IntPtr window);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWwindowrefreshfun(IntPtr window);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWwindowfocusfun(IntPtr window, int focused);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWwindowiconifyfun(IntPtr window, int iconified);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWframebuffersizefun(IntPtr window, int width, int height);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWmousebuttonfun(IntPtr window, int button, int action, int mods);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWcursorposfun(IntPtr window, double xpos, double ypos);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWcursorenterfun(IntPtr window, int entered);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWscrollfun(IntPtr window, double xoffset, double yoffset);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWkeyfun(IntPtr window, int key, int scancode, int action, int mods);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWcharfun(IntPtr window, uint codepoint);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWcharmodsfun(IntPtr window, uint codepoint, int mods);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWdropfun(IntPtr window, int count, string[] paths);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWmonitorfun(IntPtr monitor, int @event);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void GLFWjoystickfun(int joy, int @event);

		[DllImport(Library, EntryPoint = "glfwInit", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwInit();

		[DllImport(Library, EntryPoint = "glfwTerminate", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwTerminate();

		[DllImport(Library, EntryPoint = "glfwGetVersion", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetVersion(out int major, out int minor, out int rev);

		[DllImport(Library, EntryPoint = "glfwGetVersionString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string glfwGetVersionString();

		[DllImport(Library, EntryPoint = "glfwSetErrorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun cbfun);

		[DllImport(Library, EntryPoint = "glfwGetMonitors", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr[] glfwGetMonitors(out int count);

		[DllImport(Library, EntryPoint = "glfwGetPrimaryMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwGetPrimaryMonitor();

		[DllImport(Library, EntryPoint = "glfwGetMonitorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

		[DllImport(Library, EntryPoint = "glfwGetMonitorPhysicalSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

		[DllImport(Library, EntryPoint = "glfwGetMonitorName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string glfwGetMonitorName(IntPtr monitor);

		[DllImport(Library, EntryPoint = "glfwSetMonitorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun cbfun);

		[DllImport(Library, EntryPoint = "glfwGetVideoModes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWvidmode glfwGetVideoModes(IntPtr monitor, out int count);

		[DllImport(Library, EntryPoint = "glfwGetVideoMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWvidmode glfwGetVideoMode(IntPtr monitor);

		[DllImport(Library, EntryPoint = "glfwSetGamma", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetGamma(IntPtr monitor, float gamma);

		[DllImport(Library, EntryPoint = "glfwGetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWgammaramp glfwGetGammaRamp(IntPtr monitor);

		[DllImport(Library, EntryPoint = "glfwSetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetGammaRamp(IntPtr monitor, GLFWgammaramp ramp);

		[DllImport(Library, EntryPoint = "glfwDefaultWindowHints", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwDefaultWindowHints();

		[DllImport(Library, EntryPoint = "glfwWindowHint", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwWindowHint(int hint, int value);

		[DllImport(Library, EntryPoint = "glfwCreateWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwCreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

		[DllImport(Library, EntryPoint = "glfwDestroyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwDestroyWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwWindowShouldClose(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwSetWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowShouldClose(IntPtr window, int value);

		[DllImport(Library, EntryPoint = "glfwSetWindowTitle", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowTitle(IntPtr window, string title);

		[DllImport(Library, EntryPoint = "glfwSetWindowIcon", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowIcon(IntPtr window, int count, GLFWimage images);

		[DllImport(Library, EntryPoint = "glfwGetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetWindowPos(IntPtr window, out int xpos, out int ypos);

		[DllImport(Library, EntryPoint = "glfwSetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowPos(IntPtr window, int xpos, int ypos);

		[DllImport(Library, EntryPoint = "glfwGetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetWindowSize(IntPtr window, out int width, out int height);

		[DllImport(Library, EntryPoint = "glfwSetWindowSizeLimits", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

		[DllImport(Library, EntryPoint = "glfwSetWindowAspectRatio", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowAspectRatio(IntPtr window, int numer, int denom);

		[DllImport(Library, EntryPoint = "glfwSetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowSize(IntPtr window, int width, int height);

		[DllImport(Library, EntryPoint = "glfwGetFramebufferSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetFramebufferSize(IntPtr window, out int width, out int height);

		[DllImport(Library, EntryPoint = "glfwGetWindowFrameSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

		[DllImport(Library, EntryPoint = "glfwIconifyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwIconifyWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwRestoreWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwRestoreWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwMaximizeWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwMaximizeWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwShowWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwShowWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwHideWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwHideWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwFocusWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwFocusWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwGetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwGetWindowMonitor(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwSetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

		[DllImport(Library, EntryPoint = "glfwGetWindowAttrib", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwGetWindowAttrib(IntPtr window, int attrib);

		[DllImport(Library, EntryPoint = "glfwSetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetWindowUserPointer(IntPtr window, IntPtr pointer);

		[DllImport(Library, EntryPoint = "glfwGetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwGetWindowUserPointer(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwSetWindowPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWwindowposfun glfwSetWindowPosCallback(IntPtr window, GLFWwindowposfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWwindowsizefun glfwSetWindowSizeCallback(IntPtr window, GLFWwindowsizefun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowCloseCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWwindowclosefun glfwSetWindowCloseCallback(IntPtr window, GLFWwindowclosefun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowRefreshCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback(IntPtr window, GLFWwindowrefreshfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowFocusCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWwindowfocusfun glfwSetWindowFocusCallback(IntPtr window, GLFWwindowfocusfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowIconifyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback(IntPtr window, GLFWwindowiconifyfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetFramebufferSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback(IntPtr window, GLFWframebuffersizefun cbfun);

		[DllImport(Library, EntryPoint = "glfwPollEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwPollEvents();

		[DllImport(Library, EntryPoint = "glfwWaitEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwWaitEvents();

		[DllImport(Library, EntryPoint = "glfwWaitEventsTimeout", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwWaitEventsTimeout(double timeout);

		[DllImport(Library, EntryPoint = "glfwPostEmptyEvent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwPostEmptyEvent();

		[DllImport(Library, EntryPoint = "glfwGetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwGetInputMode(IntPtr window, int mode);

		[DllImport(Library, EntryPoint = "glfwSetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetInputMode(IntPtr window, int mode, int value);

		[DllImport(Library, EntryPoint = "glfwGetKeyName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string glfwGetKeyName(int key, int scancode);

		[DllImport(Library, EntryPoint = "glfwGetKey", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwGetKey(IntPtr window, int key);

		[DllImport(Library, EntryPoint = "glfwGetMouseButton", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwGetMouseButton(IntPtr window, int button);

		[DllImport(Library, EntryPoint = "glfwGetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwGetCursorPos(IntPtr window, out double xpos, out double ypos);

		[DllImport(Library, EntryPoint = "glfwSetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetCursorPos(IntPtr window, double xpos, double ypos);

		[DllImport(Library, EntryPoint = "glfwCreateCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwCreateCursor(GLFWimage image, int xhot, int yhot);

		[DllImport(Library, EntryPoint = "glfwCreateStandardCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwCreateStandardCursor(int shape);

		[DllImport(Library, EntryPoint = "glfwDestroyCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwDestroyCursor(IntPtr cursor);

		[DllImport(Library, EntryPoint = "glfwSetCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetCursor(IntPtr window, IntPtr cursor);

		[DllImport(Library, EntryPoint = "glfwSetKeyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWkeyfun glfwSetKeyCallback(IntPtr window, GLFWkeyfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCharCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWcharfun glfwSetCharCallback(IntPtr window, GLFWcharfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCharModsCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWcharmodsfun glfwSetCharModsCallback(IntPtr window, GLFWcharmodsfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetMouseButtonCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWmousebuttonfun glfwSetMouseButtonCallback(IntPtr window, GLFWmousebuttonfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCursorPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWcursorposfun glfwSetCursorPosCallback(IntPtr window, GLFWcursorposfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCursorEnterCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWcursorenterfun glfwSetCursorEnterCallback(IntPtr window, GLFWcursorenterfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetScrollCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWscrollfun glfwSetScrollCallback(IntPtr window, GLFWscrollfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetDropCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWdropfun glfwSetDropCallback(IntPtr window, GLFWdropfun cbfun);

		[DllImport(Library, EntryPoint = "glfwJoystickPresent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwJoystickPresent(int joy);

		[DllImport(Library, EntryPoint = "glfwGetJoystickAxes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern float[] glfwGetJoystickAxes(int joy, out int count);

		[DllImport(Library, EntryPoint = "glfwGetJoystickButtons", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string glfwGetJoystickButtons(int joy, out int count);

		[DllImport(Library, EntryPoint = "glfwGetJoystickName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string glfwGetJoystickName(int joy);

		[DllImport(Library, EntryPoint = "glfwSetJoystickCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetClipboardString(IntPtr window, string @string);

		[DllImport(Library, EntryPoint = "glfwGetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string glfwGetClipboardString(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwGetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern double glfwGetTime();

		[DllImport(Library, EntryPoint = "glfwSetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSetTime(double time);

		[DllImport(Library, EntryPoint = "glfwGetTimerValue", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong glfwGetTimerValue();

		[DllImport(Library, EntryPoint = "glfwGetTimerFrequency", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong glfwGetTimerFrequency();

		[DllImport(Library, EntryPoint = "glfwMakeContextCurrent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwMakeContextCurrent(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwGetCurrentContext", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwGetCurrentContext();

		[DllImport(Library, EntryPoint = "glfwSwapBuffers", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSwapBuffers(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwSwapInterval", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void glfwSwapInterval(int interval);

		[DllImport(Library, EntryPoint = "glfwExtensionSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwExtensionSupported(string extension);

		[DllImport(Library, EntryPoint = "glfwGetProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwGetProcAddress(string procname);

		[DllImport(Library, EntryPoint = "glfwVulkanSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwVulkanSupported();

		[DllImport(Library, EntryPoint = "glfwGetRequiredInstanceExtensions", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string[] glfwGetRequiredInstanceExtensions(out uint count);

		[DllImport(Library, EntryPoint = "glfwGetInstanceProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr glfwGetInstanceProcAddress(IntPtr instance, string procname);

		[DllImport(Library, EntryPoint = "glfwGetPhysicalDevicePresentationSupport", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwGetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily);

		[DllImport(Library, EntryPoint = "glfwCreateWindowSurface", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int glfwCreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface);

		private class GLFWAssemblyLoadContext : AssemblyLoadContext
		{
			internal void Init()
			{
				this.LoadUnmanagedDllFromPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Environment.Is64BitProcess ? "x64" : "x86", Library));
			}

			protected override Assembly Load(AssemblyName assemblyName) => null;
		}

		static GLFW()
		{
			new GLFWAssemblyLoadContext().Init();
		}
	}
}
