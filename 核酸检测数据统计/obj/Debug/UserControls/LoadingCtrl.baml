   M S B A M L   `   `   `  ????S  O核酸检测数据统计, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:核酸检测数据统计.UserControls%核酸检测数据统计.UserControls  5      7    1核酸检测数据统计.UserControls.LoadingCtrl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:核酸检测数据统计.UserControls     5      .??5	      ? 
???????$??Center=?6   $	??Top=?6<   $??75??6T   $??42??6_     ? 	Resources  5
   
      rec ?? 
TargetType ?? Property ?? Value  PrimaryHueMidBrush.  (System.Windows.Media.Animation.PowerEase  	powerEase   Power7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode??%?   &	        &	 ?     ?? 5      " ??6    .?5      ??  ? ??$ 10??6*   ?? 5       ? ??$ 20??6+   ?? 5       ? ??# ?  6)   5        5      $ 3Q?6*   $ 	EaseInOut=?64   5       ? Triggers 5   
   :? 5       :? RoutedEvent$ Loaded??6   .[?5      ?? .??5      ??  g? RepeatBehavior$ Forever??6!   	 ?? TargetProperty$	 Height?6:   .??5      W? 
 ?? 
TargetName$

 rec1??6*   	 W? To$ 40X?6G    g? 	BeginTime$ 0:0:0.0X?6O    g? Duration$ 0:0:0.5D?6c    W? EasingFunction# [ 6v    g? AutoReverse . 6?   W? 5      $

 rec2??6*   $ 40X?6G   $ 0:0:0.2X?6O   $ 0:0:0.5D?6c   # [ 6v    . 6?   W? 5      $

 rec3??6*   $ 40X?6G   $ 0:0:0.4X?6O   $ 0:0:0.5D?6c   # [ 6v    . 6?   W? 5      $

 rec4??6*   $ 40X?6G   $ 0:0:0.6X?6O   $ 0:0:0.5D?6c   # [ 6v    . 6?   W? 5      $

 rec5??6*   $ 40X?6G   $ 0:0:0.8X?6O   $ 0:0:0.5D?6c   # [ 6v    . 6?   5      5      5       ? ColumnDefinitions 5   
   ?? 5       $??15 ?6   ?? 5!      $??15 ?6   ?? 5"      $??15 ?6   ?? 5#      $??15 ?6   ?? 5$      $??15 ?6   .+?5&   
   ?? $??Loading??6   $??18(?5'      $??Times New Roman)?5(      ???#252c41$
??Bold"?5*      $??5??5+      $??Center=?5,      $??Center=?5-      $??0,80,0,0q?5.      ?? 5/   
   -   5        $
??rec1??5/      $??0??6    #??[  60   ?? 50   
   -   5        $
??rec2??50      $??1??6    #??[  60   ?? 51   
   -   5        $
??rec3??51      $??2??6    #??[  60   ?? 52   
   -   5        $
??rec4??52      $??3??6    #??[  60   ?? 53   
   -   5        $
??rec5??53      $??4??6    #??[  60   54      55      