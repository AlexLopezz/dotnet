   M S B A M L   `   `   `  ����H  DTextEditorWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TextEditorWPFTextEditorWPF  5   	       TextEditorWPF.NotePad   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TextEditorWPF     5   	   -   5          � Title$  NotePad��5   	   $	��450��6   $	��800��6&    � Icon$ /Images/iconText.png��5	   	    � WindowStartupLocation$ CenterScreen=�6%   .��5
      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $��mnuNew��5      $	��New��5      5      m� 5      -   5        $��mnuOpen��5      $
��Open��5      5      m� 5      -   5        $��mnuSave��5      $
��Save��5       m� Command$ ApplicationCommands.Save��5      m� 5      -   5        $��mnuClose��5      $��Close��5      5      5      m� 5      $
��Edit��6   .@�5      m� -   5        $��mnuUndo��5      $
��Undo��5      $ ApplicationCommands.Undo��5      m� 5      -   5        $��mnuCut��5      $	��Cut��5      $ ApplicationCommands.Cut��5       m� 5!      -   5        $��mnuCopy��5!      $
��Copy��5"      $ ApplicationCommands.Copy��5#      m� 5$      -	   5        $��mnuPaste��5$      $��Paste��5%      $ ApplicationCommands.Paste��5&      m� 5'      -
   5        $��mnuSelectAll��5'      $��Select All...��5(      $# ApplicationCommands.SelectAll��5)      5*      m� 5+      -   5        $��mnuAbout��5+      $��About��5,      5-      5.      �� 5/   
   $��Bottom=�6   .@�50      �� -   5        $��stCharacters��50      $��Characters: ��51      $	��120��52      �� 53      -   5        $��stWords��53      $��Words: ��54      $	��120��55      56      �� 57   
   -   5        $��
txtNotePad��57      $��18(�58       �� TextWrapping$
 Wrap=�59       �� AcceptsReturn$
 True��5:      5;      5<      5=      