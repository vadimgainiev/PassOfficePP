   M S B A M L   `   `   `  ????  PassOfficePP=    7PassOfficePP.Pages.AddEditPages.AddEditWorkSchedulePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N? Title$  График работы??5      $	??800??5	      $
??1000??6    N? 
Background
 ?????.??5      ? $??20q?6    ? RowDefinitions 5   
   ?? 5      $??8* ?6   ?? 5      $
??0.5* ?6   .+?5   
    ?  K? ZIndex$ 2??6   ? 5   
   $??0??6   $??5,0,5,5q?6    ? ColumnDefinitions 5      ?? 5      $??1* ?6#   ?? 5      $??3* ?6#    5      ?? 5      $??* ?6    ?? 5      $??* ?6    .+?5      ?? $??0??6   $??0??6%   $??Наименование:??5         AddEditDisplayInfo1#??[  5      ?? 5       $??1??6   $??0??6%   $??Описание:??5!      #??[  5"      ?? 5$      $??0??6   $??1??6#    ?? 	MaxLength$ 50??5&        AddEditTextBox1#??[ 5'      ??5%      ?? *Name_WorkSchedule+5'      ?? 5(      $??1??6   $??1??6#   $	??140??5)       ?? AcceptsReturn .  ?? 	IsEnabled .  ?? TextWrapping$
 Wrap=?5,      #??[ 5.      ??5-      ?? *Description_WorkSchedule+5.      5/      ?? 51   
   -   5        	 ??Name$	 	BtnCancel??52      $??1??51      $??Отмена??53      
???<??$
??Left=?55      
???????  DataFunctionButton#??[ 57      58      ?? 59   
   -   5        $	 BtnSave??5:      $??1??59      $??Сохранить??5;      ???#CCCCFF$??Right=?5=      
???   ?#??[ 5?      5@      5A      5B      