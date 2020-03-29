Public Class Form1
    Private Sub btnencrypt_Click(sender As Object, e As EventArgs) Handles btnencrypt.Click
        btnencrypt.Enabled = False
        btndecrypt.Enabled = True
        cmba.Enabled = True
        cmba.SelectedIndex = 0
        cmbb.Enabled = True
        cmbb.SelectedIndex = 0
        lblformula.Text = "e(x)=ax+b"
        lblbefore.Text = "Plain text"
        txtbefore.Enabled = True
        txtbefore.Text = ""
        lblafter.Text = "Chipper Text"
        btnnext.Enabled = False
        txtafter.Text = ""
        txtspecial.Enabled = False
    End Sub

    Private Sub btndecrypt_Click(sender As Object, e As EventArgs) Handles btndecrypt.Click
        btnencrypt.Enabled = True
        btndecrypt.Enabled = False
        cmba.Enabled = True
        cmba.SelectedIndex = 0
        cmbb.Enabled = True
        cmbb.SelectedIndex = 0
        lblformula.Text = "d(x)=(a^-1)x+b"
        lblbefore.Text = "Chiper text"
        txtbefore.Enabled = True
        txtbefore.Text = ""
        lblafter.Text = "Plain Text"
        btnnext.Enabled = True
        txtafter.Text = ""
        txtspecial.Enabled = True
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        nextcrypt()
    End Sub

    Private Sub encrypt()
        Dim before As List(Of Char)
        Dim after As New List(Of String)
        Dim old, newi As Integer
        Dim words As New List(Of String)({"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"})
        before = txtbefore.Text.ToLower().ToList
        For i As Integer = 0 To before.Count - 1
            If words.Contains(before(i)) Then
                old = words.IndexOf(before(i))
                newi = (CInt(cmba.Text) * old + CInt(cmbb.Text)) Mod 26
                after.Add(words(newi))
            Else
                after.Add(before(i))
            End If
        Next
        txtafter.Text = String.Join("", after.ToArray())
    End Sub

    Private Sub decrypt()
        Dim before As List(Of Char)
        Dim after As New List(Of String)
        Dim old, newi As Integer
        Dim words As New List(Of String)({"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"})
        before = txtbefore.Text.ToLower().ToList
        For i As Integer = 0 To before.Count - 1
            If words.Contains(before(i)) Then
                old = words.IndexOf(before(i))
                ainvers()
                newi = CInt(txtainvers.Text) * ((old - CInt(cmbb.Text) Mod 26) + 26) Mod 26
                after.Add(words(newi))
            Else
                after.Add(before(i))
            End If
        Next
        txtafter.Text = String.Join("", after.ToArray())
        checkspecial()
    End Sub

    Private Sub nextcrypt()
        If cmbb.SelectedIndex < 25 Then
            cmbb.SelectedIndex += 1
        Else
            If cmba.SelectedIndex < 11 Then
                cmba.SelectedIndex += 1
            Else
                cmba.SelectedIndex = 0
            End If
            cmbb.SelectedIndex = 0
        End If
    End Sub

    Private Sub checkspecial()
        Dim thetext As String
        thetext = txtspecial.Text.ToLower()

        Dim listspecial() As String = thetext.Split(",")

        Dim ada As Boolean = True

        For i As Integer = 0 To listspecial.Length - 1
            If Not txtafter.Text.Contains(listspecial(i)) Then
                ada = False
            End If
        Next

        If ada = False And Not (cmba.Text = "1" And cmbb.Text = "0") Then
            nextcrypt()
        End If
    End Sub

    Private Sub cmba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmba.SelectedIndexChanged
        ainvers()
    End Sub

    Private Sub cmbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbb.SelectedIndexChanged
        If btnencrypt.Enabled = False Then
            encrypt()
        ElseIf btndecrypt.Enabled = False Then
            decrypt()
        End If
    End Sub

    Private Sub txtbefore_TextChanged(sender As Object, e As EventArgs) Handles txtbefore.TextChanged
        If btnencrypt.Enabled = False Then
            encrypt()
        ElseIf btndecrypt.Enabled = False Then
            decrypt()
        End If
    End Sub

    Private Sub cmba_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmba.SelectionChangeCommitted
        If btnencrypt.Enabled = False Then
            encrypt()
        ElseIf btndecrypt.Enabled = False Then
            decrypt()
        End If
    End Sub

    Private Sub ainvers()
        Select Case cmba.SelectedIndex.ToString
            Case "0"
                txtainvers.Text = "1"
            Case "1"
                txtainvers.Text = "9"
            Case "2"
                txtainvers.Text = "21"
            Case "3"
                txtainvers.Text = "15"
            Case "4"
                txtainvers.Text = "3"
            Case "5"
                txtainvers.Text = "19"
            Case "6"
                txtainvers.Text = "7"
            Case "7"
                txtainvers.Text = "23"
            Case "8"
                txtainvers.Text = "11"
            Case "9"
                txtainvers.Text = "5"
            Case "10"
                txtainvers.Text = "17"
            Case "11"
                txtainvers.Text = "25"
        End Select
    End Sub
End Class