        public static void PrintAssemblyInformation(Assembly assembly)
        {
            Console.WriteLine("Assembly information for {0}", assembly.FullName);
            Console.WriteLine("\tCode Base: {0}", assembly.CodeBase);
            Console.WriteLine("\tCompany: {0}", assembly.GetName().Company);
            Console.WriteLine("\tConfiguration: {0}", assembly.GetName().Configuration);
            Console.WriteLine("\tCopyright: {0}", assembly.GetName().Copyright);
            Console.WriteLine("\tCulture: {0}", assembly.GetName().CultureName);
            Console.WriteLine("\tEscaped Code Base: {0}", assembly.EscapedCodeBase);
            Console.WriteLine("\tEvidence: {0}", assembly.Evidence);
            Console.WriteLine("\tFlags: {0}", assembly.GetName().Flags);
            Console.WriteLine("\tFullyQualifiedName: {0}", assembly.GetName().FullName);
            Console.WriteLine("\tGlobalAssemblyCache: {0}", assembly.GlobalAssemblyCache);
            Console.WriteLine("\tHostContext: {0}", assembly.HostContext);
            Console.WriteLine("\tImageRuntimeVersion: {0}", assembly.ImageRuntimeVersion);
            Console.WriteLine("\tIsCollectible: {0}", assembly.IsCollectible);
            Console.WriteLine("\tIsDynamic: {0}", assembly.IsDynamic);
            Console.WriteLine("\tIsFullyTrusted: {0}", assembly.IsFullyTrusted);
            Console.WriteLine("\tIsRetargetable: {0}", assembly.IsRetargetable);
            Console.WriteLine("\tLocation: {0}", assembly.Location);
            Console.WriteLine("\tManifestModule: {0}", assembly.ManifestModule);
            Console.WriteLine("\tModules: {0}", assembly.GetModules().Length);
            Console.WriteLine("\tProcessorArchitecture: {0}", assembly.GetName().ProcessorArchitecture);
            Console.WriteLine("\tProduct: {0}", assembly.GetName().Product);
            Console.WriteLine("\tProductVersion: {0}", assembly.GetName().ProductVersion);
            Console.WriteLine("\tReflectionOnly: {0}", assembly.ReflectionOnly);
            Console.WriteLine("\tSecurityRuleSet: {0}", assembly.SecurityRuleSet);
            Console.WriteLine("\tStrongName: {0}", assembly.GetName().GetPublicKey());
            Console.WriteLine("\tTitle: {0}", assembly.GetName().Name);
            Console.WriteLine("\tVersion: {0}", assembly.GetName().Version);
        }  
