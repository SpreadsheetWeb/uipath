   M S B A M L   `   `   `  ���� Z  VPagos.SpreadsheetWeb.Activities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�aclr-namespace:Pagos.SpreadsheetWeb.Activities.Properties;assembly=Pagos.SpreadsheetWeb.Activities*Pagos.SpreadsheetWeb.Activities.Properties  e aSystem.Activities.Presentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35wTclr-namespace:System.Activities.Presentation;assembly=System.Activities.PresentationSystem.Activities.Presentation �Yclr-namespace:System.Activities.Presentation.View;assembly=System.Activities.Presentation#System.Activities.Presentation.View �_clr-namespace:System.Activities.Presentation.Converters;assembly=System.Activities.Presentation)System.Activities.Presentation.Converters a ]Pagos.SpreadsheetWeb.Activities.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:UiPath.Shared.Activities.Design.Converters*UiPath.Shared.Activities.Design.Converters c6clr-namespace:UiPath.Shared.Activities.Design.Controls(UiPath.Shared.Activities.Design.Controls I   CPagos.SpreadsheetWeb.Activities.Design.Designers.CalculatorDesigner   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     vactivityaclr-namespace:Pagos.SpreadsheetWeb.Activities.Properties;assembly=Pagos.SpreadsheetWeb.Activities     dsapTclr-namespace:System.Activities.Presentation;assembly=System.Activities.Presentation     jsapvYclr-namespace:System.Activities.Presentation.View;assembly=System.Activities.Presentation     psapc_clr-namespace:System.Activities.Presentation.Converters;assembly=System.Activities.Presentation     O
converters8clr-namespace:UiPath.Shared.Activities.Design.Converters     Fuip6clr-namespace:UiPath.Shared.Activities.Design.Controls       � 	Resources   �� MergedDictionaries �� SourceM  GSystem.Activities.Presentation.Converters.ArgumentToExpressionConverter !  ArgumentToExpressionConverterF  @UiPath.Shared.Activities.Design.Converters.ActivityIconConverter  ActivityIconConverter��  �� $ ..\Themes\Generic.xaml?�%   &	        &	          5  /System.Activities.Presentation.ActivityDesigner   Icon L�  j� Stretch$ Uniform=� L� Drawing ��  �� Path$ 	ModelItem� �� 	Converter# [  �� ConverterParameter$_ Ypack://application:,,,/Pagos.SpreadsheetWeb.Activities.Design;component/themes/icons.xaml��.��G  AUiPath.Shared.Activities.Design.Controls.ActivityDecoratorControl  G  AUiPath.Shared.Activities.Design.Controls.ActivityDecoratorControl	   Loaded$	 FrameworkElement_OnLoaded��  ActivityDecoratorStyle#��[ .��� $	��300��
 � RowDefinitions
 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� :   4Pagos.SpreadsheetWeb.Activities.Properties.Resources$   Calculator_ApiURL_DisplayName#��Z $��0��;  5System.Activities.Presentation.View.ExpressionTextBox  $��1��$   Calculator_ApiURL_Description   HintText# Z    UseLocationExpression .     ExpressionType �� *CAModelItem.Properties[ApiURL].PropertyType.GenericTypeArguments[0]+   OwnerActivity �� $ 	ModelItem�   
Expression �� $ ModelItem.ApiURL�# [   �� Mode$ TwoWay=�$ In�� �� UpdateSourceTrigger$ PropertyChanged=��� ,   %Calculator_ApplicationKey_DisplayName#��Z $��2��  $��3��,   %Calculator_ApplicationKey_Description# Z  .   �� *KIModelItem.Properties[ApplicationKey].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.ApplicationKey�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��Input Mappings��$��4��� -   $��	grdInputs��$
��Auto��$��5��
 �� $
��Auto ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 � � ColumnDefinitions �� $	��120 ��� $��20 ��� $	��120 ��� $��40 �.+�  -   $��	txtInput1��$��0��$��0��#   Calculator_Input_Description# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input1].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input1�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��0��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput1Val��$��0��$��2��#   Calculator_Value_Description# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value1].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value1�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��3��$��0��$
��Auto��$��5q�
 � Tag$ 1������   -   $��	txtInput2��$��1��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input2].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input2�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��1��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput2Val��$��1��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value2].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value2�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��1��$��3��$
��Auto��$��5q�$ 2������   -   $��	txtInput3��$��2��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input3].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input3�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��2��$��1��$��=��$
��Auto��$��Center=�  -	   $��txtInput3Val��$��2��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value3].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value3�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -
   $��X��$��2��$��3��$
��Auto��$��5q�$ 3������   -   $��	txtInput4��$��3��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input4].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input4�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��3��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput4Val��$��3��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value4].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value4�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��3��$��3��$
��Auto��$��5q�$ 4������   -   $��	txtInput5��$��4��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input5].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input5�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��4��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput5Val��$��4��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value5].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value5�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��4��$��3��$
��Auto��$��5q�$ 5������   -   $��	txtInput6��$��5��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input6].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input6�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��5��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput6Val��$��5��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value6].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value6�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��5��$��3��$
��Auto��$��5q�$ 6������   -   $��	txtInput7��$��6��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input7].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input7�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��6��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput7Val��$��6��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value7].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value7�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��6��$��3��$
��Auto��$��5q�$ 7������   -   $��	txtInput8��$��7��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input8].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input8�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��7��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput8Val��$��7��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value8].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value8�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��7��$��3��$
��Auto��$��5q�$ 8������   -   $��	txtInput9��$��8��$��0��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Input9].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input9�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��8��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput9Val��$��8��$��2��# Z  .  $
��Auto�� �� *CAModelItem.Properties[Value9].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value8�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��8��$��3��$
��Auto��$��5q�$ 9������   -   $��
txtInput10��$��9��$��0��# Z  .  $
��Auto�� �� *DBModelItem.Properties[Input10].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Input10�# [  $ TwoWay=�$ In��$ PropertyChanged=��� $��9��$��1��$��=��$
��Auto��$��Center=�  -   $��txtInput10Val��$��9��$��2��# Z  .  $
��Auto�� �� *DBModelItem.Properties[Value10].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Value9�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -   $��X��$��9��$��3��$
��Auto��$��5q�$ 10������ �� -    $��Add New Input��$��6��$	��120��$��10q����� �� $��Output Mappings��$��7��� -!   $��
grdOutputs��$
��Auto��$��8��
 �� $
��Auto ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 ��� $��0 � �� $	��260 ��� $��40 �.+�  -"   $��
txtOutput1��$��0��$��0��%   Calculator_Output1_Description# Z  .  $
��Auto�� �� *DBModelItem.Properties[Output1].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output1�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -#   $��X��$��0��$��1��$
��Auto��$��5q�$ 1������   -$   $��
txtOutput2��$��1��$��0��%   Calculator_Output2_Description# Z  .  $
��Auto�� �� *DBModelItem.Properties[Output2].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output2�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -%   $��X��$��1��$��1��$
��Auto��$��5q�$ 2������   -&   $��
txtOutput3��$��2��$��0��%   Calculator_Output3_Description# Z  .  $
��Auto�� �� *DBModelItem.Properties[Output3].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output3�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -'   $��X��$��2��$��1��$
��Auto��$��5q�$ 3������   -(   $��
txtOutput4��$��3��$��0��%   Calculator_Output4_Description# Z  .  $
��Auto�� �� *DBModelItem.Properties[Output4].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output4�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -)   $��X��$��3��$��1��$
��Auto��$��5q�$ 4������   -*   $��
txtOutput5��$��4��$��0��%   Calculator_Output5_Description# Z  .  $
��Auto�� �� *DBModelItem.Properties[Output5].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output5�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -+   $��X��$��4��$��1��$
��Auto��$��5q�$ 5������   -,   $��
txtOutput6��$��5��$��0��%   Calculator_Output6_Description# Z  .  $
��Auto�� �� *DBModelItem.Properties[Output6].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output6�# [  $ TwoWay=�$ In��$ PropertyChanged=��� --   $��X��$��5��$��1��$
��Auto��$��5q�$ 6������   -.   $��
txtOutput7��$��6��$��0��%    Calculator_Output7_Description# Z   .  $
��Auto�� �� *DBModelItem.Properties[Output7].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output7�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -/   $��X��$��6��$��1��$
��Auto��$��5q�$ 7������   -0   $��
txtOutput8��$��7��$��0��%!   Calculator_Output8_Description# Z!  .  $
��Auto�� �� *DBModelItem.Properties[Output8].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output8�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -1   $��X��$��7��$��1��$
��Auto��$��5q�$ 8������   -2   $��
txtOutput9��$��8��$��0��%"   Calculator_Output9_Description# Z"  .  $
��Auto�� �� *DBModelItem.Properties[Output9].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output9�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -3   $��X��$��8��$��1��$
��Auto��$��5q�$ 9������   -4   $��txtOutput10��$��9��$��0��&#   Calculator_Output10_Description# Z#  .  $
��Auto�� �� *ECModelItem.Properties[Output10].PropertyType.GenericTypeArguments[0]+ �� $ 	ModelItem� �� $ ModelItem.Output10�# [  $ TwoWay=�$ In��$ PropertyChanged=��� -5   $��X��$��9��$��1��$
��Auto��$��5q�$ 10������ �� -6   $��btnAddOutput��$��Add New Output��$��9��$	��120��$��10q����� 