'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class MONITOREO
    Public Property IdMonitoreo As Integer
    Public Property IdServicio As Integer
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property MetrosRecorridos As Decimal

    Public Overridable Property SERVICIOS As SERVICIOS
    Public Overridable Property RECORRIDO As ICollection(Of RECORRIDO) = New HashSet(Of RECORRIDO)

End Class
