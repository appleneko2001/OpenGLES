using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGLES
{
    // TODO: Implement all API (including obsoleted APIs for example 1.0) and fix any broken bindings
    // TODO: Add summary to every objects (constants, methods)
    // TODO: System.Numerics integrations
    /// <summary>
    /// OpenGL ES 2.0 - 3.2 bindings with C/C++ coding style for C#
    /// </summary>
    public class GLES
    {
        public const string Path = @"libGLESv2";
        #region GL_ES_VERSION_2_0
        public const uint GL_ES_VERSION_2_0 = 1;
        public const uint GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const uint GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const uint GL_COLOR_BUFFER_BIT = 0x00004000;
        public const uint GL_FALSE = 0;
        public const uint GL_TRUE = 1;
        public const uint GL_POINTS = 0x0000;
        public const uint GL_LINES = 0x0001;
        public const uint GL_LINE_LOOP = 0x0002;
        public const uint GL_LINE_STRIP = 0x0003;
        public const uint GL_TRIANGLES = 0x0004;
        public const uint GL_TRIANGLE_STRIP = 0x0005;
        public const uint GL_TRIANGLE_FAN = 0x0006;
        public const uint GL_ZERO = 0;
        public const uint GL_ONE = 1;
        public const uint GL_SRC_COLOR = 0x0300;
        public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const uint GL_SRC_ALPHA = 0x0302;
        public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const uint GL_DST_ALPHA = 0x0304;
        public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305;
        public const uint GL_DST_COLOR = 0x0306;
        public const uint GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const uint GL_SRC_ALPHA_SATURATE = 0x0308;
        public const uint GL_FUNC_ADD = 0x8006;
        public const uint GL_BLEND_EQUATION = 0x8009;
        public const uint GL_BLEND_EQUATION_RGB = 0x8009;
        public const uint GL_BLEND_EQUATION_ALPHA = 0x883D;
        public const uint GL_FUNC_SUBTRACT = 0x800A;
        public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
        public const uint GL_BLEND_DST_RGB = 0x80C8;
        public const uint GL_BLEND_SRC_RGB = 0x80C9;
        public const uint GL_BLEND_DST_ALPHA = 0x80CA;
        public const uint GL_BLEND_SRC_ALPHA = 0x80CB;
        public const uint GL_CONSTANT_COLOR = 0x8001;
        public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const uint GL_CONSTANT_ALPHA = 0x8003;
        public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const uint GL_BLEND_COLOR = 0x8005;
        public const uint GL_ARRAY_BUFFER = 0x8892;
        public const uint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        public const uint GL_ARRAY_BUFFER_BINDING = 0x8894;
        public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const uint GL_STREAM_DRAW = 0x88E0;
        public const uint GL_STATIC_DRAW = 0x88E4;
        public const uint GL_DYNAMIC_DRAW = 0x88E8;
        public const uint GL_BUFFER_SIZE = 0x8764;
        public const uint GL_BUFFER_USAGE = 0x8765;
        public const uint GL_CURRENT_VERTEX_ATTRIB = 0x8626;
        public const uint GL_FRONT = 0x0404;
        public const uint GL_BACK = 0x0405;
        public const uint GL_FRONT_AND_BACK = 0x0408;
        public const uint GL_TEXTURE_2D = 0x0DE1;
        public const uint GL_CULL_FACE = 0x0B44;
        public const uint GL_BLEND = 0x0BE2;
        public const uint GL_DITHER = 0x0BD0;
        public const uint GL_STENCIL_TEST = 0x0B90;
        public const uint GL_DEPTH_TEST = 0x0B71;
        public const uint GL_SCISSOR_TEST = 0x0C11;
        public const uint GL_POLYGON_OFFSET_FILL = 0x8037;
        public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const uint GL_SAMPLE_COVERAGE = 0x80A0;
        public const uint GL_NO_ERROR = 0;
        public const uint GL_INVALID_ENUM = 0x0500;
        public const uint GL_INVALID_VALUE = 0x0501;
        public const uint GL_INVALID_OPERATION = 0x0502;
        public const uint GL_OUT_OF_MEMORY = 0x0505;
        public const uint GL_CW = 0x0900;
        public const uint GL_CCW = 0x0901;
        public const uint GL_LINE_WIDTH = 0x0B21;
        public const uint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const uint GL_CULL_FACE_MODE = 0x0B45;
        public const uint GL_FRONT_FACE = 0x0B46;
        public const uint GL_DEPTH_RANGE = 0x0B70;
        public const uint GL_DEPTH_WRITEMASK = 0x0B72;
        public const uint GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const uint GL_DEPTH_FUNC = 0x0B74;
        public const uint GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const uint GL_STENCIL_FUNC = 0x0B92;
        public const uint GL_STENCIL_FAIL = 0x0B94;
        public const uint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const uint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const uint GL_STENCIL_REF = 0x0B97;
        public const uint GL_STENCIL_VALUE_MASK = 0x0B93;
        public const uint GL_STENCIL_WRITEMASK = 0x0B98;
        public const uint GL_STENCIL_BACK_FUNC = 0x8800;
        public const uint GL_STENCIL_BACK_FAIL = 0x8801;
        public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const uint GL_STENCIL_BACK_REF = 0x8CA3;
        public const uint GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const uint GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const uint GL_VIEWPORT = 0x0BA2;
        public const uint GL_SCISSOR_BOX = 0x0C10;
        public const uint GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const uint GL_COLOR_WRITEMASK = 0x0C23;
        public const uint GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const uint GL_PACK_ALIGNMENT = 0x0D05;
        public const uint GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const uint GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const uint GL_SUBPIXEL_BITS = 0x0D50;
        public const uint GL_RED_BITS = 0x0D52;
        public const uint GL_GREEN_BITS = 0x0D53;
        public const uint GL_BLUE_BITS = 0x0D54;
        public const uint GL_ALPHA_BITS = 0x0D55;
        public const uint GL_DEPTH_BITS = 0x0D56;
        public const uint GL_STENCIL_BITS = 0x0D57;
        public const uint GL_POLYGON_OFFSET_UNITS = 0x2A00;
        public const uint GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const uint GL_TEXTURE_BINDING_2D = 0x8069;
        public const uint GL_SAMPLE_BUFFERS = 0x80A8;
        public const uint GL_SAMPLES = 0x80A9;
        public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const uint GL_DONT_CARE = 0x1100;
        public const uint GL_FASTEST = 0x1101;
        public const uint GL_NICEST = 0x1102;
        public const uint GL_GENERATE_MIPMAP_HINT = 0x8192;
        public const uint GL_BYTE = 0x1400;
        public const uint GL_UNSIGNED_BYTE = 0x1401;
        public const uint GL_SHORT = 0x1402;
        public const uint GL_UNSIGNED_SHORT = 0x1403;
        public const uint GL_INT = 0x1404;
        public const uint GL_UNSIGNED_INT = 0x1405;
        public const uint GL_FLOAT = 0x1406;
        public const uint GL_FIXED = 0x140C;
        public const uint GL_DEPTH_COMPONENT = 0x1902;
        public const uint GL_ALPHA = 0x1906;
        public const uint GL_RGB = 0x1907;
        public const uint GL_RGBA = 0x1908;
        public const uint GL_LUMINANCE = 0x1909;
        public const uint GL_LUMINANCE_ALPHA = 0x190A;
        public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const uint GL_FRAGMENT_SHADER = 0x8B30;
        public const uint GL_VERTEX_SHADER = 0x8B31;
        public const uint GL_MAX_VERTEX_ATTRIBS = 0x8869;
        public const uint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const uint GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const uint GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const uint GL_SHADER_TYPE = 0x8B4F;
        public const uint GL_DELETE_STATUS = 0x8B80;
        public const uint GL_LINK_STATUS = 0x8B82;
        public const uint GL_VALIDATE_STATUS = 0x8B83;
        public const uint GL_ATTACHED_SHADERS = 0x8B85;
        public const uint GL_ACTIVE_UNIFORMS = 0x8B86;
        public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const uint GL_ACTIVE_ATTRIBUTES = 0x8B89;
        public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const uint GL_CURRENT_PROGRAM = 0x8B8D;
        public const uint GL_NEVER = 0x0200;
        public const uint GL_LESS = 0x0201;
        public const uint GL_EQUAL = 0x0202;
        public const uint GL_LEQUAL = 0x0203;
        public const uint GL_GREATER = 0x0204;
        public const uint GL_NOTEQUAL = 0x0205;
        public const uint GL_GEQUAL = 0x0206;
        public const uint GL_ALWAYS = 0x0207;
        public const uint GL_KEEP = 0x1E00;
        public const uint GL_REPLACE = 0x1E01;
        public const uint GL_INCR = 0x1E02;
        public const uint GL_DECR = 0x1E03;
        public const uint GL_INVERT = 0x150A;
        public const uint GL_INCR_WRAP = 0x8507;
        public const uint GL_DECR_WRAP = 0x8508;
        public const uint GL_VENDOR = 0x1F00;
        public const uint GL_RENDERER = 0x1F01;
        public const uint GL_VERSION = 0x1F02;
        public const uint GL_EXTENSIONS = 0x1F03;
        public const int GL_NEAREST = 0x2600;
        public const int GL_LINEAR = 0x2601;
        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
        public const uint GL_TEXTURE_MAG_FILTER = 0x2800;
        public const uint GL_TEXTURE_MIN_FILTER = 0x2801;
        public const uint GL_TEXTURE_WRAP_S = 0x2802;
        public const uint GL_TEXTURE_WRAP_T = 0x2803;
        public const uint GL_TEXTURE = 0x1702;
        public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const uint GL_TEXTURE0 = 0x84C0;
        public const uint GL_TEXTURE1 = 0x84C1;
        public const uint GL_TEXTURE2 = 0x84C2;
        public const uint GL_TEXTURE3 = 0x84C3;
        public const uint GL_TEXTURE4 = 0x84C4;
        public const uint GL_TEXTURE5 = 0x84C5;
        public const uint GL_TEXTURE6 = 0x84C6;
        public const uint GL_TEXTURE7 = 0x84C7;
        public const uint GL_TEXTURE8 = 0x84C8;
        public const uint GL_TEXTURE9 = 0x84C9;
        public const uint GL_TEXTURE10 = 0x84CA;
        public const uint GL_TEXTURE11 = 0x84CB;
        public const uint GL_TEXTURE12 = 0x84CC;
        public const uint GL_TEXTURE13 = 0x84CD;
        public const uint GL_TEXTURE14 = 0x84CE;
        public const uint GL_TEXTURE15 = 0x84CF;
        public const uint GL_TEXTURE16 = 0x84D0;
        public const uint GL_TEXTURE17 = 0x84D1;
        public const uint GL_TEXTURE18 = 0x84D2;
        public const uint GL_TEXTURE19 = 0x84D3;
        public const uint GL_TEXTURE20 = 0x84D4;
        public const uint GL_TEXTURE21 = 0x84D5;
        public const uint GL_TEXTURE22 = 0x84D6;
        public const uint GL_TEXTURE23 = 0x84D7;
        public const uint GL_TEXTURE24 = 0x84D8;
        public const uint GL_TEXTURE25 = 0x84D9;
        public const uint GL_TEXTURE26 = 0x84DA;
        public const uint GL_TEXTURE27 = 0x84DB;
        public const uint GL_TEXTURE28 = 0x84DC;
        public const uint GL_TEXTURE29 = 0x84DD;
        public const uint GL_TEXTURE30 = 0x84DE;
        public const uint GL_TEXTURE31 = 0x84DF;
        public const uint GL_ACTIVE_TEXTURE = 0x84E0;
        public const int GL_REPEAT = 0x2901;
        public const int GL_CLAMP_TO_EDGE = 0x812F;
        public const int GL_MIRRORED_REPEAT = 0x8370;
        public const uint GL_FLOAT_VEC2 = 0x8B50;
        public const uint GL_FLOAT_VEC3 = 0x8B51;
        public const uint GL_FLOAT_VEC4 = 0x8B52;
        public const uint GL_INT_VEC2 = 0x8B53;
        public const uint GL_INT_VEC3 = 0x8B54;
        public const uint GL_INT_VEC4 = 0x8B55;
        public const uint GL_BOOL = 0x8B56;
        public const uint GL_BOOL_VEC2 = 0x8B57;
        public const uint GL_BOOL_VEC3 = 0x8B58;
        public const uint GL_BOOL_VEC4 = 0x8B59;
        public const uint GL_FLOAT_MAT2 = 0x8B5A;
        public const uint GL_FLOAT_MAT3 = 0x8B5B;
        public const uint GL_FLOAT_MAT4 = 0x8B5C;
        public const uint GL_SAMPLER_2D = 0x8B5E;
        public const uint GL_SAMPLER_CUBE = 0x8B60;
        public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const uint GL_COMPILE_STATUS = 0x8B81;
        public const uint GL_INFO_LOG_LENGTH = 0x8B84;
        public const uint GL_SHADER_SOURCE_LENGTH = 0x8B88;
        public const uint GL_SHADER_COMPILER = 0x8DFA;
        public const uint GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const uint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const uint GL_LOW_FLOAT = 0x8DF0;
        public const uint GL_MEDIUM_FLOAT = 0x8DF1;
        public const uint GL_HIGH_FLOAT = 0x8DF2;
        public const uint GL_LOW_INT = 0x8DF3;
        public const uint GL_MEDIUM_INT = 0x8DF4;
        public const uint GL_HIGH_INT = 0x8DF5;
        public const uint GL_FRAMEBUFFER = 0x8D40;
        public const uint GL_RENDERBUFFER = 0x8D41;
        public const uint GL_RGBA4 = 0x8056;
        public const uint GL_RGB5_A1 = 0x8057;
        public const uint GL_RGB565 = 0x8D62;
        public const uint GL_DEPTH_COMPONENT16 = 0x81A5;
        public const uint GL_STENCIL_INDEX8 = 0x8D48;
        public const uint GL_RENDERBUFFER_WIDTH = 0x8D42;
        public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43;
        public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
        public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0;
        public const uint GL_DEPTH_ATTACHMENT = 0x8D00;
        public const uint GL_STENCIL_ATTACHMENT = 0x8D20;
        public const uint GL_NONE = 0;
        public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6;
        public const uint GL_RENDERBUFFER_BINDING = 0x8CA7;
        public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
        public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;

        [DllImport(Path, EntryPoint = "glActiveTexture")]
        public static extern void glActiveTexture(uint texture);

        [DllImport(Path, EntryPoint = "glAttachShader")]
        public static extern void glAttachShader(uint program, uint shader);

        [DllImport(Path, EntryPoint = "glBindAttribLocation")]
        public static extern void glBindAttribLocation(uint program, uint index, string name);

        [DllImport(Path, EntryPoint = "glBindBuffer")]
        public static extern void glBindBuffer(uint target, uint buffer);

        [DllImport(Path, EntryPoint = "glBindFramebuffer")]
        public static extern void glBindFramebuffer(uint target, uint framebuffer);

        [DllImport(Path, EntryPoint = "glBindRenderbuffer")]
        public static extern void glBindRenderbuffer(uint target, uint renderbuffer);

        [DllImport(Path, EntryPoint = "glBindTexture")]
        public static extern void glBindTexture(uint target, uint texture);

        [DllImport(Path, EntryPoint = "glBlendColor")]
        public static extern void glBlendColor(float red, float green, float blue, float alpha);

        [DllImport(Path, EntryPoint = "glBlendEquation")]
        public static extern void glBlendEquation(uint mode);

        [DllImport(Path, EntryPoint = "glBlendEquationSeparate")]
        public static extern void glBlendEquationSeparate(uint modeRGB, uint modeAlpha);

        [DllImport(Path, EntryPoint = "glBlendFunc")]
        public static extern void glBlendFunc(uint sfactor, uint dfactor);

        [DllImport(Path, EntryPoint = "glBlendFuncSeparate")]
        public static extern void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

        [DllImport(Path, EntryPoint = "glBufferData")]
        public static extern void glBufferData(uint target, int size, IntPtr data, uint usage);

        [DllImport(Path, EntryPoint = "glBufferSubData")]
        public static extern void glBufferSubData(uint target, int offset, int size, IntPtr data);

        [DllImport(Path, EntryPoint = "glCheckFramebufferStatus")]
        public static extern uint glCheckFramebufferStatus(uint target);

        [DllImport(Path, EntryPoint = "glClear")]
        public static extern void glClear(uint mask);

        [DllImport(Path, EntryPoint = "glClearColor")]
        public static extern void glClearColor(float red, float green, float blue, float alpha);

        [DllImport(Path, EntryPoint = "glClearDepthf")]
        public static extern void glClearDepthf(float d);

        [DllImport(Path, EntryPoint = "glClearStencil")]
        public static extern void glClearStencil(int s);

        [DllImport(Path, EntryPoint = "glColorMask")]
        public static extern void glColorMask(bool red, bool green, bool blue, bool alpha);

        [DllImport(Path, EntryPoint = "glCompileShader")]
        public static extern void glCompileShader(uint shader);

        [DllImport(Path, EntryPoint = "glCompressedTexImage2D")]
        public static extern void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);

        [DllImport(Path, EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

        [DllImport(Path, EntryPoint = "glCopyTexImage2D")]
        public static extern void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

        [DllImport(Path, EntryPoint = "glCopyTexSubImage2D")]
        public static extern void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImport(Path, EntryPoint = "glCreateProgram")]
        public static extern uint glCreateProgram();

        [DllImport(Path, EntryPoint = "glCreateShader")]
        public static extern uint glCreateShader(uint type);

        [DllImport(Path, EntryPoint = "glCullFace")]
        public static extern void glCullFace(uint mode);

        [DllImport(Path, EntryPoint = "glDeleteBuffers")]
        public static extern void glDeleteBuffers(int n, uint[] buffers);

        [DllImport(Path, EntryPoint = "glDeleteFramebuffers")]
        public static extern void glDeleteFramebuffers(int n, uint[] framebuffers);

        [DllImport(Path, EntryPoint = "glDeleteProgram")]
        public static extern void glDeleteProgram(uint program);

        [DllImport(Path, EntryPoint = "glDeleteRenderbuffers")]
        public static extern void glDeleteRenderbuffers(int n, uint[] renderbuffers);

        [DllImport(Path, EntryPoint = "glDeleteShader")]
        public static extern void glDeleteShader(uint shader);

        [DllImport(Path, EntryPoint = "glDeleteTextures")]
        public static extern void glDeleteTextures(int n, uint[] textures);

        [DllImport(Path, EntryPoint = "glDepthFunc")]
        public static extern void glDepthFunc(uint func);

        [DllImport(Path, EntryPoint = "glDepthMask")]
        public static extern void glDepthMask(bool flag);

        [DllImport(Path, EntryPoint = "glDepthRangef")]
        public static extern void glDepthRangef(float n, float f);

        [DllImport(Path, EntryPoint = "glDetachShader")]
        public static extern void glDetachShader(uint program, uint shader);

        [DllImport(Path, EntryPoint = "glDisable")]
        public static extern void glDisable(uint cap);

        [DllImport(Path, EntryPoint = "glDisableVertexAttribArray")]
        public static extern void glDisableVertexAttribArray(uint index);

        [DllImport(Path, EntryPoint = "glDrawArrays")]
        public static extern void glDrawArrays(uint mode, int first, int count);

        [DllImport(Path, EntryPoint = "glDrawElements")]
        public static extern void glDrawElements(uint mode, int count, uint type, IntPtr indices);

        public static void glDrawElements(uint mode, int count, uint type, uint offset) => glDrawElements(mode, count, type, (IntPtr)offset);

        [DllImport(Path, EntryPoint = "glEnable")]
        public static extern void glEnable(uint cap);

        [DllImport(Path, EntryPoint = "glEnableVertexAttribArray")]
        public static extern void glEnableVertexAttribArray(uint index);

        [DllImport(Path, EntryPoint = "glFinish")]
        public static extern void glFinish();

        [DllImport(Path, EntryPoint = "glFlush")]
        public static extern void glFlush();

        [DllImport(Path, EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

        [DllImport(Path, EntryPoint = "glFramebufferTexture2D")]
        public static extern void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

        [DllImport(Path, EntryPoint = "glFrontFace")]
        public static extern void glFrontFace(uint mode);

        [DllImport(Path, EntryPoint = "glGenBuffers")]
        public static extern void glGenBuffers(int n, uint[] buffers);

        [DllImport(Path, EntryPoint = "glGenerateMipmap")]
        public static extern void glGenerateMipmap(uint target);

        [DllImport(Path, EntryPoint = "glGenFramebuffers")]
        public static extern void glGenFramebuffers(int n, uint[] framebuffers);

        [DllImport(Path, EntryPoint = "glGenRenderbuffers")]
        public static extern void glGenRenderbuffers(int n, uint[] renderbuffers);

        [DllImport(Path, EntryPoint = "glGenTextures")]
        public static extern void glGenTextures(int n, uint[] textures);

        [DllImport(Path, EntryPoint = "glGetActiveAttrib")]
        public static extern void glGetActiveAttrib(uint program, uint index, int bufSize, int length, int size, uint type, string name);

        [DllImport(Path, EntryPoint = "glGetActiveUniform")]
        public static extern void glGetActiveUniform(uint program, uint index, int bufSize, int length, int size, uint type, string name);

        [DllImport(Path, EntryPoint = "glGetAttachedShaders")]
        public static extern void glGetAttachedShaders(uint program, int maxCount, int count, uint[] shaders);

        [DllImport(Path, EntryPoint = "glGetAttribLocation")]
        public static extern int glGetAttribLocation(uint program, string name);

        [DllImport(Path, EntryPoint = "glGetBooleanv")]
        public static extern void glGetBooleanv(uint pname, bool data);

        [DllImport(Path, EntryPoint = "glGetBufferParameteriv")]
        public static extern void glGetBufferParameteriv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetError")]
        public static extern uint glGetError();

        [DllImport(Path, EntryPoint = "glGetFloatv")]
        public static extern void glGetFloatv(uint pname, float[] data);

        [DllImport(Path, EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetIntegerv")]
        public static extern void glGetIntegerv(uint pname, int[] data);

        [DllImport(Path, EntryPoint = "glGetProgramiv")]
        public static extern void glGetProgramiv(uint program, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetProgramiv")]
        public static extern void glGetProgramiv(uint program, uint pname, out int @params);

        [DllImport(Path, EntryPoint = "glGetProgramInfoLog")]
        public static extern void glGetProgramInfoLog(uint program, int bufSize, int length, byte[] infoLog);

        [DllImport(Path, EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void glGetRenderbufferParameteriv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetShaderiv")]
        public static extern void glGetShaderiv(uint shader, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetShaderiv")]
        public static extern void glGetShaderiv(uint shader, uint pname, out int @params);

        [DllImport(Path, EntryPoint = "glGetShaderInfoLog")]
        public static extern void glGetShaderInfoLog(uint shader, int bufSize, int length, byte[] infoLog);

        [DllImport(Path, EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int range, int precision);

        [DllImport(Path, EntryPoint = "glGetShaderSource")]
        public static extern void glGetShaderSource(uint shader, int bufSize, int length, byte[] source);

        [DllImport(Path, EntryPoint = "glGetString")]
        public static extern byte glGetString(uint name);

        [DllImport(Path, EntryPoint = "glGetTexParameterfv")]
        public static extern void glGetTexParameterfv(uint target, uint pname, float[] @params);

        [DllImport(Path, EntryPoint = "glGetTexParameteriv")]
        public static extern void glGetTexParameteriv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetUniformfv")]
        public static extern void glGetUniformfv(uint program, int location, float[] @params);

        [DllImport(Path, EntryPoint = "glGetUniformiv")]
        public static extern void glGetUniformiv(uint program, int location, int[] @params);

        [DllImport(Path, EntryPoint = "glGetUniformLocation")]
        public static extern int glGetUniformLocation(uint program, string name);

        [DllImport(Path, EntryPoint = "glGetVertexAttribfv")]
        public static extern void glGetVertexAttribfv(uint index, uint pname, float[] @params);

        [DllImport(Path, EntryPoint = "glGetVertexAttribiv")]
        public static extern void glGetVertexAttribiv(uint index, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void glGetVertexAttribPointerv(uint index, uint pname, IntPtr pointer);

        [DllImport(Path, EntryPoint = "glHint")]
        public static extern void glHint(uint target, uint mode);

        [DllImport(Path, EntryPoint = "glIsBuffer")]
        public static extern bool glIsBuffer(uint buffer);

        [DllImport(Path, EntryPoint = "glIsEnabled")]
        public static extern bool glIsEnabled(uint cap);

        [DllImport(Path, EntryPoint = "glIsFramebuffer")]
        public static extern bool glIsFramebuffer(uint framebuffer);

        [DllImport(Path, EntryPoint = "glIsProgram")]
        public static extern bool glIsProgram(uint program);

        [DllImport(Path, EntryPoint = "glIsRenderbuffer")]
        public static extern bool glIsRenderbuffer(uint renderbuffer);

        [DllImport(Path, EntryPoint = "glIsShader")]
        public static extern bool glIsShader(uint shader);

        [DllImport(Path, EntryPoint = "glIsTexture")]
        public static extern bool glIsTexture(uint texture);

        [DllImport(Path, EntryPoint = "glLineWidth")]
        public static extern void glLineWidth(float width);

        [DllImport(Path, EntryPoint = "glLinkProgram")]
        public static extern void glLinkProgram(uint program);

        [DllImport(Path, EntryPoint = "glPixelStorei")]
        public static extern void glPixelStorei(uint pname, int param);

        [DllImport(Path, EntryPoint = "glPolygonOffset")]
        public static extern void glPolygonOffset(float factor, float units);

        [DllImport(Path, EntryPoint = "glReadPixels")]
        public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);

        [DllImport(Path, EntryPoint = "glReleaseShaderCompiler")]
        public static extern void glReleaseShaderCompiler();

        [DllImport(Path, EntryPoint = "glRenderbufferStorage")]
        public static extern void glRenderbufferStorage(uint target, uint internalformat, int width, int height);

        [DllImport(Path, EntryPoint = "glSampleCoverage")]
        public static extern void glSampleCoverage(float value, bool invert);

        [DllImport(Path, EntryPoint = "glScissor")]
        public static extern void glScissor(int x, int y, int width, int height);

        [DllImport(Path, EntryPoint = "glShaderBinary")]
        public static extern void glShaderBinary(int count, uint shaders, uint binaryformat, IntPtr binary, int length);

        [DllImport(Path, EntryPoint = "glShaderSource")]
        public static extern void glShaderSource(uint shader, int count, string[] conststring, int[] length);

        [DllImport(Path, EntryPoint = "glStencilFunc")]
        public static extern void glStencilFunc(uint func, int @ref, uint mask);

        [DllImport(Path, EntryPoint = "glStencilFuncSeparate")]
        public static extern void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask);

        [DllImport(Path, EntryPoint = "glStencilMask")]
        public static extern void glStencilMask(uint mask);

        [DllImport(Path, EntryPoint = "glStencilMaskSeparate")]
        public static extern void glStencilMaskSeparate(uint face, uint mask);

        [DllImport(Path, EntryPoint = "glStencilOp")]
        public static extern void glStencilOp(uint fail, uint zfail, uint zpass);

        [DllImport(Path, EntryPoint = "glStencilOpSeparate")]
        public static extern void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

        [DllImport(Path, EntryPoint = "glTexImage2D")]
        public static extern void glTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);

        [DllImport(Path, EntryPoint = "glTexParameterf")]
        public static extern void glTexParameterf(uint target, uint pname, float param);

        [DllImport(Path, EntryPoint = "glTexParameterfv")]
        public static extern void glTexParameterfv(uint target, uint pname, float[] @params);

        [DllImport(Path, EntryPoint = "glTexParameteri")]
        public static extern void glTexParameteri(uint target, uint pname, int param);

        [DllImport(Path, EntryPoint = "glTexParameteriv")]
        public static extern void glTexParameteriv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glTexSubImage2D")]
        public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

        [DllImport(Path, EntryPoint = "glUniform1f")]
        public static extern void glUniform1f(int location, float v0);

        [DllImport(Path, EntryPoint = "glUniform1fv")]
        public static extern void glUniform1fv(int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glUniform1i")]
        public static extern void glUniform1i(int location, int v0);

        [DllImport(Path, EntryPoint = "glUniform1iv")]
        public static extern void glUniform1iv(int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glUniform2f")]
        public static extern void glUniform2f(int location, float v0, float v1);

        [DllImport(Path, EntryPoint = "glUniform2fv")]
        public static extern void glUniform2fv(int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glUniform2i")]
        public static extern void glUniform2i(int location, int v0, int v1);

        [DllImport(Path, EntryPoint = "glUniform2iv")]
        public static extern void glUniform2iv(int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glUniform3f")]
        public static extern void glUniform3f(int location, float v0, float v1, float v2);

        [DllImport(Path, EntryPoint = "glUniform3fv")]
        public static extern void glUniform3fv(int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glUniform3i")]
        public static extern void glUniform3i(int location, int v0, int v1, int v2);

        [DllImport(Path, EntryPoint = "glUniform3iv")]
        public static extern void glUniform3iv(int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glUniform4f")]
        public static extern void glUniform4f(int location, float v0, float v1, float v2, float v3);

        [DllImport(Path, EntryPoint = "glUniform4fv")]
        public static extern void glUniform4fv(int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glUniform4i")]
        public static extern void glUniform4i(int location, int v0, int v1, int v2, int v3);

        [DllImport(Path, EntryPoint = "glUniform4iv")]
        public static extern void glUniform4iv(int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix2fv")]
        public static extern void glUniformMatrix2fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix3fv")]
        public static extern void glUniformMatrix3fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix4fv")]
        public static extern void glUniformMatrix4fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUseProgram")]
        public static extern void glUseProgram(uint program);

        [DllImport(Path, EntryPoint = "glValidateProgram")]
        public static extern void glValidateProgram(uint program);

        [DllImport(Path, EntryPoint = "glVertexAttrib1f")]
        public static extern void glVertexAttrib1f(uint index, float x);

        [DllImport(Path, EntryPoint = "glVertexAttrib1fv")]
        public static extern void glVertexAttrib1fv(uint index, float[] v);

        [DllImport(Path, EntryPoint = "glVertexAttrib2f")]
        public static extern void glVertexAttrib2f(uint index, float x, float y);

        [DllImport(Path, EntryPoint = "glVertexAttrib2fv")]
        public static extern void glVertexAttrib2fv(uint index, float[] v);

        [DllImport(Path, EntryPoint = "glVertexAttrib3f")]
        public static extern void glVertexAttrib3f(uint index, float x, float y, float z);

        [DllImport(Path, EntryPoint = "glVertexAttrib3fv")]
        public static extern void glVertexAttrib3fv(uint index, float[] v);

        [DllImport(Path, EntryPoint = "glVertexAttrib4f")]
        public static extern void glVertexAttrib4f(uint index, float x, float y, float z, float w);

        [DllImport(Path, EntryPoint = "glVertexAttrib4fv")]
        public static extern void glVertexAttrib4fv(uint index, float[] v);

        [DllImport(Path, EntryPoint = "glVertexAttribPointer")]
        public static extern void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

        [DllImport(Path, EntryPoint = "glViewport")]
        public static extern void glViewport(int x, int y, int width, int height);

        #endregion

        #region GL_ES_VERSION_3_0
        public const uint GL_ES_VERSION_3_0 = 1;
        public const uint GL_READ_BUFFER = 0x0C02;
        public const uint GL_UNPACK_ROW_LENGTH = 0x0CF2;
        public const uint GL_UNPACK_SKIP_ROWS = 0x0CF3;
        public const uint GL_UNPACK_SKIP_PIXELS = 0x0CF4;
        public const uint GL_PACK_ROW_LENGTH = 0x0D02;
        public const uint GL_PACK_SKIP_ROWS = 0x0D03;
        public const uint GL_PACK_SKIP_PIXELS = 0x0D04;
        public const uint GL_COLOR = 0x1800;
        public const uint GL_DEPTH = 0x1801;
        public const uint GL_STENCIL = 0x1802;
        public const uint GL_RED = 0x1903;
        public const uint GL_RGB8 = 0x8051;
        public const uint GL_RGBA8 = 0x8058;
        public const uint GL_RGB10_A2 = 0x8059;
        public const uint GL_TEXTURE_BINDING_3D = 0x806A;
        public const uint GL_UNPACK_SKIP_IMAGES = 0x806D;
        public const uint GL_UNPACK_IMAGE_HEIGHT = 0x806E;
        public const uint GL_TEXTURE_3D = 0x806F;
        public const uint GL_TEXTURE_WRAP_R = 0x8072;
        public const uint GL_MAX_3D_TEXTURE_SIZE = 0x8073;
        public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const uint GL_MAX_ELEMENTS_VERTICES = 0x80E8;
        public const uint GL_MAX_ELEMENTS_INDICES = 0x80E9;
        public const uint GL_TEXTURE_MIN_LOD = 0x813A;
        public const uint GL_TEXTURE_MAX_LOD = 0x813B;
        public const uint GL_TEXTURE_BASE_LEVEL = 0x813C;
        public const uint GL_TEXTURE_MAX_LEVEL = 0x813D;
        public const uint GL_MIN = 0x8007;
        public const uint GL_MAX = 0x8008;
        public const uint GL_DEPTH_COMPONENT24 = 0x81A6;
        public const uint GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
        public const uint GL_TEXTURE_COMPARE_MODE = 0x884C;
        public const uint GL_TEXTURE_COMPARE_FUNC = 0x884D;
        public const uint GL_CURRENT_QUERY = 0x8865;
        public const uint GL_QUERY_RESULT = 0x8866;
        public const uint GL_QUERY_RESULT_AVAILABLE = 0x8867;
        public const uint GL_BUFFER_MAPPED = 0x88BC;
        public const uint GL_BUFFER_MAP_POINTER = 0x88BD;
        public const uint GL_STREAM_READ = 0x88E1;
        public const uint GL_STREAM_COPY = 0x88E2;
        public const uint GL_STATIC_READ = 0x88E5;
        public const uint GL_STATIC_COPY = 0x88E6;
        public const uint GL_DYNAMIC_READ = 0x88E9;
        public const uint GL_DYNAMIC_COPY = 0x88EA;
        public const uint GL_MAX_DRAW_BUFFERS = 0x8824;
        public const uint GL_DRAW_BUFFER0 = 0x8825;
        public const uint GL_DRAW_BUFFER1 = 0x8826;
        public const uint GL_DRAW_BUFFER2 = 0x8827;
        public const uint GL_DRAW_BUFFER3 = 0x8828;
        public const uint GL_DRAW_BUFFER4 = 0x8829;
        public const uint GL_DRAW_BUFFER5 = 0x882A;
        public const uint GL_DRAW_BUFFER6 = 0x882B;
        public const uint GL_DRAW_BUFFER7 = 0x882C;
        public const uint GL_DRAW_BUFFER8 = 0x882D;
        public const uint GL_DRAW_BUFFER9 = 0x882E;
        public const uint GL_DRAW_BUFFER10 = 0x882F;
        public const uint GL_DRAW_BUFFER11 = 0x8830;
        public const uint GL_DRAW_BUFFER12 = 0x8831;
        public const uint GL_DRAW_BUFFER13 = 0x8832;
        public const uint GL_DRAW_BUFFER14 = 0x8833;
        public const uint GL_DRAW_BUFFER15 = 0x8834;
        public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
        public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
        public const uint GL_SAMPLER_3D = 0x8B5F;
        public const uint GL_SAMPLER_2D_SHADOW = 0x8B62;
        public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
        public const uint GL_PIXEL_PACK_BUFFER = 0x88EB;
        public const uint GL_PIXEL_UNPACK_BUFFER = 0x88EC;
        public const uint GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const uint GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const uint GL_FLOAT_MAT2x3 = 0x8B65;
        public const uint GL_FLOAT_MAT2x4 = 0x8B66;
        public const uint GL_FLOAT_MAT3x2 = 0x8B67;
        public const uint GL_FLOAT_MAT3x4 = 0x8B68;
        public const uint GL_FLOAT_MAT4x2 = 0x8B69;
        public const uint GL_FLOAT_MAT4x3 = 0x8B6A;
        public const uint GL_SRGB = 0x8C40;
        public const uint GL_SRGB8 = 0x8C41;
        public const uint GL_SRGB8_ALPHA8 = 0x8C43;
        public const uint GL_COMPARE_REF_TO_TEXTURE = 0x884E;
        public const uint GL_MAJOR_VERSION = 0x821B;
        public const uint GL_MINOR_VERSION = 0x821C;
        public const uint GL_NUM_EXTENSIONS = 0x821D;
        public const uint GL_RGBA32F = 0x8814;
        public const uint GL_RGB32F = 0x8815;
        public const uint GL_RGBA16F = 0x881A;
        public const uint GL_RGB16F = 0x881B;
        public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
        public const uint GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
        public const uint GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
        public const uint GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
        public const uint GL_MAX_VARYING_COMPONENTS = 0x8B4B;
        public const uint GL_TEXTURE_2D_ARRAY = 0x8C1A;
        public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        public const uint GL_R11F_G11F_B10F = 0x8C3A;
        public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
        public const uint GL_RGB9_E5 = 0x8C3D;
        public const uint GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const uint GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
        public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
        public const uint GL_RASTERIZER_DISCARD = 0x8C89;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        public const uint GL_INTERLEAVED_ATTRIBS = 0x8C8C;
        public const uint GL_SEPARATE_ATTRIBS = 0x8C8D;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
        public const uint GL_RGBA32UI = 0x8D70;
        public const uint GL_RGB32UI = 0x8D71;
        public const uint GL_RGBA16UI = 0x8D76;
        public const uint GL_RGB16UI = 0x8D77;
        public const uint GL_RGBA8UI = 0x8D7C;
        public const uint GL_RGB8UI = 0x8D7D;
        public const uint GL_RGBA32I = 0x8D82;
        public const uint GL_RGB32I = 0x8D83;
        public const uint GL_RGBA16I = 0x8D88;
        public const uint GL_RGB16I = 0x8D89;
        public const uint GL_RGBA8I = 0x8D8E;
        public const uint GL_RGB8I = 0x8D8F;
        public const uint GL_RED_INTEGER = 0x8D94;
        public const uint GL_RGB_INTEGER = 0x8D98;
        public const uint GL_RGBA_INTEGER = 0x8D99;
        public const uint GL_SAMPLER_2D_ARRAY = 0x8DC1;
        public const uint GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
        public const uint GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
        public const uint GL_UNSIGNED_INT_VEC2 = 0x8DC6;
        public const uint GL_UNSIGNED_INT_VEC3 = 0x8DC7;
        public const uint GL_UNSIGNED_INT_VEC4 = 0x8DC8;
        public const uint GL_INT_SAMPLER_2D = 0x8DCA;
        public const uint GL_INT_SAMPLER_3D = 0x8DCB;
        public const uint GL_INT_SAMPLER_CUBE = 0x8DCC;
        public const uint GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
        public const uint GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
        public const uint GL_BUFFER_ACCESS_FLAGS = 0x911F;
        public const uint GL_BUFFER_MAP_LENGTH = 0x9120;
        public const uint GL_BUFFER_MAP_OFFSET = 0x9121;
        public const uint GL_DEPTH_COMPONENT32F = 0x8CAC;
        public const uint GL_DEPTH32F_STENCIL8 = 0x8CAD;
        public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        public const uint GL_FRAMEBUFFER_DEFAULT = 0x8218;
        public const uint GL_FRAMEBUFFER_UNDEFINED = 0x8219;
        public const uint GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
        public const uint GL_DEPTH_STENCIL = 0x84F9;
        public const uint GL_UNSIGNED_INT_24_8 = 0x84FA;
        public const uint GL_DEPTH24_STENCIL8 = 0x88F0;
        public const uint GL_UNSIGNED_NORMALIZED = 0x8C17;
        public const uint GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
        public const uint GL_READ_FRAMEBUFFER = 0x8CA8;
        public const uint GL_DRAW_FRAMEBUFFER = 0x8CA9;
        public const uint GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
        public const uint GL_RENDERBUFFER_SAMPLES = 0x8CAB;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const uint GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
        public const uint GL_COLOR_ATTACHMENT1 = 0x8CE1;
        public const uint GL_COLOR_ATTACHMENT2 = 0x8CE2;
        public const uint GL_COLOR_ATTACHMENT3 = 0x8CE3;
        public const uint GL_COLOR_ATTACHMENT4 = 0x8CE4;
        public const uint GL_COLOR_ATTACHMENT5 = 0x8CE5;
        public const uint GL_COLOR_ATTACHMENT6 = 0x8CE6;
        public const uint GL_COLOR_ATTACHMENT7 = 0x8CE7;
        public const uint GL_COLOR_ATTACHMENT8 = 0x8CE8;
        public const uint GL_COLOR_ATTACHMENT9 = 0x8CE9;
        public const uint GL_COLOR_ATTACHMENT10 = 0x8CEA;
        public const uint GL_COLOR_ATTACHMENT11 = 0x8CEB;
        public const uint GL_COLOR_ATTACHMENT12 = 0x8CEC;
        public const uint GL_COLOR_ATTACHMENT13 = 0x8CED;
        public const uint GL_COLOR_ATTACHMENT14 = 0x8CEE;
        public const uint GL_COLOR_ATTACHMENT15 = 0x8CEF;
        public const uint GL_COLOR_ATTACHMENT16 = 0x8CF0;
        public const uint GL_COLOR_ATTACHMENT17 = 0x8CF1;
        public const uint GL_COLOR_ATTACHMENT18 = 0x8CF2;
        public const uint GL_COLOR_ATTACHMENT19 = 0x8CF3;
        public const uint GL_COLOR_ATTACHMENT20 = 0x8CF4;
        public const uint GL_COLOR_ATTACHMENT21 = 0x8CF5;
        public const uint GL_COLOR_ATTACHMENT22 = 0x8CF6;
        public const uint GL_COLOR_ATTACHMENT23 = 0x8CF7;
        public const uint GL_COLOR_ATTACHMENT24 = 0x8CF8;
        public const uint GL_COLOR_ATTACHMENT25 = 0x8CF9;
        public const uint GL_COLOR_ATTACHMENT26 = 0x8CFA;
        public const uint GL_COLOR_ATTACHMENT27 = 0x8CFB;
        public const uint GL_COLOR_ATTACHMENT28 = 0x8CFC;
        public const uint GL_COLOR_ATTACHMENT29 = 0x8CFD;
        public const uint GL_COLOR_ATTACHMENT30 = 0x8CFE;
        public const uint GL_COLOR_ATTACHMENT31 = 0x8CFF;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const uint GL_MAX_SAMPLES = 0x8D57;
        public const uint GL_HALF_FLOAT = 0x140B;
        public const uint GL_MAP_READ_BIT = 0x0001;
        public const uint GL_MAP_WRITE_BIT = 0x0002;
        public const uint GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
        public const uint GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        public const uint GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        public const uint GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
        public const uint GL_RG = 0x8227;
        public const uint GL_RG_INTEGER = 0x8228;
        public const uint GL_R8 = 0x8229;
        public const uint GL_RG8 = 0x822B;
        public const uint GL_R16F = 0x822D;
        public const uint GL_R32F = 0x822E;
        public const uint GL_RG16F = 0x822F;
        public const uint GL_RG32F = 0x8230;
        public const uint GL_R8I = 0x8231;
        public const uint GL_R8UI = 0x8232;
        public const uint GL_R16I = 0x8233;
        public const uint GL_R16UI = 0x8234;
        public const uint GL_R32I = 0x8235;
        public const uint GL_R32UI = 0x8236;
        public const uint GL_RG8I = 0x8237;
        public const uint GL_RG8UI = 0x8238;
        public const uint GL_RG16I = 0x8239;
        public const uint GL_RG16UI = 0x823A;
        public const uint GL_RG32I = 0x823B;
        public const uint GL_RG32UI = 0x823C;
        public const uint GL_VERTEX_ARRAY_BINDING = 0x85B5;
        public const uint GL_R8_SNORM = 0x8F94;
        public const uint GL_RG8_SNORM = 0x8F95;
        public const uint GL_RGB8_SNORM = 0x8F96;
        public const uint GL_RGBA8_SNORM = 0x8F97;
        public const uint GL_SIGNED_NORMALIZED = 0x8F9C;
        public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        public const uint GL_COPY_READ_BUFFER = 0x8F36;
        public const uint GL_COPY_WRITE_BUFFER = 0x8F37;
        public const uint GL_COPY_READ_BUFFER_BINDING = 0x8F36;
        public const uint GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const uint GL_UNIFORM_BUFFER = 0x8A11;
        public const uint GL_UNIFORM_BUFFER_BINDING = 0x8A28;
        public const uint GL_UNIFORM_BUFFER_START = 0x8A29;
        public const uint GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const uint GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const uint GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        public const uint GL_UNIFORM_TYPE = 0x8A37;
        public const uint GL_UNIFORM_SIZE = 0x8A38;
        public const uint GL_UNIFORM_NAME_LENGTH = 0x8A39;
        public const uint GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
        public const uint GL_UNIFORM_OFFSET = 0x8A3B;
        public const uint GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
        public const uint GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
        public const uint GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        public const uint GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
        public const uint GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        public const uint GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint GL_INVALID_INDEX = 0xFFFFFFFFu;
        public const uint GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        public const uint GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        public const uint GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        public const uint GL_OBJECT_TYPE = 0x9112;
        public const uint GL_SYNC_CONDITION = 0x9113;
        public const uint GL_SYNC_STATUS = 0x9114;
        public const uint GL_SYNC_FLAGS = 0x9115;
        public const uint GL_SYNC_FENCE = 0x9116;
        public const uint GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        public const uint GL_UNSIGNALED = 0x9118;
        public const uint GL_SIGNALED = 0x9119;
        public const uint GL_ALREADY_SIGNALED = 0x911A;
        public const uint GL_TIMEOUT_EXPIRED = 0x911B;
        public const uint GL_CONDITION_SATISFIED = 0x911C;
        public const uint GL_WAIT_FAILED = 0x911D;
        public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
        public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
        public const uint GL_ANY_SAMPLES_PASSED = 0x8C2F;
        public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        public const uint GL_SAMPLER_BINDING = 0x8919;
        public const uint GL_RGB10_A2UI = 0x906F;
        public const uint GL_TEXTURE_SWIZZLE_R = 0x8E42;
        public const uint GL_TEXTURE_SWIZZLE_G = 0x8E43;
        public const uint GL_TEXTURE_SWIZZLE_B = 0x8E44;
        public const uint GL_TEXTURE_SWIZZLE_A = 0x8E45;
        public const uint GL_GREEN = 0x1904;
        public const uint GL_BLUE = 0x1905;
        public const uint GL_INT_2_10_10_10_REV = 0x8D9F;
        public const uint GL_TRANSFORM_FEEDBACK = 0x8E22;
        public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const uint GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        public const uint GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const uint GL_PROGRAM_BINARY_LENGTH = 0x8741;
        public const uint GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const uint GL_PROGRAM_BINARY_FORMATS = 0x87FF;
        public const uint GL_COMPRESSED_R11_EAC = 0x9270;
        public const uint GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
        public const uint GL_COMPRESSED_RG11_EAC = 0x9272;
        public const uint GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        public const uint GL_COMPRESSED_RGB8_ETC2 = 0x9274;
        public const uint GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
        public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        public const uint GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
        public const uint GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const uint GL_MAX_ELEMENT_INDEX = 0x8D6B;
        public const uint GL_NUM_SAMPLE_COUNTS = 0x9380;
        public const uint GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

        [DllImport(Path, EntryPoint = "glReadBuffer")]
        public static extern void glReadBuffer(uint src);

        [DllImport(Path, EntryPoint = "glDrawRangeElements")]
        public static extern void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices);

        [DllImport(Path, EntryPoint = "glTexImage3D")]
        public static extern void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);

        [DllImport(Path, EntryPoint = "glTexSubImage3D")]
        public static extern void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

        [DllImport(Path, EntryPoint = "glCopyTexSubImage3D")]
        public static extern void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [DllImport(Path, EntryPoint = "glCompressedTexImage3D")]
        public static extern void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

        [DllImport(Path, EntryPoint = "glCompressedTexSubImage3D")]
        public static extern void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

        [DllImport(Path, EntryPoint = "glGenQueries")]
        public static extern void glGenQueries(int n, uint ids);

        [DllImport(Path, EntryPoint = "glDeleteQueries")]
        public static extern void glDeleteQueries(int n, uint ids);

        [DllImport(Path, EntryPoint = "glIsQuery")]
        public static extern bool glIsQuery(uint id);

        [DllImport(Path, EntryPoint = "glBeginQuery")]
        public static extern void glBeginQuery(uint target, uint id);

        [DllImport(Path, EntryPoint = "glEndQuery")]
        public static extern void glEndQuery(uint target);

        [DllImport(Path, EntryPoint = "glGetQueryiv")]
        public static extern void glGetQueryiv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetQueryObjectuiv")]
        public static extern void glGetQueryObjectuiv(uint id, uint pname, uint[] @params);

        [DllImport(Path, EntryPoint = "glUnmapBuffer")]
        public static extern bool glUnmapBuffer(uint target);

        [DllImport(Path, EntryPoint = "glGetBufferPointerv")]
        public static extern void glGetBufferPointerv(uint target, uint pname, IntPtr[] @params);

        [DllImport(Path, EntryPoint = "glDrawBuffers")]
        public static extern void glDrawBuffers(int n, uint[] bufs);

        [DllImport(Path, EntryPoint = "glUniformMatrix2x3fv")]
        public static extern void glUniformMatrix2x3fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix3x2fv")]
        public static extern void glUniformMatrix3x2fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix2x4fv")]
        public static extern void glUniformMatrix2x4fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix4x2fv")]
        public static extern void glUniformMatrix4x2fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix3x4fv")]
        public static extern void glUniformMatrix3x4fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glUniformMatrix4x3fv")]
        public static extern void glUniformMatrix4x3fv(int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glBlitFramebuffer")]
        public static extern void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        [DllImport(Path, EntryPoint = "glRenderbufferStorageMultisample")]
        public static extern void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

        [DllImport(Path, EntryPoint = "glFramebufferTextureLayer")]
        public static extern void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);

        [DllImport(Path, EntryPoint = "glMapBufferRange")]
        public static extern void glMapBufferRange(uint target, int offset, int length, uint access);

        [DllImport(Path, EntryPoint = "glFlushMappedBufferRange")]
        public static extern void glFlushMappedBufferRange(uint target, int offset, int length);

        [DllImport(Path, EntryPoint = "glBindVertexArray")]
        public static extern void glBindVertexArray(uint array);

        [DllImport(Path, EntryPoint = "glDeleteVertexArrays")]
        public static extern void glDeleteVertexArrays(int n, uint[] arrays);

        [DllImport(Path, EntryPoint = "glGenVertexArrays")]
        public static extern void glGenVertexArrays(int n, uint[] arrays);

        [DllImport(Path, EntryPoint = "glIsVertexArray")]
        public static extern bool glIsVertexArray(uint array);

        [DllImport(Path, EntryPoint = "glGetIntegeri_v")]
        public static extern void glGetIntegeri_v(uint target, uint index, int data);

        [DllImport(Path, EntryPoint = "glBeginTransformFeedback")]
        public static extern void glBeginTransformFeedback(uint primitiveMode);

        [DllImport(Path, EntryPoint = "glEndTransformFeedback")]
        public static extern void glEndTransformFeedback();

        [DllImport(Path, EntryPoint = "glBindBufferRange")]
        public static extern void glBindBufferRange(uint target, uint index, uint buffer, int offset, int size);

        [DllImport(Path, EntryPoint = "glBindBufferBase")]
        public static extern void glBindBufferBase(uint target, uint index, uint buffer);

        [DllImport(Path, EntryPoint = "glTransformFeedbackVaryings")]
        public static extern void glTransformFeedbackVaryings(uint program, int count, string[] constvaryings, uint bufferMode);

        [DllImport(Path, EntryPoint = "glGetTransformFeedbackVarying")]
        public static extern void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int length, int size, uint type, string name);

        [DllImport(Path, EntryPoint = "glVertexAttribIPointer")]
        public static extern void glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer);

        [DllImport(Path, EntryPoint = "glGetVertexAttribIiv")]
        public static extern void glGetVertexAttribIiv(uint index, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetVertexAttribIuiv")]
        public static extern void glGetVertexAttribIuiv(uint index, uint pname, uint[] @params);

        [DllImport(Path, EntryPoint = "glVertexAttribI4i")]
        public static extern void glVertexAttribI4i(uint index, int x, int y, int z, int w);

        [DllImport(Path, EntryPoint = "glVertexAttribI4ui")]
        public static extern void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

        [DllImport(Path, EntryPoint = "glVertexAttribI4iv")]
        public static extern void glVertexAttribI4iv(uint index, int v);

        [DllImport(Path, EntryPoint = "glVertexAttribI4uiv")]
        public static extern void glVertexAttribI4uiv(uint index, uint v);

        [DllImport(Path, EntryPoint = "glGetUniformuiv")]
        public static extern void glGetUniformuiv(uint program, int location, uint[] @params);

        [DllImport(Path, EntryPoint = "glGetFragDataLocation")]
        public static extern int glGetFragDataLocation(uint program, string name);

        [DllImport(Path, EntryPoint = "glUniform1ui")]
        public static extern void glUniform1ui(int location, uint v0);

        [DllImport(Path, EntryPoint = "glUniform2ui")]
        public static extern void glUniform2ui(int location, uint v0, uint v1);

        [DllImport(Path, EntryPoint = "glUniform3ui")]
        public static extern void glUniform3ui(int location, uint v0, uint v1, uint v2);

        [DllImport(Path, EntryPoint = "glUniform4ui")]
        public static extern void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

        [DllImport(Path, EntryPoint = "glUniform1uiv")]
        public static extern void glUniform1uiv(int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glUniform2uiv")]
        public static extern void glUniform2uiv(int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glUniform3uiv")]
        public static extern void glUniform3uiv(int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glUniform4uiv")]
        public static extern void glUniform4uiv(int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glClearBufferiv")]
        public static extern void glClearBufferiv(uint buffer, int drawbuffer, int[] value);

        [DllImport(Path, EntryPoint = "glClearBufferuiv")]
        public static extern void glClearBufferuiv(uint buffer, int drawbuffer, uint[] value);

        [DllImport(Path, EntryPoint = "glClearBufferfv")]
        public static extern void glClearBufferfv(uint buffer, int drawbuffer, float[] value);

        [DllImport(Path, EntryPoint = "glClearBufferfi")]
        public static extern void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

        [DllImport(Path, EntryPoint = "glGetStringi")]
        public static extern byte glGetStringi(uint name, uint index);

        [DllImport(Path, EntryPoint = "glCopyBufferSubData")]
        public static extern void glCopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size);

        [DllImport(Path, EntryPoint = "glGetUniformIndices")]
        public static extern void glGetUniformIndices(uint program, int uniformCount, string constuniformNames, uint uniformIndices);

        [DllImport(Path, EntryPoint = "glGetActiveUniformsiv")]
        public static extern void glGetActiveUniformsiv(uint program, int uniformCount, uint uniformIndices, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetUniformBlockIndex")]
        public static extern uint glGetUniformBlockIndex(uint program, string uniformBlockName);

        [DllImport(Path, EntryPoint = "glGetActiveUniformBlockiv")]
        public static extern void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetActiveUniformBlockName")]
        public static extern void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int length, string uniformBlockName);

        [DllImport(Path, EntryPoint = "glUniformBlockBinding")]
        public static extern void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

        [DllImport(Path, EntryPoint = "glDrawArraysInstanced")]
        public static extern void glDrawArraysInstanced(uint mode, int first, int count, int instancecount);

        [DllImport(Path, EntryPoint = "glDrawElementsInstanced")]
        public static extern void glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount);

        [DllImport(Path, EntryPoint = "glIsSync")]
        public static extern bool glIsSync(IntPtr sync);

        [DllImport(Path, EntryPoint = "glDeleteSync")]
        public static extern void glDeleteSync(IntPtr sync);

        [DllImport(Path, EntryPoint = "glClientWaitSync")]
        public static extern uint glClientWaitSync(IntPtr sync, uint flags, uint timeout);

        [DllImport(Path, EntryPoint = "glWaitSync")]
        public static extern void glWaitSync(IntPtr sync, uint flags, uint timeout);

        [DllImport(Path, EntryPoint = "glGetInteger64v")]
        public static extern void glGetInteger64v(uint pname, int data);

        [DllImport(Path, EntryPoint = "glGetSynciv")]
        public static extern void glGetSynciv(IntPtr sync, uint pname, int bufSize, int length, int values);

        [DllImport(Path, EntryPoint = "glGetInteger64i_v")]
        public static extern void glGetInteger64i_v(uint target, uint index, int data);

        [DllImport(Path, EntryPoint = "glGetBufferParameteri64v")]
        public static extern void glGetBufferParameteri64v(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGenSamplers")]
        public static extern void glGenSamplers(int count, uint samplers);

        [DllImport(Path, EntryPoint = "glDeleteSamplers")]
        public static extern void glDeleteSamplers(int count, uint samplers);

        [DllImport(Path, EntryPoint = "glIsSampler")]
        public static extern bool glIsSampler(uint sampler);

        [DllImport(Path, EntryPoint = "glBindSampler")]
        public static extern void glBindSampler(uint unit, uint sampler);

        [DllImport(Path, EntryPoint = "glSamplerParameteri")]
        public static extern void glSamplerParameteri(uint sampler, uint pname, int param);

        [DllImport(Path, EntryPoint = "glSamplerParameteriv")]
        public static extern void glSamplerParameteriv(uint sampler, uint pname, int[] param);

        [DllImport(Path, EntryPoint = "glSamplerParameterf")]
        public static extern void glSamplerParameterf(uint sampler, uint pname, float param);

        [DllImport(Path, EntryPoint = "glSamplerParameterfv")]
        public static extern void glSamplerParameterfv(uint sampler, uint pname, float[] param);

        [DllImport(Path, EntryPoint = "glGetSamplerParameteriv")]
        public static extern void glGetSamplerParameteriv(uint sampler, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetSamplerParameterfv")]
        public static extern void glGetSamplerParameterfv(uint sampler, uint pname, float[] @params);

        [DllImport(Path, EntryPoint = "glVertexAttribDivisor")]
        public static extern void glVertexAttribDivisor(uint index, uint divisor);

        [DllImport(Path, EntryPoint = "glBindTransformFeedback")]
        public static extern void glBindTransformFeedback(uint target, uint id);

        [DllImport(Path, EntryPoint = "glDeleteTransformFeedbacks")]
        public static extern void glDeleteTransformFeedbacks(int n, uint ids);

        [DllImport(Path, EntryPoint = "glGenTransformFeedbacks")]
        public static extern void glGenTransformFeedbacks(int n, uint ids);

        [DllImport(Path, EntryPoint = "glIsTransformFeedback")]
        public static extern bool glIsTransformFeedback(uint id);

        [DllImport(Path, EntryPoint = "glPauseTransformFeedback")]
        public static extern void glPauseTransformFeedback();

        [DllImport(Path, EntryPoint = "glResumeTransformFeedback")]
        public static extern void glResumeTransformFeedback();

        [DllImport(Path, EntryPoint = "glGetProgramBinary")]
        public static extern void glGetProgramBinary(uint program, int bufSize, int length, uint binaryFormat, IntPtr binary);

        [DllImport(Path, EntryPoint = "glProgramBinary")]
        public static extern void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length);

        [DllImport(Path, EntryPoint = "glProgramParameteri")]
        public static extern void glProgramParameteri(uint program, uint pname, int value);

        [DllImport(Path, EntryPoint = "glInvalidateFramebuffer")]
        public static extern void glInvalidateFramebuffer(uint target, int numAttachments, uint attachments);

        [DllImport(Path, EntryPoint = "glInvalidateSubFramebuffer")]
        public static extern void glInvalidateSubFramebuffer(uint target, int numAttachments, uint attachments, int x, int y, int width, int height);

        [DllImport(Path, EntryPoint = "glTexStorage2D")]
        public static extern void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height);

        [DllImport(Path, EntryPoint = "glTexStorage3D")]
        public static extern void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

        [DllImport(Path, EntryPoint = "glGetInternalformativ")]
        public static extern void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params);

        #endregion

        #region GL_ES_VERSION_3_1
        public const uint GL_ES_VERSION_3_1 = 1;
        public const uint GL_COMPUTE_SHADER = 0x91B9;
        public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
        public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
        public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
        public const uint GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
        public const uint GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
        public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        public const uint GL_COMPUTE_SHADER_BIT = 0x00000020;
        public const uint GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
        public const uint GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
        public const uint GL_MAX_UNIFORM_LOCATIONS = 0x826E;
        public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
        public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
        public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
        public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        public const uint GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
        public const uint GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
        public const uint GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
        public const uint GL_UNIFORM = 0x92E1;
        public const uint GL_UNIFORM_BLOCK = 0x92E2;
        public const uint GL_PROGRAM_INPUT = 0x92E3;
        public const uint GL_PROGRAM_OUTPUT = 0x92E4;
        public const uint GL_BUFFER_VARIABLE = 0x92E5;
        public const uint GL_SHADER_STORAGE_BLOCK = 0x92E6;
        public const uint GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
        public const uint GL_ACTIVE_RESOURCES = 0x92F5;
        public const uint GL_MAX_NAME_LENGTH = 0x92F6;
        public const uint GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
        public const uint GL_NAME_LENGTH = 0x92F9;
        public const uint GL_TYPE = 0x92FA;
        public const uint GL_ARRAY_SIZE = 0x92FB;
        public const uint GL_OFFSET = 0x92FC;
        public const uint GL_BLOCK_INDEX = 0x92FD;
        public const uint GL_ARRAY_STRIDE = 0x92FE;
        public const uint GL_MATRIX_STRIDE = 0x92FF;
        public const uint GL_IS_ROW_MAJOR = 0x9300;
        public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
        public const uint GL_BUFFER_BINDING = 0x9302;
        public const uint GL_BUFFER_DATA_SIZE = 0x9303;
        public const uint GL_NUM_ACTIVE_VARIABLES = 0x9304;
        public const uint GL_ACTIVE_VARIABLES = 0x9305;
        public const uint GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
        public const uint GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
        public const uint GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
        public const uint GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
        public const uint GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
        public const uint GL_LOCATION = 0x930E;
        public const uint GL_VERTEX_SHADER_BIT = 0x00000001;
        public const uint GL_FRAGMENT_SHADER_BIT = 0x00000002;
        public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
        public const uint GL_PROGRAM_SEPARABLE = 0x8258;
        public const uint GL_ACTIVE_PROGRAM = 0x8259;
        public const uint GL_PROGRAM_PIPELINE_BINDING = 0x825A;
        public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
        public const uint GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
        public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
        public const uint GL_MAX_IMAGE_UNITS = 0x8F38;
        public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        public const uint GL_IMAGE_BINDING_NAME = 0x8F3A;
        public const uint GL_IMAGE_BINDING_LEVEL = 0x8F3B;
        public const uint GL_IMAGE_BINDING_LAYERED = 0x8F3C;
        public const uint GL_IMAGE_BINDING_LAYER = 0x8F3D;
        public const uint GL_IMAGE_BINDING_ACCESS = 0x8F3E;
        public const uint GL_IMAGE_BINDING_FORMAT = 0x906E;
        public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
        public const uint GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
        public const uint GL_UNIFORM_BARRIER_BIT = 0x00000004;
        public const uint GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
        public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
        public const uint GL_COMMAND_BARRIER_BIT = 0x00000040;
        public const uint GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
        public const uint GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
        public const uint GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
        public const uint GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
        public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
        public const uint GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
        public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
        public const uint GL_IMAGE_2D = 0x904D;
        public const uint GL_IMAGE_3D = 0x904E;
        public const uint GL_IMAGE_CUBE = 0x9050;
        public const uint GL_IMAGE_2D_ARRAY = 0x9053;
        public const uint GL_INT_IMAGE_2D = 0x9058;
        public const uint GL_INT_IMAGE_3D = 0x9059;
        public const uint GL_INT_IMAGE_CUBE = 0x905B;
        public const uint GL_INT_IMAGE_2D_ARRAY = 0x905E;
        public const uint GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
        public const uint GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const uint GL_READ_ONLY = 0x88B8;
        public const uint GL_WRITE_ONLY = 0x88B9;
        public const uint GL_READ_WRITE = 0x88BA;
        public const uint GL_SHADER_STORAGE_BUFFER = 0x90D2;
        public const uint GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
        public const uint GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
        public const uint GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
        public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
        public const uint GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
        public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        public const uint GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
        public const uint GL_STENCIL_INDEX = 0x1901;
        public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
        public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
        public const uint GL_SAMPLE_POSITION = 0x8E50;
        public const uint GL_SAMPLE_MASK = 0x8E51;
        public const uint GL_SAMPLE_MASK_VALUE = 0x8E52;
        public const uint GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const uint GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
        public const uint GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        public const uint GL_MAX_INTEGER_SAMPLES = 0x9110;
        public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const uint GL_TEXTURE_SAMPLES = 0x9106;
        public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const uint GL_TEXTURE_WIDTH = 0x1000;
        public const uint GL_TEXTURE_HEIGHT = 0x1001;
        public const uint GL_TEXTURE_DEPTH = 0x8071;
        public const uint GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
        public const uint GL_TEXTURE_RED_SIZE = 0x805C;
        public const uint GL_TEXTURE_GREEN_SIZE = 0x805D;
        public const uint GL_TEXTURE_BLUE_SIZE = 0x805E;
        public const uint GL_TEXTURE_ALPHA_SIZE = 0x805F;
        public const uint GL_TEXTURE_DEPTH_SIZE = 0x884A;
        public const uint GL_TEXTURE_STENCIL_SIZE = 0x88F1;
        public const uint GL_TEXTURE_SHARED_SIZE = 0x8C3F;
        public const uint GL_TEXTURE_RED_TYPE = 0x8C10;
        public const uint GL_TEXTURE_GREEN_TYPE = 0x8C11;
        public const uint GL_TEXTURE_BLUE_TYPE = 0x8C12;
        public const uint GL_TEXTURE_ALPHA_TYPE = 0x8C13;
        public const uint GL_TEXTURE_DEPTH_TYPE = 0x8C16;
        public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
        public const uint GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
        public const uint GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const uint GL_VERTEX_ATTRIB_BINDING = 0x82D4;
        public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
        public const uint GL_VERTEX_BINDING_DIVISOR = 0x82D6;
        public const uint GL_VERTEX_BINDING_OFFSET = 0x82D7;
        public const uint GL_VERTEX_BINDING_STRIDE = 0x82D8;
        public const uint GL_VERTEX_BINDING_BUFFER = 0x8F4F;
        public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
        public const uint GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

        [DllImport(Path, EntryPoint = "glDispatchCompute")]
        public static extern void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);

        [DllImport(Path, EntryPoint = "glDispatchComputeIndirect")]
        public static extern void glDispatchComputeIndirect(int indirect);

        [DllImport(Path, EntryPoint = "glDrawArraysIndirect")]
        public static extern void glDrawArraysIndirect(uint mode, IntPtr indirect);

        [DllImport(Path, EntryPoint = "glDrawElementsIndirect")]
        public static extern void glDrawElementsIndirect(uint mode, uint type, IntPtr indirect);

        [DllImport(Path, EntryPoint = "glFramebufferParameteri")]
        public static extern void glFramebufferParameteri(uint target, uint pname, int param);

        [DllImport(Path, EntryPoint = "glGetFramebufferParameteriv")]
        public static extern void glGetFramebufferParameteriv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetProgramInterfaceiv")]
        public static extern void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetProgramResourceIndex")]
        public static extern uint glGetProgramResourceIndex(uint program, uint programInterface, string name);

        [DllImport(Path, EntryPoint = "glGetProgramResourceName")]
        public static extern void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int length, string name);

        [DllImport(Path, EntryPoint = "glGetProgramResourceiv")]
        public static extern void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint props, int bufSize, int length, int[] @params);

        [DllImport(Path, EntryPoint = "glGetProgramResourceLocation")]
        public static extern int glGetProgramResourceLocation(uint program, uint programInterface, string name);

        [DllImport(Path, EntryPoint = "glUseProgramStages")]
        public static extern void glUseProgramStages(uint pipeline, uint stages, uint program);

        [DllImport(Path, EntryPoint = "glActiveShaderProgram")]
        public static extern void glActiveShaderProgram(uint pipeline, uint program);

        [DllImport(Path, EntryPoint = "glCreateShaderProgramv")]
        public static extern uint glCreateShaderProgramv(uint type, int count, string[] conststrings);

        [DllImport(Path, EntryPoint = "glBindProgramPipeline")]
        public static extern void glBindProgramPipeline(uint pipeline);

        [DllImport(Path, EntryPoint = "glDeleteProgramPipelines")]
        public static extern void glDeleteProgramPipelines(int n, uint pipelines);

        [DllImport(Path, EntryPoint = "glGenProgramPipelines")]
        public static extern void glGenProgramPipelines(int n, uint pipelines);

        [DllImport(Path, EntryPoint = "glIsProgramPipeline")]
        public static extern bool glIsProgramPipeline(uint pipeline);

        [DllImport(Path, EntryPoint = "glGetProgramPipelineiv")]
        public static extern void glGetProgramPipelineiv(uint pipeline, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glProgramUniform1i")]
        public static extern void glProgramUniform1i(uint program, int location, int v0);

        [DllImport(Path, EntryPoint = "glProgramUniform2i")]
        public static extern void glProgramUniform2i(uint program, int location, int v0, int v1);

        [DllImport(Path, EntryPoint = "glProgramUniform3i")]
        public static extern void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);

        [DllImport(Path, EntryPoint = "glProgramUniform4i")]
        public static extern void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

        [DllImport(Path, EntryPoint = "glProgramUniform1ui")]
        public static extern void glProgramUniform1ui(uint program, int location, uint v0);

        [DllImport(Path, EntryPoint = "glProgramUniform2ui")]
        public static extern void glProgramUniform2ui(uint program, int location, uint v0, uint v1);

        [DllImport(Path, EntryPoint = "glProgramUniform3ui")]
        public static extern void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

        [DllImport(Path, EntryPoint = "glProgramUniform4ui")]
        public static extern void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

        [DllImport(Path, EntryPoint = "glProgramUniform1f")]
        public static extern void glProgramUniform1f(uint program, int location, float v0);

        [DllImport(Path, EntryPoint = "glProgramUniform2f")]
        public static extern void glProgramUniform2f(uint program, int location, float v0, float v1);

        [DllImport(Path, EntryPoint = "glProgramUniform3f")]
        public static extern void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);

        [DllImport(Path, EntryPoint = "glProgramUniform4f")]
        public static extern void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

        [DllImport(Path, EntryPoint = "glProgramUniform1iv")]
        public static extern void glProgramUniform1iv(uint program, int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform2iv")]
        public static extern void glProgramUniform2iv(uint program, int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform3iv")]
        public static extern void glProgramUniform3iv(uint program, int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform4iv")]
        public static extern void glProgramUniform4iv(uint program, int location, int count, int[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform1uiv")]
        public static extern void glProgramUniform1uiv(uint program, int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform2uiv")]
        public static extern void glProgramUniform2uiv(uint program, int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform3uiv")]
        public static extern void glProgramUniform3uiv(uint program, int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform4uiv")]
        public static extern void glProgramUniform4uiv(uint program, int location, int count, uint[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform1fv")]
        public static extern void glProgramUniform1fv(uint program, int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform2fv")]
        public static extern void glProgramUniform2fv(uint program, int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform3fv")]
        public static extern void glProgramUniform3fv(uint program, int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniform4fv")]
        public static extern void glProgramUniform4fv(uint program, int location, int count, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix2fv")]
        public static extern void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix3fv")]
        public static extern void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix4fv")]
        public static extern void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix2x3fv")]
        public static extern void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix3x2fv")]
        public static extern void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix2x4fv")]
        public static extern void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix4x2fv")]
        public static extern void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix3x4fv")]
        public static extern void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glProgramUniformMatrix4x3fv")]
        public static extern void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value);

        [DllImport(Path, EntryPoint = "glValidateProgramPipeline")]
        public static extern void glValidateProgramPipeline(uint pipeline);

        [DllImport(Path, EntryPoint = "glGetProgramPipelineInfoLog")]
        public static extern void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int length, string infoLog);

        [DllImport(Path, EntryPoint = "glBindImageTexture")]
        public static extern void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);

        [DllImport(Path, EntryPoint = "glGetBooleani_v")]
        public static extern void glGetBooleani_v(uint target, uint index, bool[] data);

        [DllImport(Path, EntryPoint = "glMemoryBarrier")]
        public static extern void glMemoryBarrier(uint barriers);

        [DllImport(Path, EntryPoint = "glMemoryBarrierByRegion")]
        public static extern void glMemoryBarrierByRegion(uint barriers);

        [DllImport(Path, EntryPoint = "glTexStorage2DMultisample")]
        public static extern void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

        [DllImport(Path, EntryPoint = "glGetMultisamplefv")]
        public static extern void glGetMultisamplefv(uint pname, uint index, float[] val);

        [DllImport(Path, EntryPoint = "glSampleMaski")]
        public static extern void glSampleMaski(uint maskNumber, uint mask);

        [DllImport(Path, EntryPoint = "glGetTexLevelParameteriv")]
        public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetTexLevelParameterfv")]
        public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);

        [DllImport(Path, EntryPoint = "glBindVertexBuffer")]
        public static extern void glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);

        [DllImport(Path, EntryPoint = "glVertexAttribFormat")]
        public static extern void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

        [DllImport(Path, EntryPoint = "glVertexAttribIFormat")]
        public static extern void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport(Path, EntryPoint = "glVertexAttribBinding")]
        public static extern void glVertexAttribBinding(uint attribindex, uint bindingindex);

        [DllImport(Path, EntryPoint = "glVertexBindingDivisor")]
        public static extern void glVertexBindingDivisor(uint bindingindex, uint divisor);

        #endregion

        #region GL_ES_VERSION_3_2
        public const uint GL_ES_VERSION_3_2 = 1;
        public const uint GL_MULTISAMPLE_LINE_WIDTH_RANGE = 0x9381;
        public const uint GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY = 0x9382;
        public const uint GL_MULTIPLY = 0x9294;
        public const uint GL_SCREEN = 0x9295;
        public const uint GL_OVERLAY = 0x9296;
        public const uint GL_DARKEN = 0x9297;
        public const uint GL_LIGHTEN = 0x9298;
        public const uint GL_COLORDODGE = 0x9299;
        public const uint GL_COLORBURN = 0x929A;
        public const uint GL_HARDLIGHT = 0x929B;
        public const uint GL_SOFTLIGHT = 0x929C;
        public const uint GL_DIFFERENCE = 0x929E;
        public const uint GL_EXCLUSION = 0x92A0;
        public const uint GL_HSL_HUE = 0x92AD;
        public const uint GL_HSL_SATURATION = 0x92AE;
        public const uint GL_HSL_COLOR = 0x92AF;
        public const uint GL_HSL_LUMINOSITY = 0x92B0;
        public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
        public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        public const uint GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
        public const uint GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
        public const uint GL_DEBUG_SOURCE_API = 0x8246;
        public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
        public const uint GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
        public const uint GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
        public const uint GL_DEBUG_SOURCE_APPLICATION = 0x824A;
        public const uint GL_DEBUG_SOURCE_OTHER = 0x824B;
        public const uint GL_DEBUG_TYPE_ERROR = 0x824C;
        public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
        public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
        public const uint GL_DEBUG_TYPE_PORTABILITY = 0x824F;
        public const uint GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
        public const uint GL_DEBUG_TYPE_OTHER = 0x8251;
        public const uint GL_DEBUG_TYPE_MARKER = 0x8268;
        public const uint GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
        public const uint GL_DEBUG_TYPE_POP_GROUP = 0x826A;
        public const uint GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
        public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
        public const uint GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
        public const uint GL_BUFFER = 0x82E0;
        public const uint GL_SHADER = 0x82E1;
        public const uint GL_PROGRAM = 0x82E2;
        public const uint GL_VERTEX_ARRAY = 0x8074;
        public const uint GL_QUERY = 0x82E3;
        public const uint GL_PROGRAM_PIPELINE = 0x82E4;
        public const uint GL_SAMPLER = 0x82E6;
        public const uint GL_MAX_LABEL_LENGTH = 0x82E8;
        public const uint GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
        public const uint GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
        public const uint GL_DEBUG_LOGGED_MESSAGES = 0x9145;
        public const uint GL_DEBUG_SEVERITY_HIGH = 0x9146;
        public const uint GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
        public const uint GL_DEBUG_SEVERITY_LOW = 0x9148;
        public const uint GL_DEBUG_OUTPUT = 0x92E0;
        public const uint GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
        public const uint GL_STACK_OVERFLOW = 0x0503;
        public const uint GL_STACK_UNDERFLOW = 0x0504;
        public const uint GL_GEOMETRY_SHADER = 0x8DD9;
        public const uint GL_GEOMETRY_SHADER_BIT = 0x00000004;
        public const uint GL_GEOMETRY_VERTICES_OUT = 0x8916;
        public const uint GL_GEOMETRY_INPUT_TYPE = 0x8917;
        public const uint GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
        public const uint GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        public const uint GL_LAYER_PROVOKING_VERTEX = 0x825E;
        public const uint GL_LINES_ADJACENCY = 0x000A;
        public const uint GL_LINE_STRIP_ADJACENCY = 0x000B;
        public const uint GL_TRIANGLES_ADJACENCY = 0x000C;
        public const uint GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
        public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
        public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
        public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
        public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
        public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        public const uint GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const uint GL_LAST_VERTEX_CONVENTION = 0x8E4E;
        public const uint GL_UNDEFINED_VERTEX = 0x8260;
        public const uint GL_PRIMITIVES_GENERATED = 0x8C87;
        public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
        public const uint GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
        public const uint GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
        public const uint GL_PRIMITIVE_BOUNDING_BOX = 0x92BE;
        public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
        public const uint GL_CONTEXT_FLAGS = 0x821E;
        public const uint GL_LOSE_CONTEXT_ON_RESET = 0x8252;
        public const uint GL_GUILTY_CONTEXT_RESET = 0x8253;
        public const uint GL_INNOCENT_CONTEXT_RESET = 0x8254;
        public const uint GL_UNKNOWN_CONTEXT_RESET = 0x8255;
        public const uint GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const uint GL_NO_RESET_NOTIFICATION = 0x8261;
        public const uint GL_CONTEXT_LOST = 0x0507;
        public const uint GL_SAMPLE_SHADING = 0x8C36;
        public const uint GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
        public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        public const uint GL_PATCHES = 0x000E;
        public const uint GL_PATCH_VERTICES = 0x8E72;
        public const uint GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        public const uint GL_TESS_GEN_MODE = 0x8E76;
        public const uint GL_TESS_GEN_SPACING = 0x8E77;
        public const uint GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
        public const uint GL_TESS_GEN_POINT_MODE = 0x8E79;
        public const uint GL_ISOLINES = 0x8E7A;
        public const uint GL_QUADS = 0x0007;
        public const uint GL_FRACTIONAL_ODD = 0x8E7B;
        public const uint GL_FRACTIONAL_EVEN = 0x8E7C;
        public const uint GL_MAX_PATCH_VERTICES = 0x8E7D;
        public const uint GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
        public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const uint GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
        public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
        public const uint GL_IS_PER_PATCH = 0x92E7;
        public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
        public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
        public const uint GL_TESS_CONTROL_SHADER = 0x8E88;
        public const uint GL_TESS_EVALUATION_SHADER = 0x8E87;
        public const uint GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
        public const uint GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
        public const uint GL_TEXTURE_BORDER_COLOR = 0x1004;
        public const uint GL_CLAMP_TO_BORDER = 0x812D;
        public const uint GL_TEXTURE_BUFFER = 0x8C2A;
        public const uint GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
        public const uint GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
        public const uint GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
        public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
        public const uint GL_SAMPLER_BUFFER = 0x8DC2;
        public const uint GL_INT_SAMPLER_BUFFER = 0x8DD0;
        public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
        public const uint GL_IMAGE_BUFFER = 0x9051;
        public const uint GL_INT_IMAGE_BUFFER = 0x905C;
        public const uint GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
        public const uint GL_TEXTURE_BUFFER_OFFSET = 0x919D;
        public const uint GL_TEXTURE_BUFFER_SIZE = 0x919E;
        public const uint GL_COMPRESSED_RGBA_ASTC_4x4 = 0x93B0;
        public const uint GL_COMPRESSED_RGBA_ASTC_5x4 = 0x93B1;
        public const uint GL_COMPRESSED_RGBA_ASTC_5x5 = 0x93B2;
        public const uint GL_COMPRESSED_RGBA_ASTC_6x5 = 0x93B3;
        public const uint GL_COMPRESSED_RGBA_ASTC_6x6 = 0x93B4;
        public const uint GL_COMPRESSED_RGBA_ASTC_8x5 = 0x93B5;
        public const uint GL_COMPRESSED_RGBA_ASTC_8x6 = 0x93B6;
        public const uint GL_COMPRESSED_RGBA_ASTC_8x8 = 0x93B7;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x5 = 0x93B8;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x6 = 0x93B9;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x8 = 0x93BA;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x10 = 0x93BB;
        public const uint GL_COMPRESSED_RGBA_ASTC_12x10 = 0x93BC;
        public const uint GL_COMPRESSED_RGBA_ASTC_12x12 = 0x93BD;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 = 0x93D0;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 = 0x93D1;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 = 0x93D2;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 = 0x93D3;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 = 0x93D4;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 = 0x93D5;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 = 0x93D6;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 = 0x93D7;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 = 0x93D8;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 = 0x93D9;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 = 0x93DA;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 = 0x93DB;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 = 0x93DC;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 = 0x93DD;
        public const uint GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        public const uint GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
        public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
        public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
        public const uint GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
        public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

        [DllImport(Path, EntryPoint = "glBlendBarrier")]
        public static extern void glBlendBarrier();

        [DllImport(Path, EntryPoint = "glCopyImageSubData")]
        public static extern void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight,
                int srcDepth);

        [DllImport(Path, EntryPoint = "glDebugMessageControl")]
        public static extern void glDebugMessageControl(uint source, uint type, uint severity, int count, uint ids, bool enabled);

        [DllImport(Path, EntryPoint = "glDebugMessageInsert")]
        public static extern void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string message);

        [DllImport(Path, EntryPoint = "glDebugMessageCallback")]
        public static extern void glDebugMessageCallback(IntPtr callback, IntPtr userParam);

        [DllImport(Path, EntryPoint = "glGetDebugMessageLog")]
        public static extern uint glGetDebugMessageLog(uint count, int bufSize, uint sources, uint types, uint ids, uint severities, int lengths, string messageLog);

        [DllImport(Path, EntryPoint = "glPushDebugGroup")]
        public static extern void glPushDebugGroup(uint source, uint id, int length, string message);

        [DllImport(Path, EntryPoint = "glPopDebugGroup")]
        public static extern void glPopDebugGroup();

        [DllImport(Path, EntryPoint = "glObjectLabel")]
        public static extern void glObjectLabel(uint identifier, uint name, int length, string label);

        [DllImport(Path, EntryPoint = "glGetObjectLabel")]
        public static extern void glGetObjectLabel(uint identifier, uint name, int bufSize, int length, string label);

        [DllImport(Path, EntryPoint = "glObjectPtrLabel")]
        public static extern void glObjectPtrLabel(IntPtr ptr, int length, string label);

        [DllImport(Path, EntryPoint = "glGetObjectPtrLabel")]
        public static extern void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int length, string label);

        [DllImport(Path, EntryPoint = "glGetPointerv")]
        public static extern void glGetPointerv(uint pname, IntPtr[] @params);

        [DllImport(Path, EntryPoint = "glEnablei")]
        public static extern void glEnablei(uint target, uint index);

        [DllImport(Path, EntryPoint = "glDisablei")]
        public static extern void glDisablei(uint target, uint index);

        [DllImport(Path, EntryPoint = "glBlendEquationi")]
        public static extern void glBlendEquationi(uint buf, uint mode);

        [DllImport(Path, EntryPoint = "glBlendEquationSeparatei")]
        public static extern void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);

        [DllImport(Path, EntryPoint = "glBlendFunci")]
        public static extern void glBlendFunci(uint buf, uint src, uint dst);

        [DllImport(Path, EntryPoint = "glBlendFuncSeparatei")]
        public static extern void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

        [DllImport(Path, EntryPoint = "glColorMaski")]
        public static extern void glColorMaski(uint index, bool r, bool g, bool b, bool a);

        [DllImport(Path, EntryPoint = "glIsEnabledi")]
        public static extern bool glIsEnabledi(uint target, uint index);

        [DllImport(Path, EntryPoint = "glDrawElementsBaseVertex")]
        public static extern void glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex);

        [DllImport(Path, EntryPoint = "glDrawRangeElementsBaseVertex")]
        public static extern void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);

        [DllImport(Path, EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public static extern void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);

        [DllImport(Path, EntryPoint = "glFramebufferTexture")]
        public static extern void glFramebufferTexture(uint target, uint attachment, uint texture, int level);

        [DllImport(Path, EntryPoint = "glPrimitiveBoundingBox")]
        public static extern void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

        [DllImport(Path, EntryPoint = "glGetGraphicsResetStatus")]
        public static extern uint glGetGraphicsResetStatus();

        [DllImport(Path, EntryPoint = "glReadnPixels")]
        public static extern void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);

        [DllImport(Path, EntryPoint = "glGetnUniformfv")]
        public static extern void glGetnUniformfv(uint program, int location, int bufSize, float[] @params);

        [DllImport(Path, EntryPoint = "glGetnUniformiv")]
        public static extern void glGetnUniformiv(uint program, int location, int bufSize, int[] @params);

        [DllImport(Path, EntryPoint = "glGetnUniformuiv")]
        public static extern void glGetnUniformuiv(uint program, int location, int bufSize, uint[] @params);

        [DllImport(Path, EntryPoint = "glMinSampleShading")]
        public static extern void glMinSampleShading(float value);

        [DllImport(Path, EntryPoint = "glPatchParameteri")]
        public static extern void glPatchParameteri(uint pname, int value);

        [DllImport(Path, EntryPoint = "glTexParameterIiv")]
        public static extern void glTexParameterIiv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glTexParameterIuiv")]
        public static extern void glTexParameterIuiv(uint target, uint pname, uint[] @params);

        [DllImport(Path, EntryPoint = "glGetTexParameterIiv")]
        public static extern void glGetTexParameterIiv(uint target, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetTexParameterIuiv")]
        public static extern void glGetTexParameterIuiv(uint target, uint pname, uint[] @params);

        [DllImport(Path, EntryPoint = "glSamplerParameterIiv")]
        public static extern void glSamplerParameterIiv(uint sampler, uint pname, int[] param);

        [DllImport(Path, EntryPoint = "glSamplerParameterIuiv")]
        public static extern void glSamplerParameterIuiv(uint sampler, uint pname, uint[] param);

        [DllImport(Path, EntryPoint = "glGetSamplerParameterIiv")]
        public static extern void glGetSamplerParameterIiv(uint sampler, uint pname, int[] @params);

        [DllImport(Path, EntryPoint = "glGetSamplerParameterIuiv")]
        public static extern void glGetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params);

        [DllImport(Path, EntryPoint = "glTexBuffer")]
        public static extern void glTexBuffer(uint target, uint internalformat, uint buffer);

        [DllImport(Path, EntryPoint = "glTexBufferRange")]
        public static extern void glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size);

        [DllImport(Path, EntryPoint = "glTexStorage3DMultisample")]
        public static extern void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
        #endregion

        #region Additional methods
        public static uint glGenBuffer()
        {
            var ids = new uint[1];
            glGenBuffers(1, ids);
            return ids[0];
        }

        public static uint glGenFramebuffer()
        {
            var ids = new uint[1];
            glGenFramebuffers(1, ids);
            return ids[0];
        }
        public static uint glGenRenderbuffer()
        {
            var ids = new uint[1];
            glGenRenderbuffers(1, ids);
            return ids[0];
        }

        public static uint glGenVertexArray()
        {
            var ids = new uint[1];
            glGenVertexArrays(1, ids);
            return ids[0];
        }

        public static uint glGenTexture()
        {
            var ids = new uint[1];
            glGenTextures(1, ids);
            return ids[0];
        }

        public static string glGetProgramInfoLog(uint program)
        {
            glGetProgramiv(program, GL_INFO_LOG_LENGTH, out int infoLogLength);
            var data = new byte[infoLogLength];
            glGetProgramInfoLog(program, infoLogLength, 0, data);
            return Encoding.ASCII.GetString(data);
        }

        public static string glGetShaderInfoLog(uint shader)
        {
            glGetShaderiv(shader, GL_INFO_LOG_LENGTH, out int infoLogLength);
            byte[] data = new byte[infoLogLength];
            glGetShaderInfoLog(shader, infoLogLength, 0, data);
            return Encoding.ASCII.GetString(data);
        }

        public static void glShaderSource(uint shader, string source)
        {
            glShaderSource(shader, 1, new string[] { source }, new int[] { source.Length });
        }

        public static void glUniformMatrix4fv(int location, Matrix4x4 mat)
        {
            var arr = new[]
            {
                mat.M11, mat.M12, mat.M13, mat.M14,
                mat.M21, mat.M22, mat.M23, mat.M24,
                mat.M31, mat.M32, mat.M33, mat.M34,
                mat.M41, mat.M42, mat.M43, mat.M44,
            };
            glUniformMatrix4fv(location, 1, false, arr);
        }

        public static void glGetIntegerv(uint pname, out int data)
        {
            int[] d = new int[1];
            glGetIntegerv(pname, d);
            data = d[0];
        }

        public static void glDeleteBuffer(uint id)
        {
            uint[] d = new uint[1] { id };
            glDeleteBuffers(1, d);
        }
        #endregion

        //public static void glBufferData(BufferKind kind, int size, IntPtr dataPtr, BufferUsage usage) => glBufferData((uint)kind, size, dataPtr, (uint)usage);

        //public static void glBufferSubData(BufferKind kind, int offset, int size, IntPtr dataPtr) => glBufferSubData((uint)kind, offset, size, dataPtr);

        //public static void glBindBuffer(BufferKind kind, uint buffer) => glBindBuffer((uint)kind, buffer);
        public static void glUniform3f(int location, Vector3 v) => glUniform3f(location, v.X, v.Y, v.Z);
    }
}