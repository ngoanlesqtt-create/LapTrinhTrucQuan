   M S B A M L   `   `   `  ����B  >ToolBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ToolBarToolBar  5   	       ToolBar.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ToolBar     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   c� -   5        $��toolBar1��5
      $��26��6   $	��200��6.   $
��Left=�5      .@�5      �� -   5        $��button1��5   !   $��23��6   $��23��60   $��ApplicationCommands.Copy��5       � ToolTip$
 Copy��6$   .��5      �� $��16��6   $��16��6#   $
��Left=�5      5      �� 5      -   5        $��button2��5   !   $��23��6   $��23��60   $��ApplicationCommands.Cut��5      $	 Cut��6#   .��5      �� $��16��6   $��16��6#   $
��Left=�5      5      �� 5      -   5        $��button3��5   !   $��23��6   $��23��60   $��ApplicationCommands.Paste��5      $ Dán văn bản��6%   .��5      �� $��16��6   $��16��6#   $
��Left=�5      5      �� 5      �� 5      -   5        $��button4��5   !   $��23��6   $ Increase size of font��60   $��23��6P   .��5      �� $��16��6   $��16��6#   $
��Left=�5      5      �� 5       -   5        $��button5��5    !   $��23��6   $ Decrease size of font��60   $��23��5!      .��5"      �� $��16��6   $��16��6#   $
��Left=�5#      5$      5%      �� 5'   
   -   5        $��textBox��5'       �� TextWrapping$
 Wrap=�6!   $��2q�65   .��6@   Hello World!5)      5*      5+      