//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//



namespace OpenTK.Graphics.ES30
{
    using System;
    using System.Security;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {
        public GL()
        {
            IGraphicsContextInternal context = GraphicsContext.CurrentContext as IGraphicsContextInternal;
            if (context == null) throw new GraphicsContextMissingException();

            Delegates.glActiveProgramEXT = (Delegates.ActiveProgramEXT)GetExtensionDelegate("glActiveProgramEXT", typeof(Delegates.ActiveProgramEXT));
            Delegates.glActiveShaderProgramEXT = (Delegates.ActiveShaderProgramEXT)GetExtensionDelegate("glActiveShaderProgramEXT", typeof(Delegates.ActiveShaderProgramEXT));
            Delegates.glActiveTexture = (Delegates.ActiveTexture)GetExtensionDelegate("glActiveTexture", typeof(Delegates.ActiveTexture));
            Delegates.glAlphaFuncQCOM = (Delegates.AlphaFuncQCOM)GetExtensionDelegate("glAlphaFuncQCOM", typeof(Delegates.AlphaFuncQCOM));
            Delegates.glAttachShader = (Delegates.AttachShader)GetExtensionDelegate("glAttachShader", typeof(Delegates.AttachShader));
            Delegates.glBeginPerfMonitorAMD = (Delegates.BeginPerfMonitorAMD)GetExtensionDelegate("glBeginPerfMonitorAMD", typeof(Delegates.BeginPerfMonitorAMD));
            Delegates.glBeginQuery = (Delegates.BeginQuery)GetExtensionDelegate("glBeginQuery", typeof(Delegates.BeginQuery));
            Delegates.glBeginQueryEXT = (Delegates.BeginQueryEXT)GetExtensionDelegate("glBeginQueryEXT", typeof(Delegates.BeginQueryEXT));
            Delegates.glBeginTransformFeedback = (Delegates.BeginTransformFeedback)GetExtensionDelegate("glBeginTransformFeedback", typeof(Delegates.BeginTransformFeedback));
            Delegates.glBindAttribLocation = (Delegates.BindAttribLocation)GetExtensionDelegate("glBindAttribLocation", typeof(Delegates.BindAttribLocation));
            Delegates.glBindBuffer = (Delegates.BindBuffer)GetExtensionDelegate("glBindBuffer", typeof(Delegates.BindBuffer));
            Delegates.glBindBufferBase = (Delegates.BindBufferBase)GetExtensionDelegate("glBindBufferBase", typeof(Delegates.BindBufferBase));
            Delegates.glBindBufferRange = (Delegates.BindBufferRange)GetExtensionDelegate("glBindBufferRange", typeof(Delegates.BindBufferRange));
            Delegates.glBindFramebuffer = (Delegates.BindFramebuffer)GetExtensionDelegate("glBindFramebuffer", typeof(Delegates.BindFramebuffer));
            Delegates.glBindProgramPipelineEXT = (Delegates.BindProgramPipelineEXT)GetExtensionDelegate("glBindProgramPipelineEXT", typeof(Delegates.BindProgramPipelineEXT));
            Delegates.glBindRenderbuffer = (Delegates.BindRenderbuffer)GetExtensionDelegate("glBindRenderbuffer", typeof(Delegates.BindRenderbuffer));
            Delegates.glBindSampler = (Delegates.BindSampler)GetExtensionDelegate("glBindSampler", typeof(Delegates.BindSampler));
            Delegates.glBindTexture = (Delegates.BindTexture)GetExtensionDelegate("glBindTexture", typeof(Delegates.BindTexture));
            Delegates.glBindTransformFeedback = (Delegates.BindTransformFeedback)GetExtensionDelegate("glBindTransformFeedback", typeof(Delegates.BindTransformFeedback));
            Delegates.glBindVertexArray = (Delegates.BindVertexArray)GetExtensionDelegate("glBindVertexArray", typeof(Delegates.BindVertexArray));
            Delegates.glBindVertexArrayOES = (Delegates.BindVertexArrayOES)GetExtensionDelegate("glBindVertexArrayOES", typeof(Delegates.BindVertexArrayOES));
            Delegates.glBlendBarrierNV = (Delegates.BlendBarrierNV)GetExtensionDelegate("glBlendBarrierNV", typeof(Delegates.BlendBarrierNV));
            Delegates.glBlendColor = (Delegates.BlendColor)GetExtensionDelegate("glBlendColor", typeof(Delegates.BlendColor));
            Delegates.glBlendEquation = (Delegates.BlendEquation)GetExtensionDelegate("glBlendEquation", typeof(Delegates.BlendEquation));
            Delegates.glBlendEquationEXT = (Delegates.BlendEquationEXT)GetExtensionDelegate("glBlendEquationEXT", typeof(Delegates.BlendEquationEXT));
            Delegates.glBlendEquationSeparate = (Delegates.BlendEquationSeparate)GetExtensionDelegate("glBlendEquationSeparate", typeof(Delegates.BlendEquationSeparate));
            Delegates.glBlendFunc = (Delegates.BlendFunc)GetExtensionDelegate("glBlendFunc", typeof(Delegates.BlendFunc));
            Delegates.glBlendFuncSeparate = (Delegates.BlendFuncSeparate)GetExtensionDelegate("glBlendFuncSeparate", typeof(Delegates.BlendFuncSeparate));
            Delegates.glBlendParameteriNV = (Delegates.BlendParameteriNV)GetExtensionDelegate("glBlendParameteriNV", typeof(Delegates.BlendParameteriNV));
            Delegates.glBlitFramebuffer = (Delegates.BlitFramebuffer)GetExtensionDelegate("glBlitFramebuffer", typeof(Delegates.BlitFramebuffer));
            Delegates.glBlitFramebufferANGLE = (Delegates.BlitFramebufferANGLE)GetExtensionDelegate("glBlitFramebufferANGLE", typeof(Delegates.BlitFramebufferANGLE));
            Delegates.glBlitFramebufferNV = (Delegates.BlitFramebufferNV)GetExtensionDelegate("glBlitFramebufferNV", typeof(Delegates.BlitFramebufferNV));
            Delegates.glBufferData = (Delegates.BufferData)GetExtensionDelegate("glBufferData", typeof(Delegates.BufferData));
            Delegates.glBufferSubData = (Delegates.BufferSubData)GetExtensionDelegate("glBufferSubData", typeof(Delegates.BufferSubData));
            Delegates.glCheckFramebufferStatus = (Delegates.CheckFramebufferStatus)GetExtensionDelegate("glCheckFramebufferStatus", typeof(Delegates.CheckFramebufferStatus));
            Delegates.glClear = (Delegates.Clear)GetExtensionDelegate("glClear", typeof(Delegates.Clear));
            Delegates.glClearBufferfi = (Delegates.ClearBufferfi)GetExtensionDelegate("glClearBufferfi", typeof(Delegates.ClearBufferfi));
            Delegates.glClearBufferfv = (Delegates.ClearBufferfv)GetExtensionDelegate("glClearBufferfv", typeof(Delegates.ClearBufferfv));
            Delegates.glClearBufferiv = (Delegates.ClearBufferiv)GetExtensionDelegate("glClearBufferiv", typeof(Delegates.ClearBufferiv));
            Delegates.glClearBufferuiv = (Delegates.ClearBufferuiv)GetExtensionDelegate("glClearBufferuiv", typeof(Delegates.ClearBufferuiv));
            Delegates.glClearColor = (Delegates.ClearColor)GetExtensionDelegate("glClearColor", typeof(Delegates.ClearColor));
            Delegates.glClearDepthf = (Delegates.ClearDepthf)GetExtensionDelegate("glClearDepthf", typeof(Delegates.ClearDepthf));
            Delegates.glClearStencil = (Delegates.ClearStencil)GetExtensionDelegate("glClearStencil", typeof(Delegates.ClearStencil));
            Delegates.glClientWaitSync = (Delegates.ClientWaitSync)GetExtensionDelegate("glClientWaitSync", typeof(Delegates.ClientWaitSync));
            Delegates.glClientWaitSyncAPPLE = (Delegates.ClientWaitSyncAPPLE)GetExtensionDelegate("glClientWaitSyncAPPLE", typeof(Delegates.ClientWaitSyncAPPLE));
            Delegates.glColorMask = (Delegates.ColorMask)GetExtensionDelegate("glColorMask", typeof(Delegates.ColorMask));
            Delegates.glCompileShader = (Delegates.CompileShader)GetExtensionDelegate("glCompileShader", typeof(Delegates.CompileShader));
            Delegates.glCompressedTexImage2D = (Delegates.CompressedTexImage2D)GetExtensionDelegate("glCompressedTexImage2D", typeof(Delegates.CompressedTexImage2D));
            Delegates.glCompressedTexImage3D = (Delegates.CompressedTexImage3D)GetExtensionDelegate("glCompressedTexImage3D", typeof(Delegates.CompressedTexImage3D));
            Delegates.glCompressedTexImage3DOES = (Delegates.CompressedTexImage3DOES)GetExtensionDelegate("glCompressedTexImage3DOES", typeof(Delegates.CompressedTexImage3DOES));
            Delegates.glCompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)GetExtensionDelegate("glCompressedTexSubImage2D", typeof(Delegates.CompressedTexSubImage2D));
            Delegates.glCompressedTexSubImage3D = (Delegates.CompressedTexSubImage3D)GetExtensionDelegate("glCompressedTexSubImage3D", typeof(Delegates.CompressedTexSubImage3D));
            Delegates.glCompressedTexSubImage3DOES = (Delegates.CompressedTexSubImage3DOES)GetExtensionDelegate("glCompressedTexSubImage3DOES", typeof(Delegates.CompressedTexSubImage3DOES));
            Delegates.glCopyBufferSubData = (Delegates.CopyBufferSubData)GetExtensionDelegate("glCopyBufferSubData", typeof(Delegates.CopyBufferSubData));
            Delegates.glCopyBufferSubDataNV = (Delegates.CopyBufferSubDataNV)GetExtensionDelegate("glCopyBufferSubDataNV", typeof(Delegates.CopyBufferSubDataNV));
            Delegates.glCopyTexImage2D = (Delegates.CopyTexImage2D)GetExtensionDelegate("glCopyTexImage2D", typeof(Delegates.CopyTexImage2D));
            Delegates.glCopyTexSubImage2D = (Delegates.CopyTexSubImage2D)GetExtensionDelegate("glCopyTexSubImage2D", typeof(Delegates.CopyTexSubImage2D));
            Delegates.glCopyTexSubImage3D = (Delegates.CopyTexSubImage3D)GetExtensionDelegate("glCopyTexSubImage3D", typeof(Delegates.CopyTexSubImage3D));
            Delegates.glCopyTexSubImage3DOES = (Delegates.CopyTexSubImage3DOES)GetExtensionDelegate("glCopyTexSubImage3DOES", typeof(Delegates.CopyTexSubImage3DOES));
            Delegates.glCopyTextureLevelsAPPLE = (Delegates.CopyTextureLevelsAPPLE)GetExtensionDelegate("glCopyTextureLevelsAPPLE", typeof(Delegates.CopyTextureLevelsAPPLE));
            Delegates.glCoverageMaskNV = (Delegates.CoverageMaskNV)GetExtensionDelegate("glCoverageMaskNV", typeof(Delegates.CoverageMaskNV));
            Delegates.glCoverageOperationNV = (Delegates.CoverageOperationNV)GetExtensionDelegate("glCoverageOperationNV", typeof(Delegates.CoverageOperationNV));
            Delegates.glCreateProgram = (Delegates.CreateProgram)GetExtensionDelegate("glCreateProgram", typeof(Delegates.CreateProgram));
            Delegates.glCreateShader = (Delegates.CreateShader)GetExtensionDelegate("glCreateShader", typeof(Delegates.CreateShader));
            Delegates.glCreateShaderProgramEXT = (Delegates.CreateShaderProgramEXT)GetExtensionDelegate("glCreateShaderProgramEXT", typeof(Delegates.CreateShaderProgramEXT));
            Delegates.glCreateShaderProgramvEXT = (Delegates.CreateShaderProgramvEXT)GetExtensionDelegate("glCreateShaderProgramvEXT", typeof(Delegates.CreateShaderProgramvEXT));
            Delegates.glCullFace = (Delegates.CullFace)GetExtensionDelegate("glCullFace", typeof(Delegates.CullFace));
            Delegates.glDebugMessageCallback = (Delegates.DebugMessageCallback)GetExtensionDelegate("glDebugMessageCallback", typeof(Delegates.DebugMessageCallback));
            Delegates.glDebugMessageCallbackKHR = (Delegates.DebugMessageCallbackKHR)GetExtensionDelegate("glDebugMessageCallbackKHR", typeof(Delegates.DebugMessageCallbackKHR));
            Delegates.glDebugMessageControl = (Delegates.DebugMessageControl)GetExtensionDelegate("glDebugMessageControl", typeof(Delegates.DebugMessageControl));
            Delegates.glDebugMessageControlKHR = (Delegates.DebugMessageControlKHR)GetExtensionDelegate("glDebugMessageControlKHR", typeof(Delegates.DebugMessageControlKHR));
            Delegates.glDebugMessageInsert = (Delegates.DebugMessageInsert)GetExtensionDelegate("glDebugMessageInsert", typeof(Delegates.DebugMessageInsert));
            Delegates.glDebugMessageInsertKHR = (Delegates.DebugMessageInsertKHR)GetExtensionDelegate("glDebugMessageInsertKHR", typeof(Delegates.DebugMessageInsertKHR));
            Delegates.glDeleteBuffers = (Delegates.DeleteBuffers)GetExtensionDelegate("glDeleteBuffers", typeof(Delegates.DeleteBuffers));
            Delegates.glDeleteFencesNV = (Delegates.DeleteFencesNV)GetExtensionDelegate("glDeleteFencesNV", typeof(Delegates.DeleteFencesNV));
            Delegates.glDeleteFramebuffers = (Delegates.DeleteFramebuffers)GetExtensionDelegate("glDeleteFramebuffers", typeof(Delegates.DeleteFramebuffers));
            Delegates.glDeletePerfMonitorsAMD = (Delegates.DeletePerfMonitorsAMD)GetExtensionDelegate("glDeletePerfMonitorsAMD", typeof(Delegates.DeletePerfMonitorsAMD));
            Delegates.glDeleteProgram = (Delegates.DeleteProgram)GetExtensionDelegate("glDeleteProgram", typeof(Delegates.DeleteProgram));
            Delegates.glDeleteProgramPipelinesEXT = (Delegates.DeleteProgramPipelinesEXT)GetExtensionDelegate("glDeleteProgramPipelinesEXT", typeof(Delegates.DeleteProgramPipelinesEXT));
            Delegates.glDeleteQueries = (Delegates.DeleteQueries)GetExtensionDelegate("glDeleteQueries", typeof(Delegates.DeleteQueries));
            Delegates.glDeleteQueriesEXT = (Delegates.DeleteQueriesEXT)GetExtensionDelegate("glDeleteQueriesEXT", typeof(Delegates.DeleteQueriesEXT));
            Delegates.glDeleteRenderbuffers = (Delegates.DeleteRenderbuffers)GetExtensionDelegate("glDeleteRenderbuffers", typeof(Delegates.DeleteRenderbuffers));
            Delegates.glDeleteSamplers = (Delegates.DeleteSamplers)GetExtensionDelegate("glDeleteSamplers", typeof(Delegates.DeleteSamplers));
            Delegates.glDeleteShader = (Delegates.DeleteShader)GetExtensionDelegate("glDeleteShader", typeof(Delegates.DeleteShader));
            Delegates.glDeleteSync = (Delegates.DeleteSync)GetExtensionDelegate("glDeleteSync", typeof(Delegates.DeleteSync));
            Delegates.glDeleteSyncAPPLE = (Delegates.DeleteSyncAPPLE)GetExtensionDelegate("glDeleteSyncAPPLE", typeof(Delegates.DeleteSyncAPPLE));
            Delegates.glDeleteTextures = (Delegates.DeleteTextures)GetExtensionDelegate("glDeleteTextures", typeof(Delegates.DeleteTextures));
            Delegates.glDeleteTransformFeedbacks = (Delegates.DeleteTransformFeedbacks)GetExtensionDelegate("glDeleteTransformFeedbacks", typeof(Delegates.DeleteTransformFeedbacks));
            Delegates.glDeleteVertexArrays = (Delegates.DeleteVertexArrays)GetExtensionDelegate("glDeleteVertexArrays", typeof(Delegates.DeleteVertexArrays));
            Delegates.glDeleteVertexArraysOES = (Delegates.DeleteVertexArraysOES)GetExtensionDelegate("glDeleteVertexArraysOES", typeof(Delegates.DeleteVertexArraysOES));
            Delegates.glDepthFunc = (Delegates.DepthFunc)GetExtensionDelegate("glDepthFunc", typeof(Delegates.DepthFunc));
            Delegates.glDepthMask = (Delegates.DepthMask)GetExtensionDelegate("glDepthMask", typeof(Delegates.DepthMask));
            Delegates.glDepthRangef = (Delegates.DepthRangef)GetExtensionDelegate("glDepthRangef", typeof(Delegates.DepthRangef));
            Delegates.glDetachShader = (Delegates.DetachShader)GetExtensionDelegate("glDetachShader", typeof(Delegates.DetachShader));
            Delegates.glDisable = (Delegates.Disable)GetExtensionDelegate("glDisable", typeof(Delegates.Disable));
            Delegates.glDisableDriverControlQCOM = (Delegates.DisableDriverControlQCOM)GetExtensionDelegate("glDisableDriverControlQCOM", typeof(Delegates.DisableDriverControlQCOM));
            Delegates.glDisableVertexAttribArray = (Delegates.DisableVertexAttribArray)GetExtensionDelegate("glDisableVertexAttribArray", typeof(Delegates.DisableVertexAttribArray));
            Delegates.glDiscardFramebufferEXT = (Delegates.DiscardFramebufferEXT)GetExtensionDelegate("glDiscardFramebufferEXT", typeof(Delegates.DiscardFramebufferEXT));
            Delegates.glDrawArrays = (Delegates.DrawArrays)GetExtensionDelegate("glDrawArrays", typeof(Delegates.DrawArrays));
            Delegates.glDrawArraysInstanced = (Delegates.DrawArraysInstanced)GetExtensionDelegate("glDrawArraysInstanced", typeof(Delegates.DrawArraysInstanced));
            Delegates.glDrawArraysInstancedANGLE = (Delegates.DrawArraysInstancedANGLE)GetExtensionDelegate("glDrawArraysInstancedANGLE", typeof(Delegates.DrawArraysInstancedANGLE));
            Delegates.glDrawArraysInstancedEXT = (Delegates.DrawArraysInstancedEXT)GetExtensionDelegate("glDrawArraysInstancedEXT", typeof(Delegates.DrawArraysInstancedEXT));
            Delegates.glDrawArraysInstancedNV = (Delegates.DrawArraysInstancedNV)GetExtensionDelegate("glDrawArraysInstancedNV", typeof(Delegates.DrawArraysInstancedNV));
            Delegates.glDrawBuffers = (Delegates.DrawBuffers)GetExtensionDelegate("glDrawBuffers", typeof(Delegates.DrawBuffers));
            Delegates.glDrawBuffersEXT = (Delegates.DrawBuffersEXT)GetExtensionDelegate("glDrawBuffersEXT", typeof(Delegates.DrawBuffersEXT));
            Delegates.glDrawBuffersIndexedEXT = (Delegates.DrawBuffersIndexedEXT)GetExtensionDelegate("glDrawBuffersIndexedEXT", typeof(Delegates.DrawBuffersIndexedEXT));
            Delegates.glDrawBuffersNV = (Delegates.DrawBuffersNV)GetExtensionDelegate("glDrawBuffersNV", typeof(Delegates.DrawBuffersNV));
            Delegates.glDrawElements = (Delegates.DrawElements)GetExtensionDelegate("glDrawElements", typeof(Delegates.DrawElements));
            Delegates.glDrawElementsInstanced = (Delegates.DrawElementsInstanced)GetExtensionDelegate("glDrawElementsInstanced", typeof(Delegates.DrawElementsInstanced));
            Delegates.glDrawElementsInstancedANGLE = (Delegates.DrawElementsInstancedANGLE)GetExtensionDelegate("glDrawElementsInstancedANGLE", typeof(Delegates.DrawElementsInstancedANGLE));
            Delegates.glDrawElementsInstancedEXT = (Delegates.DrawElementsInstancedEXT)GetExtensionDelegate("glDrawElementsInstancedEXT", typeof(Delegates.DrawElementsInstancedEXT));
            Delegates.glDrawElementsInstancedNV = (Delegates.DrawElementsInstancedNV)GetExtensionDelegate("glDrawElementsInstancedNV", typeof(Delegates.DrawElementsInstancedNV));
            Delegates.glDrawRangeElements = (Delegates.DrawRangeElements)GetExtensionDelegate("glDrawRangeElements", typeof(Delegates.DrawRangeElements));
            Delegates.glEGLImageTargetRenderbufferStorageOES = (Delegates.EGLImageTargetRenderbufferStorageOES)GetExtensionDelegate("glEGLImageTargetRenderbufferStorageOES", typeof(Delegates.EGLImageTargetRenderbufferStorageOES));
            Delegates.glEGLImageTargetTexture2DOES = (Delegates.EGLImageTargetTexture2DOES)GetExtensionDelegate("glEGLImageTargetTexture2DOES", typeof(Delegates.EGLImageTargetTexture2DOES));
            Delegates.glEnable = (Delegates.Enable)GetExtensionDelegate("glEnable", typeof(Delegates.Enable));
            Delegates.glEnableDriverControlQCOM = (Delegates.EnableDriverControlQCOM)GetExtensionDelegate("glEnableDriverControlQCOM", typeof(Delegates.EnableDriverControlQCOM));
            Delegates.glEnableVertexAttribArray = (Delegates.EnableVertexAttribArray)GetExtensionDelegate("glEnableVertexAttribArray", typeof(Delegates.EnableVertexAttribArray));
            Delegates.glEndPerfMonitorAMD = (Delegates.EndPerfMonitorAMD)GetExtensionDelegate("glEndPerfMonitorAMD", typeof(Delegates.EndPerfMonitorAMD));
            Delegates.glEndQuery = (Delegates.EndQuery)GetExtensionDelegate("glEndQuery", typeof(Delegates.EndQuery));
            Delegates.glEndQueryEXT = (Delegates.EndQueryEXT)GetExtensionDelegate("glEndQueryEXT", typeof(Delegates.EndQueryEXT));
            Delegates.glEndTilingQCOM = (Delegates.EndTilingQCOM)GetExtensionDelegate("glEndTilingQCOM", typeof(Delegates.EndTilingQCOM));
            Delegates.glEndTransformFeedback = (Delegates.EndTransformFeedback)GetExtensionDelegate("glEndTransformFeedback", typeof(Delegates.EndTransformFeedback));
            Delegates.glExtGetBufferPointervQCOM = (Delegates.ExtGetBufferPointervQCOM)GetExtensionDelegate("glExtGetBufferPointervQCOM", typeof(Delegates.ExtGetBufferPointervQCOM));
            Delegates.glExtGetBuffersQCOM = (Delegates.ExtGetBuffersQCOM)GetExtensionDelegate("glExtGetBuffersQCOM", typeof(Delegates.ExtGetBuffersQCOM));
            Delegates.glExtGetFramebuffersQCOM = (Delegates.ExtGetFramebuffersQCOM)GetExtensionDelegate("glExtGetFramebuffersQCOM", typeof(Delegates.ExtGetFramebuffersQCOM));
            Delegates.glExtGetProgramBinarySourceQCOM = (Delegates.ExtGetProgramBinarySourceQCOM)GetExtensionDelegate("glExtGetProgramBinarySourceQCOM", typeof(Delegates.ExtGetProgramBinarySourceQCOM));
            Delegates.glExtGetProgramsQCOM = (Delegates.ExtGetProgramsQCOM)GetExtensionDelegate("glExtGetProgramsQCOM", typeof(Delegates.ExtGetProgramsQCOM));
            Delegates.glExtGetRenderbuffersQCOM = (Delegates.ExtGetRenderbuffersQCOM)GetExtensionDelegate("glExtGetRenderbuffersQCOM", typeof(Delegates.ExtGetRenderbuffersQCOM));
            Delegates.glExtGetShadersQCOM = (Delegates.ExtGetShadersQCOM)GetExtensionDelegate("glExtGetShadersQCOM", typeof(Delegates.ExtGetShadersQCOM));
            Delegates.glExtGetTexLevelParameterivQCOM = (Delegates.ExtGetTexLevelParameterivQCOM)GetExtensionDelegate("glExtGetTexLevelParameterivQCOM", typeof(Delegates.ExtGetTexLevelParameterivQCOM));
            Delegates.glExtGetTexSubImageQCOM = (Delegates.ExtGetTexSubImageQCOM)GetExtensionDelegate("glExtGetTexSubImageQCOM", typeof(Delegates.ExtGetTexSubImageQCOM));
            Delegates.glExtGetTexturesQCOM = (Delegates.ExtGetTexturesQCOM)GetExtensionDelegate("glExtGetTexturesQCOM", typeof(Delegates.ExtGetTexturesQCOM));
            Delegates.glExtIsProgramBinaryQCOM = (Delegates.ExtIsProgramBinaryQCOM)GetExtensionDelegate("glExtIsProgramBinaryQCOM", typeof(Delegates.ExtIsProgramBinaryQCOM));
            Delegates.glExtTexObjectStateOverrideiQCOM = (Delegates.ExtTexObjectStateOverrideiQCOM)GetExtensionDelegate("glExtTexObjectStateOverrideiQCOM", typeof(Delegates.ExtTexObjectStateOverrideiQCOM));
            Delegates.glFenceSync = (Delegates.FenceSync)GetExtensionDelegate("glFenceSync", typeof(Delegates.FenceSync));
            Delegates.glFenceSyncAPPLE = (Delegates.FenceSyncAPPLE)GetExtensionDelegate("glFenceSyncAPPLE", typeof(Delegates.FenceSyncAPPLE));
            Delegates.glFinish = (Delegates.Finish)GetExtensionDelegate("glFinish", typeof(Delegates.Finish));
            Delegates.glFinishFenceNV = (Delegates.FinishFenceNV)GetExtensionDelegate("glFinishFenceNV", typeof(Delegates.FinishFenceNV));
            Delegates.glFlush = (Delegates.Flush)GetExtensionDelegate("glFlush", typeof(Delegates.Flush));
            Delegates.glFlushMappedBufferRange = (Delegates.FlushMappedBufferRange)GetExtensionDelegate("glFlushMappedBufferRange", typeof(Delegates.FlushMappedBufferRange));
            Delegates.glFlushMappedBufferRangeEXT = (Delegates.FlushMappedBufferRangeEXT)GetExtensionDelegate("glFlushMappedBufferRangeEXT", typeof(Delegates.FlushMappedBufferRangeEXT));
            Delegates.glFramebufferRenderbuffer = (Delegates.FramebufferRenderbuffer)GetExtensionDelegate("glFramebufferRenderbuffer", typeof(Delegates.FramebufferRenderbuffer));
            Delegates.glFramebufferTexture2D = (Delegates.FramebufferTexture2D)GetExtensionDelegate("glFramebufferTexture2D", typeof(Delegates.FramebufferTexture2D));
            Delegates.glFramebufferTexture2DMultisampleEXT = (Delegates.FramebufferTexture2DMultisampleEXT)GetExtensionDelegate("glFramebufferTexture2DMultisampleEXT", typeof(Delegates.FramebufferTexture2DMultisampleEXT));
            Delegates.glFramebufferTexture2DMultisampleIMG = (Delegates.FramebufferTexture2DMultisampleIMG)GetExtensionDelegate("glFramebufferTexture2DMultisampleIMG", typeof(Delegates.FramebufferTexture2DMultisampleIMG));
            Delegates.glFramebufferTexture3DOES = (Delegates.FramebufferTexture3DOES)GetExtensionDelegate("glFramebufferTexture3DOES", typeof(Delegates.FramebufferTexture3DOES));
            Delegates.glFramebufferTextureLayer = (Delegates.FramebufferTextureLayer)GetExtensionDelegate("glFramebufferTextureLayer", typeof(Delegates.FramebufferTextureLayer));
            Delegates.glFrontFace = (Delegates.FrontFace)GetExtensionDelegate("glFrontFace", typeof(Delegates.FrontFace));
            Delegates.glGenBuffers = (Delegates.GenBuffers)GetExtensionDelegate("glGenBuffers", typeof(Delegates.GenBuffers));
            Delegates.glGenerateMipmap = (Delegates.GenerateMipmap)GetExtensionDelegate("glGenerateMipmap", typeof(Delegates.GenerateMipmap));
            Delegates.glGenFencesNV = (Delegates.GenFencesNV)GetExtensionDelegate("glGenFencesNV", typeof(Delegates.GenFencesNV));
            Delegates.glGenFramebuffers = (Delegates.GenFramebuffers)GetExtensionDelegate("glGenFramebuffers", typeof(Delegates.GenFramebuffers));
            Delegates.glGenPerfMonitorsAMD = (Delegates.GenPerfMonitorsAMD)GetExtensionDelegate("glGenPerfMonitorsAMD", typeof(Delegates.GenPerfMonitorsAMD));
            Delegates.glGenProgramPipelinesEXT = (Delegates.GenProgramPipelinesEXT)GetExtensionDelegate("glGenProgramPipelinesEXT", typeof(Delegates.GenProgramPipelinesEXT));
            Delegates.glGenQueries = (Delegates.GenQueries)GetExtensionDelegate("glGenQueries", typeof(Delegates.GenQueries));
            Delegates.glGenQueriesEXT = (Delegates.GenQueriesEXT)GetExtensionDelegate("glGenQueriesEXT", typeof(Delegates.GenQueriesEXT));
            Delegates.glGenRenderbuffers = (Delegates.GenRenderbuffers)GetExtensionDelegate("glGenRenderbuffers", typeof(Delegates.GenRenderbuffers));
            Delegates.glGenSamplers = (Delegates.GenSamplers)GetExtensionDelegate("glGenSamplers", typeof(Delegates.GenSamplers));
            Delegates.glGenTextures = (Delegates.GenTextures)GetExtensionDelegate("glGenTextures", typeof(Delegates.GenTextures));
            Delegates.glGenTransformFeedbacks = (Delegates.GenTransformFeedbacks)GetExtensionDelegate("glGenTransformFeedbacks", typeof(Delegates.GenTransformFeedbacks));
            Delegates.glGenVertexArrays = (Delegates.GenVertexArrays)GetExtensionDelegate("glGenVertexArrays", typeof(Delegates.GenVertexArrays));
            Delegates.glGenVertexArraysOES = (Delegates.GenVertexArraysOES)GetExtensionDelegate("glGenVertexArraysOES", typeof(Delegates.GenVertexArraysOES));
            Delegates.glGetActiveAttrib = (Delegates.GetActiveAttrib)GetExtensionDelegate("glGetActiveAttrib", typeof(Delegates.GetActiveAttrib));
            Delegates.glGetActiveUniform = (Delegates.GetActiveUniform)GetExtensionDelegate("glGetActiveUniform", typeof(Delegates.GetActiveUniform));
            Delegates.glGetActiveUniformBlockiv = (Delegates.GetActiveUniformBlockiv)GetExtensionDelegate("glGetActiveUniformBlockiv", typeof(Delegates.GetActiveUniformBlockiv));
            Delegates.glGetActiveUniformBlockName = (Delegates.GetActiveUniformBlockName)GetExtensionDelegate("glGetActiveUniformBlockName", typeof(Delegates.GetActiveUniformBlockName));
            Delegates.glGetActiveUniformsiv = (Delegates.GetActiveUniformsiv)GetExtensionDelegate("glGetActiveUniformsiv", typeof(Delegates.GetActiveUniformsiv));
            Delegates.glGetAttachedShaders = (Delegates.GetAttachedShaders)GetExtensionDelegate("glGetAttachedShaders", typeof(Delegates.GetAttachedShaders));
            Delegates.glGetAttribLocation = (Delegates.GetAttribLocation)GetExtensionDelegate("glGetAttribLocation", typeof(Delegates.GetAttribLocation));
            Delegates.glGetBooleanv = (Delegates.GetBooleanv)GetExtensionDelegate("glGetBooleanv", typeof(Delegates.GetBooleanv));
            Delegates.glGetBufferParameteri64v = (Delegates.GetBufferParameteri64v)GetExtensionDelegate("glGetBufferParameteri64v", typeof(Delegates.GetBufferParameteri64v));
            Delegates.glGetBufferParameteriv = (Delegates.GetBufferParameteriv)GetExtensionDelegate("glGetBufferParameteriv", typeof(Delegates.GetBufferParameteriv));
            Delegates.glGetBufferPointerv = (Delegates.GetBufferPointerv)GetExtensionDelegate("glGetBufferPointerv", typeof(Delegates.GetBufferPointerv));
            Delegates.glGetBufferPointervOES = (Delegates.GetBufferPointervOES)GetExtensionDelegate("glGetBufferPointervOES", typeof(Delegates.GetBufferPointervOES));
            Delegates.glGetDebugMessageLog = (Delegates.GetDebugMessageLog)GetExtensionDelegate("glGetDebugMessageLog", typeof(Delegates.GetDebugMessageLog));
            Delegates.glGetDebugMessageLogKHR = (Delegates.GetDebugMessageLogKHR)GetExtensionDelegate("glGetDebugMessageLogKHR", typeof(Delegates.GetDebugMessageLogKHR));
            Delegates.glGetDriverControlsQCOM = (Delegates.GetDriverControlsQCOM)GetExtensionDelegate("glGetDriverControlsQCOM", typeof(Delegates.GetDriverControlsQCOM));
            Delegates.glGetDriverControlStringQCOM = (Delegates.GetDriverControlStringQCOM)GetExtensionDelegate("glGetDriverControlStringQCOM", typeof(Delegates.GetDriverControlStringQCOM));
            Delegates.glGetError = (Delegates.GetError)GetExtensionDelegate("glGetError", typeof(Delegates.GetError));
            Delegates.glGetFenceivNV = (Delegates.GetFenceivNV)GetExtensionDelegate("glGetFenceivNV", typeof(Delegates.GetFenceivNV));
            Delegates.glGetFloatv = (Delegates.GetFloatv)GetExtensionDelegate("glGetFloatv", typeof(Delegates.GetFloatv));
            Delegates.glGetFragDataLocation = (Delegates.GetFragDataLocation)GetExtensionDelegate("glGetFragDataLocation", typeof(Delegates.GetFragDataLocation));
            Delegates.glGetFramebufferAttachmentParameteriv = (Delegates.GetFramebufferAttachmentParameteriv)GetExtensionDelegate("glGetFramebufferAttachmentParameteriv", typeof(Delegates.GetFramebufferAttachmentParameteriv));
            Delegates.glGetGraphicsResetStatusEXT = (Delegates.GetGraphicsResetStatusEXT)GetExtensionDelegate("glGetGraphicsResetStatusEXT", typeof(Delegates.GetGraphicsResetStatusEXT));
            Delegates.glGetInteger64i_v = (Delegates.GetInteger64i_v)GetExtensionDelegate("glGetInteger64i_v", typeof(Delegates.GetInteger64i_v));
            Delegates.glGetInteger64v = (Delegates.GetInteger64v)GetExtensionDelegate("glGetInteger64v", typeof(Delegates.GetInteger64v));
            Delegates.glGetInteger64vAPPLE = (Delegates.GetInteger64vAPPLE)GetExtensionDelegate("glGetInteger64vAPPLE", typeof(Delegates.GetInteger64vAPPLE));
            Delegates.glGetIntegeri_v = (Delegates.GetIntegeri_v)GetExtensionDelegate("glGetIntegeri_v", typeof(Delegates.GetIntegeri_v));
            Delegates.glGetIntegeri_vEXT = (Delegates.GetIntegeri_vEXT)GetExtensionDelegate("glGetIntegeri_vEXT", typeof(Delegates.GetIntegeri_vEXT));
            Delegates.glGetIntegerv = (Delegates.GetIntegerv)GetExtensionDelegate("glGetIntegerv", typeof(Delegates.GetIntegerv));
            Delegates.glGetInternalformativ = (Delegates.GetInternalformativ)GetExtensionDelegate("glGetInternalformativ", typeof(Delegates.GetInternalformativ));
            Delegates.glGetnUniformfvEXT = (Delegates.GetnUniformfvEXT)GetExtensionDelegate("glGetnUniformfvEXT", typeof(Delegates.GetnUniformfvEXT));
            Delegates.glGetnUniformivEXT = (Delegates.GetnUniformivEXT)GetExtensionDelegate("glGetnUniformivEXT", typeof(Delegates.GetnUniformivEXT));
            Delegates.glGetObjectLabel = (Delegates.GetObjectLabel)GetExtensionDelegate("glGetObjectLabel", typeof(Delegates.GetObjectLabel));
            Delegates.glGetObjectLabelEXT = (Delegates.GetObjectLabelEXT)GetExtensionDelegate("glGetObjectLabelEXT", typeof(Delegates.GetObjectLabelEXT));
            Delegates.glGetObjectLabelKHR = (Delegates.GetObjectLabelKHR)GetExtensionDelegate("glGetObjectLabelKHR", typeof(Delegates.GetObjectLabelKHR));
            Delegates.glGetObjectPtrLabel = (Delegates.GetObjectPtrLabel)GetExtensionDelegate("glGetObjectPtrLabel", typeof(Delegates.GetObjectPtrLabel));
            Delegates.glGetObjectPtrLabelKHR = (Delegates.GetObjectPtrLabelKHR)GetExtensionDelegate("glGetObjectPtrLabelKHR", typeof(Delegates.GetObjectPtrLabelKHR));
            Delegates.glGetPerfMonitorCounterDataAMD = (Delegates.GetPerfMonitorCounterDataAMD)GetExtensionDelegate("glGetPerfMonitorCounterDataAMD", typeof(Delegates.GetPerfMonitorCounterDataAMD));
            Delegates.glGetPerfMonitorCounterInfoAMD = (Delegates.GetPerfMonitorCounterInfoAMD)GetExtensionDelegate("glGetPerfMonitorCounterInfoAMD", typeof(Delegates.GetPerfMonitorCounterInfoAMD));
            Delegates.glGetPerfMonitorCountersAMD = (Delegates.GetPerfMonitorCountersAMD)GetExtensionDelegate("glGetPerfMonitorCountersAMD", typeof(Delegates.GetPerfMonitorCountersAMD));
            Delegates.glGetPerfMonitorCounterStringAMD = (Delegates.GetPerfMonitorCounterStringAMD)GetExtensionDelegate("glGetPerfMonitorCounterStringAMD", typeof(Delegates.GetPerfMonitorCounterStringAMD));
            Delegates.glGetPerfMonitorGroupsAMD = (Delegates.GetPerfMonitorGroupsAMD)GetExtensionDelegate("glGetPerfMonitorGroupsAMD", typeof(Delegates.GetPerfMonitorGroupsAMD));
            Delegates.glGetPerfMonitorGroupStringAMD = (Delegates.GetPerfMonitorGroupStringAMD)GetExtensionDelegate("glGetPerfMonitorGroupStringAMD", typeof(Delegates.GetPerfMonitorGroupStringAMD));
            Delegates.glGetPointerv = (Delegates.GetPointerv)GetExtensionDelegate("glGetPointerv", typeof(Delegates.GetPointerv));
            Delegates.glGetPointervKHR = (Delegates.GetPointervKHR)GetExtensionDelegate("glGetPointervKHR", typeof(Delegates.GetPointervKHR));
            Delegates.glGetProgramBinary = (Delegates.GetProgramBinary)GetExtensionDelegate("glGetProgramBinary", typeof(Delegates.GetProgramBinary));
            Delegates.glGetProgramBinaryOES = (Delegates.GetProgramBinaryOES)GetExtensionDelegate("glGetProgramBinaryOES", typeof(Delegates.GetProgramBinaryOES));
            Delegates.glGetProgramInfoLog = (Delegates.GetProgramInfoLog)GetExtensionDelegate("glGetProgramInfoLog", typeof(Delegates.GetProgramInfoLog));
            Delegates.glGetProgramiv = (Delegates.GetProgramiv)GetExtensionDelegate("glGetProgramiv", typeof(Delegates.GetProgramiv));
            Delegates.glGetProgramPipelineInfoLogEXT = (Delegates.GetProgramPipelineInfoLogEXT)GetExtensionDelegate("glGetProgramPipelineInfoLogEXT", typeof(Delegates.GetProgramPipelineInfoLogEXT));
            Delegates.glGetProgramPipelineivEXT = (Delegates.GetProgramPipelineivEXT)GetExtensionDelegate("glGetProgramPipelineivEXT", typeof(Delegates.GetProgramPipelineivEXT));
            Delegates.glGetQueryiv = (Delegates.GetQueryiv)GetExtensionDelegate("glGetQueryiv", typeof(Delegates.GetQueryiv));
            Delegates.glGetQueryivEXT = (Delegates.GetQueryivEXT)GetExtensionDelegate("glGetQueryivEXT", typeof(Delegates.GetQueryivEXT));
            Delegates.glGetQueryObjecti64vEXT = (Delegates.GetQueryObjecti64vEXT)GetExtensionDelegate("glGetQueryObjecti64vEXT", typeof(Delegates.GetQueryObjecti64vEXT));
            Delegates.glGetQueryObjectivEXT = (Delegates.GetQueryObjectivEXT)GetExtensionDelegate("glGetQueryObjectivEXT", typeof(Delegates.GetQueryObjectivEXT));
            Delegates.glGetQueryObjectui64vEXT = (Delegates.GetQueryObjectui64vEXT)GetExtensionDelegate("glGetQueryObjectui64vEXT", typeof(Delegates.GetQueryObjectui64vEXT));
            Delegates.glGetQueryObjectuiv = (Delegates.GetQueryObjectuiv)GetExtensionDelegate("glGetQueryObjectuiv", typeof(Delegates.GetQueryObjectuiv));
            Delegates.glGetQueryObjectuivEXT = (Delegates.GetQueryObjectuivEXT)GetExtensionDelegate("glGetQueryObjectuivEXT", typeof(Delegates.GetQueryObjectuivEXT));
            Delegates.glGetRenderbufferParameteriv = (Delegates.GetRenderbufferParameteriv)GetExtensionDelegate("glGetRenderbufferParameteriv", typeof(Delegates.GetRenderbufferParameteriv));
            Delegates.glGetSamplerParameterfv = (Delegates.GetSamplerParameterfv)GetExtensionDelegate("glGetSamplerParameterfv", typeof(Delegates.GetSamplerParameterfv));
            Delegates.glGetSamplerParameteriv = (Delegates.GetSamplerParameteriv)GetExtensionDelegate("glGetSamplerParameteriv", typeof(Delegates.GetSamplerParameteriv));
            Delegates.glGetShaderInfoLog = (Delegates.GetShaderInfoLog)GetExtensionDelegate("glGetShaderInfoLog", typeof(Delegates.GetShaderInfoLog));
            Delegates.glGetShaderiv = (Delegates.GetShaderiv)GetExtensionDelegate("glGetShaderiv", typeof(Delegates.GetShaderiv));
            Delegates.glGetShaderPrecisionFormat = (Delegates.GetShaderPrecisionFormat)GetExtensionDelegate("glGetShaderPrecisionFormat", typeof(Delegates.GetShaderPrecisionFormat));
            Delegates.glGetShaderSource = (Delegates.GetShaderSource)GetExtensionDelegate("glGetShaderSource", typeof(Delegates.GetShaderSource));
            Delegates.glGetString = (Delegates.GetString)GetExtensionDelegate("glGetString", typeof(Delegates.GetString));
            Delegates.glGetStringi = (Delegates.GetStringi)GetExtensionDelegate("glGetStringi", typeof(Delegates.GetStringi));
            Delegates.glGetSynciv = (Delegates.GetSynciv)GetExtensionDelegate("glGetSynciv", typeof(Delegates.GetSynciv));
            Delegates.glGetSyncivAPPLE = (Delegates.GetSyncivAPPLE)GetExtensionDelegate("glGetSyncivAPPLE", typeof(Delegates.GetSyncivAPPLE));
            Delegates.glGetTexParameterfv = (Delegates.GetTexParameterfv)GetExtensionDelegate("glGetTexParameterfv", typeof(Delegates.GetTexParameterfv));
            Delegates.glGetTexParameteriv = (Delegates.GetTexParameteriv)GetExtensionDelegate("glGetTexParameteriv", typeof(Delegates.GetTexParameteriv));
            Delegates.glGetTransformFeedbackVarying = (Delegates.GetTransformFeedbackVarying)GetExtensionDelegate("glGetTransformFeedbackVarying", typeof(Delegates.GetTransformFeedbackVarying));
            Delegates.glGetTranslatedShaderSourceANGLE = (Delegates.GetTranslatedShaderSourceANGLE)GetExtensionDelegate("glGetTranslatedShaderSourceANGLE", typeof(Delegates.GetTranslatedShaderSourceANGLE));
            Delegates.glGetUniformBlockIndex = (Delegates.GetUniformBlockIndex)GetExtensionDelegate("glGetUniformBlockIndex", typeof(Delegates.GetUniformBlockIndex));
            Delegates.glGetUniformfv = (Delegates.GetUniformfv)GetExtensionDelegate("glGetUniformfv", typeof(Delegates.GetUniformfv));
            Delegates.glGetUniformIndices = (Delegates.GetUniformIndices)GetExtensionDelegate("glGetUniformIndices", typeof(Delegates.GetUniformIndices));
            Delegates.glGetUniformiv = (Delegates.GetUniformiv)GetExtensionDelegate("glGetUniformiv", typeof(Delegates.GetUniformiv));
            Delegates.glGetUniformLocation = (Delegates.GetUniformLocation)GetExtensionDelegate("glGetUniformLocation", typeof(Delegates.GetUniformLocation));
            Delegates.glGetUniformuiv = (Delegates.GetUniformuiv)GetExtensionDelegate("glGetUniformuiv", typeof(Delegates.GetUniformuiv));
            Delegates.glGetVertexAttribfv = (Delegates.GetVertexAttribfv)GetExtensionDelegate("glGetVertexAttribfv", typeof(Delegates.GetVertexAttribfv));
            Delegates.glGetVertexAttribIiv = (Delegates.GetVertexAttribIiv)GetExtensionDelegate("glGetVertexAttribIiv", typeof(Delegates.GetVertexAttribIiv));
            Delegates.glGetVertexAttribIuiv = (Delegates.GetVertexAttribIuiv)GetExtensionDelegate("glGetVertexAttribIuiv", typeof(Delegates.GetVertexAttribIuiv));
            Delegates.glGetVertexAttribiv = (Delegates.GetVertexAttribiv)GetExtensionDelegate("glGetVertexAttribiv", typeof(Delegates.GetVertexAttribiv));
            Delegates.glGetVertexAttribPointerv = (Delegates.GetVertexAttribPointerv)GetExtensionDelegate("glGetVertexAttribPointerv", typeof(Delegates.GetVertexAttribPointerv));
            Delegates.glHint = (Delegates.Hint)GetExtensionDelegate("glHint", typeof(Delegates.Hint));
            Delegates.glInsertEventMarkerEXT = (Delegates.InsertEventMarkerEXT)GetExtensionDelegate("glInsertEventMarkerEXT", typeof(Delegates.InsertEventMarkerEXT));
            Delegates.glInvalidateFramebuffer = (Delegates.InvalidateFramebuffer)GetExtensionDelegate("glInvalidateFramebuffer", typeof(Delegates.InvalidateFramebuffer));
            Delegates.glInvalidateSubFramebuffer = (Delegates.InvalidateSubFramebuffer)GetExtensionDelegate("glInvalidateSubFramebuffer", typeof(Delegates.InvalidateSubFramebuffer));
            Delegates.glIsBuffer = (Delegates.IsBuffer)GetExtensionDelegate("glIsBuffer", typeof(Delegates.IsBuffer));
            Delegates.glIsEnabled = (Delegates.IsEnabled)GetExtensionDelegate("glIsEnabled", typeof(Delegates.IsEnabled));
            Delegates.glIsFenceNV = (Delegates.IsFenceNV)GetExtensionDelegate("glIsFenceNV", typeof(Delegates.IsFenceNV));
            Delegates.glIsFramebuffer = (Delegates.IsFramebuffer)GetExtensionDelegate("glIsFramebuffer", typeof(Delegates.IsFramebuffer));
            Delegates.glIsProgram = (Delegates.IsProgram)GetExtensionDelegate("glIsProgram", typeof(Delegates.IsProgram));
            Delegates.glIsProgramPipelineEXT = (Delegates.IsProgramPipelineEXT)GetExtensionDelegate("glIsProgramPipelineEXT", typeof(Delegates.IsProgramPipelineEXT));
            Delegates.glIsQuery = (Delegates.IsQuery)GetExtensionDelegate("glIsQuery", typeof(Delegates.IsQuery));
            Delegates.glIsQueryEXT = (Delegates.IsQueryEXT)GetExtensionDelegate("glIsQueryEXT", typeof(Delegates.IsQueryEXT));
            Delegates.glIsRenderbuffer = (Delegates.IsRenderbuffer)GetExtensionDelegate("glIsRenderbuffer", typeof(Delegates.IsRenderbuffer));
            Delegates.glIsSampler = (Delegates.IsSampler)GetExtensionDelegate("glIsSampler", typeof(Delegates.IsSampler));
            Delegates.glIsShader = (Delegates.IsShader)GetExtensionDelegate("glIsShader", typeof(Delegates.IsShader));
            Delegates.glIsSync = (Delegates.IsSync)GetExtensionDelegate("glIsSync", typeof(Delegates.IsSync));
            Delegates.glIsSyncAPPLE = (Delegates.IsSyncAPPLE)GetExtensionDelegate("glIsSyncAPPLE", typeof(Delegates.IsSyncAPPLE));
            Delegates.glIsTexture = (Delegates.IsTexture)GetExtensionDelegate("glIsTexture", typeof(Delegates.IsTexture));
            Delegates.glIsTransformFeedback = (Delegates.IsTransformFeedback)GetExtensionDelegate("glIsTransformFeedback", typeof(Delegates.IsTransformFeedback));
            Delegates.glIsVertexArray = (Delegates.IsVertexArray)GetExtensionDelegate("glIsVertexArray", typeof(Delegates.IsVertexArray));
            Delegates.glIsVertexArrayOES = (Delegates.IsVertexArrayOES)GetExtensionDelegate("glIsVertexArrayOES", typeof(Delegates.IsVertexArrayOES));
            Delegates.glLabelObjectEXT = (Delegates.LabelObjectEXT)GetExtensionDelegate("glLabelObjectEXT", typeof(Delegates.LabelObjectEXT));
            Delegates.glLineWidth = (Delegates.LineWidth)GetExtensionDelegate("glLineWidth", typeof(Delegates.LineWidth));
            Delegates.glLinkProgram = (Delegates.LinkProgram)GetExtensionDelegate("glLinkProgram", typeof(Delegates.LinkProgram));
            Delegates.glMapBufferOES = (Delegates.MapBufferOES)GetExtensionDelegate("glMapBufferOES", typeof(Delegates.MapBufferOES));
            Delegates.glMapBufferRange = (Delegates.MapBufferRange)GetExtensionDelegate("glMapBufferRange", typeof(Delegates.MapBufferRange));
            Delegates.glMapBufferRangeEXT = (Delegates.MapBufferRangeEXT)GetExtensionDelegate("glMapBufferRangeEXT", typeof(Delegates.MapBufferRangeEXT));
            Delegates.glMultiDrawArraysEXT = (Delegates.MultiDrawArraysEXT)GetExtensionDelegate("glMultiDrawArraysEXT", typeof(Delegates.MultiDrawArraysEXT));
            Delegates.glMultiDrawElementsEXT = (Delegates.MultiDrawElementsEXT)GetExtensionDelegate("glMultiDrawElementsEXT", typeof(Delegates.MultiDrawElementsEXT));
            Delegates.glObjectLabel = (Delegates.ObjectLabel)GetExtensionDelegate("glObjectLabel", typeof(Delegates.ObjectLabel));
            Delegates.glObjectLabelKHR = (Delegates.ObjectLabelKHR)GetExtensionDelegate("glObjectLabelKHR", typeof(Delegates.ObjectLabelKHR));
            Delegates.glObjectPtrLabel = (Delegates.ObjectPtrLabel)GetExtensionDelegate("glObjectPtrLabel", typeof(Delegates.ObjectPtrLabel));
            Delegates.glObjectPtrLabelKHR = (Delegates.ObjectPtrLabelKHR)GetExtensionDelegate("glObjectPtrLabelKHR", typeof(Delegates.ObjectPtrLabelKHR));
            Delegates.glPauseTransformFeedback = (Delegates.PauseTransformFeedback)GetExtensionDelegate("glPauseTransformFeedback", typeof(Delegates.PauseTransformFeedback));
            Delegates.glPixelStorei = (Delegates.PixelStorei)GetExtensionDelegate("glPixelStorei", typeof(Delegates.PixelStorei));
            Delegates.glPolygonOffset = (Delegates.PolygonOffset)GetExtensionDelegate("glPolygonOffset", typeof(Delegates.PolygonOffset));
            Delegates.glPopDebugGroup = (Delegates.PopDebugGroup)GetExtensionDelegate("glPopDebugGroup", typeof(Delegates.PopDebugGroup));
            Delegates.glPopDebugGroupKHR = (Delegates.PopDebugGroupKHR)GetExtensionDelegate("glPopDebugGroupKHR", typeof(Delegates.PopDebugGroupKHR));
            Delegates.glPopGroupMarkerEXT = (Delegates.PopGroupMarkerEXT)GetExtensionDelegate("glPopGroupMarkerEXT", typeof(Delegates.PopGroupMarkerEXT));
            Delegates.glProgramBinary = (Delegates.ProgramBinary)GetExtensionDelegate("glProgramBinary", typeof(Delegates.ProgramBinary));
            Delegates.glProgramBinaryOES = (Delegates.ProgramBinaryOES)GetExtensionDelegate("glProgramBinaryOES", typeof(Delegates.ProgramBinaryOES));
            Delegates.glProgramParameteri = (Delegates.ProgramParameteri)GetExtensionDelegate("glProgramParameteri", typeof(Delegates.ProgramParameteri));
            Delegates.glProgramParameteriEXT = (Delegates.ProgramParameteriEXT)GetExtensionDelegate("glProgramParameteriEXT", typeof(Delegates.ProgramParameteriEXT));
            Delegates.glProgramUniform1fEXT = (Delegates.ProgramUniform1fEXT)GetExtensionDelegate("glProgramUniform1fEXT", typeof(Delegates.ProgramUniform1fEXT));
            Delegates.glProgramUniform1fvEXT = (Delegates.ProgramUniform1fvEXT)GetExtensionDelegate("glProgramUniform1fvEXT", typeof(Delegates.ProgramUniform1fvEXT));
            Delegates.glProgramUniform1iEXT = (Delegates.ProgramUniform1iEXT)GetExtensionDelegate("glProgramUniform1iEXT", typeof(Delegates.ProgramUniform1iEXT));
            Delegates.glProgramUniform1ivEXT = (Delegates.ProgramUniform1ivEXT)GetExtensionDelegate("glProgramUniform1ivEXT", typeof(Delegates.ProgramUniform1ivEXT));
            Delegates.glProgramUniform1uiEXT = (Delegates.ProgramUniform1uiEXT)GetExtensionDelegate("glProgramUniform1uiEXT", typeof(Delegates.ProgramUniform1uiEXT));
            Delegates.glProgramUniform1uivEXT = (Delegates.ProgramUniform1uivEXT)GetExtensionDelegate("glProgramUniform1uivEXT", typeof(Delegates.ProgramUniform1uivEXT));
            Delegates.glProgramUniform2fEXT = (Delegates.ProgramUniform2fEXT)GetExtensionDelegate("glProgramUniform2fEXT", typeof(Delegates.ProgramUniform2fEXT));
            Delegates.glProgramUniform2fvEXT = (Delegates.ProgramUniform2fvEXT)GetExtensionDelegate("glProgramUniform2fvEXT", typeof(Delegates.ProgramUniform2fvEXT));
            Delegates.glProgramUniform2iEXT = (Delegates.ProgramUniform2iEXT)GetExtensionDelegate("glProgramUniform2iEXT", typeof(Delegates.ProgramUniform2iEXT));
            Delegates.glProgramUniform2ivEXT = (Delegates.ProgramUniform2ivEXT)GetExtensionDelegate("glProgramUniform2ivEXT", typeof(Delegates.ProgramUniform2ivEXT));
            Delegates.glProgramUniform2uiEXT = (Delegates.ProgramUniform2uiEXT)GetExtensionDelegate("glProgramUniform2uiEXT", typeof(Delegates.ProgramUniform2uiEXT));
            Delegates.glProgramUniform2uivEXT = (Delegates.ProgramUniform2uivEXT)GetExtensionDelegate("glProgramUniform2uivEXT", typeof(Delegates.ProgramUniform2uivEXT));
            Delegates.glProgramUniform3fEXT = (Delegates.ProgramUniform3fEXT)GetExtensionDelegate("glProgramUniform3fEXT", typeof(Delegates.ProgramUniform3fEXT));
            Delegates.glProgramUniform3fvEXT = (Delegates.ProgramUniform3fvEXT)GetExtensionDelegate("glProgramUniform3fvEXT", typeof(Delegates.ProgramUniform3fvEXT));
            Delegates.glProgramUniform3iEXT = (Delegates.ProgramUniform3iEXT)GetExtensionDelegate("glProgramUniform3iEXT", typeof(Delegates.ProgramUniform3iEXT));
            Delegates.glProgramUniform3ivEXT = (Delegates.ProgramUniform3ivEXT)GetExtensionDelegate("glProgramUniform3ivEXT", typeof(Delegates.ProgramUniform3ivEXT));
            Delegates.glProgramUniform3uiEXT = (Delegates.ProgramUniform3uiEXT)GetExtensionDelegate("glProgramUniform3uiEXT", typeof(Delegates.ProgramUniform3uiEXT));
            Delegates.glProgramUniform3uivEXT = (Delegates.ProgramUniform3uivEXT)GetExtensionDelegate("glProgramUniform3uivEXT", typeof(Delegates.ProgramUniform3uivEXT));
            Delegates.glProgramUniform4fEXT = (Delegates.ProgramUniform4fEXT)GetExtensionDelegate("glProgramUniform4fEXT", typeof(Delegates.ProgramUniform4fEXT));
            Delegates.glProgramUniform4fvEXT = (Delegates.ProgramUniform4fvEXT)GetExtensionDelegate("glProgramUniform4fvEXT", typeof(Delegates.ProgramUniform4fvEXT));
            Delegates.glProgramUniform4iEXT = (Delegates.ProgramUniform4iEXT)GetExtensionDelegate("glProgramUniform4iEXT", typeof(Delegates.ProgramUniform4iEXT));
            Delegates.glProgramUniform4ivEXT = (Delegates.ProgramUniform4ivEXT)GetExtensionDelegate("glProgramUniform4ivEXT", typeof(Delegates.ProgramUniform4ivEXT));
            Delegates.glProgramUniform4uiEXT = (Delegates.ProgramUniform4uiEXT)GetExtensionDelegate("glProgramUniform4uiEXT", typeof(Delegates.ProgramUniform4uiEXT));
            Delegates.glProgramUniform4uivEXT = (Delegates.ProgramUniform4uivEXT)GetExtensionDelegate("glProgramUniform4uivEXT", typeof(Delegates.ProgramUniform4uivEXT));
            Delegates.glProgramUniformMatrix2fvEXT = (Delegates.ProgramUniformMatrix2fvEXT)GetExtensionDelegate("glProgramUniformMatrix2fvEXT", typeof(Delegates.ProgramUniformMatrix2fvEXT));
            Delegates.glProgramUniformMatrix2x3fvEXT = (Delegates.ProgramUniformMatrix2x3fvEXT)GetExtensionDelegate("glProgramUniformMatrix2x3fvEXT", typeof(Delegates.ProgramUniformMatrix2x3fvEXT));
            Delegates.glProgramUniformMatrix2x4fvEXT = (Delegates.ProgramUniformMatrix2x4fvEXT)GetExtensionDelegate("glProgramUniformMatrix2x4fvEXT", typeof(Delegates.ProgramUniformMatrix2x4fvEXT));
            Delegates.glProgramUniformMatrix3fvEXT = (Delegates.ProgramUniformMatrix3fvEXT)GetExtensionDelegate("glProgramUniformMatrix3fvEXT", typeof(Delegates.ProgramUniformMatrix3fvEXT));
            Delegates.glProgramUniformMatrix3x2fvEXT = (Delegates.ProgramUniformMatrix3x2fvEXT)GetExtensionDelegate("glProgramUniformMatrix3x2fvEXT", typeof(Delegates.ProgramUniformMatrix3x2fvEXT));
            Delegates.glProgramUniformMatrix3x4fvEXT = (Delegates.ProgramUniformMatrix3x4fvEXT)GetExtensionDelegate("glProgramUniformMatrix3x4fvEXT", typeof(Delegates.ProgramUniformMatrix3x4fvEXT));
            Delegates.glProgramUniformMatrix4fvEXT = (Delegates.ProgramUniformMatrix4fvEXT)GetExtensionDelegate("glProgramUniformMatrix4fvEXT", typeof(Delegates.ProgramUniformMatrix4fvEXT));
            Delegates.glProgramUniformMatrix4x2fvEXT = (Delegates.ProgramUniformMatrix4x2fvEXT)GetExtensionDelegate("glProgramUniformMatrix4x2fvEXT", typeof(Delegates.ProgramUniformMatrix4x2fvEXT));
            Delegates.glProgramUniformMatrix4x3fvEXT = (Delegates.ProgramUniformMatrix4x3fvEXT)GetExtensionDelegate("glProgramUniformMatrix4x3fvEXT", typeof(Delegates.ProgramUniformMatrix4x3fvEXT));
            Delegates.glPushDebugGroup = (Delegates.PushDebugGroup)GetExtensionDelegate("glPushDebugGroup", typeof(Delegates.PushDebugGroup));
            Delegates.glPushDebugGroupKHR = (Delegates.PushDebugGroupKHR)GetExtensionDelegate("glPushDebugGroupKHR", typeof(Delegates.PushDebugGroupKHR));
            Delegates.glPushGroupMarkerEXT = (Delegates.PushGroupMarkerEXT)GetExtensionDelegate("glPushGroupMarkerEXT", typeof(Delegates.PushGroupMarkerEXT));
            Delegates.glQueryCounterEXT = (Delegates.QueryCounterEXT)GetExtensionDelegate("glQueryCounterEXT", typeof(Delegates.QueryCounterEXT));
            Delegates.glReadBuffer = (Delegates.ReadBuffer)GetExtensionDelegate("glReadBuffer", typeof(Delegates.ReadBuffer));
            Delegates.glReadBufferIndexedEXT = (Delegates.ReadBufferIndexedEXT)GetExtensionDelegate("glReadBufferIndexedEXT", typeof(Delegates.ReadBufferIndexedEXT));
            Delegates.glReadBufferNV = (Delegates.ReadBufferNV)GetExtensionDelegate("glReadBufferNV", typeof(Delegates.ReadBufferNV));
            Delegates.glReadnPixelsEXT = (Delegates.ReadnPixelsEXT)GetExtensionDelegate("glReadnPixelsEXT", typeof(Delegates.ReadnPixelsEXT));
            Delegates.glReadPixels = (Delegates.ReadPixels)GetExtensionDelegate("glReadPixels", typeof(Delegates.ReadPixels));
            Delegates.glReleaseShaderCompiler = (Delegates.ReleaseShaderCompiler)GetExtensionDelegate("glReleaseShaderCompiler", typeof(Delegates.ReleaseShaderCompiler));
            Delegates.glRenderbufferStorage = (Delegates.RenderbufferStorage)GetExtensionDelegate("glRenderbufferStorage", typeof(Delegates.RenderbufferStorage));
            Delegates.glRenderbufferStorageMultisample = (Delegates.RenderbufferStorageMultisample)GetExtensionDelegate("glRenderbufferStorageMultisample", typeof(Delegates.RenderbufferStorageMultisample));
            Delegates.glRenderbufferStorageMultisampleANGLE = (Delegates.RenderbufferStorageMultisampleANGLE)GetExtensionDelegate("glRenderbufferStorageMultisampleANGLE", typeof(Delegates.RenderbufferStorageMultisampleANGLE));
            Delegates.glRenderbufferStorageMultisampleAPPLE = (Delegates.RenderbufferStorageMultisampleAPPLE)GetExtensionDelegate("glRenderbufferStorageMultisampleAPPLE", typeof(Delegates.RenderbufferStorageMultisampleAPPLE));
            Delegates.glRenderbufferStorageMultisampleEXT = (Delegates.RenderbufferStorageMultisampleEXT)GetExtensionDelegate("glRenderbufferStorageMultisampleEXT", typeof(Delegates.RenderbufferStorageMultisampleEXT));
            Delegates.glRenderbufferStorageMultisampleIMG = (Delegates.RenderbufferStorageMultisampleIMG)GetExtensionDelegate("glRenderbufferStorageMultisampleIMG", typeof(Delegates.RenderbufferStorageMultisampleIMG));
            Delegates.glRenderbufferStorageMultisampleNV = (Delegates.RenderbufferStorageMultisampleNV)GetExtensionDelegate("glRenderbufferStorageMultisampleNV", typeof(Delegates.RenderbufferStorageMultisampleNV));
            Delegates.glResolveMultisampleFramebufferAPPLE = (Delegates.ResolveMultisampleFramebufferAPPLE)GetExtensionDelegate("glResolveMultisampleFramebufferAPPLE", typeof(Delegates.ResolveMultisampleFramebufferAPPLE));
            Delegates.glResumeTransformFeedback = (Delegates.ResumeTransformFeedback)GetExtensionDelegate("glResumeTransformFeedback", typeof(Delegates.ResumeTransformFeedback));
            Delegates.glSampleCoverage = (Delegates.SampleCoverage)GetExtensionDelegate("glSampleCoverage", typeof(Delegates.SampleCoverage));
            Delegates.glSamplerParameterf = (Delegates.SamplerParameterf)GetExtensionDelegate("glSamplerParameterf", typeof(Delegates.SamplerParameterf));
            Delegates.glSamplerParameterfv = (Delegates.SamplerParameterfv)GetExtensionDelegate("glSamplerParameterfv", typeof(Delegates.SamplerParameterfv));
            Delegates.glSamplerParameteri = (Delegates.SamplerParameteri)GetExtensionDelegate("glSamplerParameteri", typeof(Delegates.SamplerParameteri));
            Delegates.glSamplerParameteriv = (Delegates.SamplerParameteriv)GetExtensionDelegate("glSamplerParameteriv", typeof(Delegates.SamplerParameteriv));
            Delegates.glScissor = (Delegates.Scissor)GetExtensionDelegate("glScissor", typeof(Delegates.Scissor));
            Delegates.glSelectPerfMonitorCountersAMD = (Delegates.SelectPerfMonitorCountersAMD)GetExtensionDelegate("glSelectPerfMonitorCountersAMD", typeof(Delegates.SelectPerfMonitorCountersAMD));
            Delegates.glSetFenceNV = (Delegates.SetFenceNV)GetExtensionDelegate("glSetFenceNV", typeof(Delegates.SetFenceNV));
            Delegates.glShaderBinary = (Delegates.ShaderBinary)GetExtensionDelegate("glShaderBinary", typeof(Delegates.ShaderBinary));
            Delegates.glShaderSource = (Delegates.ShaderSource)GetExtensionDelegate("glShaderSource", typeof(Delegates.ShaderSource));
            Delegates.glStartTilingQCOM = (Delegates.StartTilingQCOM)GetExtensionDelegate("glStartTilingQCOM", typeof(Delegates.StartTilingQCOM));
            Delegates.glStencilFunc = (Delegates.StencilFunc)GetExtensionDelegate("glStencilFunc", typeof(Delegates.StencilFunc));
            Delegates.glStencilFuncSeparate = (Delegates.StencilFuncSeparate)GetExtensionDelegate("glStencilFuncSeparate", typeof(Delegates.StencilFuncSeparate));
            Delegates.glStencilMask = (Delegates.StencilMask)GetExtensionDelegate("glStencilMask", typeof(Delegates.StencilMask));
            Delegates.glStencilMaskSeparate = (Delegates.StencilMaskSeparate)GetExtensionDelegate("glStencilMaskSeparate", typeof(Delegates.StencilMaskSeparate));
            Delegates.glStencilOp = (Delegates.StencilOp)GetExtensionDelegate("glStencilOp", typeof(Delegates.StencilOp));
            Delegates.glStencilOpSeparate = (Delegates.StencilOpSeparate)GetExtensionDelegate("glStencilOpSeparate", typeof(Delegates.StencilOpSeparate));
            Delegates.glTestFenceNV = (Delegates.TestFenceNV)GetExtensionDelegate("glTestFenceNV", typeof(Delegates.TestFenceNV));
            Delegates.glTexImage2D = (Delegates.TexImage2D)GetExtensionDelegate("glTexImage2D", typeof(Delegates.TexImage2D));
            Delegates.glTexImage3D = (Delegates.TexImage3D)GetExtensionDelegate("glTexImage3D", typeof(Delegates.TexImage3D));
            Delegates.glTexImage3DOES = (Delegates.TexImage3DOES)GetExtensionDelegate("glTexImage3DOES", typeof(Delegates.TexImage3DOES));
            Delegates.glTexParameterf = (Delegates.TexParameterf)GetExtensionDelegate("glTexParameterf", typeof(Delegates.TexParameterf));
            Delegates.glTexParameterfv = (Delegates.TexParameterfv)GetExtensionDelegate("glTexParameterfv", typeof(Delegates.TexParameterfv));
            Delegates.glTexParameteri = (Delegates.TexParameteri)GetExtensionDelegate("glTexParameteri", typeof(Delegates.TexParameteri));
            Delegates.glTexParameteriv = (Delegates.TexParameteriv)GetExtensionDelegate("glTexParameteriv", typeof(Delegates.TexParameteriv));
            Delegates.glTexStorage1DEXT = (Delegates.TexStorage1DEXT)GetExtensionDelegate("glTexStorage1DEXT", typeof(Delegates.TexStorage1DEXT));
            Delegates.glTexStorage2D = (Delegates.TexStorage2D)GetExtensionDelegate("glTexStorage2D", typeof(Delegates.TexStorage2D));
            Delegates.glTexStorage2DEXT = (Delegates.TexStorage2DEXT)GetExtensionDelegate("glTexStorage2DEXT", typeof(Delegates.TexStorage2DEXT));
            Delegates.glTexStorage3D = (Delegates.TexStorage3D)GetExtensionDelegate("glTexStorage3D", typeof(Delegates.TexStorage3D));
            Delegates.glTexStorage3DEXT = (Delegates.TexStorage3DEXT)GetExtensionDelegate("glTexStorage3DEXT", typeof(Delegates.TexStorage3DEXT));
            Delegates.glTexSubImage2D = (Delegates.TexSubImage2D)GetExtensionDelegate("glTexSubImage2D", typeof(Delegates.TexSubImage2D));
            Delegates.glTexSubImage3D = (Delegates.TexSubImage3D)GetExtensionDelegate("glTexSubImage3D", typeof(Delegates.TexSubImage3D));
            Delegates.glTexSubImage3DOES = (Delegates.TexSubImage3DOES)GetExtensionDelegate("glTexSubImage3DOES", typeof(Delegates.TexSubImage3DOES));
            Delegates.glTextureStorage1DEXT = (Delegates.TextureStorage1DEXT)GetExtensionDelegate("glTextureStorage1DEXT", typeof(Delegates.TextureStorage1DEXT));
            Delegates.glTextureStorage2DEXT = (Delegates.TextureStorage2DEXT)GetExtensionDelegate("glTextureStorage2DEXT", typeof(Delegates.TextureStorage2DEXT));
            Delegates.glTextureStorage3DEXT = (Delegates.TextureStorage3DEXT)GetExtensionDelegate("glTextureStorage3DEXT", typeof(Delegates.TextureStorage3DEXT));
            Delegates.glTransformFeedbackVaryings = (Delegates.TransformFeedbackVaryings)GetExtensionDelegate("glTransformFeedbackVaryings", typeof(Delegates.TransformFeedbackVaryings));
            Delegates.glUniform1f = (Delegates.Uniform1f)GetExtensionDelegate("glUniform1f", typeof(Delegates.Uniform1f));
            Delegates.glUniform1fv = (Delegates.Uniform1fv)GetExtensionDelegate("glUniform1fv", typeof(Delegates.Uniform1fv));
            Delegates.glUniform1i = (Delegates.Uniform1i)GetExtensionDelegate("glUniform1i", typeof(Delegates.Uniform1i));
            Delegates.glUniform1iv = (Delegates.Uniform1iv)GetExtensionDelegate("glUniform1iv", typeof(Delegates.Uniform1iv));
            Delegates.glUniform1ui = (Delegates.Uniform1ui)GetExtensionDelegate("glUniform1ui", typeof(Delegates.Uniform1ui));
            Delegates.glUniform1uiv = (Delegates.Uniform1uiv)GetExtensionDelegate("glUniform1uiv", typeof(Delegates.Uniform1uiv));
            Delegates.glUniform2f = (Delegates.Uniform2f)GetExtensionDelegate("glUniform2f", typeof(Delegates.Uniform2f));
            Delegates.glUniform2fv = (Delegates.Uniform2fv)GetExtensionDelegate("glUniform2fv", typeof(Delegates.Uniform2fv));
            Delegates.glUniform2i = (Delegates.Uniform2i)GetExtensionDelegate("glUniform2i", typeof(Delegates.Uniform2i));
            Delegates.glUniform2iv = (Delegates.Uniform2iv)GetExtensionDelegate("glUniform2iv", typeof(Delegates.Uniform2iv));
            Delegates.glUniform2ui = (Delegates.Uniform2ui)GetExtensionDelegate("glUniform2ui", typeof(Delegates.Uniform2ui));
            Delegates.glUniform2uiv = (Delegates.Uniform2uiv)GetExtensionDelegate("glUniform2uiv", typeof(Delegates.Uniform2uiv));
            Delegates.glUniform3f = (Delegates.Uniform3f)GetExtensionDelegate("glUniform3f", typeof(Delegates.Uniform3f));
            Delegates.glUniform3fv = (Delegates.Uniform3fv)GetExtensionDelegate("glUniform3fv", typeof(Delegates.Uniform3fv));
            Delegates.glUniform3i = (Delegates.Uniform3i)GetExtensionDelegate("glUniform3i", typeof(Delegates.Uniform3i));
            Delegates.glUniform3iv = (Delegates.Uniform3iv)GetExtensionDelegate("glUniform3iv", typeof(Delegates.Uniform3iv));
            Delegates.glUniform3ui = (Delegates.Uniform3ui)GetExtensionDelegate("glUniform3ui", typeof(Delegates.Uniform3ui));
            Delegates.glUniform3uiv = (Delegates.Uniform3uiv)GetExtensionDelegate("glUniform3uiv", typeof(Delegates.Uniform3uiv));
            Delegates.glUniform4f = (Delegates.Uniform4f)GetExtensionDelegate("glUniform4f", typeof(Delegates.Uniform4f));
            Delegates.glUniform4fv = (Delegates.Uniform4fv)GetExtensionDelegate("glUniform4fv", typeof(Delegates.Uniform4fv));
            Delegates.glUniform4i = (Delegates.Uniform4i)GetExtensionDelegate("glUniform4i", typeof(Delegates.Uniform4i));
            Delegates.glUniform4iv = (Delegates.Uniform4iv)GetExtensionDelegate("glUniform4iv", typeof(Delegates.Uniform4iv));
            Delegates.glUniform4ui = (Delegates.Uniform4ui)GetExtensionDelegate("glUniform4ui", typeof(Delegates.Uniform4ui));
            Delegates.glUniform4uiv = (Delegates.Uniform4uiv)GetExtensionDelegate("glUniform4uiv", typeof(Delegates.Uniform4uiv));
            Delegates.glUniformBlockBinding = (Delegates.UniformBlockBinding)GetExtensionDelegate("glUniformBlockBinding", typeof(Delegates.UniformBlockBinding));
            Delegates.glUniformMatrix2fv = (Delegates.UniformMatrix2fv)GetExtensionDelegate("glUniformMatrix2fv", typeof(Delegates.UniformMatrix2fv));
            Delegates.glUniformMatrix2x3fv = (Delegates.UniformMatrix2x3fv)GetExtensionDelegate("glUniformMatrix2x3fv", typeof(Delegates.UniformMatrix2x3fv));
            Delegates.glUniformMatrix2x3fvNV = (Delegates.UniformMatrix2x3fvNV)GetExtensionDelegate("glUniformMatrix2x3fvNV", typeof(Delegates.UniformMatrix2x3fvNV));
            Delegates.glUniformMatrix2x4fv = (Delegates.UniformMatrix2x4fv)GetExtensionDelegate("glUniformMatrix2x4fv", typeof(Delegates.UniformMatrix2x4fv));
            Delegates.glUniformMatrix2x4fvNV = (Delegates.UniformMatrix2x4fvNV)GetExtensionDelegate("glUniformMatrix2x4fvNV", typeof(Delegates.UniformMatrix2x4fvNV));
            Delegates.glUniformMatrix3fv = (Delegates.UniformMatrix3fv)GetExtensionDelegate("glUniformMatrix3fv", typeof(Delegates.UniformMatrix3fv));
            Delegates.glUniformMatrix3x2fv = (Delegates.UniformMatrix3x2fv)GetExtensionDelegate("glUniformMatrix3x2fv", typeof(Delegates.UniformMatrix3x2fv));
            Delegates.glUniformMatrix3x2fvNV = (Delegates.UniformMatrix3x2fvNV)GetExtensionDelegate("glUniformMatrix3x2fvNV", typeof(Delegates.UniformMatrix3x2fvNV));
            Delegates.glUniformMatrix3x4fv = (Delegates.UniformMatrix3x4fv)GetExtensionDelegate("glUniformMatrix3x4fv", typeof(Delegates.UniformMatrix3x4fv));
            Delegates.glUniformMatrix3x4fvNV = (Delegates.UniformMatrix3x4fvNV)GetExtensionDelegate("glUniformMatrix3x4fvNV", typeof(Delegates.UniformMatrix3x4fvNV));
            Delegates.glUniformMatrix4fv = (Delegates.UniformMatrix4fv)GetExtensionDelegate("glUniformMatrix4fv", typeof(Delegates.UniformMatrix4fv));
            Delegates.glUniformMatrix4x2fv = (Delegates.UniformMatrix4x2fv)GetExtensionDelegate("glUniformMatrix4x2fv", typeof(Delegates.UniformMatrix4x2fv));
            Delegates.glUniformMatrix4x2fvNV = (Delegates.UniformMatrix4x2fvNV)GetExtensionDelegate("glUniformMatrix4x2fvNV", typeof(Delegates.UniformMatrix4x2fvNV));
            Delegates.glUniformMatrix4x3fv = (Delegates.UniformMatrix4x3fv)GetExtensionDelegate("glUniformMatrix4x3fv", typeof(Delegates.UniformMatrix4x3fv));
            Delegates.glUniformMatrix4x3fvNV = (Delegates.UniformMatrix4x3fvNV)GetExtensionDelegate("glUniformMatrix4x3fvNV", typeof(Delegates.UniformMatrix4x3fvNV));
            Delegates.glUnmapBuffer = (Delegates.UnmapBuffer)GetExtensionDelegate("glUnmapBuffer", typeof(Delegates.UnmapBuffer));
            Delegates.glUnmapBufferOES = (Delegates.UnmapBufferOES)GetExtensionDelegate("glUnmapBufferOES", typeof(Delegates.UnmapBufferOES));
            Delegates.glUseProgram = (Delegates.UseProgram)GetExtensionDelegate("glUseProgram", typeof(Delegates.UseProgram));
            Delegates.glUseProgramStagesEXT = (Delegates.UseProgramStagesEXT)GetExtensionDelegate("glUseProgramStagesEXT", typeof(Delegates.UseProgramStagesEXT));
            Delegates.glUseShaderProgramEXT = (Delegates.UseShaderProgramEXT)GetExtensionDelegate("glUseShaderProgramEXT", typeof(Delegates.UseShaderProgramEXT));
            Delegates.glValidateProgram = (Delegates.ValidateProgram)GetExtensionDelegate("glValidateProgram", typeof(Delegates.ValidateProgram));
            Delegates.glValidateProgramPipelineEXT = (Delegates.ValidateProgramPipelineEXT)GetExtensionDelegate("glValidateProgramPipelineEXT", typeof(Delegates.ValidateProgramPipelineEXT));
            Delegates.glVertexAttrib1f = (Delegates.VertexAttrib1f)GetExtensionDelegate("glVertexAttrib1f", typeof(Delegates.VertexAttrib1f));
            Delegates.glVertexAttrib1fv = (Delegates.VertexAttrib1fv)GetExtensionDelegate("glVertexAttrib1fv", typeof(Delegates.VertexAttrib1fv));
            Delegates.glVertexAttrib2f = (Delegates.VertexAttrib2f)GetExtensionDelegate("glVertexAttrib2f", typeof(Delegates.VertexAttrib2f));
            Delegates.glVertexAttrib2fv = (Delegates.VertexAttrib2fv)GetExtensionDelegate("glVertexAttrib2fv", typeof(Delegates.VertexAttrib2fv));
            Delegates.glVertexAttrib3f = (Delegates.VertexAttrib3f)GetExtensionDelegate("glVertexAttrib3f", typeof(Delegates.VertexAttrib3f));
            Delegates.glVertexAttrib3fv = (Delegates.VertexAttrib3fv)GetExtensionDelegate("glVertexAttrib3fv", typeof(Delegates.VertexAttrib3fv));
            Delegates.glVertexAttrib4f = (Delegates.VertexAttrib4f)GetExtensionDelegate("glVertexAttrib4f", typeof(Delegates.VertexAttrib4f));
            Delegates.glVertexAttrib4fv = (Delegates.VertexAttrib4fv)GetExtensionDelegate("glVertexAttrib4fv", typeof(Delegates.VertexAttrib4fv));
            Delegates.glVertexAttribDivisor = (Delegates.VertexAttribDivisor)GetExtensionDelegate("glVertexAttribDivisor", typeof(Delegates.VertexAttribDivisor));
            Delegates.glVertexAttribDivisorANGLE = (Delegates.VertexAttribDivisorANGLE)GetExtensionDelegate("glVertexAttribDivisorANGLE", typeof(Delegates.VertexAttribDivisorANGLE));
            Delegates.glVertexAttribDivisorEXT = (Delegates.VertexAttribDivisorEXT)GetExtensionDelegate("glVertexAttribDivisorEXT", typeof(Delegates.VertexAttribDivisorEXT));
            Delegates.glVertexAttribDivisorNV = (Delegates.VertexAttribDivisorNV)GetExtensionDelegate("glVertexAttribDivisorNV", typeof(Delegates.VertexAttribDivisorNV));
            Delegates.glVertexAttribI4i = (Delegates.VertexAttribI4i)GetExtensionDelegate("glVertexAttribI4i", typeof(Delegates.VertexAttribI4i));
            Delegates.glVertexAttribI4iv = (Delegates.VertexAttribI4iv)GetExtensionDelegate("glVertexAttribI4iv", typeof(Delegates.VertexAttribI4iv));
            Delegates.glVertexAttribI4ui = (Delegates.VertexAttribI4ui)GetExtensionDelegate("glVertexAttribI4ui", typeof(Delegates.VertexAttribI4ui));
            Delegates.glVertexAttribI4uiv = (Delegates.VertexAttribI4uiv)GetExtensionDelegate("glVertexAttribI4uiv", typeof(Delegates.VertexAttribI4uiv));
            Delegates.glVertexAttribIPointer = (Delegates.VertexAttribIPointer)GetExtensionDelegate("glVertexAttribIPointer", typeof(Delegates.VertexAttribIPointer));
            Delegates.glVertexAttribPointer = (Delegates.VertexAttribPointer)GetExtensionDelegate("glVertexAttribPointer", typeof(Delegates.VertexAttribPointer));
            Delegates.glViewport = (Delegates.Viewport)GetExtensionDelegate("glViewport", typeof(Delegates.Viewport));
            Delegates.glWaitSync = (Delegates.WaitSync)GetExtensionDelegate("glWaitSync", typeof(Delegates.WaitSync));
            Delegates.glWaitSyncAPPLE = (Delegates.WaitSyncAPPLE)GetExtensionDelegate("glWaitSyncAPPLE", typeof(Delegates.WaitSyncAPPLE));
        }

