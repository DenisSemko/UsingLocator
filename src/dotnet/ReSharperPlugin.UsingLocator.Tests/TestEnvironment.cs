using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.UsingLocator.Tests
{
    [ZoneDefinition]
    public class UsingLocatorTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IUsingLocatorZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<UsingLocatorTestEnvironmentZone> { }

    [SetUpFixture]
    public class UsingLocatorTestsAssembly : ExtensionTestEnvironmentAssembly<UsingLocatorTestEnvironmentZone> { }
}
