   M S B A M L   `   `   `  ����  Exercicio01-CadCliente)    #Exercicio01_CadCliente.wdCadProduto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  Cadastro de Produtos��5      $	��600��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$
 None=�6`    � 
ResizeMode$ NoResize=�6s    � 	Resources 5         	BlueSizex��%+   &	        ��5   
   	#FF537A7D��6-   5      .��5      � 
������� � RowDefinitions 5	   
   �� 5
      $��40 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � $��0��6   $��2��6   ���#547a7d � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      �� -   5         ��Name$ Titlelbl��5      $��- Cadastro de Clientes��6*   $
��Left=�6K   $��0,0,0,-0q�6f   $��0��6x   $
��Bold"�6�   $��Calibri)�6�   $��22(�6�   
�������6�   5      � 5      $��1��6   .+�5      �� -   5        $ Datelbl��5      $��Data:��6)   $��Right=�69   $��
0,0,150,-0q�6U   $��0��6i   $
��Bold"�6v   $��Calibri)�6�   $��22(�6�   ���	#00000000
�������6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ Datatxt��5      $��2��6.   $��Right=�6>   $��5,7,5,0q�6Z   $	��Top=�6k   $��0��6�   5      5      � 5   
   $��1��6   $��2��6    5       �� 5!      $	��150 �6#   �� 5"      $	��150 �6#   �� 5#      $��* �6#   �� 5$      $	��150 �6#   .+�5&      � $��0��6   .+�5'      �� -   5        $ CPFLbl��5'      $��CPF: ��6(   $��Stretch=�68   $��0,0,0,-0q�6V   $��0��6h   $
��Bold"�6u   $��Calibri)�6�   $��14(�6�   �� 5(      -   5        	 ��Name$	 CPFtxt��5(      $��	5,23,0,-0q�6*   
 �� TextWrapping$

 Wrap=�6=   $��1��6Q   ���	#FF7189CF �� TextAlignment$ Right=�6v   5)      � 5*      $��1��6   .+�5+      �� -   5        $ RGLbl��5+      $
��RG: ��6'   $��Stretch=�66   $��0,0,0,-0q�6T   $��0��6f   $
��Bold"�6s   $��Calibri)�6�   $��14(�6�   �� 5,      -   5        $	 RGtxt��5,      $��Stretch=�6)   $��5,23,0,0q�6G   $

 Wrap=�6Y   $��2��6m    �� CharacterCasing$ Upper=�6z   ���	#FF7189CF$ Right=�6�   5-      � 5.      $��2��6   .+�5/      �� -   5        $ NomeLbl��5/      $��Nome: ��6)   $��Stretch=�6:   $��0,0,0,-0q�6X   $��0��6j   $
