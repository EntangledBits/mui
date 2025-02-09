﻿using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;
using System.Resources;
using System;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e467fe5a-70ee-4907-8d06-156e4c988e7d")]


[assembly: XmlnsDefinition("http://firstfloorsoftware.com/ModernUI", "FirstFloor.ModernUI.Presentation")]
[assembly: XmlnsDefinition("http://firstfloorsoftware.com/ModernUI", "FirstFloor.ModernUI.Windows")]
[assembly: XmlnsDefinition("http://firstfloorsoftware.com/ModernUI", "FirstFloor.ModernUI.Windows.Controls")]
[assembly: XmlnsDefinition("http://firstfloorsoftware.com/ModernUI", "FirstFloor.ModernUI.Windows.Converters")]
[assembly: XmlnsDefinition("http://firstfloorsoftware.com/ModernUI", "FirstFloor.ModernUI.Windows.Navigation")]
[assembly: XmlnsPrefix("http://firstfloorsoftware.com/ModernUI", "mui")]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page, 
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page, 
                                              // app, or any theme specific resource dictionaries)
)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]
