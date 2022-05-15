Imports System.ComponentModel

Public Class DataGridViewProgressColumn
    Inherits DataGridViewImageColumn

    Public Sub New()
        CellTemplate = New DataGridViewProgressCell
    End Sub
End Class
Public Class DataGridViewProgressCell
    Inherits DataGridViewImageCell

    Dim foreColorBrush = New SolidBrush(Color.Black)
    Dim backColorBrush = New SolidBrush(Color.WhiteSmoke)

    Sub New()
        MyBase.New()
        ValueType = Type.GetType("Integer")
    End Sub

    Protected Overrides Function GetFormattedValue(value As Object, rowIndex As Integer, ByRef cellStyle As DataGridViewCellStyle, valueTypeConverter As TypeConverter,
                                                   formattedValueTypeConverter As TypeConverter, context As DataGridViewDataErrorContexts) As Object

        GetFormattedValue = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppArgb)
    End Function

    Protected Overrides Sub Paint(g As Graphics, clipBounds As Rectangle, cellBounds As Rectangle,
                                  rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String,
                                  cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)

        Dim progressVal As Integer = value
        Dim percentage As Single = (progressVal / 100)

        MyBase.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        If percentage > 0 Then
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 190, 0)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4)
            If percentage < 0.5 Then
                g.DrawString(progressVal.ToString() + "%", cellStyle.Font, backColorBrush, cellBounds.X + (cellBounds.Width / 2) - 5, cellBounds.Y + 2)
            Else
                g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + (cellBounds.Width / 2) - 5, cellBounds.Y + 2)
            End If
        End If

    End Sub
End Class