// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.TransformApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for Cat <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/cat-transforms.html</para></summary>
	public partial class CatTransformDescriptor : RequestDescriptorBase<CatTransformDescriptor, CatTransformRequestParameters, ICatTransformRequest>, ICatTransformRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformCat;
		///<summary>/_cat/transforms</summary>
		public CatTransformDescriptor(): base()
		{
		}

		///<summary>/_cat/transforms/{transform_id}</summary>
		///<param name = "transformId">Optional, accepts null</param>
		public CatTransformDescriptor(string_ transformId): base(r => r.Optional("transform_id", transformId))
		{
		}

		// values part of the url path
		string_ ICatTransformRequest.TransformId => Self.RouteValues.Get<string_>("transform_id");
		///<summary>The id of the transform for which to get stats. '_all' or '*' implies all transforms</summary>
		public CatTransformDescriptor TransformId(string_ transformId) => Assign(transformId, (a, v) => a.RouteValues.Optional("transform_id", v));
		// Request parameters
		///<summary>Whether to ignore if a wildcard expression matches no transforms. (This includes `_all` string or when no transforms have been specified)</summary>
		public CatTransformDescriptor AllowNoMatch(bool? allownomatch = true) => Qs("allow_no_match", allownomatch);
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public CatTransformDescriptor Format(string format) => Qs("format", format);
		///<summary>skips a number of transform configs, defaults to 0</summary>
		public CatTransformDescriptor From(int? from) => Qs("from", from);
		///<summary>Comma-separated list of column names to display</summary>
		public CatTransformDescriptor Headers(params string[] headers) => Qs("h", headers);
		///<summary>Return help information</summary>
		public CatTransformDescriptor Help(bool? help = true) => Qs("help", help);
		///<summary>specifies a max number of transforms to get, defaults to 100</summary>
		public CatTransformDescriptor Size(int? size) => Qs("size", size);
		///<summary>Comma-separated list of column names or column aliases to sort by</summary>
		public CatTransformDescriptor SortByColumns(params string[] sortbycolumns) => Qs("s", sortbycolumns);
		///<summary>Verbose mode. Display column headers</summary>
		public CatTransformDescriptor Verbose(bool? verbose = true) => Qs("v", verbose);
		[Obsolete("Unmapped, blacklist this API in CodeConfiguration.cs or implement CatTransformDescriptor and CatTransformRequest in a file called CatTransformRequest.cs in NEST's codebase", true)]
		public bool IsUnmapped => true;
		public bool UseIsUnmapped => IsUnmapped;
	}
}