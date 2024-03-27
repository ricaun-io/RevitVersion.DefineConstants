namespace RevitVersion.DefineConstants.Sample
{
    public class Revit
    {
#if REVIT2025
        public class Revit2025 { }
#endif
#if REVIT2024
        public class Revit2024 { }
#endif
#if REVIT2023
        public class Revit2023 { }
#endif
#if REVIT2022
        public class Revit2022 { }
#endif
#if REVIT2021
        public class Revit2021 { }
#endif
#if REVIT2020
        public class Revit2020 { }
#endif
#if REVIT2019
        public class Revit2019 { }
#endif
#if REVIT2018
        public class Revit2018 { }
#endif
#if REVIT2017
        public class Revit2017 { }
#endif

#if REVIT2025_OR_GREATER
        public class Revit2025OrGreater { }
#endif
#if REVIT2024_OR_GREATER
        public class Revit2024OrGreater { }
#endif
#if REVIT2023_OR_GREATER
        public class Revit2023OrGreater { }
#endif
#if REVIT2022_OR_GREATER
        public class Revit2022OrGreater { }
#endif
#if REVIT2021_OR_GREATER
        public class Revit2021OrGreater { }
#endif
#if REVIT2020_OR_GREATER
        public class Revit2020OrGreater { }
#endif
#if REVIT2019_OR_GREATER
        public class Revit2019OrGreater { }
#endif
#if REVIT2018_OR_GREATER
        public class Revit2018OrGreater { }
#endif
#if REVIT2017_OR_GREATER
        public class Revit2017OrGreater { }
#endif
    }
#if TEST
    public class Test { }
#endif
#if REVIT_TEST
    public class RevitTest { }
#endif
#if NET2017_OR_GREATER
    public class NetTest { }
#endif
}
