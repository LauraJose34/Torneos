   M S B A M L   `   `   `  ����E  ATorneo.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Torneo.GUI
Torneo.GUI  5   	       Torneo.GUI.Menu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Torneo.GUI     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	     � Title$
  Menu��5	   	   $	��600��6   $
��1000��6#   ��5
      �� 5   
   .��5      �� ��5   
   �� 5       �� ImageSource$ Imagenes/IMG_259233.jpg��6   .@�5   
   �� $��Inicio��6   $��90��6"   .��5      � $��0,-4,0,0q�6    � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $
��auto �6'   .+�5      � $��0��6   $��1��6,    � Orientation$ Vertical=�69   
���   �$��0,20,0,0q�6c   .+�5      � $ 
Horizontal=�6    .+�5      �� $��40��6    $��80��6,   
�������$��18(�6J   $
��Bold"�6X   .��6j   	Usuario6s   �� 5      -   5         ��Name$ txbUsuarioInicio��5   "   $��35��6<   $	��200��6H   ���	#FFCDBA05$��16(�6�   $
��Bold"�6�   ��6T   Z� ��6�   Z� 6�   5      � 5       $ 
Horizontal=�6    .+�5!      �� $��40��6    $��80��6,   
�������$��18(�6J   $
��Bold"�6X   .��6j   Puesto6r   �� 5"      -   5        $ txbTipoInicio��5"   "   $��35��69   $	��200��6E   ���	#FFCDBA05$��16(�6~   $
��Bold"�6�   ��6Q   Z� ��6�   Z� 6�   5#      5$      5%      5&      �� 5*   
   $��Deporte��6   $	��100��6#   .��5+      �  5,      �� 5-      $	��120 �6$   �� 5.      $��* �6$    50      �� 51      $
��auto �6'   �� 52      $��* �6'   .+�54      � $��0��6   $��15,15,15,24q�6,   ��55      �� 56       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��57      �  � Color$ Black��6+   	 � Offset$	 0Q�69   � 58      $ 	#FF0E1F21��6+   $	 1Q�6=   59      .+�5;      � $ Vertical=�6    .+�5<      �� 
 �� Orientation$
 
Horizontal=�6%   $��10q�6>   $��Center=�6J   $��59��6g   .+�5=      �� $��30��6$   $	��170��60   ���	#FFF2F2FF$��14(�6S   .��6a   Ingrese el Nuevo Deporte6{   �� 5>      -   5        $ txtDeportesDeportes��5>   &   $	��280��6C   $��25��6O   $��14(�6[   6k   5?      5@      5A      � 5B      $��1��6   $��10q�6)   $ 
Horizontal=�65   .+�5C      �� -   5         ��Name$ btnNuevoDeporte��5C   3   $��85��6   $��2q�6(   $��35��6j   ���	#FF3A3333���	#FFFDFDFD.��5D      �� $
 
Horizontal=�6%   .+�5E      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Nuevo6b   �� 5F      $��/Imagenes/disk.png��6$   $��16��6@   6N   5G      5H      �� 5I      -   5        $ btnAgregarDeporte��5I   3   $��85��6   $��2q�6(   ���	#FF3A3333���	#FFFDFDFD.��5J      �� $
 
Horizontal=�6%   .+�5K      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   	Agregar6d   �� 5L      $��/Imagenes/add.png��6$   $��16��6?   6M   5M      5N      �� 5O      -   5        $ btnEditarDeporte��5O      $��85��6V   $��2q�6a   ���	#FF3A3333���	#FFFDFDFD.��5P      �� $
 
Horizontal=�6%   .+�5Q      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Editar6c   �� 5R      $��/Imagenes/world_edit.png��6$   $��16��6F   6T   5S      5T      �� 5U      -   5        $ btnEliminarDeporte��5U      $��85��6Z   $��2q�6e   ���	#FF3A3333���	#FFFDFDFD.��5V      �� $
 
Horizontal=�6%   .+�5W      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Eliminar6e   �� 5X      $!��/Imagenes/basket_remove.png��6$   $��16��6I   6W   5Y      5Z      �� 5[      -   5        $ btnCancelarDeporte��5[      $��85��6Z   $��2q�6e   ���	#FF3A3333���	#FFFDFDFD.��5\      �� $
 
Horizontal=�6%   .+�5]      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Cancelar6e   �� 5^      $��/Imagenes/cancel.png��6$   $��16��6B   6P   5_      5`      5a      &   System.Windows.Controls.DataGrid  5c      -	   5          Name$ 
dtgDeporte��5c      $��1��6/   $��0��6?   $��2��6L      
IsReadOnly . $��0,0,0,25q�6p   5d      5e      �� 5h   
   $��Equipos��6   $	��100��6#   .��5i      �  5j      �� 5k      $
