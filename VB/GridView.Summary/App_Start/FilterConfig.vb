Imports System.Web
Imports System.Web.Mvc

Namespace GridView.Summary
    Public Class FilterConfig
        Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
            filters.Add(New HandleErrorAttribute())
        End Sub
    End Class
End Namespace
