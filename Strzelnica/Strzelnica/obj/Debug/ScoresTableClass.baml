   M S B A M L   `   `   `  ����E  AStrzelnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Strzelnica
Strzelnica  5   	   !    Strzelnica.ScoresTableClass   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Strzelnica     5   	     � Title$  Wyniki��5   	   $	��480��6   $	��840��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   .+�5   
   �� -   5        $��	ListView1��5   1   $��Stretch=�6    �� View 5      �� 5      .P�5      �� $
��Nick��6%    �� Width$ 70��63    �� DisplayMemberBinding 6?   �� *Nick+�� 5      $��Imię��6%   $ 70��63    6?   �� *Name+�� 5      $��Nazwisko��6%   $	 100��67    6D   �� *	Surname+�� 5      $��Styczeń��6%   $ 70��66    6B   �� *
Month[0]+�� 5      $
��Luty��6%   $ 70��63    6?   �� *
Month[1]+�� 5      $��Marzec��6%   $ 70��65    6A   �� *
Month[2]+�� 5      $��Kwicień��6%   $ 70��66    6B   �� *
Month[3]+�� 5      $	��Maj��6%   $ 70��62    6>   �� *
Month[4]+�� 5      $��Czerwiec��6%   $ 70��67    6C   �� *
Month[5]+�� 5      $��Lipiec��6%   $ 70��65    6A   �� *
Month[6]+�� 5      $��	Sierpień��6%   $ 70��67    6C   �� *
Month[7]+�� 5      $��	Wrzesień��6%   $ 70��67    6C   �� *
Month[8]+�� 5       $��Październik��6%   $ 70��6:    6F   �� *
Month[9]+�� 5!      $��Listopad��6%   $ 70��67    6C   �� *	Month[10]+�� 5"      $��	Grudzień��6%   $ 70��67    6C   �� *	Month[11]+�� 5#      $
��SUMA��6%   $ 70��63    6?   �� *
TotalScore+�� 5$      $��SUMA[%]��6%   $ 70��66    6B   �� *TotalScorePercentage+5%      5'      5(      5)      