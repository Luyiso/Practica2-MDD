﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace UPM_IPS.DCMLRACPGProyectoIPS
{
	/// <summary>
	/// DomainClass ExampleConnector
	/// Connector between the ExampleShapes. Represents ExampleRelationships on the
	/// Diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleConnector.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleConnector.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("36de7fc2-1221-411d-93cd-1515b126a48b")]
	public partial class ExampleConnector : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ExampleConnector.
		/// </summary>
		public static DslDiagrams::Decorator FindExampleConnectorDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Color = global::System.Drawing.Color.FromArgb(255, 113, 111, 110);
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLineDecorator, linePen);
			linePen.Width = 0.01f;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
			DslDiagrams::BrushSettings lineBrush = new DslDiagrams::BrushSettings();
			lineBrush.Color = global::System.Drawing.Color.FromArgb(255, 113, 111, 110);
			classStyleSet.OverrideBrush(DslDiagrams::DiagramBrushes.ConnectionLineDecorator, lineBrush);
			
		}
		
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorEmptyArrow, new DslDiagrams::SizeD(0.1,0.1), false);
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ExampleConnector domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x36de7fc2, 0x1221, 0x411d, 0x93, 0xcd, 0x15, 0x15, 0xb1, 0x26, 0xa4, 0x8b);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ExampleConnector(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ExampleConnector(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}