//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  internal partial class DrawingWand : IDisposable
  {
    private static class NativeMethods
    {
      public static class X64
      {
        static X64() { NativeLibraryLoader.Load(); }
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr DrawingWand_Create(IntPtr image, IntPtr settings);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Dispose(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Affine(IntPtr Instance, double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Alpha(IntPtr Instance, double x, double y, UIntPtr paintMethod, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Arc(IntPtr Instance, double startX, double startY, double endX, double endY, double startDegrees, double endDegrees, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Bezier(IntPtr Instance, IntPtr coordinates, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_BorderColor(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Circle(IntPtr Instance, double originX, double originY, double perimeterX, double perimeterY, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_ClipPath(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_ClipRule(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_ClipUnits(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Color(IntPtr Instance, double x, double y, UIntPtr paintMethod, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Composite(IntPtr Instance, double x, double y, double width, double height, UIntPtr compositeOperator, IntPtr image, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Density(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Ellipse(IntPtr Instance, double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillColor(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillOpacity(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillPatternUrl(IntPtr Instance, IntPtr url, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillRule(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Font(IntPtr Instance, IntPtr family, UIntPtr style, UIntPtr weight, UIntPtr stretch, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FontPointSize(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Gravity(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Line(IntPtr Instance, double startX, double startY, double endX, double endY, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathArcAbs(IntPtr Instance, double x, double y, double radiusX, double radiusY, double rotationX, [MarshalAs(UnmanagedType.Bool)] bool useLargeArc, [MarshalAs(UnmanagedType.Bool)] bool useSweep, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathArcRel(IntPtr Instance, double x, double y, double radiusX, double radiusY, double rotationX, [MarshalAs(UnmanagedType.Bool)] bool useLargeArc, [MarshalAs(UnmanagedType.Bool)] bool useSweep, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Render(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Text(IntPtr Instance, double x, double y, IntPtr text, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathClose(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathCurveToAbs(IntPtr Instance, double x1, double y1, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathCurveToRel(IntPtr Instance, double x1, double y1, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathFinish(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToAbs(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToRel(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToHorizontalAbs(IntPtr Instance, double x, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToHorizontalRel(IntPtr Instance, double x, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToVerticalAbs(IntPtr Instance, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToVerticalRel(IntPtr Instance, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathMoveToAbs(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathMoveToRel(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathQuadraticCurveToAbs(IntPtr Instance, double x1, double y1, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathQuadraticCurveToRel(IntPtr Instance, double x1, double y1, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothCurveToAbs(IntPtr Instance, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothCurveToRel(IntPtr Instance, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothQuadraticCurveToAbs(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothQuadraticCurveToRel(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathStart(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Point(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Polygon(IntPtr Instance, IntPtr coordinates, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Polyline(IntPtr Instance, IntPtr coordinates, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PopClipPath(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PopGraphicContext(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PopPattern(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PushClipPath(IntPtr Instance, IntPtr clipPath, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PushGraphicContext(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PushPattern(IntPtr Instance, IntPtr id, double x, double y, double width, double height, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Rectangle(IntPtr Instance, double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Rotation(IntPtr Instance, double angle, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_RoundRectangle(IntPtr Instance, double centerX, double centerY, double width, double height, double cornerWidth, double cornerHeight, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Scaling(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_SkewX(IntPtr Instance, double angle, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_SkewY(IntPtr Instance, double angle, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeAntialias(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool isEnabled, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeColor(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeDashArray(IntPtr Instance, double[] dash, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeDashOffset(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeLineCap(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeLineJoin(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeMiterLimit(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeOpacity(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokePatternUrl(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeWidth(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextAlignment(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextAntialias(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool isEnabled, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextDecoration(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextDirection(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextEncoding(IntPtr Instance, IntPtr encoding, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextInterlineSpacing(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextInterwordSpacing(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextKerning(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextUnderColor(IntPtr Instance, IntPtr color, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Translation(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Viewbox(IntPtr Instance, double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, out IntPtr exception);
      }
      public static class X86
      {
        static X86() { NativeLibraryLoader.Load(); }
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr DrawingWand_Create(IntPtr image, IntPtr settings);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Dispose(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Affine(IntPtr Instance, double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Alpha(IntPtr Instance, double x, double y, UIntPtr paintMethod, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Arc(IntPtr Instance, double startX, double startY, double endX, double endY, double startDegrees, double endDegrees, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Bezier(IntPtr Instance, IntPtr coordinates, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_BorderColor(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Circle(IntPtr Instance, double originX, double originY, double perimeterX, double perimeterY, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_ClipPath(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_ClipRule(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_ClipUnits(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Color(IntPtr Instance, double x, double y, UIntPtr paintMethod, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Composite(IntPtr Instance, double x, double y, double width, double height, UIntPtr compositeOperator, IntPtr image, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Density(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Ellipse(IntPtr Instance, double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillColor(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillOpacity(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillPatternUrl(IntPtr Instance, IntPtr url, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FillRule(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Font(IntPtr Instance, IntPtr family, UIntPtr style, UIntPtr weight, UIntPtr stretch, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_FontPointSize(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Gravity(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Line(IntPtr Instance, double startX, double startY, double endX, double endY, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathArcAbs(IntPtr Instance, double x, double y, double radiusX, double radiusY, double rotationX, [MarshalAs(UnmanagedType.Bool)] bool useLargeArc, [MarshalAs(UnmanagedType.Bool)] bool useSweep, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathArcRel(IntPtr Instance, double x, double y, double radiusX, double radiusY, double rotationX, [MarshalAs(UnmanagedType.Bool)] bool useLargeArc, [MarshalAs(UnmanagedType.Bool)] bool useSweep, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Render(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Text(IntPtr Instance, double x, double y, IntPtr text, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathClose(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathCurveToAbs(IntPtr Instance, double x1, double y1, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathCurveToRel(IntPtr Instance, double x1, double y1, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathFinish(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToAbs(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToRel(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToHorizontalAbs(IntPtr Instance, double x, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToHorizontalRel(IntPtr Instance, double x, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToVerticalAbs(IntPtr Instance, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathLineToVerticalRel(IntPtr Instance, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathMoveToAbs(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathMoveToRel(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathQuadraticCurveToAbs(IntPtr Instance, double x1, double y1, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathQuadraticCurveToRel(IntPtr Instance, double x1, double y1, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothCurveToAbs(IntPtr Instance, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothCurveToRel(IntPtr Instance, double x2, double y2, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothQuadraticCurveToAbs(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathSmoothQuadraticCurveToRel(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PathStart(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Point(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Polygon(IntPtr Instance, IntPtr coordinates, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Polyline(IntPtr Instance, IntPtr coordinates, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PopClipPath(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PopGraphicContext(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PopPattern(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PushClipPath(IntPtr Instance, IntPtr clipPath, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PushGraphicContext(IntPtr Instance, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_PushPattern(IntPtr Instance, IntPtr id, double x, double y, double width, double height, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Rectangle(IntPtr Instance, double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Rotation(IntPtr Instance, double angle, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_RoundRectangle(IntPtr Instance, double centerX, double centerY, double width, double height, double cornerWidth, double cornerHeight, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Scaling(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_SkewX(IntPtr Instance, double angle, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_SkewY(IntPtr Instance, double angle, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeAntialias(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool isEnabled, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeColor(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeDashArray(IntPtr Instance, double[] dash, UIntPtr length, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeDashOffset(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeLineCap(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeLineJoin(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeMiterLimit(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeOpacity(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokePatternUrl(IntPtr Instance, IntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_StrokeWidth(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextAlignment(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextAntialias(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool isEnabled, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextDecoration(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextDirection(IntPtr Instance, UIntPtr value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextEncoding(IntPtr Instance, IntPtr encoding, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextInterlineSpacing(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextInterwordSpacing(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextKerning(IntPtr Instance, double value, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_TextUnderColor(IntPtr Instance, IntPtr color, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Translation(IntPtr Instance, double x, double y, out IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawingWand_Viewbox(IntPtr Instance, double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, out IntPtr exception);
      }
    }
    private NativeDrawingWand _NativeInstance;
    private sealed class NativeDrawingWand : NativeInstance
    {
      private IntPtr _Instance = IntPtr.Zero;
      protected override void Dispose(IntPtr instance)
      {
        DisposeInstance(instance);
      }
      public static void DisposeInstance(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Dispose(instance);
        else
          NativeMethods.X86.DrawingWand_Dispose(instance);
      }
      public NativeDrawingWand(MagickImage image, DrawingSettings settings)
      {
        using (INativeInstance settingsNative = DrawingSettings.CreateInstance(settings))
        {
          if (NativeLibrary.Is64Bit)
            _Instance = NativeMethods.X64.DrawingWand_Create(MagickImage.GetInstance(image), settingsNative.Instance);
          else
            _Instance = NativeMethods.X86.DrawingWand_Create(MagickImage.GetInstance(image), settingsNative.Instance);
          if (_Instance == IntPtr.Zero)
            throw new InvalidOperationException();
        }
      }
      public override IntPtr Instance
      {
        get
        {
          if (_Instance == IntPtr.Zero)
            throw new ObjectDisposedException(typeof(DrawingWand).ToString());
          return _Instance;
        }
        set
        {
          if (_Instance != IntPtr.Zero)
            Dispose(_Instance);
          _Instance = value;
        }
      }
      public void Affine(double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Affine(Instance, scaleX, scaleY, shearX, shearY, translateX, translateY, out exception);
        else
          NativeMethods.X86.DrawingWand_Affine(Instance, scaleX, scaleY, shearX, shearY, translateX, translateY, out exception);
        CheckException(exception);
      }
      public void Alpha(double x, double y, PaintMethod paintMethod)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Alpha(Instance, x, y, (UIntPtr)paintMethod, out exception);
        else
          NativeMethods.X86.DrawingWand_Alpha(Instance, x, y, (UIntPtr)paintMethod, out exception);
        CheckException(exception);
      }
      public void Arc(double startX, double startY, double endX, double endY, double startDegrees, double endDegrees)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Arc(Instance, startX, startY, endX, endY, startDegrees, endDegrees, out exception);
        else
          NativeMethods.X86.DrawingWand_Arc(Instance, startX, startY, endX, endY, startDegrees, endDegrees, out exception);
        CheckException(exception);
      }
      public void Bezier(PointInfoCollection coordinates, int length)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Bezier(Instance, PointInfoCollection.GetInstance(coordinates), (UIntPtr)length, out exception);
        else
          NativeMethods.X86.DrawingWand_Bezier(Instance, PointInfoCollection.GetInstance(coordinates), (UIntPtr)length, out exception);
        CheckException(exception);
      }
      public void BorderColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_BorderColor(Instance, valueNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_BorderColor(Instance, valueNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void Circle(double originX, double originY, double perimeterX, double perimeterY)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Circle(Instance, originX, originY, perimeterX, perimeterY, out exception);
        else
          NativeMethods.X86.DrawingWand_Circle(Instance, originX, originY, perimeterX, perimeterY, out exception);
        CheckException(exception);
      }
      public void ClipPath(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_ClipPath(Instance, valueNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_ClipPath(Instance, valueNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void ClipRule(FillRule value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_ClipRule(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_ClipRule(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void ClipUnits(ClipPathUnit value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_ClipUnits(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_ClipUnits(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void Color(double x, double y, PaintMethod paintMethod)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Color(Instance, x, y, (UIntPtr)paintMethod, out exception);
        else
          NativeMethods.X86.DrawingWand_Color(Instance, x, y, (UIntPtr)paintMethod, out exception);
        CheckException(exception);
      }
      public void Composite(double x, double y, double width, double height, CompositeOperator compositeOperator, MagickImage image)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Composite(Instance, x, y, width, height, (UIntPtr)compositeOperator, MagickImage.GetInstance(image), out exception);
        else
          NativeMethods.X86.DrawingWand_Composite(Instance, x, y, width, height, (UIntPtr)compositeOperator, MagickImage.GetInstance(image), out exception);
        CheckException(exception);
      }
      public void Density(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_Density(Instance, valueNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_Density(Instance, valueNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void Ellipse(double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Ellipse(Instance, originX, originY, radiusX, radiusY, startDegrees, endDegrees, out exception);
        else
          NativeMethods.X86.DrawingWand_Ellipse(Instance, originX, originY, radiusX, radiusY, startDegrees, endDegrees, out exception);
        CheckException(exception);
      }
      public void FillColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_FillColor(Instance, valueNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_FillColor(Instance, valueNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void FillOpacity(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_FillOpacity(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_FillOpacity(Instance, value, out exception);
        CheckException(exception);
      }
      public void FillPatternUrl(string url)
      {
        using (INativeInstance urlNative = UTF8Marshaler.CreateInstance(url))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_FillPatternUrl(Instance, urlNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_FillPatternUrl(Instance, urlNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void FillRule(FillRule value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_FillRule(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_FillRule(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void Font(string family, FontStyleType style, FontWeight weight, FontStretch stretch)
      {
        using (INativeInstance familyNative = UTF8Marshaler.CreateInstance(family))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_Font(Instance, familyNative.Instance, (UIntPtr)style, (UIntPtr)weight, (UIntPtr)stretch, out exception);
          else
            NativeMethods.X86.DrawingWand_Font(Instance, familyNative.Instance, (UIntPtr)style, (UIntPtr)weight, (UIntPtr)stretch, out exception);
          CheckException(exception);
        }
      }
      public void FontPointSize(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_FontPointSize(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_FontPointSize(Instance, value, out exception);
        CheckException(exception);
      }
      public void Gravity(Gravity value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Gravity(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_Gravity(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void Line(double startX, double startY, double endX, double endY)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Line(Instance, startX, startY, endX, endY, out exception);
        else
          NativeMethods.X86.DrawingWand_Line(Instance, startX, startY, endX, endY, out exception);
        CheckException(exception);
      }
      public void PathArcAbs(double x, double y, double radiusX, double radiusY, double rotationX, bool useLargeArc, bool useSweep)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathArcAbs(Instance, x, y, radiusX, radiusY, rotationX, useLargeArc, useSweep, out exception);
        else
          NativeMethods.X86.DrawingWand_PathArcAbs(Instance, x, y, radiusX, radiusY, rotationX, useLargeArc, useSweep, out exception);
        CheckException(exception);
      }
      public void PathArcRel(double x, double y, double radiusX, double radiusY, double rotationX, bool useLargeArc, bool useSweep)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathArcRel(Instance, x, y, radiusX, radiusY, rotationX, useLargeArc, useSweep, out exception);
        else
          NativeMethods.X86.DrawingWand_PathArcRel(Instance, x, y, radiusX, radiusY, rotationX, useLargeArc, useSweep, out exception);
        CheckException(exception);
      }
      public void Render()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Render(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_Render(Instance, out exception);
        CheckException(exception);
      }
      public void Text(double x, double y, string text)
      {
        using (INativeInstance textNative = UTF8Marshaler.CreateInstance(text))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_Text(Instance, x, y, textNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_Text(Instance, x, y, textNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void PathClose()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathClose(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PathClose(Instance, out exception);
        CheckException(exception);
      }
      public void PathCurveToAbs(double x1, double y1, double x2, double y2, double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathCurveToAbs(Instance, x1, y1, x2, y2, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathCurveToAbs(Instance, x1, y1, x2, y2, x, y, out exception);
        CheckException(exception);
      }
      public void PathCurveToRel(double x1, double y1, double x2, double y2, double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathCurveToRel(Instance, x1, y1, x2, y2, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathCurveToRel(Instance, x1, y1, x2, y2, x, y, out exception);
        CheckException(exception);
      }
      public void PathFinish()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathFinish(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PathFinish(Instance, out exception);
        CheckException(exception);
      }
      public void PathLineToAbs(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathLineToAbs(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathLineToAbs(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void PathLineToRel(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathLineToRel(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathLineToRel(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void PathLineToHorizontalAbs(double x)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathLineToHorizontalAbs(Instance, x, out exception);
        else
          NativeMethods.X86.DrawingWand_PathLineToHorizontalAbs(Instance, x, out exception);
        CheckException(exception);
      }
      public void PathLineToHorizontalRel(double x)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathLineToHorizontalRel(Instance, x, out exception);
        else
          NativeMethods.X86.DrawingWand_PathLineToHorizontalRel(Instance, x, out exception);
        CheckException(exception);
      }
      public void PathLineToVerticalAbs(double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathLineToVerticalAbs(Instance, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathLineToVerticalAbs(Instance, y, out exception);
        CheckException(exception);
      }
      public void PathLineToVerticalRel(double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathLineToVerticalRel(Instance, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathLineToVerticalRel(Instance, y, out exception);
        CheckException(exception);
      }
      public void PathMoveToAbs(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathMoveToAbs(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathMoveToAbs(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void PathMoveToRel(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathMoveToRel(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathMoveToRel(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void PathQuadraticCurveToAbs(double x1, double y1, double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathQuadraticCurveToAbs(Instance, x1, y1, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathQuadraticCurveToAbs(Instance, x1, y1, x, y, out exception);
        CheckException(exception);
      }
      public void PathQuadraticCurveToRel(double x1, double y1, double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathQuadraticCurveToRel(Instance, x1, y1, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathQuadraticCurveToRel(Instance, x1, y1, x, y, out exception);
        CheckException(exception);
      }
      public void PathSmoothCurveToAbs(double x2, double y2, double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathSmoothCurveToAbs(Instance, x2, y2, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathSmoothCurveToAbs(Instance, x2, y2, x, y, out exception);
        CheckException(exception);
      }
      public void PathSmoothCurveToRel(double x2, double y2, double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathSmoothCurveToRel(Instance, x2, y2, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathSmoothCurveToRel(Instance, x2, y2, x, y, out exception);
        CheckException(exception);
      }
      public void PathSmoothQuadraticCurveToAbs(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathSmoothQuadraticCurveToAbs(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathSmoothQuadraticCurveToAbs(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void PathSmoothQuadraticCurveToRel(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathSmoothQuadraticCurveToRel(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_PathSmoothQuadraticCurveToRel(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void PathStart()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PathStart(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PathStart(Instance, out exception);
        CheckException(exception);
      }
      public void Point(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Point(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_Point(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void Polygon(PointInfoCollection coordinates, int length)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Polygon(Instance, PointInfoCollection.GetInstance(coordinates), (UIntPtr)length, out exception);
        else
          NativeMethods.X86.DrawingWand_Polygon(Instance, PointInfoCollection.GetInstance(coordinates), (UIntPtr)length, out exception);
        CheckException(exception);
      }
      public void Polyline(PointInfoCollection coordinates, int length)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Polyline(Instance, PointInfoCollection.GetInstance(coordinates), (UIntPtr)length, out exception);
        else
          NativeMethods.X86.DrawingWand_Polyline(Instance, PointInfoCollection.GetInstance(coordinates), (UIntPtr)length, out exception);
        CheckException(exception);
      }
      public void PopClipPath()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PopClipPath(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PopClipPath(Instance, out exception);
        CheckException(exception);
      }
      public void PopGraphicContext()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PopGraphicContext(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PopGraphicContext(Instance, out exception);
        CheckException(exception);
      }
      public void PopPattern()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PopPattern(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PopPattern(Instance, out exception);
        CheckException(exception);
      }
      public void PushClipPath(string clipPath)
      {
        using (INativeInstance clipPathNative = UTF8Marshaler.CreateInstance(clipPath))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_PushClipPath(Instance, clipPathNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_PushClipPath(Instance, clipPathNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void PushGraphicContext()
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_PushGraphicContext(Instance, out exception);
        else
          NativeMethods.X86.DrawingWand_PushGraphicContext(Instance, out exception);
        CheckException(exception);
      }
      public void PushPattern(string id, double x, double y, double width, double height)
      {
        using (INativeInstance idNative = UTF8Marshaler.CreateInstance(id))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_PushPattern(Instance, idNative.Instance, x, y, width, height, out exception);
          else
            NativeMethods.X86.DrawingWand_PushPattern(Instance, idNative.Instance, x, y, width, height, out exception);
          CheckException(exception);
        }
      }
      public void Rectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Rectangle(Instance, upperLeftX, upperLeftY, lowerRightX, lowerRightY, out exception);
        else
          NativeMethods.X86.DrawingWand_Rectangle(Instance, upperLeftX, upperLeftY, lowerRightX, lowerRightY, out exception);
        CheckException(exception);
      }
      public void Rotation(double angle)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Rotation(Instance, angle, out exception);
        else
          NativeMethods.X86.DrawingWand_Rotation(Instance, angle, out exception);
        CheckException(exception);
      }
      public void RoundRectangle(double centerX, double centerY, double width, double height, double cornerWidth, double cornerHeight)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_RoundRectangle(Instance, centerX, centerY, width, height, cornerWidth, cornerHeight, out exception);
        else
          NativeMethods.X86.DrawingWand_RoundRectangle(Instance, centerX, centerY, width, height, cornerWidth, cornerHeight, out exception);
        CheckException(exception);
      }
      public void Scaling(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Scaling(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_Scaling(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void SkewX(double angle)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_SkewX(Instance, angle, out exception);
        else
          NativeMethods.X86.DrawingWand_SkewX(Instance, angle, out exception);
        CheckException(exception);
      }
      public void SkewY(double angle)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_SkewY(Instance, angle, out exception);
        else
          NativeMethods.X86.DrawingWand_SkewY(Instance, angle, out exception);
        CheckException(exception);
      }
      public void StrokeAntialias(bool isEnabled)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeAntialias(Instance, isEnabled, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeAntialias(Instance, isEnabled, out exception);
        CheckException(exception);
      }
      public void StrokeColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_StrokeColor(Instance, valueNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_StrokeColor(Instance, valueNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void StrokeDashArray(double[] dash, int length)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeDashArray(Instance, dash, (UIntPtr)length, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeDashArray(Instance, dash, (UIntPtr)length, out exception);
        CheckException(exception);
      }
      public void StrokeDashOffset(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeDashOffset(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeDashOffset(Instance, value, out exception);
        CheckException(exception);
      }
      public void StrokeLineCap(LineCap value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeLineCap(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeLineCap(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void StrokeLineJoin(LineJoin value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeLineJoin(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeLineJoin(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void StrokeMiterLimit(int value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeMiterLimit(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeMiterLimit(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void StrokeOpacity(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeOpacity(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeOpacity(Instance, value, out exception);
        CheckException(exception);
      }
      public void StrokePatternUrl(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_StrokePatternUrl(Instance, valueNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_StrokePatternUrl(Instance, valueNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void StrokeWidth(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_StrokeWidth(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_StrokeWidth(Instance, value, out exception);
        CheckException(exception);
      }
      public void TextAlignment(TextAlignment value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextAlignment(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_TextAlignment(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void TextAntialias(bool isEnabled)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextAntialias(Instance, isEnabled, out exception);
        else
          NativeMethods.X86.DrawingWand_TextAntialias(Instance, isEnabled, out exception);
        CheckException(exception);
      }
      public void TextDecoration(TextDecoration value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextDecoration(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_TextDecoration(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void TextDirection(TextDirection value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextDirection(Instance, (UIntPtr)value, out exception);
        else
          NativeMethods.X86.DrawingWand_TextDirection(Instance, (UIntPtr)value, out exception);
        CheckException(exception);
      }
      public void TextEncoding(string encoding)
      {
        using (INativeInstance encodingNative = UTF8Marshaler.CreateInstance(encoding))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_TextEncoding(Instance, encodingNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_TextEncoding(Instance, encodingNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void TextInterlineSpacing(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextInterlineSpacing(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_TextInterlineSpacing(Instance, value, out exception);
        CheckException(exception);
      }
      public void TextInterwordSpacing(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextInterwordSpacing(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_TextInterwordSpacing(Instance, value, out exception);
        CheckException(exception);
      }
      public void TextKerning(double value)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_TextKerning(Instance, value, out exception);
        else
          NativeMethods.X86.DrawingWand_TextKerning(Instance, value, out exception);
        CheckException(exception);
      }
      public void TextUnderColor(MagickColor color)
      {
        using (INativeInstance colorNative = MagickColor.CreateInstance(color))
        {
          IntPtr exception = IntPtr.Zero;
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.DrawingWand_TextUnderColor(Instance, colorNative.Instance, out exception);
          else
            NativeMethods.X86.DrawingWand_TextUnderColor(Instance, colorNative.Instance, out exception);
          CheckException(exception);
        }
      }
      public void Translation(double x, double y)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Translation(Instance, x, y, out exception);
        else
          NativeMethods.X86.DrawingWand_Translation(Instance, x, y, out exception);
        CheckException(exception);
      }
      public void Viewbox(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
      {
        IntPtr exception = IntPtr.Zero;
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.DrawingWand_Viewbox(Instance, upperLeftX, upperLeftY, lowerRightX, lowerRightY, out exception);
        else
          NativeMethods.X86.DrawingWand_Viewbox(Instance, upperLeftX, upperLeftY, lowerRightX, lowerRightY, out exception);
        CheckException(exception);
      }
    }
    internal static IntPtr GetInstance(DrawingWand instance)
    {
      if (instance == null)
        return IntPtr.Zero;
      return instance._NativeInstance.Instance;
    }
  }
}