��auto �6$   $	��421��62   �� 5l      $��* �6$    5n      �� 5o      $
��auto �6'   $	��489��64   �� 5p      $��* �6'   .+�5r      � $��0��6   $��0��6)   $��
10,10,10,0q�69   $ Vertical=�6M   ��5s      �� 5t      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5u      � $ Black��6+   $	 0Q�69   � 5v      $ 	#FF0E1F21��6+   $	 1Q�6=   5w      .+�5y      � $ Vertical=�6    .+�5z      �� $��10q�6    $��Center=�6,   
�������$��18(�6\   $
��Bold"�6j   .��6|   Información Básica6�   �� 5{      $
 
Horizontal=�6%   .+�5|      �� $��30��6$   $	��170��60   ���	#FFF2F2FF$��14(�6S   .��6a   Nombre del Equipo6t   �� 5}      -
   5        $ txtNombreEquipo��5}   &   $	��280��6?   $��25��6K   $��14(�6W   6g   5~      �� 5      $
 
Horizontal=�6%   .+�5�      �� $��30��6$   $	��170��60   ���	#FFF2F2FF$��14(�6S   .��6a   
Director6k   �� 5�      -   5        $ txtDirectorEquipo��5�   &   $	��280��6A   $��25��6M   $��14(�6Y   6i   5�      �� 5�      $
 
Horizontal=�6%   .+�5�      �� $��30��6$   $	��170��60   ���	#FFF2F2FF$��14(�6S   .��6a   Tipo de Deporte6r   �� 5�      -   5         ��Name$ txtTipoDeporteEquipo��5�   '   $	��280��6E   $��25��6Q   $��14(�6]   6n   5�      5�      5�      � 5�      $��1��6   $��0��6)   $��10,10,10,54q�69   $ 
Horizontal=�6N   .+�5�      �� -   5        $ btnNuevoEquipo��5�      $��85��6S   $��2q�6^   $��35��6i   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Nuevo6b   �� 5�      $��/Imagenes/disk.png��6$   $��16��6@   6N   5�      5�      �� 5�      -   5        $ btnAgregarEquipo��5�      $��85��6V   $��2q�6a   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   	Agregar6d   �� 5�      $��/Imagenes/add.png��6$   $��16��6?   6M   5�      5�      �� 5�      -   5        $ btnEditarEquipo��5�      $��85��6T   $��2q�6_   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Editar6c   �� 5�      $��/Imagenes/world_edit.png��6$   $��16��6F   6T   5�      5�      �� 5�      -   5        $ btnEliminarEquipo��5�      $��85��6Y   $��2q�6d   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Eliminar6e   �� 5�      $!��/Imagenes/basket_remove.png��6$   $��16��6I   6W   5�      5�      �� 5�      -   5        $ btnCancelarEquipo��5�      $��85��6Y   $��2q�6d   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Cancelar6e   �� 5�      $��/Imagenes/cancel.png��6$   $��16��6B   6P   5�      5�      5�      � 5�      $��1��6   $��0��6,   $��2��69   $ Vertical=�6J   $��
0,5,5,-130q�6a   .+�5�      � $��5q�6    .+�5�        -   5        $ 	dtgEquipo��5�   #   $	��360��66   $	��850��6C    . 6c   5�      5�      5�      5�      �� 5�   
   $��Torneos��6   $	��100��6#   .��5�      � $��4,0,-4,0q�6    5�      �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $��* �6$    5�      �� 5�      $
��auto �6'   �� 5�      $��* �6'   .+�5�      � $
��Left=�6   $��10q�67   $��0��6C   $��0��6S   $	��550��6`   ��5�      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ Black��6+   $	 0Q�69   � 5�      $ 	#FF102325��6+   $	 1Q�6=   5�      .+�5�      �� $��Center=�6!   $��27q�6>   .+�5�      �� $
 
Horizontal=�6%   .+�5�      �� $��30��6$   $	��170��60   ���	#FFF2F2FF$��14(�6S   .��6a   Fecha6h   (  "System.Windows.Controls.DatePicker  5�      -   5          Name$ clFechaTorneo��5�   )   $	��280��6@   $��25��6L   6Z   5�      �� 5�      $
 
Horizontal=�6%   .+�5�      �� $��30��6$   $	��170��60   ���	#FFF2F2FF$��14(�6S   .��6a   Tipo de deporte6r   �� 5�      -   5        $ cmbTipoDeporteTorneo��5�   '   $	��220��6E   $��25��6Q   6`   �� 5�      -   5        $ btnBuscadorTorneo��5�   %   $��3q�6`   $��23��6k   $��23��6w    � ToolTip$ Ver Equipos��6�   .��5�   "   �� $��/Imagenes/ico_search.png��6(   $��16��6J   6X   5�      �� 5�      -   5        $! EliminacionDeTorneoCompleto��5�   %   $��3q�6u   $��23��6�   $��23��6�   $ Eliminar Torneo��6�   ���	#FFFDFDFD.��5�   "   �� $��/Imagenes/cart_remove.png��6(   $��18��6K   6Y   5�      5�      5�      5�      � 5�      $��0��6   $��1��6,   $ 
Horizontal=�69   $��Center=�6R   .+�5�      �� -   5        $ btnNuevoTorneo��5�      $��85��6R   $��2q�6]   $��35��6i   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Nuevo6b   �� 5�      $��/Imagenes/disk.png��6$   $��16��6@   6N   5�      5�      �� 5�      -   5        $ btnOrdenarTorneo��5�      $��85��6V   $��2q�6a   $��35��6l   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   	Ordenar6d   5�      5�      �� 5�      -   5        $ btnEliminarTorneo��5�      $��85��6X   $��2q�6c   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Eliminar6e   �� 5�      $!��/Imagenes/basket_remove.png��6$   $��16��6I   6W   5�      5�      �� 5�      -   5        $ btnCancelarTorneo��5�      $��85��6X   $��2q�6c   ���	#FF3A3333���	#FFFDFDFD.��5�      �� $
 
Horizontal=�6%   .+�5�      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Cancelar6e   �� 5�      $��/Imagenes/cancel.png��6$   $��16��6B   6P   5�      5�      5�      �� 5�      $��122,10,122,96q�6   $��1��6/   $��0��6@   
�������$��18(�6`   $
��Bold"�6n   $��Center=�6�   ��5�      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ Black��6+   $	 0Q�69   � 5�      $ 	#FF102325��6+   $	 1Q�6=   5�      .��5�   (   Lista De Equipos5�        5�      -   5        $ dtgDatosDeporte2��5�      $��1��65   $��
10,49,10,0q�6E    . $��2��6k   �� 5�      $��5q�6   $��1��6#   $��2��64   
�������$��18(�6T   $
��Bold"�6b   $��Center=�6t   ��5�      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ Black��6+   $	 0Q�69   � 5�      $ 	#FF102325��6+   $	 1Q�6=   5      .��5  (   Torneos Generados5       5     -   5        $ 	dtgPrueba��5     $��1��6.   $��3��6>   $��4��6K    . $��10q�6o   �� 5     $��5q�6   $��0��6#   $��2��64   
�������$��18(�6T   $
��Bold"�6b   $��Center=�6t   ��5     �� 5     $ 0.5,1&�6.   $ 0.5,0&�6?   .��5     � $ Black��6+   $	 0Q�69   � 5     $ 	#FF102325��6+   $	 1Q�6=   5	     .��5
  (   Simulación de Torneo5       5     -   5        $ dtgDatosDeporte��5     $��3��64   $��15,10,15,131q�6A    . 6W   5     5     �� 5  
   $��Puntos Equipos��6   $	��100��6*   .��5     �  5     �� 5     $
��auto �6$   �� 5     $
��auto �6$   �� 5     $
��auto �6$   �� 5     $
��auto �6$   �� 5     $
��auto �6$   �� 5     $
��auto �6$   �� 5     $
��auto �6$   .+�5     � $��0��6   $��0��6,   $��50��69   $��Center=�6E   $��5q�6b   ��5     �� 5      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5!     � $ Black��6+   $	 0Q�69   � 5"     $ 	#FF0E1F21��6+   $	 1Q�6=   5#     .+�5%     �� $
 
Horizontal=�6!   .+�5&     �� 
�������$��30��63   $	��180��6?   $��14(�6K   .��6Z   Tipo de Deporte6k   �� 5'     -   5        $ cmbDeportePuntosEquipos��5'  #   $��25��6D   $	��220��6P   6^   5(     �� 5)     $
 
Horizontal=�6!   .+�5*     �� 
�������$��30��63   $	��180��6?   $��14(�6K   .��6Z   Fecha programada6l     5+     -   5        $ clcFechaPuntosEquipos��5+  %   $��25��6D   $	��220��6P   6^   5,     �� 5-     .+�5.     �� -    5        $ PuntosEquiposBuscador��5.  !   $ Buscar��6d   $��22��6u   $��5q�6�   $��30��6�   .��5/     �� $��/Imagenes/ico_search.png��6$   $��18��6F   6U   50     51     �� 52     .+�53     �� -!   5        $ PuntosRegresarTabla��53  !   $ 	Ver datos��6a   $��22��6u   $��5q�6�   $��30��6�   .��54     �� $��/Imagenes/book_open.png��6$   $��18��6E   6T   55     56     57       58     -"   5        $ dtgPuntosEquipos��58     $��1��65   $��10q�6B   $	��240��6N   $	��800��6[    . 6�   � 59     $��0��6   $��2��6,   $	��766��69   $��Center=�6E   $��110,12,110,0q�6b   ��5:     �� 5;     $ 0.5,1&�6.   $ 0.5,0&�6?   .��5<     � $ Black��6+   $	 0Q�69   � 5=     $ 	#FF0E1F21��6+   $	 1Q�6=   5>     .+�5@     � $ Vertical=�6    .+�5A     � $ 
Horizontal=�6$   .+�5B     �� $
 
Horizontal=�6)   .+�5C  "   �� 
�������$��30��6;   $	��120��6G   $��14(�6S   $��5q�6a   .��6l   Identificador6{   �� 5D  "   -#   5        $" txtPuntosToneroIdentificador��5D  *    �� 
IsReadOnly . $��25��6b   $	��350��6n   6|   5E     5F     5G     � 5H     $ 
Horizontal=�6    .+�5I     �� $
 
Horizontal=�6%   .+�5J     �� 
�������$��30��67   $	��120��6C   $��14(�6O   $��5q�6]   .��6h   
Equipo 16r   �� 5K     -$   5        $ txtPuntosToneroEquipo1��5K  &    . $��25��6X   $	��220��6d   6r   5L     �� 5M     $
 
Horizontal=�6%   .+�5N     �� 
�������$��30��67   $	��120��6C   $��14(�6O   $��5q�6]   .��6h   
Equipo 26r   �� 5O     -%   5        $ txtPuntosToneroEquipo2��5O  &    . $��25��6X   $	��220��6d   6r   5P     �� 5Q     $
 
Horizontal=�6%   .+�5R     �� 
�������$��30��67   $	��120��6C   $��14(�6O   $��5q�6]   .��6h   
Marcador 16t   �� 5S     -&   5        $ txtPuntosMarcador1��5S  &   $��25��6B   $	��220��6N   6\   5T     �� 5U     $
 
Horizontal=�6%   .+�5V     �� 
�������$��30��67   $	��120��6C   $��14(�6O   $��5q�6]   .��6h   
Marcador 26t   �� 5W     -'   5        $ txtPuntosMarcador2��5W  &   $��25��6B   $	��220��6N   6\   5X     5Y     5Z     � 5[     $��Center=�6   $��0��69   $��4��6I   $��2q�6V   .+�5^     �� -(   5        $ btnEditarPuntosEquipos��5^  3   $��85��6   $��5q�6(   ���	#FF3A3333���	#FFFDFDFD.��5_     �� $
 
Horizontal=�6%   .+�5`     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Editar6c   �� 5a     $��/Imagenes/world_edit.png��6$   $��16��6F   6T   5b     5c     �� 5d     -)   5        $ btnEliminarPuntosEquipos��5d  3   $��85��6   $��5q�6(   ���	#FF3A3333���	#FFFDFDFD.��5e     �� $
 
Horizontal=�6%   .+�5f     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Eliminar6e   �� 5g     $!��/Imagenes/basket_remove.png��6$   $��16��6I   6W   5h     5i     �� 5j     -*   5        $ btnCancelarPuntosEquipos��5j  3   $��85��6   $��5q�6(   ���	#FF3A3333���	#FFFDFDFD.��5k     �� $
 
Horizontal=�6%   .+�5l     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Cancelar6e   �� 5m     $��/Imagenes/cancel.png��6$   $��16��6B   6P   5n     5o     5p     5q     5r     �� 5x  
   $��Estadisticos��6   $	��100��6(   .��5y     �  5z     �� 5{     $
��121* �6'   �� 5|     $
��372* �6'    5~     �� 5     $
��auto �6$   �� 5�     $
��452* �6$   .+�5�     � $��0��6   $��0��6,   $��2��69   $��15q�6N   ��5�     �� 5�     $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�     � $ Black��6+   $	 0Q�69   � 5�     $ 	#FF0E1F21��6+   $	 1Q�6=   5�     .+�5�     �� $
 
Horizontal=�6!   .+�5�     �� 
�������$��30��63   $	��160��6?   $��14(�6K   $��5q�6Y   .��6d   Ingrese Fecha de Torneo6}     5�     -+   5        $ clcFechaEstadisticos��5�  =   $��35��6%   $	��220��61   6]   5�     �� 5�     $
 
Horizontal=�6!   .+�5�     �� 
�������$��30��63   $	��125��6?   $��14(�6K   $��5q�6Y   .��6d   Ingrese El Deporte6x   �� 5�     -,   5        $ cmbEstadisticosEquipos��5�  ;   $��25��6#   $	��220��6/   6]   5�     �� 5�     --   5        $ btnCalcularEstadisticos��5�  @   $��90��6   $��2q�6(   $��35��64   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5�     �� ���	#FFF5ECEC$
��Bold"�6;   $��12(�6M   .��6[   
Calcular6e   �� 5�     $��/Imagenes/calculator.png��6$   $��18��6F   6T   5�     5�     �� 5�     -.   5        $ btnImprimirEstadisticos��5�  @   $��90��6   $��2q�6(   $��35��64   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5�     �� ���	#FFF5ECEC$
��Bold"�6;   $��12(�6M   .��6[   
Imprimir6e   �� 5�     $��/Imagenes/printer.png��6$   $��18��6C   6Q   5�     5�     5�       5�     -/   5        $ dtgTablaEstadisticos��5�  E   $��0��6   $��1��6,   $��20q�69   6e     OxyPlot.Wpf.PlotView  5�     -0   5          Name$ Grafica��5�     $��1��60   $��1��6@   $��20q�6M   5�     5�     �� 5�  
   $��Usuario��6   $	��100��6#   .��5�     � ��5�     �� 5�     $ Imagenes/IMG_259233.jpg��6!    5�     �� 5�     $
��auto �6'   �� 5�     $��* �6'    5�     �� 5�     $
��auto �6$   �� 5�     $��* �6$   .+�5�     � $��10q�6   $ Vertical=�6(   $��0��6?   $��0��6L   ��5�     �� 5�     $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�     � $ Black��6+   $	 0Q�69   � 5�     $ 	#FF0E1F21��6+   $	 1Q�6=   5�     .+�5�     �� $
 
Horizontal=�6!   $��1q�6:   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Nombre6e   �� 5�     -1   5        $ txtNombreUsuario��5�  "   $	��280��6<   $��25��6H   $��14(�6T   6d   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Apellido Paterno6o   �� 5�     -2   5        $ txtApellidoPaternoUsuario��5�  "   $	��280��6E   $��25��6Q   $��14(�6]   6m   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Apellido Materno6o   �� 5�     -3   5        $ txtApellidoMaterno��5�  "   $	��280��6>   $��25��6J   $��14(�6V   6f   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Fecha De Nacimiento6r     5�     -4   5        $ clcFechaUsuario��5�  %   $	��280��6>   $��25��6J   $��14(�6V   6f   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   
Telefono6g   �� 5�     -5   5        $ txtTelefono��5�  "   $	��280��67   $��25��6C   $��14(�6O   6_   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   	Domicilio6h   �� 5�     -6   5        $ txtDomicilioUsuario��5�  "   $	��280��6?   $��25��6K   $��14(�6W   6g   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Nombre de usuario6p   �� 5�     -7   5        $ txtNombreDeUsuario��5�  "   $	��280��6>   $��25��6J   $��14(�6V   6f   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Tipo de Usuario6n   �� 5�     -8   5        $ txtTipoUsuario��5�  "   $	��280��6:   $��25��6F   $��14(�6R   6b   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   	Deporte6f   �� 5�     -9   5        $ txtDeporteUsuario��5�  #   $	��280��6>   $��25��6J   $��14(�6V   6f   5�     �� 5�     $
 
Horizontal=�6!   $��1q�6;   .+�5�     �� $��30��6    $	��150��6,   ���	#FFF2F2FF$��14(�6O   .��6]   Contraseña6i   G� 5�     -:   5         G�Name$ txtContrasenaUsuario��5�  >   $	��250��6&   $��25��62   $��14(�6\   �� 5�     -;   5         ��Name$ boxContrasena��5�  .   $��5q�6#   6J   5�     5�     � 5�     $��10q�6   $ 
Horizontal=�6(   $��0��6A   $��1��6Q   .+�5�     �� -<   5        $ btnNuevoUsuario��5�  3   $��85��6   $��2q�6(   $��35��6j   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5�     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Nuevo6b   �� 5�     $��/Imagenes/disk.png��6$   $��16��6@   6N   5�     5�     �� 5�     -=   5        $ 
btnAgregar��5�  3   $��85��6   $��2q�6(   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5�     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   	Agregar6d   �� 5�     $��/Imagenes/add.png��6$   $��16��6?   6M   5�     5�     �� 5�     ->   5        $ btnEditarUsuario��5�  3   $��85��6   $��2q�6(   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5�     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   Editar6c   �� 5�     $��/Imagenes/world_edit.png��6$   $��16��6F   6T   5�     5�     �� 5�     -?   5        $ btnEliminarUusraios��5�  3   $��85��6   $��2q�6(   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5�     �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Eliminar6e   �� 5�     $!��/Imagenes/basket_remove.png��6$   $��16��6I   6W   5�     5�     �� 5�     -@   5        $ btnCancelarUsuario��5�  3   $��85��6   $��2q�6(   ���	#FF3A3333���	#FFFDFDFD.��5�     �� $
 
Horizontal=�6%   .+�5      �� ���	#FFF5ECEC$
��Bold"�6;   $��14(�6M   .��6[   
Cancelar6e   �� 5     $��/Imagenes/cancel.png��6$   $��16��6B   6P   5     5     5       5     -A   5        $ dtgUsuarios��5     $��1��60   $��0��6@   $��2��6M    . $��0,0,0,25q�6q   5     5     5     5     