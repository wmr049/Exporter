﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExportImplementation {
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
    public class Templates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Templates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExportImplementation.Templates", typeof(Templates).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;?mso-application progid=&quot;Excel.Sheet&quot;?&gt;
        ///&lt;Workbook xmlns=&quot;urn:schemas-microsoft-com:office:spreadsheet&quot;
        ///xmlns:o=&quot;urn:schemas-microsoft-com:office:office&quot;
        ///xmlns:x=&quot;urn:schemas-microsoft-com:office:excel&quot;
        ///xmlns:ss=&quot;urn:schemas-microsoft-com:office:spreadsheet&quot;
        ///xmlns:html=&quot;http://www.w3.org/TR/REC-html40&quot;&gt;
        ///&lt;DocumentProperties xmlns=&quot;urn:schemas-microsoft-com:office:office&quot;&gt;
        /// &lt;Author&gt;Andrei Ignat&lt;/Author&gt;
        /// &lt;LastAuthor&gt;Andrei Ignat&lt;/LastAuthor&gt;
        /// &lt;Created&gt;$DateCreated;format=&quot;yyyy- [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Excel2003File {
            get {
                return ResourceManager.GetString("Excel2003File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Row&gt;
        ///@foreach(var item in Model){
        ///   &lt;Cell ss:StyleID=&apos;s21&apos;&gt;&lt;Data ss:Type=&apos;String&apos;&gt;@System.Security.SecurityElement.Escape(item)&lt;/Data&gt;&lt;/Cell&gt;
        ///} 
        ///&lt;/Row&gt;.
        /// </summary>
        public static string Excel2003Header {
            get {
                return ResourceManager.GetString("Excel2003Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Row&gt;
        ///@foreach(var item in Model){	
        ///   &lt;Cell&gt;&lt;Data ss:Type=&apos;String&apos;&gt;@@System.Security.SecurityElement.Escape((((object)Model.@item) ?? &quot;&quot;).ToString())&lt;/Data&gt;&lt;/Cell&gt;
        ///}&lt;/Row&gt;.
        /// </summary>
        public static string Excel2003Item {
            get {
                return ResourceManager.GetString("Excel2003Item", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Worksheet ss:Name=&quot;Model.NameOfT&quot;&gt;
        /// &lt;Table  x:FullColumns=&quot;1&quot;
        ///  x:FullRows=&quot;1&quot;&gt;
        ///@Include(Model.NameOfT+&quot;Excel2003Header&quot;)
        ///@foreach(var item in Model.Data){
        ///  @Include(Model.NameOfT+&quot;Excel2003Item&quot;,item)
        ///} 
        /// &lt;/Table&gt;
        /// &lt;WorksheetOptions xmlns=&quot;urn:schemas-microsoft-com:office:excel&quot;&gt;
        ///  &lt;Print&gt;
        ///   &lt;ValidPrinterInfo/&gt;
        ///   &lt;PaperSizeIndex&gt;9&lt;/PaperSizeIndex&gt;
        ///   &lt;HorizontalResolution&gt;600&lt;/HorizontalResolution&gt;
        ///   &lt;VerticalResolution&gt;600&lt;/VerticalResolution&gt;
        ///  &lt;/Print&gt;
        ///  &lt;Selected/&gt;
        ///  &lt;Panes&gt;
        ///   &lt;P [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Excel2003Sheet {
            get {
                return ResourceManager.GetString("Excel2003Sheet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&apos;1.0&apos; encoding=&apos;UTF-8&apos; standalone=&apos;yes&apos; ?&gt;
        ///&lt;worksheet xmlns=&apos;http://schemas.openxmlformats.org/spreadsheetml/2006/main&apos; xmlns:r=&apos;http://schemas.openxmlformats.org/officeDocument/2006/relationships&apos;&gt;
        ///    &lt;sheetData&gt;
        ///
        ///@Include(Model.NameOfT+&quot;Excel2007Header&quot;)
        ///
        ///@foreach(var item in Model.Data){
        ///  @Include(Model.NameOfT+&quot;Excel2007Item&quot;,item)
        ///} 
        ///
        ///    &lt;/sheetData&gt;
        ///&lt;/worksheet&gt;.
        /// </summary>
        public static string Excel2007File {
            get {
                return ResourceManager.GetString("Excel2007File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;row&gt;
        ///@foreach(var item in Model){
        ///   &lt;c t=&apos;inlineStr&apos;&gt;
        ///                &lt;is&gt;
        ///                    &lt;t&gt;@System.Security.SecurityElement.Escape(item)&lt;/t&gt;
        ///                &lt;/is&gt;
        ///            &lt;/c&gt;
        ///} 
        ///&lt;/row&gt;.
        /// </summary>
        public static string Excel2007Header {
            get {
                return ResourceManager.GetString("Excel2007Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;row&gt;
        ///@foreach(var item in Model){
        ///   &lt;c t=&apos;inlineStr&apos;&gt;
        ///                &lt;is&gt;
        ///                    &lt;t&gt;@@System.Security.SecurityElement.Escape((((object)Model.@item) ?? &quot;&quot;).ToString())
        ///                    &lt;/t&gt;
        ///                &lt;/is&gt;
        ///    &lt;/c&gt;
        ///   }
        ///&lt;/row&gt;.
        /// </summary>
        public static string Excel2007Item {
            get {
                return ResourceManager.GetString("Excel2007Item", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///    &lt;head&gt;
        ///    &lt;title&gt;Export&lt;/title&gt;
        ///    &lt;/head&gt;
        ///    &lt;body&gt;
        ///    
        ///&lt;Table border=&quot;1&quot;&gt;
        ///
        ///@Include(Model.NameOfT+&quot;HtmlHeader&quot;)
        ///
        ///@foreach(var item in Model.Data){
        ///  @Include(Model.NameOfT+&quot;HtmlItem&quot;,item)
        ///} 
        ///
        /// &lt;/Table&gt;
        ///                
        ///         Generated on @ViewBag.DateCreated
        ///    &lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        public static string HtmlFile {
            get {
                return ResourceManager.GetString("HtmlFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;tr&gt;
        ///@foreach(var item in Model){
        ///   &lt;th&gt;@System.Security.SecurityElement.Escape(item)&lt;/th&gt;
        ///} 
        ///&lt;/tr&gt;.
        /// </summary>
        public static string HtmlHeader {
            get {
                return ResourceManager.GetString("HtmlHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;tr&gt;
        ///@foreach(var item in Model){
        ///   &lt;td&gt;@@System.Security.SecurityElement.Escape((((object)Model.@item) ?? &quot;&quot;).ToString())&lt;/td&gt;
        ///} 
        ///&lt;/tr&gt;.
        /// </summary>
        public static string HtmlItem {
            get {
                return ResourceManager.GetString("HtmlItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;itext author=&quot;Andrei Ignat&quot; title=&quot;Collection&quot;&gt;
        ///
        ///&lt;chapter numberdepth=&quot;0&quot;&gt;
        ///&lt;newline /&gt;
        ///&lt;section numberdepth=&quot;0&quot;&gt;
        ///&lt;table width=&quot;100%&quot;  cellspacing=&quot;0&quot; cellpadding=&quot;2&quot; columns=&quot;$ItemToDisplay.Properties.keys.Count$&quot; grayfill=&quot;0.90&quot;&gt;
        ///
        ///@Include(Model.NameOfT+&quot;iTextSharp4Header&quot;)
        ///
        ///@foreach(var item in Model.Data){
        ///  @Include(Model.NameOfT+&quot;iTextSharp4Item&quot;,item)
        ///}     
        ///&lt;/table&gt;
        ///&lt;/section&gt;
        ///
        ///&lt;/chapter&gt;
        ///
        ///
        ///
        ///&lt;/itext&gt;.
        /// </summary>
        public static string iTextSharp4File {
            get {
                return ResourceManager.GetString("iTextSharp4File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;row&gt;
        ///@foreach(var item in Model){
        ///&lt;cell&gt;&lt;phrase font=&apos;Arial&apos; size=&apos;12&apos; style=&apos;bold&apos;&gt;@System.Security.SecurityElement.Escape(item)&lt;/phrase&gt;&lt;/cell&gt;
        ///}
        ///&lt;/row&gt;.
        /// </summary>
        public static string iTextSharp4Header {
            get {
                return ResourceManager.GetString("iTextSharp4Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;row&gt;
        ///@foreach(var item in Model){
        ///    &lt;cell&gt;&lt;phrase font=&apos;Times New Roman&apos; size=&apos;8&apos;&gt;@@System.Security.SecurityElement.Escape((((object)Model.@item) ?? &quot;&quot;).ToString())&lt;/phrase&gt;&lt;/cell&gt;
        ///}
        ///&lt;/row&gt;.
        /// </summary>
        public static string iTextSharp4Item {
            get {
                return ResourceManager.GetString("iTextSharp4Item", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;w:wordDocument xmlns:w=&quot;http://schemas.microsoft.com/office/word/2003/wordml&quot; &gt;        
        ///    &lt;w:body&gt;
        ///        &lt;w:tbl&gt;
        ///    
        ///@Include(Model.NameOfT+&quot;Word2003Header&quot;)
        ///
        ///@foreach(var item in Model.Data){
        ///  @Include(Model.NameOfT+&quot;Word2003Item&quot;,item)
        ///} 
        ///
        ///        &lt;/w:tbl&gt;
        ///    &lt;/w:body&gt;
        ///    
        ///&lt;/w:wordDocument&gt;.
        /// </summary>
        public static string Word2003File {
            get {
                return ResourceManager.GetString("Word2003File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;w:tr&gt;
        ///@foreach(var item in Model){
        ///           &lt;w:tc&gt;
        ///                &lt;w:p&gt;
        ///                    &lt;w:r&gt;
        ///                        &lt;w:rPr&gt;
        ///                            &lt;w:b w:val=&apos;on&apos;/&gt;
        ///                            &lt;w:t&gt;
        ///                                @System.Security.SecurityElement.Escape(item)
        ///                            &lt;/w:t&gt;
        ///                        &lt;/w:rPr&gt;
        ///                    &lt;/w:r&gt;
        ///                &lt;/w:p&gt;
        ///            &lt;/w:tc&gt;                
        ///}
        ///&lt;/w:tr&gt;.
        /// </summary>
        public static string Word2003Header {
            get {
                return ResourceManager.GetString("Word2003Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;w:tr&gt;
        ///@foreach(var item in Model){
        ///   &lt;w:tc&gt;
        ///    &lt;w:p&gt;
        ///        &lt;w:r&gt;
        ///            &lt;w:t&gt;@@System.Security.SecurityElement.Escape((((object)Model.@item) ?? &quot;&quot;).ToString())&lt;/w:t&gt;
        ///        &lt;/w:r&gt;
        ///    &lt;/w:p&gt;
        ///    &lt;/w:tc&gt;
        ///   }
        ///&lt;/w:tr&gt;.
        /// </summary>
        public static string Word2003Item {
            get {
                return ResourceManager.GetString("Word2003Item", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;w:document xmlns:w=&quot;http://schemas.openxmlformats.org/wordprocessingml/2006/main&quot;&gt;
        ///    &lt;w:body&gt;
        ///        &lt;w:tbl&gt;
        ///
        ///@Include(Model.NameOfT+&quot;Word2007Header&quot;)
        ///
        ///@foreach(var item in Model.Data){
        ///  @Include(Model.NameOfT+&quot;Word2007Item&quot;,item)
        ///} 
        ///        &lt;/w:tbl&gt;
        ///    &lt;/w:body&gt;
        ///&lt;/w:document&gt;.
        /// </summary>
        public static string Word2007File {
            get {
                return ResourceManager.GetString("Word2007File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;w:tr&gt;
        ///@foreach(var item in Model){
        ///                &lt;w:tc&gt;
        ///                    &lt;w:p&gt;
        ///                        &lt;w:r&gt;
        ///                            &lt;w:rPr&gt;
        ///                                &lt;w:b w:val=&apos;on&apos;/&gt;
        ///                                &lt;w:t&gt;
        ///                                      @System.Security.SecurityElement.Escape(item)
        ///                                &lt;/w:t&gt;
        ///                            &lt;/w:rPr&gt;
        ///                        &lt;/w:r&gt;
        ///                    &lt;/w:p&gt;
        ///                &lt;/w:tc&gt;
        ///}
        ///            &lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Word2007Header {
            get {
                return ResourceManager.GetString("Word2007Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;w:tr&gt;
        ///@foreach(var item in Model){
        ///   &lt;w:tc&gt;
        ///    &lt;w:p&gt;
        ///        &lt;w:r&gt;
        ///              &lt;w:t&gt;@@System.Security.SecurityElement.Escape((((object)Model.@item) ?? &quot;&quot;).ToString())&lt;/w:t&gt;
        ///        &lt;/w:r&gt;
        ///    &lt;/w:p&gt;
        ///    &lt;/w:tc&gt;
        ///   }
        ///&lt;/w:tr&gt;.
        /// </summary>
        public static string Word2007Item {
            get {
                return ResourceManager.GetString("Word2007Item", resourceCulture);
            }
        }
    }
}
