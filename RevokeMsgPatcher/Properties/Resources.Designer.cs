﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RevokeMsgPatcher.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RevokeMsgPatcher.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 {&quot;Apps&quot;:{&quot;Wechat&quot;:{&quot;Name&quot;:&quot;Wechat&quot;,&quot;FileTargetInfos&quot;:{&quot;WeChatWin.dll&quot;:{&quot;Name&quot;:&quot;WeChatWin.dll&quot;,&quot;RelativePath&quot;:&quot;WeChatWin.dll&quot;,&quot;Memo&quot;:null}},&quot;FileModifyInfos&quot;:{&quot;WeChatWin.dll&quot;:[{&quot;Name&quot;:&quot;WeChatWin.dll&quot;,&quot;Version&quot;:&quot;2.7.1.65&quot;,&quot;SHA1Before&quot;:&quot;8346b97d264725da924d240c6eb77df3e693385e&quot;,&quot;SHA1After&quot;:&quot;42bab2c9c79ef4f2088c00ea6d817973e14a5e6e&quot;,&quot;Changes&quot;:[{&quot;Position&quot;:2495545,&quot;Content&quot;:[235]}]},{&quot;Name&quot;:&quot;WeChatWin.dll&quot;,&quot;Version&quot;:&quot;2.7.1.59&quot;,&quot;SHA1Before&quot;:&quot;df954d403edaca89cd5394927a325a0023e93281&quot;,&quot;SHA1After&quot;:&quot;6aa22460c91bb5c5e [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string PatchJson {
            get {
                return ResourceManager.GetString("PatchJson", resourceCulture);
            }
        }
    }
}