        internal static partial class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveProgramEXT(UInt32 program);
            internal static ActiveProgramEXT glActiveProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgramEXT glActiveShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES30.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFuncQCOM(OpenTK.Graphics.ES30.All func, Single @ref);
            internal static AlphaFuncQCOM glAlphaFuncQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginPerfMonitorAMD(UInt32 monitor);
            internal static BeginPerfMonitorAMD glBeginPerfMonitorAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQuery(OpenTK.Graphics.ES30.QueryTarget target, UInt32 id);
            internal static BeginQuery glBeginQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQueryEXT(OpenTK.Graphics.ES30.QueryTarget target, UInt32 id);
            internal static BeginQueryEXT glBeginQueryEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginTransformFeedback(OpenTK.Graphics.ES30.TransformFeedbackPrimitiveType primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBuffer(OpenTK.Graphics.ES30.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBufferBase(OpenTK.Graphics.ES30.BufferRangeTarget target, UInt32 index, UInt32 buffer);
            internal static BindBufferBase glBindBufferBase;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBufferRange(OpenTK.Graphics.ES30.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRange glBindBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFramebuffer(OpenTK.Graphics.ES30.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindProgramPipelineEXT(UInt32 pipeline);
            internal static BindProgramPipelineEXT glBindProgramPipelineEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.ES30.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);
            internal static BindSampler glBindSampler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTexture(OpenTK.Graphics.ES30.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTransformFeedback(OpenTK.Graphics.ES30.TransformFeedbackTarget target, UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendBarrierNV();
            internal static BlendBarrierNV glBlendBarrierNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquation(OpenTK.Graphics.ES30.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.ES30.BlendEquationMode mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.ES30.BlendEquationMode modeRGB, OpenTK.Graphics.ES30.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunc(OpenTK.Graphics.ES30.BlendingFactorSrc sfactor, OpenTK.Graphics.ES30.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.ES30.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.ES30.BlendingFactorDest dfactorRGB, OpenTK.Graphics.ES30.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.ES30.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendParameteriNV(OpenTK.Graphics.ES30.All pname, Int32 value);
            internal static BlendParameteriNV glBlendParameteriNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES30.ClearBufferMask mask, OpenTK.Graphics.ES30.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES30.ClearBufferMask mask, OpenTK.Graphics.ES30.BlitFramebufferFilter filter);
            internal static BlitFramebufferANGLE glBlitFramebufferANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES30.ClearBufferMask mask, OpenTK.Graphics.ES30.BlitFramebufferFilter filter);
            internal static BlitFramebufferNV glBlitFramebufferNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferData(OpenTK.Graphics.ES30.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES30.BufferUsageHint usage);
            internal static BufferData glBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferSubData(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES30.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.ES30.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Clear(OpenTK.Graphics.ES30.ClearBufferMask mask);
            internal static Clear glClear;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferfi(OpenTK.Graphics.ES30.ClearBufferCombined buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            internal static ClearBufferfi glClearBufferfi;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferfv(OpenTK.Graphics.ES30.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferiv(OpenTK.Graphics.ES30.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferuiv(OpenTK.Graphics.ES30.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES30.WaitSyncStatus ClientWaitSync(IntPtr sync, OpenTK.Graphics.ES30.ClientWaitSyncFlags flags, UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES30.WaitSyncStatus ClientWaitSyncAPPLE(IntPtr sync, OpenTK.Graphics.ES30.ClientWaitSyncFlags flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES30.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3DOES glCompressedTexImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES30.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.All format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3DOES glCompressedTexSubImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyBufferSubData(OpenTK.Graphics.ES30.BufferTarget readTarget, OpenTK.Graphics.ES30.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyBufferSubDataNV(OpenTK.Graphics.ES30.BufferTarget readTarget, OpenTK.Graphics.ES30.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubDataNV glCopyBufferSubDataNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES30.TextureCopyComponentCount internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3DOES glCopyTexSubImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CoverageMaskNV(bool mask);
            internal static CoverageMaskNV glCoverageMaskNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CoverageOperationNV(OpenTK.Graphics.ES30.All operation);
            internal static CoverageOperationNV glCoverageOperationNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShader(OpenTK.Graphics.ES30.ShaderType type);
            internal static CreateShader glCreateShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShaderProgramEXT(OpenTK.Graphics.ES30.All type, String @string);
            internal static CreateShaderProgramEXT glCreateShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShaderProgramvEXT(OpenTK.Graphics.ES30.All type, Int32 count, String[] strings);
            internal static CreateShaderProgramvEXT glCreateShaderProgramvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CullFace(OpenTK.Graphics.ES30.CullFaceMode mode);
            internal static CullFace glCullFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            internal static DebugMessageCallback glDebugMessageCallback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            internal static DebugMessageCallbackKHR glDebugMessageCallbackKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControl(OpenTK.Graphics.ES30.DebugSourceControl source, OpenTK.Graphics.ES30.DebugTypeControl type, OpenTK.Graphics.ES30.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControl glDebugMessageControl;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControlKHR(OpenTK.Graphics.ES30.DebugSourceControl source, OpenTK.Graphics.ES30.DebugTypeControl type, OpenTK.Graphics.ES30.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlKHR glDebugMessageControlKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsert(OpenTK.Graphics.ES30.DebugSourceExternal source, OpenTK.Graphics.ES30.DebugType type, UInt32 id, OpenTK.Graphics.ES30.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsert glDebugMessageInsert;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsertKHR(OpenTK.Graphics.ES30.DebugSourceExternal source, OpenTK.Graphics.ES30.DebugType type, UInt32 id, OpenTK.Graphics.ES30.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsertKHR glDebugMessageInsertKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeletePerfMonitorsAMD(Int32 n, UInt32* monitors);
            internal unsafe static DeletePerfMonitorsAMD glDeletePerfMonitorsAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelinesEXT glDeleteProgramPipelinesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteQueriesEXT(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesEXT glDeleteQueriesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteSamplers(Int32 count, UInt32* samplers);
            internal unsafe static DeleteSamplers glDeleteSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSync(IntPtr sync);
            internal static DeleteSync glDeleteSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSyncAPPLE(IntPtr sync);
            internal static DeleteSyncAPPLE glDeleteSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArrays(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArrays glDeleteVertexArrays;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysOES glDeleteVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthFunc(OpenTK.Graphics.ES30.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disable(OpenTK.Graphics.ES30.EnableCap cap);
            internal static Disable glDisable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableDriverControlQCOM(UInt32 driverControl);
            internal static DisableDriverControlQCOM glDisableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES30.All target, Int32 numAttachments, OpenTK.Graphics.ES30.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArrays(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstanced(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);
            internal static DrawArraysInstanced glDrawArraysInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedANGLE(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedANGLE glDrawArraysInstancedANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 start, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedNV(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedNV glDrawArraysInstancedNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffers(Int32 n, OpenTK.Graphics.ES30.DrawBufferMode* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffersEXT(Int32 n, OpenTK.Graphics.ES30.DrawBufferMode* bufs);
            internal unsafe static DrawBuffersEXT glDrawBuffersEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffersIndexedEXT(Int32 n, OpenTK.Graphics.ES30.All* location, Int32* indices);
            internal unsafe static DrawBuffersIndexedEXT glDrawBuffersIndexedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffersNV(Int32 n, OpenTK.Graphics.ES30.DrawBufferMode* bufs);
            internal unsafe static DrawBuffersNV glDrawBuffersNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElements(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstanced(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 instancecount);
            internal static DrawElementsInstanced glDrawElementsInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedANGLE(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedANGLE glDrawElementsInstancedANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedNV(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedNV glDrawElementsInstancedNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawRangeElements(OpenTK.Graphics.ES30.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES30.All target, IntPtr image);
            internal static EGLImageTargetRenderbufferStorageOES glEGLImageTargetRenderbufferStorageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES30.All target, IntPtr image);
            internal static EGLImageTargetTexture2DOES glEGLImageTargetTexture2DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enable(OpenTK.Graphics.ES30.EnableCap cap);
            internal static Enable glEnable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableDriverControlQCOM(UInt32 driverControl);
            internal static EnableDriverControlQCOM glEnableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndPerfMonitorAMD(UInt32 monitor);
            internal static EndPerfMonitorAMD glEndPerfMonitorAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQuery(OpenTK.Graphics.ES30.QueryTarget target);
            internal static EndQuery glEndQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQueryEXT(OpenTK.Graphics.ES30.QueryTarget target);
            internal static EndQueryEXT glEndQueryEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTilingQCOM(UInt32 preserveMask);
            internal static EndTilingQCOM glEndTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES30.All target, [OutAttribute] IntPtr @params);
            internal static ExtGetBufferPointervQCOM glExtGetBufferPointervQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            internal unsafe static ExtGetBuffersQCOM glExtGetBuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            internal unsafe static ExtGetFramebuffersQCOM glExtGetFramebuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES30.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            internal unsafe static ExtGetProgramBinarySourceQCOM glExtGetProgramBinarySourceQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            internal unsafe static ExtGetProgramsQCOM glExtGetProgramsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            internal unsafe static ExtGetRenderbuffersQCOM glExtGetRenderbuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            internal unsafe static ExtGetShadersQCOM glExtGetShadersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES30.All face, Int32 level, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static ExtGetTexLevelParameterivQCOM glExtGetTexLevelParameterivQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES30.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.All format, OpenTK.Graphics.ES30.All type, [OutAttribute] IntPtr texels);
            internal static ExtGetTexSubImageQCOM glExtGetTexSubImageQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            internal unsafe static ExtGetTexturesQCOM glExtGetTexturesQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool ExtIsProgramBinaryQCOM(UInt32 program);
            internal static ExtIsProgramBinaryQCOM glExtIsProgramBinaryQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All pname, Int32 param);
            internal static ExtTexObjectStateOverrideiQCOM glExtTexObjectStateOverrideiQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSync(OpenTK.Graphics.ES30.SyncCondition condition, OpenTK.Graphics.ES30.WaitSyncFlags flags);
            internal static FenceSync glFenceSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES30.SyncCondition condition, OpenTK.Graphics.ES30.WaitSyncFlags flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Finish();
            internal static Finish glFinish;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Flush();
            internal static Flush glFlush;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRange(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferAttachment attachment, OpenTK.Graphics.ES30.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferAttachment attachment, OpenTK.Graphics.ES30.TextureTarget2d textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All attachment, OpenTK.Graphics.ES30.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleEXT glFramebufferTexture2DMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All attachment, OpenTK.Graphics.ES30.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleIMG glFramebufferTexture2DMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture3DOES(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All attachment, OpenTK.Graphics.ES30.All textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3DOES glFramebufferTexture3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTextureLayer(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrontFace(OpenTK.Graphics.ES30.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GenerateMipmap(OpenTK.Graphics.ES30.TextureTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            internal unsafe static GenPerfMonitorsAMD glGenPerfMonitorsAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenProgramPipelinesEXT(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelinesEXT glGenProgramPipelinesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenQueriesEXT(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueriesEXT glGenQueriesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            internal unsafe static GenSamplers glGenSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArrays glGenVertexArrays;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES30.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES30.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.ES30.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.ES30.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteri64v(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferParameterName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointerv(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES30.DebugSourceExternal* sources, [OutAttribute] OpenTK.Graphics.ES30.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES30.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLog glGetDebugMessageLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES30.DebugSourceExternal* sources, [OutAttribute] OpenTK.Graphics.ES30.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES30.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogKHR glGetDebugMessageLogKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            internal unsafe static GetDriverControlsQCOM glGetDriverControlsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            internal unsafe static GetDriverControlStringQCOM glGetDriverControlStringQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES30.ErrorCode GetError();
            internal static GetError glGetError;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);
            internal static GetFragDataLocation glGetFragDataLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferAttachment attachment, OpenTK.Graphics.ES30.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES30.All GetGraphicsResetStatusEXT();
            internal static GetGraphicsResetStatusEXT glGetGraphicsResetStatusEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64i_v(OpenTK.Graphics.ES30.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64v(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64v glGetInteger64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegeri_v(OpenTK.Graphics.ES30.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegeri_vEXT(OpenTK.Graphics.ES30.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_vEXT glGetIntegeri_vEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInternalformativ(OpenTK.Graphics.ES30.ImageTarget target, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, OpenTK.Graphics.ES30.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetInternalformativ glGetInternalformativ;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvEXT glGetnUniformfvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivEXT glGetnUniformivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabel(OpenTK.Graphics.ES30.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabel glGetObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabelEXT(OpenTK.Graphics.ES30.All type, UInt32 @object, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelEXT glGetObjectLabelEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabelKHR(OpenTK.Graphics.ES30.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelKHR glGetObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabel glGetObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabelKHR glGetObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorCounterDataAMD(UInt32 monitor, OpenTK.Graphics.ES30.All pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten);
            internal unsafe static GetPerfMonitorCounterDataAMD glGetPerfMonitorCounterDataAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, OpenTK.Graphics.ES30.All pname, [OutAttribute] IntPtr data);
            internal static GetPerfMonitorCounterInfoAMD glGetPerfMonitorCounterInfoAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters);
            internal unsafe static GetPerfMonitorCountersAMD glGetPerfMonitorCountersAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString);
            internal unsafe static GetPerfMonitorCounterStringAMD glGetPerfMonitorCounterStringAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups);
            internal unsafe static GetPerfMonitorGroupsAMD glGetPerfMonitorGroupsAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString);
            internal unsafe static GetPerfMonitorGroupStringAMD glGetPerfMonitorGroupStringAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointerv(OpenTK.Graphics.ES30.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointervKHR(OpenTK.Graphics.ES30.All pname, [OutAttribute] IntPtr @params);
            internal static GetPointervKHR glGetPointervKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES30.All* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramBinaryOES(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES30.All* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinaryOES glGetProgramBinaryOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.ES30.GetProgramParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLogEXT glGetProgramPipelineInfoLogEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineivEXT(UInt32 pipeline, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineivEXT glGetProgramPipelineivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryiv(OpenTK.Graphics.ES30.QueryTarget target, OpenTK.Graphics.ES30.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryivEXT(OpenTK.Graphics.ES30.QueryTarget target, OpenTK.Graphics.ES30.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryivEXT glGetQueryivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectivEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectivEXT glGetQueryObjectivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectuivEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuivEXT glGetQueryObjectuivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.ES30.RenderbufferTarget target, OpenTK.Graphics.ES30.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.ES30.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.ES30.ShaderType shadertype, OpenTK.Graphics.ES30.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetString(OpenTK.Graphics.ES30.StringName name);
            internal static GetString glGetString;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetStringi(OpenTK.Graphics.ES30.StringNameIndexed name, UInt32 index);
            internal static GetStringi glGetStringi;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSynciv(IntPtr sync, OpenTK.Graphics.ES30.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES30.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.GetTextureParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.GetTextureParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES30.TransformFeedbackType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetTranslatedShaderSourceANGLE glGetTranslatedShaderSourceANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            internal unsafe static GetUniformIndices glGetUniformIndices;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.ES30.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.ES30.All pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.ES30.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.ES30.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Hint(OpenTK.Graphics.ES30.HintTarget target, OpenTK.Graphics.ES30.HintMode mode);
            internal static Hint glHint;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InsertEventMarkerEXT(Int32 length, String marker);
            internal static InsertEventMarkerEXT glInsertEventMarkerEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void InvalidateFramebuffer(OpenTK.Graphics.ES30.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.ES30.FramebufferAttachment* attachments);
            internal unsafe static InvalidateFramebuffer glInvalidateFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void InvalidateSubFramebuffer(OpenTK.Graphics.ES30.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.ES30.FramebufferAttachment* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            internal unsafe static InvalidateSubFramebuffer glInvalidateSubFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES30.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgramPipelineEXT(UInt32 pipeline);
            internal static IsProgramPipelineEXT glIsProgramPipelineEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsQueryEXT(UInt32 id);
            internal static IsQueryEXT glIsQueryEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSampler(UInt32 sampler);
            internal static IsSampler glIsSampler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSync(IntPtr sync);
            internal static IsSync glIsSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSyncAPPLE(IntPtr sync);
            internal static IsSyncAPPLE glIsSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArrayOES(UInt32 array);
            internal static IsVertexArrayOES glIsVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LabelObjectEXT(OpenTK.Graphics.ES30.All type, UInt32 @object, Int32 length, String label);
            internal static LabelObjectEXT glLabelObjectEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferOES(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All access);
            internal static MapBufferOES glMapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRange(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.ES30.BufferAccessMask access);
            internal static MapBufferRange glMapBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length, UInt32 access);
            internal static MapBufferRangeEXT glMapBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabel(OpenTK.Graphics.ES30.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabel glObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabelKHR(OpenTK.Graphics.ES30.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabelKHR glObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabel glObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabelKHR glObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorei(OpenTK.Graphics.ES30.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopDebugGroup();
            internal static PopDebugGroup glPopDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopDebugGroupKHR();
            internal static PopDebugGroupKHR glPopDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopGroupMarkerEXT();
            internal static PopGroupMarkerEXT glPopGroupMarkerEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramBinary(UInt32 program, OpenTK.Graphics.ES30.All binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinary glProgramBinary;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramBinaryOES(UInt32 program, OpenTK.Graphics.ES30.All binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinaryOES glProgramBinaryOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramParameteri(UInt32 program, OpenTK.Graphics.ES30.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteri glProgramParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.ES30.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1fEXT glProgramUniform1fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fvEXT glProgramUniform1fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1iEXT glProgramUniform1iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1ivEXT glProgramUniform1ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1uiEXT glProgramUniform1uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uivEXT glProgramUniform1uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2fEXT glProgramUniform2fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fvEXT glProgramUniform2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2iEXT glProgramUniform2iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2ivEXT glProgramUniform2ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2uiEXT glProgramUniform2uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uivEXT glProgramUniform2uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3fEXT glProgramUniform3fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fvEXT glProgramUniform3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3iEXT glProgramUniform3iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3ivEXT glProgramUniform3ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3uiEXT glProgramUniform3uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uivEXT glProgramUniform3uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4fEXT glProgramUniform4fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fvEXT glProgramUniform4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4iEXT glProgramUniform4iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4ivEXT glProgramUniform4ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4uiEXT glProgramUniform4uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uivEXT glProgramUniform4uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroup(OpenTK.Graphics.ES30.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroup glPushDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroupKHR(OpenTK.Graphics.ES30.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroupKHR glPushDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushGroupMarkerEXT(Int32 length, String marker);
            internal static PushGroupMarkerEXT glPushGroupMarkerEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void QueryCounterEXT(UInt32 id, OpenTK.Graphics.ES30.All target);
            internal static QueryCounterEXT glQueryCounterEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBuffer(OpenTK.Graphics.ES30.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBufferIndexedEXT(OpenTK.Graphics.ES30.All src, Int32 index);
            internal static ReadBufferIndexedEXT glReadBufferIndexedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBufferNV(OpenTK.Graphics.ES30.All mode);
            internal static ReadBufferNV glReadBufferNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES30.All format, OpenTK.Graphics.ES30.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsEXT glReadnPixelsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.ES30.RenderbufferTarget target, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisample(OpenTK.Graphics.ES30.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleANGLE(OpenTK.Graphics.ES30.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleANGLE glRenderbufferStorageMultisampleANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES30.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES30.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES30.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleIMG glRenderbufferStorageMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleNV(OpenTK.Graphics.ES30.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleNV glRenderbufferStorageMultisampleNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Single param);
            internal static SamplerParameterf glSamplerParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Int32 param);
            internal static SamplerParameteri glSamplerParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList);
            internal unsafe static SelectPerfMonitorCountersAMD glSelectPerfMonitorCountersAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES30.All condition);
            internal static SetFenceNV glSetFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.ES30.ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            internal static StartTilingQCOM glStartTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFunc(OpenTK.Graphics.ES30.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.ES30.StencilFace face, OpenTK.Graphics.ES30.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.ES30.StencilFace face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOp(OpenTK.Graphics.ES30.StencilOp fail, OpenTK.Graphics.ES30.StencilOp zfail, OpenTK.Graphics.ES30.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.ES30.StencilFace face, OpenTK.Graphics.ES30.StencilOp sfail, OpenTK.Graphics.ES30.StencilOp dpfail, OpenTK.Graphics.ES30.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES30.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexImage3DOES glTexImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterf(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameteri(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage1DEXT(OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width);
            internal static TexStorage1DEXT glTexStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2D glTexStorage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3D glTexStorage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3DEXT(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3DEXT glTexStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.All format, OpenTK.Graphics.ES30.All type, IntPtr pixels);
            internal static TexSubImage3DOES glTexSubImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width);
            internal static TextureStorage1DEXT glTextureStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static TextureStorage2DEXT glTextureStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TextureStorage3DEXT glTextureStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.ES30.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1ui(Int32 location, UInt32 v0);
            internal static Uniform1ui glUniform1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uiv glUniform1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2ui glUniform2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uiv glUniform2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3ui glUniform3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uiv glUniform3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4ui glUniform4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uiv glUniform4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            internal static UniformBlockBinding glUniformBlockBinding;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fvNV glUniformMatrix2x3fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fvNV glUniformMatrix2x4fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fvNV glUniformMatrix3x2fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fvNV glUniformMatrix3x4fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fvNV glUniformMatrix4x2fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fvNV glUniformMatrix4x3fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBuffer(OpenTK.Graphics.ES30.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES30.BufferTarget target);
            internal static UnmapBufferOES glUnmapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);
            internal static UseProgramStagesEXT glUseProgramStagesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseShaderProgramEXT(OpenTK.Graphics.ES30.All type, UInt32 program);
            internal static UseShaderProgramEXT glUseShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgramPipelineEXT(UInt32 pipeline);
            internal static ValidateProgramPipelineEXT glValidateProgramPipelineEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorANGLE glVertexAttribDivisorANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisorEXT(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorEXT glVertexAttribDivisorEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisorNV(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorNV glVertexAttribDivisorNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES30.VertexAttribIntegerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES30.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WaitSync(IntPtr sync, OpenTK.Graphics.ES30.WaitSyncFlags flags, UInt64 timeout);
            internal static WaitSync glWaitSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WaitSyncAPPLE(IntPtr sync, OpenTK.Graphics.ES30.WaitSyncFlags flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE;
        }
    }
}
