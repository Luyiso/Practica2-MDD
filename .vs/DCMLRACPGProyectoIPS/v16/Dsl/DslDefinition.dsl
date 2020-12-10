<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="7a1b2eb7-00e3-4138-9590-e2f66f0ef09c" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPS" Name="DCMLRACPGProyectoIPS" DisplayName="DCMLRACPGProyectoIPS" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" ProductName="DCMLRACPGProyectoIPS" CompanyName="UPM_IPS" PackageGuid="864bdef2-a50a-4d37-a1d8-9f2398d80509" PackageNamespace="UPM_IPS.DCMLRACPGProyectoIPS" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="0f1bdfa7-8281-43cb-85a3-b4a92daf5b28" Description="The root in which all other elements are embedded. Appears as a diagram." Name="ExampleModel" DisplayName="Example Model" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="ExampleElement" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ExampleModelHasElements.Elements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="14b2f7c8-155d-40e5-9afc-f4d5357c6db7" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="ExampleElement" DisplayName="Example Element" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
      <Properties>
        <DomainProperty Id="b5c57801-d6b3-454c-b553-1d9a2e40f652" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement.Name" Name="Name" DisplayName="Name" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="ee9f05ad-b14a-47ab-a93b-ad737f0d63d4" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement.Domain Property1" Name="DomainProperty1" DisplayName="Domain Property1">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="bc5815fb-f8e3-4b49-a730-768441542442" Description="Embedding relationship between the Model and Elements" Name="ExampleModelHasElements" DisplayName="Example Model Has Elements" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" IsEmbedding="true">
      <Source>
        <DomainRole Id="fecdedc4-ce1d-4887-9e28-9901a183bfac" Description="" Name="ExampleModel" DisplayName="Example Model" PropertyName="Elements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Elements">
          <RolePlayer>
            <DomainClassMoniker Name="ExampleModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="34547f57-7949-447e-b5a3-f9efe5a9618b" Description="" Name="Element" DisplayName="Element" PropertyName="ExampleModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Example Model">
          <RolePlayer>
            <DomainClassMoniker Name="ExampleElement" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="83c5b17b-4644-4a0e-9a2f-a50b21eed852" Description="Reference relationship between Elements." Name="ExampleElementReferencesTargets" DisplayName="Example Element References Targets" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
      <Source>
        <DomainRole Id="caf0c5d3-0b97-40cb-918c-83836b6ef6da" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.ExampleRelationship.Target" Name="Source" DisplayName="Source" PropertyName="Targets" PropertyDisplayName="Targets">
          <RolePlayer>
            <DomainClassMoniker Name="ExampleElement" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="16e9f64e-e673-4720-9f76-fbb958f09883" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.ExampleRelationship.Source" Name="Target" DisplayName="Target" PropertyName="Sources" PropertyDisplayName="Sources">
          <RolePlayer>
            <DomainClassMoniker Name="ExampleElement" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
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
    <ExternalType Name="Color" Namespace="System.Drawing" />
  </Types>
  <Shapes>
    <GeometryShape Id="cf0a3412-19c5-4235-958a-64244bab8e23" Description="Shape used to represent ExampleElements on a Diagram." Name="ExampleShape" DisplayName="Example Shape" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FixedTooltipText="Example Shape" FillColor="242, 239, 229" OutlineColor="113, 111, 110" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" Geometry="Rectangle">
      <Notes>The shape has a text decorator used to display the Name property of the mapped ExampleElement.</Notes>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="3e68c1fe-d8d0-47df-b2ec-3196a7271ad6" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.GeometryShape1" Name="GeometryShape1" DisplayName="Geometry Shape1" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FixedTooltipText="Geometry Shape1" InitialHeight="1" Geometry="Rectangle" />
    <CompartmentShape Id="4451c0c0-8283-4a55-a568-9d73a60089af" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.CompartmentShape1" Name="CompartmentShape1" DisplayName="Compartment Shape1" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FixedTooltipText="Compartment Shape1" InitialHeight="1" Geometry="Rectangle">
      <Properties>
        <DomainProperty Id="2edededc-9337-4b12-acd4-a163fa4bd176" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.CompartmentShape1.Blue" Name="blue" DisplayName="Blue" Kind="CustomStorage">
          <Type>
            <ExternalTypeMoniker Name="/System.Drawing/Color" />
          </Type>
        </DomainProperty>
      </Properties>
      <Compartment Name="HolaSoyUnCompartimiento" />
    </CompartmentShape>
  </Shapes>
  <Connectors>
    <Connector Id="36de7fc2-1221-411d-93cd-1515b126a48b" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="ExampleConnector" DisplayName="Example Connector" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FixedTooltipText="Example Connector" Color="113, 111, 110" TargetEndStyle="EmptyArrow" Thickness="0.01" />
  </Connectors>
  <XmlSerializationBehavior Name="DCMLRACPGProyectoIPSSerializationBehavior" Namespace="UPM_IPS.DCMLRACPGProyectoIPS">
    <ClassData>
      <XmlClassData TypeName="ExampleModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleModelMoniker" ElementName="exampleModel" MonikerTypeName="ExampleModelMoniker">
        <DomainClassMoniker Name="ExampleModel" />
        <ElementData>
          <XmlRelationshipData RoleElementName="elements">
            <DomainRelationshipMoniker Name="ExampleModelHasElements" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ExampleElement" MonikerAttributeName="name" SerializeId="true" MonikerElementName="exampleElementMoniker" ElementName="exampleElement" MonikerTypeName="ExampleElementMoniker">
        <DomainClassMoniker Name="ExampleElement" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="ExampleElement/Name" />
          </XmlPropertyData>
          <XmlRelationshipData RoleElementName="targets">
            <DomainRelationshipMoniker Name="ExampleElementReferencesTargets" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="domainProperty1">
            <DomainPropertyMoniker Name="ExampleElement/DomainProperty1" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ExampleModelHasElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleModelHasElementsMoniker" ElementName="exampleModelHasElements" MonikerTypeName="ExampleModelHasElementsMoniker">
        <DomainRelationshipMoniker Name="ExampleModelHasElements" />
      </XmlClassData>
      <XmlClassData TypeName="ExampleElementReferencesTargets" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleElementReferencesTargetsMoniker" ElementName="exampleElementReferencesTargets" MonikerTypeName="ExampleElementReferencesTargetsMoniker">
        <DomainRelationshipMoniker Name="ExampleElementReferencesTargets" />
      </XmlClassData>
      <XmlClassData TypeName="ExampleShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleShapeMoniker" ElementName="exampleShape" MonikerTypeName="ExampleShapeMoniker">
        <GeometryShapeMoniker Name="ExampleShape" />
      </XmlClassData>
      <XmlClassData TypeName="ExampleConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleConnectorMoniker" ElementName="exampleConnector" MonikerTypeName="ExampleConnectorMoniker">
        <ConnectorMoniker Name="ExampleConnector" />
      </XmlClassData>
      <XmlClassData TypeName="DCMLRACPGProyectoIPSDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="dCMLRACPGProyectoIPSDiagramMoniker" ElementName="dCMLRACPGProyectoIPSDiagram" MonikerTypeName="DCMLRACPGProyectoIPSDiagramMoniker">
        <DiagramMoniker Name="DCMLRACPGProyectoIPSDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="GeometryShape1" MonikerAttributeName="" SerializeId="true" MonikerElementName="geometryShape1Moniker" ElementName="geometryShape1" MonikerTypeName="GeometryShape1Moniker">
        <GeometryShapeMoniker Name="GeometryShape1" />
      </XmlClassData>
      <XmlClassData TypeName="CompartmentShape1" MonikerAttributeName="" SerializeId="true" MonikerElementName="compartmentShape1Moniker" ElementName="compartmentShape1" MonikerTypeName="CompartmentShape1Moniker">
        <CompartmentShapeMoniker Name="CompartmentShape1" />
        <ElementData>
          <XmlPropertyData XmlName="blue">
            <DomainPropertyMoniker Name="CompartmentShape1/blue" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="DCMLRACPGProyectoIPSExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="ExampleElementReferencesTargetsBuilder">
      <Notes>Provides for the creation of an ExampleRelationship by pointing at two ExampleElements.</Notes>
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="ExampleElementReferencesTargets" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ExampleElement" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ExampleElement" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="8f4c5349-5b0f-417f-b726-07628c29b15a" Description="Description for UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDiagram" Name="DCMLRACPGProyectoIPSDiagram" DisplayName="Minimal Language Diagram" Namespace="UPM_IPS.DCMLRACPGProyectoIPS" FillColor="PowderBlue" TextColor="DarkCyan">
    <Class>
      <DomainClassMoniker Name="ExampleModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="ExampleElement" />
        <ParentElementPath>
          <DomainPath>ExampleModelHasElements.ExampleModel/!ExampleModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="ExampleShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="ExampleElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="ExampleShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="ExampleConnector" />
        <DomainRelationshipMoniker Name="ExampleElementReferencesTargets" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="DCMLRACPG_ProyIPS" EditorGuid="74060ce3-65a4-418f-9013-79ed1166bd5c">
    <RootClass>
      <DomainClassMoniker Name="ExampleModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="DCMLRACPGProyectoIPSSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="DCMLRACPGProyectoIPS">
      <ElementTool Name="ExampleElement" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="ExampleElement" Tooltip="Create an ExampleElement" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="ExampleElement" />
      </ElementTool>
      <ConnectionTool Name="ExampleRelationship" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="ExampleRelationship" Tooltip="Drag between ExampleElements to create an ExampleRelationship" HelpKeyword="ConnectExampleRelationF1Keyword">
        <ConnectionBuilderMoniker Name="DCMLRACPGProyectoIPS/ExampleElementReferencesTargetsBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="DCMLRACPGProyectoIPSDiagram" />
  </Designer>
  <Explorer ExplorerGuid="a16e949e-8cba-4406-a66b-fc6da5e5bf4d" Title="DCMLRACPGProyectoIPS Explorer">
    <ExplorerBehaviorMoniker Name="DCMLRACPGProyectoIPS/DCMLRACPGProyectoIPSExplorer" />
  </Explorer>
</Dsl>