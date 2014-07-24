﻿//----------------------------------------------------------------------- 
// <copyright file="CreateMixinLevelAutoGeneratedContainerClassTypeDeclaration.cs" company="Copacetic Software"> 
// Copyright (c) Copacetic Software.  
// <author>Philip Pittle</author> 
// <date>Wednesday, July 23, 2014 2:06:46 PM</date> 
// Licensed under the Apache License, Version 2.0,
// you may not use this file except in compliance with this License.
//  
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an 'AS IS' BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright> 
//-----------------------------------------------------------------------

using System;
using CopaceticSoftware.CodeGenerator.StarterKit.Extensions;
using CopaceticSoftware.Common.Patterns;
using CopaceticSoftware.pMixins.CodeGenerator.Infrastructure;
using CopaceticSoftware.pMixins.CodeGenerator.Pipelines.GenerateCodeBehind.Pipelines.TargetLevelCodeGenerator;
using CopaceticSoftware.pMixins.CodeGenerator.Pipelines.GenerateCodeBehind.Pipelines.TargetLevelCodeGenerator.Steps.CreateTypeDeclarations;
using ICSharpCode.NRefactory.CSharp;

namespace CopaceticSoftware.pMixins.CodeGenerator.Pipelines.GenerateCodeBehind.Pipelines.MixinLevelCodeGenerator.Steps.CreateTypeDeclarations
{
    /// <summary>
    /// Generates a container class for Auto Generated wrapper classes inside
    /// <see cref="TargetLevelCodeGeneratorPipelineState.GlobalAutoGeneratedContainerClass"/>)
    /// code-behind class:
    /// <code>
    /// <![CDATA[
    /// //created in CreateGlobalAutoGeneratedContainerClass
    /// private sealed class __pMixinAutoGenerated
    /// {
    ///    //created here (CreateMixinLevelAutoGeneratedContainerClass)
    ///    //Container for Mixin global::Namespace.MixinName
    ///    public sealed class Namespace_MixinName{}
    /// }    
    /// ]]>
    /// </code>
    /// </summary>
    /// <remarks>
    /// Saves the <see cref="TypeDeclaration"/> in 
    /// <see cref="MixinLevelCodeGeneratorPipelineState.MixinAutoGeneratedContainerClass"/>
    /// </remarks>
    /// <remarks>
    /// Must be called after
    /// <see cref="CreateGlobalAutoGeneratedContainerClass"/>
    /// </remarks>
    public class CreateMixinLevelAutoGeneratedContainerClass : IPipelineStep<MixinLevelCodeGeneratorPipelineState>
    {
        public bool PerformTask(MixinLevelCodeGeneratorPipelineState manager)
        {
            var className =
                manager.MixinGenerationPlan.MixinAttribute.Mixin
                    .GetFullNameAsIdentifier()
                    .Replace(".", "_");

            //Create class
            var autoGeneratedContainer = new TypeDeclaration
            {
                ClassType = ClassType.Class,
                Modifiers = Modifiers.Private | Modifiers.Sealed,
                Name = className,
            };

            //Add class to Target's Code Behind
            new CodeGeneratorProxy(
                manager.TargetLevelCodeGeneratorPipelineState.GlobalAutoGeneratedContainerClass, "")
                .AddNestedType(autoGeneratedContainer);

            //Save the class
            manager.MixinAutoGeneratedContainerClass = autoGeneratedContainer;

            return true;
        }
    }
}
