using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("BIDS Helper")]
[assembly: AssemblyDescription("Provides additional useful features to SQL Server Data Tools (formerly known as BI Development Studio)")]
[assembly: AssemblyCompany("http://bidshelper.codeplex.com/")]
[assembly: AssemblyCopyright("Copyright � 2015 BIDS Helper")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.7.0.0")]
[assembly: AssemblyFileVersion("1.7.0.0")]

[assembly: ComVisible(true)]
[assembly: CLSCompliant(false)]
[assembly: NeutralResourcesLanguage("en-US")]

#if SQL2014
[assembly: AssemblyTitle("BIDS Helper for SQL Server 2014")]
#elif DENALI
[assembly: AssemblyTitle("BIDS Helper for SQL Server 2012")]
#elif KATMAI
[assembly: AssemblyTitle("BIDS Helper for SQL Server 2008")]
#else
[assembly: AssemblyTitle("BIDS Helper for SQL Server 2005")]
#endif

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
