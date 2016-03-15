using System;
using System.Runtime.InteropServices;

namespace GLFWDotNet
{
	public static partial class GLFW
	{
		public const int VERSION_MAJOR = 3;
		public const int VERSION_MINOR = 1;
		public const int VERSION_REVISION = 2;
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
		public const int FOCUSED = 0x00020001;
		public const int ICONIFIED = 0x00020002;
		public const int RESIZABLE = 0x00020003;
		public const int VISIBLE = 0x00020004;
		public const int DECORATED = 0x00020005;
		public const int AUTO_ICONIFY = 0x00020006;
		public const int FLOATING = 0x00020007;
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
		}

		public struct GammaRamp
		{
		}

		public struct Image
		{
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
		public delegate void WindowSizeFun(IntPtr window, int width, int height);

		/// <summary>
		/// This is the function signature for window close callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that the user attempted to close.
		/// </param>
		public delegate void WindowCloseFun(IntPtr window);

		/// <summary>
		/// This is the function signature for window refresh callback functions.
		/// </summary>
		/// <param name="window">
		/// The window whose content needs to be refreshed.
		/// </param>
		public delegate void WindowRefreshFun(IntPtr window);

		/// <summary>
		/// This is the function signature for window focus callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that gained or lost input focus.
		/// </param>
		/// <param name="focused">
		/// `GL_TRUE` if the window was given input focus, or
		/// `GL_FALSE` if it lost it.
		/// </param>
		public delegate void WindowFocusFun(IntPtr window, int focused);

		/// <summary>
		/// This is the function signature for window iconify/restore callback
		/// functions.
		/// </summary>
		/// <param name="window">
		/// The window that was iconified or restored.
		/// </param>
		/// <param name="iconified">
		/// `GL_TRUE` if the window was iconified, or `GL_FALSE`
		/// if it was restored.
		/// </param>
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
		public delegate void MouseButtonFun(IntPtr window, int button, int action, int mods);

		/// <summary>
		/// This is the function signature for cursor position callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="xpos">
		/// The new x-coordinate, in screen coordinates, of the cursor.
		/// </param>
		/// <param name="ypos">
		/// The new y-coordinate, in screen coordinates, of the cursor.
		/// </param>
		public delegate void CursorPosFun(IntPtr window, double xpos, double ypos);

		/// <summary>
		/// This is the function signature for cursor enter/leave callback functions.
		/// </summary>
		/// <param name="window">
		/// The window that received the event.
		/// </param>
		/// <param name="entered">
		/// `GL_TRUE` if the cursor entered the window's client
		/// area, or `GL_FALSE` if it left it.
		/// </param>
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
		public delegate void MonitorFun(IntPtr monitor, int @event);

		/// <summary>
		/// This function initializes the GLFW library.  Before most GLFW functions can
		/// be used, GLFW must be initialized, and before an application terminates GLFW
		/// should be terminated in order to free any resources allocated during or
		/// after initialization.
		/// </summary>
		/// <remarks>
		/// __OS X:__ This function will change the current directory of the
		/// application to the `Contents/Resources` subdirectory of the application's
		/// bundle, if present.  This can be disabled with a
		/// [compile-time option](@ref compile_options_osx).
		/// </remarks>
		/// <returns>
		/// `GL_TRUE` if successful, or `GL_FALSE` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwInit", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int Init();

