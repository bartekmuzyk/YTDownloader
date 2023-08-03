using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YTDownloader
{
    internal static class Dwm
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        public enum DWMWINDOWATTRIBUTE : uint
        {
            NCRenderingEnabled = 1,
            NCRenderingPolicy,
            TransitionsForceDisabled,
            AllowNCPaint,
            CaptionButtonBounds,
            NonClientRtlLayout,
            ForceIconicRepresentation,
            Flip3DPolicy,
            ExtendedFrameBounds,
            HasIconicBitmap,
            DisallowPeek,
            ExcludedFromPeek,
            Cloak,
            Cloaked,
            FreezeRepresentation,
            PassiveUpdateMode,
            UseHostBackdropBrush,
            UseImmersiveDarkMode = 20,
            WindowCornerPreference = 33,
            BorderColor,
            CaptionColor,
            TextColor,
            VisibleFrameBorderThickness,
            SystemBackdropType,
            Last
        }

        private static MARGINS margins = new()
        {
            leftWidth = 0,
            rightWidth = 0,
            topHeight = 9999,
            bottomHeight = 0,
        };

        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref int attrValue, int attrSize);

        public static void AutoExtendFrameIntoClientArea(IntPtr hwnd)
        {
            _ = DwmExtendFrameIntoClientArea(hwnd, ref margins);
        }

        public static void ApplyMicaBackdropToWindow(IntPtr hwnd)
        {
            int micaBackdropType = 2;
            _ = DwmSetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.SystemBackdropType, ref micaBackdropType, sizeof(int));
        }
    }
}
