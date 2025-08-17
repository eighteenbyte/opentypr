using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opentypr.Modules
{
    internal class AdvancedTextBox : RichTextBox
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct STRUCT_RECT
        {
            public Int32 left;
            public Int32 top;
            public Int32 right;
            public Int32 bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct STRUCT_CHARRANGE
        {
            public Int32 cpMin;
            public Int32 cpMax;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct STRUCT_FORMATRANGE
        {
            public IntPtr hdc;
            public IntPtr hdcTarget;
            public STRUCT_RECT rc;
            public STRUCT_RECT rcPage;
            public STRUCT_CHARRANGE chrg;
        }

        #region BULLETING

        [StructLayout(LayoutKind.Sequential)]
        private class PARAFORMAT2
        {
            public int cbSize;
            public int dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x20)]
            public int[] rgxTabs;

            public int dySpaceBefore; 	// Vertical spacing before para
            public int dySpaceAfter; 	// Vertical spacing after para
            public int dyLineSpacing; 	// Line spacing depending on Rule
            public short sStyle; 		// Style handle
            public byte bLineSpacingRule; 	// Rule for line spacing (see tom.doc)
            public byte bOutlineLevel; 	// Outline Level
            public short wShadingWeight; 	// Shading in hundredths of a per cent
            public short wShadingStyle; 	// Byte 0: style, nib 2: cfpat, 3: cbpat
            public short wNumberingStart; 	// Starting value for numbering
            public short wNumberingStyle; 	// Alignment, Roman/Arabic, (), ), ., etc.
            public short wNumberingTab; 	// Space bet 1st indent and 1st-line text
            public short wBorderSpace; 	// Border-text spaces (nbl/bdr in pts)
            public short wBorderWidth; 	// Pen widths (nbl/bdr in half twips)
            public short wBorders; 		// Border styles (nibble/border)

            public PARAFORMAT2()
            {
                this.cbSize = Marshal.SizeOf(typeof(PARAFORMAT2));
            }
        }

        #region PARAFORMAT MASK VALUES
        // PARAFORMAT mask values
        private const uint PFM_STARTINDENT = 0x00000001;
        private const uint PFM_RIGHTINDENT = 0x00000002;
        private const uint PFM_OFFSET = 0x00000004;
        private const uint PFM_ALIGNMENT = 0x00000008;
        private const uint PFM_TABSTOPS = 0x00000010;
        private const uint PFM_NUMBERING = 0x00000020;
        private const uint PFM_OFFSETINDENT = 0x80000000;

        // PARAFORMAT 2.0 masks and effects
        private const uint PFM_SPACEBEFORE = 0x00000040;
        private const uint PFM_SPACEAFTER = 0x00000080;
        private const uint PFM_LINESPACING = 0x00000100;
        private const uint PFM_STYLE = 0x00000400;
        private const uint PFM_BORDER = 0x00000800; // (*)
        private const uint PFM_SHADING = 0x00001000; // (*)
        private const uint PFM_NUMBERINGSTYLE = 0x00002000; // RE 3.0
        private const uint PFM_NUMBERINGTAB = 0x00004000; // RE 3.0
        private const uint PFM_NUMBERINGSTART = 0x00008000; // RE 3.0

        private const uint PFM_RTLPARA = 0x00010000;
        private const uint PFM_KEEP = 0x00020000; 		// (*)
        private const uint PFM_KEEPNEXT = 0x00040000; 		// (*)
        private const uint PFM_PAGEBREAKBEFORE = 0x00080000; 	// (*)
        private const uint PFM_NOLINENUMBER = 0x00100000; 	// (*)
        private const uint PFM_NOWIDOWCONTROL = 0x00200000; 	// (*)
        private const uint PFM_DONOTHYPHEN = 0x00400000; 	// (*)
        private const uint PFM_SIDEBYSIDE = 0x00800000; 	// (*)
        private const uint PFM_TABLE = 0x40000000; 		// RE 3.0
        private const uint PFM_TEXTWRAPPINGBREAK = 0x20000000; 	// RE 3.0
        private const uint PFM_TABLEROWDELIMITER = 0x10000000; 	// RE 4.0

        // The following three properties are read only
        private const uint PFM_COLLAPSED = 0x01000000; 	// RE 3.0
        private const uint PFM_OUTLINELEVEL = 0x02000000; 	// RE 3.0
        private const uint PFM_BOX = 0x04000000; 		// RE 3.0
        private const uint PFM_RESERVED2 = 0x08000000; 	// RE 4.0

        public enum AdvRichTextBulletType
        {
            Normal = 1,
            Number = 2,
            LowerCaseLetter = 3,
            UpperCaseLetter = 4,
            LowerCaseRoman = 5,
            UpperCaseRoman = 6
        }

        public enum AdvRichTextBulletStyle
        {
            RightParenthesis = 0x000,
            DoubleParenthesis = 0x100,
            Period = 0x200,
            Plain = 0x300,
            NoNumber = 0x400
        }
        #endregion

        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam,
           [In, Out, MarshalAs(UnmanagedType.LPStruct)] PARAFORMAT2 lParam);

        private AdvRichTextBulletType _BulletType = AdvRichTextBulletType.Number;
        private AdvRichTextBulletStyle _BulletStyle = AdvRichTextBulletStyle.Period;
        private short _BulletNumberStart = 1;

        public AdvRichTextBulletType BulletType
        {
            get { return _BulletType; }
            set
            {
                _BulletType = value;
                NumberedBullet(true);
            }
        }
        public AdvRichTextBulletStyle BulletStyle
        {
            get { return _BulletStyle; }
            set
            {
                _BulletStyle = value;
                NumberedBullet(true);
            }
        }
        public void NumberedBullet(bool TurnOn)
        {
            PARAFORMAT2 paraformat1 = new PARAFORMAT2();
            paraformat1.dwMask = (int)(PFM_NUMBERING | PFM_OFFSET | PFM_NUMBERINGSTART |
                PFM_NUMBERINGSTYLE | PFM_NUMBERINGTAB);
            if (!TurnOn)
            {
                paraformat1.wNumbering = 0;
                paraformat1.dxOffset = 0;
            }
            else
            {
                paraformat1.wNumbering = (short)_BulletType;
                paraformat1.dxOffset = this.BulletIndent;
                paraformat1.wNumberingStyle = (short)_BulletStyle;
                paraformat1.wNumberingStart = _BulletNumberStart;
                paraformat1.wNumberingTab = 500;
            }
            SendMessage(new System.Runtime.InteropServices.HandleRef(this, this.Handle),
                0x447, 0, paraformat1);
        }

        #endregion

        [DllImport("user32.dll")]
        private static extern Int32 SendMessage(IntPtr hWnd, Int32 msg, Int32 wParam, IntPtr lParam);

        private const Int32 WM_USER = 0x400;
        private const Int32 EM_FORMATRANGE = WM_USER + 57;
        private const Int32 EM_GETCHARFORMAT = WM_USER + 58;
        private const Int32 EM_SETCHARFORMAT = WM_USER + 68;

        /// <summary>
        /// Calculate or render the contents of our RichTextBox for printing
        /// </summary>
        /// <param name="measureOnly">If true, only the calculation is performed, otherwise the text is rendered as well</param>
        /// <param name="e">The PrintPageEventArgs object from the PrintPage event</param>
        /// <param name="charFrom">Index of first character to be printed</param>
        /// <param name="charTo">Index of last character to be printed</param>
        /// <returns> (Index of last character that fitted on the page) + 1</returns>
        public int FormatRange(bool measureOnly, PrintPageEventArgs e, int charFrom, int charTo)
        {
            // Specify which characters to print
            STRUCT_CHARRANGE cr = default(STRUCT_CHARRANGE);
            cr.cpMin = charFrom;
            cr.cpMax = charTo;

            // Specify the area inside page margins
            STRUCT_RECT rc = default(STRUCT_RECT);
            rc.top = HundredthInchToTwips(e.MarginBounds.Top);
            rc.bottom = HundredthInchToTwips(e.MarginBounds.Bottom);
            rc.left = HundredthInchToTwips(e.MarginBounds.Left);
            rc.right = HundredthInchToTwips(e.MarginBounds.Right);

            // Specify the page area
            STRUCT_RECT rcPage = default(STRUCT_RECT);
            rcPage.top = HundredthInchToTwips(e.PageBounds.Top);
            rcPage.bottom = HundredthInchToTwips(e.PageBounds.Bottom);
            rcPage.left = HundredthInchToTwips(e.PageBounds.Left);
            rcPage.right = HundredthInchToTwips(e.PageBounds.Right);

            // Get device context of output device
            IntPtr hdc = default(IntPtr);
            hdc = e.Graphics.GetHdc();

            // Fill in the FORMATRANGE structure
            STRUCT_FORMATRANGE fr = default(STRUCT_FORMATRANGE);
            fr.chrg = cr;
            fr.hdc = hdc;
            fr.hdcTarget = hdc;
            fr.rc = rc;
            fr.rcPage = rcPage;

            // Non-Zero wParam means render, Zero means measure
            Int32 wParam = default(Int32);
            if (measureOnly)
            {
                wParam = 0;
            }
            else
            {
                wParam = 1;
            }

            // Allocate memory for the FORMATRANGE struct and
            // copy the contents of our struct to this memory
            IntPtr lParam = default(IntPtr);
            lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fr));
            Marshal.StructureToPtr(fr, lParam, false);

            // Send the actual Win32 message
            int res = 0;
            res = SendMessage(Handle, EM_FORMATRANGE, wParam, lParam);

            // Free allocated memory
            Marshal.FreeCoTaskMem(lParam);

            // and release the device context
            e.Graphics.ReleaseHdc(hdc);

            return res;
        }

        /// <summary>
        /// Convert between 1/100 inch (unit used by the .NET framework)
        /// and twips (1/1440 inch, used by Win32 API calls)
        /// </summary>
        /// <param name="n">Value in 1/100 inch</param>
        /// <returns>Value in twips</returns>
        private Int32 HundredthInchToTwips(int n)
        {
            return Convert.ToInt32(n * 14.4);
        }

        /// <summary>
        /// Free cached data from rich edit control after printing
        /// </summary>
        public void FormatRangeDone()
        {
            IntPtr lParam = new IntPtr(0);
            SendMessage(Handle, EM_FORMATRANGE, 0, lParam);
        }
    }
}