//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CopaceticSoftware.pMixins.CodeGenerator v0.6.0.457
//      for file pMixins\pMixins.Mvc.Recipes\AbstractMixin\AbstractMixin.cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.  
// </auto-generated> 
//------------------------------------------------------------------------------
namespace pMixins.Mvc.Recipes.AbstractMixin
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public partial class AbstractMixinExample : pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.IPrinterMixinRequirements, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin>
	{
		private sealed class __Mixins
		{
			public static global::System.Object ____Lock = new global::System.Object ();
			public __pMixinAutoGenerated.pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin.PrinterMixinMasterWrapper pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin;
			public __Mixins (AbstractMixinExample target)
			{
				pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin.PrinterMixinMasterWrapper> ((pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.IPrinterMixinRequirements)target);
			}
			[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
			[global::System.Diagnostics.DebuggerStepThrough]
			public void __ActivateMixinDependencies (pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample target)
			{
				pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin.__ActivateMixinDependencies (target);
			}
		}
		private sealed class __pMixinAutoGenerated
		{
			public sealed class pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin
			{
				public class PrinterMixinMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public PrinterMixinMasterWrapper (pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.IPrinterMixinRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.PrinterMixinAbstractWrapper> (target);
						NameFuncGet = () => _mixinInstance.Name;
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.PrinterMixinAbstractWrapper _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Func<global::System.String> NameFuncGet {
						get;
						set;
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					internal global::System.String Name {
						get {
							return base.ExecutePropertyGet ("Name", () => NameFuncGet ());
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public global::System.String PrintName ()
					{
						return base.ExecuteMethod ("PrintName", new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.Parameter> {

						}, () => _mixinInstance.PrintName ());
					}
				}
			}
		}
		private __Mixins ____mixins;
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		private __Mixins __mixins {
			get {
				if (null == ____mixins) {
					lock (__Mixins.____Lock) {
						if (null == ____mixins) {
							____mixins = new __Mixins (this);
							____mixins.__ActivateMixinDependencies (this);
						}
					}
				}
				return ____mixins;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin>.MixinInstance {
			get {
				return __mixins.pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[global::System.Diagnostics.DebuggerStepThrough]
		public static implicit operator global::pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin (AbstractMixinExample target) {
			return target.__mixins.pMixins_Mvc_Recipes_AbstractMixin_PrinterMixin._mixinInstance;
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.__Shared
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IPrinterMixinRequirements : global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.__Shared.ISharedRequirements
	{
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::System.String Name {
			get;
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin
{
	public abstract class PrinterMixinProtectedMembersWrapper : global::pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin
	{
		public PrinterMixinProtectedMembersWrapper () : base ()
		{
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin
{
	public class PrinterMixinAbstractWrapper : PrinterMixinProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.IPrinterMixinRequirements _target;
		public PrinterMixinAbstractWrapper (global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.AbstractMixin.AbstractMixinExample.pMixins.Mvc.Recipes.AbstractMixin.PrinterMixin.IPrinterMixinRequirements target) : base ()
		{
			_target = target;
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		public override global::System.String Name {
			get {
				return _target.Name;
			}
		}
	}
}