��Bold"�6w   $��Calibri)�6�   $��14(�6�   �� 50      -	   5        $	 Nometxt��50      $��Stretch=�6+   $��5,23,0,0q�6I   $

 Wrap=�6[   $��3��6o   $ Upper=�6|   ���	#FF7189CF6�   51      � 52      $��3��6   .+�53      �� $��INATIVO��6   $��5,20,5,0q�6-   $
��Bold"�6?   ��.  6Q   54      55      � 56   
   $��2��6   $��2��6    57      �� 58      $��* �6#   �� 59      $	��100 �6#   �� 5:      $	��150 �6#   .+�5<      � $��0��6   .+�5=      �� -
   5        $ Endlbl��5=      $��Endereço: ��6(   $��Stretch=�6=   $��0,0,0,-0q�6[   $��0��6m   $
��Bold"�6z   $��Calibri)�6�   $��14(�6�   �� 5>      -   5        $	 Endtxt��5>      $��Stretch=�6*   $��	5,23,0,-0q�6H   $

 Wrap=�6[   $��4��6o   $ Upper=�6|   ���	#FF7189CF6�   5?      � 5@      $��1��6   .+�5A      �� -   5        $ 	NumEndlbl��5A      $��Numero: ��6+   $��Stretch=�6>   $��0,0,0,-0q�6\   $��0��6n   $
��Bold"�6{   $��Calibri)�6�   $��14(�6�   �� 5B      -   5        $	 	NumEndtxt��5B      $��Stretch=�6-   $��	5,23,0,-0q�6K   $

 Wrap=�6^   $��5��6r   $ Upper=�6   ���	#FF7189CF$ Right=�6�   5C      � 5D      $��2��6   .+�5E      �� -   5        $ BairroEndlbl��5E      $��Bairro: ��6.   $��Stretch=�6A   $��0,0,0,-0q�6_   $��0��6q   $
��Bold"�6~   $��Calibri)�6�   $��14(�6�   $��41��6�   $	��Top=�6�   �� 5F      -   5        $	 BairroEndtxt��5F      $��Stretch=�60   $��	5,23,5,-0q�6N   $

 Wrap=�6a   $��6��6u   ���	#FF7189CF6�   5G      5H      � 5I   
   $��3��6   $��2��6    5J      �� 5K      $	��100 �6#   �� 5L      $	��100 �6#   �� 5M      $	��150 �6#   �� 5N      $��* �6#   .+�5P      � $��0��6   .+�5Q      �� -   5        $ 	CidEndlbl��5Q      $��Cidade: ��6+   $��Stretch=�6>   $��0,0,0,-0q�6\   $��0��6n   $
��Bold"�6{   $��Calibri)�6�   $��14(�6�   �� 5R      -   5        $	 	CidEndtxt��5R      $��Stretch=�6-   $��	5,23,0,-0q�6K   $

 Wrap=�6^   $��7��6r   $ Upper=�6   ���	#FF7189CF6�   5S      � 5T      $��1��6   .+�5U      �� -   5        $ 	EstEndlbl��5U      $��Estado: ��6+   $��Stretch=�6>   $��0,0,0,-0q�6\   $��0��6n   $
��Bold"�6{   $��Calibri)�6�   $��14(�6�   �� 5V      -   5         ��Name$ 	EstEndcmb��5V      $��Stretch=�6.   $��	5,23,-0,0q�6L   $��Calibri)�6_   $��14(�6t   $��8��6�   ���	#FF7189CF.@�5W      �� $��	Acre (AC)��6#   �� 5X      $��Alagoas (AL)��6#   �� 5Y      $��Amapá (AP)��6#   �� 5Z      $��Amazonas (AM)��6#   �� 5[      $��
Bahia (BA)��6#   �� 5\      $��Ceará (CE)��6#   �� 5]      $��Espírito Santo (ES)��6#   �� 5^      $��Goiás (GO)��6#   �� 5_      $��Maranhão (MA)��6#   �� 5`      $��Mato Grosso (MT)��6#   �� 5a      $��Mato Grosso do Sul (MS)��6#   �� 5b      $��Minas Gerais (MG)��6#   �� 5c      $��
Pará (PA)��6#   �� 5d      $��Paraíba (PB)��6#   �� 5e      $��Paraná (PR)��6#   �� 5f      $��Pernambuco (PE)��6#   �� 5g      $��Piauí (PI)��6#   �� 5h      $��Rio de Janeiro (RJ)��6#   �� 5i      $��Rio Grande do Norte (RN)��6#   �� 5j      $��Rio Grande do Sul (RS)��6#   �� 5k      $��Rondônia (RO)��6#   �� 5l      $��Roraima (RR)��6#   �� 5m      $��Santa Catarina (SC)��6#   �� 5n      $��São Paulo (SP)��6#   �� 5o      $��Sergipe (SE)��6#   �� 5p      $��Tocantins (TO)��6#   5q      5r      � 5s      $��2��6   .+�5t      �� -   5        $ 	CEPEndlbl��5t      $��CEP: ��6+   $��Stretch=�6;   $��0,0,0,-0q�6Y   $��0��6k   $
��Bold"�6x   $��Calibri)�6�   $��14(�6�   �� 5u      -   5        $	 	CEPEndtxt��5u      $��Stretch=�6-   $��	5,23,5,-0q�6K   $

 Wrap=�6^   $ Right=�6r   $��9��6�   ���	#FF7189CF6�   5v      � 5w      $��3��6   .+�5x      �� -   5        $ 
CompEndlbl��5x      $��Complemento: ��6,   $��Stretch=�6D   $��0,0,0,-0q�6b   $��0��6t   $
��Bold"�6�   $��Calibri)�6�   $��14(�6�   �� 5y      -   5        $	 
CompEndtxt��5y      $��Stretch=�6.   $��	5,23,5,-0q�6L   $

 Wrap=�6_   $��10��6s   ���	#FF7189CF6�   5z      5{      � 5|   
   $��4��6   $��2��6    5}      �� 5~      $	��150 �6#   �� 5      $	��150 �6#   �� 5�      $��* �6#   �� 5�      $
��auto �6#   �� 5�      $
��auto �6#   .+�5�      � $��0��6   .+�5�      �� -   5        $ TipoContlbl��5�      $��Tipo: ��6-   $��Stretch=�6>   $��0,0,0,-0q�6\   $��0��6n   $
��Bold"�6{   $��Calibri)�6�   $��14(�6�   �� 5�      -   5        $ TipoContcmb��5�      $��Stretch=�60   $��	5,23,-0,0q�6N   $��Calibri)�6a   $��14(�6v   $��11��6�   ���	#FF7189CF.@�5�      �� $��Email��6#   �� 5�      $��Celular��6#   �� 5�      $��Telefone��6#   5�      5�      � 5�      $��1��6   .+�5�      �� -   5        $ 
Contatolbl��5�      $��	Contato: ��6,   $��Stretch=�6@   $��0,0,0,-0q�6^   $��0��6p   $
��Bold"�6}   $��Calibri)�6�   $��14(�6�   �� 5�      -   5        $	 
Contatotxt��5�      $��Stretch=�6.   $��	5,23,0,-0q�6L   $

 Wrap=�6_   $��12��6s   $ Upper=�6�   ���	#FF7189CF6�   5�      � 5�      $��2��6   .+�5�      �� -   5        $ 
OBSContlbl��5�      $��Observação: ��6,   $��Stretch=�6C   $��0,0,0,-0q�6a   $��0��6s   $
��Bold"�6�   $��Calibri)�6�   $��14(�6�   �� 5�      -   5        $	 
OBSConttxt��5�      $��Stretch=�6.   $��	5,23,5,-0q�6L   $

 Wrap=�6_   $��13��6s   ���	#FF7189CF6�   5�      � 5�      $��3��6   .+�5�      �� -   5         ��Name$ MaisBtn��5�      $��+��6*   $��Stretch=�66   $��5,15,0,0q�6T   $��20��6f   $��20��6q   ���	#FF5DFF00
����������	#FF5DFF00$��Calibri)�6�   $��	ExtraBold"�6�   $��14��6�   5�      � 5�      $��4��6    5�      �� 5�      $��4* �6$   �� 5�      .+�5�      �� -   5        $ MenosBtn��5�      $��-��6+   $��Stretch=�67   $��	10,18,5,2q�6U   $��20��6h   $��20��6s    J� RenderTransformOrigin$ 0.25,2.2&�6   
���  ��
�������
���  ��$��	ExtraBold"�6�   $��Calibri)�6�   $��2��6  $��15��6  5�      5�      � 5�   
   $��5��6   .+�5�      &   System.Windows.Controls.DataGrid  $��Stretch=�6   $��5,5,5,5q�65      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Tipo de Contato��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6B     5�      $ Contato��6)   $	 150 6:     5�      $ Observação��6)   $ * 6=   5�      5�      � 5�   
   $��6��6   $��Stretch=�6   ���#c5cd39.+�5�      � $��0��6   $��Right=�6     5�      �� 5�      $��90 �6'   �� 5�      $��90 �6'   .+�5�      � $��0��6   .+�5�      �� -    5        $ 	SalvarBtn��5�      $��Salvar [F2]��60   $��Stretch=�6F   $��0,5,5,5q�6d   $��14(�6v   $��Calibri)�6�   $��SemiBold"�6�   
�������
�������$��16��6�   5�      � 5�      $��1��6   .+�5�      �� -!   5        $ 
ExcluirBtn��5�      $��Excluir [F3]��61   $��Stretch=�6H   $��0,5,5,5q�6f   $��14(�6w   $��Calibri)�6�   $��SemiBold"�6�   
�������
�������$��17��6�   5�      5�      5�      5�      5�      