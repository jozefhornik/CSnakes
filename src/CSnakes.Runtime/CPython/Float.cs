﻿using System.Runtime.InteropServices;

namespace CSnakes.Runtime.CPython;

internal unsafe partial class CPythonAPI
{
    private static nint PyFloatType = IntPtr.Zero;

    [LibraryImport(PythonLibraryName)]
    internal static partial nint PyFloat_FromDouble(double v);


    [LibraryImport(PythonLibraryName)]
    internal static partial double PyFloat_AsDouble(nint p);

    internal static bool IsPyFloat(nint p)
    {
        return ((PyObjectStruct*)p)->Type() == PyFloatType;
    }
}
