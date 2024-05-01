// <auto-generated/>
using Clerk.Net.Client.Templates.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Templates {
    /// <summary>
    /// Builds and executes requests for operations under \templates
    /// </summary>
    public class TemplatesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Clerk.Net.Client.templates.item collection</summary>
        /// <param name="position">The type of templates to list (email or SMS)</param>
        /// <returns>A <see cref="WithTemplate_typeItemRequestBuilder"/></returns>
        public WithTemplate_typeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("template_type", position);
                return new WithTemplate_typeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="TemplatesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TemplatesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/templates", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TemplatesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TemplatesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/templates", rawUrl)
        {
        }
    }
}
