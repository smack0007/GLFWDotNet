using System;

namespace GLFWDotNet
{
	public enum FramebufferHints
	{
		RedBits = GLFW.RED_BITS,
		GreenBits = GLFW.GREEN_BITS,
		BlueBits = GLFW.BLUE_BITS,
		AlphaBits = GLFW.ALPHA_BITS,
		DepthBits = GLFW.DEPTH_BITS,
		StencilBits = GLFW.STENCIL_BITS,
		AccumRedBits = GLFW.ACCUM_RED_BITS,
		AccumGreenBits = GLFW.ACCUM_GREEN_BITS,
		AccumBlueBits = GLFW.ACCUM_BLUE_BITS,
		AccumAlphaBits = GLFW.ACCUM_ALPHA_BITS,
		AuxBuffers = GLFW.AUX_BUFFERS,
		Stereo = GLFW.STEREO,
		Samples = GLFW.SAMPLES,
		SrgbCapable = GLFW.SRGB_CAPABLE,
		RefreshRate = GLFW.REFRESH_RATE,
		Doublebuffer = GLFW.DOUBLEBUFFER,
	}
}
