using System;

namespace GLFWDotNet
{
	public enum ContextHints
	{
		ClientApi = GLFW.CLIENT_API,
		ContextVersionMajor = GLFW.CONTEXT_VERSION_MAJOR,
		ContextVersionMinor = GLFW.CONTEXT_VERSION_MINOR,
		ContextRevision = GLFW.CONTEXT_REVISION,
		ContextRobustness = GLFW.CONTEXT_ROBUSTNESS,
		OpenglForwardCompat = GLFW.OPENGL_FORWARD_COMPAT,
		OpenglDebugContext = GLFW.OPENGL_DEBUG_CONTEXT,
		OpenglProfile = GLFW.OPENGL_PROFILE,
		ContextReleaseBehavior = GLFW.CONTEXT_RELEASE_BEHAVIOR,
		OpenglApi = GLFW.OPENGL_API,
		OpenglEsApi = GLFW.OPENGL_ES_API,
		NoRobustness = GLFW.NO_ROBUSTNESS,
		NoResetNotification = GLFW.NO_RESET_NOTIFICATION,
		LoseContextOnReset = GLFW.LOSE_CONTEXT_ON_RESET,
		OpenglAnyProfile = GLFW.OPENGL_ANY_PROFILE,
		OpenglCoreProfile = GLFW.OPENGL_CORE_PROFILE,
		OpenglCompatProfile = GLFW.OPENGL_COMPAT_PROFILE,
		AnyReleaseBehavior = GLFW.ANY_RELEASE_BEHAVIOR,
		ReleaseBehaviorFlush = GLFW.RELEASE_BEHAVIOR_FLUSH,
		ReleaseBehaviorNone = GLFW.RELEASE_BEHAVIOR_NONE,
	}
}
