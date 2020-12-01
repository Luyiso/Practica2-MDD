#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"UPM_IPS")]
[assembly: AssemblyProduct(@"DCMLRACPGProyectoIPS")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"UPM_IPS.DCMLRACPGProyectoIPS.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100A542B694BE8A9AEEBE1F84EBB56BF2267E098728C5B228C7C9FEE068177737FD58A02DE6FA1834EBA1B80E3F1A160CB2635812C3891058D4601A2219569B2AD031027DE0769BECEA3773C78A0CD7F89D90161085451C774E6C6E91AAF8A5F0444377A50406A80BF66142B4ACEBC7ABFEB3B4A2D7F918F895562628B5FC50BFBA")]