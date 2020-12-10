<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="7a1b2eb7-00e3-4138-9590-e2f66f0ef09c" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPS" Name="DCMLRACPGProyectoIPS" DisplayName="DCMLRACPGProyectoIPS" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" ProductName="DCMLRACPGProyectoIPS" CompanyName="UPM_IPS" PackageGuid="864bdef2-a50a-4d37-a1d8-9f2398d80509" PackageNamespace="UPM_IPS.DCMLRACPGProyectoIPS" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="0f1bdfa7-8281-43cb-85a3-b4a92daf5b28" Description="The root in which all other elements are embedded. Appears as a diagram." Name="MyDSLModel" DisplayName="My DSLModel" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" />
    <DomainClass Id="81a59436-7b16-4346-92c0-0f32b4cc879b" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.Atributo" Name="Atributo" DisplayName="Atributo" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
      <Properties>
        <DomainProperty Id="2b34b6a9-cf27-40e7-b2bb-eb35a9219fc6" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.Atributo.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="06c9fb9d-7e57-411c-aa84-84b0f51366b9" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.Atributo.Type" Name="Type" DisplayName="Type">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="6ec5e41f-14ed-448a-bf4c-b614ab13d267" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.Atributo.Lenght" Name="Lenght" DisplayName="Lenght">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="f4e3ef88-e6aa-4481-b507-001fd07e5c4d" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.Atributo.Type Name" Name="TypeName" DisplayName="Type Name" Kind="Calculated" IsBrowsable="false" IsUIReadOnly="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
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
    <DomainEnumeration Name="TipoEnumerado1" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.TipoEnumerado1">
      <Literals>
        <EnumerationLiteral Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.TipoEnumerado1.Valoruno" Name="Valoruno" Value="0" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <CompartmentShape Id="264f6fe4-46a7-4b2e-9d1a-39fb6a77fb8b" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.ModelCShape" Name="ModelCShape" DisplayName="Model CShape" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FixedTooltipText="Model CShape" TextColor="21, 42, 43" FillColor="191, 216, 146" OutlineColor="23, 51, 54" InitialHeight="1" OutlineThickness="0.05" FillGradientMode="None" Geometry="Rectangle" />
  </Shapes>
  <XmlSerializationBehavior Name="DCMLRACPGProyectoIPSSerializationBehavior" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
    <ClassData>
      <XmlClassData TypeName="MyDSLModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="myDSLModelMoniker" ElementName="myDSLModel" MonikerTypeName="MyDSLModelMoniker">
        <DomainClassMoniker Name="MyDSLModel" />
      </XmlClassData>
      <XmlClassData TypeName="DCMLRACPGProyectoIPSDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="dCMLRACPGProyectoIPSDiagramMoniker" ElementName="dCMLRACPGProyectoIPSDiagram" MonikerTypeName="DCMLRACPGProyectoIPSDiagramMoniker">
        <DiagramMoniker Name="DCMLRACPGProyectoIPSDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="ModelCShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelCShapeMoniker" ElementName="modelCShape" MonikerTypeName="ModelCShapeMoniker">
        <CompartmentShapeMoniker Name="ModelCShape" />
      </XmlClassData>
      <XmlClassData TypeName="Atributo" MonikerAttributeName="" SerializeId="true" MonikerElementName="atributoMoniker" ElementName="atributo" MonikerTypeName="AtributoMoniker">
        <DomainClassMoniker Name="Atributo" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Atributo/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="type">
            <DomainPropertyMoniker Name="Atributo/Type" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="lenght">
            <DomainPropertyMoniker Name="Atributo/Lenght" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="typeName" Representation="Ignore">
            <DomainPropertyMoniker Name="Atributo/TypeName" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="DCMLRACPGProyectoIPSExplorer" />
  <Diagram Id="8f4c5349-5b0f-417f-b726-07628c29b15a" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDiagram" Name="DCMLRACPGProyectoIPSDiagram" DisplayName="Minimal Language Diagram" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FillColor="224, 231, 182" TextColor="21, 42, 43">
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
    <ToolboxTab TabText="DCMLRACPGProyectoIPS2" />
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="DCMLRACPGProyectoIPSDiagram" />
  </Designer>
  <Explorer ExplorerGuid="a16e949e-8cba-4406-a66b-fc6da5e5bf4d" Title="DCMLRACPGProyectoIPS Explorer">
    <ExplorerBehaviorMoniker Name="DCMLRACPGProyectoIPS/DCMLRACPGProyectoIPSExplorer" />
  </Explorer>
</Dsl>