		/// <summary>
		/// This function destroys all remaining windows and cursors, restores any
		/// modified gamma ramps and frees any other allocated resources.  Once this
		/// function is called, you must again call @ref glfwInit successfully before
		/// you will be able to use most GLFW functions.
		/// </summary>
		/// <remarks>
		/// This function may be called before @ref glfwInit.
		/// </remarks>
		[DllImport(Library, EntryPoint = "glfwTerminate", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void Terminate();

		/// <summary>
		/// This function retrieves the major, minor and revision numbers of the GLFW
		/// library.  It is intended for when you are using GLFW as a shared library and
		/// want to ensure that you are using the minimum required version.
		/// </summary>
		/// <remarks>
		/// This function may be called before @ref glfwInit.
		/// </remarks>
		/// <param name="major">
		/// Where to store the major version number, or `NULL`.
		/// </param>
		/// <param name="minor">
		/// Where to store the minor version number, or `NULL`.
		/// </param>
		/// <param name="rev">
		/// Where to store the revision number, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetVersion", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetVersion(out int major, out int minor, out int rev);

		/// <summary>
		/// This function returns the compile-time generated
		/// [version string](@ref intro_version_string) of the GLFW library binary.  It
		/// describes the version, platform, compiler and any platform-specific
		/// compile-time options.
		/// </summary>
		/// <remarks>
		/// This function may be called before @ref glfwInit.
		/// </remarks>
		/// <returns>
		/// The GLFW version string.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetVersionString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string GetVersionString();

		/// <summary>
		/// This function sets the error callback, which is called with an error code
		/// and a human-readable description each time a GLFW error occurs.
		/// </summary>
		/// <remarks>
		/// This function may be called before @ref glfwInit.
		/// </remarks>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetErrorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern ErrorFun SetErrorCallback(ErrorFun cbfun);

		/// <summary>
		/// This function returns an array of handles for all currently connected
		/// monitors.  The primary monitor is always first in the returned array.  If no
		/// monitors were found, this function returns `NULL`.
		/// </summary>
		/// <param name="count">
		/// Where to store the number of monitors in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of monitor handles, or `NULL` if no monitors were found or
		/// if an [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetMonitors", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr[] GetMonitors(out int count);

		/// <summary>
		/// This function returns the primary monitor.  This is usually the monitor
		/// where elements like the task bar or global menu bar are located.
		/// </summary>
		/// <remarks>
		/// The primary monitor is always first in the array returned by @ref
		/// glfwGetMonitors.
		/// </remarks>
		/// <returns>
		/// The primary monitor, or `NULL` if no monitors were found or if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetPrimaryMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetPrimaryMonitor();

		/// <summary>
		/// This function returns the position, in screen coordinates, of the upper-left
		/// corner of the specified monitor.
		/// </summary>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="xpos">
		/// Where to store the monitor x-coordinate, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the monitor y-coordinate, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetMonitorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

		/// <summary>
		/// This function returns the size, in millimetres, of the display area of the
		/// specified monitor.
		/// </summary>
		/// <remarks>
		/// __Windows:__ The OS calculates the returned physical size from the
		/// current resolution and system DPI instead of querying the monitor EDID data.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="widthMM">
		/// Where to store the width, in millimetres, of the
		/// monitor's display area, or `NULL`.
		/// </param>
		/// <param name="heightMM">
		/// Where to store the height, in millimetres, of the
		/// monitor's display area, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetMonitorPhysicalSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

		/// <summary>
		/// This function returns a human-readable name, encoded as UTF-8, of the
		/// specified monitor.  The name typically reflects the make and model of the
		/// monitor and is not guaranteed to be unique among the connected monitors.
		/// </summary>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded name of the monitor, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetMonitorName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string GetMonitorName(IntPtr monitor);

		/// <summary>
		/// This function sets the monitor configuration callback, or removes the
		/// currently set callback.  This is called when a monitor is connected to or
		/// disconnected from the system.
		/// </summary>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetMonitorCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern MonitorFun SetMonitorCallback(MonitorFun cbfun);

		/// <summary>
		/// This function returns an array of all video modes supported by the specified
		/// monitor.  The returned array is sorted in ascending order, first by color
		/// bit depth (the sum of all channel depths) and then by resolution area (the
		/// product of width and height).
		/// </summary>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of video modes in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of video modes, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetVideoModes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern VidMode GetVideoModes(IntPtr monitor, out int count);

		/// <summary>
		/// This function returns the current video mode of the specified monitor.  If
		/// you have created a full screen window for that monitor, the return value
		/// will depend on whether that window is iconified.
		/// </summary>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <returns>
		/// The current mode of the monitor, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetVideoMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern VidMode GetVideoMode(IntPtr monitor);

		/// <summary>
		/// This function generates a 256-element gamma ramp from the specified exponent
		/// and then calls @ref glfwSetGammaRamp with it.  The value must be a finite
		/// number greater than zero.
		/// </summary>
		/// <param name="monitor">
		/// The monitor whose gamma ramp to set.
		/// </param>
		/// <param name="gamma">
		/// The desired exponent.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetGamma", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetGamma(IntPtr monitor, float gamma);

		/// <summary>
		/// This function returns the current gamma ramp of the specified monitor.
		/// </summary>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <returns>
		/// The current gamma ramp, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern GammaRamp GetGammaRamp(IntPtr monitor);

		/// <summary>
		/// This function sets the current gamma ramp for the specified monitor.  The
		/// original gamma ramp for that monitor is saved by GLFW the first time this
		/// function is called and is restored by @ref glfwTerminate.
		/// </summary>
		/// <remarks>
		/// __Windows:__ The gamma ramp size must be 256.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor whose gamma ramp to set.
		/// </param>
		/// <param name="ramp">
		/// The gamma ramp to use.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetGammaRamp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetGammaRamp(IntPtr monitor, GammaRamp ramp);

		/// <summary>
		/// This function resets all window hints to their
		/// [default values](@ref window_hints_values).
		/// </summary>
		[DllImport(Library, EntryPoint = "glfwDefaultWindowHints", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void DefaultWindowHints();

		/// <summary>
		/// This function sets hints for the next call to @ref glfwCreateWindow.  The
		/// hints, once set, retain their values until changed by a call to @ref
		/// glfwWindowHint or @ref glfwDefaultWindowHints, or until the library is
		/// terminated.
		/// </summary>
		/// <param name="target">
		/// The [window hint](@ref window_hints) to set.
		/// </param>
		/// <param name="hint">
		/// The new value of the window hint.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwWindowHint", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void WindowHint(int target, int hint);

		/// <summary>
		/// This function creates a window and its associated OpenGL or OpenGL ES
		/// context.  Most of the options controlling how the window and its context
		/// should be created are specified with [window hints](@ref window_hints).
		/// </summary>
		/// <remarks>
		/// __X11:__ Due to the asynchronous nature of X11, it may take
		/// a moment for a window to reach its requested state.  This means you may not
		/// be able to query the final size, position or other attributes directly after
		/// window creation.
		/// </remarks>
		/// <param name="width">
		/// The desired width, in screen coordinates, of the window.
		/// This must be greater than zero.
		/// </param>
		/// <param name="height">
		/// The desired height, in screen coordinates, of the window.
		/// This must be greater than zero.
		/// </param>
		/// <param name="title">
		/// The initial, UTF-8 encoded window title.
		/// </param>
		/// <param name="monitor">
		/// The monitor to use for full screen mode, or `NULL` to use
		/// windowed mode.
		/// </param>
		/// <param name="share">
		/// The window whose context to share resources with, or `NULL`
		/// to not share resources.
		/// </param>
		/// <returns>
		/// The handle of the created window, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwCreateWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

		/// <summary>
		/// This function destroys the specified window and its context.  On calling
		/// this function, no further callbacks will be called for that window.
		/// </summary>
		/// <param name="window">
		/// The window to destroy.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwDestroyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void DestroyWindow(IntPtr window);

		/// <summary>
		/// This function returns the value of the close flag of the specified window.
		/// </summary>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <returns>
		/// The value of the close flag.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int WindowShouldClose(IntPtr window);

		/// <summary>
		/// This function sets the value of the close flag of the specified window.
		/// This can be used to override the user's attempt to close the window, or
		/// to signal that it should be closed.
		/// </summary>
		/// <param name="window">
		/// The window whose flag to change.
		/// </param>
		/// <param name="value">
		/// The new value.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetWindowShouldClose", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowShouldClose(IntPtr window, int value);

		/// <summary>
		/// This function sets the window title, encoded as UTF-8, of the specified
		/// window.
		/// </summary>
		/// <remarks>
		/// __OS X:__ The window title will not be updated until the next time
		/// you process events.
		/// </remarks>
		/// <param name="window">
		/// The window whose title to change.
		/// </param>
		/// <param name="title">
		/// The UTF-8 encoded window title.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetWindowTitle", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowTitle(IntPtr window, string title);

		/// <summary>
		/// This function retrieves the position, in screen coordinates, of the
		/// upper-left corner of the client area of the specified window.
		/// </summary>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="xpos">
		/// Where to store the x-coordinate of the upper-left corner of
		/// the client area, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the y-coordinate of the upper-left corner of
		/// the client area, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetWindowPos(IntPtr window, out int xpos, out int ypos);

		/// <summary>
		/// This function sets the position, in screen coordinates, of the upper-left
		/// corner of the client area of the specified windowed mode window.  If the
		/// window is a full screen window, this function does nothing.
		/// </summary>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="xpos">
		/// The x-coordinate of the upper-left corner of the client area.
		/// </param>
		/// <param name="ypos">
		/// The y-coordinate of the upper-left corner of the client area.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetWindowPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowPos(IntPtr window, int xpos, int ypos);

		/// <summary>
		/// This function retrieves the size, in screen coordinates, of the client area
		/// of the specified window.  If you wish to retrieve the size of the
		/// framebuffer of the window in pixels, see @ref glfwGetFramebufferSize.
		/// </summary>
		/// <param name="window">
		/// The window whose size to retrieve.
		/// </param>
		/// <param name="width">
		/// Where to store the width, in screen coordinates, of the
		/// client area, or `NULL`.
		/// </param>
		/// <param name="height">
		/// Where to store the height, in screen coordinates, of the
		/// client area, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetWindowSize(IntPtr window, out int width, out int height);

		/// <summary>
		/// This function sets the size, in screen coordinates, of the client area of
		/// the specified window.
		/// </summary>
		/// <param name="window">
		/// The window to resize.
		/// </param>
		/// <param name="width">
		/// The desired width of the specified window.
		/// </param>
		/// <param name="height">
		/// The desired height of the specified window.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetWindowSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowSize(IntPtr window, int width, int height);

		/// <summary>
		/// This function retrieves the size, in pixels, of the framebuffer of the
		/// specified window.  If you wish to retrieve the size of the window in screen
		/// coordinates, see @ref glfwGetWindowSize.
		/// </summary>
		/// <param name="window">
		/// The window whose framebuffer to query.
		/// </param>
		/// <param name="width">
		/// Where to store the width, in pixels, of the framebuffer,
		/// or `NULL`.
		/// </param>
		/// <param name="height">
		/// Where to store the height, in pixels, of the framebuffer,
		/// or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetFramebufferSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetFramebufferSize(IntPtr window, out int width, out int height);

		/// <summary>
		/// This function retrieves the size, in screen coordinates, of each edge of the
		/// frame of the specified window.  This size includes the title bar, if the
		/// window has one.  The size of the frame may vary depending on the
		/// [window-related hints](@ref window_hints_wnd) used to create it.
		/// </summary>
		/// <param name="window">
		/// The window whose frame size to query.
		/// </param>
		/// <param name="left">
		/// Where to store the size, in screen coordinates, of the left
		/// edge of the window frame, or `NULL`.
		/// </param>
		/// <param name="top">
		/// Where to store the size, in screen coordinates, of the top
		/// edge of the window frame, or `NULL`.
		/// </param>
		/// <param name="right">
		/// Where to store the size, in screen coordinates, of the
		/// right edge of the window frame, or `NULL`.
		/// </param>
		/// <param name="bottom">
		/// Where to store the size, in screen coordinates, of the
		/// bottom edge of the window frame, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetWindowFrameSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

		/// <summary>
		/// This function iconifies (minimizes) the specified window if it was
		/// previously restored.  If the window is already iconified, this function does
		/// nothing.
		/// </summary>
		/// <param name="window">
		/// The window to iconify.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwIconifyWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void IconifyWindow(IntPtr window);

		/// <summary>
		/// This function restores the specified window if it was previously iconified
		/// (minimized).  If the window is already restored, this function does nothing.
		/// </summary>
		/// <param name="window">
		/// The window to restore.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwRestoreWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void RestoreWindow(IntPtr window);

		/// <summary>
		/// This function makes the specified window visible if it was previously
		/// hidden.  If the window is already visible or is in full screen mode, this
		/// function does nothing.
		/// </summary>
		/// <param name="window">
		/// The window to make visible.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwShowWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowWindow(IntPtr window);

		/// <summary>
		/// This function hides the specified window if it was previously visible.  If
		/// the window is already hidden or is in full screen mode, this function does
		/// nothing.
		/// </summary>
		/// <param name="window">
		/// The window to hide.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwHideWindow", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void HideWindow(IntPtr window);

		/// <summary>
		/// This function returns the handle of the monitor that the specified window is
		/// in full screen on.
		/// </summary>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <returns>
		/// The monitor, or `NULL` if the window is in windowed mode or an error
		/// occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetWindowMonitor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetWindowMonitor(IntPtr window);

		/// <summary>
		/// This function returns the value of an attribute of the specified window or
		/// its OpenGL or OpenGL ES context.
		/// </summary>
		/// <remarks>
		/// Zero is a valid value for many window and context related
		/// attributes so you cannot use a return value of zero as an indication of
		/// errors.  However, this function should not fail as long as it is passed
		/// valid arguments and the library has been [initialized](@ref intro_init).
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="attrib">
		/// The [window attribute](@ref window_attribs) whose value to
		/// return.
		/// </param>
		/// <returns>
		/// The value of the attribute, or zero if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetWindowAttrib", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetWindowAttrib(IntPtr window, int attrib);

		/// <summary>
		/// This function sets the user-defined pointer of the specified window.  The
		/// current value is retained until the window is destroyed.  The initial value
		/// is `NULL`.
		/// </summary>
		/// <param name="window">
		/// The window whose pointer to set.
		/// </param>
		/// <param name="pointer">
		/// The new value.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowUserPointer(IntPtr window, IntPtr pointer);

		/// <summary>
		/// This function returns the current value of the user-defined pointer of the
		/// specified window.  The initial value is `NULL`.
		/// </summary>
		/// <param name="window">
		/// The window whose pointer to return.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetWindowUserPointer", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetWindowUserPointer(IntPtr window);

		/// <summary>
		/// This function sets the position callback of the specified window, which is
		/// called when the window is moved.  The callback is provided with the screen
		/// position of the upper-left corner of the client area of the window.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetWindowPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern WindowPosFun SetWindowPosCallback(IntPtr window, WindowPosFun cbfun);

		/// <summary>
		/// This function sets the size callback of the specified window, which is
		/// called when the window is resized.  The callback is provided with the size,
		/// in screen coordinates, of the client area of the window.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetWindowSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern WindowSizeFun SetWindowSizeCallback(IntPtr window, WindowSizeFun cbfun);

		/// <summary>
		/// This function sets the close callback of the specified window, which is
		/// called when the user attempts to close the window, for example by clicking
		/// the close widget in the title bar.
		/// </summary>
		/// <remarks>
		/// __OS X:__ Selecting Quit from the application menu will
		/// trigger the close callback for all windows.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetWindowCloseCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern WindowCloseFun SetWindowCloseCallback(IntPtr window, WindowCloseFun cbfun);

		/// <summary>
		/// This function sets the refresh callback of the specified window, which is
		/// called when the client area of the window needs to be redrawn, for example
		/// if the window has been exposed after having been covered by another window.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetWindowRefreshCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern WindowRefreshFun SetWindowRefreshCallback(IntPtr window, WindowRefreshFun cbfun);

		/// <summary>
		/// This function sets the focus callback of the specified window, which is
		/// called when the window gains or loses input focus.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetWindowFocusCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern WindowFocusFun SetWindowFocusCallback(IntPtr window, WindowFocusFun cbfun);

		/// <summary>
		/// This function sets the iconification callback of the specified window, which
		/// is called when the window is iconified or restored.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetWindowIconifyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern WindowIconifyFun SetWindowIconifyCallback(IntPtr window, WindowIconifyFun cbfun);

		/// <summary>
		/// This function sets the framebuffer resize callback of the specified window,
		/// which is called when the framebuffer of the specified window is resized.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetFramebufferSizeCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern FramebufferSizeFun SetFramebufferSizeCallback(IntPtr window, FramebufferSizeFun cbfun);

		/// <summary>
		/// This function processes only those events that are already in the event
		/// queue and then returns immediately.  Processing events will cause the window
		/// and input callbacks associated with those events to be called.
		/// </summary>
		[DllImport(Library, EntryPoint = "glfwPollEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void PollEvents();

		/// <summary>
		/// This function puts the calling thread to sleep until at least one event is
		/// available in the event queue.  Once one or more events are available,
		/// it behaves exactly like @ref glfwPollEvents, i.e. the events in the queue
		/// are processed and the function then returns immediately.  Processing events
		/// will cause the window and input callbacks associated with those events to be
		/// called.
		/// </summary>
		[DllImport(Library, EntryPoint = "glfwWaitEvents", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void WaitEvents();

		/// <summary>
		/// This function posts an empty event from the current thread to the event
		/// queue, causing @ref glfwWaitEvents to return.
		/// </summary>
		[DllImport(Library, EntryPoint = "glfwPostEmptyEvent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void PostEmptyEvent();

		/// <summary>
		/// This function returns the value of an input option for the specified window.
		/// The mode must be one of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or
		/// `GLFW_STICKY_MOUSE_BUTTONS`.
		/// </summary>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="mode">
		/// One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or
		/// `GLFW_STICKY_MOUSE_BUTTONS`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetInputMode(IntPtr window, int mode);

		/// <summary>
		/// This function sets an input mode option for the specified window.  The mode
		/// must be one of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or
		/// `GLFW_STICKY_MOUSE_BUTTONS`.
		/// </summary>
		/// <param name="window">
		/// The window whose input mode to set.
		/// </param>
		/// <param name="mode">
		/// One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS` or
		/// `GLFW_STICKY_MOUSE_BUTTONS`.
		/// </param>
		/// <param name="value">
		/// The new value of the specified input mode.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetInputMode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetInputMode(IntPtr window, int mode, int value);

		/// <summary>
		/// This function returns the last state reported for the specified key to the
		/// specified window.  The returned state is one of `GLFW_PRESS` or
		/// `GLFW_RELEASE`.  The higher-level action `GLFW_REPEAT` is only reported to
		/// the key callback.
		/// </summary>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="key">
		/// The desired [keyboard key](@ref keys).  `GLFW_KEY_UNKNOWN` is
		/// not a valid key for this function.
		/// </param>
		/// <returns>
		/// One of `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetKey", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetKey(IntPtr window, int key);

		/// <summary>
		/// This function returns the last state reported for the specified mouse button
		/// to the specified window.  The returned state is one of `GLFW_PRESS` or
		/// `GLFW_RELEASE`.
		/// </summary>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="button">
		/// The desired [mouse button](@ref buttons).
		/// </param>
		/// <returns>
		/// One of `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetMouseButton", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMouseButton(IntPtr window, int button);

		/// <summary>
		/// This function returns the position of the cursor, in screen coordinates,
		/// relative to the upper-left corner of the client area of the specified
		/// window.
		/// </summary>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="xpos">
		/// Where to store the cursor x-coordinate, relative to the
		/// left edge of the client area, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the cursor y-coordinate, relative to the to
		/// top edge of the client area, or `NULL`.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwGetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetCursorPos(IntPtr window, out double xpos, out double ypos);

		/// <summary>
		/// This function sets the position, in screen coordinates, of the cursor
		/// relative to the upper-left corner of the client area of the specified
		/// window.  The window must have input focus.  If the window does not have
		/// input focus when this function is called, it fails silently.
		/// </summary>
		/// <remarks>
		/// __X11:__ Due to the asynchronous nature of X11, it may take
		/// a moment for the window focus event to arrive.  This means you may not be
		/// able to set the cursor position directly after window creation.
		/// </remarks>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="xpos">
		/// The desired x-coordinate, relative to the left edge of the
		/// client area.
		/// </param>
		/// <param name="ypos">
		/// The desired y-coordinate, relative to the top edge of the
		/// client area.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetCursorPos", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCursorPos(IntPtr window, double xpos, double ypos);

		/// <summary>
		/// Creates a new custom cursor image that can be set for a window with @ref
		/// glfwSetCursor.  The cursor can be destroyed with @ref glfwDestroyCursor.
		/// Any remaining cursors are destroyed by @ref glfwTerminate.
		/// </summary>
		/// <param name="image">
		/// The desired cursor image.
		/// </param>
		/// <param name="xhot">
		/// The desired x-coordinate, in pixels, of the cursor hotspot.
		/// </param>
		/// <param name="yhot">
		/// The desired y-coordinate, in pixels, of the cursor hotspot.
		/// </param>
		/// <returns>
		/// The handle of the created cursor, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwCreateCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr CreateCursor(Image image, int xhot, int yhot);

		/// <summary>
		/// Returns a cursor with a [standard shape](@ref shapes), that can be set for
		/// a window with @ref glfwSetCursor.
		/// </summary>
		/// <param name="shape">
		/// One of the [standard shapes](@ref shapes).
		/// </param>
		/// <returns>
		/// A new cursor ready to use or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwCreateStandardCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr CreateStandardCursor(int shape);

		/// <summary>
		/// This function destroys a cursor previously created with @ref
		/// glfwCreateCursor.  Any remaining cursors will be destroyed by @ref
		/// glfwTerminate.
		/// </summary>
		/// <param name="cursor">
		/// The cursor object to destroy.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwDestroyCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void DestroyCursor(IntPtr cursor);

		/// <summary>
		/// This function sets the cursor image to be used when the cursor is over the
		/// client area of the specified window.  The set cursor will only be visible
		/// when the [cursor mode](@ref cursor_mode) of the window is
		/// `GLFW_CURSOR_NORMAL`.
		/// </summary>
		/// <param name="window">
		/// The window to set the cursor for.
		/// </param>
		/// <param name="cursor">
		/// The cursor to set, or `NULL` to switch back to the default
		/// arrow cursor.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetCursor", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCursor(IntPtr window, IntPtr cursor);

		/// <summary>
		/// This function sets the key callback of the specified window, which is called
		/// when a key is pressed, repeated or released.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new key callback, or `NULL` to remove the currently
		/// set callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetKeyCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern KeyFun SetKeyCallback(IntPtr window, KeyFun cbfun);

		/// <summary>
		/// This function sets the character callback of the specified window, which is
		/// called when a Unicode character is input.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetCharCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern CharFun SetCharCallback(IntPtr window, CharFun cbfun);

		/// <summary>
		/// This function sets the character with modifiers callback of the specified
		/// window, which is called when a Unicode character is input regardless of what
		/// modifier keys are used.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or an
		/// error occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetCharModsCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern CharModsFun SetCharModsCallback(IntPtr window, CharModsFun cbfun);

		/// <summary>
		/// This function sets the mouse button callback of the specified window, which
		/// is called when a mouse button is pressed or released.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetMouseButtonCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern MouseButtonFun SetMouseButtonCallback(IntPtr window, MouseButtonFun cbfun);

		/// <summary>
		/// This function sets the cursor position callback of the specified window,
		/// which is called when the cursor is moved.  The callback is provided with the
		/// position, in screen coordinates, relative to the upper-left corner of the
		/// client area of the window.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetCursorPosCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern CursorPosFun SetCursorPosCallback(IntPtr window, CursorPosFun cbfun);

		/// <summary>
		/// This function sets the cursor boundary crossing callback of the specified
		/// window, which is called when the cursor enters or leaves the client area of
		/// the window.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetCursorEnterCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern CursorEnterFun SetCursorEnterCallback(IntPtr window, CursorEnterFun cbfun);

		/// <summary>
		/// This function sets the scroll callback of the specified window, which is
		/// called when a scrolling device is used, such as a mouse wheel or scrolling
		/// area of a touchpad.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new scroll callback, or `NULL` to remove the currently
		/// set callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetScrollCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern ScrollFun SetScrollCallback(IntPtr window, ScrollFun cbfun);

		/// <summary>
		/// This function sets the file drop callback of the specified window, which is
		/// called when one or more dragged files are dropped on the window.
		/// </summary>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new file drop callback, or `NULL` to remove the
		/// currently set callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwSetDropCallback", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern DropFun SetDropCallback(IntPtr window, DropFun cbfun);

		/// <summary>
		/// This function returns whether the specified joystick is present.
		/// </summary>
		/// <param name="joy">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// `GL_TRUE` if the joystick is present, or `GL_FALSE` otherwise.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwJoystickPresent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int JoystickPresent(int joy);

		/// <summary>
		/// This function returns the values of all axes of the specified joystick.
		/// Each element in the array is a value between -1.0 and 1.0.
		/// </summary>
		/// <param name="joy">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of axis values in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of axis values, or `NULL` if the joystick is not present.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetJoystickAxes", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern float[] GetJoystickAxes(int joy, out int count);

		/// <summary>
		/// This function returns the state of all buttons of the specified joystick.
		/// Each element in the array is either `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </summary>
		/// <param name="joy">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of button states in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of button states, or `NULL` if the joystick is not present.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetJoystickButtons", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string GetJoystickButtons(int joy, out int count);

		/// <summary>
		/// This function returns the name, encoded as UTF-8, of the specified joystick.
		/// The returned string is allocated and freed by GLFW.  You should not free it
		/// yourself.
		/// </summary>
		/// <param name="joy">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded name of the joystick, or `NULL` if the joystick
		/// is not present.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetJoystickName", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string GetJoystickName(int joy);

		/// <summary>
		/// This function sets the system clipboard to the specified, UTF-8 encoded
		/// string.
		/// </summary>
		/// <param name="window">
		/// The window that will own the clipboard contents.
		/// </param>
		/// <param name="string">
		/// A UTF-8 encoded string.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetClipboardString(IntPtr window, string @string);

		/// <summary>
		/// This function returns the contents of the system clipboard, if it contains
		/// or is convertible to a UTF-8 encoded string.  If the clipboard is empty or
		/// if its contents cannot be converted, `NULL` is returned and a @ref
		/// GLFW_FORMAT_UNAVAILABLE error is generated.
		/// </summary>
		/// <param name="window">
		/// The window that will request the clipboard contents.
		/// </param>
		/// <returns>
		/// The contents of the clipboard as a UTF-8 encoded string, or `NULL`
		/// if an [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetClipboardString", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern string GetClipboardString(IntPtr window);

		/// <summary>
		/// This function returns the value of the GLFW timer.  Unless the timer has
		/// been set using @ref glfwSetTime, the timer measures time elapsed since GLFW
		/// was initialized.
		/// </summary>
		/// <returns>
		/// The current value, in seconds, or zero if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern double GetTime();

		/// <summary>
		/// This function sets the value of the GLFW timer.  It then continues to count
		/// up from that value.  The value must be a positive finite number less than
		/// or equal to 18446744073.0, which is approximately 584.5 years.
		/// </summary>
		/// <remarks>
		/// The upper limit of the timer is calculated as
		/// floor((2<sup>64</sup> - 1) / 10<sup>9</sup>) and is due to implementations
		/// storing nanoseconds in 64 bits.  The limit may be increased in the future.
		/// </remarks>
		/// <param name="time">
		/// The new value, in seconds.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSetTime", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTime(double time);

		/// <summary>
		/// This function makes the OpenGL or OpenGL ES context of the specified window
		/// current on the calling thread.  A context can only be made current on
		/// a single thread at a time and each thread can have only a single current
		/// context at a time.
		/// </summary>
		/// <param name="window">
		/// The window whose context to make current, or `NULL` to
		/// detach the current context.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwMakeContextCurrent", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void MakeContextCurrent(IntPtr window);

		/// <summary>
		/// This function returns the window whose OpenGL or OpenGL ES context is
		/// current on the calling thread.
		/// </summary>
		/// <returns>
		/// The window whose context is current, or `NULL` if no window's
		/// context is current.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetCurrentContext", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetCurrentContext();

		/// <summary>
		/// This function swaps the front and back buffers of the specified window.  If
		/// the swap interval is greater than zero, the GPU driver waits the specified
		/// number of screen updates before swapping the buffers.
		/// </summary>
		/// <param name="window">
		/// The window whose buffers to swap.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSwapBuffers", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SwapBuffers(IntPtr window);

		/// <summary>
		/// This function sets the swap interval for the current context, i.e. the
		/// number of screen updates to wait from the time @ref glfwSwapBuffers was
		/// called before swapping the buffers and returning.  This is sometimes called
		/// _vertical synchronization_, _vertical retrace synchronization_ or just
		/// _vsync_.
		/// </summary>
		/// <remarks>
		/// Some GPU drivers do not honor the requested swap interval, either
		/// because of a user setting that overrides the application's request or due to
		/// bugs in the driver.
		/// </remarks>
		/// <param name="interval">
		/// The minimum number of screen updates to wait for
		/// until the buffers are swapped by @ref glfwSwapBuffers.
		/// </param>
		[DllImport(Library, EntryPoint = "glfwSwapInterval", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern void SwapInterval(int interval);

		/// <summary>
		/// This function returns whether the specified
		/// [client API extension](@ref context_glext) is supported by the current
		/// OpenGL or OpenGL ES context.  It searches both for OpenGL and OpenGL ES
		/// extension and platform-specific context creation API extensions.
		/// </summary>
		/// <param name="extension">
		/// The ASCII encoded name of the extension.
		/// </param>
		/// <returns>
		/// `GL_TRUE` if the extension is available, or `GL_FALSE` otherwise.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwExtensionSupported", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern int ExtensionSupported(string extension);

		/// <summary>
		/// This function returns the address of the specified
		/// [core or extension function](@ref context_glext), if it is supported
		/// by the current context.
		/// </summary>
		/// <remarks>
		/// This function may return a non-`NULL` address despite the
		/// associated version or extension not being available.  Always check the
		/// context version or extension string first.
		/// </remarks>
		/// <param name="procname">
		/// The ASCII encoded name of the function.
		/// </param>
		/// <returns>
		/// The address of the function, or `NULL` if an [error](@ref
		/// error_handling) occurred.
		/// </returns>
		[DllImport(Library, EntryPoint = "glfwGetProcAddress", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetProcAddress(string procname);

	}
}
