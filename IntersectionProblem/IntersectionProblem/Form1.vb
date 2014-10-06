﻿Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        ' Please write your code here...

        'Function CBool(A)

        ' If B > C Then

        ' End If
        'now looking for absence of intersection, which is easier to find 
        Dim result As String
        If (B < C) Or (D < A) Then
            result = "No Intersection"
        Else


            Dim begPoint As Double
            begPoint = Math.Max(A, C)

            Dim endPoint As Double
            endPoint = Math.Min(B, D)



            result = "The intersection is from" & begPoint & "to" & endPoint


            txtResult.Text = result
        End If
    End Sub

    Function FindIntersection(A As Double, B As Double, C As Double, D As Double) As String
        Dim result As String
        If (B < C) Or (D < A) Then
            result = "No Intersection"
        Else

            'brought along the code from befroe in to 
            Dim begPoint As Double
            begPoint = Math.Max(A, C)

            Dim endPoint As Double
            endPoint = Math.Min(B, D)


    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
