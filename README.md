# Basic 

[TinyIoC](https://github.com/grumpydev/TinyIoC/wiki)

[Simple way to use icon fonts in Xamarin Forms projects](https://trailheadtechnology.com/simple-way-to-use-icon-fonts-in-xamarin-forms-projects/)

[Font Awesom Font on Xamarin.Forms](https://medium.com/@tsjdevapps/use-fontawesome-in-a-xamarin-forms-app-2edf25311db4)

Projektet, inden der anvendes Essentials.


IconFont på iOS: Kopier font til Resources og kontrollér BuildAction = BuildResource.
I Info.plist tilføjes følgende:
```xml
<key>UIAppFonts</key>
    <array>
      <string>fa-solid-900.ttf</string>
    </array>
```

Bemærk kun én font her!

I App.xaml tilføjes en style:
```xml
<Style x:Key="IconFont" TargetType="{x:Type Label}">
    <Setter Property="FontFamily">
        <Setter.Value>
            <OnPlatform x:TypeArguments="x:String">
                <On Platform="Android">fa-solid-900.ttf#Font Awesome 5 Free Solid</On>
                <On Platform="iOS">Font Awesome 5 Free</On>
                <!--<On Platform="UWP">/Assets/fa-solid-900.ttf#Font Awesome 5 Free</On>-->
            </OnPlatform>
        </Setter.Value>
    </Setter>
</Style>
```

Bemærk at det er Font-navnet, men undtagen "Solid" der skal angives ved iOS!
