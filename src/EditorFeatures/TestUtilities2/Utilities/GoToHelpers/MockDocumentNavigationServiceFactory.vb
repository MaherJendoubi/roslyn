﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.Host
Imports Microsoft.CodeAnalysis.Host.Mef
Imports Microsoft.CodeAnalysis.Navigation

Namespace Microsoft.CodeAnalysis.Editor.UnitTests.Utilities.GoToHelpers
    <ExportWorkspaceServiceFactory(GetType(IDocumentNavigationService), ServiceLayer.Host), [Shared]>
    <PartNotDiscoverable>
    Friend Class MockDocumentNavigationServiceFactory
        Implements IWorkspaceServiceFactory

        <ImportingConstructor>
        Public Sub New()
        End Sub

        Public Function CreateService(workspaceServices As HostWorkspaceServices) As IWorkspaceService Implements IWorkspaceServiceFactory.CreateService
            Return New MockDocumentNavigationService()
        End Function
    End Class
End Namespace
