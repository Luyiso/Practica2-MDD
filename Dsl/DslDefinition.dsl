<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="7a1b2eb7-00e3-4138-9590-e2f66f0ef09c" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPS" Name="DCMLRACPGProyectoIPS" DisplayName="DCMLRACPGProyectoIPS" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" ProductName="DCMLRACPGProyectoIPS" CompanyName="UPM_IPS" PackageGuid="864bdef2-a50a-4d37-a1d8-9f2398d80509" PackageNamespace="UPM_IPS.DCMLRACPGProyectoIPS" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="0f1bdfa7-8281-43cb-85a3-b4a92daf5b28" Description="The root in which all other elements are embedded. Appears as a diagram." Name="MyDSLModel" DisplayName="My DSLModel" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" />
  </Classes>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="DomainEnumeration1" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DomainEnumeration1">
      <Literals>
        <EnumerationLiteral Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DomainEnumeration1.EnumerationLiteral1" Name="EnumerationLiteral1" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="DomainEnumeration2" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DomainEnumeration2" />
  </Types>
  <XmlSerializationBehavior Name="DCMLRACPGProyectoIPSSerializationBehavior" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
    <ClassData>
      <XmlClassData TypeName="MyDSLModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="myDSLModelMoniker" ElementName="myDSLModel" MonikerTypeName="MyDSLModelMoniker">
        <DomainClassMoniker Name="MyDSLModel" />
      </XmlClassData>
      <XmlClassData TypeName="DCMLRACPGProyectoIPSDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="dCMLRACPGProyectoIPSDiagramMoniker" ElementName="dCMLRACPGProyectoIPSDiagram" MonikerTypeName="DCMLRACPGProyectoIPSDiagramMoniker">
        <DiagramMoniker Name="DCMLRACPGProyectoIPSDiagram" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="DCMLRACPGProyectoIPSExplorer" />
  <Diagram Id="8f4c5349-5b0f-417f-b726-07628c29b15a" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDiagram" Name="DCMLRACPGProyectoIPSDiagram" DisplayName="Minimal Language Diagram" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FillColor="PowderBlue" TextColor="DarkCyan">
    <Class>
      <DomainClassMoniker Name="MyDSLModel" />
    </Class>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="DCMLRACPG_ProyIPS" EditorGuid="74060ce3-65a4-418f-9013-79ed1166bd5c">
    <RootClass>
      <DomainClassMoniker Name="MyDSLModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="DCMLRACPGProyectoIPSSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="DCMLRACPGProyectoIPS">
      <ElementTool Name="ExampleElement" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="ExampleElement" Tooltip="Create an ExampleElement" HelpKeyword="CreateExampleClassF1Keyword" />
      <ConnectionTool Name="ConnectionTool1" ToolboxIcon="D:\Documentos\BDA\Practica2-MDD\Resources\Relation.bmp" Caption="ConnectionTool1" Tooltip="Connection Tool1" HelpKeyword="ConnectionTool1" ReversesDirection="true" />
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="DCMLRACPGProyectoIPSDiagram" />
  </Designer>
  <Explorer ExplorerGuid="a16e949e-8cba-4406-a66b-fc6da5e5bf4d" Title="DCMLRACPGProyectoIPS Explorer">
    <ExplorerBehaviorMoniker Name="DCMLRACPGProyectoIPS/DCMLRACPGProyectoIPSExplorer" />
  </Explorer>
</Dsl>