   M S B A M L   `   `   `  ���� C  ?Languago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Languago.ViewsLanguago.Views       Languago.Views.SessionView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:Languago.Views     $	��600��$
��1053��$	��600��  J� InputBindings  �� 
 �� Key$ z�� �� Command �� *PreviousWordCommand+�� $ a�� �� *CheckPronunCommand+�� $ s�� �� *HearPronunCommand+�� $ d�� �� *HearPronunCommand+�� $ f�� �� *HearPronunCommand+�� $ c�� �� *NextWordCommand+.��� ����  �� ImageSource$) #/Views/50104273998_3bb93042c6_o.jpg�� � RowDefinitions �� $	��65* ��� $
��519* � � ColumnDefinitions �� $	��74* ��� $
��277* �.+��� 
���   �$��2�����	#FFA0A0A0$��0,0,0,10q��� -    ��Name$ 
ExitButton��$
��Exit��$��0,8,32,0q�$��1��$��64��$��40��$	��Top=�$��Right=����� *ExitSessionCommand+� $��1��$��18,49,107,0q����	#FF00B621 J� RenderTransformOrigin$ 0.5,0.5&�$��6��$	��Top=� � Value �� *ProgressBar+z�V� .~��� 	 �� ScaleY$	 1Q��� �� T� �� -   
 ��Name$
 WordID��$��1��$��110,13,0,31q�$
��Wrap=�$��Bahnschrift Light)�$��22(�$
��Left=�$��46������ *Word+��  � Language$ pl-pl�$�00���� $��1��$��1��
���   �����  �� Color$ 	#FFD3D2D2�� �� Opacity$ 1Q��� -   $ 
HearButton��$��Hear
pronunciation��$��1��$��465,395,0,0q�$��1��$��70��$	��Top=�$
��Left=�$	��104��4  .System.Windows.Automation.AutomationProperties   	AccessKey$ S������ *HearPronunCommand+�� -   $ CheckButton��$��Check 
pronunciation��$��1��$��246,395,0,0q�$��1��$��70��$	��Top=�$
��Left=�$	��104��   AcceleratorKey$  ��$ a������ *CheckPronunCommand+�� -   $ 
NextButton��$
��Next��$��1��$��
0,414,39,0q�$��1��$��48��$	��Top=�$��Right=�$��57������ *NextWordCommand+�� -   $ PreviousButton��$��Previous��$��1��$��
30,414,0,0q�$��1��$��48��$	��Top=�$
��Left=����� *PreviousWordCommand+�� $��1��$��
0,168,46,0q�$��1��$��1��$	��Top=�
���   � �� RadiusX$ 8�� �� RadiusY$ 8��$��Right=��� $��1��$��226,351,227,0q�$��1��
���   �$ 8��$ 8��$��1��$	��Top=��� -   $
 PronunciationText��$��1��$��226,319,227,0q�$��1��$
��Wrap=�$��23(�$��29��$	��Top=� �� TextAlignment$ Center=����� *Pronunciation+�� $��1��$��
24,168,0,0q�$��1��$��1��$	��Top=�
���   �$ 8��$ 8��$
��Left=�$	��366���� -   $
 ExamplesText��$��1��$��	24,0,45,0q�$��1��$
��Wrap=�$��15(�$��23��$��Center=�$ Center=����� *	Example+�� $��1��$��24,277,46,0q�$��1��$��1��$	��Top=�
���   �$ 8��$ 8���� -	   $
 
EnglishBox��$��1��$��466,135,21,0q�$��1��$
��Wrap=�$��23(�$��34��$	��Top=�$ Center=����� *	English+�� -
   $
 	FrenchBox��$��1��$��24,134,441,0q�$��1��$
��Wrap=�$��23(�$��34��$	��Top=�$ Center=����� *French+�� $��French��$��1��$��182,169,0,0q�$��1�����	#FF515151$��42��$	��Top=�$
��Left=�$��50���� $��English��$��1��$��0,170,169,0q�$��1�����	#FF404040$��29��$	��Top=�$��Right=�$��50���� $��Examples��$��1��$��384,277,385,0q�$��1�����	#FF515151$��29��$	��Top=��� $��Your pronunciation��$��1��$��354,345,362,0q�$��1�����	#FF515151$��42��$	��Top=��� $��Key S��$��1��$��465,465,0,0q����	#FF3E3E3E$��16��$	��Top=����	#FFA4A4A4$��10(�$��1��$��1,1,1,1q�$��Center=�$��Normal"�$
��Left=�$	��104���� $��Grammar��$��1��$��62,44,707,0q�$��1�����	#FF515151$��26��$	��Top=��� $��1��$��24,44,669,0q�$��1��$��1��$	��Top=�
���   �$ 8��$ 8���� -   $
 GrammarText��$��1��$��24,10,669,0q�$��1��$
��Wrap=�$��23(�$��34��$	��Top=�$ Center=����� *	Grammar+�� $��Key A��$��1��$��246,465,0,0q����	#FF3E3E3E$��16��$	��Top=����	#FFA4A4A4$��10(�$��1��$��1,1,1,1q�$��Center=�$��Normal"�$
��Left=�$	��104���� $��Key Z��$��1��$��
30,398,0,0q����	#FF3E3E3E$��16��$	��Top=����	#FFA4A4A4$��10(�$��1��$��1,1,1,1q�$��Center=�$��Normal"�$
��Left=�$��49���� $��Key C��$��1��$��
0,398,39,0q����	#FF3E3E3E$��16��$	��Top=����	#FFA4A4A4$��10(�$��1��$��1,1,1,1q�$��Center=�$��Normal"�$��Right=�$��57���� -   $
 SessionDetails_Copy3��$��1��$��8,13,0,0q�$
��Wrap=�$��Bahnschrift Light)�$��22(�$��31��$	��Top=�$
��Left=�$	��102���� $ pl-pl�$�Word num���� -   $
 SessionDetails_Copy��$��1��$��
168,13,0,0q�$
��Wrap=�$��Bahnschrift Light)�$��22(�$��26��$	��Top=�$
��Left=�$��65���� $ pl-pl�$�Range���� -   $
 Range��$��1��$��233,13,556,31q�$
��Wrap=�$��Bahnschrift Light)�$��22(����� *Range+�� $ pl-pl�$�00���� $��1��$��465,169,21,0q�$��1��$��1��$	��Top=�
���   �$ 8��$ 8��