   M S B A M L   `   `   `  ���� D  @OdinDurak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OdinDurak	OdinDurak      OdinDurak.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:OdinDurak     -     � Title$  Durak��$	��450��$	��800��.��� -   -  'System.Windows.Input.KeyboardNavigation   	IsTabStop .     TabNavigation$
 None=�   DirectionalNavigation$
 None=�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 1,1&�.���  � Color$	 Red�� � Offset$ 0.151Q�� $ Orange��$ 0.167Q�� $ Yellow��$ 0.327Q�� $
 Lime��$ 0.488Q�� $
 Blue��$ 0.661Q�� $ Magenta��$ 0.828Q�� $ 	#FFFFCF00��$ 0.323Q�� $ 	#FFFCFF00��$ 0.479Q�� $ 	#FF00FF3A��$
 0.65Q�� $ 	#FE0000FF��$ 0.813Q�.+��� $��Center=�$��85��$��0,50,0,0q�$
��Wrap=�$	��Top=�$	��500��$��30(�$��Comic Sans MS)� �� TextAlignment$ Center=�$
��Bold"�	 J� Effect	 3  -System.Windows.Media.Effects.DropShadowEffect  
   Color$
 	#FFFF0000��97Ну вот ты скажи, только честно.�� ТЫ СОВСЕМ ДЕБИЛ?�� -   $��YesBtn��$
��Left=�$	��Top=�$	��100��$	��100��$��32(�$��Comic Sans MS)�$
��Bold"�$��200,200,0,0q�$��5q�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ��ح���  � �� ��  �� 
TargetType" ��.R���  ��Name$ Border��#��z��$��5q� �� CornerRadius$ 10������ $ 0.5,1&� � MappingMode$ RelativeToBoundingBox=�$ 0.5,0&�.��� $	 Red��$ 1Q�� $ 	#FFFFA400��$
 0.74Q�� $
 Lime��$ 0.542Q�� $
 Blue��$ 0.339Q�� $ 	#FFDD00FF��$ 0.142Q�._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ Border�� � �� ��  �� ImageSource$ Assets/luka_ziga.jpg������ $ Assets/luka_klass.jpg�� j� Stretch$ UniformToFill=����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF0DFF0D��$ 0.819Q�� $	 Red��$ 0.551Q�� $ 	#FFAFFF11��$ 0.657Q�� $ 	#FFFF0101��$ 0.643Q�.��ДА�� -    ��Name$ NoPanel��$��Right=�$	��Top=�$��0,180,180,0q�
������  .  $
 None=�$
 None=�.+��� -    ��Name$ NoBtn��$��20q�$��Right=�$	��Top=�$	��100��$	��100��$��32(�$��Comic Sans MS)�$
��Bold"�$��5q�$��НЕТ��
���  �� .  $
 None=�$
 None=����� " ��.���  � ��
 ��ح���  � �� �� " ��.R��� $ Border��#��z��$��5q�$ 10��._��� $��Center=�$��Center=����� $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0.305Q�� $ White��$ 1Q�� $	 Red��$ 0.341Q�� $ White��$ 0.695Q�� $	 Red��$ 0.659Q� P�  �@J�IsMouseOver . . ��� $ Border�� � �� �� $ Assets/rikardo_milos.jpg������ $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0.305Q�� $ White��$ 1Q�� $	 Red��$ 0.341Q�� $ White��$ 0.695Q�� $	 Red��$ 0.659Q����� $ Assets/rikardo_milos1.gif��$ UniformToFill=�r� -    r�Name$ media�� r� Source$ Assets/videoplayback.mp4?� r� LoadedBehavior$ Manual=�$y�Hidden=�$��Center=�$	��420��$��0,0,0,0q�$��Center=�$	��800��