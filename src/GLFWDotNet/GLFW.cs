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

		private static class Delegates
		{
			public delegate int glfwInit();

			public delegate void glfwTerminate();

			public delegate void glfwGetVersion(out int major, out int minor, out int rev);

			public delegate string glfwGetVersionString();

			public delegate GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun cbfun);

			public delegate IntPtr[] glfwGetMonitors(out int count);

			public delegate IntPtr glfwGetPrimaryMonitor();

			public delegate void glfwGetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

			public delegate void glfwGetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

			public delegate string glfwGetMonitorName(IntPtr monitor);

			public delegate GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun cbfun);

			public delegate GLFWvidmode glfwGetVideoModes(IntPtr monitor, out int count);

			public delegate GLFWvidmode glfwGetVideoMode(IntPtr monitor);

			public delegate void glfwSetGamma(IntPtr monitor, float gamma);

			public delegate GLFWgammaramp glfwGetGammaRamp(IntPtr monitor);

			public delegate void glfwSetGammaRamp(IntPtr monitor, GLFWgammaramp ramp);

			public delegate void glfwDefaultWindowHints();

			public delegate void glfwWindowHint(int hint, int value);

			public delegate IntPtr glfwCreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

			public delegate void glfwDestroyWindow(IntPtr window);

			public delegate int glfwWindowShouldClose(IntPtr window);

			public delegate void glfwSetWindowShouldClose(IntPtr window, int value);

			public delegate void glfwSetWindowTitle(IntPtr window, string title);

			public delegate void glfwSetWindowIcon(IntPtr window, int count, GLFWimage images);

			public delegate void glfwGetWindowPos(IntPtr window, out int xpos, out int ypos);

			public delegate void glfwSetWindowPos(IntPtr window, int xpos, int ypos);

			public delegate void glfwGetWindowSize(IntPtr window, out int width, out int height);

			public delegate void glfwSetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

			public delegate void glfwSetWindowAspectRatio(IntPtr window, int numer, int denom);

			public delegate void glfwSetWindowSize(IntPtr window, int width, int height);

			public delegate void glfwGetFramebufferSize(IntPtr window, out int width, out int height);

			public delegate void glfwGetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

			public delegate void glfwIconifyWindow(IntPtr window);

			public delegate void glfwRestoreWindow(IntPtr window);

			public delegate void glfwMaximizeWindow(IntPtr window);

			public delegate void glfwShowWindow(IntPtr window);

			public delegate void glfwHideWindow(IntPtr window);

			public delegate void glfwFocusWindow(IntPtr window);

			public delegate IntPtr glfwGetWindowMonitor(IntPtr window);

			public delegate void glfwSetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

			public delegate int glfwGetWindowAttrib(IntPtr window, int attrib);

			public delegate void glfwSetWindowUserPointer(IntPtr window, IntPtr pointer);

			public delegate IntPtr glfwGetWindowUserPointer(IntPtr window);

			public delegate GLFWwindowposfun glfwSetWindowPosCallback(IntPtr window, GLFWwindowposfun cbfun);

			public delegate GLFWwindowsizefun glfwSetWindowSizeCallback(IntPtr window, GLFWwindowsizefun cbfun);

			public delegate GLFWwindowclosefun glfwSetWindowCloseCallback(IntPtr window, GLFWwindowclosefun cbfun);

			public delegate GLFWwindowrefreshfun glfwSetWindowRefreshCallback(IntPtr window, GLFWwindowrefreshfun cbfun);

			public delegate GLFWwindowfocusfun glfwSetWindowFocusCallback(IntPtr window, GLFWwindowfocusfun cbfun);

			public delegate GLFWwindowiconifyfun glfwSetWindowIconifyCallback(IntPtr window, GLFWwindowiconifyfun cbfun);

			public delegate GLFWframebuffersizefun glfwSetFramebufferSizeCallback(IntPtr window, GLFWframebuffersizefun cbfun);

			public delegate void glfwPollEvents();

			public delegate void glfwWaitEvents();

			public delegate void glfwWaitEventsTimeout(double timeout);

			public delegate void glfwPostEmptyEvent();

			public delegate int glfwGetInputMode(IntPtr window, int mode);

			public delegate void glfwSetInputMode(IntPtr window, int mode, int value);

			public delegate string glfwGetKeyName(int key, int scancode);

			public delegate int glfwGetKey(IntPtr window, int key);

			public delegate int glfwGetMouseButton(IntPtr window, int button);

			public delegate void glfwGetCursorPos(IntPtr window, out double xpos, out double ypos);

			public delegate void glfwSetCursorPos(IntPtr window, double xpos, double ypos);

			public delegate IntPtr glfwCreateCursor(GLFWimage image, int xhot, int yhot);

			public delegate IntPtr glfwCreateStandardCursor(int shape);

			public delegate void glfwDestroyCursor(IntPtr cursor);

			public delegate void glfwSetCursor(IntPtr window, IntPtr cursor);

			public delegate GLFWkeyfun glfwSetKeyCallback(IntPtr window, GLFWkeyfun cbfun);

			public delegate GLFWcharfun glfwSetCharCallback(IntPtr window, GLFWcharfun cbfun);

			public delegate GLFWcharmodsfun glfwSetCharModsCallback(IntPtr window, GLFWcharmodsfun cbfun);

			public delegate GLFWmousebuttonfun glfwSetMouseButtonCallback(IntPtr window, GLFWmousebuttonfun cbfun);

			public delegate GLFWcursorposfun glfwSetCursorPosCallback(IntPtr window, GLFWcursorposfun cbfun);

			public delegate GLFWcursorenterfun glfwSetCursorEnterCallback(IntPtr window, GLFWcursorenterfun cbfun);

			public delegate GLFWscrollfun glfwSetScrollCallback(IntPtr window, GLFWscrollfun cbfun);

			public delegate GLFWdropfun glfwSetDropCallback(IntPtr window, GLFWdropfun cbfun);

			public delegate int glfwJoystickPresent(int joy);

			public delegate float[] glfwGetJoystickAxes(int joy, out int count);

			public delegate string glfwGetJoystickButtons(int joy, out int count);

			public delegate string glfwGetJoystickName(int joy);

			public delegate GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun cbfun);

			public delegate void glfwSetClipboardString(IntPtr window, string @string);

			public delegate string glfwGetClipboardString(IntPtr window);

			public delegate double glfwGetTime();

			public delegate void glfwSetTime(double time);

			public delegate ulong glfwGetTimerValue();

			public delegate ulong glfwGetTimerFrequency();

			public delegate void glfwMakeContextCurrent(IntPtr window);

			public delegate IntPtr glfwGetCurrentContext();

			public delegate void glfwSwapBuffers(IntPtr window);

			public delegate void glfwSwapInterval(int interval);

			public delegate int glfwExtensionSupported(string extension);

			public delegate IntPtr glfwGetProcAddress(string procname);

			public delegate int glfwVulkanSupported();

			public delegate string[] glfwGetRequiredInstanceExtensions(out uint count);

			public delegate IntPtr glfwGetInstanceProcAddress(IntPtr instance, string procname);

			public delegate int glfwGetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily);

			public delegate int glfwCreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface);

		}
		private static Delegates.glfwInit _glfwInit;

		private static Delegates.glfwTerminate _glfwTerminate;

		private static Delegates.glfwGetVersion _glfwGetVersion;

		private static Delegates.glfwGetVersionString _glfwGetVersionString;

		private static Delegates.glfwSetErrorCallback _glfwSetErrorCallback;

		private static Delegates.glfwGetMonitors _glfwGetMonitors;

		private static Delegates.glfwGetPrimaryMonitor _glfwGetPrimaryMonitor;

		private static Delegates.glfwGetMonitorPos _glfwGetMonitorPos;

		private static Delegates.glfwGetMonitorPhysicalSize _glfwGetMonitorPhysicalSize;

		private static Delegates.glfwGetMonitorName _glfwGetMonitorName;

		private static Delegates.glfwSetMonitorCallback _glfwSetMonitorCallback;

		private static Delegates.glfwGetVideoModes _glfwGetVideoModes;

		private static Delegates.glfwGetVideoMode _glfwGetVideoMode;

		private static Delegates.glfwSetGamma _glfwSetGamma;

		private static Delegates.glfwGetGammaRamp _glfwGetGammaRamp;

		private static Delegates.glfwSetGammaRamp _glfwSetGammaRamp;

		private static Delegates.glfwDefaultWindowHints _glfwDefaultWindowHints;

		private static Delegates.glfwWindowHint _glfwWindowHint;

		private static Delegates.glfwCreateWindow _glfwCreateWindow;

		private static Delegates.glfwDestroyWindow _glfwDestroyWindow;

		private static Delegates.glfwWindowShouldClose _glfwWindowShouldClose;

		private static Delegates.glfwSetWindowShouldClose _glfwSetWindowShouldClose;

		private static Delegates.glfwSetWindowTitle _glfwSetWindowTitle;

		private static Delegates.glfwSetWindowIcon _glfwSetWindowIcon;

		private static Delegates.glfwGetWindowPos _glfwGetWindowPos;

		private static Delegates.glfwSetWindowPos _glfwSetWindowPos;

		private static Delegates.glfwGetWindowSize _glfwGetWindowSize;

		private static Delegates.glfwSetWindowSizeLimits _glfwSetWindowSizeLimits;

		private static Delegates.glfwSetWindowAspectRatio _glfwSetWindowAspectRatio;

		private static Delegates.glfwSetWindowSize _glfwSetWindowSize;

		private static Delegates.glfwGetFramebufferSize _glfwGetFramebufferSize;

		private static Delegates.glfwGetWindowFrameSize _glfwGetWindowFrameSize;

		private static Delegates.glfwIconifyWindow _glfwIconifyWindow;

		private static Delegates.glfwRestoreWindow _glfwRestoreWindow;

		private static Delegates.glfwMaximizeWindow _glfwMaximizeWindow;

		private static Delegates.glfwShowWindow _glfwShowWindow;

		private static Delegates.glfwHideWindow _glfwHideWindow;

		private static Delegates.glfwFocusWindow _glfwFocusWindow;

		private static Delegates.glfwGetWindowMonitor _glfwGetWindowMonitor;

		private static Delegates.glfwSetWindowMonitor _glfwSetWindowMonitor;

		private static Delegates.glfwGetWindowAttrib _glfwGetWindowAttrib;

		private static Delegates.glfwSetWindowUserPointer _glfwSetWindowUserPointer;

		private static Delegates.glfwGetWindowUserPointer _glfwGetWindowUserPointer;

		private static Delegates.glfwSetWindowPosCallback _glfwSetWindowPosCallback;

		private static Delegates.glfwSetWindowSizeCallback _glfwSetWindowSizeCallback;

		private static Delegates.glfwSetWindowCloseCallback _glfwSetWindowCloseCallback;

		private static Delegates.glfwSetWindowRefreshCallback _glfwSetWindowRefreshCallback;

		private static Delegates.glfwSetWindowFocusCallback _glfwSetWindowFocusCallback;

		private static Delegates.glfwSetWindowIconifyCallback _glfwSetWindowIconifyCallback;

		private static Delegates.glfwSetFramebufferSizeCallback _glfwSetFramebufferSizeCallback;

		private static Delegates.glfwPollEvents _glfwPollEvents;

		private static Delegates.glfwWaitEvents _glfwWaitEvents;

		private static Delegates.glfwWaitEventsTimeout _glfwWaitEventsTimeout;

		private static Delegates.glfwPostEmptyEvent _glfwPostEmptyEvent;

		private static Delegates.glfwGetInputMode _glfwGetInputMode;

		private static Delegates.glfwSetInputMode _glfwSetInputMode;

		private static Delegates.glfwGetKeyName _glfwGetKeyName;

		private static Delegates.glfwGetKey _glfwGetKey;

		private static Delegates.glfwGetMouseButton _glfwGetMouseButton;

		private static Delegates.glfwGetCursorPos _glfwGetCursorPos;

		private static Delegates.glfwSetCursorPos _glfwSetCursorPos;

		private static Delegates.glfwCreateCursor _glfwCreateCursor;

		private static Delegates.glfwCreateStandardCursor _glfwCreateStandardCursor;

		private static Delegates.glfwDestroyCursor _glfwDestroyCursor;

		private static Delegates.glfwSetCursor _glfwSetCursor;

		private static Delegates.glfwSetKeyCallback _glfwSetKeyCallback;

		private static Delegates.glfwSetCharCallback _glfwSetCharCallback;

		private static Delegates.glfwSetCharModsCallback _glfwSetCharModsCallback;

		private static Delegates.glfwSetMouseButtonCallback _glfwSetMouseButtonCallback;

		private static Delegates.glfwSetCursorPosCallback _glfwSetCursorPosCallback;

		private static Delegates.glfwSetCursorEnterCallback _glfwSetCursorEnterCallback;

		private static Delegates.glfwSetScrollCallback _glfwSetScrollCallback;

		private static Delegates.glfwSetDropCallback _glfwSetDropCallback;

		private static Delegates.glfwJoystickPresent _glfwJoystickPresent;

		private static Delegates.glfwGetJoystickAxes _glfwGetJoystickAxes;

		private static Delegates.glfwGetJoystickButtons _glfwGetJoystickButtons;

		private static Delegates.glfwGetJoystickName _glfwGetJoystickName;

		private static Delegates.glfwSetJoystickCallback _glfwSetJoystickCallback;

		private static Delegates.glfwSetClipboardString _glfwSetClipboardString;

		private static Delegates.glfwGetClipboardString _glfwGetClipboardString;

		private static Delegates.glfwGetTime _glfwGetTime;

		private static Delegates.glfwSetTime _glfwSetTime;

		private static Delegates.glfwGetTimerValue _glfwGetTimerValue;

		private static Delegates.glfwGetTimerFrequency _glfwGetTimerFrequency;

		private static Delegates.glfwMakeContextCurrent _glfwMakeContextCurrent;

		private static Delegates.glfwGetCurrentContext _glfwGetCurrentContext;

		private static Delegates.glfwSwapBuffers _glfwSwapBuffers;

		private static Delegates.glfwSwapInterval _glfwSwapInterval;

		private static Delegates.glfwExtensionSupported _glfwExtensionSupported;

		private static Delegates.glfwGetProcAddress _glfwGetProcAddress;

		private static Delegates.glfwVulkanSupported _glfwVulkanSupported;

		private static Delegates.glfwGetRequiredInstanceExtensions _glfwGetRequiredInstanceExtensions;

		private static Delegates.glfwGetInstanceProcAddress _glfwGetInstanceProcAddress;

		private static Delegates.glfwGetPhysicalDevicePresentationSupport _glfwGetPhysicalDevicePresentationSupport;

		private static Delegates.glfwCreateWindowSurface _glfwCreateWindowSurface;

		private static class Win32
        {
            [DllImport("kernel32")]
            public static extern IntPtr LoadLibrary(string fileName);

            [DllImport("kernel32")]
            public static extern IntPtr GetProcAddress(IntPtr module, string procName);
        }

        public static int glfwInit()
        {
            LoadFunctions(LoadAssembly());
            return _glfwInit();
        }

        private static Func<string, IntPtr> LoadAssembly()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                string assemblyPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Environment.Is64BitProcess ? "x64" : "x86", "glfw3.dll");
                IntPtr assembly = Win32.LoadLibrary(assemblyPath);

                if (assembly == IntPtr.Zero)
                    throw new InvalidOperationException($"Failed to load GLFW dll from path '{assemblyPath}'.");

                return x => Win32.GetProcAddress(assembly, x);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Coming soon...
            }

            throw new NotImplementedException("Unsupported platform.");
        }

		private static void LoadFunctions(Func<string, IntPtr> getProcAddress)
		{
			_glfwInit = (Delegates.glfwInit)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwInit"), typeof(Delegates.glfwInit));
			_glfwTerminate = (Delegates.glfwTerminate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwTerminate"), typeof(Delegates.glfwTerminate));
			_glfwGetVersion = (Delegates.glfwGetVersion)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetVersion"), typeof(Delegates.glfwGetVersion));
			_glfwGetVersionString = (Delegates.glfwGetVersionString)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetVersionString"), typeof(Delegates.glfwGetVersionString));
			_glfwSetErrorCallback = (Delegates.glfwSetErrorCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetErrorCallback"), typeof(Delegates.glfwSetErrorCallback));
			//_glfwGetMonitors = (Delegates.glfwGetMonitors)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetMonitors"), typeof(Delegates.glfwGetMonitors));
			_glfwGetPrimaryMonitor = (Delegates.glfwGetPrimaryMonitor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetPrimaryMonitor"), typeof(Delegates.glfwGetPrimaryMonitor));
			_glfwGetMonitorPos = (Delegates.glfwGetMonitorPos)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetMonitorPos"), typeof(Delegates.glfwGetMonitorPos));
			_glfwGetMonitorPhysicalSize = (Delegates.glfwGetMonitorPhysicalSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetMonitorPhysicalSize"), typeof(Delegates.glfwGetMonitorPhysicalSize));
			_glfwGetMonitorName = (Delegates.glfwGetMonitorName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetMonitorName"), typeof(Delegates.glfwGetMonitorName));
			_glfwSetMonitorCallback = (Delegates.glfwSetMonitorCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetMonitorCallback"), typeof(Delegates.glfwSetMonitorCallback));
			_glfwGetVideoModes = (Delegates.glfwGetVideoModes)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetVideoModes"), typeof(Delegates.glfwGetVideoModes));
			_glfwGetVideoMode = (Delegates.glfwGetVideoMode)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetVideoMode"), typeof(Delegates.glfwGetVideoMode));
			_glfwSetGamma = (Delegates.glfwSetGamma)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetGamma"), typeof(Delegates.glfwSetGamma));
			//_glfwGetGammaRamp = (Delegates.glfwGetGammaRamp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetGammaRamp"), typeof(Delegates.glfwGetGammaRamp));
			_glfwSetGammaRamp = (Delegates.glfwSetGammaRamp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetGammaRamp"), typeof(Delegates.glfwSetGammaRamp));
			_glfwDefaultWindowHints = (Delegates.glfwDefaultWindowHints)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwDefaultWindowHints"), typeof(Delegates.glfwDefaultWindowHints));
			_glfwWindowHint = (Delegates.glfwWindowHint)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwWindowHint"), typeof(Delegates.glfwWindowHint));
			_glfwCreateWindow = (Delegates.glfwCreateWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwCreateWindow"), typeof(Delegates.glfwCreateWindow));
			_glfwDestroyWindow = (Delegates.glfwDestroyWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwDestroyWindow"), typeof(Delegates.glfwDestroyWindow));
			_glfwWindowShouldClose = (Delegates.glfwWindowShouldClose)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwWindowShouldClose"), typeof(Delegates.glfwWindowShouldClose));
			_glfwSetWindowShouldClose = (Delegates.glfwSetWindowShouldClose)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowShouldClose"), typeof(Delegates.glfwSetWindowShouldClose));
			_glfwSetWindowTitle = (Delegates.glfwSetWindowTitle)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowTitle"), typeof(Delegates.glfwSetWindowTitle));
			_glfwSetWindowIcon = (Delegates.glfwSetWindowIcon)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowIcon"), typeof(Delegates.glfwSetWindowIcon));
			_glfwGetWindowPos = (Delegates.glfwGetWindowPos)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetWindowPos"), typeof(Delegates.glfwGetWindowPos));
			_glfwSetWindowPos = (Delegates.glfwSetWindowPos)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowPos"), typeof(Delegates.glfwSetWindowPos));
			_glfwGetWindowSize = (Delegates.glfwGetWindowSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetWindowSize"), typeof(Delegates.glfwGetWindowSize));
			_glfwSetWindowSizeLimits = (Delegates.glfwSetWindowSizeLimits)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowSizeLimits"), typeof(Delegates.glfwSetWindowSizeLimits));
			_glfwSetWindowAspectRatio = (Delegates.glfwSetWindowAspectRatio)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowAspectRatio"), typeof(Delegates.glfwSetWindowAspectRatio));
			_glfwSetWindowSize = (Delegates.glfwSetWindowSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowSize"), typeof(Delegates.glfwSetWindowSize));
			_glfwGetFramebufferSize = (Delegates.glfwGetFramebufferSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetFramebufferSize"), typeof(Delegates.glfwGetFramebufferSize));
			_glfwGetWindowFrameSize = (Delegates.glfwGetWindowFrameSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetWindowFrameSize"), typeof(Delegates.glfwGetWindowFrameSize));
			_glfwIconifyWindow = (Delegates.glfwIconifyWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwIconifyWindow"), typeof(Delegates.glfwIconifyWindow));
			_glfwRestoreWindow = (Delegates.glfwRestoreWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwRestoreWindow"), typeof(Delegates.glfwRestoreWindow));
			_glfwMaximizeWindow = (Delegates.glfwMaximizeWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwMaximizeWindow"), typeof(Delegates.glfwMaximizeWindow));
			_glfwShowWindow = (Delegates.glfwShowWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwShowWindow"), typeof(Delegates.glfwShowWindow));
			_glfwHideWindow = (Delegates.glfwHideWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwHideWindow"), typeof(Delegates.glfwHideWindow));
			_glfwFocusWindow = (Delegates.glfwFocusWindow)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwFocusWindow"), typeof(Delegates.glfwFocusWindow));
			_glfwGetWindowMonitor = (Delegates.glfwGetWindowMonitor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetWindowMonitor"), typeof(Delegates.glfwGetWindowMonitor));
			_glfwSetWindowMonitor = (Delegates.glfwSetWindowMonitor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowMonitor"), typeof(Delegates.glfwSetWindowMonitor));
			_glfwGetWindowAttrib = (Delegates.glfwGetWindowAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetWindowAttrib"), typeof(Delegates.glfwGetWindowAttrib));
			_glfwSetWindowUserPointer = (Delegates.glfwSetWindowUserPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowUserPointer"), typeof(Delegates.glfwSetWindowUserPointer));
			_glfwGetWindowUserPointer = (Delegates.glfwGetWindowUserPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetWindowUserPointer"), typeof(Delegates.glfwGetWindowUserPointer));
			_glfwSetWindowPosCallback = (Delegates.glfwSetWindowPosCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowPosCallback"), typeof(Delegates.glfwSetWindowPosCallback));
			_glfwSetWindowSizeCallback = (Delegates.glfwSetWindowSizeCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowSizeCallback"), typeof(Delegates.glfwSetWindowSizeCallback));
			_glfwSetWindowCloseCallback = (Delegates.glfwSetWindowCloseCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowCloseCallback"), typeof(Delegates.glfwSetWindowCloseCallback));
			_glfwSetWindowRefreshCallback = (Delegates.glfwSetWindowRefreshCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowRefreshCallback"), typeof(Delegates.glfwSetWindowRefreshCallback));
			_glfwSetWindowFocusCallback = (Delegates.glfwSetWindowFocusCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowFocusCallback"), typeof(Delegates.glfwSetWindowFocusCallback));
			_glfwSetWindowIconifyCallback = (Delegates.glfwSetWindowIconifyCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetWindowIconifyCallback"), typeof(Delegates.glfwSetWindowIconifyCallback));
			_glfwSetFramebufferSizeCallback = (Delegates.glfwSetFramebufferSizeCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetFramebufferSizeCallback"), typeof(Delegates.glfwSetFramebufferSizeCallback));
			_glfwPollEvents = (Delegates.glfwPollEvents)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwPollEvents"), typeof(Delegates.glfwPollEvents));
			_glfwWaitEvents = (Delegates.glfwWaitEvents)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwWaitEvents"), typeof(Delegates.glfwWaitEvents));
			_glfwWaitEventsTimeout = (Delegates.glfwWaitEventsTimeout)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwWaitEventsTimeout"), typeof(Delegates.glfwWaitEventsTimeout));
			_glfwPostEmptyEvent = (Delegates.glfwPostEmptyEvent)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwPostEmptyEvent"), typeof(Delegates.glfwPostEmptyEvent));
			_glfwGetInputMode = (Delegates.glfwGetInputMode)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetInputMode"), typeof(Delegates.glfwGetInputMode));
			_glfwSetInputMode = (Delegates.glfwSetInputMode)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetInputMode"), typeof(Delegates.glfwSetInputMode));
			_glfwGetKeyName = (Delegates.glfwGetKeyName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetKeyName"), typeof(Delegates.glfwGetKeyName));
			_glfwGetKey = (Delegates.glfwGetKey)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetKey"), typeof(Delegates.glfwGetKey));
			_glfwGetMouseButton = (Delegates.glfwGetMouseButton)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetMouseButton"), typeof(Delegates.glfwGetMouseButton));
			_glfwGetCursorPos = (Delegates.glfwGetCursorPos)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetCursorPos"), typeof(Delegates.glfwGetCursorPos));
			_glfwSetCursorPos = (Delegates.glfwSetCursorPos)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetCursorPos"), typeof(Delegates.glfwSetCursorPos));
			_glfwCreateCursor = (Delegates.glfwCreateCursor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwCreateCursor"), typeof(Delegates.glfwCreateCursor));
			_glfwCreateStandardCursor = (Delegates.glfwCreateStandardCursor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwCreateStandardCursor"), typeof(Delegates.glfwCreateStandardCursor));
			_glfwDestroyCursor = (Delegates.glfwDestroyCursor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwDestroyCursor"), typeof(Delegates.glfwDestroyCursor));
			_glfwSetCursor = (Delegates.glfwSetCursor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetCursor"), typeof(Delegates.glfwSetCursor));
			_glfwSetKeyCallback = (Delegates.glfwSetKeyCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetKeyCallback"), typeof(Delegates.glfwSetKeyCallback));
			_glfwSetCharCallback = (Delegates.glfwSetCharCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetCharCallback"), typeof(Delegates.glfwSetCharCallback));
			_glfwSetCharModsCallback = (Delegates.glfwSetCharModsCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetCharModsCallback"), typeof(Delegates.glfwSetCharModsCallback));
			_glfwSetMouseButtonCallback = (Delegates.glfwSetMouseButtonCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetMouseButtonCallback"), typeof(Delegates.glfwSetMouseButtonCallback));
			_glfwSetCursorPosCallback = (Delegates.glfwSetCursorPosCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetCursorPosCallback"), typeof(Delegates.glfwSetCursorPosCallback));
			_glfwSetCursorEnterCallback = (Delegates.glfwSetCursorEnterCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetCursorEnterCallback"), typeof(Delegates.glfwSetCursorEnterCallback));
			_glfwSetScrollCallback = (Delegates.glfwSetScrollCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetScrollCallback"), typeof(Delegates.glfwSetScrollCallback));
			_glfwSetDropCallback = (Delegates.glfwSetDropCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetDropCallback"), typeof(Delegates.glfwSetDropCallback));
			_glfwJoystickPresent = (Delegates.glfwJoystickPresent)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwJoystickPresent"), typeof(Delegates.glfwJoystickPresent));
			//_glfwGetJoystickAxes = (Delegates.glfwGetJoystickAxes)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetJoystickAxes"), typeof(Delegates.glfwGetJoystickAxes));
			_glfwGetJoystickButtons = (Delegates.glfwGetJoystickButtons)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetJoystickButtons"), typeof(Delegates.glfwGetJoystickButtons));
			_glfwGetJoystickName = (Delegates.glfwGetJoystickName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetJoystickName"), typeof(Delegates.glfwGetJoystickName));
			_glfwSetJoystickCallback = (Delegates.glfwSetJoystickCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetJoystickCallback"), typeof(Delegates.glfwSetJoystickCallback));
			_glfwSetClipboardString = (Delegates.glfwSetClipboardString)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetClipboardString"), typeof(Delegates.glfwSetClipboardString));
			_glfwGetClipboardString = (Delegates.glfwGetClipboardString)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetClipboardString"), typeof(Delegates.glfwGetClipboardString));
			_glfwGetTime = (Delegates.glfwGetTime)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetTime"), typeof(Delegates.glfwGetTime));
			_glfwSetTime = (Delegates.glfwSetTime)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSetTime"), typeof(Delegates.glfwSetTime));
			_glfwGetTimerValue = (Delegates.glfwGetTimerValue)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetTimerValue"), typeof(Delegates.glfwGetTimerValue));
			_glfwGetTimerFrequency = (Delegates.glfwGetTimerFrequency)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetTimerFrequency"), typeof(Delegates.glfwGetTimerFrequency));
			_glfwMakeContextCurrent = (Delegates.glfwMakeContextCurrent)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwMakeContextCurrent"), typeof(Delegates.glfwMakeContextCurrent));
			_glfwGetCurrentContext = (Delegates.glfwGetCurrentContext)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetCurrentContext"), typeof(Delegates.glfwGetCurrentContext));
			_glfwSwapBuffers = (Delegates.glfwSwapBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSwapBuffers"), typeof(Delegates.glfwSwapBuffers));
			_glfwSwapInterval = (Delegates.glfwSwapInterval)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwSwapInterval"), typeof(Delegates.glfwSwapInterval));
			_glfwExtensionSupported = (Delegates.glfwExtensionSupported)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwExtensionSupported"), typeof(Delegates.glfwExtensionSupported));
			_glfwGetProcAddress = (Delegates.glfwGetProcAddress)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetProcAddress"), typeof(Delegates.glfwGetProcAddress));
			_glfwVulkanSupported = (Delegates.glfwVulkanSupported)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwVulkanSupported"), typeof(Delegates.glfwVulkanSupported));
			//_glfwGetRequiredInstanceExtensions = (Delegates.glfwGetRequiredInstanceExtensions)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetRequiredInstanceExtensions"), typeof(Delegates.glfwGetRequiredInstanceExtensions));
			_glfwGetInstanceProcAddress = (Delegates.glfwGetInstanceProcAddress)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetInstanceProcAddress"), typeof(Delegates.glfwGetInstanceProcAddress));
			_glfwGetPhysicalDevicePresentationSupport = (Delegates.glfwGetPhysicalDevicePresentationSupport)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwGetPhysicalDevicePresentationSupport"), typeof(Delegates.glfwGetPhysicalDevicePresentationSupport));
			_glfwCreateWindowSurface = (Delegates.glfwCreateWindowSurface)Marshal.GetDelegateForFunctionPointer(getProcAddress("glfwCreateWindowSurface"), typeof(Delegates.glfwCreateWindowSurface));
		}

		public static void glfwTerminate()
		{
			_glfwTerminate();
		}

		public static void glfwGetVersion(out int major, out int minor, out int rev)
		{
			_glfwGetVersion(out major, out minor, out rev);
		}

		public static string glfwGetVersionString()
		{
			return _glfwGetVersionString();
		}

		public static GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun cbfun)
		{
			return _glfwSetErrorCallback(cbfun);
		}

		public static IntPtr[] glfwGetMonitors(out int count)
		{
			return _glfwGetMonitors(out count);
		}

		public static IntPtr glfwGetPrimaryMonitor()
		{
			return _glfwGetPrimaryMonitor();
		}

		public static void glfwGetMonitorPos(IntPtr monitor, out int xpos, out int ypos)
		{
			_glfwGetMonitorPos(monitor, out xpos, out ypos);
		}

		public static void glfwGetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM)
		{
			_glfwGetMonitorPhysicalSize(monitor, out widthMM, out heightMM);
		}

		public static string glfwGetMonitorName(IntPtr monitor)
		{
			return _glfwGetMonitorName(monitor);
		}

		public static GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun cbfun)
		{
			return _glfwSetMonitorCallback(cbfun);
		}

		public static GLFWvidmode glfwGetVideoModes(IntPtr monitor, out int count)
		{
			return _glfwGetVideoModes(monitor, out count);
		}

		public static GLFWvidmode glfwGetVideoMode(IntPtr monitor)
		{
			return _glfwGetVideoMode(monitor);
		}

		public static void glfwSetGamma(IntPtr monitor, float gamma)
		{
			_glfwSetGamma(monitor, gamma);
		}

		public static GLFWgammaramp glfwGetGammaRamp(IntPtr monitor)
		{
			return _glfwGetGammaRamp(monitor);
		}

		public static void glfwSetGammaRamp(IntPtr monitor, GLFWgammaramp ramp)
		{
			_glfwSetGammaRamp(monitor, ramp);
		}

		public static void glfwDefaultWindowHints()
		{
			_glfwDefaultWindowHints();
		}

		public static void glfwWindowHint(int hint, int value)
		{
			_glfwWindowHint(hint, value);
		}

		public static IntPtr glfwCreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share)
		{
			return _glfwCreateWindow(width, height, title, monitor, share);
		}

		public static void glfwDestroyWindow(IntPtr window)
		{
			_glfwDestroyWindow(window);
		}

		public static int glfwWindowShouldClose(IntPtr window)
		{
			return _glfwWindowShouldClose(window);
		}

		public static void glfwSetWindowShouldClose(IntPtr window, int value)
		{
			_glfwSetWindowShouldClose(window, value);
		}

		public static void glfwSetWindowTitle(IntPtr window, string title)
		{
			_glfwSetWindowTitle(window, title);
		}

		public static void glfwSetWindowIcon(IntPtr window, int count, GLFWimage images)
		{
			_glfwSetWindowIcon(window, count, images);
		}

		public static void glfwGetWindowPos(IntPtr window, out int xpos, out int ypos)
		{
			_glfwGetWindowPos(window, out xpos, out ypos);
		}

		public static void glfwSetWindowPos(IntPtr window, int xpos, int ypos)
		{
			_glfwSetWindowPos(window, xpos, ypos);
		}

		public static void glfwGetWindowSize(IntPtr window, out int width, out int height)
		{
			_glfwGetWindowSize(window, out width, out height);
		}

		public static void glfwSetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight)
		{
			_glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
		}

		public static void glfwSetWindowAspectRatio(IntPtr window, int numer, int denom)
		{
			_glfwSetWindowAspectRatio(window, numer, denom);
		}

		public static void glfwSetWindowSize(IntPtr window, int width, int height)
		{
			_glfwSetWindowSize(window, width, height);
		}

		public static void glfwGetFramebufferSize(IntPtr window, out int width, out int height)
		{
			_glfwGetFramebufferSize(window, out width, out height);
		}

		public static void glfwGetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom)
		{
			_glfwGetWindowFrameSize(window, out left, out top, out right, out bottom);
		}

		public static void glfwIconifyWindow(IntPtr window)
		{
			_glfwIconifyWindow(window);
		}

		public static void glfwRestoreWindow(IntPtr window)
		{
			_glfwRestoreWindow(window);
		}

		public static void glfwMaximizeWindow(IntPtr window)
		{
			_glfwMaximizeWindow(window);
		}

		public static void glfwShowWindow(IntPtr window)
		{
			_glfwShowWindow(window);
		}

		public static void glfwHideWindow(IntPtr window)
		{
			_glfwHideWindow(window);
		}

		public static void glfwFocusWindow(IntPtr window)
		{
			_glfwFocusWindow(window);
		}

		public static IntPtr glfwGetWindowMonitor(IntPtr window)
		{
			return _glfwGetWindowMonitor(window);
		}

		public static void glfwSetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate)
		{
			_glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
		}

		public static int glfwGetWindowAttrib(IntPtr window, int attrib)
		{
			return _glfwGetWindowAttrib(window, attrib);
		}

		public static void glfwSetWindowUserPointer(IntPtr window, IntPtr pointer)
		{
			_glfwSetWindowUserPointer(window, pointer);
		}

		public static IntPtr glfwGetWindowUserPointer(IntPtr window)
		{
			return _glfwGetWindowUserPointer(window);
		}

		public static GLFWwindowposfun glfwSetWindowPosCallback(IntPtr window, GLFWwindowposfun cbfun)
		{
			return _glfwSetWindowPosCallback(window, cbfun);
		}

		public static GLFWwindowsizefun glfwSetWindowSizeCallback(IntPtr window, GLFWwindowsizefun cbfun)
		{
			return _glfwSetWindowSizeCallback(window, cbfun);
		}

		public static GLFWwindowclosefun glfwSetWindowCloseCallback(IntPtr window, GLFWwindowclosefun cbfun)
		{
			return _glfwSetWindowCloseCallback(window, cbfun);
		}

		public static GLFWwindowrefreshfun glfwSetWindowRefreshCallback(IntPtr window, GLFWwindowrefreshfun cbfun)
		{
			return _glfwSetWindowRefreshCallback(window, cbfun);
		}

		public static GLFWwindowfocusfun glfwSetWindowFocusCallback(IntPtr window, GLFWwindowfocusfun cbfun)
		{
			return _glfwSetWindowFocusCallback(window, cbfun);
		}

		public static GLFWwindowiconifyfun glfwSetWindowIconifyCallback(IntPtr window, GLFWwindowiconifyfun cbfun)
		{
			return _glfwSetWindowIconifyCallback(window, cbfun);
		}

		public static GLFWframebuffersizefun glfwSetFramebufferSizeCallback(IntPtr window, GLFWframebuffersizefun cbfun)
		{
			return _glfwSetFramebufferSizeCallback(window, cbfun);
		}

		public static void glfwPollEvents()
		{
			_glfwPollEvents();
		}

		public static void glfwWaitEvents()
		{
			_glfwWaitEvents();
		}

		public static void glfwWaitEventsTimeout(double timeout)
		{
			_glfwWaitEventsTimeout(timeout);
		}

		public static void glfwPostEmptyEvent()
		{
			_glfwPostEmptyEvent();
		}

		public static int glfwGetInputMode(IntPtr window, int mode)
		{
			return _glfwGetInputMode(window, mode);
		}

		public static void glfwSetInputMode(IntPtr window, int mode, int value)
		{
			_glfwSetInputMode(window, mode, value);
		}

		public static string glfwGetKeyName(int key, int scancode)
		{
			return _glfwGetKeyName(key, scancode);
		}

		public static int glfwGetKey(IntPtr window, int key)
		{
			return _glfwGetKey(window, key);
		}

		public static int glfwGetMouseButton(IntPtr window, int button)
		{
			return _glfwGetMouseButton(window, button);
		}

		public static void glfwGetCursorPos(IntPtr window, out double xpos, out double ypos)
		{
			_glfwGetCursorPos(window, out xpos, out ypos);
		}

		public static void glfwSetCursorPos(IntPtr window, double xpos, double ypos)
		{
			_glfwSetCursorPos(window, xpos, ypos);
		}

		public static IntPtr glfwCreateCursor(GLFWimage image, int xhot, int yhot)
		{
			return _glfwCreateCursor(image, xhot, yhot);
		}

		public static IntPtr glfwCreateStandardCursor(int shape)
		{
			return _glfwCreateStandardCursor(shape);
		}

		public static void glfwDestroyCursor(IntPtr cursor)
		{
			_glfwDestroyCursor(cursor);
		}

		public static void glfwSetCursor(IntPtr window, IntPtr cursor)
		{
			_glfwSetCursor(window, cursor);
		}

		public static GLFWkeyfun glfwSetKeyCallback(IntPtr window, GLFWkeyfun cbfun)
		{
			return _glfwSetKeyCallback(window, cbfun);
		}

		public static GLFWcharfun glfwSetCharCallback(IntPtr window, GLFWcharfun cbfun)
		{
			return _glfwSetCharCallback(window, cbfun);
		}

		public static GLFWcharmodsfun glfwSetCharModsCallback(IntPtr window, GLFWcharmodsfun cbfun)
		{
			return _glfwSetCharModsCallback(window, cbfun);
		}

		public static GLFWmousebuttonfun glfwSetMouseButtonCallback(IntPtr window, GLFWmousebuttonfun cbfun)
		{
			return _glfwSetMouseButtonCallback(window, cbfun);
		}

		public static GLFWcursorposfun glfwSetCursorPosCallback(IntPtr window, GLFWcursorposfun cbfun)
		{
			return _glfwSetCursorPosCallback(window, cbfun);
		}

		public static GLFWcursorenterfun glfwSetCursorEnterCallback(IntPtr window, GLFWcursorenterfun cbfun)
		{
			return _glfwSetCursorEnterCallback(window, cbfun);
		}

		public static GLFWscrollfun glfwSetScrollCallback(IntPtr window, GLFWscrollfun cbfun)
		{
			return _glfwSetScrollCallback(window, cbfun);
		}

		public static GLFWdropfun glfwSetDropCallback(IntPtr window, GLFWdropfun cbfun)
		{
			return _glfwSetDropCallback(window, cbfun);
		}

		public static int glfwJoystickPresent(int joy)
		{
			return _glfwJoystickPresent(joy);
		}

		public static float[] glfwGetJoystickAxes(int joy, out int count)
		{
			return _glfwGetJoystickAxes(joy, out count);
		}

		public static string glfwGetJoystickButtons(int joy, out int count)
		{
			return _glfwGetJoystickButtons(joy, out count);
		}

		public static string glfwGetJoystickName(int joy)
		{
			return _glfwGetJoystickName(joy);
		}

		public static GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun cbfun)
		{
			return _glfwSetJoystickCallback(cbfun);
		}

		public static void glfwSetClipboardString(IntPtr window, string @string)
		{
			_glfwSetClipboardString(window, @string);
		}

		public static string glfwGetClipboardString(IntPtr window)
		{
			return _glfwGetClipboardString(window);
		}

		public static double glfwGetTime()
		{
			return _glfwGetTime();
		}

		public static void glfwSetTime(double time)
		{
			_glfwSetTime(time);
		}

		public static ulong glfwGetTimerValue()
		{
			return _glfwGetTimerValue();
		}

		public static ulong glfwGetTimerFrequency()
		{
			return _glfwGetTimerFrequency();
		}

		public static void glfwMakeContextCurrent(IntPtr window)
		{
			_glfwMakeContextCurrent(window);
		}

		public static IntPtr glfwGetCurrentContext()
		{
			return _glfwGetCurrentContext();
		}

		public static void glfwSwapBuffers(IntPtr window)
		{
			_glfwSwapBuffers(window);
		}

		public static void glfwSwapInterval(int interval)
		{
			_glfwSwapInterval(interval);
		}

		public static int glfwExtensionSupported(string extension)
		{
			return _glfwExtensionSupported(extension);
		}

		public static IntPtr glfwGetProcAddress(string procname)
		{
			return _glfwGetProcAddress(procname);
		}

		public static int glfwVulkanSupported()
		{
			return _glfwVulkanSupported();
		}

		public static string[] glfwGetRequiredInstanceExtensions(out uint count)
		{
			return _glfwGetRequiredInstanceExtensions(out count);
		}

		public static IntPtr glfwGetInstanceProcAddress(IntPtr instance, string procname)
		{
			return _glfwGetInstanceProcAddress(instance, procname);
		}

		public static int glfwGetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily)
		{
			return _glfwGetPhysicalDevicePresentationSupport(instance, device, queuefamily);
		}

		public static int glfwCreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface)
		{
			return _glfwCreateWindowSurface(instance, window, allocator, out surface);
		}

	}
}
