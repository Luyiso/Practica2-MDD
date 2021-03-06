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
namespace UPM_IPS.DCMLRACPGProyectoIPS
{
	/// <summary>
	/// DomainRelationship ExampleModelHasElements
	/// Embedding relationship between the Model and Elements
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("bc5815fb-f8e3-4b49-a730-768441542442")]
	public partial class ExampleModelHasElements : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ExampleModelHasElements domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xbc5815fb, 0xf8e3, 0x4b49, 0xa7, 0x30, 0x76, 0x84, 0x41, 0x54, 0x24, 0x42);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ExampleModelHasElements link in the same Partition as the given ExampleModel
		/// </summary>
		/// <param name="source">ExampleModel to use as the source of the relationship.</param>
		/// <param name="target">ExampleElement to use as the target of the relationship.</param>
		public ExampleModelHasElements(ExampleModel source, ExampleElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ExampleModelHasElements.ExampleModelDomainRoleId, source), new DslModeling::RoleAssignment(ExampleModelHasElements.ElementDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleModelHasElements(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleModelHasElements(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleModelHasElements(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleModelHasElements(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region ExampleModel domain role code
		
		/// <summary>
		/// ExampleModel domain role Id.
		/// </summary>
		public static readonly global::System.Guid ExampleModelDomainRoleId = new global::System.Guid(0xfecdedc4, 0xce1d, 0x4887, 0x9e, 0x28, 0x99, 0x01, 0xa1, 0x83, 0xbf, 0xac);
		
		/// <summary>
		/// DomainRole ExampleModel
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements/ExampleModel.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements/ExampleModel.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Elements", PropertyDisplayNameKey="UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements/ExampleModel.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("fecdedc4-ce1d-4887-9e28-9901a183bfac")]
		public virtual ExampleModel ExampleModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleModel)DslModeling::DomainRoleInfo.GetRolePlayer(this, ExampleModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ExampleModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ExampleModel of a ExampleElement
		/// <summary>
		/// Gets ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static ExampleModel GetExampleModel(ExampleElement element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ElementDomainRoleId) as ExampleModel;
		}
		
		/// <summary>
		/// Sets ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetExampleModel(ExampleElement element, ExampleModel newExampleModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ElementDomainRoleId, newExampleModel);
		}
		#endregion
		#region Element domain role code
		
		/// <summary>
		/// Element domain role Id.
		/// </summary>
		public static readonly global::System.Guid ElementDomainRoleId = new global::System.Guid(0x34547f57, 0x7949, 0x447e, 0xb5, 0xa3, 0xf9, 0xef, 0xe5, 0xa9, 0x61, 0x8b);
		
		/// <summary>
		/// DomainRole Element
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements/Element.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements/Element.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "ExampleModel", PropertyDisplayNameKey="UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements/Element.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("34547f57-7949-447e-b5a3-f9efe5a9618b")]
		public virtual ExampleElement Element
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, ElementDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ElementDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Elements of a ExampleModel
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetElements(ExampleModel element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, ExampleModelDomainRoleId);
		}
		#endregion
		#region ExampleModel link accessor
		/// <summary>
		/// Get the list of ExampleModelHasElements links to a ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements> GetLinksToElements ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModel exampleModelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements>(exampleModelInstance, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements.ExampleModelDomainRoleId);
		}
		#endregion
		#region Element link accessor
		/// <summary>
		/// Get the ExampleModelHasElements link to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements GetLinkToExampleModel (global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement elementInstance)
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements>(elementInstance, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements.ElementDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Element not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region ExampleModelHasElements instance accessors
		
		/// <summary>
		/// Get any ExampleModelHasElements links between a given ExampleModel and a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements> GetLinks( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModel source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement target )
		{
			global::System.Collections.Generic.List<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements> outLinks = new global::System.Collections.Generic.List<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements>();
			global::System.Collections.Generic.IList<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements>(source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements.ExampleModelDomainRoleId);
			foreach ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ExampleModelHasElements link between a given ExampleModeland a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements GetLink( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModel source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement target )
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements>(source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements.ExampleModelDomainRoleId);
			foreach ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace UPM_IPS.DCMLRACPGProyectoIPS
{
	/// <summary>
	/// DomainRelationship ExampleElementReferencesTargets
	/// Reference relationship between Elements.
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("83c5b17b-4644-4a0e-9a2f-a50b21eed852")]
	public partial class ExampleElementReferencesTargets : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ExampleElementReferencesTargets domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x83c5b17b, 0x4644, 0x4a0e, 0x9a, 0x2f, 0xa5, 0x0b, 0x21, 0xee, 0xd8, 0x52);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ExampleElementReferencesTargets link in the same Partition as the given ExampleElement
		/// </summary>
		/// <param name="source">ExampleElement to use as the source of the relationship.</param>
		/// <param name="target">ExampleElement to use as the target of the relationship.</param>
		public ExampleElementReferencesTargets(ExampleElement source, ExampleElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ExampleElementReferencesTargets.SourceDomainRoleId, source), new DslModeling::RoleAssignment(ExampleElementReferencesTargets.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleElementReferencesTargets(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleElementReferencesTargets(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleElementReferencesTargets(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleElementReferencesTargets(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0xcaf0c5d3, 0x0b97, 0x40cb, 0x91, 0x8c, 0x83, 0x83, 0x6b, 0x6e, 0xf6, 0xda);
		
		/// <summary>
		/// DomainRole Source
		/// Description for UPM_IPS.DCMLRACPGProyectoIPS.ExampleRelationship.Target
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets/Source.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets/Source.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Targets", PropertyDisplayNameKey="UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("caf0c5d3-0b97-40cb-918c-83836b6ef6da")]
		public virtual ExampleElement Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Sources of a ExampleElement
		/// <summary>
		/// Gets a list of Sources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetSources(ExampleElement element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x16e9f64e, 0xe673, 0x4720, 0x9f, 0x76, 0xfb, 0xb9, 0x58, 0xf0, 0x98, 0x83);
		
		/// <summary>
		/// DomainRole Target
		/// Description for UPM_IPS.DCMLRACPGProyectoIPS.ExampleRelationship.Source
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets/Target.DisplayName", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets/Target.Description", typeof(global::UPM_IPS.DCMLRACPGProyectoIPS.DCMLRACPGProyectoIPSDomainModel), "UPM_IPS.DCMLRACPGProyectoIPS.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Sources", PropertyDisplayNameKey="UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("16e9f64e-e673-4720-9f76-fbb958f09883")]
		public virtual ExampleElement Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Targets of a ExampleElement
		/// <summary>
		/// Gets a list of Targets.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetTargets(ExampleElement element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, SourceDomainRoleId);
		}
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the list of ExampleElementReferencesTargets links to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets> GetLinksToTargets ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement sourceInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets>(sourceInstance, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets.SourceDomainRoleId);
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of ExampleElementReferencesTargets links to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets> GetLinksToSources ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets>(targetInstance, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets.TargetDomainRoleId);
		}
		#endregion
		#region ExampleElementReferencesTargets instance accessors
		
		/// <summary>
		/// Get any ExampleElementReferencesTargets links between a given ExampleElement and a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets> GetLinks( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement target )
		{
			global::System.Collections.Generic.List<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets> outLinks = new global::System.Collections.Generic.List<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets>();
			global::System.Collections.Generic.IList<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets>(source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets.SourceDomainRoleId);
			foreach ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ExampleElementReferencesTargets link between a given ExampleElementand a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets GetLink( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElement target )
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets>(source, global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets.SourceDomainRoleId);
			foreach ( global::UPM_IPS.DCMLRACPGProyectoIPS.ExampleElementReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
