﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessWatchdog {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProcessWatchdog.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProcessWatchdog.
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} version {1}.
        /// </summary>
        internal static string Banner {
            get {
                return ResourceManager.GetString("Banner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not take screenshot for process {0}, because this process does not have a UI..
        /// </summary>
        internal static string ErrorCannotTakeScreenshotNoConsoleSession {
            get {
                return ResourceManager.GetString("ErrorCannotTakeScreenshotNoConsoleSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not take screenshot for process {0}..
        /// </summary>
        internal static string ErrorCannotTakeScreenshotUnexpectedError {
            get {
                return ResourceManager.GetString("ErrorCannotTakeScreenshotUnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: {0}.
        /// </summary>
        internal static string ErrorFormat {
            get {
                return ResourceManager.GetString("ErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The polling interval &quot;{0}&quot; is invalid. Please specify a polling interval in milliseconds with a value greater than 0..
        /// </summary>
        internal static string ErrorInvalidPollingInterval {
            get {
                return ResourceManager.GetString("ErrorInvalidPollingInterval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &quot;{0}&quot; is not a valid TimeSpan. {1} Please specify the timeout interval with a string of the form hh:mm[:ss]..
        /// </summary>
        internal static string ErrorInvalidTimeoutInterval {
            get {
                return ResourceManager.GetString("ErrorInvalidTimeoutInterval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process {0} ({1}) exceeded the time limit of {2} and will be terminated..
        /// </summary>
        internal static string ErrorProcessTimedOut {
            get {
                return ResourceManager.GetString("ErrorProcessTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created output folder {0}..
        /// </summary>
        internal static string InfoCreatedOutputFolder {
            get {
                return ResourceManager.GetString("InfoCreatedOutputFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saved screenshot to file {0}..
        /// </summary>
        internal static string InfoSavedScreenshot {
            get {
                return ResourceManager.GetString("InfoSavedScreenshot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Terminating process {0} ({1}) and saving crash dump....
        /// </summary>
        internal static string InfoTerminatingProcess {
            get {
                return ResourceManager.GetString("InfoTerminatingProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process {0} exited successfully after {1}..
        /// </summary>
        internal static string ProcessExited {
            get {
                return ResourceManager.GetString("ProcessExited", resourceCulture);
            }
        }
    }
}
