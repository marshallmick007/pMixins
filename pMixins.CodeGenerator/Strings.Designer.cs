﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopaceticSoftware.pMixins.CodeGenerator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CopaceticSoftware.pMixins.CodeGenerator.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //------------------------------------------------------------------------------
        ///// &lt;auto-generated&gt;
        /////     This code was generated by {0}
        /////      for file {1}.
        /////
        /////     Changes to this file may cause incorrect behavior and will be lost if 
        /////     the code is regenerated.  
        ///// &lt;/auto-generated&gt; 
        /////------------------------------------------------------------------------------
        ///.
        /// </summary>
        public static string AutoGeneratedCommentHeaderFormat {
            get {
                return ResourceManager.GetString("AutoGeneratedCommentHeaderFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interceptor [{0}] is not a concrete class..
        /// </summary>
        public static string ErrorInterceptorMustBeConcreteClass {
            get {
                return ResourceManager.GetString("ErrorInterceptorMustBeConcreteClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interceptor [{0}] does not implement {1}..
        /// </summary>
        public static string ErrorInterceptorMustImplementIMixinIntercetpor {
            get {
                return ResourceManager.GetString("ErrorInterceptorMustImplementIMixinIntercetpor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mixin [{0}] is an interface or struct. Mixins must be a class..
        /// </summary>
        public static string ErrorMixinCanNotBeInterfaceOrStruct {
            get {
                return ResourceManager.GetString("ErrorMixinCanNotBeInterfaceOrStruct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve Mixin type [{0}].  Please make sure all class files have been saved.  If you continue to receive this error try rebuilding the solution..
        /// </summary>
        public static string ErrorMixinCouldNotBeResolved {
            get {
                return ResourceManager.GetString("ErrorMixinCouldNotBeResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not mixin [{0}] into [{1}].  [{0}] has a dependency on [{2}] (via IMixinDependency&lt;{2}&gt;) which is not satisified by [{1}].  [{1}] must either inherit from [{2}] or mix in a class that does..
        /// </summary>
        public static string ErrorMixinDependencyIsClassAndIsNotSatisified {
            get {
                return ResourceManager.GetString("ErrorMixinDependencyIsClassAndIsNotSatisified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mixin [{0}] is both Abstract and a Nested Type.  .
        /// </summary>
        public static string ErrorMixinIsNestedAndAbstract {
            get {
                return ResourceManager.GetString("ErrorMixinIsNestedAndAbstract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required Field [Mixin] is not defined..
        /// </summary>
        public static string ErrorMixinTypeIsNotSpecified {
            get {
                return ResourceManager.GetString("ErrorMixinTypeIsNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code Generator Pipeline can not execute when source file has errors.  Correct any errors and re-run Code Generator..
        /// </summary>
        public static string ErrorSourceFileHasErrors {
            get {
                return ResourceManager.GetString("ErrorSourceFileHasErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Mixin [{0}] {1} [{2}] could not be resolved.  Are you missing an assembly reference?.
        /// </summary>
        public static string ErrorTypeInMixinMemberCouldNotBeResolved {
            get {
                return ResourceManager.GetString("ErrorTypeInMixinMemberCouldNotBeResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project at [{0}] has not been parsed or could not be found..
        /// </summary>
        public static string ExceptionCouldNotFindProjectWithFullName {
            get {
                return ResourceManager.GetString("ExceptionCouldNotFindProjectWithFullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed adding Data Member [{0}] because the class already contains a Data Member with that name.
        /// </summary>
        public static string ExceptionCreateDataMemberFailedBecauseClassAlreadyContainsDataMemberName {
            get {
                return ResourceManager.GetString("ExceptionCreateDataMemberFailedBecauseClassAlreadyContainsDataMemberName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed adding method because the class already contains a method matching the signature {0}({1}).
        /// </summary>
        public static string ExceptionCreateMethodFailedBecauseClassAlreadyContainsMethodSignature {
            get {
                return ResourceManager.GetString("ExceptionCreateMethodFailedBecauseClassAlreadyContainsMethodSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create {0} in Code Generator Proxy because the following code failed to parse [{1}].
        /// </summary>
        public static string ExceptionParsingCodeInCodeGeneratorProxy {
            get {
                return ResourceManager.GetString("ExceptionParsingCodeInCodeGeneratorProxy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code Generation is Disabled for Project because a DisableCodeGeneration Attribute is present in Project [{0}].
        /// </summary>
        public static string MessageDisableCodeGenerationAttributePresentInAssembly {
            get {
                return ResourceManager.GetString("MessageDisableCodeGenerationAttributePresentInAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code Generation is Disabled for Class because a DisableCodeGeneration Attribute is present on Class [{0}].
        /// </summary>
        public static string MessageDisableCodeGenerationAttributePresentOnClass {
            get {
                return ResourceManager.GetString("MessageDisableCodeGenerationAttributePresentOnClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to Resolve Class: {0}.
        /// </summary>
        public static string WarningFailedToResolveClass {
            get {
                return ResourceManager.GetString("WarningFailedToResolveClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Partial class definition found in source file.  Code Generation can only be performed on Partial classes..
        /// </summary>
        public static string WarningNoPartialClassInSourceFile {
            get {
                return ResourceManager.GetString("WarningNoPartialClassInSourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File is configured to use the pMixin Code Generator but it hasn&apos;t made use of a pMixin Attributes.  See the pMixin documentation for more information on how to use the framework..
        /// </summary>
        public static string WarningNopMixinAttributeInFile {
            get {
                return ResourceManager.GetString("WarningNopMixinAttributeInFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class [{0}] must be partial in order to use pMixin.
        /// </summary>
        public static string WarningpMixinAttributeOnNonPartialClass {
            get {
                return ResourceManager.GetString("WarningpMixinAttributeOnNonPartialClass", resourceCulture);
            }
        }
    }
}
