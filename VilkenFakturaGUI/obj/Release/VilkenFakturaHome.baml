   M S B A M L   `   `   `  ���� K  GVilkenFakturaGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:VilkenFakturaGUIVilkenFakturaGUI  (    "VilkenFakturaGUI.VilkenFakturaHome   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:VilkenFakturaGUI       � Language$  sv-SE� N� Title$ Vilken Faktura Home��.��� $��5,5,5,5q� � RowDefinitions �� $��1 ��� $��55 ��� �� $��45 �.+��� $��1��
�������
�������$��1q� �� CornerRadius$ 5�� �� Padding$ 1q�$��2q�._���  �� Orientation$ 
Horizontal=�.+��� $��90������  �� TextWrapping$
 Wrap=�$��Lägg till fakturapost:���� .u��� -   $��NewInvoiceName��$��1q�$	��220��$��28��.��'   !VilkenFakturaGUI.WatermarkService   	Watermark ��    textblockStyle#��[  Fakturatext.���� .u��� -   $��NewInvoiceCost��$��1q�$	��150��$��28��.�� �� #��[  	Kostnad.���� -   $��NewInvoiceButton��$��15,1,1,1q�  buttonStyle#��[ .��
Lägg till� $��0��$��2��.+��� -   $��MainTabControl��.@��� -   $��InvoiceItemsTab��$��Fakturaposter��.���� -   $��invoiceListBox��$��Stretch=�����  �� View �� !	 �� ColumnHeaderContainerStyle	 �� 
 �� 
TargetType"
 ��.���  �� Property � �� �� Value$ Stretch=�.P���  �� Width$	 280������ $
��Namn��$
��Left=� �� CellTemplate �� .R���  �� TextAlignment$
 Left=�����  �� Path$
 Name��� $	 165������ $��Kostnad��$��Center=� �� .R��� $ Right=����� $
 Cost� �� StringFormat$ c���� $ 40������ $��Inkl.��$��Center=� �� .R��� $��Center=�$��Center=� d� 	IsChecked �� $ Include��� $ 70������ $��Radera��$��Center=� �� .R��� -   $��Center=�$��Center=�.��	Ta bort�� -   $��SolutionTab��$��Lösning��.���� -	   $��Results��$:��4Här kommer det presenteras en eventuell lösning...���� $��3��
�������
�������$��1q�$ 5��$ 1q�$��2q�._�� .+��� $��0��$��3��$ 
Horizontal=�.+��� $��Center=�.��
Delsumma�� -
   $��
SumTextBox��$	��100��$��20������ $	 Sum�$ c���� $��3��$ 
Horizontal=�$��Right=�.+��� -   #��[ .��	Importera�� -   #��[ .��Öppna�� -   #��[ .��Spara�� -   $��Calculate_Button��#��[ .��
Beräkna � 	Resources 5   /VilkenFakturaGUI.WidthCalculationMultiConverter   lastColumnMaximizerConverter��%   &	         