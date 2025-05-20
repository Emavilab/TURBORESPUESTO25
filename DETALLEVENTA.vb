Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class DETALLEVENTA


    Private Sub DETALLEVENTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnbuscardetalleventa_Click(sender As Object, e As EventArgs) Handles btnbuscardetalleventa.Click
        If String.IsNullOrWhiteSpace(txtbuscaridventa.Text) Then
            MessageBox.Show("Ingrese un ID de venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVenta As Integer
        If Not Integer.TryParse(txtbuscaridventa.Text, idVenta) Then
            MessageBox.Show("ID de venta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' 1. Traer datos de la venta, usuario y cliente
                Dim queryVenta As String = "SELECT v.fecha, v.total, v.monto_pago, v.monto_cambio, 
                                               u.nombre_usuario, c.nombre AS nombre_cliente, c.dni
                                        FROM ventas v
                                        INNER JOIN usuarios u ON v.id_usuario = u.id_usuario
                                        INNER JOIN clientes c ON v.id_cliente = c.id_cliente
                                        WHERE v.id_venta = @id_venta"
                Using cmd As New MySqlCommand(queryVenta, conn)
                    cmd.Parameters.AddWithValue("@id_venta", idVenta)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFECHA.Text = Convert.ToDateTime(reader("fecha")).ToString("yyyy-MM-dd")
                            txtusuario.Text = reader("nombre_usuario").ToString()
                            txtnombrecliente.Text = reader("nombre_cliente").ToString()
                            txtdni.Text = reader("dni").ToString()
                            txtmontototal.Text = reader("total").ToString()
                            txtmontopago.Text = reader("monto_pago").ToString()
                            txtmontocambio.Text = reader("monto_cambio").ToString()
                        Else
                            MessageBox.Show("No se encontró la venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LimpiarCampos()
                            Return
                        End If
                    End Using
                End Using

                ' 2. Traer detalles de la venta
                Dim queryDetalle As String = "SELECT p.nombre AS producto, d.precio_unitario, d.cantidad, d.subtotal
                                          FROM detalle_venta d
                                          INNER JOIN productos p ON d.id_producto = p.id_producto
                                          WHERE d.id_venta = @id_venta"
                Using cmdDetalle As New MySqlCommand(queryDetalle, conn)
                    cmdDetalle.Parameters.AddWithValue("@id_venta", idVenta)
                    Dim adapter As New MySqlDataAdapter(cmdDetalle)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    tabladettalecompra.DataSource = table
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarCampos()
            End Try
        End Using
    End Sub

    Private Sub LimpiarCampos()
        txtFECHA.Clear()
        txtusuario.Clear()
        txtnombrecliente.Clear()
        txtdni.Clear()
        txtmontototal.Clear()
        txtmontopago.Clear()
        txtmontocambio.Clear()
        tabladettalecompra.DataSource = Nothing
    End Sub

    Private Sub btndescargar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click
        If String.IsNullOrWhiteSpace(txtbuscaridventa.Text) OrElse tabladettalecompra.DataSource Is Nothing Then
            MessageBox.Show("Primero busque una venta válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.FileName = $"Venta_{txtbuscaridventa.Text}.pdf"
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

                ' N. venta (derecha)
                Dim cellVenta As New PdfPCell()
                cellVenta.Border = Rectangle.NO_BORDER
                cellVenta.HorizontalAlignment = Element.ALIGN_RIGHT
                cellVenta.AddElement(New Paragraph("N. Venta", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                cellVenta.AddElement(New Paragraph(txtbuscaridventa.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
                cellVenta.Rowspan = 4
                tableHeader.AddCell(cellVenta)

                doc.Add(tableHeader)
                doc.Add(New Paragraph(" "))

                ' --- Datos de la venta ---
                Dim fuenteMono As Font = FontFactory.GetFont(FontFactory.COURIER, 11)
                Dim sb As New System.Text.StringBuilder()
                sb.AppendLine("Cliente:             " & txtnombrecliente.Text)
                sb.AppendLine("DNI:                 " & txtdni.Text)
                sb.AppendLine("Fecha de venta:      " & txtFECHA.Text)
                sb.AppendLine("Usuario de registro: " & txtusuario.Text)
                doc.Add(New Paragraph(sb.ToString(), fuenteMono))
                doc.Add(New Paragraph(" "))

                ' --- Tabla de detalles de productos ---
                Dim pdfTable As New PdfPTable(tabladettalecompra.Columns.Count)
                pdfTable.WidthPercentage = 100

                ' Encabezados
                For Each col As DataGridViewColumn In tabladettalecompra.Columns
                    pdfTable.AddCell(New Phrase(col.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                Next

                ' Filas
                For Each row As DataGridViewRow In tabladettalecompra.Rows
                    If row.IsNewRow Then Continue For
                    For Each col As DataGridViewColumn In tabladettalecompra.Columns
                        pdfTable.AddCell(New Phrase(row.Cells(col.Index).Value?.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)))
                    Next
                Next

                doc.Add(pdfTable)
                doc.Add(New Paragraph(" "))

                ' --- Tabla de totales ---
                Dim tablaTotales As New PdfPTable(2)
                tablaTotales.WidthPercentage = 40
                tablaTotales.HorizontalAlignment = Element.ALIGN_RIGHT
                tablaTotales.DefaultCell.Border = Rectangle.NO_BORDER

                tablaTotales.AddCell(New Phrase("Monto total:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
                tablaTotales.AddCell(New Phrase(txtmontototal.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))

                tablaTotales.AddCell(New Phrase("Monto pago:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
                tablaTotales.AddCell(New Phrase(txtmontopago.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))

                tablaTotales.AddCell(New Phrase("Monto cambio:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
                tablaTotales.AddCell(New Phrase(txtmontocambio.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))

                doc.Add(tablaTotales)

                doc.Close()
            End Using

            MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class