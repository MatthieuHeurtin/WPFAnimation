   M S B A M L   `   `   `  ����  heurtin.WpfAnimation    WpfAnimation.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  WPF Animations��5   	   $	��350��6    $
��1000��6-    � 	Resources 5         BasicTextBlock  BasicTextBlockComment  BasicButtonWithCommand �� ElementName �� Path �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%  &	        &	 H     &	 �     '�� '    �� 5	   
   .R�5
      �� ��6   �� *AnimationName+5      �� 5   
   .R�5      �� ��6   �� *	Comment+5      �� 5   
   .R�5      �� $	��140��6   $	��Run��6"   ��60   �� $ MYList��$ DataContext.MyCommand���6t   �� *AnimationName+5      �� 5   
   " ��6   .�5      ��  � ��
 ��  �6-    5      P� 5       �@J�IsMouseOver	 . . �5      ��  � ��
 �  ��65   5      5      5       .��5"      � .+�5#   
   �� -   5        $��MYList��5#   /   $��Stretch=�6   ��6=   �� *MyList+
 �� View
 5$      �� 5%      P�5&      �� 5'      $
��Name��6*    �� CellTemplate# [  69   �� 5(      $��Comment��6*   # [ 6<   �� 5)      $	��Run��6*   # [ 68   5+      5-      5.      5/      