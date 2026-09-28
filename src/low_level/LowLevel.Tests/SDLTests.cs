using OwlDomain.SDL3.LowLevel.Tests.Info;

namespace OwlDomain.SDL3.LowLevel.Tests;

[TestClass]
public sealed class SDLTests
{
	#region Tests
	[DynamicData(nameof(GetNativeFunctions), DynamicDataDisplayName = nameof(GetDisplayName))]
	[TestMethod]
	public void HasExpectedCallingConvention(MethodInfo method)
	{
		UnmanagedCallConvAttribute? attribute = method.GetCustomAttribute<UnmanagedCallConvAttribute>();
		Assert.IsNotNull(attribute, $"The function '{method.Name}' didn't have the '{nameof(UnmanagedCallConvAttribute)}' attribute.");

		Assert.IsNotNull(attribute.CallConvs, $"The function '{method.Name}' didn't have any calling conventions set.");
		Assert.IsNotEmpty(attribute.CallConvs, $"The function '{method.Name}' didn't have any calling conventions set.");

		Assert.Contains(typeof(CallConvCdecl), attribute.CallConvs, $"The function '{method.Name}' didn't have the C declaration calling convention.");
	}

	[DynamicData(nameof(GetNativeFunctions), DynamicDataDisplayName = nameof(GetDisplayName))]
	[TestMethod]
	public void EntryPointExists(MethodInfo method)
	{
		LibraryImportAttribute? attribute = method.GetCustomAttribute<LibraryImportAttribute>();
		Assert.IsNotNull(attribute, $"The function '{method.Name}' didn't have the '{nameof(LibraryImportAttribute)}' attribute.");
		Assert.IsNotNull(attribute.EntryPoint, $"The function '{method.Name}' didn't have an entry point value.");

		if (SDLNameInfo.Names.Functions.ContainsKey(attribute.EntryPoint) is false)
			Assert.Fail($"The function '{method.Name}' had an SDL3 entry point '{attribute.EntryPoint}' which didn't exist.");
	}

	[DynamicData(nameof(GetNativeFunctions), DynamicDataDisplayName = nameof(GetDisplayName))]
	[TestMethod]
	public void FunctionNameMatchesEntryPoint(MethodInfo method)
	{
		LibraryImportAttribute? attribute = method.GetCustomAttribute<LibraryImportAttribute>();
		Assert.IsNotNull(attribute, $"The function '{method.Name}' didn't have the '{nameof(LibraryImportAttribute)}' attribute.");
		Assert.IsNotNull(attribute.EntryPoint, $"The function '{method.Name}' didn't have an entry point value.");

		if (SDLNameInfo.Names.Functions.ContainsKey(attribute.EntryPoint) is false)
			Assert.Inconclusive($"The function '{method.Name}' had an SDL3 entry point '{attribute.EntryPoint}' which didn't exist.");

		if (IsNameSimilarEnough(method.Name, attribute.EntryPoint) is false)
			Assert.Fail($"The function '{method.Name}' had an SDL3 entry point '{attribute.EntryPoint}' which was too different.");
	}

	[DynamicData(nameof(GetNativeFunctions), DynamicDataDisplayName = nameof(GetDisplayName))]
	[TestMethod]
	public void HasExpectedLibraryName(MethodInfo method)
	{
		LibraryImportAttribute? attribute = method.GetCustomAttribute<LibraryImportAttribute>();
		Assert.IsNotNull(attribute, $"The function '{method.Name}' didn't have the '{nameof(LibraryImportAttribute)}' attribute.");
		Assert.IsNotNull(attribute.EntryPoint, $"The function '{method.Name}' didn't have an entry point value.");

		Assert.AreEqual(SDL.LibName, attribute.LibraryName);
	}
	#endregion

	#region Helpers
	[ExcludeFromCodeCoverage(Justification = "Called by testing framework.")]
	public static string GetDisplayName(MethodInfo testMethod, object[] data)
	{
		MethodInfo target = (MethodInfo)data[0];
		return $"{testMethod.Name}({target.Name})";
	}

	[ExcludeFromCodeCoverage(Justification = "Called by testing framework.")]
	private static IEnumerable<TestDataRow<MethodInfo>> GetNativeFunctions()
	{
		Type type = typeof(SDL);
		MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

		foreach (MethodInfo method in methods)
		{
			LibraryImportAttribute? attribute = method.GetCustomAttribute<LibraryImportAttribute>();
			if (attribute is null)
				continue;

			yield return new(method) { DisplayName = method.Name };
		}
	}

	private static bool IsNameSimilarEnough(string functionName, string entryPoint)
	{
		functionName = functionName.Trim('_');

		ReadOnlySpan<string?> checks =
		[
			entryPoint,
			entryPoint.Replace("_", ""),
			entryPoint.StartsWith("SDL_") ? entryPoint["SDL_".Length..] : null,
			entryPoint.StartsWith("SDL_") ? entryPoint["SDL_".Length..].Replace("_", "") : null,
		];

		foreach (string? check in checks)
		{
			if (check is null)
				continue;

			if (functionName == check)
				return true;

			if (functionName.Equals(check, StringComparison.OrdinalIgnoreCase))
				return true;
		}

		return false;
	}
	#endregion
}
