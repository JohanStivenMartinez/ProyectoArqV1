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

Partial Public Class COMPROBANTE
    Public Property IdComprobante As Integer
    Public Property Monto As Decimal
    Public Property Iva As Decimal
    Public Property FirmaTecnico As Byte()
    Public Property FirmaUsuario As Byte()
    Public Property IdServicio As Integer
    Public Property FechaCreacion As Date
    Public Property FechaImpresion As Date

    Public Overridable Property SERVICIOS As SERVICIOS

End Class
