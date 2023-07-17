'**************************************************** Bismillah ***********************************************

Public Class xTile

    Private nTileHoverColor As Color = Me.BackColor
    Private nTileBackColor As Color = Me.BackColor
    Private nTileIcon As String
    Private nTileText As String = "UNTITLED"

    Public Property TileIcon() As String
        Get
            Return nTileIcon
        End Get
        Set(ByVal value As String)
            nTileIcon = value
            Icon.Text = nTileIcon
        End Set
    End Property

    Public Property TileText() As String
        Get
            Return nTileText
        End Get
        Set(ByVal value As String)
            nTileText = value
            CtlTileText.Text = nTileText
        End Set
    End Property

    Public Property TileHoverColor() As Color
        Get
            Return nTileHoverColor
        End Get
        Set(ByVal value As Color)
            nTileHoverColor = value
        End Set
    End Property

    Public Property TileBackColor() As Color
        Get
            Return nTileBackColor
        End Get
        Set(ByVal value As Color)
            nTileBackColor = value
            Me.BackColor = nTileBackColor
        End Set
    End Property

    Private Sub xTile_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Icon.MouseEnter, CtlTileText.MouseEnter

        Me.BackColor = TileHoverColor

    End Sub

    Private Sub xTile_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Icon.MouseLeave, CtlTileText.MouseLeave

        Me.BackColor = TileBackColor

    End Sub

End Class
