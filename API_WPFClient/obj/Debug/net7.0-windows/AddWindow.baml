   M S B A M L   `   `   `  ����H  DAPI_WPFClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:API_WPFClientAPI_WPFClient  5   	       API_WPFClient.AddWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:API_WPFClient     5   	     � Title$  	AddWindow��5   	   $	��450��6   $	��800��6(    � Icon$ Icon.png��5	   	    � 	Resources 5
         RoundButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ���	#FF3D64E6$��0q�5   !   $ 10��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   5      5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   	 � ColumnDefinitions	 5'   
   �� 5(      $��* �6   �� 5)      $��* �6   .+�5,   
   �� $��0��6   $��32(�6   $��Add a Country:��6+   $
��Left=�6D   $��
289,15,0,5q�6_   $��2��6s   �� 5.   
   $��1��6   $��0��6   $��Center=�6-   $��18(�6J   $��Countryname:��6X   �� 5/   
   -   5        
 ��Name$
 CountryTextBox��5/   =   $��1��6   $��1��6   $��18(�6/   $��75, 5q�6U   �� 51   
   $��2��6   $��0��6   $��Center=�6-   $��18(�6J   $��Capital:��6X   �� 52   
   -   5        $
 CapitalTextBox��52   =   $��2��6   $��1��6   $��18(�6/   $��75, 5q�6U   �� 54   
   $��3��6   $��0��6   $��Center=�6-   $��18(�6J   $��
Continent:��6X   �� 55   
   -   5        $
 ContinentTextBox��55   =   $��3��6   $��1��6   $��18(�6/   $��75, 5q�6W   �� 57   
   $��4��6   $��0��6   $��Center=�6-   $��18(�6J   $��Population:��6X   �� 58   
   -   5        $
 PopulationTextBox��58   =   $��4��6   $��1��6   $��18(�6/   $��75, 5q�6X   �� 5:   
   $��5��6   $��0��6   $��Center=�6-   $��18(�6J   $��	Currency:��6X   �� 5;   
   -   5        $
 CurrencyTextBox��5;   =   $��5��6   $��1��6   $��18(�6/   $��75, 5q�6V   �� 5=   
   $��6��6   $��0��6   $��Center=�6-   $��18(�6J   $��Common Languages:��6X   �� 5>   
   -   5        $
 CommonLanguagesTextBox��5>   =   $��6��6   $��1��6   $��18(�6/   $��75, 5q�6]   �� 5@   
   $��7��6   $��0��6   $��Center=�6-   $��18(�6J   $��
Imagelink:��6X   �� 5A   
   -   5        $
 ImagesourceTextBox��5A   =   $��7��6   $��1��6   $��18(�6/   $��75, 5q�6Y   �� 5C   
   -   5        $��8��5C      $��18(�6   #��[  6,   $��Add Country��6V   $
��Left=�6�   $��	340,5,0,5q�6�   ���	#FF3D64E6
�������$��30��6�   $	��120��6�   $��2��6�   5D      5E      