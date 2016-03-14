using System;
using System.Runtime.InteropServices;

namespace GLFWDotNet
{
	public static partial class GLFW
	{
		public const int GLFW_VERSION_MAJOR = 3;
		public const int GLFW_VERSION_MINOR = 1;
		public const int GLFW_VERSION_REVISION = 2;
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
		public const int GLFW_FOCUSED = 0x00020001;
		public const int GLFW_ICONIFIED = 0x00020002;
		public const int GLFW_RESIZABLE = 0x00020003;
		public const int GLFW_VISIBLE = 0x00020004;
		public const int GLFW_DECORATED = 0x00020005;
		public const int GLFW_AUTO_ICONIFY = 0x00020006;
		public const int GLFW_FLOATING = 0x00020007;
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
		public const int GLFW_ARROW_CURSOR = 0x00036001;
		public const int GLFW_IBEAM_CURSOR = 0x00036002;
		public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
		public const int GLFW_HAND_CURSOR = 0x00036004;
		public const int GLFW_HRESIZE_CURSOR = 0x00036005;
		public const int GLFW_VRESIZE_CURSOR = 0x00036006;
		public const int GLFW_CONNECTED = 0x00040001;
		public const int GLFW_DISCONNECTED = 0x00040002;
		public const int GLFW_DONT_CARE = -1;

		[DllImport(Library, EntryPoint = "glfwInit", ExactSpelling = true)]
		public static extern int Init();

		[DllImport(Library, EntryPoint = "glfwTerminate", ExactSpelling = true)]
		public static extern void Terminate();

		[DllImport(Library, EntryPoint = "glfwGetVersion", ExactSpelling = true)]
		public static extern void GetVersion(out int major, out int minor, out int rev);

		[DllImport(Library, EntryPoint = "glfwGetVersionString", ExactSpelling = true)]
		public static extern string GetVersionString();

		[DllImport(Library, EntryPoint = "glfwSetErrorCallback", ExactSpelling = true)]
		public static extern GLFWerrorfun SetErrorCallback(GLFWerrorfun cbfun);

		[DllImport(Library, EntryPoint = "glfwGetMonitors", ExactSpelling = true)]
		public static extern GLFWmonitor** GetMonitors(ref int count);

		[DllImport(Library, EntryPoint = "glfwGetPrimaryMonitor", ExactSpelling = true)]
		public static extern GLFWmonitor* GetPrimaryMonitor();

		[DllImport(Library, EntryPoint = "glfwGetMonitorPos", ExactSpelling = true)]
		public static extern void GetMonitorPos(GLFWmonitor* monitor, out int xpos, out int ypos);

		[DllImport(Library, EntryPoint = "glfwGetMonitorPhysicalSize", ExactSpelling = true)]
		public static extern void GetMonitorPhysicalSize(GLFWmonitor* monitor, out int widthMM, out int heightMM);

		[DllImport(Library, EntryPoint = "glfwGetMonitorName", ExactSpelling = true)]
		public static extern string GetMonitorName(GLFWmonitor* monitor);

		[DllImport(Library, EntryPoint = "glfwSetMonitorCallback", ExactSpelling = true)]
		public static extern GLFWmonitorfun SetMonitorCallback(GLFWmonitorfun cbfun);

		[DllImport(Library, EntryPoint = "glfwGetVideoModes", ExactSpelling = true)]
		public static extern GLFWvidmode* GetVideoModes(GLFWmonitor* monitor, ref int count);

		[DllImport(Library, EntryPoint = "glfwGetVideoMode", ExactSpelling = true)]
		public static extern GLFWvidmode* GetVideoMode(GLFWmonitor* monitor);

		[DllImport(Library, EntryPoint = "glfwSetGamma", ExactSpelling = true)]
		public static extern void SetGamma(GLFWmonitor* monitor, float gamma);

		[DllImport(Library, EntryPoint = "glfwGetGammaRamp", ExactSpelling = true)]
		public static extern GLFWgammaramp* GetGammaRamp(GLFWmonitor* monitor);

		[DllImport(Library, EntryPoint = "glfwSetGammaRamp", ExactSpelling = true)]
		public static extern void SetGammaRamp(GLFWmonitor* monitor, const GLFWgammaramp* ramp);

		[DllImport(Library, EntryPoint = "glfwDefaultWindowHints", ExactSpelling = true)]
		public static extern void DefaultWindowHints();

		[DllImport(Library, EntryPoint = "glfwWindowHint", ExactSpelling = true)]
		public static extern void WindowHint(int target, int hint);

		[DllImport(Library, EntryPoint = "glfwCreateWindow", ExactSpelling = true)]
		public static extern GLFWwindow* CreateWindow(int width, int height, string title, GLFWmonitor* monitor, GLFWwindow* share);

