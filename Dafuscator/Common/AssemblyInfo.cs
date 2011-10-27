using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Dafuscator")]
[assembly: AssemblyDescription("Database Data Obfuscation")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("WaveTech Digital Technologies, Inc.")]
[assembly: AssemblyProduct("Dafuscator")]
[assembly: AssemblyCopyright("Copyright © WaveTech Digital Technologies, Inc. 2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Generators, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Generators.DEMO, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("Dafuscator, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("DafuscatorBatch, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Framework, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Generators, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Model, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Services, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Providers.DatabaseInteractionProvider, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Providers.FileDataProvider, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Providers.ObjectSerializationProvider, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Providers.SymmetricEncryptionProvider, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Providers.TokenReplacementProvider, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.Repositories.DatabaseProjectRepository, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("WaveTech.Dafuscator.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]
[assembly: InternalsVisibleTo("TestHarness, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb6ecf786bb9686313b48ec788e0c831e095937eb8f520db5ad69bf67dc2d4b965fbf73721ac8aafad5b473acba92a815e0c4d6f236166fc87027b1883fdff0d35962875465141236b9f65e6cdf5ffc8a0dc1be0b7b14920bae58cc3e2e036e2038b7045475349588efe753321e485f74393d2de559733149e5a03860bd90fa6")]

[assembly: InternalsVisibleTo("StructureMap, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b0d701ad-d956-45c5-9f51-bee0d10b2725")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.5.1010.2616")] // Rule: *.*.YYMM.DDhh
[assembly: AssemblyFileVersion("0.5.1010.2616")] // Rule: *.*.YYMM.DDhh
