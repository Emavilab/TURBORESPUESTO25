Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class REPORTECOMPRAS
    Private Sub REPORTECOMPRAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerINICIO.Value = Date.Today
        DateTimePickerFIN.Value = Date.Today
        CargarReporteCompras()
    End Sub

    Private Sub CargarReporteCompras()
        Dim fechaInicio As Date = DateTimePickerINICIO.Value.Date
        Dim fechaFin As Date = DateTimePickerFIN.Value.Date.AddDays(1)
        Dim filtro As String = txtbuscar.Text.Trim()

        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String =
                "SELECT c.fecha AS 'Fecha de registro', " &
                "p.nombre AS 'Proveedor', " &
                "u.nombre_usuario AS 'Usuario de registro', " &
                "pr.nombre AS 'Producto', " &
                "dc.cantidad AS 'Cantidad', " &
                "dc.precio_unitario AS 'Precio unitario', " &
                "dc.subtotal AS 'Subtotal', " &
                "c.total AS 'Total' " &
                "FROM compras c " &
                "INNER JOIN detalle_compra dc ON c.id_compra = dc.id_compra " &
                "INNER JOIN productos pr ON dc.id_producto = pr.id_producto " &
                "INNER JOIN proveedores p ON c.id_proveedor = p.id_proveedor " &
                "INNER JOIN usuarios u ON c.id_usuario = u.id_usuario " &
                "WHERE c.fecha >= @fechaInicio AND c.fecha < @fechaFin"

            If Not String.IsNullOrEmpty(filtro) Then
                query &= " AND (c.fecha LIKE @filtro OR p.nombre LIKE @filtro OR u.nombre_usuario LIKE @filtro OR pr.nombre LIKE @filtro)"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"))
            If Not String.IsNullOrEmpty(filtro) Then
                cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            tabladeventas.DataSource = table
        End Using
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        CargarReporteCompras()
    End Sub

    Private Sub DateTimePickerINICIO_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerINICIO.ValueChanged
        CargarReporteCompras()
    End Sub

    Private Sub DateTimePickerFIN_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFIN.ValueChanged
        CargarReporteCompras()
    End Sub

    Private Sub btndescargar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click
        If tabladeventas.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx"
        saveFileDialog.FileName = "ReporteCompras.xlsx"
        If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return

        Try
            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Reporte Compras")

                ' Escribir encabezados con formato
                For col = 0 To tabladeventas.Columns.Count - 1
                    ws.Cell(1, col + 1).Value = tabladeventas.Columns(col).HeaderText
                    ws.Cell(1, col + 1).Style.Font.Bold = True
                    ws.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.LightSteelBlue
                    ws.Cell(1, col + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    ws.Cell(1, col + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                Next

                ' Escribir datos
                For row = 0 To tabladeventas.Rows.Count - 1
                    If tabladeventas.Rows(row).IsNewRow Then Continue For
                    For col = 0 To tabladeventas.Columns.Count - 1
                        Dim cellValue = tabladeventas.Rows(row).Cells(col).Value
                        If cellValue Is Nothing OrElse IsDBNull(cellValue) Then
                            ws.Cell(row + 2, col + 1).Value = ""
                        ElseIf TypeOf cellValue Is DateTime Then
                            ws.Cell(row + 2, col + 1).Value = CType(cellValue, DateTime).ToString("yyyy-MM-dd HH:mm:ss")
                        ElseIf IsNumeric(cellValue) Then
                            ws.Cell(row + 2, col + 1).Value = Convert.ToDouble(cellValue)
                        ElseIf TypeOf cellValue Is Boolean Then
                            ws.Cell(row + 2, col + 1).Value = CBool(cellValue)
                        Else
                            ws.Cell(row + 2, col + 1).Value = cellValue.ToString()
                        End If
                        ws.Cell(row + 2, col + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                    Next
                Next

                ws.Columns().AdjustToContents()
                ws.SheetView.FreezeRows(1)
                wb.SaveAs(saveFileDialog.FileName)
            End Using

            MessageBox.Show("Datos exportados correctamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al exportar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class