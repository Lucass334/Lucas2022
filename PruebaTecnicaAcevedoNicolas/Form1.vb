Imports System.Collections.ObjectModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form1

    Private connection As SqlConnection
    Private Sub InsertClientes_Paint(sender As Object, e As PaintEventArgs) Handles InsertClientes.Paint

    End Sub

    Private Sub EstablecerConexion(ByVal query As String)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

        connection = New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(query, connection)
        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim insertquery As String = " INSERT INTO dbo.Clientes(Cliente,Telefono,Correo)VALUES('" & TextBoxCliente.Text & "','" & TextBoxtelefono.Text & "','" & TextBoxCorreo.Text & "')"
        EstablecerConexion(insertquery)
        MessageBox.Show("Nuevo Cliente creado con exito", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBoxCorreo.Clear()
        TextBoxCliente.Clear()
        TextBoxtelefono.Clear()
        llenar_sub()
        InsertClientes.Visible = False
        NuevoClient.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = " INSERT INTO dbo.productos(Nombre,Precio,Categoria)VALUES('" & TextBoxNombreProducto.Text & "','" & TextBoxPrecio.Text & "','" & TextBoxCategoria.Text & "')"
        EstablecerConexion(insertquery)
        MessageBox.Show("Nuevo Producto creado con exito", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBoxNombreProducto.Clear()
        TextBoxCategoria.Clear()
        TextBoxPrecio.Clear()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellContentClick

    End Sub

    Private Sub llenar_sub()
        Dim query As String = "SELECT * FROM dbo.clientes"
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

        Using connection As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridViewClientes.DataSource = table
        End Using


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_sub()
    End Sub

    Private Sub NuevoCliente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoClient_Click(sender As Object, e As EventArgs) Handles NuevoClient.Click
        InsertClientes.Visible = True
        NuevoClient.Visible = False
    End Sub
End Class
