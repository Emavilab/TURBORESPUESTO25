
Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel

Public Class REPORTESVENTAS
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub REPORTESVENTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerINICIO.Value = Date.Today
        DateTimePickerFIN.Value = Date.Today
        CargarReporteVentas()
    End Sub

    Private Sub CargarReporteVentas()
        Dim fechaInicio As Date = DateTimePickerINICIO.Value.Date
        Dim fechaFin As Date = DateTimePickerFIN.Value.Date.AddDays(1) ' Incluye todo el día final
        Dim filtro As String = txtbuscar.Text.Trim()

        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String =
            "SELECT v.fecha AS 'Fecha de registro', " &
            "c.nombre AS 'Cliente', " &
            "u.nombre_usuario AS 'Usuario de registro', " &
            "p.nombre AS 'Producto', " &
            "dv.cantidad AS 'Cantidad', " &
            "dv.precio_unitario AS 'Precio unitario', " &
            "dv.subtotal AS 'Subtotal', " &
            "v.total AS 'Total' " &
            "FROM ventas v " &
            "INNER JOIN detalle_venta dv ON v.id_venta = dv.id_venta " &
            "INNER JOIN productos p ON dv.id_producto = p.id_producto " &
            "INNER JOIN clientes c ON v.id_cliente = c.id_cliente " &
            "INNER JOIN usuarios u ON v.id_usuario = u.id_usuario " &
            "WHERE v.fecha >= @fechaInicio AND v.fecha < @fechaFin"

            If Not String.IsNullOrEmpty(filtro) Then
                query &= " AND (v.fecha LIKE @filtro OR c.nombre LIKE @filtro OR u.nombre_usuario LIKE @filtro OR p.nombre LIKE @filtro)"
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


    Private Sub DateTimePickerINICIO_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerINICIO.ValueChanged
        CargarReporteVentas()
    End Sub

    Private Sub DateTimePickerFIN_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFIN.ValueChanged
        CargarReporteVentas()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        CargarReporteVentas()
    End Sub

    Private Sub btndescargar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click
        If tabladeventas.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx"
        saveFileDialog.FileName = "ReporteVentas.xlsx"
        If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return

        Try
            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Reporte Ventas")

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

                ' Ajustar ancho de columnas
                ws.Columns().AdjustToContents()

                ' Fijar encabezado
                ws.SheetView.FreezeRows(1)

                wb.SaveAs(saveFileDialog.FileName)
            End Using

            MessageBox.Show("Datos exportados correctamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al exportar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class