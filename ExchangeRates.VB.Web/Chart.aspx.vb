﻿Public Class Chart
   Inherits Page

   Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

   End Sub
   Protected Sub btnLoad_Click(sender As Object, e As EventArgs) Handles BackButton.Click
      Server.Transfer("Index.aspx")
   End Sub
End Class