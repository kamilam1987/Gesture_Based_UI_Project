   M S B A M L   `   `   `  ����E  AWPF_Kinect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_Kinect
WPF_Kinect  5   	       WPF_Kinect.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_Kinect     5   	   -   5          � Title$  Kinect Camera��5   	   $
��1000��6   $	��800��6-    � 	Resources 5	         ButtonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6$   .�5      ��  � ��$
 10,5q�6'   �� 5       � ��
 ��  �6+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   5      5      .��5      (� .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��62   .+�5      �� -   5        $��Color��5      #��[  6)   6N   �� 5      -   5        $��Infrared��5      #��[  6,   6Q   �� 5      -   5        $��Depth��5      #��[  6)   6N   �� 5      -   5        $
��Body��5      #��[  6(   6M   5      �� 5      -   5         ��Name$ camera��5      $��1��6$   $��Uniform=�61   �� 5      -   5        $��canvas��5      $��1��6#   5       5!      5"      