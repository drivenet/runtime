// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// THIS IS AUTOGENERATED FILE CREATED BY
// https://github.com/dotnet/buildtools/blob/6736870b84e06b75e7df32bb84d442db1b2afa10/src/Microsoft.DotNet.Build.Tasks/PackageFiles/encoding.targets

namespace System.Text
{
    internal static partial class EncodingTable
    {
        //
        // EncodingNames is the concatenation of all supported IANA names for each codepage.
        // This is done rather than using a large readonly array of strings to avoid
        // generating a large amount of code in the static constructor.
        // Using indices from EncodingNamesIndices, we binary search this string when mapping
        // an encoding name to a codepage. Note that these names are all lowercase and are
        // sorted alphabetically.
        //
        private const string EncodingNames =
            "ansi_x3.4-1968" + // 20127
            "ansi_x3.4-1986" + // 20127
            "ascii" + // 20127
            "cp367" + // 20127
            "cp819" + // 28591
            "csascii" + // 20127
            "csisolatin1" + // 28591
            "csunicode11utf7" + // 65000
            "ibm367" + // 20127
            "ibm819" + // 28591
            "iso-10646-ucs-2" + // 1200
            "iso-8859-1" + // 28591
            "iso-ir-100" + // 28591
            "iso-ir-6" + // 20127
            "iso646-us" + // 20127
            "iso8859-1" + // 28591
            "iso_646.irv:1991" + // 20127
            "iso_8859-1" + // 28591
            "iso_8859-1:1987" + // 28591
            "l1" + // 28591
            "latin1" + // 28591
            "ucs-2" + // 1200
            "unicode" + // 1200
            "unicode-1-1-utf-7" + // 65000
            "unicode-1-1-utf-8" + // 65001
            "unicode-2-0-utf-7" + // 65000
            "unicode-2-0-utf-8" + // 65001
            "unicodefffe" + // 1201
            "us" + // 20127
            "us-ascii" + // 20127
            "utf-16" + // 1200
            "utf-16be" + // 1201
            "utf-16le" + // 1200
            "utf-32" + // 12000
            "utf-32be" + // 12001
            "utf-32le" + // 12000
            "utf-7" + // 65000
            "utf-8" + // 65001
            "x-unicode-1-1-utf-7" + // 65000
            "x-unicode-1-1-utf-8" + // 65001
            "x-unicode-2-0-utf-7" + // 65000
            "x-unicode-2-0-utf-8"; // 65001

        //
        // EncodingNameIndices contains the start index of every encoding name in the string
        // EncodingNames. We infer the length of each string by looking at the start index
        // of the next string.
        //
        private static ReadOnlySpan<int> EncodingNameIndices => new int[]
        {
            0, // ansi_x3.4-1968 (20127)
            14, // ansi_x3.4-1986 (20127)
            28, // ascii (20127)
            33, // cp367 (20127)
            38, // cp819 (28591)
            43, // csascii (20127)
            50, // csisolatin1 (28591)
            61, // csunicode11utf7 (65000)
            76, // ibm367 (20127)
            82, // ibm819 (28591)
            88, // iso-10646-ucs-2 (1200)
            103, // iso-8859-1 (28591)
            113, // iso-ir-100 (28591)
            123, // iso-ir-6 (20127)
            131, // iso646-us (20127)
            140, // iso8859-1 (28591)
            149, // iso_646.irv:1991 (20127)
            165, // iso_8859-1 (28591)
            175, // iso_8859-1:1987 (28591)
            190, // l1 (28591)
            192, // latin1 (28591)
            198, // ucs-2 (1200)
            203, // unicode (1200)
            210, // unicode-1-1-utf-7 (65000)
            227, // unicode-1-1-utf-8 (65001)
            244, // unicode-2-0-utf-7 (65000)
            261, // unicode-2-0-utf-8 (65001)
            278, // unicodefffe (1201)
            289, // us (20127)
            291, // us-ascii (20127)
            299, // utf-16 (1200)
            305, // utf-16be (1201)
            313, // utf-16le (1200)
            321, // utf-32 (12000)
            327, // utf-32be (12001)
            335, // utf-32le (12000)
            343, // utf-7 (65000)
            348, // utf-8 (65001)
            353, // x-unicode-1-1-utf-7 (65000)
            372, // x-unicode-1-1-utf-8 (65001)
            391, // x-unicode-2-0-utf-7 (65000)
            410, // x-unicode-2-0-utf-8 (65001)
            429
        };

        //
        // CodePagesByName contains the list of supported codepages which match the encoding
        // names listed in EncodingNames. The way mapping works is we binary search
        // EncodingNames using EncodingNamesIndices until we find a match for a given name.
        // The index of the entry in EncodingNamesIndices will be the index of codepage in
        // CodePagesByName.
        //
        private static ReadOnlySpan<ushort> CodePagesByName => new ushort[]
        {
            20127, // ansi_x3.4-1968
            20127, // ansi_x3.4-1986
            20127, // ascii
            20127, // cp367
            28591, // cp819
            20127, // csascii
            28591, // csisolatin1
            65000, // csunicode11utf7
            20127, // ibm367
            28591, // ibm819
            1200, // iso-10646-ucs-2
            28591, // iso-8859-1
            28591, // iso-ir-100
            20127, // iso-ir-6
            20127, // iso646-us
            28591, // iso8859-1
            20127, // iso_646.irv:1991
            28591, // iso_8859-1
            28591, // iso_8859-1:1987
            28591, // l1
            28591, // latin1
            1200, // ucs-2
            1200, // unicode
            65000, // unicode-1-1-utf-7
            65001, // unicode-1-1-utf-8
            65000, // unicode-2-0-utf-7
            65001, // unicode-2-0-utf-8
            1201, // unicodefffe
            20127, // us
            20127, // us-ascii
            1200, // utf-16
            1201, // utf-16be
            1200, // utf-16le
            12000, // utf-32
            12001, // utf-32be
            12000, // utf-32le
            65000, // utf-7
            65001, // utf-8
            65000, // x-unicode-1-1-utf-7
            65001, // x-unicode-1-1-utf-8
            65000, // x-unicode-2-0-utf-7
            65001 // x-unicode-2-0-utf-8
        };

