   M S B A M L   `   `   `  ????S  O核酸检测数据统计, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:核酸检测数据统计核酸检测数据统计  5   	   ]3clr-namespace:核酸检测数据统计.UserControls%核酸检测数据统计.UserControls  5   	   *    $核酸检测数据统计.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:核酸检测数据统计     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   FUserControls3clr-namespace:核酸检测数据统计.UserControls  5   	   -   5          ? WindowStyle$
  None=?5
   	   
??????  ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?5   
    ? Title$ 
MainWindow??5   	   $	??380??6   $	??650??6)   .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??196 ?6   ?? 5      $??40 ?6   ?? 5      $??50 ?6   ?? 5      $??* ?6   .+?5   
   ?? $??4??6    ?? CornerRadius$ 16??6#   
???????67   ?? 5   
   $??Resources/main.png??6   $	??240??6,   $	??160??68   $??0,20,0,0q?6E   ?? 5   
   $??1??6   $??Center=?6!   $
??Bold"?6?   $$??学生核酸数据统计系统??6Q   $??20(?6c   ?? 5   
   -   5         ??Name$ name_box??5      $??2??6#   $ 10??61   $	??200??6C   $??32??6O   ???#DEDEDE._?5      ?? -   5         ??Name$ name_txt??5      $	??180??6(   $??5q?64   $??0q?6?   $??Center=?6S   .??6p    ? 	Resources 5         HintText	 j? TileMode
 ?? Opacity j? Stretch j? 
AlignmentX !? Visual??%?   &	        !? 5      $
	 None=?63   $	
 0.5Q?6C   $
 None=?6Q   $
 Left=?6`    5      ?? 5      $??Italic$?6(   $??请输入用户名??6;   5!      5"      .??6%   ??5#      ?? 5$       ?? 
TargetType" ??6   .?5%      ??  ?? Property ? ?? ?? Value ?#DEDEDE67   ?? 5&       ?@??TextAlignment$
 Left=?6:   ?? 5'       ? ??$ Center=?6>   ?? 5(       ? ??$ 14(?65    ?? Triggers 5)      P? 5*       P? Property ? ?? P? Value 66   Z? . ?5+   "   ??  ? ??# [  6?   5,      P? 5-       ? ??$  ??66   . ?5.   "   ??  ? ??# [  6?   5/      51      .??52   !   53      54      ?? 55   
   -   5         ??Name$ 	start_btn??55      $??3??6$   $	??200??61   $??32??6=   $	??Top=?6I   $??0,4,0,0q?6a   .??56      ?? $??开始使用??6   57      7   1核酸检测数据统计.UserControls.LoadingCtrl  58   
   -   5          Name$
 load??58   #   $y?Hidden=?61   $??Center=?6E   $??2??6c   $	??Top=?6p    J? RenderTransformOrigin$ 0.528,-0.158&?6?   $	??228??6?   ?? 59   
   -   5        $ 	close_btn??59      $??	0,12,12,0q?6$   $	??Top=?67   $??Right=?6O   $??40??6k   $??40??6v   ??5:      ?? 5;      .R?5<      ?? ._?5=      ?? $	????6$   $??/Resources/#iconfont)?64   $??20??6W   
???   ?$??20(?6v   $
??Bold"?6?    ?? TextAlignment$ Center=?6?   5>      5?      5A      5B      5C      