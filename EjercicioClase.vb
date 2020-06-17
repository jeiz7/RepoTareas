Imports System.ComponentModel

Public Class Validaciones
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Try Catch: se utiliza para capturar un error en tiempo de ejecucion
        'ValidateChildren-> Botton:
        'Validating-> Cajas de texto
        Try
            'Si las casillas estan sin  ningun valor
            'Aplique a todos los elementos>  Producto sea diferente de vacio, precio sea diferente de vacio, Cantidad sea un valor entero
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged

    End Sub

    'Este errorValidacion me permite en la casilla producto proporcionar la opcion de que si el usuario no agrega 
    'ningun numero en la casilla se le proporcione un mensaje diciendo que el campo es obligatorio
    Private Sub txtProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub
    'Este errorValidacion me permite en la casilla precio proporcionar la opcion de que si el usuario no agrega 
    'ningun numero en la casilla se le proporcione un mensaje diciendo que el campo es obligatorio.
    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    'El error que me va a mostrar aqui es que si el usuario ingresa un numero decimal
    'la condicion no se lo va a permitir y que por lo tanto debe colocar un numero entero.
    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    'El ToolTip sirve para mostrar un mensaje mientras se desliza el cursor sobre la casilla.
    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        toolTip.SetToolTip(txtProducto, "Tipo de Producto") 'Este es el mensaje que muestra
        toolTip.ToolTipTitle = "Precio" 'Es el titulo de la casilla donde va el mensaje
        toolTip.ToolTipIcon = ToolTipIcon.Info 'Muestra el icono
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        toolTip.SetToolTip(txtPrecio, "Precio del Producto") 'Este es el mensaje que muestra
        toolTip.ToolTipTitle = "Precio" 'Es el titulo de la casilla donde va el mensaje
        toolTip.ToolTipIcon = ToolTipIcon.Info 'Muestra el icono
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        toolTip.SetToolTip(txtCantidad, "Cantidad de Productos (Entero)") 'Este es el mensaje que muestra
        toolTip.ToolTipTitle = "Cantidad" 'Es el titulo de la casilla donde va el mensaje
        toolTip.ToolTipIcon = ToolTipIcon.Info 'Muestra el icono
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        toolTip.SetToolTip(txtDescripcion, "Descripcion del Producto") 'Este es el mensaje que muestra
        toolTip.ToolTipTitle = "Descripcion" 'Es el titulo de la casilla donde va el mensaje
        toolTip.ToolTipIcon = ToolTipIcon.Info 'Muestra el icono
    End Sub


End Class
