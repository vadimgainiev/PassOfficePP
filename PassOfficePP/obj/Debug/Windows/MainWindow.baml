   M S B A M L   `   `   `  ????  PassOfficePP    PassOfficePP.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          ? WindowState$  	Maximized=?5   	    ? WindowStartupLocation$ CenterScreen=?5	   	    ? Title$! Бюро пропусков??5
   	    ? 
ResizeMode$ CanMinimize=?5   	   $	??450??5   	   $	??800??6   
???????.??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??4* ?6   .+?5   
    ? -   5          ?Name$ 	MainFrame??5       $??1??6     ? NavigationUIVisibility$ Hidden=?5      ? 5   
   $??0??6    ? RowDefinitions 5      ?? 5      $??1* ?6    ?? 5      $??3* ?6    .+?5      ?? $??0??6    K? ZIndex$ 1??5      $??10q?5       .+?5!      ?? $??../Resources/pass.png??6   $??Center=?5"      $??Center=?5#      $??Uniform=?5$      $	??300??5%      $	??200??5&      ?? 5'      $!??Бюро пропусков??6   $??	ExtraBold"?5(      $??16(?5)      $??Center=?5*      $??Center=?5+      5,      ?? 5.      $??1??6   ??5/      ?? 50      .??51      ? 	 ? Color$	 Bisque??6'   
 ? Offset$
 0Q?66   ? 52      $	 Bisque??6'   $	
 0.8Q?66   53      55      ?? 57      $??1??6   $??20q?6&   .+?58      ?? $??Навигация??6   $??Heavy"?59      $??Center=?5:      $??16(?5;         DisplayInfo#??[  5<      $??0,0,0,30q?5=      ?? 5>      -   5         ??Name$ ShowVisitorPage??5>        
MenuButton#??[ 5?      .??5A      ??  ?? Orientation$ 
Horizontal=?6!   $
??Left=?5B   !   $??Center=?5C   !   .+?5D      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Account=?5E        MenuButtonIcon#??[ 5F      ?? 5G      $??Сотрудники??6$     MenuButtonText#??[ 5H   $   5I      5J      ?? 5K      -   5        $ ShowAccessLevelPage??5K      #??[ 5L      .??5N      ?? $ 
Horizontal=?6!   $
??Left=?5O   !   $??Center=?5P   !   .+?5Q        $ AccessPointCheck=?5R      #??[ 5S      ?? 5T      $!??Уровни доступа??6$   #??[ 5U   $   5V      5W      ?? 5X      -   5        $ ShowPostPage??5X      #??[ 5Y      .??5[      ?? $ 
Horizontal=?6!   $
??Left=?5\   !   $??Center=?5]   !   .+?5^        $
 Post=?5_      #??[ 5`      ?? 5a      $??Должности??6$   #??[ 5b   $   5c      5d      ?? 5e      -   5        $ ShowCategoryPage??5e      #??[ 5f      .??5h      ?? $ 
Horizontal=?6!   $
??Left=?5i   !   $??Center=?5j   !   .+?5k        $ Table=?5l      #??[ 5m      ?? 5n      $??Категории??6$   #??[ 5o   $   5p      5q      ?? 5r      -   5        $ ShowWorkPlacePage??5r      #??[ 5s      .??5u      ?? $ 
Horizontal=?6!   $
??Left=?5v   !   $??Center=?5w   !   .+?5x        $ OfficeBuildingOutline=?5y      #??[ 5z      ?? 5{      $??Места работы??6$   #??[ 5|   $   5}      5~      ?? 5      -   5        $ ShowWorkSchedulePage??5      #??[ 5?      .??5?      ?? $ 
Horizontal=?6!   $
??Left=?5?   !   $??Center=?5?   !   .+?5?        $ ClipboardTextClockOutline=?5?      #??[ 5?      ?? 5?      $!??Графики работы??6$   #??[ 5?   $   5?      5?      ?? 5?      -	   5        $ ExitBtn??5?      $??	0,200,0,0q?5?      $??
Выйти??5?        DataFunctionButton2#??[ 5?      5?      5?      5?      5?      5?      