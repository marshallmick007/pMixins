//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CopaceticSoftware.pMixins.CodeGenerator v0.6.0.457
//      for file pMixins\pMixins.Mvc.Recipes\NonPublicNonParameterlessConstructor\NonPublicNonParameterlessConstructor.cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.  
// </auto-generated> 
//------------------------------------------------------------------------------
namespace pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public partial class NonPublicNonParameterlessConstructor : pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin.IMixinRequirements, pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin.IAbstractMixinRequirements, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin>, CopaceticSoftware.pMixins.Infrastructure.IMixinConstructorRequirement<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin>, CopaceticSoftware.pMixins.Infrastructure.IMixinConstructorRequirement<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin>
	{
		private sealed class __Mixins
		{
			public static global::System.Object ____Lock = new global::System.Object ();
			public __pMixinAutoGenerated.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin.MixinMasterWrapper pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin;
			public __pMixinAutoGenerated.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin.AbstractMixinMasterWrapper pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin;
			public __Mixins (NonPublicNonParameterlessConstructor target)
			{
				pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin.MixinMasterWrapper> ((pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin.IMixinRequirements)target);
				pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin.AbstractMixinMasterWrapper> ((pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin.IAbstractMixinRequirements)target);
			}
			[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
			[global::System.Diagnostics.DebuggerStepThrough]
			public void __ActivateMixinDependencies (pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor target)
			{
				pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin.__ActivateMixinDependencies (target);
				pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin.__ActivateMixinDependencies (target);
			}
		}
		private sealed class __pMixinAutoGenerated
		{
			public sealed class pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin
			{
				public class MixinMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public MixinMasterWrapper (pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin.IMixinRequirements target)
					{
						_mixinInstance = ((global::CopaceticSoftware.pMixins.Infrastructure.IMixinConstructorRequirement<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin>)target).InitializeMixin ();
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 FavoriteNumber {
						get {
							return base.ExecutePropertyGet ("FavoriteNumber", () => _mixinInstance.FavoriteNumber);
						}
					}
				}
			}
			public sealed class pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin
			{
				public class AbstractMixinMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public AbstractMixinMasterWrapper (pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin.IAbstractMixinRequirements target)
					{
						_mixinInstance = ((global::CopaceticSoftware.pMixins.Infrastructure.IMixinConstructorRequirement<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin>)target).InitializeMixin ();
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 AbstractFavoriteNumber {
						get {
							return base.ExecutePropertyGet ("AbstractFavoriteNumber", () => _mixinInstance.AbstractFavoriteNumber);
						}
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
		global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin>.MixinInstance {
			get {
				return __mixins.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin>.MixinInstance {
			get {
				return __mixins.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[global::System.Diagnostics.DebuggerStepThrough]
		public static implicit operator global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin (NonPublicNonParameterlessConstructor target) {
			return target.__mixins.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_Mixin._mixinInstance;
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[global::System.Diagnostics.DebuggerStepThrough]
		public static implicit operator global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin (NonPublicNonParameterlessConstructor target) {
			return target.__mixins.pMixins_Mvc_Recipes_NonPublicNonParameterlessConstructor_AbstractMixin._mixinInstance;
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.__Shared
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IMixinRequirements : global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin
{
	public abstract class MixinProtectedMembersWrapper : global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin
	{
		public MixinProtectedMembersWrapper () : base ()
		{
		}
		public MixinProtectedMembersWrapper (global::System.Int32 favoriteNumber) : base (favoriteNumber)
		{
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin
{
	public class MixinAbstractWrapper : MixinProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin.IMixinRequirements _target;
		public MixinAbstractWrapper (global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin.IMixinRequirements target) : base ()
		{
			_target = target;
		}
		public MixinAbstractWrapper (global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.Mixin.IMixinRequirements target, global::System.Int32 favoriteNumber) : base (favoriteNumber)
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IAbstractMixinRequirements : global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin
{
	public abstract class AbstractMixinProtectedMembersWrapper : global::pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin
	{
		public AbstractMixinProtectedMembersWrapper (global::System.Int32 favoriteNumber) : base (favoriteNumber)
		{
		}
	}
}
namespace pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin
{
	public class AbstractMixinAbstractWrapper : AbstractMixinProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin.IAbstractMixinRequirements _target;
		public AbstractMixinAbstractWrapper (global::pMixins.AutoGenerated.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.NonPublicNonParameterlessConstructor.pMixins.Mvc.Recipes.NonPublicNonParameterlessConstructor.AbstractMixin.IAbstractMixinRequirements target, global::System.Int32 favoriteNumber) : base (favoriteNumber)
		{
			_target = target;
		}
	}
}
