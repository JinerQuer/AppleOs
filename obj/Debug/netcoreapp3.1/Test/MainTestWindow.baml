   M S B A M L   `   `   `  ����B  >AppleOs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AppleOs.TestAppleOs.Test  5   	   5clr-namespace:AppleOs.ResourcesAppleOs.Resources  5   	   !    AppleOs.Test.MainTestWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:AppleOs.Test     5   	   /resclr-namespace:AppleOs.Resources     5   	   -   5          �Name$  
TestWindow��5   	    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	    � Title$ 
TestWindow��5   	   $	��450��6   $	��800��6)      AppleOs.Test.WindowBlur   	IsEnabled$
 True��5   	    � 	Resources 5      !   AppleOs.Test.MainTestWindow �� 
TargetType �� Property �� Value	 �� 
TargetType
 J� Opacity   NormalDarkSolidBrush �� RelativeSource �� AncestorType �� 	Converter7  1AppleOs.Resources.WindowStateToThicknessConverter��%
  '        7   �� 5   
   "  6   .�5      ��  � �� 5      �� 5      "	 �6&   .R�5      �� $	
 0.8Q�6!   8��  ��6b   �� *WindowState+ �� 
 Window   ._�5      �� #��z��6/   6U   5      5      5      5      5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 3q�5        WindowCaptionHeight   CaptionHeight# [ 5         CornerRadius$ 0��5          GlassFrameThickness$ 0q�5!      .��5$      �  � RowDefinitions 5%   
   �� 5&      ��6   ��  �� Source# [  3   -AppleOs.Resources.DoubleToGridLengthConverter  �� 5'      $��* �6   .+�5)   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5*      �� $��10��6   �� 5+      -   5          WindowButton#��[ 5+        NormalRedSolidBrush#��[ 6;     DarkRedSolidBrush#��[ 6m   6�   �� 5,      -   5        #��[ 5,        NormalYellowSolidBrush#��[ 6;     DarkYellowSolidBrush#��[ 6p   6�   �� 5-      -   5        #��[ 5-        NormalGreenSolidBrush#��[ 6;     DarkGreenSolidBrush#��[ 6o   6�   5.      � 5/   
   $��1��6    � ColumnDefinitions 50      �� 51      $��2* �6#   �� 52      $��2 �6#   �� 53      $��5* �6#   .+�55      �� $��0��6   57      �� 58      $��3q�6   
���  ��$��1��6@   $��Stretch=�6P   $��Center=�6l   �� 59      $��2��6   5;      5<      5>      5?      