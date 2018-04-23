Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.Data.Filtering

Namespace WinSample.Module
	<DefaultClassOptions> _
	Public Class Master
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _MasterName As String
		Public Property MasterName() As String
			Get
				Return _MasterName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("MasterName", _MasterName, value)
			End Set
		End Property
		<Association("Master-Details")> _
		Public ReadOnly Property Details() As XPCollection(Of Detail)
			Get
				Return GetCollection(Of Detail)("Details")
			End Get
		End Property
		Private _SubDetails As XPCollection(Of SubDetail)
		Public ReadOnly Property SubDetails() As XPCollection(Of SubDetail)
			Get
				If _SubDetails Is Nothing Then
					UpdateSubDetails()
				End If
				Return _SubDetails
			End Get
		End Property
		Public Sub UpdateSubDetails()
			If Details.Count > 0 Then
				_SubDetails = New XPCollection(Of SubDetail)(Session, New InOperator("Detail", Details))
			Else
				_SubDetails = Nothing
			End If
		End Sub
		Protected Overrides Overloads Function CreateCollection(Of T)(ByVal [property] As DevExpress.Xpo.Metadata.XPMemberInfo) As XPCollection(Of T)
			Dim collection As XPCollection(Of T) = MyBase.CreateCollection(Of T)([property])
			If [property].Name = "Details" Then
				AddHandler collection.CollectionChanged, AddressOf Details_CollectionChanged
			End If
			Return collection
		End Function
		Private Sub Details_CollectionChanged(ByVal sender As Object, ByVal e As XPCollectionChangedEventArgs)
			UpdateSubDetails()
			OnChanged("SubDetails")
		End Sub
	End Class

End Namespace