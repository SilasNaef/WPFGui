   M S B A M L   `   `   `  ����D  @KSharpGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KSharpGui.ControlKSharpGui.Control  5   	       KSharpGui.View.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5	KSharpGuiclr-namespace:KSharpGui.Control     5   	     � Title$  K Sharp Toolbox��5	   	   $	��300��6!   $	��500��6.   .��5      � .+�5   
   �� .+�5      o�  o� 
IsMainMenu . ���#0d0e36.@�5      m� $	��7pxq�6   ��5      �� 5      .+�5      �� $��20��6$   $��20��6/   $#��..\images\white-menu-icon.png��6;   5      5      m� 5      $��_Passwordgenerator��6   
�������$	��7pxq�6J   6Z   m� 5      $��_Gruppenersteller��6   
�������$	��7pxq�6I   6Y   5      � 5       � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $��* �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   .+�5#      � $��0��6    5$      �� 5%      $
��Auto �6(   �� 5&      $
��Auto �6(   �� 5'      $
��Auto �6(   �� 5(      $
��Auto �6(   �� 5)      $
��Auto �6(   �� 5*      $
��Auto �6(   .+�5,      �� $��Einstellungen: ��6   $��0��62   $��	10 10 0 0q�6?   $��0q�6R   $
��Bold"�6^   �� 5-      $��Anzahl Gruppen:��6   $��1��66   $��9(�6C   $��	10 10 0 0q�6P   $��0q�6c   �� 5.      -   5        $��AnzahlGruppen��5.   +   $��2��6   $��	10 0 10 0q�6@   ��6S   �� *GruppenAnzahl+�� 50      $��Mitglied hinzufügen: ��6   $��
10 10 10 0q�6<   $��3��6P   $��9(�6]   $��0q�6j   �� 51      $��4��6   $��	10 0 10 0q�6+   ��6>   �� *
Mitglieder+�� 54      $��5��6   $��
10 20 10 0q�6*   $��Generate Random��6>   $��9(�6x   ��6X   �� *ClickRandom+6�   55      � 57      $��1��6    58      �� 59      $
��Auto �6(   �� 5:      $
��Auto �6(   �� 5;      $
��Auto �6(   .+�5=      �� $��Gruppenersteller: ��6   $��0��69   $��	10 10 0 0q�6F   $��0q�6Y   $
��Bold"�6e   &   System.Windows.Controls.DataGrid  5@      $��Stretch=�6   $��1��6D   $��100 50 100 0q�6Q   ��6g   �� *GruppenListe+6�   5C      5D      5E      5F      5G      