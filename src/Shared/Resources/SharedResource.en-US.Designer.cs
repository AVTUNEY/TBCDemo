﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shared.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SharedResource_en_US {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SharedResource_en_US() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Shared.Resources.SharedResource_en_US", typeof(SharedResource_en_US).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string StringLengthErrorMessage {
            get {
                return ResourceManager.GetString("StringLengthErrorMessage", resourceCulture);
            }
        }
        
        public static string RequiredErrorMessage {
            get {
                return ResourceManager.GetString("RequiredErrorMessage", resourceCulture);
            }
        }
        
        public static string InvalidCharactersErrorMessage {
            get {
                return ResourceManager.GetString("InvalidCharactersErrorMessage", resourceCulture);
            }
        }
        
        public static string AgeRestrictionErrorMessage {
            get {
                return ResourceManager.GetString("AgeRestrictionErrorMessage", resourceCulture);
            }
        }
        
        public static string PersonalNumberDigitsOnlyErrorMessage {
            get {
                return ResourceManager.GetString("PersonalNumberDigitsOnlyErrorMessage", resourceCulture);
            }
        }
        
        public static string PersonalNumberDigitsNumberErrorMessage {
            get {
                return ResourceManager.GetString("PersonalNumberDigitsNumberErrorMessage", resourceCulture);
            }
        }
        
        public static string InvalidDataTypeForDate {
            get {
                return ResourceManager.GetString("InvalidDataTypeForDate", resourceCulture);
            }
        }
        
        public static string PersonNotFoundErrorMessage {
            get {
                return ResourceManager.GetString("PersonNotFoundErrorMessage", resourceCulture);
            }
        }
        
        public static string DefaultErrorMessage {
            get {
                return ResourceManager.GetString("DefaultErrorMessage", resourceCulture);
            }
        }
    }
}
