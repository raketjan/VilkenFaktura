   M S B A M L   `   `   `  ����K  GVilkenFakturaGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:VilkenFakturaGUIVilkenFakturaGUI  5      (    "VilkenFakturaGUI.VilkenFakturaHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:VilkenFakturaGUI     5        � Language$  sv-SE�5   0    N� Title$ Vilken Faktura Home��5	      .��5
      � $��5,5,5,5q�6    � RowDefinitions 5   
   �� 5      $��1 �6   �� 5      $��55 �6   �� 5      �� 5      $��45 �6   .+�5   
   �� $��1��6   
�������
�������$��1q�6K    �� CornerRadius$ 5��6_    �� Padding$ 1q�6p   $��2q�6|   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��90��6   ��5      �� 5       �� TextWrapping$
 Wrap=�6%   $��Lägg till fakturapost:��69   5      �� 5      .u�5      �� -   5        $��NewInvoiceName��5   )   $��1q�6   $	��220��6?   $��28��6K   .��6X   '   !VilkenFakturaGUI.WatermarkService   	Watermark 5      �� 5         textblockStyle#��[  6(   Fakturatext6]   .��5   @   5      5      �� 5       .u�5!      �� -   5        $��NewInvoiceCost��5!   )   $��1q�6   $	��150��6?   $��28��6K   .��6X    5"      �� 5#      #��[  6(   	Kostnad6Y   .��5$   @   5%      5&      �� 5(      -   5        $��NewInvoiceButton��5(   +   $��15,1,1,1q�6     buttonStyle#��[ 6b   .��6�   
Lägg till6�   5*      5+      � 5,   
   $��0��6   $��2��6   .+�5-      �� -   5        $��MainTabControl��5-      .@�5.      �� -   5        $��InvoiceItemsTab��5.      $��Fakturaposter��61   .��5/      �� -   5        $��invoiceListBox��5/      $��Stretch=�6N   ��66   ��  �� View 50      �� 51      !	 �� ColumnHeaderContainerStyle	 52      �� 53   "   
 �� 
TargetType"
 ��6(   .�54   &   ��  �� Property � �� �� Value$ Stretch=�6S   55   #   .P�58      ��  �� Width$	 280��6.   ��59   "   �� 5:   &   $
��Namn��6;   $
��Left=�6J    �� CellTemplate 5<   "   �� 5=   &   .R�5>   *   ��  �� TextAlignment$
 Left=�6M   ��62   ��  �� Path$
 Name�6M   5?   '   5A      �� 5B      $	 165��6-   ��5C   "   �� 5D   &   $��Kostnad��6;   $��Center=�6M    5F   "   �� 5G   &   .R�5H   *   �� $ Right=�6\   ��62   �� $
 Cost� �� StringFormat$ c��6\   5I   '   5K      �� 5L      $ 40��6.   ��5M   "   �� 5N   &   $��Inkl.��6;   $��Center=�6K    5P   "   �� 5Q   &   .R�5R   *   �� $��Center=�63   $��Center=�6P    d� 	IsChecked 6k   �� $ Include�5S   '   5U      �� 5V      $ 70��6-   ��5W   "   �� 5X   &   $��Radera��6;   $��Center=�6L    5Z   "   �� 5[   &   .R�5\   *   �� -   5        $��Center=�5\   1   $��Center=�6N   .��6�   	Ta bort6�   5]   '   5`      5a      5c      5d      �� 5e      -   5        $��SolutionTab��5e      $��Lösning��6-   .��5f      �� -	   5        $��Results��5f      $:��4Här kommer det presenteras en eventuell lösning...��6-   5g      5h      5i      �� 5j   
   $��3��6   
�������
�������$��1q�6K   $ 5��6_   $ 1q�6p   $��2q�6|   ._�5k      � .+�5l      �� $��0��6   $��3��6-   $ 
Horizontal=�6:   .+�5m      �� $��Center=�6   .��63   
Delsumma6=   �� 5n      -
   5        $��
SumTextBox��5n      $	��100��6,   $��20��6a   ��68   �� $	 Sum�$ c��6a   5o      �� 5p      $��3��6   $ 
Horizontal=�6&   $��Right=�6?   .+�5q      �� -   5        #��[ 5q   5   .��6Z   	Importera6e   �� 5r      -   5        #��[ 5r   3   .��6X   Öppna6_   �� 5s      -   5        #��[ 5s   3   .��6X   Spara6_   �� 5t      -   5        $��Calculate_Button��5t      #��[ 6P   .��6u   
Beräkna6~   5u      5v      5x       � 	Resources 5y   
   5   /VilkenFakturaGUI.WidthCalculationMultiConverter   lastColumnMaximizerConverter��%   &	         5z      63   5{      5|      5}      