        //
        // When retrieving the value for System.Text.Encoding.WebName or
        // System.Text.Encoding.EncodingName given System.Text.Encoding.CodePage,
        // we perform a linear search on MappedCodePages to find the index of the
        // given codepage. This is used to index WebNameIndices to get the start
        // index of the web name in the string WebNames, and to index
        // EnglishNameIndices to get the start of the English name in
        // EnglishNames. In addition, this arrays indices correspond to the indices
        // into UiFamilyCodePages and Flags.
        //
        private static ReadOnlySpan<ushort> MappedCodePages => new ushort[]
        {
            1200, // utf-16
            1201, // utf-16be
            12000, // utf-32
            12001, // utf-32be
            20127, // us-ascii
            28591, // iso-8859-1
            65000, // utf-7
            65001 // utf-8
        };

        //
        // UiFamilyCodePages is indexed by the corresponding index in MappedCodePages.
        //
        private static ReadOnlySpan<int> UiFamilyCodePages => new int[]
        {
            1200,
            1200,
            1200,
            1200,
            1252,
            1252,
            1200,
            1200
        };

        //
        // WebNames is a concatenation of the default encoding names
        // for each code page. It is used in retrieving the value for
        // System.Text.Encoding.WebName given System.Text.Encoding.CodePage.
        // This is done rather than using a large readonly array of strings to avoid
        // generating a large amount of code in the static constructor.
        //
        private const string WebNames =
            "utf-16" + // 1200
            "utf-16BE" + // 1201
            "utf-32" + // 12000
            "utf-32BE" + // 12001
            "us-ascii" + // 20127
            "iso-8859-1" + // 28591
            "utf-7" + // 65000
            "utf-8"; // 65001

        //
        // WebNameIndices contains the start index of each code page's default
        // web name in the string WebNames. It is indexed by an index into
        // MappedCodePages.
        //
        private static ReadOnlySpan<int> WebNameIndices => new int[]
        {
            0, // utf-16 (1200)
            6, // utf-16be (1201)
            14, // utf-32 (12000)
            20, // utf-32be (12001)
            28, // us-ascii (20127)
            36, // iso-8859-1 (28591)
            46, // utf-7 (65000)
            51, // utf-8 (65001)
            56
        };

        //
        // EnglishNames is the concatenation of the English names for each codepage.
        // It is used in retrieving the value for System.Text.Encoding.EncodingName
        // given System.Text.Encoding.CodePage.
        // This is done rather than using a large readonly array of strings to avoid
        // generating a large amount of code in the static constructor.
        //
        private const string EnglishNames =
            "Unicode" + // 1200
            "Unicode (Big-Endian)" + // 1201
            "Unicode (UTF-32)" + // 12000
            "Unicode (UTF-32 Big-Endian)" + // 12001
            "US-ASCII" + // 20127
            "Western European (ISO)" + // 28591
            "Unicode (UTF-7)" + // 65000
            "Unicode (UTF-8)"; // 65001

        //
        // EnglishNameIndices contains the start index of each code page's English
        // name in the string EnglishNames. It is indexed by an index into
        // MappedCodePages.
        //
        private static ReadOnlySpan<int> EnglishNameIndices => new int[]
        {
            0, // Unicode (1200)
            7, // Unicode (Big-Endian) (1201)
            27, // Unicode (UTF-32) (12000)
            43, // Unicode (UTF-32 Big-Endian) (12001)
            70, // US-ASCII (20127)
            78, // Western European (ISO) (28591)
            100, // Unicode (UTF-7) (65000)
            115, // Unicode (UTF-8) (65001)
            130
        };

        // redeclaring these constants here for readability below
        private const uint MIMECONTF_MAILNEWS = Encoding.MIMECONTF_MAILNEWS;
        private const uint MIMECONTF_BROWSER = Encoding.MIMECONTF_BROWSER;
        private const uint MIMECONTF_SAVABLE_MAILNEWS = Encoding.MIMECONTF_SAVABLE_MAILNEWS;
        private const uint MIMECONTF_SAVABLE_BROWSER = Encoding.MIMECONTF_SAVABLE_BROWSER;

        // Flags is indexed by the corresponding index in MappedCodePages.
        private static ReadOnlySpan<uint> Flags => new uint[]
        {
            MIMECONTF_SAVABLE_BROWSER,
            0,
            0,
            0,
            MIMECONTF_MAILNEWS | MIMECONTF_SAVABLE_MAILNEWS,
            MIMECONTF_MAILNEWS | MIMECONTF_BROWSER | MIMECONTF_SAVABLE_MAILNEWS | MIMECONTF_SAVABLE_BROWSER,
            MIMECONTF_MAILNEWS | MIMECONTF_SAVABLE_MAILNEWS,
            MIMECONTF_MAILNEWS | MIMECONTF_BROWSER | MIMECONTF_SAVABLE_MAILNEWS | MIMECONTF_SAVABLE_BROWSER
        };
    }
}
