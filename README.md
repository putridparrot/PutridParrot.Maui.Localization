# PutridParrot.Maui.Localization

[![Build PutridParrot.Maui.Localization](https://github.com/putridparrot/PutridParrot.Maui.Localization/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/putridparrot/PutridParrot.Maui.Localization/actions/workflows/dotnet-core.yml)
[![NuGet version (PutridParrot.Maui.Localization)](https://img.shields.io/nuget/v/PutridParrot.Maui.Localization.svg?style=flat-square)](https://www.nuget.org/packages/PutridParrot.Maui.Localization/)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/putridparrot/PutridParrot.Maui.Localization/blob/master/LICENSE.md)
[![GitHub Releases](https://img.shields.io/github/release/putridparrot/PutridParrot.Maui.Localization.svg)](https://github.com/putridparrot/PutridParrot.Maui.Localization/releases)
[![GitHub Issues](https://img.shields.io/github/issues/putridparrot/PutridParrot.Maui.Localization.svg)](https://github.com/putridparrot/PutridParrot.Maui.Localization/issues)


The aim of for this project is to supply helper functionality etc. for Maui to allow us to easily create localizable applications.

Package available via [nuget](https://www.nuget.org/packages/PutridParrot.Maui.Localization/)

### Getting Started

* Install the nuget package PutridParrot.Maui.Localization
* In your MauiProgram.cs add the using 

   ```
   using Microsoft.Extensions.Logging;
   ```

    Within the CreateMauiApp method add

   ```
    builder.Services.AddLocalization();
   ```
* Add a folder to Resources such as Resources/Strings
* Add a new item, a Resource (with the .resx extension), be default I use AppRes.resx, but you can name it whatever you like. This will be our default language strings resource.
* Add more new Resource (.resx extensions) for each of the languages you wish to support, they should be named as per your default resource file, so in my case AppRes then followed by the culture string (for example en-US, fr, de), so will look like this AppRes.de.resx for all German localizations.
* To use these in code is as simple as  

   ```
   Debug.WriteLine(AppRes.HelloWorld);
   ```

   where HelloWorld is a key within the AppRes.resx.
* For XAML we use the the LocalizeExtension, however this expects a type which represents the AppRes (or whatever you named it type). So the simplest way to resolve this is create a new class named something like LocalizeAppResExtension which might look like this

   ```
   internal class LocalizeAppResExtension : LocalizeExtension<AppRes>
   {
   }
   ```

   Now within our XAML we use

   ```
   <Label Text="{utils:LocalizeAppRes HelloWorld}" />
   ```

### Changing your current culture

This is easy enough and worth doing when debugging your application as some languages have much longer strings for certain things that are pretty short in English (German, I'm looking at you my old friend).

We can do this pretty simply outselves, but this package includes the Localize class with a some code to do this for us, just use the SetCurrentlCulture static method

```
Localize.SetCurrentCulture("de);
```
