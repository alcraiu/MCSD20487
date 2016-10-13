﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



Namespace Microsoft.Samples.Security

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.Samples.Security", ConfigurationName:="Microsoft.Samples.Security.ICalculatorDuplex", CallbackContract:=GetType(Microsoft.Samples.Security.ICalculatorDuplexCallback), SessionMode:=System.ServiceModel.SessionMode.Required)> _
    Public Interface ICalculatorDuplex

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/Clear")> _
        Sub Clear()

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/AddTo")> _
        Sub AddTo(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/SubtractFrom")> _
        Sub SubtractFrom(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/MultiplyBy")> _
        Sub MultiplyBy(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/DivideBy")> _
        Sub DivideBy(ByVal n As Double)
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Public Interface ICalculatorDuplexCallback

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/Result")> _
        Sub Result(ByVal result As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.Samples.Security/ICalculatorDuplex/Equation")> _
        Sub Equation(ByVal eqn As String)
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Public Interface ICalculatorDuplexChannel
        Inherits Microsoft.Samples.Security.ICalculatorDuplex, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Partial Public Class CalculatorDuplexClient
        Inherits System.ServiceModel.DuplexClientBase(Of Microsoft.Samples.Security.ICalculatorDuplex)
        Implements Microsoft.Samples.Security.ICalculatorDuplex

        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext)
            MyBase.New(callbackInstance)
        End Sub

        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String)
            MyBase.New(callbackInstance, endpointConfigurationName)
        End Sub

        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, binding, remoteAddress)
        End Sub

        Public Sub Clear() Implements Microsoft.Samples.Security.ICalculatorDuplex.Clear
            MyBase.Channel.Clear()
        End Sub

        Public Sub AddTo(ByVal n As Double) Implements Microsoft.Samples.Security.ICalculatorDuplex.AddTo
            MyBase.Channel.AddTo(n)
        End Sub

        Public Sub SubtractFrom(ByVal n As Double) Implements Microsoft.Samples.Security.ICalculatorDuplex.SubtractFrom
            MyBase.Channel.SubtractFrom(n)
        End Sub

        Public Sub MultiplyBy(ByVal n As Double) Implements Microsoft.Samples.Security.ICalculatorDuplex.MultiplyBy
            MyBase.Channel.MultiplyBy(n)
        End Sub

        Public Sub DivideBy(ByVal n As Double) Implements Microsoft.Samples.Security.ICalculatorDuplex.DivideBy
            MyBase.Channel.DivideBy(n)
        End Sub
    End Class
End Namespace
