Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class detallecompra
    Private Sub txtbuscaridcompra_TextChanged(sender As Object, e As EventArgs) Handles txtbuscaridcompra.TextChanged

    End Sub

    Private Sub LimpiarCampos()
        txtFECHA.Clear()
        txtmontototal.Clear()
        txtusuario.Clear()
        txtnombrepro.Clear()
        txttelefonopro.Clear()
        tabladettalecompra.DataSource = Nothing
    End Sub


    Private Sub btndescargar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click
        If String.IsNullOrWhiteSpace(txtbuscaridcompra.Text) OrElse tabladettalecompra.DataSource Is Nothing Then
            MessageBox.Show("Primero busque una compra válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.FileName = $"Compra_{txtbuscaridcompra.Text}.pdf"
        If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return

        Try
            Dim doc As New Document(PageSize.A4, 40, 40, 80, 40)
            Using fs As New FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim writer = PdfWriter.GetInstance(doc, fs)
                doc.Open()

                ' --- Encabezado con logo y datos de empresa ---
                Dim tableHeader As New PdfPTable(3)
                tableHeader.WidthPercentage = 100
                tableHeader.SetWidths(New Single() {1.5F, 3.5F, 2.0F})

                ' Logo (izquierda)
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(My.Resources.Logo, System.Drawing.Imaging.ImageFormat.Png)
                logo.ScaleAbsolute(60, 60)
                Dim cellLogo As New PdfPCell(logo)
                cellLogo.Border = Rectangle.NO_BORDER
                cellLogo.HorizontalAlignment = Element.ALIGN_LEFT
                cellLogo.Rowspan = 4
                tableHeader.AddCell(cellLogo)

                ' Marca y datos de empresa (centro)
                Dim marca As String = "TURBORESPUESTO"
                Dim referencia As String = "N° Referencia: 123456"
                Dim direccion As String = "Dirección: Avenida 14 HN"
                Dim cellCentro As New PdfPCell()
                cellCentro.Border = Rectangle.NO_BORDER
                cellCentro.HorizontalAlignment = Element.ALIGN_CENTER
                cellCentro.AddElement(New Paragraph(marca, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)))
                cellCentro.AddElement(New Paragraph(referencia, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
                cellCentro.AddElement(New Paragraph(direccion, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
                cellCentro.Rowspan = 4
                tableHeader.AddCell(cellCentro)

                ' N. compra (derecha)
                Dim cellCompra As New PdfPCell()
                cellCompra.Border = Rectangle.NO_BORDER
                cellCompra.HorizontalAlignment = Element.ALIGN_RIGHT
                cellCompra.AddElement(New Paragraph("N. Compra", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                cellCompra.AddElement(New Paragraph(txtbuscaridcompra.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
                cellCompra.Rowspan = 4
                tableHeader.AddCell(cellCompra)

                doc.Add(tableHeader)
                doc.Add(New Paragraph(" "))

                ' --- Datos de la compra ---
                Dim fuenteMono As Font = FontFactory.GetFont(FontFactory.COURIER, 11)
                Dim sb As New System.Text.StringBuilder()

                sb.AppendLine("Proveedor:           " & txtnombrepro.Text)
                sb.AppendLine("Teléfono:            " & txttelefonopro.Text)
                sb.AppendLine("Fecha de registro:   " & txtFECHA.Text)
                sb.AppendLine("Usuario de registro: " & txtusuario.Text)

                doc.Add(New Paragraph(sb.ToString(), fuenteMono))
                doc.Add(New Paragraph(" "))

                ' --- Tabla de detalles ---
                Dim pdfTable As New PdfPTable(tabladettalecompra.Columns.Count - 1) ' -1 para ocultar id_producto
                pdfTable.WidthPercentage = 100

                ' Encabezados
                For Each col As DataGridViewColumn In tabladettalecompra.Columns
                    If col.Visible Then
                        pdfTable.AddCell(New Phrase(col.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                    End If
                Next

                ' Filas
                For Each row As DataGridViewRow In tabladettalecompra.Rows
                    If row.IsNewRow Then Continue For
                    For Each col As DataGridViewColumn In tabladettalecompra.Columns
                        If col.Visible Then
                            pdfTable.AddCell(New Phrase(row.Cells(col.Index).Value?.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)))
                        End If
                    Next
                Next

                doc.Add(pdfTable)
                doc.Add(New Paragraph(" "))

                ' --- Monto total ---
                doc.Add(New Paragraph($"Monto total de la compra: {txtmontototal.Text}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))

                doc.Close()
            End Using

            MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnbuscardetallecompra_Click(sender As Object, e As EventArgs) Handles btnbuscardetallecompra.Click
        If String.IsNullOrWhiteSpace(txtbuscaridcompra.Text) Then
            LimpiarCampos()
            Return
        End If

        Dim idCompra As Integer
        If Not Integer.TryParse(txtbuscaridcompra.Text, idCompra) Then
            LimpiarCampos()
            Return
        End If

        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' 1. Obtener datos de la compra, usuario y proveedor
                Dim queryCompra As String = "SELECT c.fecha, c.total, u.nombre_usuario, p.nombre AS proveedor, p.telefono
                                         FROM compras c
                                         INNER JOIN usuarios u ON c.id_usuario = u.id_usuario
                                         INNER JOIN proveedores p ON c.id_proveedor = p.id_proveedor
                                         WHERE c.id_compra = @id_compra"
                Using cmd As New MySqlCommand(queryCompra, conn)
                    cmd.Parameters.AddWithValue("@id_compra", idCompra)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFECHA.Text = Convert.ToDateTime(reader("fecha")).ToString("yyyy-MM-dd")
                            txtmontototal.Text = reader("total").ToString()
                            txtusuario.Text = reader("nombre_usuario").ToString()
                            txtnombrepro.Text = reader("proveedor").ToString()
                            txttelefonopro.Text = reader("telefono").ToString()
                        Else
                            LimpiarCampos()
                            Return
                        End If
                    End Using
                End Using

                ' 2. Obtener detalles de la compra
                Dim queryDetalle As String = "SELECT d.id_producto, pr.nombre AS producto, d.precio_unitario, d.cantidad, d.subtotal
                                          FROM detalle_compra d
                                          INNER JOIN productos pr ON d.id_producto = pr.id_producto
                                          WHERE d.id_compra = @id_compra"
                Using cmdDetalle As New MySqlCommand(queryDetalle, conn)
                    cmdDetalle.Parameters.AddWithValue("@id_compra", idCompra)
                    Dim adapter As New MySqlDataAdapter(cmdDetalle)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    tabladettalecompra.DataSource = table
                    If tabladettalecompra.Columns.Contains("id_producto") Then
                        tabladettalecompra.Columns("id_producto").Visible = False
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarCampos()
            End Try
        End Using
    End Sub

End Class