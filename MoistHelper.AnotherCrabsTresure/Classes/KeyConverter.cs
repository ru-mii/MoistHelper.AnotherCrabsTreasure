using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class KeyConverter
{
    internal static int UnityKeyToVirtualKey(int unityKeyCode)
    {
        switch (unityKeyCode)
        {
            case 97: return 0x41;   // 'A'
            case 98: return 0x42;   // 'B'
            case 99: return 0x43;   // 'C'
            case 100: return 0x44;  // 'D'
            case 101: return 0x45;  // 'E'
            case 102: return 0x46;  // 'F'
            case 103: return 0x47;  // 'G'
            case 104: return 0x48;  // 'H'
            case 105: return 0x49;  // 'I'
            case 106: return 0x4A;  // 'J'
            case 107: return 0x4B;  // 'K'
            case 108: return 0x4C;  // 'L'
            case 109: return 0x4D;  // 'M'
            case 110: return 0x4E;  // 'N'
            case 111: return 0x4F;  // 'O'
            case 112: return 0x50;  // 'P'
            case 113: return 0x51;  // 'Q'
            case 114: return 0x52;  // 'R'
            case 115: return 0x53;  // 'S'
            case 116: return 0x54;  // 'T'
            case 117: return 0x55;  // 'U'
            case 118: return 0x56;  // 'V'
            case 119: return 0x57;  // 'W'
            case 120: return 0x58;  // 'X'
            case 121: return 0x59;  // 'Y'
            case 122: return 0x5A;  // 'Z'

            case 48: return 0x30;   // '0'
            case 49: return 0x31;   // '1'
            case 50: return 0x32;   // '2'
            case 51: return 0x33;   // '3'
            case 52: return 0x34;   // '4'
            case 53: return 0x35;   // '5'
            case 54: return 0x36;   // '6'
            case 55: return 0x37;   // '7'
            case 56: return 0x38;   // '8'
            case 57: return 0x39;   // '9'

            case 282: return 0x70;  // F1
            case 283: return 0x71;  // F2
            case 284: return 0x72;  // F3
            case 285: return 0x73;  // F4
            case 286: return 0x74;  // F5
            case 287: return 0x75;  // F6
            case 288: return 0x76;  // F7
            case 289: return 0x77;  // F8
            case 290: return 0x78;  // F9
            case 291: return 0x79;  // F10
            case 292: return 0x7A;  // F11
            case 293: return 0x7B;  // F12

            case 27: return 0x1B;   // Escape
            case 304: return 0xA0;  // Left Shift
            case 303: return 0xA1;  // Right Shift
            case 306: return 0xA2;  // Left Control
            case 305: return 0xA3;  // Right Control
            case 308: return 0xA4;  // Left Alt
            case 307: return 0xA5;  // Right Alt
            case 8: return 0x08;    // Backspace
            case 9: return 0x09;    // Tab
            case 13: return 0x0D;   // Enter
            case 32: return 0x20;   // Space
            case 92: return 0x5C;   // Backslash
            case 47: return 0xBF;   // Forward Slash
            case 45: return 0xBD;   // Minus
            case 61: return 0xBB;   // Equals
            case 91: return 0x5B;   // Left Bracket
            case 93: return 0x5D;   // Right Bracket
            case 59: return 0xBA;   // Semicolon
            case 39: return 0xDE;   // Single Quote
            case 44: return 0xBC;   // Comma
            case 46: return 0xBE;   // Period

            case 273: return 0x26;  // Up Arrow
            case 274: return 0x28;  // Down Arrow
            case 276: return 0x25;  // Left Arrow
            case 275: return 0x27;  // Right Arrow

            case 277: return 0x2D;  // Insert
            case 127: return 0x2E;  // Delete
            case 278: return 0x24;  // Home
            case 279: return 0x23;  // End
            case 280: return 0x21;  // Page Up
            case 281: return 0x22;  // Page Down

            default: return 0;
        }
    }
}
