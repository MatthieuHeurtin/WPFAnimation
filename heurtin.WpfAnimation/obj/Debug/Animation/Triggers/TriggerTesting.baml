   M S B A M L   `   `   `  ����O  Kheurtin.WpfAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:heurtin.WpfAnimation.Animation.Triggers'heurtin.WpfAnimation.Animation.Triggers  5   	   <    6heurtin.WpfAnimation.Animation.Triggers.TriggerTesting   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:heurtin.WpfAnimation.Animation.Triggers     5   	     � Title$  TriggerTesting��5   	   $	��450��6    $	��800��6-    � 	Resources 5
       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value   BasicLabels �� Triggers	 �� Value
 �� Binding �� RelativeSource �� Mode �� AncestorType �� Path �� 
TargetName 	 brush �� Color��%,  '��       '��     &	  �    &	 �    �� 5   
   " ��6   .�5      ��  � ��
 ��  �6-   �� 5       � ��$ 50��6(   �� 5       � ��$ 30��6)    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �  ��65   �� 5       � ��$	 100��60   5      5      �� 5   
   " ��6   .�5      ��  � ��$ 1q�62   �� 5       � ��
 �����6.   �� 5       � ��
 �����6+   �� 5       � ��$ 12(�6)    5      P� 5       �@J�	IsFocused . . �5      ��  � ��$ 2q�6:   �� 5        � ��
 �����63   �� 5!       � ��$ 15(�61   5"      P� 5#       �@J�IsMouseOver . . �5$      ��  � ��$ 15(�61   5%      5'      �� 5)   
   .R�5*      �� $��MyLabel��6   ��6#   �� *Name+ 5+      �� 5,      $
	 True��6�   
 6   ��  �� $ FindAncestor=�" ��$ IsMouseOver�.a�5-      �� $ MyLabel��6    � ��
 �  ��6H   5.      50      �� 5D   
   $ Yellow��6(   69   5F      .��5H      �  � ColumnDefinitions 5I   
   �� 5J      $��* �6   �� 5K      $��* �6   �� 5L      $��2* �6   �� 5M      $��2* �6   .+�5P   
   �� $��0��6   $��I'm a button��6!   �� 5Q   
   $��1��6   $��I'm a TextBox��6"   � 5S   
   $��2��6    � RowDefinitions 5T      �� 5U      $��3* �6    �� 5V      $��* �6    .+�5X      �� $��0��6   $��10q�6$   ��60   �� *
Elements+ �� View 5Y      �� 5Z      .P�5[      �� $
��Name��6)    �� CellTemplate# [  69   �� 5\      $��Integer��6)    �� DisplayMemberBinding 6<   �� *	Integer+�� 5]      $��Boolean��6)    6<   �� *	Boolean+5^      5`      �� 5a      -   5        $��
AddTextBox��5a   d   $��1��6   $	��100��6#   $��Name;Integer;Boolean��60   $	��Top=�6L   6d   �� 5b      -   5        $��	AddButton��5b      $��1��6&   $	��Add��63   $��Bottom=�6�   ��6A   �� *
AddCommand+��6`   �� *Text+ �� ElementName$ 
AddTextBox��6�   �� 5c      $��Adding Element��6   ��5d      �� 5e      " ��6   .�5f      ��  � y�$ Hidden=�67   �� 5g       �@J�Opacity$ 0Q�64    5h      5o      5q      5u      � 5v   
   $��3��6   .+�5w      �� $��Center=�6   $��0,20,0,0q�65   ��5x      �� 5y      " ��6   .�5z      ��  � ��$$ Waiting an element to be added��61   �� 5{       � ��
 �  ��67    5|      �� 5}      
 6*   �� *	IsAdded+	 True6F   .a�5~   "   ��  � ��$ Element being added...��69   �� 5   "    � ��
 � � �6?   5�      5�      5�      5�      5�      5�      