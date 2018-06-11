' Project name:         Bingo Project
' Project purpose:      Simultes the bingo game where a player 
'                       wins by achieving patterns on the interface
' Created/revised by:   Kelvin Mundi on 12/1/2016

Option Explicit On
Option Infer On
Option Strict Off

Public Class mainForm
    Private randgen As New Random
    Private newNum As String
    Private letters() As String = {"B", "I", "N", "G", "O"}
    Private bNum(5), iNum(5), nNum(4), gNum(5), oNum(5) As Integer
    Private randLetter As String
    Private randNum As Integer

    Private Sub Shuffle()
        ' shuffles numbers and displays them accordingly
        Dim randomB As Integer
        Dim randomI As Integer
        Dim randomN As Integer
        Dim randomG As Integer
        Dim randomO As Integer
        Dim searchSubscript As Integer
        Dim subscript As Integer = 1
        Dim isFound As Boolean

        ' declare arrays for the labels
        Dim bArray() As Label = {LabelB1, LabelB2, LabelB3, LabelB4, LabelB5}
        Dim iArray() As Label = {LabelI1, LabelI2, LabelI3, LabelI4, LabelI5}
        Dim nArray() As Label = {LabelN1, LabelN2, LabelN3, LabelN4}
        Dim gArray() As Label = {LabelG1, LabelG2, LabelG3, LabelG4, LabelG5}
        Dim oArray() As Label = {LabelO1, LabelO2, LabelO3, LabelO4, LabelO5}

        ' populate B column
        bNum(0) = randgen.Next(1, 15)
            Do While subscript <= bNum.GetUpperBound(0)
            randomB = randgen.Next(1, 15)
                searchSubscript = 0
                isFound = False
                Do While searchSubscript < subscript AndAlso isFound = False
                    If bNum(searchSubscript) = randomB Then
                        isFound = True
                    Else
                        searchSubscript += 1
                    End If
                Loop
                If isFound = False Then
                bNum(subscript) = randomB
                bArray(subscript - 1).Text = randomB.ToString
                bArray(subscript - 1).BackColor = Color.White
                bArray(subscript - 1).Enabled = True
                subscript += 1
                End If
        Loop
        isFound = False
        subscript = 1

        ' populate  I column
        iNum(0) = randgen.Next(16, 30)
        Do While subscript <= iNum.GetUpperBound(0)
            randomI = randgen.Next(16, 30)
            searchSubscript = 0
            isFound = False
            Do While searchSubscript < subscript AndAlso isFound = False
                If iNum(searchSubscript) = randomI Then
                    isFound = True
                Else
                    searchSubscript += 1
                End If
            Loop
            If isFound = False Then
                iNum(subscript) = randomI
                iArray(subscript - 1).Text = randomI.ToString
                iArray(subscript - 1).BackColor = Color.White
                iArray(subscript - 1).Enabled = True
                subscript += 1
            End If
        Loop
        isFound = False
        subscript = 1

        ' populate N column
        nNum(0) = randgen.Next(31, 45)
        Do While subscript <= nNum.GetUpperBound(0)
            randomN = randgen.Next(31, 45)
            searchSubscript = 0
            isFound = False
            Do While searchSubscript < subscript AndAlso isFound = False
                If nNum(searchSubscript) = randomN Then
                    isFound = True
                Else
                    searchSubscript += 1
                End If
            Loop
            If isFound = False Then
                nNum(subscript) = randomN
                nArray(subscript - 1).Text = randomN.ToString
                nArray(subscript - 1).BackColor = Color.White
                nArray(subscript - 1).Enabled = True
                subscript += 1
            End If
        Loop
        isFound = False
        subscript = 1

        ' populate G column
        gNum(0) = randgen.Next(46, 60)
        Do While subscript <= gNum.GetUpperBound(0)
            randomG = randgen.Next(46, 60)
            searchSubscript = 0
            isFound = False
            Do While searchSubscript < subscript AndAlso isFound = False
                If gNum(searchSubscript) = randomG Then
                    isFound = True
                Else
                    searchSubscript += 1
                End If
            Loop
            If isFound = False Then
                gNum(subscript) = randomG
                gArray(subscript - 1).Text = randomG.ToString
                gArray(subscript - 1).BackColor = Color.White
                gArray(subscript - 1).Enabled = True
                subscript += 1
            End If
        Loop
        isFound = False
        subscript = 1

        ' populate the O column
        oNum(0) = randgen.Next(61, 75)
        Do While subscript <= oNum.GetUpperBound(0)
            randomO = randgen.Next(61, 75)
            searchSubscript = 0
            isFound = False
            Do While searchSubscript < subscript AndAlso isFound = False
                If oNum(searchSubscript) = randomO Then
                    isFound = True
                Else
                    searchSubscript += 1
                End If
            Loop
            If isFound = False Then
                oNum(subscript) = randomO
                oArray(subscript - 1).Text = randomO.ToString
                oArray(subscript - 1).BackColor = Color.White
                oArray(subscript - 1).Enabled = True
                subscript += 1
            End If
        Loop
        isFound = False
        subscript = 1
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim exitConfirm As DialogResult
        exitConfirm =
            MessageBox.Show("Are you sure you want to exit?", "BINGO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button2)
        If exitConfirm = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fills the bingo interface when it loads
        Call Shuffle()
    End Sub

    Private Sub getNumButton_Click(sender As Object, e As EventArgs) Handles getNumButton.Click
        ' sets the new number on the interface
StartPosition:
        Dim index As Integer = 0
        Dim listIndex As Integer = 0
        Dim numItems As Integer
        Dim found As Boolean = False
        numItems = ListBox1.Items.Count

        If numItems = 70 Then
            ListBox1.Items.Clear()
            GoTo StartPosition
        End If

        index = randgen.Next(0, 5)
        randLetter = ""

        If letters(index) = "B" Then
            randNum = randgen.Next(1, 15)
            randLetter = letters(index)
            newNum = randLetter + randNum.ToString
            If numItems < 1 Then
                newNumLabel.Text = newNum.ToString
                ListBox1.Items.Add(newNum.ToString)
            Else
                Do While listIndex < numItems AndAlso found = False
                    If ListBox1.Items(listIndex) = newNum Then
                        found = True
                        GoTo StartPosition
                    Else
                        listIndex += 1
                    End If
                Loop
                If found = False Then
                    newNumLabel.Text = newNum.ToString
                    If numItems = 70 Then
                        ListBox1.Items.Clear()
                    Else
                        ListBox1.Items.Add(newNum.ToString)
                    End If
                End If
            End If
        ElseIf letters(index) = "I" Then
            randNum = randgen.Next(16, 30)
            randLetter = letters(index)
            newNum = randLetter + randNum.ToString
            If numItems < 1 Then
                newNumLabel.Text = newNum.ToString
                ListBox1.Items.Add(newNum.ToString)
            Else
                Do While listIndex < numItems AndAlso found = False
                    If ListBox1.Items(listIndex) = newNum Then
                        found = True
                        GoTo StartPosition
                    Else
                        listIndex += 1
                    End If
                Loop
                If found = False Then
                    newNumLabel.Text = newNum.ToString
                    If numItems = 70 Then
                        ListBox1.Items.Clear()
                    Else
                        ListBox1.Items.Add(newNum.ToString)
                    End If
                End If
            End If
        ElseIf letters(index) = "N" Then
            randNum = randgen.Next(31, 45)
            randLetter = letters(index)
            newNum = randLetter + randNum.ToString
            If numItems < 1 Then
                newNumLabel.Text = newNum.ToString
                ListBox1.Items.Add(newNum.ToString)
            Else
                Do While listIndex < numItems AndAlso found = False
                    If ListBox1.Items(listIndex) = newNum Then
                        found = True
                        GoTo StartPosition
                    Else
                        listIndex += 1
                    End If
                Loop
                If found = False Then
                    newNumLabel.Text = newNum.ToString
                    If numItems = 70 Then
                        ListBox1.Items.Clear()
                    Else
                        ListBox1.Items.Add(newNum.ToString)
                    End If
                End If
            End If
        ElseIf letters(index) = "G" Then
            randNum = randgen.Next(46, 60)
            randLetter = letters(index)
            newNum = randLetter + randNum.ToString
            If numItems < 1 Then
                newNumLabel.Text = newNum.ToString
                ListBox1.Items.Add(newNum.ToString)
            Else
                Do While listIndex < numItems AndAlso found = False
                    If ListBox1.Items(listIndex) = newNum Then
                        found = True
                        GoTo StartPosition
                    Else
                        listIndex += 1
                    End If
                Loop
                If found = False Then
                    newNumLabel.Text = newNum.ToString
                    If numItems = 70 Then
                        ListBox1.Items.Clear()
                    Else
                        ListBox1.Items.Add(newNum.ToString)
                    End If
                End If
            End If
        ElseIf letters(index) = "O" Then
            randNum = randgen.Next(60, 75)
            randLetter = letters(index)
            newNum = randLetter + randNum.ToString
            If numItems < 1 Then
                newNumLabel.Text = newNum.ToString
                ListBox1.Items.Add(newNum.ToString)
            Else
                Do While listIndex < numItems AndAlso found = False
                    If ListBox1.Items(listIndex) = newNum Then
                        found = True
                        GoTo StartPosition
                    Else
                        listIndex += 1
                    End If
                Loop
                If found = False Then
                    newNumLabel.Text = newNum.ToString
                    If numItems = 70 Then
                        ListBox1.Items.Clear()
                    Else
                        ListBox1.Items.Add(newNum.ToString)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub newGameButton_Click(sender As Object, e As EventArgs) Handles newGameButton.Click
        ' starts a new game
        newNumLabel.Text = String.Empty
        ListBox1.Items.Clear()
        Call Shuffle()
    End Sub

    Private Sub fontButton_Click(sender As Object, e As EventArgs) Handles fontButton.Click
        FontDialog.Font = Me.Font
        FontDialog.ShowDialog()
        Me.Font = FontDialog.Font
    End Sub

    Private Sub TestForMatch(sender As Object, e As EventArgs) Handles LabelB1.Click, LabelB2.Click, LabelB3.Click, LabelB4.Click, LabelB5.Click, LabelI1.Click, LabelI2.Click, LabelI3.Click, LabelI4.Click, LabelI5.Click, LabelN1.Click, LabelN2.Click, LabelN3.Click, LabelN4.Click, LabelO1.Click, LabelO2.Click, LabelO3.Click, LabelO4.Click, LabelO5.Click, LabelG1.Click, LabelG2.Click, LabelG3.Click, LabelG4.Click, LabelG5.Click
        ' listens for clicks and sets color to matching labels
        ' confirm that the clicked label text
        ' matches the new number selected

        ' change background of clicked label
        Dim clickedLabel As Object = TryCast(sender, Label)
        If clickedLabel.Text = newNumLabel.Text.Remove(0, 1) Then
            clickedLabel.BackColor = Color.IndianRed
            clickedLabel.Enabled = False
        End If

        ' test for patterns
        ' vertical labels
        If LabelB1.Enabled = False AndAlso
           LabelB2.Enabled = False AndAlso
           LabelB3.Enabled = False AndAlso
           LabelB4.Enabled = False AndAlso
           LabelB5.Enabled = False Then
            LabelB1.BackColor = Color.Aqua
            LabelB2.BackColor = Color.Aqua
            LabelB3.BackColor = Color.Aqua
            LabelB4.BackColor = Color.Aqua
            LabelB5.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelI1.Enabled = False AndAlso
           LabelI2.Enabled = False AndAlso
           LabelI3.Enabled = False AndAlso
           LabelI4.Enabled = False AndAlso
           LabelI5.Enabled = False Then
            LabelI1.BackColor = Color.Aqua
            LabelI2.BackColor = Color.Aqua
            LabelI3.BackColor = Color.Aqua
            LabelI4.BackColor = Color.Aqua
            LabelI5.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelN1.Enabled = False AndAlso
            LabelN2.Enabled = False AndAlso
            LabelN3.Enabled = False AndAlso
            LabelN4.Enabled = False Then
            LabelN1.BackColor = Color.Aqua
            LabelN2.BackColor = Color.Aqua
            LabelN3.BackColor = Color.Aqua
            LabelN4.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelG1.Enabled = False AndAlso
           LabelG2.Enabled = False AndAlso
           LabelG3.Enabled = False AndAlso
           LabelG4.Enabled = False AndAlso
           LabelG5.Enabled = False Then
            LabelG1.BackColor = Color.Aqua
            LabelG2.BackColor = Color.Aqua
            LabelG3.BackColor = Color.Aqua
            LabelG4.BackColor = Color.Aqua
            LabelG5.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelO1.Enabled = False AndAlso
           LabelO2.Enabled = False AndAlso
           LabelO3.Enabled = False AndAlso
           LabelO4.Enabled = False AndAlso
           LabelO5.Enabled = False Then
            LabelO1.BackColor = Color.Aqua
            LabelO2.BackColor = Color.Aqua
            LabelO3.BackColor = Color.Aqua
            LabelO4.BackColor = Color.Aqua
            LabelO5.BackColor = Color.Aqua
            Call Winner()
        End If
        ' horizontal labels
        If LabelB1.Enabled = False AndAlso
        LabelI1.Enabled = False AndAlso
        LabelN1.Enabled = False AndAlso
        LabelG1.Enabled = False AndAlso
        LabelO1.Enabled = False Then
            LabelB1.BackColor = Color.Aqua
            LabelI1.BackColor = Color.Aqua
            LabelN1.BackColor = Color.Aqua
            LabelG1.BackColor = Color.Aqua
            LabelO1.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelB2.Enabled = False AndAlso
           LabelI2.Enabled = False AndAlso
           LabelN2.Enabled = False AndAlso
           LabelG2.Enabled = False AndAlso
           LabelO2.Enabled = False Then
            LabelB2.BackColor = Color.Aqua
            LabelI2.BackColor = Color.Aqua
            LabelN2.BackColor = Color.Aqua
            LabelG2.BackColor = Color.Aqua
            LabelO2.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelB3.Enabled = False AndAlso
            LabelI3.Enabled = False AndAlso
            LabelG3.Enabled = False AndAlso
            LabelO3.Enabled = False Then
            LabelB3.BackColor = Color.Aqua
            LabelI3.BackColor = Color.Aqua
            LabelG3.BackColor = Color.Aqua
            LabelO3.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelB4.Enabled = False AndAlso
           LabelI4.Enabled = False AndAlso
           LabelN3.Enabled = False AndAlso
           LabelG4.Enabled = False AndAlso
           LabelO4.Enabled = False Then
            LabelB4.BackColor = Color.Aqua
            LabelI4.BackColor = Color.Aqua
            LabelN3.BackColor = Color.Aqua
            LabelG4.BackColor = Color.Aqua
            LabelO4.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelB5.Enabled = False AndAlso
           LabelI5.Enabled = False AndAlso
           LabelN4.Enabled = False AndAlso
           LabelG5.Enabled = False AndAlso
           LabelO5.Enabled = False Then
            LabelB5.BackColor = Color.Aqua
            LabelI5.BackColor = Color.Aqua
            LabelN4.BackColor = Color.Aqua
            LabelG5.BackColor = Color.Aqua
            LabelO5.BackColor = Color.Aqua
            Call Winner()
        End If
        ' diagonal labels
        If LabelB1.Enabled = False AndAlso
            LabelI2.Enabled = False AndAlso
            LabelG4.Enabled = False AndAlso
            LabelO5.Enabled = False Then
            LabelB1.BackColor = Color.Aqua
            LabelI2.BackColor = Color.Aqua
            LabelG4.BackColor = Color.Aqua
            LabelO5.BackColor = Color.Aqua
            Call Winner()
        ElseIf LabelO1.Enabled = False AndAlso
           LabelG2.Enabled = False AndAlso
           LabelI4.Enabled = False AndAlso
           LabelB5.Enabled = False Then
            LabelB5.BackColor = Color.Aqua
            LabelI4.BackColor = Color.Aqua
            LabelG2.BackColor = Color.Aqua
            LabelO1.BackColor = Color.Aqua
            Call Winner()
        End If

    End Sub

    Private Sub Winner()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        Me.Refresh()
        System.Threading.Thread.Sleep(200)
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        Me.Refresh()
        System.Threading.Thread.Sleep(200)
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        Me.Refresh()
        System.Threading.Thread.Sleep(200)
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        Me.Refresh()
        System.Threading.Thread.Sleep(200)

        MessageBox.Show("BINGO!", "BINGO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
