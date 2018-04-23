Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinSample.Module
	<DefaultClassOptions> _
	Public Class SubDetail
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _SubDetailName As String
		Public Property SubDetailName() As String
			Get
				Return _SubDetailName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("SubDetailName", _SubDetailName, value)
			End Set
		End Property
		Private _Detail As Detail
		<Association("Details-SubDetails")> _
		Public Property Detail() As Detail
			Get
				Return _Detail
			End Get
			Set(ByVal value As Detail)
				SetPropertyValue("Detail", _Detail, value)
			End Set
		End Property
	End Class

End Namespace