		[DllImport(Library, EntryPoint = "glfwDestroyWindow", ExactSpelling = true)]
		public static extern void DestroyWindow(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwWindowShouldClose", ExactSpelling = true)]
		public static extern int WindowShouldClose(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwSetWindowShouldClose", ExactSpelling = true)]
		public static extern void SetWindowShouldClose(GLFWwindow* window, int value);

		[DllImport(Library, EntryPoint = "glfwSetWindowTitle", ExactSpelling = true)]
		public static extern void SetWindowTitle(GLFWwindow* window, string title);

		[DllImport(Library, EntryPoint = "glfwGetWindowPos", ExactSpelling = true)]
		public static extern void GetWindowPos(GLFWwindow* window, out int xpos, out int ypos);

		[DllImport(Library, EntryPoint = "glfwSetWindowPos", ExactSpelling = true)]
		public static extern void SetWindowPos(GLFWwindow* window, int xpos, int ypos);

		[DllImport(Library, EntryPoint = "glfwGetWindowSize", ExactSpelling = true)]
		public static extern void GetWindowSize(GLFWwindow* window, out int width, out int height);

		[DllImport(Library, EntryPoint = "glfwSetWindowSize", ExactSpelling = true)]
		public static extern void SetWindowSize(GLFWwindow* window, int width, int height);

		[DllImport(Library, EntryPoint = "glfwGetFramebufferSize", ExactSpelling = true)]
		public static extern void GetFramebufferSize(GLFWwindow* window, out int width, out int height);

		[DllImport(Library, EntryPoint = "glfwGetWindowFrameSize", ExactSpelling = true)]
		public static extern void GetWindowFrameSize(GLFWwindow* window, out int left, out int top, out int right, out int bottom);

		[DllImport(Library, EntryPoint = "glfwIconifyWindow", ExactSpelling = true)]
		public static extern void IconifyWindow(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwRestoreWindow", ExactSpelling = true)]
		public static extern void RestoreWindow(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwShowWindow", ExactSpelling = true)]
		public static extern void ShowWindow(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwHideWindow", ExactSpelling = true)]
		public static extern void HideWindow(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwGetWindowMonitor", ExactSpelling = true)]
		public static extern GLFWmonitor* GetWindowMonitor(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwGetWindowAttrib", ExactSpelling = true)]
		public static extern int GetWindowAttrib(GLFWwindow* window, int attrib);

		[DllImport(Library, EntryPoint = "glfwSetWindowUserPointer", ExactSpelling = true)]
		public static extern void SetWindowUserPointer(GLFWwindow* window, IntPtr pointer);

		[DllImport(Library, EntryPoint = "glfwGetWindowUserPointer", ExactSpelling = true)]
		public static extern IntPtr GetWindowUserPointer(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwSetWindowPosCallback", ExactSpelling = true)]
		public static extern GLFWwindowposfun SetWindowPosCallback(GLFWwindow* window, GLFWwindowposfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowSizeCallback", ExactSpelling = true)]
		public static extern GLFWwindowsizefun SetWindowSizeCallback(GLFWwindow* window, GLFWwindowsizefun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowCloseCallback", ExactSpelling = true)]
		public static extern GLFWwindowclosefun SetWindowCloseCallback(GLFWwindow* window, GLFWwindowclosefun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowRefreshCallback", ExactSpelling = true)]
		public static extern GLFWwindowrefreshfun SetWindowRefreshCallback(GLFWwindow* window, GLFWwindowrefreshfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowFocusCallback", ExactSpelling = true)]
		public static extern GLFWwindowfocusfun SetWindowFocusCallback(GLFWwindow* window, GLFWwindowfocusfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetWindowIconifyCallback", ExactSpelling = true)]
		public static extern GLFWwindowiconifyfun SetWindowIconifyCallback(GLFWwindow* window, GLFWwindowiconifyfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetFramebufferSizeCallback", ExactSpelling = true)]
		public static extern GLFWframebuffersizefun SetFramebufferSizeCallback(GLFWwindow* window, GLFWframebuffersizefun cbfun);

		[DllImport(Library, EntryPoint = "glfwPollEvents", ExactSpelling = true)]
		public static extern void PollEvents();

		[DllImport(Library, EntryPoint = "glfwWaitEvents", ExactSpelling = true)]
		public static extern void WaitEvents();

		[DllImport(Library, EntryPoint = "glfwPostEmptyEvent", ExactSpelling = true)]
		public static extern void PostEmptyEvent();

		[DllImport(Library, EntryPoint = "glfwGetInputMode", ExactSpelling = true)]
		public static extern int GetInputMode(GLFWwindow* window, int mode);

		[DllImport(Library, EntryPoint = "glfwSetInputMode", ExactSpelling = true)]
		public static extern void SetInputMode(GLFWwindow* window, int mode, int value);

		[DllImport(Library, EntryPoint = "glfwGetKey", ExactSpelling = true)]
		public static extern int GetKey(GLFWwindow* window, int key);

		[DllImport(Library, EntryPoint = "glfwGetMouseButton", ExactSpelling = true)]
		public static extern int GetMouseButton(GLFWwindow* window, int button);

		[DllImport(Library, EntryPoint = "glfwGetCursorPos", ExactSpelling = true)]
		public static extern void GetCursorPos(GLFWwindow* window, double* xpos, double* ypos);

		[DllImport(Library, EntryPoint = "glfwSetCursorPos", ExactSpelling = true)]
		public static extern void SetCursorPos(GLFWwindow* window, double xpos, double ypos);

		[DllImport(Library, EntryPoint = "glfwCreateCursor", ExactSpelling = true)]
		public static extern GLFWcursor* CreateCursor(const GLFWimage* image, int xhot, int yhot);

		[DllImport(Library, EntryPoint = "glfwCreateStandardCursor", ExactSpelling = true)]
		public static extern GLFWcursor* CreateStandardCursor(int shape);

		[DllImport(Library, EntryPoint = "glfwDestroyCursor", ExactSpelling = true)]
		public static extern void DestroyCursor(GLFWcursor* cursor);

		[DllImport(Library, EntryPoint = "glfwSetCursor", ExactSpelling = true)]
		public static extern void SetCursor(GLFWwindow* window, GLFWcursor* cursor);

		[DllImport(Library, EntryPoint = "glfwSetKeyCallback", ExactSpelling = true)]
		public static extern GLFWkeyfun SetKeyCallback(GLFWwindow* window, GLFWkeyfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCharCallback", ExactSpelling = true)]
		public static extern GLFWcharfun SetCharCallback(GLFWwindow* window, GLFWcharfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCharModsCallback", ExactSpelling = true)]
		public static extern GLFWcharmodsfun SetCharModsCallback(GLFWwindow* window, GLFWcharmodsfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetMouseButtonCallback", ExactSpelling = true)]
		public static extern GLFWmousebuttonfun SetMouseButtonCallback(GLFWwindow* window, GLFWmousebuttonfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCursorPosCallback", ExactSpelling = true)]
		public static extern GLFWcursorposfun SetCursorPosCallback(GLFWwindow* window, GLFWcursorposfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetCursorEnterCallback", ExactSpelling = true)]
		public static extern GLFWcursorenterfun SetCursorEnterCallback(GLFWwindow* window, GLFWcursorenterfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetScrollCallback", ExactSpelling = true)]
		public static extern GLFWscrollfun SetScrollCallback(GLFWwindow* window, GLFWscrollfun cbfun);

		[DllImport(Library, EntryPoint = "glfwSetDropCallback", ExactSpelling = true)]
		public static extern GLFWdropfun SetDropCallback(GLFWwindow* window, GLFWdropfun cbfun);

		[DllImport(Library, EntryPoint = "glfwJoystickPresent", ExactSpelling = true)]
		public static extern int JoystickPresent(int joy);

		[DllImport(Library, EntryPoint = "glfwGetJoystickAxes", ExactSpelling = true)]
		public static extern float* GetJoystickAxes(int joy, ref int count);

		[DllImport(Library, EntryPoint = "glfwGetJoystickButtons", ExactSpelling = true)]
		public static extern unsigned char* GetJoystickButtons(int joy, ref int count);

		[DllImport(Library, EntryPoint = "glfwGetJoystickName", ExactSpelling = true)]
		public static extern string GetJoystickName(int joy);

		[DllImport(Library, EntryPoint = "glfwSetClipboardString", ExactSpelling = true)]
		public static extern void SetClipboardString(GLFWwindow* window, string string);

		[DllImport(Library, EntryPoint = "glfwGetClipboardString", ExactSpelling = true)]
		public static extern string GetClipboardString(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwGetTime", ExactSpelling = true)]
		public static extern double GetTime();

		[DllImport(Library, EntryPoint = "glfwSetTime", ExactSpelling = true)]
		public static extern void SetTime(double time);

		[DllImport(Library, EntryPoint = "glfwMakeContextCurrent", ExactSpelling = true)]
		public static extern void MakeContextCurrent(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwGetCurrentContext", ExactSpelling = true)]
		public static extern GLFWwindow* GetCurrentContext();

		[DllImport(Library, EntryPoint = "glfwSwapBuffers", ExactSpelling = true)]
		public static extern void SwapBuffers(GLFWwindow* window);

		[DllImport(Library, EntryPoint = "glfwSwapInterval", ExactSpelling = true)]
		public static extern void SwapInterval(int interval);

		[DllImport(Library, EntryPoint = "glfwExtensionSupported", ExactSpelling = true)]
		public static extern int ExtensionSupported(string extension);

		[DllImport(Library, EntryPoint = "glfwGetProcAddress", ExactSpelling = true)]
		public static extern GLFWglproc GetProcAddress(string procname);

	}
}
