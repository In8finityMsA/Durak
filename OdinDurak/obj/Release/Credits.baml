   M S B A M L   `   `   `  ����   	OdinDurak    OdinDurak.Credits   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��500��$	��500��
���   � � Triggers :�  :� RoutedEvent$ Window.Loaded��.[��� .���� -    g�Name$ story��.��W�  �� 
TargetName$ TextPos�� �� TargetProperty$ OffsetY� W� From$
 -1.5X�	 W� To$ 5X� g� Duration$ 0:1:30D�.��� .+�'� -   $��viewport3D1��	 '� Camera	 =� -   camMain��
 � Position$
 
0.5 -1 0.41� � LookDirection$ 0 5 -15�.x�g�  g� Content ��  �� Color$ White��g�  �  � Geometry k� -   meshMain�� k� 	Positions- �   @ ���� 5 ����@  5  k� TriangleIndices �      k� TextureCoordinates �    � Material u� -   matDiffuseMain�� u� Brush !�  !� Visual � $	��200��$
��1000��
���   �.+��� 
���   �._��� 
���   �$
��Wrap=����	#FFFFDA00$��Franklin Gothic)�$
��Bold"�$��16(� �� TextAlignment$ Justify=� �� 
LineHeight$ 17�� �� LineStackingStrategy$ BlockLineHeight=�Ну что�� �� )'Вот ты и разъебал нас.�� �� ��Мы проебали два лектоса и пару часов вечером только чтобы написать это говно�� �� ��Да, код говно. Да, легко сломать и нихуя не работает. Но какой ценой мы написали это дерьмо?�� �� ЦЕНОЙ ВСЕГО!�� �� 86И на прощание хочется сказать�� �� �� �� !ЛОВИ БСОД В ЕБАЛО g� 	Transform S� -   TextPos�� S� OffsetY$
 -1.5Q�g�  �  k� -   
meshShadow��E �   @  � ��  5  � �� @ @KL ��  5 @KL ��  �      �    u� -   matDiffuseShade�� ��  �� 
StartPoint$	 0,0&� �� EndPoint$	 0,1&�.���  � Color$ Black�� � Offset$
 0.85Q�� $ 	#00000000��$	 1.0Q