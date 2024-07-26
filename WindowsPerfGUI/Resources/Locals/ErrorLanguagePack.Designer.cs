﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsPerfGUI.Resources.Locals {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorLanguagePack {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorLanguagePack() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WindowsPerfGUI.Resources.Locals.ErrorLanguagePack", typeof(ErrorLanguagePack).Assembly);
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
        ///   Looks up a localized string similar to WindowsPerf Error.
        /// </summary>
        public static string ErrorWindowsPerfCLI {
            get {
                return ResourceManager.GetString("ErrorWindowsPerfCLI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To start counting you need to have at least an event or a metric selected, as well as at least one core selected!.
        /// </summary>
        public static string IncompleteCountingSettingsLine1 {
            get {
                return ResourceManager.GetString("IncompleteCountingSettingsLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To start sampling you need to have at least the executable file path and the event name as well as the core selected!.
        /// </summary>
        public static string IncompleteSamplingSettingsLine1 {
            get {
                return ResourceManager.GetString("IncompleteSamplingSettingsLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This version of the extention was built to only support WindowsPerf version {0}!.
        /// </summary>
        public static string MinimumVersionMismatch {
            get {
                return ResourceManager.GetString("MinimumVersionMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to bypass this check, please go to Tools -&gt; Options -&gt; WindowsPerf -&gt; WindowsPerf Path and check the &apos;Ignore WindowsPerf version check&apos; checkbox..
        /// </summary>
        public static string MinimumVersionMismatchLine2 {
            get {
                return ResourceManager.GetString("MinimumVersionMismatchLine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WidnowsPerf is not initialized please follow the initialization steps.
        /// </summary>
        public static string NotInititiatedWperfErrorLine1 {
            get {
                return ResourceManager.GetString("NotInititiatedWperfErrorLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To do so go to Tools -&gt; Options -&gt; WindowsPerf -&gt; Wperf Path.
        /// </summary>
        public static string NotInititiatedWperfErrorLine2 {
            get {
                return ResourceManager.GetString("NotInititiatedWperfErrorLine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No results were returned from WindowsPerf.
        /// </summary>
        public static string NoWindowsPerfCliData {
            get {
                return ResourceManager.GetString("NoWindowsPerfCliData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Badly formatted raw event.
        ///Please specify raw events with r&lt;VALUE&gt; where &lt;VALUE&gt; is a 16-bit hexadecimal event index value without leading 0x.
        ///For example r10 is event with index 0x10.
        /// </summary>
        public static string RawEventBadFormat {
            get {
                return ResourceManager.GetString("RawEventBadFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Raw event already exists. Please enter a different event..
        /// </summary>
        public static string RawEventExists {
            get {
                return ResourceManager.GetString("RawEventExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WindowsPerf is currently counting.
        /// </summary>
        public static string RunningCountingOverlapLine1 {
            get {
                return ResourceManager.GetString("RunningCountingOverlapLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait for the current counting to finish before starting another counting instance.
        /// </summary>
        public static string RunningCountingOverlapLine2 {
            get {
                return ResourceManager.GetString("RunningCountingOverlapLine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WindowsPerf is currently sampling.
        /// </summary>
        public static string RunningSamplingOverlapLine1 {
            get {
                return ResourceManager.GetString("RunningSamplingOverlapLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait for the current sampling to finish before starting another sampling instance.
        /// </summary>
        public static string RunningSamplingOverlapLine2 {
            get {
                return ResourceManager.GetString("RunningSamplingOverlapLine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error starting wperf process. Please double check your wperf path..
        /// </summary>
        public static string WperfPathChanged {
            get {
                return ResourceManager.GetString("WperfPathChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WindowsPerf is not available at the indicated path or not initialized.
        /// </summary>
        public static string WperfUnavailable {
            get {
                return ResourceManager.GetString("WperfUnavailable", resourceCulture);
            }
        }
    }
}
